import esbuild from "esbuild";
import { existsSync, readdirSync, statSync, mkdirSync, writeFileSync, rmSync } from "fs";
import { join, relative, resolve } from "path";
import { exit } from "process";

if (process.argv.slice(2).some(x => x == "--trigger")) {
    if (existsSync('typings/serenity.corelib/_trigger.ts'))
        rmSync('typings/serenity.corelib/_trigger.ts')
    else {
        if (!existsSync('typings/serenity.corelib/'))
            mkdirSync('typings/serenity.corelib/');
        writeFileSync('typings/serenity.corelib/_trigger.ts', '// for triggering build');
    }
    exit(0);
}

let prod = process.argv.slice(2).some(x => x == "--prod");

const outDir = 'wwwroot/esm';

var entryPoints = scanDir('Modules').filter(p =>
    p.match(/(Page)\.ts$/)).map(p => 'Modules/' + p);

await esbuild.build({
    absWorkingDir: resolve('./'),
    bundle: true,
    chunkNames: '_chunks/[name]-[hash]',
    color: true,
    metafile: true,
    minify: true,
    sourcemap: true,
    entryPoints: entryPoints,
    format: 'esm',
    logLevel: 'info',
    outdir: outDir,
    outbase: "./",
    splitting: !process.argv.slice(2).some(x => x == "--nosplit"),
    target: 'es6',
    watch: process.argv.slice(2).some(x => x == "--watch"),
    plugins: [
        cleanPlugin(),
        importAsGlobals({
            "@serenity-is/corelib": "Serenity",
            "@serenity-is/corelib/q": "Q",
            "@serenity-is/corelib/slick": "Slick",
            "@serenity-is/sleekgrid": "Slick",
            "@serenity-is/extensions": "Serenity.Extensions",
            "@serenity-is/pro.extensions": "Serenity"
        })
    ]
});

function scanDir(dir, org) {
    return readdirSync(dir).reduce((files, file) => {
        const absolute = join(dir, file);
        return [...files, ...(statSync(absolute).isDirectory()
            ? scanDir(absolute, org || dir)
            : [relative(org || dir, absolute)])]
    }, []);
}

// https://github.com/evanw/esbuild/issues/337
function importAsGlobals(mapping) {
    const escRe = (s) => s.replace(/[-\/\\^$*+?.()|[\]{}]/g, "\\$&");
    const filter = new RegExp(Object.keys(mapping).map((mod) =>
        `^${escRe(mod)}$`).join("|"));

    return {
        name: "global-imports",
        setup(build) {
            build.onResolve({ filter }, (args) => {
                if (!mapping[args.path]) 
                    throw new Error("Unknown global: " + args.path);
                return { path: args.path, namespace: "external-global" };
            });

            build.onLoad({ filter, namespace: "external-global" },
                async (args) => {
                    const global = mapping[args.path];
                    return { contents: `module.exports = ${global};`, loader: "js" };
                });
        }
    };
}

function cleanPlugin() {
    return {
        name: 'clean',
        setup(build) {
            build.onEnd(result => {
                try {
                    const { outputs } = result.metafile ?? {};
                    if (!outputs || !existsSync(build.initialOptions.outDir))
                        return;
                    const outputFiles = new Set(Object.keys(outputs));
                    scanDir(build.initialOptions.outdir).forEach(file => {
                        if (!outputFiles.has(join(outDir, file).replace(/\\/g, '/')))
                            rmSync(join(outDir, file));
                    });
                } catch (e) {
                    console.error(`esbuild clean: ${e}`);
                }
            });
        }
    }
}
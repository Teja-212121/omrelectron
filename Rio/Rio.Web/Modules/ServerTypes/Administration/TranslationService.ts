﻿import { TranslationListRequest } from "./TranslationListRequest";
import { ListResponse, SaveResponse } from "@serenity-is/corelib";
import { TranslationItem } from "./TranslationItem";
import { ServiceOptions, serviceRequest } from "@serenity-is/corelib/q";
import { TranslationUpdateRequest } from "./TranslationUpdateRequest";

export namespace TranslationService {
    export const baseUrl = 'Administration/Translation';

    export declare function List(request: TranslationListRequest, onSuccess?: (response: ListResponse<TranslationItem>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: TranslationUpdateRequest, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export declare const enum Methods {
        List = "Administration/Translation/List",
        Update = "Administration/Translation/Update"
    }

    [
        'List', 
        'Update'
    ].forEach(x => {
        (<any>TranslationService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}

import"../../../_chunks/chunk-CXKY5VTN.js";import{a as u,b as h,c as g,e as p,r as l}from"../../../_chunks/chunk-QA2B7C3R.js";var m=u(g(),1);var s=u(p(),1),t=u(g(),1);var o=class extends s.EntityGrid{constructor(e){super(e);this.element.on("keyup."+this.uniqueName+" change."+this.uniqueName,"input.custom-text",r=>{var i=(0,t.trimToNull)($(r.target).val());i===""&&(i=null),this.view.getItemById($(r.target).data("key")).CustomText=i,this.hasChanges=!0})}getIdProperty(){return"Key"}getLocalTextPrefix(){return"Administration.Translation"}getService(){return l.baseUrl}onClick(e,r,i){if(super.onClick(e,r,i),e.isDefaultPrevented())return;let a=this.itemAt(r),n;if($(e.target).hasClass("source-text")){if(e.preventDefault(),n=()=>{a.CustomText=a.SourceText,this.view.updateItem(a.Key,a),this.hasChanges=!0},(0,t.isTrimmedEmpty)(a.CustomText)||(0,t.trimToEmpty)(a.CustomText)===(0,t.trimToEmpty)(a.SourceText)){n();return}(0,t.confirm)((0,t.text)("Db.Administration.Translation.OverrideConfirmation"),n);return}if($(e.target).hasClass("target-text")){if(e.preventDefault(),n=()=>{a.CustomText=a.TargetText,this.view.updateItem(a.Key,a),this.hasChanges=!0},(0,t.isTrimmedEmpty)(a.CustomText)||(0,t.trimToEmpty)(a.CustomText)===(0,t.trimToEmpty)(a.TargetText)){n();return}(0,t.confirm)((0,t.text)("Db.Administration.Translation.OverrideConfirmation"),n);return}}getColumns(){var e=[];return e.push({field:"Key",width:300,sortable:!1}),e.push({field:"SourceText",width:300,sortable:!1,format:r=>(0,t.outerHtml)($("<a/>").addClass("source-text").text(r.value||""))}),e.push({field:"CustomText",width:300,sortable:!1,format:r=>(0,t.outerHtml)($("<input/>").addClass("custom-text").attr("value",r.value).attr("type","text").attr("data-key",r.item.Key))}),e.push({field:"TargetText",width:300,sortable:!1,format:r=>(0,t.outerHtml)($("<a/>").addClass("target-text").text(r.value||""))}),e}createToolbarExtensions(){super.createToolbarExtensions();let e={lookupKey:"Administration.Language"};this.sourceLanguage=s.Widget.create({type:s.LookupEditor,element:r=>r.appendTo(this.toolbar.element).attr("placeholder","--- "+(0,t.text)("Db.Administration.Translation.SourceLanguage")+" ---"),options:e}),this.sourceLanguage.changeSelect2(r=>{this.hasChanges?this.saveChanges(this.targetLanguageKey).then(()=>this.refresh()):this.refresh()}),this.targetLanguage=s.Widget.create({type:s.LookupEditor,element:r=>r.appendTo(this.toolbar.element).attr("placeholder","--- "+(0,t.text)("Db.Administration.Translation.TargetLanguage")+" ---"),options:e}),this.targetLanguage.changeSelect2(r=>{this.hasChanges?this.saveChanges(this.targetLanguageKey).then(()=>this.refresh()):this.refresh()})}saveChanges(e){var r={};for(let i of this.getItems())r[i.Key]=i.CustomText;return Promise.resolve(l.Update({TargetLanguageID:e,Translations:r})).then(()=>{this.hasChanges=!1,e=(0,t.trimToNull)(e)||"invariant",(0,t.notifySuccess)('User translations in "'+e+'" language are saved to "user.texts.'+e+'.json" file under "~/App_Data/texts/"',"")})}onViewSubmit(){var e=this.view.params;return e.SourceLanguageID=this.sourceLanguage.value,this.targetLanguageKey=this.targetLanguage.value||"",e.TargetLanguageID=this.targetLanguageKey,this.hasChanges=!1,super.onViewSubmit()}getButtons(){return[{title:(0,t.text)("Db.Administration.Translation.SaveChangesButton"),onClick:e=>this.saveChanges(this.targetLanguageKey).then(()=>this.refresh()),cssClass:"apply-changes-button"}]}createQuickSearchInput(){s.GridUtils.addQuickSearchInputCustom(this.toolbar.element,(e,r)=>{this.searchText=r,this.view.setItems(this.view.getItems(),!0)})}onViewFilter(e){if(!super.onViewFilter(e))return!1;if(!this.searchText)return!0;var r=Select2.util.stripDiacritics,i=r(this.searchText).toLowerCase();function a(n){return n?n.toLowerCase().indexOf(i)>=0:!1}return(0,t.isEmptyOrNull)(i)||a(e.Key)||a(e.SourceText)||a(e.TargetText)||a(e.CustomText)}usePager(){return!1}};o=h([s.Decorators.registerClass()],o);$(function(){(0,m.initFullHeightGridPage)(new o($("#GridDiv")).element)});
//# sourceMappingURL=TranslationPage.js.map

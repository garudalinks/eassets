import { ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { TranslationListRequest } from "../Extensions/TranslationListRequest";
import { TranslationListResponse } from "../Extensions/TranslationListResponse";
import { TranslationUpdateRequest } from "../Extensions/TranslationUpdateRequest";
import { ServiceResponse } from "../Services/ServiceResponse";

export namespace TranslationService {
    export const baseUrl = 'Administration/Translation';

    export declare function List(request: TranslationListRequest, onSuccess?: (response: TranslationListResponse) => void, opt?: ServiceOptions<any>): PromiseLike<TranslationListResponse>;
    export declare function Update(request: TranslationUpdateRequest, onSuccess?: (response: ServiceResponse) => void, opt?: ServiceOptions<any>): PromiseLike<ServiceResponse>;

    export const Methods = {
        List: "Administration/Translation/List",
        Update: "Administration/Translation/Update"
    } as const;

    [
        'List', 
        'Update'
    ].forEach(x => {
        (<any>TranslationService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
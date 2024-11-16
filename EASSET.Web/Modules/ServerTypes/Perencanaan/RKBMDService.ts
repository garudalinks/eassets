import { ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { DeleteRequest } from "../Services/DeleteRequest";
import { DeleteResponse } from "../Services/DeleteResponse";
import { ListRequest } from "../Services/ListRequest";
import { ListResponse } from "../Services/ListResponse";
import { RetrieveRequest } from "../Services/RetrieveRequest";
import { RetrieveResponse } from "../Services/RetrieveResponse";
import { SaveRequest } from "../Services/SaveRequest";
import { SaveResponse } from "../Services/SaveResponse";
import { RKBMDRow } from "./RKBMDRow";

export namespace RKBMDService {
    export const baseUrl = 'Perencanaan/RKBMD';

    export declare function Create(request: SaveRequest<RKBMDRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<RKBMDRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<RKBMDRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<RKBMDRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<RKBMDRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<RKBMDRow>>;

    export const Methods = {
        Create: "Perencanaan/RKBMD/Create",
        Update: "Perencanaan/RKBMD/Update",
        Delete: "Perencanaan/RKBMD/Delete",
        Retrieve: "Perencanaan/RKBMD/Retrieve",
        List: "Perencanaan/RKBMD/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>RKBMDService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
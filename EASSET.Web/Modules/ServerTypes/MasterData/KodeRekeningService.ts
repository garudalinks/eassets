import { ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { DeleteRequest } from "../Services/DeleteRequest";
import { DeleteResponse } from "../Services/DeleteResponse";
import { ListRequest } from "../Services/ListRequest";
import { ListResponse } from "../Services/ListResponse";
import { RetrieveRequest } from "../Services/RetrieveRequest";
import { RetrieveResponse } from "../Services/RetrieveResponse";
import { SaveRequest } from "../Services/SaveRequest";
import { SaveResponse } from "../Services/SaveResponse";
import { KodeRekeningRow } from "./KodeRekeningRow";

export namespace KodeRekeningService {
    export const baseUrl = 'MasterData/KodeRekening';

    export declare function Create(request: SaveRequest<KodeRekeningRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<KodeRekeningRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<KodeRekeningRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<KodeRekeningRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<KodeRekeningRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<KodeRekeningRow>>;

    export const Methods = {
        Create: "MasterData/KodeRekening/Create",
        Update: "MasterData/KodeRekening/Update",
        Delete: "MasterData/KodeRekening/Delete",
        Retrieve: "MasterData/KodeRekening/Retrieve",
        List: "MasterData/KodeRekening/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>KodeRekeningService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
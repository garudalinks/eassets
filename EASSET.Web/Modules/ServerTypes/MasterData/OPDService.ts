import { ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { DeleteRequest } from "../Services/DeleteRequest";
import { DeleteResponse } from "../Services/DeleteResponse";
import { ListRequest } from "../Services/ListRequest";
import { ListResponse } from "../Services/ListResponse";
import { RetrieveRequest } from "../Services/RetrieveRequest";
import { RetrieveResponse } from "../Services/RetrieveResponse";
import { SaveRequest } from "../Services/SaveRequest";
import { SaveResponse } from "../Services/SaveResponse";
import { OPDRow } from "./OPDRow";

export namespace OPDService {
    export const baseUrl = 'MasterData/OPD';

    export declare function Create(request: SaveRequest<OPDRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<OPDRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<OPDRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<OPDRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<OPDRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<OPDRow>>;

    export const Methods = {
        Create: "MasterData/OPD/Create",
        Update: "MasterData/OPD/Update",
        Delete: "MasterData/OPD/Delete",
        Retrieve: "MasterData/OPD/Retrieve",
        List: "MasterData/OPD/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>OPDService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
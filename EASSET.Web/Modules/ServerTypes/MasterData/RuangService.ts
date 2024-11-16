import { ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { DeleteRequest } from "../Services/DeleteRequest";
import { DeleteResponse } from "../Services/DeleteResponse";
import { ListRequest } from "../Services/ListRequest";
import { ListResponse } from "../Services/ListResponse";
import { RetrieveRequest } from "../Services/RetrieveRequest";
import { RetrieveResponse } from "../Services/RetrieveResponse";
import { SaveRequest } from "../Services/SaveRequest";
import { SaveResponse } from "../Services/SaveResponse";
import { RuangRow } from "./RuangRow";

export namespace RuangService {
    export const baseUrl = 'MasterData/Ruang';

    export declare function Create(request: SaveRequest<RuangRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<RuangRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<RuangRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<RuangRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<RuangRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<RuangRow>>;

    export const Methods = {
        Create: "MasterData/Ruang/Create",
        Update: "MasterData/Ruang/Update",
        Delete: "MasterData/Ruang/Delete",
        Retrieve: "MasterData/Ruang/Retrieve",
        List: "MasterData/Ruang/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>RuangService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
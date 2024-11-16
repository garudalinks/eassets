import { ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { DeleteRequest } from "../Services/DeleteRequest";
import { DeleteResponse } from "../Services/DeleteResponse";
import { ListRequest } from "../Services/ListRequest";
import { ListResponse } from "../Services/ListResponse";
import { RetrieveRequest } from "../Services/RetrieveRequest";
import { RetrieveResponse } from "../Services/RetrieveResponse";
import { SaveRequest } from "../Services/SaveRequest";
import { SaveResponse } from "../Services/SaveResponse";
import { SubUnitRow } from "./SubUnitRow";

export namespace SubUnitService {
    export const baseUrl = 'MasterData/SubUnit';

    export declare function Create(request: SaveRequest<SubUnitRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SubUnitRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SubUnitRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SubUnitRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SubUnitRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SubUnitRow>>;

    export const Methods = {
        Create: "MasterData/SubUnit/Create",
        Update: "MasterData/SubUnit/Update",
        Delete: "MasterData/SubUnit/Delete",
        Retrieve: "MasterData/SubUnit/Retrieve",
        List: "MasterData/SubUnit/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SubUnitService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
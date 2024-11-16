import { ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { DeleteRequest } from "../Services/DeleteRequest";
import { DeleteResponse } from "../Services/DeleteResponse";
import { ListRequest } from "../Services/ListRequest";
import { ListResponse } from "../Services/ListResponse";
import { RetrieveRequest } from "../Services/RetrieveRequest";
import { RetrieveResponse } from "../Services/RetrieveResponse";
import { SaveRequest } from "../Services/SaveRequest";
import { SaveResponse } from "../Services/SaveResponse";
import { UPBRow } from "./UPBRow";

export namespace UPBService {
    export const baseUrl = 'MasterData/UPB';

    export declare function Create(request: SaveRequest<UPBRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<UPBRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<UPBRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<UPBRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<UPBRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<UPBRow>>;

    export const Methods = {
        Create: "MasterData/UPB/Create",
        Update: "MasterData/UPB/Update",
        Delete: "MasterData/UPB/Delete",
        Retrieve: "MasterData/UPB/Retrieve",
        List: "MasterData/UPB/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>UPBService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
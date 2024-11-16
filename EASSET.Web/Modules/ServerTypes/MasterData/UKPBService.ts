import { ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { DeleteRequest } from "../Services/DeleteRequest";
import { DeleteResponse } from "../Services/DeleteResponse";
import { ListRequest } from "../Services/ListRequest";
import { ListResponse } from "../Services/ListResponse";
import { RetrieveRequest } from "../Services/RetrieveRequest";
import { RetrieveResponse } from "../Services/RetrieveResponse";
import { SaveRequest } from "../Services/SaveRequest";
import { SaveResponse } from "../Services/SaveResponse";
import { UKPBRow } from "./UKPBRow";

export namespace UKPBService {
    export const baseUrl = 'MasterData/UKPB';

    export declare function Create(request: SaveRequest<UKPBRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<UKPBRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<UKPBRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<UKPBRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<UKPBRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<UKPBRow>>;

    export const Methods = {
        Create: "MasterData/UKPB/Create",
        Update: "MasterData/UKPB/Update",
        Delete: "MasterData/UKPB/Delete",
        Retrieve: "MasterData/UKPB/Retrieve",
        List: "MasterData/UKPB/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>UKPBService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
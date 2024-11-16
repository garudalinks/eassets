import { ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { DeleteRequest } from "../Services/DeleteRequest";
import { DeleteResponse } from "../Services/DeleteResponse";
import { ListRequest } from "../Services/ListRequest";
import { ListResponse } from "../Services/ListResponse";
import { RetrieveRequest } from "../Services/RetrieveRequest";
import { RetrieveResponse } from "../Services/RetrieveResponse";
import { SaveRequest } from "../Services/SaveRequest";
import { SaveResponse } from "../Services/SaveResponse";
import { SubKegiatanRow } from "./SubKegiatanRow";

export namespace SubKegiatanService {
    export const baseUrl = 'MasterData/SubKegiatan';

    export declare function Create(request: SaveRequest<SubKegiatanRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SubKegiatanRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SubKegiatanRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SubKegiatanRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SubKegiatanRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SubKegiatanRow>>;

    export const Methods = {
        Create: "MasterData/SubKegiatan/Create",
        Update: "MasterData/SubKegiatan/Update",
        Delete: "MasterData/SubKegiatan/Delete",
        Retrieve: "MasterData/SubKegiatan/Retrieve",
        List: "MasterData/SubKegiatan/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SubKegiatanService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
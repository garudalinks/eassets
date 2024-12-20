﻿import { ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { UserPermissionListRequest } from "./UserPermissionListRequest";
import { UserPermissionListResponse } from "./UserPermissionListResponse";
import { UserPermissionUpdateRequest } from "./UserPermissionUpdateRequest";
import { UserPermissionUpdateResponse } from "./UserPermissionUpdateResponse";

export namespace UserPermissionService {
    export const baseUrl = 'Administration/UserPermission';

    export declare function Update(request: UserPermissionUpdateRequest, onSuccess?: (response: UserPermissionUpdateResponse) => void, opt?: ServiceOptions<any>): PromiseLike<UserPermissionUpdateResponse>;
    export declare function List(request: UserPermissionListRequest, onSuccess?: (response: UserPermissionListResponse) => void, opt?: ServiceOptions<any>): PromiseLike<UserPermissionListResponse>;

    export const Methods = {
        Update: "Administration/UserPermission/Update",
        List: "Administration/UserPermission/List"
    } as const;

    [
        'Update', 
        'List'
    ].forEach(x => {
        (<any>UserPermissionService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
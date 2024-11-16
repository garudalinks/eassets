import { ListResponse } from "../Services/ListResponse";
import { UserPermissionRow } from "./UserPermissionRow";

export interface UserPermissionListResponse extends ListResponse<UserPermissionRow> {
    RolePermissions?: string[];
}
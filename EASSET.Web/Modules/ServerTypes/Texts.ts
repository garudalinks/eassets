import { proxyTexts } from "@serenity-is/corelib";

namespace EASSET.Texts {

    export declare namespace Db {

        namespace Administration {

            namespace Language {
                export const Id: string;
                export const LanguageId: string;
                export const LanguageName: string;
            }

            namespace Role {
                export const RoleId: string;
                export const RoleKey: string;
                export const RoleKeyOrName: string;
                export const RoleName: string;
            }

            namespace RolePermission {
                export const PermissionKey: string;
                export const RoleId: string;
                export const RoleKeyOrName: string;
                export const RolePermissionId: string;
            }

            namespace User {
                export const DisplayName: string;
                export const Email: string;
                export const ImpersonationToken: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LastDirectoryUpdate: string;
                export const MobilePhoneNumber: string;
                export const MobilePhoneVerified: string;
                export const Password: string;
                export const PasswordConfirm: string;
                export const PasswordHash: string;
                export const PasswordSalt: string;
                export const Roles: string;
                export const Source: string;
                export const TwoFactorAuth: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const UserImage: string;
                export const Username: string;
            }

            namespace UserPermission {
                export const Granted: string;
                export const PermissionKey: string;
                export const User: string;
                export const UserId: string;
                export const UserPermissionId: string;
                export const Username: string;
            }

            namespace UserRole {
                export const RoleId: string;
                export const RoleKeyOrName: string;
                export const User: string;
                export const UserId: string;
                export const UserRoleId: string;
                export const Username: string;
            }
        }

        namespace MasterData {

            namespace KodeRekening {
                export const Akun108Id: string;
                export const AkunView: string;
                export const Id: string;
                export const IsEnabled: string;
                export const Jenis108Id: string;
                export const JenisView: string;
                export const Kelompok108Id: string;
                export const KelompokView: string;
                export const KodeRekening108: string;
                export const Objek108Id: string;
                export const ObjekView: string;
                export const Ro108Id: string;
                export const RoView: string;
                export const SubRo108Id: string;
                export const SubRoView: string;
                export const SubSubRo108Id: string;
                export const SubSubRoView: string;
                export const ThAng: string;
            }

            namespace OPD {
                export const Alamat: string;
                export const Dlt: string;
                export const IsBlud: string;
                export const Lu: string;
                export const NoUrut: string;
                export const Npwp: string;
                export const Op: string;
                export const Pc: string;
                export const ThAng: string;
                export const UnitId: string;
                export const UnitKode: string;
                export const UnitNama: string;
            }

            namespace Ruang {
                export const Dlt: string;
                export const Lu: string;
                export const Op: string;
                export const Pc: string;
                export const RuangId: string;
                export const RuangKode: string;
                export const RuangNama: string;
                export const SubUnitId: string;
                export const SubUnitNama: string;
                export const ThAng: string;
                export const UnitId: string;
                export const UnitNama: string;
            }

            namespace SubKegiatan {
                export const BidangView: string;
                export const Id: string;
                export const KegView: string;
                export const ProgView: string;
                export const SubKeg50Id: string;
                export const SubKeg50Kode: string;
                export const SubKegView: string;
                export const UrusanView: string;
            }

            namespace SubUnit {
                export const Alamat: string;
                export const Dlt: string;
                export const Lu: string;
                export const Npwp: string;
                export const Op: string;
                export const Pc: string;
                export const SubUnitId: string;
                export const SubUnitKode: string;
                export const SubUnitNama: string;
                export const ThAng: string;
                export const UnitId: string;
                export const UnitNama: string;
            }

            namespace UKPB {
                export const Dlt: string;
                export const Lu: string;
                export const Op: string;
                export const Pc: string;
                export const SubUnitId: string;
                export const SubUnitNama: string;
                export const ThAng: string;
                export const UkpbAlamat: string;
                export const UkpbKode: string;
                export const UkpbNama: string;
                export const Ukpbid: string;
                export const UnitId: string;
                export const UnitNama: string;
                export const UpbNama: string;
                export const Upbid: string;
            }

            namespace UPB {
                export const Dlt: string;
                export const Lu: string;
                export const Op: string;
                export const Pc: string;
                export const SubUnitId: string;
                export const SubUnitNama: string;
                export const ThAng: string;
                export const UnitId: string;
                export const UnitNama: string;
                export const UpbKode: string;
                export const UpbNama: string;
                export const Upbid: string;
            }
        }

        namespace Perencanaan {

            namespace RKBMD {
                export const Dlt: string;
                export const JmlExisting: string;
                export const JmlKebMax: string;
                export const JmlUsulan: string;
                export const Keterangan: string;
                export const KodeRekening: string;
                export const Lu: string;
                export const NamaRekening: string;
                export const NoUrut: string;
                export const Op: string;
                export const Pc: string;
                export const Rkbmdid: string;
                export const Rkpdid: string;
                export const Satuan: string;
                export const SubKegId: string;
                export const SubKegKode: string;
                export const SubKegNama: string;
                export const SubSubRo108Id: string;
                export const SubUnitId: string;
                export const ThAng: string;
                export const UnitId: string;
            }
        }
    }

    export declare namespace Forms {

        namespace Membership {

            namespace Login {
                export const ForgotPassword: string;
                export const LoginToYourAccount: string;
                export const OR: string;
                export const RememberMe: string;
                export const SignInButton: string;
                export const SignInWithGeneric: string;
                export const SignUpButton: string;
            }

            namespace SendActivation {
                export const FormInfo: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace SignUp {
                export const ActivateEmailSubject: string;
                export const ActivationCompleteMessage: string;
                export const ConfirmDetails: string;
                export const ConfirmEmail: string;
                export const ConfirmPassword: string;
                export const DisplayName: string;
                export const Email: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const Password: string;
                export const SubmitButton: string;
                export const Success: string;
            }
        }
        export const SiteTitle: string;
    }

    export declare namespace Navigation {
        export const Dashboard: string;
        export const LogoutLink: string;
        export const SiteTitle: string;
    }

    export declare namespace Site {

        namespace AccessDenied {
            export const ClickToChangeUser: string;
            export const ClickToLogin: string;
            export const LackPermissions: string;
            export const NotLoggedIn: string;
            export const PageTitle: string;
        }

        namespace Layout {
            export const Language: string;
            export const Theme: string;
        }

        namespace RolePermissionDialog {
            export const DialogTitle: string;
            export const EditButton: string;
            export const SaveSuccess: string;
        }

        namespace UserDialog {
            export const EditPermissionsButton: string;
            export const EditRolesButton: string;
        }

        namespace UserPermissionDialog {
            export const DialogTitle: string;
            export const Grant: string;
            export const Permission: string;
            export const Revoke: string;
            export const SaveSuccess: string;
        }

        namespace ValidationError {
            export const Title: string;
        }
    }

    export declare namespace Validation {
        export const AuthenticationError: string;
        export const CurrentPasswordMismatch: string;
        export const DeleteForeignKeyError: string;
        export const EmailConfirm: string;
        export const EmailInUse: string;
        export const InvalidActivateToken: string;
        export const InvalidResetToken: string;
        export const MinRequiredPasswordLength: string;
        export const PasswordConfirmMismatch: string;
        export const SavePrimaryKeyError: string;
    }

    EASSET['Texts'] = proxyTexts(Texts, '', {
        Db: {
            Administration: {
                Language: {},
                Role: {},
                RolePermission: {},
                User: {},
                UserPermission: {},
                UserRole: {}
            },
            MasterData: {
                KodeRekening: {},
                OPD: {},
                Ruang: {},
                SubKegiatan: {},
                SubUnit: {},
                UKPB: {},
                UPB: {}
            },
            Perencanaan: {
                RKBMD: {}
            }
        },
        Forms: {
            Membership: {
                Login: {},
                SendActivation: {},
                SignUp: {}
            }
        },
        Navigation: {},
        Site: {
            AccessDenied: {},
            Layout: {},
            RolePermissionDialog: {},
            UserDialog: {},
            UserPermissionDialog: {},
            ValidationError: {}
        },
        Validation: {}
    }) as any;
}

export const Texts = EASSET.Texts;
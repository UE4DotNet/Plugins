// Copyright 2018 by JCoder58.  See License.txt for license
// Auto-generated --- Do not modify.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject;
using UE4.CoreUObject.Native;
using UE4.InputCore;
using UE4.Native;


namespace UE4.MagicLeap.Native {
    [StructLayout( LayoutKind.Explicit, Size=272 )]
    internal unsafe struct MagicLeapPrivileges_fields {
    }
    internal unsafe struct MagicLeapPrivileges_methods {
        internal struct CheckPrivilege_method {
            static internal IntPtr CheckPrivilege_ptr;
            static CheckPrivilege_method() {
                CheckPrivilege_ptr = Main.GetMethodUFunction(MagicLeapPrivileges.StaticClass, "CheckPrivilege");
            }

            internal static unsafe bool Invoke(IntPtr obj, EMagicLeapPrivilege Privilege) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Privilege;
                Main.GetProcessEvent(obj, CheckPrivilege_ptr, new IntPtr(p)); ;
                return *((bool*)(b+1));
            }
        }
        internal struct RequestPrivilege_method {
            static internal IntPtr RequestPrivilege_ptr;
            static RequestPrivilege_method() {
                RequestPrivilege_ptr = Main.GetMethodUFunction(MagicLeapPrivileges.StaticClass, "RequestPrivilege");
            }

            internal static unsafe bool Invoke(IntPtr obj, EMagicLeapPrivilege Privilege) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Privilege;
                Main.GetProcessEvent(obj, RequestPrivilege_ptr, new IntPtr(p)); ;
                return *((bool*)(b+1));
            }
        }
        internal struct RequestPrivilegeAsync_method {
            static internal IntPtr RequestPrivilegeAsync_ptr;
            static RequestPrivilegeAsync_method() {
                RequestPrivilegeAsync_ptr = Main.GetMethodUFunction(MagicLeapPrivileges.StaticClass, "RequestPrivilegeAsync");
            }

            internal static unsafe bool Invoke(IntPtr obj, EMagicLeapPrivilege Privilege, byte ResultDelegate /*TODO: delegate FPrivilegeRequestDelegate */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Privilege;
                throw new NotImplementedException(); //TODO: delegate FPrivilegeRequestDelegate ResultDelegate
                Main.GetProcessEvent(obj, RequestPrivilegeAsync_ptr, new IntPtr(p)); ;
                 //TODO: delegate FPrivilegeRequestDelegate ResultDelegate
                return *((bool*)(b+24));
            }
        }
    }
    internal unsafe struct MagicLeapPrivileges_events {
    }
}

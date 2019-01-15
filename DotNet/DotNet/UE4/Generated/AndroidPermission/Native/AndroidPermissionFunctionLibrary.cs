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


namespace UE4.AndroidPermission.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct AndroidPermissionFunctionLibrary_fields {
    }
    internal unsafe struct AndroidPermissionFunctionLibrary_methods {
        internal struct AcquirePermissions_method {
            static internal IntPtr AcquirePermissions_ptr;
            static AcquirePermissions_method() {
                AcquirePermissions_ptr = Main.GetMethodUFunction(AndroidPermissionFunctionLibrary.StaticClass, "AcquirePermissions");
            }

            internal static unsafe AndroidPermissionCallbackProxy Invoke(byte permissions /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray permissions
                Main.GetProcessEvent(AndroidPermissionFunctionLibrary.DefaultObject, AcquirePermissions_ptr, new IntPtr(p)); ;
                 //TODO: array TArray permissions
                return *((IntPtr*)(b+16));
            }
        }
        internal struct CheckPermission_method {
            static internal IntPtr CheckPermission_ptr;
            static CheckPermission_method() {
                CheckPermission_ptr = Main.GetMethodUFunction(AndroidPermissionFunctionLibrary.StaticClass, "CheckPermission");
            }

            internal static unsafe bool Invoke(string permission) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var permission_handle = GCHandle.Alloc(permission, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = permission_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = permission.Length;
                *(int*)(b+IntPtr.Size+4+0) = permission.Length;
                Main.GetProcessEvent(AndroidPermissionFunctionLibrary.DefaultObject, CheckPermission_ptr, new IntPtr(p)); ;
                permission_handle.Free();
                return *((bool*)(b+16));
            }
        }
    }
    internal unsafe struct AndroidPermissionFunctionLibrary_events {
    }
}

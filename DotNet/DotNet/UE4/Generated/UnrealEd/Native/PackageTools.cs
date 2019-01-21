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


namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct PackageTools_fields {
    }
    internal unsafe struct PackageTools_methods {
        internal struct SanitizePackageName_method {
            static internal IntPtr SanitizePackageName_ptr;
            static SanitizePackageName_method() {
                SanitizePackageName_ptr = Main.GetMethodUFunction(PackageTools.StaticClass, "SanitizePackageName");
            }

            internal static unsafe string Invoke(string InPackageName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InPackageName_handle = GCHandle.Alloc(InPackageName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InPackageName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InPackageName.Length;
                *(int*)(b+IntPtr.Size+4+0) = InPackageName.Length;
                Main.GetProcessEvent(PackageTools.DefaultObject, SanitizePackageName_ptr, new IntPtr(p)); ;
                InPackageName_handle.Free();
                return FString.Get(b+16);
            }
        }
    }
    internal unsafe struct PackageTools_events {
    }
}

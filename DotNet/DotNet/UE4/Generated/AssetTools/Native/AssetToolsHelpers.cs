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


namespace UE4.AssetTools.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct AssetToolsHelpers_fields {
    }
    internal unsafe struct AssetToolsHelpers_methods {
        internal struct GetAssetTools_method {
            static internal IntPtr GetAssetTools_ptr;
            static GetAssetTools_method() {
                GetAssetTools_ptr = Main.GetMethodUFunction(AssetToolsHelpers.StaticClass, "GetAssetTools");
            }

            internal static unsafe AssetTools Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(AssetToolsHelpers.DefaultObject, GetAssetTools_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface ReturnValue
                return *((IntPtr*)(b+0));
            }
        }
    }
    internal unsafe struct AssetToolsHelpers_events {
    }
}

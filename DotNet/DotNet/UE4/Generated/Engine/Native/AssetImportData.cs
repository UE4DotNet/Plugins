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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=104 )]
    internal unsafe struct AssetImportData_fields {
        [FieldOffset(88)] public AssetImportInfo SourceData;
    }
    internal unsafe struct AssetImportData_methods {
        internal struct K2_ExtractFilenames_method {
            static internal IntPtr K2_ExtractFilenames_ptr;
            static K2_ExtractFilenames_method() {
                K2_ExtractFilenames_ptr = Main.GetMethodUFunction(AssetImportData.StaticClass, "K2_ExtractFilenames");
            }

            internal static unsafe IReadOnlyCollection<string> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_ExtractFilenames_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToStringCollection(b+0);
            }
        }
        internal struct K2_GetFirstFilename_method {
            static internal IntPtr K2_GetFirstFilename_ptr;
            static K2_GetFirstFilename_method() {
                K2_GetFirstFilename_ptr = Main.GetMethodUFunction(AssetImportData.StaticClass, "K2_GetFirstFilename");
            }

            internal static unsafe string Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_GetFirstFilename_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
    }
    internal unsafe struct AssetImportData_events {
    }
}

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

using UE4.Engine;

namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MaterialImportHelpers_fields {
    }
    internal unsafe struct MaterialImportHelpers_methods {
        internal struct FindExistingMaterial_method {
            static internal IntPtr FindExistingMaterial_ptr;
            static FindExistingMaterial_method() {
                FindExistingMaterial_ptr = Main.GetMethodUFunction(MaterialImportHelpers.StaticClass, "FindExistingMaterial");
            }

            internal static unsafe (byte /*TODO: text FText*/, MaterialInterface) Invoke(string BasePath, string MaterialFullName, bool bRecursivePaths) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var BasePath_handle = GCHandle.Alloc(BasePath, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = BasePath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = BasePath.Length;
                *(int*)(b+IntPtr.Size+4+0) = BasePath.Length;
                var MaterialFullName_handle = GCHandle.Alloc(MaterialFullName, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = MaterialFullName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = MaterialFullName.Length;
                *(int*)(b+IntPtr.Size+4+16) = MaterialFullName.Length;
                *((bool*)(b+32)) = bRecursivePaths;
                Main.GetProcessEvent(MaterialImportHelpers.DefaultObject, FindExistingMaterial_ptr, new IntPtr(p)); ;
                BasePath_handle.Free();
                MaterialFullName_handle.Free();
                 //TODO: text FText OutError
                return (UObject.NotImplemented<byte>() /*TODO: text FText*/,*((IntPtr*)(b+64)));
            }
        }
        internal struct FindExistingMaterialFromSearchLocation_method {
            static internal IntPtr FindExistingMaterialFromSearchLocation_ptr;
            static FindExistingMaterialFromSearchLocation_method() {
                FindExistingMaterialFromSearchLocation_ptr = Main.GetMethodUFunction(MaterialImportHelpers.StaticClass, "FindExistingMaterialFromSearchLocation");
            }

            internal static unsafe (byte /*TODO: text FText*/, MaterialInterface) Invoke(string MaterialFullName, string BasePackagePath, EMaterialSearchLocation SearchLocation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var MaterialFullName_handle = GCHandle.Alloc(MaterialFullName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = MaterialFullName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = MaterialFullName.Length;
                *(int*)(b+IntPtr.Size+4+0) = MaterialFullName.Length;
                var BasePackagePath_handle = GCHandle.Alloc(BasePackagePath, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = BasePackagePath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = BasePackagePath.Length;
                *(int*)(b+IntPtr.Size+4+16) = BasePackagePath.Length;
                *(b+32) = (byte)SearchLocation;
                Main.GetProcessEvent(MaterialImportHelpers.DefaultObject, FindExistingMaterialFromSearchLocation_ptr, new IntPtr(p)); ;
                MaterialFullName_handle.Free();
                BasePackagePath_handle.Free();
                 //TODO: text FText OutError
                return (UObject.NotImplemented<byte>() /*TODO: text FText*/,*((IntPtr*)(b+64)));
            }
        }
    }
    internal unsafe struct MaterialImportHelpers_events {
    }
}

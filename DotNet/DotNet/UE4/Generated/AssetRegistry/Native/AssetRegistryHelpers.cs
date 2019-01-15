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


namespace UE4.AssetRegistry.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct AssetRegistryHelpers_fields {
    }
    internal unsafe struct AssetRegistryHelpers_methods {
        internal struct CreateAssetData_method {
            static internal IntPtr CreateAssetData_ptr;
            static CreateAssetData_method() {
                CreateAssetData_ptr = Main.GetMethodUFunction(AssetRegistryHelpers.StaticClass, "CreateAssetData");
            }

            internal static unsafe AssetData Invoke(UObject InAsset, bool bAllowBlueprintClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InAsset;
                *((bool*)(b+8)) = bAllowBlueprintClass;
                Main.GetProcessEvent(AssetRegistryHelpers.DefaultObject, CreateAssetData_ptr, new IntPtr(p)); ;
                return *((AssetData*)(b+16));
            }
        }
        internal struct GetAsset_method {
            static internal IntPtr GetAsset_ptr;
            static GetAsset_method() {
                GetAsset_ptr = Main.GetMethodUFunction(AssetRegistryHelpers.StaticClass, "GetAsset");
            }

            internal static unsafe UObject Invoke(AssetData InAssetData) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((AssetData*)(b+0)) = InAssetData;
                Main.GetProcessEvent(AssetRegistryHelpers.DefaultObject, GetAsset_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+104));
            }
        }
        internal struct GetAssetRegistry_method {
            static internal IntPtr GetAssetRegistry_ptr;
            static GetAssetRegistry_method() {
                GetAssetRegistry_ptr = Main.GetMethodUFunction(AssetRegistryHelpers.StaticClass, "GetAssetRegistry");
            }

            internal static unsafe AssetRegistry Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(AssetRegistryHelpers.DefaultObject, GetAssetRegistry_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface ReturnValue
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetClass_method {
            static internal IntPtr GetClass_ptr;
            static GetClass_method() {
                GetClass_ptr = Main.GetMethodUFunction(AssetRegistryHelpers.StaticClass, "GetClass");
            }

            internal static unsafe SubclassOf<UObject> Invoke(AssetData InAssetData) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((AssetData*)(b+0)) = InAssetData;
                Main.GetProcessEvent(AssetRegistryHelpers.DefaultObject, GetClass_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+104));
            }
        }
        internal struct GetExportTextName_method {
            static internal IntPtr GetExportTextName_ptr;
            static GetExportTextName_method() {
                GetExportTextName_ptr = Main.GetMethodUFunction(AssetRegistryHelpers.StaticClass, "GetExportTextName");
            }

            internal static unsafe string Invoke(AssetData InAssetData) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((AssetData*)(b+0)) = InAssetData;
                Main.GetProcessEvent(AssetRegistryHelpers.DefaultObject, GetExportTextName_ptr, new IntPtr(p)); ;
                return FString.Get(b+104);
            }
        }
        internal struct GetFullName_method {
            static internal IntPtr GetFullName_ptr;
            static GetFullName_method() {
                GetFullName_ptr = Main.GetMethodUFunction(AssetRegistryHelpers.StaticClass, "GetFullName");
            }

            internal static unsafe string Invoke(AssetData InAssetData) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((AssetData*)(b+0)) = InAssetData;
                Main.GetProcessEvent(AssetRegistryHelpers.DefaultObject, GetFullName_ptr, new IntPtr(p)); ;
                return FString.Get(b+104);
            }
        }
        internal struct GetTagValue_method {
            static internal IntPtr GetTagValue_ptr;
            static GetTagValue_method() {
                GetTagValue_ptr = Main.GetMethodUFunction(AssetRegistryHelpers.StaticClass, "GetTagValue");
            }

            internal static unsafe (string, bool) Invoke(AssetData InAssetData, Name InTagName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((AssetData*)(b+0)) = InAssetData;
                *((Name*)(b+104)) = InTagName;
                Main.GetProcessEvent(AssetRegistryHelpers.DefaultObject, GetTagValue_ptr, new IntPtr(p)); ;
                return (FString.Get(b+120),*((bool*)(b+136)));
            }
        }
        internal struct IsAssetLoaded_method {
            static internal IntPtr IsAssetLoaded_ptr;
            static IsAssetLoaded_method() {
                IsAssetLoaded_ptr = Main.GetMethodUFunction(AssetRegistryHelpers.StaticClass, "IsAssetLoaded");
            }

            internal static unsafe bool Invoke(AssetData InAssetData) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((AssetData*)(b+0)) = InAssetData;
                Main.GetProcessEvent(AssetRegistryHelpers.DefaultObject, IsAssetLoaded_ptr, new IntPtr(p)); ;
                return *((bool*)(b+104));
            }
        }
        internal struct IsRedirector_method {
            static internal IntPtr IsRedirector_ptr;
            static IsRedirector_method() {
                IsRedirector_ptr = Main.GetMethodUFunction(AssetRegistryHelpers.StaticClass, "IsRedirector");
            }

            internal static unsafe bool Invoke(AssetData InAssetData) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((AssetData*)(b+0)) = InAssetData;
                Main.GetProcessEvent(AssetRegistryHelpers.DefaultObject, IsRedirector_ptr, new IntPtr(p)); ;
                return *((bool*)(b+104));
            }
        }
        internal struct IsUAsset_method {
            static internal IntPtr IsUAsset_ptr;
            static IsUAsset_method() {
                IsUAsset_ptr = Main.GetMethodUFunction(AssetRegistryHelpers.StaticClass, "IsUAsset");
            }

            internal static unsafe bool Invoke(AssetData InAssetData) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((AssetData*)(b+0)) = InAssetData;
                Main.GetProcessEvent(AssetRegistryHelpers.DefaultObject, IsUAsset_ptr, new IntPtr(p)); ;
                return *((bool*)(b+104));
            }
        }
        internal struct IsValid_method {
            static internal IntPtr IsValid_ptr;
            static IsValid_method() {
                IsValid_ptr = Main.GetMethodUFunction(AssetRegistryHelpers.StaticClass, "IsValid");
            }

            internal static unsafe bool Invoke(AssetData InAssetData) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((AssetData*)(b+0)) = InAssetData;
                Main.GetProcessEvent(AssetRegistryHelpers.DefaultObject, IsValid_ptr, new IntPtr(p)); ;
                return *((bool*)(b+104));
            }
        }
        internal struct SetFilterTagsAndValues_method {
            static internal IntPtr SetFilterTagsAndValues_ptr;
            static SetFilterTagsAndValues_method() {
                SetFilterTagsAndValues_ptr = Main.GetMethodUFunction(AssetRegistryHelpers.StaticClass, "SetFilterTagsAndValues");
            }

            internal static unsafe ARFilter Invoke(ARFilter InFilter, byte InTagsAndValues /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((ARFilter*)(b+0)) = InFilter;
                throw new NotImplementedException(); //TODO: array TArray InTagsAndValues
                Main.GetProcessEvent(AssetRegistryHelpers.DefaultObject, SetFilterTagsAndValues_ptr, new IntPtr(p)); ;
                 //TODO: array TArray InTagsAndValues
                return *((ARFilter*)(b+248));
            }
        }
        internal struct ToSoftObjectPath_method {
            static internal IntPtr ToSoftObjectPath_ptr;
            static ToSoftObjectPath_method() {
                ToSoftObjectPath_ptr = Main.GetMethodUFunction(AssetRegistryHelpers.StaticClass, "ToSoftObjectPath");
            }

            internal static unsafe SoftObjectPath Invoke(AssetData InAssetData) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((AssetData*)(b+0)) = InAssetData;
                Main.GetProcessEvent(AssetRegistryHelpers.DefaultObject, ToSoftObjectPath_ptr, new IntPtr(p)); ;
                return *((SoftObjectPath*)(b+104));
            }
        }
    }
    internal unsafe struct AssetRegistryHelpers_events {
    }
}

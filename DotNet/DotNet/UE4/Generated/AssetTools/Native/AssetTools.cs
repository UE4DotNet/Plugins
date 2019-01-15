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

using UE4.UnrealEd;

namespace UE4.AssetTools.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct AssetTools_fields {
    }
    internal unsafe struct AssetTools_methods {
        internal struct CreateAsset_method {
            static internal IntPtr CreateAsset_ptr;
            static CreateAsset_method() {
                CreateAsset_ptr = Main.GetMethodUFunction(AssetTools.StaticClass, "CreateAsset");
            }

            internal static unsafe UObject Invoke(IntPtr obj, string AssetName, string PackagePath, SubclassOf<UObject> AssetClass, Factory Factory, Name CallingContext) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var AssetName_handle = GCHandle.Alloc(AssetName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = AssetName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = AssetName.Length;
                *(int*)(b+IntPtr.Size+4+0) = AssetName.Length;
                var PackagePath_handle = GCHandle.Alloc(PackagePath, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = PackagePath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = PackagePath.Length;
                *(int*)(b+IntPtr.Size+4+16) = PackagePath.Length;
                *((IntPtr*)(b+32)) = AssetClass;
                *((IntPtr*)(b+40)) = Factory;
                *((Name*)(b+48)) = CallingContext;
                Main.GetProcessEvent(obj, CreateAsset_ptr, new IntPtr(p)); ;
                AssetName_handle.Free();
                PackagePath_handle.Free();
                return *((IntPtr*)(b+64));
            }
        }
        internal struct CreateAssetWithDialog_method {
            static internal IntPtr CreateAssetWithDialog_ptr;
            static CreateAssetWithDialog_method() {
                CreateAssetWithDialog_ptr = Main.GetMethodUFunction(AssetTools.StaticClass, "CreateAssetWithDialog");
            }

            internal static unsafe UObject Invoke(IntPtr obj, string AssetName, string PackagePath, SubclassOf<UObject> AssetClass, Factory Factory, Name CallingContext) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var AssetName_handle = GCHandle.Alloc(AssetName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = AssetName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = AssetName.Length;
                *(int*)(b+IntPtr.Size+4+0) = AssetName.Length;
                var PackagePath_handle = GCHandle.Alloc(PackagePath, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = PackagePath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = PackagePath.Length;
                *(int*)(b+IntPtr.Size+4+16) = PackagePath.Length;
                *((IntPtr*)(b+32)) = AssetClass;
                *((IntPtr*)(b+40)) = Factory;
                *((Name*)(b+48)) = CallingContext;
                Main.GetProcessEvent(obj, CreateAssetWithDialog_ptr, new IntPtr(p)); ;
                AssetName_handle.Free();
                PackagePath_handle.Free();
                return *((IntPtr*)(b+64));
            }
        }
        internal struct CreateUniqueAssetName_method {
            static internal IntPtr CreateUniqueAssetName_ptr;
            static CreateUniqueAssetName_method() {
                CreateUniqueAssetName_ptr = Main.GetMethodUFunction(AssetTools.StaticClass, "CreateUniqueAssetName");
            }

            internal static unsafe (string, string) Invoke(IntPtr obj, string InBasePackageName, string InSuffix) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InBasePackageName_handle = GCHandle.Alloc(InBasePackageName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InBasePackageName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InBasePackageName.Length;
                *(int*)(b+IntPtr.Size+4+0) = InBasePackageName.Length;
                var InSuffix_handle = GCHandle.Alloc(InSuffix, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = InSuffix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = InSuffix.Length;
                *(int*)(b+IntPtr.Size+4+16) = InSuffix.Length;
                Main.GetProcessEvent(obj, CreateUniqueAssetName_ptr, new IntPtr(p)); ;
                InBasePackageName_handle.Free();
                InSuffix_handle.Free();
                return (FString.Get(b+32),FString.Get(b+48));
            }
        }
        internal struct DuplicateAsset_method {
            static internal IntPtr DuplicateAsset_ptr;
            static DuplicateAsset_method() {
                DuplicateAsset_ptr = Main.GetMethodUFunction(AssetTools.StaticClass, "DuplicateAsset");
            }

            internal static unsafe UObject Invoke(IntPtr obj, string AssetName, string PackagePath, UObject OriginalObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var AssetName_handle = GCHandle.Alloc(AssetName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = AssetName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = AssetName.Length;
                *(int*)(b+IntPtr.Size+4+0) = AssetName.Length;
                var PackagePath_handle = GCHandle.Alloc(PackagePath, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = PackagePath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = PackagePath.Length;
                *(int*)(b+IntPtr.Size+4+16) = PackagePath.Length;
                *((IntPtr*)(b+32)) = OriginalObject;
                Main.GetProcessEvent(obj, DuplicateAsset_ptr, new IntPtr(p)); ;
                AssetName_handle.Free();
                PackagePath_handle.Free();
                return *((IntPtr*)(b+40));
            }
        }
        internal struct DuplicateAssetWithDialog_method {
            static internal IntPtr DuplicateAssetWithDialog_ptr;
            static DuplicateAssetWithDialog_method() {
                DuplicateAssetWithDialog_ptr = Main.GetMethodUFunction(AssetTools.StaticClass, "DuplicateAssetWithDialog");
            }

            internal static unsafe UObject Invoke(IntPtr obj, string AssetName, string PackagePath, UObject OriginalObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var AssetName_handle = GCHandle.Alloc(AssetName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = AssetName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = AssetName.Length;
                *(int*)(b+IntPtr.Size+4+0) = AssetName.Length;
                var PackagePath_handle = GCHandle.Alloc(PackagePath, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = PackagePath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = PackagePath.Length;
                *(int*)(b+IntPtr.Size+4+16) = PackagePath.Length;
                *((IntPtr*)(b+32)) = OriginalObject;
                Main.GetProcessEvent(obj, DuplicateAssetWithDialog_ptr, new IntPtr(p)); ;
                AssetName_handle.Free();
                PackagePath_handle.Free();
                return *((IntPtr*)(b+40));
            }
        }
        internal struct ExportAssets_method {
            static internal IntPtr ExportAssets_ptr;
            static ExportAssets_method() {
                ExportAssets_ptr = Main.GetMethodUFunction(AssetTools.StaticClass, "ExportAssets");
            }

            internal static unsafe void Invoke(IntPtr obj, byte AssetsToExport /*TODO: array TArray */, string ExportPath) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray AssetsToExport
                var ExportPath_handle = GCHandle.Alloc(ExportPath, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = ExportPath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = ExportPath.Length;
                *(int*)(b+IntPtr.Size+4+16) = ExportPath.Length;
                Main.GetProcessEvent(obj, ExportAssets_ptr, new IntPtr(p)); ;
                 //TODO: array TArray AssetsToExport
                ExportPath_handle.Free();
            }
        }
        internal struct ExportAssetsWithDialog_method {
            static internal IntPtr ExportAssetsWithDialog_ptr;
            static ExportAssetsWithDialog_method() {
                ExportAssetsWithDialog_ptr = Main.GetMethodUFunction(AssetTools.StaticClass, "ExportAssetsWithDialog");
            }

            internal static unsafe void Invoke(IntPtr obj, byte AssetsToExport /*TODO: array TArray */, bool bPromptForIndividualFilenames) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray AssetsToExport
                *((bool*)(b+16)) = bPromptForIndividualFilenames;
                Main.GetProcessEvent(obj, ExportAssetsWithDialog_ptr, new IntPtr(p)); ;
                 //TODO: array TArray AssetsToExport
            }
        }
        internal struct FindSoftReferencesToObject_method {
            static internal IntPtr FindSoftReferencesToObject_ptr;
            static FindSoftReferencesToObject_method() {
                FindSoftReferencesToObject_ptr = Main.GetMethodUFunction(AssetTools.StaticClass, "FindSoftReferencesToObject");
            }

            internal static unsafe IReadOnlyCollection<UObject> Invoke(IntPtr obj, SoftObjectPath TargetObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SoftObjectPath*)(b+0)) = TargetObject;
                Main.GetProcessEvent(obj, FindSoftReferencesToObject_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReferencingObjects
                return UObject.ToUObjectCollection<UObject>(b+32);
            }
        }
        internal struct ImportAssetsAutomated_method {
            static internal IntPtr ImportAssetsAutomated_ptr;
            static ImportAssetsAutomated_method() {
                ImportAssetsAutomated_ptr = Main.GetMethodUFunction(AssetTools.StaticClass, "ImportAssetsAutomated");
            }

            internal static unsafe IReadOnlyCollection<UObject> Invoke(IntPtr obj, AutomatedAssetImportData ImportData) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ImportData;
                Main.GetProcessEvent(obj, ImportAssetsAutomated_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUObjectCollection<UObject>(b+8);
            }
        }
        internal struct ImportAssetsWithDialog_method {
            static internal IntPtr ImportAssetsWithDialog_ptr;
            static ImportAssetsWithDialog_method() {
                ImportAssetsWithDialog_ptr = Main.GetMethodUFunction(AssetTools.StaticClass, "ImportAssetsWithDialog");
            }

            internal static unsafe IReadOnlyCollection<UObject> Invoke(IntPtr obj, string DestinationPath) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var DestinationPath_handle = GCHandle.Alloc(DestinationPath, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = DestinationPath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = DestinationPath.Length;
                *(int*)(b+IntPtr.Size+4+0) = DestinationPath.Length;
                Main.GetProcessEvent(obj, ImportAssetsWithDialog_ptr, new IntPtr(p)); ;
                DestinationPath_handle.Free();
                 //TODO: array TArray ReturnValue
                return UObject.ToUObjectCollection<UObject>(b+16);
            }
        }
        internal struct ImportAssetTasks_method {
            static internal IntPtr ImportAssetTasks_ptr;
            static ImportAssetTasks_method() {
                ImportAssetTasks_ptr = Main.GetMethodUFunction(AssetTools.StaticClass, "ImportAssetTasks");
            }

            internal static unsafe void Invoke(IntPtr obj, byte ImportTasks /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray ImportTasks
                Main.GetProcessEvent(obj, ImportAssetTasks_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ImportTasks
            }
        }
        internal struct RenameAssets_method {
            static internal IntPtr RenameAssets_ptr;
            static RenameAssets_method() {
                RenameAssets_ptr = Main.GetMethodUFunction(AssetTools.StaticClass, "RenameAssets");
            }

            internal static unsafe bool Invoke(IntPtr obj, byte AssetsAndNames /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray AssetsAndNames
                Main.GetProcessEvent(obj, RenameAssets_ptr, new IntPtr(p)); ;
                 //TODO: array TArray AssetsAndNames
                return *((bool*)(b+16));
            }
        }
        internal struct RenameAssetsWithDialog_method {
            static internal IntPtr RenameAssetsWithDialog_ptr;
            static RenameAssetsWithDialog_method() {
                RenameAssetsWithDialog_ptr = Main.GetMethodUFunction(AssetTools.StaticClass, "RenameAssetsWithDialog");
            }

            internal static unsafe void Invoke(IntPtr obj, byte AssetsAndNames /*TODO: array TArray */, bool bAutoCheckout) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray AssetsAndNames
                *((bool*)(b+16)) = bAutoCheckout;
                Main.GetProcessEvent(obj, RenameAssetsWithDialog_ptr, new IntPtr(p)); ;
                 //TODO: array TArray AssetsAndNames
            }
        }
    }
    internal unsafe struct AssetTools_events {
    }
}

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
    internal unsafe struct EditorLoadingAndSavingUtils_fields {
    }
    internal unsafe struct EditorLoadingAndSavingUtils_methods {
        internal struct ExportScene_method {
            static internal IntPtr ExportScene_ptr;
            static ExportScene_method() {
                ExportScene_ptr = Main.GetMethodUFunction(EditorLoadingAndSavingUtils.StaticClass, "ExportScene");
            }

            internal static unsafe void Invoke(bool bExportSelectedActorsOnly) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bExportSelectedActorsOnly;
                Main.GetProcessEvent(EditorLoadingAndSavingUtils.DefaultObject, ExportScene_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetDirtyContentPackages_method {
            static internal IntPtr GetDirtyContentPackages_ptr;
            static GetDirtyContentPackages_method() {
                GetDirtyContentPackages_ptr = Main.GetMethodUFunction(EditorLoadingAndSavingUtils.StaticClass, "GetDirtyContentPackages");
            }

            internal static unsafe IReadOnlyCollection<Package> Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(EditorLoadingAndSavingUtils.DefaultObject, GetDirtyContentPackages_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutDirtyPackages
                return UObject.ToUObjectCollection<Package>(b+0);
            }
        }
        internal struct GetDirtyMapPackages_method {
            static internal IntPtr GetDirtyMapPackages_ptr;
            static GetDirtyMapPackages_method() {
                GetDirtyMapPackages_ptr = Main.GetMethodUFunction(EditorLoadingAndSavingUtils.StaticClass, "GetDirtyMapPackages");
            }

            internal static unsafe IReadOnlyCollection<Package> Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(EditorLoadingAndSavingUtils.DefaultObject, GetDirtyMapPackages_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutDirtyPackages
                return UObject.ToUObjectCollection<Package>(b+0);
            }
        }
        internal struct ImportScene_method {
            static internal IntPtr ImportScene_ptr;
            static ImportScene_method() {
                ImportScene_ptr = Main.GetMethodUFunction(EditorLoadingAndSavingUtils.StaticClass, "ImportScene");
            }

            internal static unsafe void Invoke(string Filename) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var Filename_handle = GCHandle.Alloc(Filename, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Filename_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Filename.Length;
                *(int*)(b+IntPtr.Size+4+0) = Filename.Length;
                Main.GetProcessEvent(EditorLoadingAndSavingUtils.DefaultObject, ImportScene_ptr, new IntPtr(p)); ;
                Filename_handle.Free();
            }
        }
        internal struct LoadMap_method {
            static internal IntPtr LoadMap_ptr;
            static LoadMap_method() {
                LoadMap_ptr = Main.GetMethodUFunction(EditorLoadingAndSavingUtils.StaticClass, "LoadMap");
            }

            internal static unsafe World Invoke(string Filename) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Filename_handle = GCHandle.Alloc(Filename, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Filename_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Filename.Length;
                *(int*)(b+IntPtr.Size+4+0) = Filename.Length;
                Main.GetProcessEvent(EditorLoadingAndSavingUtils.DefaultObject, LoadMap_ptr, new IntPtr(p)); ;
                Filename_handle.Free();
                return *((IntPtr*)(b+16));
            }
        }
        internal struct LoadMapWithDialog_method {
            static internal IntPtr LoadMapWithDialog_ptr;
            static LoadMapWithDialog_method() {
                LoadMapWithDialog_ptr = Main.GetMethodUFunction(EditorLoadingAndSavingUtils.StaticClass, "LoadMapWithDialog");
            }

            internal static unsafe World Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(EditorLoadingAndSavingUtils.DefaultObject, LoadMapWithDialog_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct NewBlankMap_method {
            static internal IntPtr NewBlankMap_ptr;
            static NewBlankMap_method() {
                NewBlankMap_ptr = Main.GetMethodUFunction(EditorLoadingAndSavingUtils.StaticClass, "NewBlankMap");
            }

            internal static unsafe World Invoke(bool bSaveExistingMap) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bSaveExistingMap;
                Main.GetProcessEvent(EditorLoadingAndSavingUtils.DefaultObject, NewBlankMap_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct NewMapFromTemplate_method {
            static internal IntPtr NewMapFromTemplate_ptr;
            static NewMapFromTemplate_method() {
                NewMapFromTemplate_ptr = Main.GetMethodUFunction(EditorLoadingAndSavingUtils.StaticClass, "NewMapFromTemplate");
            }

            internal static unsafe World Invoke(string PathToTemplateLevel, bool bSaveExistingMap) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var PathToTemplateLevel_handle = GCHandle.Alloc(PathToTemplateLevel, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = PathToTemplateLevel_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = PathToTemplateLevel.Length;
                *(int*)(b+IntPtr.Size+4+0) = PathToTemplateLevel.Length;
                *((bool*)(b+16)) = bSaveExistingMap;
                Main.GetProcessEvent(EditorLoadingAndSavingUtils.DefaultObject, NewMapFromTemplate_ptr, new IntPtr(p)); ;
                PathToTemplateLevel_handle.Free();
                return *((IntPtr*)(b+24));
            }
        }
        internal struct SaveCurrentLevel_method {
            static internal IntPtr SaveCurrentLevel_ptr;
            static SaveCurrentLevel_method() {
                SaveCurrentLevel_ptr = Main.GetMethodUFunction(EditorLoadingAndSavingUtils.StaticClass, "SaveCurrentLevel");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(EditorLoadingAndSavingUtils.DefaultObject, SaveCurrentLevel_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SaveDirtyPackages_method {
            static internal IntPtr SaveDirtyPackages_ptr;
            static SaveDirtyPackages_method() {
                SaveDirtyPackages_ptr = Main.GetMethodUFunction(EditorLoadingAndSavingUtils.StaticClass, "SaveDirtyPackages");
            }

            internal static unsafe bool Invoke(bool bSaveMapPackages, bool bSaveContentPackages) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bSaveMapPackages;
                *((bool*)(b+1)) = bSaveContentPackages;
                Main.GetProcessEvent(EditorLoadingAndSavingUtils.DefaultObject, SaveDirtyPackages_ptr, new IntPtr(p)); ;
                return *((bool*)(b+2));
            }
        }
        internal struct SaveDirtyPackagesWithDialog_method {
            static internal IntPtr SaveDirtyPackagesWithDialog_ptr;
            static SaveDirtyPackagesWithDialog_method() {
                SaveDirtyPackagesWithDialog_ptr = Main.GetMethodUFunction(EditorLoadingAndSavingUtils.StaticClass, "SaveDirtyPackagesWithDialog");
            }

            internal static unsafe bool Invoke(bool bSaveMapPackages, bool bSaveContentPackages) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bSaveMapPackages;
                *((bool*)(b+1)) = bSaveContentPackages;
                Main.GetProcessEvent(EditorLoadingAndSavingUtils.DefaultObject, SaveDirtyPackagesWithDialog_ptr, new IntPtr(p)); ;
                return *((bool*)(b+2));
            }
        }
        internal struct SaveMap_method {
            static internal IntPtr SaveMap_ptr;
            static SaveMap_method() {
                SaveMap_ptr = Main.GetMethodUFunction(EditorLoadingAndSavingUtils.StaticClass, "SaveMap");
            }

            internal static unsafe bool Invoke(World World, string AssetPath) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = World;
                var AssetPath_handle = GCHandle.Alloc(AssetPath, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = AssetPath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = AssetPath.Length;
                *(int*)(b+IntPtr.Size+4+8) = AssetPath.Length;
                Main.GetProcessEvent(EditorLoadingAndSavingUtils.DefaultObject, SaveMap_ptr, new IntPtr(p)); ;
                AssetPath_handle.Free();
                return *((bool*)(b+24));
            }
        }
        internal struct SavePackages_method {
            static internal IntPtr SavePackages_ptr;
            static SavePackages_method() {
                SavePackages_ptr = Main.GetMethodUFunction(EditorLoadingAndSavingUtils.StaticClass, "SavePackages");
            }

            internal static unsafe bool Invoke(byte PackagesToSave /*TODO: array TArray */, bool bOnlyDirty) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PackagesToSave
                *((bool*)(b+16)) = bOnlyDirty;
                Main.GetProcessEvent(EditorLoadingAndSavingUtils.DefaultObject, SavePackages_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PackagesToSave
                return *((bool*)(b+17));
            }
        }
        internal struct SavePackagesWithDialog_method {
            static internal IntPtr SavePackagesWithDialog_ptr;
            static SavePackagesWithDialog_method() {
                SavePackagesWithDialog_ptr = Main.GetMethodUFunction(EditorLoadingAndSavingUtils.StaticClass, "SavePackagesWithDialog");
            }

            internal static unsafe bool Invoke(byte PackagesToSave /*TODO: array TArray */, bool bOnlyDirty) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PackagesToSave
                *((bool*)(b+16)) = bOnlyDirty;
                Main.GetProcessEvent(EditorLoadingAndSavingUtils.DefaultObject, SavePackagesWithDialog_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PackagesToSave
                return *((bool*)(b+17));
            }
        }
        internal struct UnloadPackages_method {
            static internal IntPtr UnloadPackages_ptr;
            static UnloadPackages_method() {
                UnloadPackages_ptr = Main.GetMethodUFunction(EditorLoadingAndSavingUtils.StaticClass, "UnloadPackages");
            }

            internal static unsafe (bool, byte /*TODO: text FText*/) Invoke(byte PackagesToUnload /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PackagesToUnload
                Main.GetProcessEvent(EditorLoadingAndSavingUtils.DefaultObject, UnloadPackages_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PackagesToUnload
                 //TODO: text FText OutErrorMessage
                return (*((bool*)(b+16)),UObject.NotImplemented<byte>() /*TODO: text FText*/);
            }
        }
    }
    internal unsafe struct EditorLoadingAndSavingUtils_events {
    }
}

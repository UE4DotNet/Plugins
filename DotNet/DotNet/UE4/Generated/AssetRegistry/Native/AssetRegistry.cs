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
    internal unsafe struct AssetRegistry_fields {
    }
    internal unsafe struct AssetRegistry_methods {
        internal struct GetAllAssets_method {
            static internal IntPtr GetAllAssets_ptr;
            static GetAllAssets_method() {
                GetAllAssets_ptr = Main.GetMethodUFunction(AssetRegistry.StaticClass, "GetAllAssets");
            }

            internal static unsafe (IReadOnlyCollection<AssetData>, bool) Invoke(IntPtr obj, bool bIncludeOnlyOnDiskAssets) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+16)) = bIncludeOnlyOnDiskAssets;
                Main.GetProcessEvent(obj, GetAllAssets_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutAssetData
                return (UObject.ToUnmangedCollection<AssetData>(b+0),*((bool*)(b+17)));
            }
        }
        internal struct GetAllCachedPaths_method {
            static internal IntPtr GetAllCachedPaths_ptr;
            static GetAllCachedPaths_method() {
                GetAllCachedPaths_ptr = Main.GetMethodUFunction(AssetRegistry.StaticClass, "GetAllCachedPaths");
            }

            internal static unsafe IReadOnlyCollection<string> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAllCachedPaths_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutPathList
                return UObject.ToStringCollection(b+0);
            }
        }
        internal struct GetAssetByObjectPath_method {
            static internal IntPtr GetAssetByObjectPath_ptr;
            static GetAssetByObjectPath_method() {
                GetAssetByObjectPath_ptr = Main.GetMethodUFunction(AssetRegistry.StaticClass, "GetAssetByObjectPath");
            }

            internal static unsafe AssetData Invoke(IntPtr obj, Name ObjectPath, bool bIncludeOnlyOnDiskAssets) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ObjectPath;
                *((bool*)(b+12)) = bIncludeOnlyOnDiskAssets;
                Main.GetProcessEvent(obj, GetAssetByObjectPath_ptr, new IntPtr(p)); ;
                return *((AssetData*)(b+16));
            }
        }
        internal struct GetAssets_method {
            static internal IntPtr GetAssets_ptr;
            static GetAssets_method() {
                GetAssets_ptr = Main.GetMethodUFunction(AssetRegistry.StaticClass, "GetAssets");
            }

            internal static unsafe (IReadOnlyCollection<AssetData>, bool) Invoke(IntPtr obj, ARFilter Filter) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((ARFilter*)(b+0)) = Filter;
                Main.GetProcessEvent(obj, GetAssets_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutAssetData
                return (UObject.ToUnmangedCollection<AssetData>(b+232),*((bool*)(b+248)));
            }
        }
        internal struct GetAssetsByClass_method {
            static internal IntPtr GetAssetsByClass_ptr;
            static GetAssetsByClass_method() {
                GetAssetsByClass_ptr = Main.GetMethodUFunction(AssetRegistry.StaticClass, "GetAssetsByClass");
            }

            internal static unsafe (IReadOnlyCollection<AssetData>, bool) Invoke(IntPtr obj, Name ClassName, bool bSearchSubClasses) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ClassName;
                *((bool*)(b+32)) = bSearchSubClasses;
                Main.GetProcessEvent(obj, GetAssetsByClass_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutAssetData
                return (UObject.ToUnmangedCollection<AssetData>(b+16),*((bool*)(b+33)));
            }
        }
        internal struct GetAssetsByPackageName_method {
            static internal IntPtr GetAssetsByPackageName_ptr;
            static GetAssetsByPackageName_method() {
                GetAssetsByPackageName_ptr = Main.GetMethodUFunction(AssetRegistry.StaticClass, "GetAssetsByPackageName");
            }

            internal static unsafe (IReadOnlyCollection<AssetData>, bool) Invoke(IntPtr obj, Name PackageName, bool bIncludeOnlyOnDiskAssets) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = PackageName;
                *((bool*)(b+32)) = bIncludeOnlyOnDiskAssets;
                Main.GetProcessEvent(obj, GetAssetsByPackageName_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutAssetData
                return (UObject.ToUnmangedCollection<AssetData>(b+16),*((bool*)(b+33)));
            }
        }
        internal struct GetAssetsByPath_method {
            static internal IntPtr GetAssetsByPath_ptr;
            static GetAssetsByPath_method() {
                GetAssetsByPath_ptr = Main.GetMethodUFunction(AssetRegistry.StaticClass, "GetAssetsByPath");
            }

            internal static unsafe (IReadOnlyCollection<AssetData>, bool) Invoke(IntPtr obj, Name PackagePath, bool bRecursive, bool bIncludeOnlyOnDiskAssets) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = PackagePath;
                *((bool*)(b+32)) = bRecursive;
                *((bool*)(b+33)) = bIncludeOnlyOnDiskAssets;
                Main.GetProcessEvent(obj, GetAssetsByPath_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutAssetData
                return (UObject.ToUnmangedCollection<AssetData>(b+16),*((bool*)(b+34)));
            }
        }
        internal struct GetSubPaths_method {
            static internal IntPtr GetSubPaths_ptr;
            static GetSubPaths_method() {
                GetSubPaths_ptr = Main.GetMethodUFunction(AssetRegistry.StaticClass, "GetSubPaths");
            }

            internal static unsafe IReadOnlyCollection<string> Invoke(IntPtr obj, string InBasePath, bool bInRecurse) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InBasePath_handle = GCHandle.Alloc(InBasePath, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InBasePath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InBasePath.Length;
                *(int*)(b+IntPtr.Size+4+0) = InBasePath.Length;
                *((bool*)(b+32)) = bInRecurse;
                Main.GetProcessEvent(obj, GetSubPaths_ptr, new IntPtr(p)); ;
                InBasePath_handle.Free();
                 //TODO: array TArray OutPathList
                return UObject.ToStringCollection(b+16);
            }
        }
        internal struct HasAssets_method {
            static internal IntPtr HasAssets_ptr;
            static HasAssets_method() {
                HasAssets_ptr = Main.GetMethodUFunction(AssetRegistry.StaticClass, "HasAssets");
            }

            internal static unsafe bool Invoke(IntPtr obj, Name PackagePath, bool bRecursive) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = PackagePath;
                *((bool*)(b+12)) = bRecursive;
                Main.GetProcessEvent(obj, HasAssets_ptr, new IntPtr(p)); ;
                return *((bool*)(b+13));
            }
        }
        internal struct IsLoadingAssets_method {
            static internal IntPtr IsLoadingAssets_ptr;
            static IsLoadingAssets_method() {
                IsLoadingAssets_ptr = Main.GetMethodUFunction(AssetRegistry.StaticClass, "IsLoadingAssets");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsLoadingAssets_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct PrioritizeSearchPath_method {
            static internal IntPtr PrioritizeSearchPath_ptr;
            static PrioritizeSearchPath_method() {
                PrioritizeSearchPath_ptr = Main.GetMethodUFunction(AssetRegistry.StaticClass, "PrioritizeSearchPath");
            }

            internal static unsafe void Invoke(IntPtr obj, string PathToPrioritize) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var PathToPrioritize_handle = GCHandle.Alloc(PathToPrioritize, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = PathToPrioritize_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = PathToPrioritize.Length;
                *(int*)(b+IntPtr.Size+4+0) = PathToPrioritize.Length;
                Main.GetProcessEvent(obj, PrioritizeSearchPath_ptr, new IntPtr(p)); ;
                PathToPrioritize_handle.Free();
            }
        }
        internal struct RunAssetsThroughFilter_method {
            static internal IntPtr RunAssetsThroughFilter_ptr;
            static RunAssetsThroughFilter_method() {
                RunAssetsThroughFilter_ptr = Main.GetMethodUFunction(AssetRegistry.StaticClass, "RunAssetsThroughFilter");
            }

            internal static unsafe IReadOnlyCollection<AssetData> Invoke(IntPtr obj, ARFilter Filter) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((ARFilter*)(b+16)) = Filter;
                Main.GetProcessEvent(obj, RunAssetsThroughFilter_ptr, new IntPtr(p)); ;
                 //TODO: array TArray AssetDataList
                return UObject.ToUnmangedCollection<AssetData>(b+0);
            }
        }
        internal struct ScanFilesSynchronous_method {
            static internal IntPtr ScanFilesSynchronous_ptr;
            static ScanFilesSynchronous_method() {
                ScanFilesSynchronous_ptr = Main.GetMethodUFunction(AssetRegistry.StaticClass, "ScanFilesSynchronous");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InFilePaths /*TODO: array TArray */, bool bForceRescan) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray InFilePaths
                *((bool*)(b+16)) = bForceRescan;
                Main.GetProcessEvent(obj, ScanFilesSynchronous_ptr, new IntPtr(p)); ;
                 //TODO: array TArray InFilePaths
            }
        }
        internal struct ScanModifiedAssetFiles_method {
            static internal IntPtr ScanModifiedAssetFiles_ptr;
            static ScanModifiedAssetFiles_method() {
                ScanModifiedAssetFiles_ptr = Main.GetMethodUFunction(AssetRegistry.StaticClass, "ScanModifiedAssetFiles");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InFilePaths /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray InFilePaths
                Main.GetProcessEvent(obj, ScanModifiedAssetFiles_ptr, new IntPtr(p)); ;
                 //TODO: array TArray InFilePaths
            }
        }
        internal struct ScanPathsSynchronous_method {
            static internal IntPtr ScanPathsSynchronous_ptr;
            static ScanPathsSynchronous_method() {
                ScanPathsSynchronous_ptr = Main.GetMethodUFunction(AssetRegistry.StaticClass, "ScanPathsSynchronous");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InPaths /*TODO: array TArray */, bool bForceRescan) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray InPaths
                *((bool*)(b+16)) = bForceRescan;
                Main.GetProcessEvent(obj, ScanPathsSynchronous_ptr, new IntPtr(p)); ;
                 //TODO: array TArray InPaths
            }
        }
        internal struct SearchAllAssets_method {
            static internal IntPtr SearchAllAssets_ptr;
            static SearchAllAssets_method() {
                SearchAllAssets_ptr = Main.GetMethodUFunction(AssetRegistry.StaticClass, "SearchAllAssets");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bSynchronousSearch) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bSynchronousSearch;
                Main.GetProcessEvent(obj, SearchAllAssets_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct AssetRegistry_events {
    }
}

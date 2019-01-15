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

#pragma warning disable CS0108
using UE4.AssetRegistry.Native;

namespace UE4.AssetRegistry {
    ///<summary>Asset Registry</summary>
    public unsafe partial class AssetRegistry : Interface  {

        ///<summary>Gets asset data for all assets in the registry.</summary>
        ///<remarks>
        ///This method may be slow, use a filter if possible to avoid iterating over the entire registry.
        ///
        ///@param OutAssetData the list of assets in this path
        ///</remarks>
        public (IReadOnlyCollection<AssetData>, bool) GetAllAssets(bool bIncludeOnlyOnDiskAssets)  => 
            AssetRegistry_methods.GetAllAssets_method.Invoke(ObjPointer, bIncludeOnlyOnDiskAssets);

        ///<summary>Gets a list of all paths that are currently cached</summary>
        public IReadOnlyCollection<string> GetAllCachedPaths()  => 
            AssetRegistry_methods.GetAllCachedPaths_method.Invoke(ObjPointer);

        ///<summary>
        ///Gets the asset data for the specified object path
        ///@
        ///</summary>
        ///<remarks>
        ///param ObjectPath the path of the object to be looked up
        ///@param bIncludeOnlyOnDiskAssets if true, in-memory objects will be ignored. The call will be faster.
        ///@return the assets data;Will be invalid if object could not be found
        ///</remarks>
        public AssetData GetAssetByObjectPath(Name ObjectPath, bool bIncludeOnlyOnDiskAssets)  => 
            AssetRegistry_methods.GetAssetByObjectPath_method.Invoke(ObjPointer, ObjectPath, bIncludeOnlyOnDiskAssets);

        ///<summary>Gets asset data for all assets that match the filter.</summary>
        ///<remarks>
        ///Assets returned must satisfy every filter component if there is at least one element in the component's array.
        ///Assets will satisfy a component if they match any of the elements in it.
        ///
        ///@param Filter filter to apply to the assets in the AssetRegistry
        ///@param OutAssetData the list of assets in this path
        ///</remarks>
        public (IReadOnlyCollection<AssetData>, bool) GetAssets(ARFilter Filter)  => 
            AssetRegistry_methods.GetAssets_method.Invoke(ObjPointer, Filter);

        ///<summary>
        ///Gets asset data for all assets with the supplied class
        ///@
        ///</summary>
        ///<remarks>
        ///param ClassName the class name of the assets requested
        ///@param OutAssetData the list of assets in this path
        ///@param bSearchSubClasses if true, all subclasses of the passed in class will be searched as well
        ///</remarks>
        public (IReadOnlyCollection<AssetData>, bool) GetAssetsByClass(Name ClassName, bool bSearchSubClasses)  => 
            AssetRegistry_methods.GetAssetsByClass_method.Invoke(ObjPointer, ClassName, bSearchSubClasses);

        ///<summary>
        ///Gets asset data for the assets in the package with the specified package name
        ///@
        ///</summary>
        ///<remarks>
        ///param PackageName the package name for the requested assets
        ///@param OutAssetData the list of assets in this path
        ///</remarks>
        public (IReadOnlyCollection<AssetData>, bool) GetAssetsByPackageName(Name PackageName, bool bIncludeOnlyOnDiskAssets)  => 
            AssetRegistry_methods.GetAssetsByPackageName_method.Invoke(ObjPointer, PackageName, bIncludeOnlyOnDiskAssets);

        ///<summary>
        ///Gets asset data for all assets in the supplied folder path
        ///@
        ///</summary>
        ///<remarks>
        ///param PackagePath the path to query asset data in
        ///@param OutAssetData the list of assets in this path
        ///@param bRecursive if true, all supplied paths will be searched recursively
        ///</remarks>
        public (IReadOnlyCollection<AssetData>, bool) GetAssetsByPath(Name PackagePath, bool bRecursive, bool bIncludeOnlyOnDiskAssets)  => 
            AssetRegistry_methods.GetAssetsByPath_method.Invoke(ObjPointer, PackagePath, bRecursive, bIncludeOnlyOnDiskAssets);

        ///<summary>Gets a list of all paths that are currently cached below the passed-in base path</summary>
        public IReadOnlyCollection<string> GetSubPaths(string InBasePath, bool bInRecurse)  => 
            AssetRegistry_methods.GetSubPaths_method.Invoke(ObjPointer, InBasePath, bInRecurse);

        ///<summary>
        ///Does the given path contain assets, optionally also testing sub-paths?
        ///@
        ///</summary>
        ///<remarks>
        ///param PackagePath the path to query asset data in
        ///@param bRecursive if true, the supplied path will be tested recursively
        ///</remarks>
        public bool HasAssets(Name PackagePath, bool bRecursive)  => 
            AssetRegistry_methods.HasAssets_method.Invoke(ObjPointer, PackagePath, bRecursive);

        ///<summary>Returns true if the asset registry is currently loading files and does not yet know about all assets</summary>
        public bool IsLoadingAssets()  => 
            AssetRegistry_methods.IsLoadingAssets_method.Invoke(ObjPointer);

        ///<summary>If assets are currently being asynchronously scanned in the specified path, this will cause them to be scanned before other assets.</summary>
        public void PrioritizeSearchPath(string PathToPrioritize)  => 
            AssetRegistry_methods.PrioritizeSearchPath_method.Invoke(ObjPointer, PathToPrioritize);

        ///<summary>Trims items out of the asset data list that do not pass the supplied filter</summary>
        public IReadOnlyCollection<AssetData> RunAssetsThroughFilter(ARFilter Filter)  => 
            AssetRegistry_methods.RunAssetsThroughFilter_method.Invoke(ObjPointer, Filter);

        ///<summary>Scan the specified individual files right now and populate the asset registry. If bForceRescan is true, the paths will be scanned again, even if they were previously scanned</summary>
        public void ScanFilesSynchronous(byte InFilePaths /*TODO: array TArray */, bool bForceRescan)  => 
            AssetRegistry_methods.ScanFilesSynchronous_method.Invoke(ObjPointer, InFilePaths, bForceRescan);

        ///<summary>Forces a rescan of specific filenames, call this when you need to refresh from disk</summary>
        public void ScanModifiedAssetFiles(byte InFilePaths /*TODO: array TArray */)  => 
            AssetRegistry_methods.ScanModifiedAssetFiles_method.Invoke(ObjPointer, InFilePaths);

        ///<summary>Scan the supplied paths recursively right now and populate the asset registry. If bForceRescan is true, the paths will be scanned again, even if they were previously scanned</summary>
        public void ScanPathsSynchronous(byte InPaths /*TODO: array TArray */, bool bForceRescan)  => 
            AssetRegistry_methods.ScanPathsSynchronous_method.Invoke(ObjPointer, InPaths, bForceRescan);

        ///<summary>Look for all assets on disk (can be async or synchronous)</summary>
        public void SearchAllAssets(bool bSynchronousSearch)  => 
            AssetRegistry_methods.SearchAllAssets_method.Invoke(ObjPointer, bSynchronousSearch);
        static AssetRegistry() {
            StaticClass = Main.GetClass("AssetRegistry");
        }
        internal unsafe AssetRegistry_fields* AssetRegistry_ptr => (AssetRegistry_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AssetRegistry(IntPtr p) => UObject.Make<AssetRegistry>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AssetRegistry DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AssetRegistry New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

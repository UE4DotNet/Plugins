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
    ///<summary>Asset Registry Helpers</summary>
    public unsafe partial class AssetRegistryHelpers : UObject  {

        ///<summary>Creates asset data from a UObject.</summary>
        ///<remarks>
        ///@param InAsset       The asset to create asset data for
        ///@param bAllowBlueprintClass  By default trying to create asset data for a blueprint class will create one for the UBlueprint instead
        ///</remarks>
        public static AssetData CreateAssetData(UObject InAsset, bool bAllowBlueprintClass)  => 
            AssetRegistryHelpers_methods.CreateAssetData_method.Invoke(InAsset, bAllowBlueprintClass);

        ///<summary>Returns the asset UObject if it is loaded or loads the asset if it is unloaded then returns the result</summary>
        public static UObject GetAsset(AssetData InAssetData)  => 
            AssetRegistryHelpers_methods.GetAsset_method.Invoke(InAssetData);

        ///<summary>Get Asset Registry</summary>
        public static AssetRegistry GetAssetRegistry()  => 
            AssetRegistryHelpers_methods.GetAssetRegistry_method.Invoke();

        ///<summary>Get Class</summary>
        public static SubclassOf<UObject> GetClass(AssetData InAssetData)  => 
            AssetRegistryHelpers_methods.GetClass_method.Invoke(InAssetData);

        ///<summary>Returns the name for the asset in the form: Class'ObjectPath'</summary>
        public static string GetExportTextName(AssetData InAssetData)  => 
            AssetRegistryHelpers_methods.GetExportTextName_method.Invoke(InAssetData);

        ///<summary>Returns the full name for the asset in the form: Class ObjectPath</summary>
        public static string GetFullName(AssetData InAssetData)  => 
            AssetRegistryHelpers_methods.GetFullName_method.Invoke(InAssetData);

        ///<summary>Gets the value associated with the given tag as a string</summary>
        public static (string, bool) GetTagValue(AssetData InAssetData, Name InTagName)  => 
            AssetRegistryHelpers_methods.GetTagValue_method.Invoke(InAssetData, InTagName);

        ///<summary>Returns true if the asset is loaded</summary>
        public static bool IsAssetLoaded(AssetData InAssetData)  => 
            AssetRegistryHelpers_methods.IsAssetLoaded_method.Invoke(InAssetData);

        ///<summary>Returns true if the this asset is a redirector.</summary>
        public static bool IsRedirector(AssetData InAssetData)  => 
            AssetRegistryHelpers_methods.IsRedirector_method.Invoke(InAssetData);

        ///<summary>Returns true if this is the primary asset in a package, true for maps and assets but false for secondary objects like class redirectors</summary>
        public static bool IsUAsset(AssetData InAssetData)  => 
            AssetRegistryHelpers_methods.IsUAsset_method.Invoke(InAssetData);

        ///<summary>Checks to see if this AssetData refers to an asset or is NULL</summary>
        public static bool IsValid(AssetData InAssetData)  => 
            AssetRegistryHelpers_methods.IsValid_method.Invoke(InAssetData);

        ///<summary>Populates the FARFilters tags and values map with the passed in tags and values</summary>
        public static ARFilter SetFilterTagsAndValues(ARFilter InFilter, byte InTagsAndValues /*TODO: array TArray */)  => 
            AssetRegistryHelpers_methods.SetFilterTagsAndValues_method.Invoke(InFilter, InTagsAndValues);

        ///<summary>Convert to a SoftObjectPath for loading</summary>
        public static SoftObjectPath ToSoftObjectPath(AssetData InAssetData)  => 
            AssetRegistryHelpers_methods.ToSoftObjectPath_method.Invoke(InAssetData);
        static AssetRegistryHelpers() {
            StaticClass = Main.GetClass("AssetRegistryHelpers");
        }
        internal unsafe AssetRegistryHelpers_fields* AssetRegistryHelpers_ptr => (AssetRegistryHelpers_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AssetRegistryHelpers(IntPtr p) => UObject.Make<AssetRegistryHelpers>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AssetRegistryHelpers DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AssetRegistryHelpers New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

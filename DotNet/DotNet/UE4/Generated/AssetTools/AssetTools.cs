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
using UE4.AssetTools.Native;
using UE4.UnrealEd;

namespace UE4.AssetTools {
    ///<summary>Asset Tools</summary>
    public unsafe partial class AssetTools : Interface  {

        ///<summary>
        ///Creates an asset with the specified name, path, and factory
        ///@
        ///</summary>
        ///<remarks>
        ///param AssetName the name of the new asset
        ///@param PackagePath the package that will contain the new asset
        ///@param AssetClass the class of the new asset
        ///@param Factory the factory that will build the new asset
        ///@param CallingContext optional name of the module or method calling CreateAsset() - this is passed to the factory
        ///@return the new asset or NULL if it fails
        ///</remarks>
        public UObject CreateAsset(string AssetName, string PackagePath, SubclassOf<UObject> AssetClass, Factory Factory, Name CallingContext)  => 
            AssetTools_methods.CreateAsset_method.Invoke(ObjPointer, AssetName, PackagePath, AssetClass, Factory, CallingContext);

        ///<summary>Opens an asset picker dialog and creates an asset with the specified name and path</summary>
        public UObject CreateAssetWithDialog(string AssetName, string PackagePath, SubclassOf<UObject> AssetClass, Factory Factory, Name CallingContext)  => 
            AssetTools_methods.CreateAssetWithDialog_method.Invoke(ObjPointer, AssetName, PackagePath, AssetClass, Factory, CallingContext);

        ///<summary>Creates a unique package and asset name taking the form InBasePackageName+InSuffix</summary>
        public (string, string) CreateUniqueAssetName(string InBasePackageName, string InSuffix)  => 
            AssetTools_methods.CreateUniqueAssetName_method.Invoke(ObjPointer, InBasePackageName, InSuffix);

        ///<summary>Creates an asset with the specified name and path. Uses OriginalObject as the duplication source.</summary>
        public UObject DuplicateAsset(string AssetName, string PackagePath, UObject OriginalObject)  => 
            AssetTools_methods.DuplicateAsset_method.Invoke(ObjPointer, AssetName, PackagePath, OriginalObject);

        ///<summary>Opens an asset picker dialog and creates an asset with the specified name and path. Uses OriginalObject as the duplication source.</summary>
        public UObject DuplicateAssetWithDialog(string AssetName, string PackagePath, UObject OriginalObject)  => 
            AssetTools_methods.DuplicateAssetWithDialog_method.Invoke(ObjPointer, AssetName, PackagePath, OriginalObject);

        ///<summary>Exports the specified objects to file.</summary>
        ///<remarks>
        ///@param       AssetsToExport                                  List of full asset names (e.g /Game/Path/Asset) to export
        ///@param       ExportPath                                              The directory path to export to.
        ///</remarks>
        public void ExportAssets(byte AssetsToExport /*TODO: array TArray */, string ExportPath)  => 
            AssetTools_methods.ExportAssets_method.Invoke(ObjPointer, AssetsToExport, ExportPath);

        ///<summary>Exports the specified objects to file.</summary>
        ///<remarks>
        ///First prompting the user to pick an export directory and optionally prompting the user to pick a unique directory per file
        ///
        ///@param       AssetsToExport                                  List of assets to export
        ///@param       ExportPath                                              The directory path to export to.
        ///</remarks>
        public void ExportAssetsWithDialog(byte AssetsToExport /*TODO: array TArray */, bool bPromptForIndividualFilenames)  => 
            AssetTools_methods.ExportAssetsWithDialog_method.Invoke(ObjPointer, AssetsToExport, bPromptForIndividualFilenames);

        ///<summary>Returns list of objects that soft reference the given soft object path. This will load assets into memory to verify</summary>
        public IReadOnlyCollection<UObject> FindSoftReferencesToObject(SoftObjectPath TargetObject)  => 
            AssetTools_methods.FindSoftReferencesToObject_method.Invoke(ObjPointer, TargetObject);

        ///<summary>Imports assets using data specified completely up front.</summary>
        ///<remarks>
        ///Does not ever ask any questions of the user or show any modal error messages
        ///
        ///@param AutomatedImportData   Data that specifies how to import each file
        ///@return list of successfully imported assets
        ///</remarks>
        public IReadOnlyCollection<UObject> ImportAssetsAutomated(AutomatedAssetImportData ImportData)  => 
            AssetTools_methods.ImportAssetsAutomated_method.Invoke(ObjPointer, ImportData);

        ///<summary>Opens a file open dialog to choose files to import to the destination path.</summary>
        ///<remarks>
        ///@param DestinationPath       Path to import files to
        ///@return list of successfully imported assets
        ///</remarks>
        public IReadOnlyCollection<UObject> ImportAssetsWithDialog(string DestinationPath)  => 
            AssetTools_methods.ImportAssetsWithDialog_method.Invoke(ObjPointer, DestinationPath);

        ///<summary>Imports assets using tasks specified.</summary>
        ///<remarks>
        ///@param ImportTasks    Tasks that specify how to import each file
        ///@return list of successfully imported assets
        ///</remarks>
        public void ImportAssetTasks(byte ImportTasks /*TODO: array TArray */)  => 
            AssetTools_methods.ImportAssetTasks_method.Invoke(ObjPointer, ImportTasks);

        ///<summary>Opens editor for assets</summary>
        public void OpenEditorForAssets(byte Assets /*TODO: array TArray */)  => 
            AssetTools_methods.OpenEditorForAssets_method.Invoke(ObjPointer, Assets);

        ///<summary>Renames assets using the specified names.</summary>
        public bool RenameAssets(byte AssetsAndNames /*TODO: array TArray */)  => 
            AssetTools_methods.RenameAssets_method.Invoke(ObjPointer, AssetsAndNames);

        ///<summary>Renames assets using the specified names.</summary>
        public void RenameAssetsWithDialog(byte AssetsAndNames /*TODO: array TArray */, bool bAutoCheckout)  => 
            AssetTools_methods.RenameAssetsWithDialog_method.Invoke(ObjPointer, AssetsAndNames, bAutoCheckout);
        static AssetTools() {
            StaticClass = Main.GetClass("AssetTools");
        }
        internal unsafe AssetTools_fields* AssetTools_ptr => (AssetTools_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AssetTools(IntPtr p) => UObject.Make<AssetTools>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AssetTools DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AssetTools New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

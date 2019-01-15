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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>
    ///This class is a wrapper for editor loading and saving functionality
    ///It is meant to contain only functions that can be executed in script (but are also allowed in C++).
    ///</summary>
    ///<remarks>
    ///It is separated from FEditorFileUtils to ensure new easier to use methods can be created without breaking FEditorFileUtils backwards compatibility
    ///However this should be used in place of FEditorFileUtils wherever possible as the goal is to deprecate FEditorFileUtils eventually
    ///</remarks>
    public unsafe partial class EditorLoadingAndSavingUtils : UObject  {

        ///<summary>Exports the current scene</summary>
        public static void ExportScene(bool bExportSelectedActorsOnly)  => 
            EditorLoadingAndSavingUtils_methods.ExportScene_method.Invoke(bExportSelectedActorsOnly);

        ///<summary>Appends array with all currently dirty content packages.</summary>
        ///<remarks>
        ///@param OutDirtyPackages Array to append dirty packages to.
        ///</remarks>
        public static IReadOnlyCollection<Package> GetDirtyContentPackages()  => 
            EditorLoadingAndSavingUtils_methods.GetDirtyContentPackages_method.Invoke();

        ///<summary>Appends array with all currently dirty map packages.</summary>
        ///<remarks>
        ///@param OutDirtyPackages Array to append dirty packages to.
        ///</remarks>
        public static IReadOnlyCollection<Package> GetDirtyMapPackages()  => 
            EditorLoadingAndSavingUtils_methods.GetDirtyMapPackages_method.Invoke();

        ///<summary>Imports a file such as (FBX or obj) and spawns actors f into the current level</summary>
        public static void ImportScene(string Filename)  => 
            EditorLoadingAndSavingUtils_methods.ImportScene_method.Invoke(Filename);

        ///<summary>Loads the specified map.</summary>
        ///<remarks>
        ///Does not prompt the user to save the current map.
        ///
        ///@param       Filename                Level package filename, including path.
        ///@return                                      true if the map was loaded successfully.
        ///</remarks>
        public static World LoadMap(string Filename)  => 
            EditorLoadingAndSavingUtils_methods.LoadMap_method.Invoke(Filename);

        ///<summary>
        ///Prompts the user to save the current map if necessary, the presents a load dialog and
        ///loads a new map if selected by the user.
        ///</summary>
        public static World LoadMapWithDialog()  => 
            EditorLoadingAndSavingUtils_methods.LoadMapWithDialog_method.Invoke();

        ///<summary>New Blank Map</summary>
        public static World NewBlankMap(bool bSaveExistingMap)  => 
            EditorLoadingAndSavingUtils_methods.NewBlankMap_method.Invoke(bSaveExistingMap);

        ///<summary>New Map from Template</summary>
        public static World NewMapFromTemplate(string PathToTemplateLevel, bool bSaveExistingMap)  => 
            EditorLoadingAndSavingUtils_methods.NewMapFromTemplate_method.Invoke(PathToTemplateLevel, bSaveExistingMap);

        ///<summary>Saves the active level, prompting the use for checkout if necessary.</summary>
        ///<remarks>
        ///@return      true on success, False on fail
        ///</remarks>
        public static bool SaveCurrentLevel()  => 
            EditorLoadingAndSavingUtils_methods.SaveCurrentLevel_method.Invoke();

        ///<summary>Looks at all currently loaded packages and saves them if their "bDirty" flag is set.</summary>
        ///<remarks>
        ///Assume all dirty packages should be saved and check out from source control (if enabled).
        ///
        ///@param       bSaveMapPackages                        true if map packages should be saved
        ///@param       bSaveContentPackages            true if we should save content packages.
        ///@return                                                              true on success, false on fail.
        ///</remarks>
        public static bool SaveDirtyPackages(bool bSaveMapPackages, bool bSaveContentPackages)  => 
            EditorLoadingAndSavingUtils_methods.SaveDirtyPackages_method.Invoke(bSaveMapPackages, bSaveContentPackages);

        ///<summary>Looks at all currently loaded packages and saves them if their "bDirty" flag is set.</summary>
        ///<remarks>
        ///Prompt the user to select which dirty packages to save and check them out from source control (if enabled).
        ///
        ///
        ///@param       bSaveMapPackages                        true if map packages should be saved
        ///@param       bSaveContentPackages            true if we should save content packages.
        ///@return                                                              true on success, false on fail.
        ///</remarks>
        public static bool SaveDirtyPackagesWithDialog(bool bSaveMapPackages, bool bSaveContentPackages)  => 
            EditorLoadingAndSavingUtils_methods.SaveDirtyPackagesWithDialog_method.Invoke(bSaveMapPackages, bSaveContentPackages);

        ///<summary>Saves the specified map, returning true on success.</summary>
        ///<remarks>
        ///@param       World                   The world to save.
        ///@param       AssetPath               The valid content directory path and name for the asset.  E.g "/Game/MyMap"
        ///
        ///@return                                      true if the map was saved successfully.
        ///</remarks>
        public static bool SaveMap(World World, string AssetPath)  => 
            EditorLoadingAndSavingUtils_methods.SaveMap_method.Invoke(World, AssetPath);

        ///<summary>Save all packages.</summary>
        ///<remarks>
        ///Assume all dirty packages should be saved and check out from source control (if enabled).
        ///
        ///@param               PackagesToSave                          The list of packages to save.  Both map and content packages are supported
        ///@param               bCheckDirty                                     If true, only packages that are dirty in PackagesToSave will be saved
        ///@return                                                                      true on success, false on fail.
        ///</remarks>
        public static bool SavePackages(byte PackagesToSave /*TODO: array TArray */, bool bOnlyDirty)  => 
            EditorLoadingAndSavingUtils_methods.SavePackages_method.Invoke(PackagesToSave, bOnlyDirty);

        ///<summary>Save all packages.</summary>
        ///<remarks>
        ///Optionally prompting the user to select which packages to save.
        ///Prompt the user to select which dirty packages to save and check them out from source control (if enabled).
        ///
        ///@param                PackagesToSave                          The list of packages to save.  Both map and content packages are supported
        ///@param                bCheckDirty                                     If true, only packages that are dirty in PackagesToSave will be saved
        ///@return                                                                       true on success, false on fail.
        ///</remarks>
        public static bool SavePackagesWithDialog(byte PackagesToSave /*TODO: array TArray */, bool bOnlyDirty)  => 
            EditorLoadingAndSavingUtils_methods.SavePackagesWithDialog_method.Invoke(PackagesToSave, bOnlyDirty);

        ///<summary>
        ///Unloads a list of packages
        ///@
        ///</summary>
        ///<remarks>param PackagesToUnload Array of packages to unload.</remarks>
        public static (bool, byte /*TODO: text FText*/) UnloadPackages(byte PackagesToUnload /*TODO: array TArray */)  => 
            EditorLoadingAndSavingUtils_methods.UnloadPackages_method.Invoke(PackagesToUnload);
        static EditorLoadingAndSavingUtils() {
            StaticClass = Main.GetClass("EditorLoadingAndSavingUtils");
        }
        internal unsafe EditorLoadingAndSavingUtils_fields* EditorLoadingAndSavingUtils_ptr => (EditorLoadingAndSavingUtils_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditorLoadingAndSavingUtils(IntPtr p) => UObject.Make<EditorLoadingAndSavingUtils>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditorLoadingAndSavingUtils DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditorLoadingAndSavingUtils New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

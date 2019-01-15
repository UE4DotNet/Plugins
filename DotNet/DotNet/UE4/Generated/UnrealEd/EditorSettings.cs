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
    ///<summary>Editor Settings</summary>
    public unsafe partial class EditorSettings : UObject  {
        public bool bLoadTheMostRecentlyLoadedProjectAtStartup {
            get {return Main.GetGetBoolPropertyByName(this, "bLoadTheMostRecentlyLoadedProjectAtStartup"); }
            set {Main.SetGetBoolPropertyByName(this, "bLoadTheMostRecentlyLoadedProjectAtStartup", value); }
        }
        ///<summary>Directory to be used for caching derived data locally (native textures, compiled shaders, etc...). The editor must be restarted for changes to take effect.</summary>
        public unsafe DirectoryPath LocalDerivedDataCache {
            get {return EditorSettings_ptr->LocalDerivedDataCache;}
            set {EditorSettings_ptr->LocalDerivedDataCache = value;}
        }
        ///<summary>Path to a network share that can be used for sharing derived data (native textures, compiled shaders, etc...) with a team. Will not disabled if this directory cannot be accessed. The editor must be restarted for changes to take effect.</summary>
        public unsafe DirectoryPath SharedDerivedDataCache {
            get {return EditorSettings_ptr->SharedDerivedDataCache;}
            set {EditorSettings_ptr->SharedDerivedDataCache = value;}
        }
         //TODO: array not UObject TArray RecentlyOpenedProjectFiles
         //TODO: array not UObject TArray CreatedProjectPaths
        public bool bCopyStarterContentPreference {
            get {return Main.GetGetBoolPropertyByName(this, "bCopyStarterContentPreference"); }
            set {Main.SetGetBoolPropertyByName(this, "bCopyStarterContentPreference", value); }
        }
         //TODO: array not UObject TArray CompletedSurveys
         //TODO: array not UObject TArray InProgressSurveys
        ///<summary>Auto Scalability Work Scale Amount</summary>
        public unsafe float AutoScalabilityWorkScaleAmount {
            get {return EditorSettings_ptr->AutoScalabilityWorkScaleAmount;}
            set {EditorSettings_ptr->AutoScalabilityWorkScaleAmount = value;}
        }
        static EditorSettings() {
            StaticClass = Main.GetClass("EditorSettings");
        }
        internal unsafe EditorSettings_fields* EditorSettings_ptr => (EditorSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditorSettings(IntPtr p) => UObject.Make<EditorSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditorSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditorSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

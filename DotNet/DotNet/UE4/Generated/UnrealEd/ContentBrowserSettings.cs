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

namespace UE4.UnrealEd {
    ///<summary>Implements content browser settings.  These are global not per-project</summary>
    public unsafe partial class ContentBrowserSettings : UObject  {
        ///<summary>The number of objects to load at once in the Content Browser before displaying a warning about loading many assets</summary>
        public unsafe int NumObjectsToLoadBeforeWarning {
            get {return ContentBrowserSettings_ptr->NumObjectsToLoadBeforeWarning;}
            set {ContentBrowserSettings_ptr->NumObjectsToLoadBeforeWarning = value;}
        }
        public bool bOpenSourcesPanelByDefault {
            get {return Main.GetGetBoolPropertyByName(this, "bOpenSourcesPanelByDefault"); }
            set {Main.SetGetBoolPropertyByName(this, "bOpenSourcesPanelByDefault", value); }
        }
        public bool RealTimeThumbnails {
            get {return Main.GetGetBoolPropertyByName(this, "RealTimeThumbnails"); }
            set {Main.SetGetBoolPropertyByName(this, "RealTimeThumbnails", value); }
        }
        public bool DisplayFolders {
            get {return Main.GetGetBoolPropertyByName(this, "DisplayFolders"); }
            set {Main.SetGetBoolPropertyByName(this, "DisplayFolders", value); }
        }
        public bool DisplayEmptyFolders {
            get {return Main.GetGetBoolPropertyByName(this, "DisplayEmptyFolders"); }
            set {Main.SetGetBoolPropertyByName(this, "DisplayEmptyFolders", value); }
        }
        ///<summary>The number of objects to keep in the Content Browser Recently Opened filter</summary>
        public unsafe int NumObjectsInRecentList {
            get {return ContentBrowserSettings_ptr->NumObjectsInRecentList;}
            set {ContentBrowserSettings_ptr->NumObjectsInRecentList = value;}
        }
        public bool DisplayEngineFolder {
            get {return Main.GetGetBoolPropertyByName(this, "DisplayEngineFolder"); }
            set {Main.SetGetBoolPropertyByName(this, "DisplayEngineFolder", value); }
        }
        public bool DisplayDevelopersFolder {
            get {return Main.GetGetBoolPropertyByName(this, "DisplayDevelopersFolder"); }
            set {Main.SetGetBoolPropertyByName(this, "DisplayDevelopersFolder", value); }
        }
        public bool DisplayL10NFolder {
            get {return Main.GetGetBoolPropertyByName(this, "DisplayL10NFolder"); }
            set {Main.SetGetBoolPropertyByName(this, "DisplayL10NFolder", value); }
        }
        public bool DisplayPluginFolders {
            get {return Main.GetGetBoolPropertyByName(this, "DisplayPluginFolders"); }
            set {Main.SetGetBoolPropertyByName(this, "DisplayPluginFolders", value); }
        }
        public bool DisplayCollections {
            get {return Main.GetGetBoolPropertyByName(this, "DisplayCollections"); }
            set {Main.SetGetBoolPropertyByName(this, "DisplayCollections", value); }
        }
        public bool DisplayFavorites {
            get {return Main.GetGetBoolPropertyByName(this, "DisplayFavorites"); }
            set {Main.SetGetBoolPropertyByName(this, "DisplayFavorites", value); }
        }
        public bool DisplayCppFolders {
            get {return Main.GetGetBoolPropertyByName(this, "DisplayCppFolders"); }
            set {Main.SetGetBoolPropertyByName(this, "DisplayCppFolders", value); }
        }
        public bool IncludeClassNames {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeClassNames"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeClassNames", value); }
        }
        public bool IncludeAssetPaths {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeAssetPaths"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeAssetPaths", value); }
        }
        public bool IncludeCollectionNames {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeCollectionNames"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeCollectionNames", value); }
        }
        static ContentBrowserSettings() {
            StaticClass = Main.GetClass("ContentBrowserSettings");
        }
        internal unsafe ContentBrowserSettings_fields* ContentBrowserSettings_ptr => (ContentBrowserSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ContentBrowserSettings(IntPtr p) => UObject.Make<ContentBrowserSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ContentBrowserSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ContentBrowserSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
using UE4.PluginBrowser.Native;

namespace UE4.PluginBrowser {
    ///<summary>We use this object to display plugin properties using details view.</summary>
    public unsafe partial class PluginMetadataObject : UObject  {
        ///<summary>Version number for the plugin.</summary>
        ///<remarks>
        ///The version number must increase with every version of the plugin, so that the system
        ///      can determine whether one version of a plugin is newer than another, or to enforce other requirements.  This version
        ///      number is not displayed in front-facing UI.  Use the VersionName for that.
        ///</remarks>
        public unsafe int Version {
            get {return PluginMetadataObject_ptr->Version;}
            set {PluginMetadataObject_ptr->Version = value;}
        }
         //TODO: string FString VersionName
         //TODO: string FString FriendlyName
         //TODO: string FString Description
         //TODO: string FString Category
         //TODO: string FString CreatedBy
         //TODO: string FString CreatedByURL
         //TODO: string FString DocsURL
         //TODO: string FString MarketplaceURL
         //TODO: string FString SupportURL
        public bool bCanContainContent {
            get {return Main.GetGetBoolPropertyByName(this, "bCanContainContent"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanContainContent", value); }
        }
        public bool bIsBetaVersion {
            get {return Main.GetGetBoolPropertyByName(this, "bIsBetaVersion"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsBetaVersion", value); }
        }
        static PluginMetadataObject() {
            StaticClass = Main.GetClass("PluginMetadataObject");
        }
        internal unsafe PluginMetadataObject_fields* PluginMetadataObject_ptr => (PluginMetadataObject_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PluginMetadataObject(IntPtr p) => UObject.Make<PluginMetadataObject>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PluginMetadataObject DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PluginMetadataObject New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

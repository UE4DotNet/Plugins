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
using UE4.TranslationEditor.Native;

namespace UE4.TranslationEditor {
    ///<summary>Internationalization Export Settings</summary>
    public unsafe partial class InternationalizationExportSettings : UObject  {
         //TODO: array not UObject TArray CulturesToGenerate
         //TODO: string FString CommandletClass
         //TODO: string FString SourcePath
         //TODO: string FString DestinationPath
         //TODO: string FString PortableObjectName
         //TODO: string FString ManifestName
         //TODO: string FString ArchiveName
        public bool bExportLoc {
            get {return Main.GetGetBoolPropertyByName(this, "bExportLoc"); }
            set {Main.SetGetBoolPropertyByName(this, "bExportLoc", value); }
        }
        public bool bImportLoc {
            get {return Main.GetGetBoolPropertyByName(this, "bImportLoc"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportLoc", value); }
        }
        public bool bUseCultureDirectory {
            get {return Main.GetGetBoolPropertyByName(this, "bUseCultureDirectory"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseCultureDirectory", value); }
        }
        static InternationalizationExportSettings() {
            StaticClass = Main.GetClass("InternationalizationExportSettings");
        }
        internal unsafe InternationalizationExportSettings_fields* InternationalizationExportSettings_ptr => (InternationalizationExportSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InternationalizationExportSettings(IntPtr p) => UObject.Make<InternationalizationExportSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InternationalizationExportSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InternationalizationExportSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

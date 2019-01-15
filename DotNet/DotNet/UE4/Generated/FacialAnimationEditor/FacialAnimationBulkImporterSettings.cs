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
using UE4.FacialAnimationEditor.Native;
using UE4.Engine;

namespace UE4.FacialAnimationEditor {
    ///<summary>Facial Animation Bulk Importer Settings</summary>
    public unsafe partial class FacialAnimationBulkImporterSettings : UObject  {
        ///<summary>The path to import files from</summary>
        public unsafe DirectoryPath SourceImportPath {
            get {return FacialAnimationBulkImporterSettings_ptr->SourceImportPath;}
            set {FacialAnimationBulkImporterSettings_ptr->SourceImportPath = value;}
        }
        ///<summary>The path to import files to</summary>
        public unsafe DirectoryPath TargetImportPath {
            get {return FacialAnimationBulkImporterSettings_ptr->TargetImportPath;}
            set {FacialAnimationBulkImporterSettings_ptr->TargetImportPath = value;}
        }
         //TODO: string FString CurveNodeName
        static FacialAnimationBulkImporterSettings() {
            StaticClass = Main.GetClass("FacialAnimationBulkImporterSettings");
        }
        internal unsafe FacialAnimationBulkImporterSettings_fields* FacialAnimationBulkImporterSettings_ptr => (FacialAnimationBulkImporterSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FacialAnimationBulkImporterSettings(IntPtr p) => UObject.Make<FacialAnimationBulkImporterSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FacialAnimationBulkImporterSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FacialAnimationBulkImporterSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

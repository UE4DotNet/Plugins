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
using UE4.GameProjectGeneration.Native;

namespace UE4.GameProjectGeneration {
    ///<summary>Template Project Defs</summary>
    public unsafe partial class TemplateProjectDefs : UObject  {
         //TODO: array not UObject TArray LocalizedDisplayNames
         //TODO: array not UObject TArray LocalizedDescriptions
         //TODO: array not UObject TArray FoldersToIgnore
         //TODO: array not UObject TArray FilesToIgnore
         //TODO: array not UObject TArray FolderRenames
         //TODO: array not UObject TArray FilenameReplacements
         //TODO: array not UObject TArray ReplacementsInFiles
         //TODO: string FString SortKey
        ///<summary>Category</summary>
        public unsafe Name Category {
            get {return TemplateProjectDefs_ptr->Category;}
            set {TemplateProjectDefs_ptr->Category = value;}
        }
         //TODO: string FString ClassTypes
         //TODO: string FString AssetTypes
        public bool bAllowProjectCreation {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowProjectCreation"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowProjectCreation", value); }
        }
         //TODO: array not UObject TArray PacksToInclude
         //TODO: enum EFeaturePackDetailLevel EditDetailLevelPreference
         //TODO: array not UObject TArray SharedContentPacks
        static TemplateProjectDefs() {
            StaticClass = Main.GetClass("TemplateProjectDefs");
        }
        internal unsafe TemplateProjectDefs_fields* TemplateProjectDefs_ptr => (TemplateProjectDefs_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TemplateProjectDefs(IntPtr p) => UObject.Make<TemplateProjectDefs>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TemplateProjectDefs DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TemplateProjectDefs New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

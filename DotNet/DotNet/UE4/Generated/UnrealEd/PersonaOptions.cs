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
    ///<summary>Persona Options</summary>
    public unsafe partial class PersonaOptions : UObject  {
        public bool bAutoAlignFloorToMesh {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoAlignFloorToMesh"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoAlignFloorToMesh", value); }
        }
        public bool bShowGrid {
            get {return Main.GetGetBoolPropertyByName(this, "bShowGrid"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowGrid", value); }
        }
        public bool bHighlightOrigin {
            get {return Main.GetGetBoolPropertyByName(this, "bHighlightOrigin"); }
            set {Main.SetGetBoolPropertyByName(this, "bHighlightOrigin", value); }
        }
        public bool bMuteAudio {
            get {return Main.GetGetBoolPropertyByName(this, "bMuteAudio"); }
            set {Main.SetGetBoolPropertyByName(this, "bMuteAudio", value); }
        }
        public bool bUseAudioAttenuation {
            get {return Main.GetGetBoolPropertyByName(this, "bUseAudioAttenuation"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseAudioAttenuation", value); }
        }
        ///<summary>Currently Stats can have None, Basic and Detailed. Please refer to EDisplayInfoMode.</summary>
        public unsafe int ShowMeshStats {
            get {return PersonaOptions_ptr->ShowMeshStats;}
            set {PersonaOptions_ptr->ShowMeshStats = value;}
        }
         //TODO: numeric uint32 DefaultLocalAxesSelection
         //TODO: numeric uint32 DefaultBoneDrawSelection
        ///<summary>Section Timing Node Color</summary>
        public unsafe LinearColor SectionTimingNodeColor {
            get {return PersonaOptions_ptr->SectionTimingNodeColor;}
            set {PersonaOptions_ptr->SectionTimingNodeColor = value;}
        }
        ///<summary>Notify Timing Node Color</summary>
        public unsafe LinearColor NotifyTimingNodeColor {
            get {return PersonaOptions_ptr->NotifyTimingNodeColor;}
            set {PersonaOptions_ptr->NotifyTimingNodeColor = value;}
        }
        ///<summary>Branching Point Timing Node Color</summary>
        public unsafe LinearColor BranchingPointTimingNodeColor {
            get {return PersonaOptions_ptr->BranchingPointTimingNodeColor;}
            set {PersonaOptions_ptr->BranchingPointTimingNodeColor = value;}
        }
        public bool bUseInlineSocketEditor {
            get {return Main.GetGetBoolPropertyByName(this, "bUseInlineSocketEditor"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseInlineSocketEditor", value); }
        }
        public bool bFlattenSkeletonHierarchyWhenFiltering {
            get {return Main.GetGetBoolPropertyByName(this, "bFlattenSkeletonHierarchyWhenFiltering"); }
            set {Main.SetGetBoolPropertyByName(this, "bFlattenSkeletonHierarchyWhenFiltering", value); }
        }
        public bool bHideParentsWhenFiltering {
            get {return Main.GetGetBoolPropertyByName(this, "bHideParentsWhenFiltering"); }
            set {Main.SetGetBoolPropertyByName(this, "bHideParentsWhenFiltering", value); }
        }
        public bool bAllowPreviewMeshCollectionsToSelectFromDifferentSkeletons {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowPreviewMeshCollectionsToSelectFromDifferentSkeletons"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowPreviewMeshCollectionsToSelectFromDifferentSkeletons", value); }
        }
        public bool bAllowMeshSectionSelection {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowMeshSectionSelection"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowMeshSectionSelection", value); }
        }
         //TODO: numeric uint32 NumFolderFiltersInAssetBrowser
         //TODO: array not UObject TArray AssetEditorOptions
        static PersonaOptions() {
            StaticClass = Main.GetClass("PersonaOptions");
        }
        internal unsafe PersonaOptions_fields* PersonaOptions_ptr => (PersonaOptions_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PersonaOptions(IntPtr p) => UObject.Make<PersonaOptions>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PersonaOptions DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PersonaOptions New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

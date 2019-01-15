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
    ///<summary>Implements the settings for the skeletal mesh editor.</summary>
    public unsafe partial class SkeletalMeshEditorSettings : UObject  {
        ///<summary>Anim Preview Floor Color</summary>
        public unsafe Color AnimPreviewFloorColor {
            get {return SkeletalMeshEditorSettings_ptr->AnimPreviewFloorColor;}
            set {SkeletalMeshEditorSettings_ptr->AnimPreviewFloorColor = value;}
        }
        ///<summary>Anim Preview Sky Color</summary>
        public unsafe Color AnimPreviewSkyColor {
            get {return SkeletalMeshEditorSettings_ptr->AnimPreviewSkyColor;}
            set {SkeletalMeshEditorSettings_ptr->AnimPreviewSkyColor = value;}
        }
        ///<summary>Anim Preview Sky Brightness</summary>
        public unsafe float AnimPreviewSkyBrightness {
            get {return SkeletalMeshEditorSettings_ptr->AnimPreviewSkyBrightness;}
            set {SkeletalMeshEditorSettings_ptr->AnimPreviewSkyBrightness = value;}
        }
        ///<summary>Anim Preview Light Brightness</summary>
        public unsafe float AnimPreviewLightBrightness {
            get {return SkeletalMeshEditorSettings_ptr->AnimPreviewLightBrightness;}
            set {SkeletalMeshEditorSettings_ptr->AnimPreviewLightBrightness = value;}
        }
        ///<summary>Anim Preview Lighting Direction</summary>
        public unsafe Rotator AnimPreviewLightingDirection {
            get {return SkeletalMeshEditorSettings_ptr->AnimPreviewLightingDirection;}
            set {SkeletalMeshEditorSettings_ptr->AnimPreviewLightingDirection = value;}
        }
        ///<summary>Anim Preview Directional Color</summary>
        public unsafe Color AnimPreviewDirectionalColor {
            get {return SkeletalMeshEditorSettings_ptr->AnimPreviewDirectionalColor;}
            set {SkeletalMeshEditorSettings_ptr->AnimPreviewDirectionalColor = value;}
        }
        static SkeletalMeshEditorSettings() {
            StaticClass = Main.GetClass("SkeletalMeshEditorSettings");
        }
        internal unsafe SkeletalMeshEditorSettings_fields* SkeletalMeshEditorSettings_ptr => (SkeletalMeshEditorSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SkeletalMeshEditorSettings(IntPtr p) => UObject.Make<SkeletalMeshEditorSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SkeletalMeshEditorSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SkeletalMeshEditorSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

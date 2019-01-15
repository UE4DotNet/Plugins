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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>UPlanarReflectionComponent</summary>
    public unsafe partial class PlanarReflectionComponent : SceneCaptureComponent  {
        ///<summary>Preview Box</summary>
        public unsafe BoxComponent PreviewBox {
            get {return PlanarReflectionComponent_ptr->PreviewBox;}
            set {PlanarReflectionComponent_ptr->PreviewBox = value;}
        }
        ///<summary>Controls the strength of normals when distorting the planar reflection.</summary>
        public unsafe float NormalDistortionStrength {
            get {return PlanarReflectionComponent_ptr->NormalDistortionStrength;}
            set {PlanarReflectionComponent_ptr->NormalDistortionStrength = value;}
        }
        ///<summary>The roughness value to prefilter the planar reflection texture with, useful for hiding low resolution.  Larger values have larger GPU cost.</summary>
        public unsafe float PrefilterRoughness {
            get {return PlanarReflectionComponent_ptr->PrefilterRoughness;}
            set {PlanarReflectionComponent_ptr->PrefilterRoughness = value;}
        }
        ///<summary>The distance at which the prefilter roughness value will be achieved.</summary>
        public unsafe float PrefilterRoughnessDistance {
            get {return PlanarReflectionComponent_ptr->PrefilterRoughnessDistance;}
            set {PlanarReflectionComponent_ptr->PrefilterRoughnessDistance = value;}
        }
        ///<summary>Downsample percent, can be used to reduce GPU time rendering the planar reflection.</summary>
        public unsafe int ScreenPercentage {
            get {return PlanarReflectionComponent_ptr->ScreenPercentage;}
            set {PlanarReflectionComponent_ptr->ScreenPercentage = value;}
        }
        ///<summary>Additional FOV used when rendering to the reflection texture.</summary>
        ///<remarks>
        ///This is useful when normal distortion is causing reads outside the reflection texture.
        ///Larger values increase rendering thread and GPU cost, as more objects and triangles have to be rendered into the planar reflection.
        ///</remarks>
        public unsafe float ExtraFOV {
            get {return PlanarReflectionComponent_ptr->ExtraFOV;}
            set {PlanarReflectionComponent_ptr->ExtraFOV = value;}
        }
        ///<summary>Receiving pixels at this distance from the reflection plane will begin to fade out the planar reflection.</summary>
        public unsafe float DistanceFromPlaneFadeoutStart {
            get {return PlanarReflectionComponent_ptr->DistanceFromPlaneFadeoutStart;}
            set {PlanarReflectionComponent_ptr->DistanceFromPlaneFadeoutStart = value;}
        }
        ///<summary>Receiving pixels at this distance from the reflection plane will have completely faded out the planar reflection.</summary>
        public unsafe float DistanceFromPlaneFadeoutEnd {
            get {return PlanarReflectionComponent_ptr->DistanceFromPlaneFadeoutEnd;}
            set {PlanarReflectionComponent_ptr->DistanceFromPlaneFadeoutEnd = value;}
        }
        ///<summary>Receiving pixels whose normal is at this angle from the reflection plane will begin to fade out the planar reflection.</summary>
        public unsafe float AngleFromPlaneFadeStart {
            get {return PlanarReflectionComponent_ptr->AngleFromPlaneFadeStart;}
            set {PlanarReflectionComponent_ptr->AngleFromPlaneFadeStart = value;}
        }
        ///<summary>Receiving pixels whose normal is at this angle from the reflection plane will have completely faded out the planar reflection.</summary>
        public unsafe float AngleFromPlaneFadeEnd {
            get {return PlanarReflectionComponent_ptr->AngleFromPlaneFadeEnd;}
            set {PlanarReflectionComponent_ptr->AngleFromPlaneFadeEnd = value;}
        }
        public bool bRenderSceneTwoSided {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderSceneTwoSided"); }
            set {Main.SetGetBoolPropertyByName(this, "bRenderSceneTwoSided", value); }
        }
        static PlanarReflectionComponent() {
            StaticClass = Main.GetClass("PlanarReflectionComponent");
        }
        internal unsafe PlanarReflectionComponent_fields* PlanarReflectionComponent_ptr => (PlanarReflectionComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PlanarReflectionComponent(IntPtr p) => UObject.Make<PlanarReflectionComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PlanarReflectionComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PlanarReflectionComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

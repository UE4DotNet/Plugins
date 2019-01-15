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
    ///<summary>Allows multiple animations to be blended between based on input parameters</summary>
    public unsafe partial class BlendSpaceBase : AnimationAsset  {
        public bool bRotationBlendInMeshSpace {
            get {return Main.GetGetBoolPropertyByName(this, "bRotationBlendInMeshSpace"); }
            set {Main.SetGetBoolPropertyByName(this, "bRotationBlendInMeshSpace", value); }
        }
        ///<summary>Preview Base pose for additive BlendSpace *</summary>
        public unsafe AnimSequence PreviewBasePose {
            get {return BlendSpaceBase_ptr->PreviewBasePose;}
            set {BlendSpaceBase_ptr->PreviewBasePose = value;}
        }
        ///<summary>This animation length changes based on current input (resulting in different blend time)*</summary>
        public unsafe float AnimLength {
            get {return BlendSpaceBase_ptr->AnimLength;}
            set {BlendSpaceBase_ptr->AnimLength = value;}
        }
        ///<summary>Input interpolation parameter for all 3 axis, for each axis input, decide how you'd like to interpolate input to</summary>
        public unsafe InterpolationParameter InterpolationParam {
            get {return BlendSpaceBase_ptr->InterpolationParam;}
            set {BlendSpaceBase_ptr->InterpolationParam = value;}
        }
        ///<summary>Target weight interpolation.</summary>
        ///<remarks>
        ///When target samples are set, how fast you'd like to get to target. Improve target blending.
        ///i.e. for locomotion, if you interpolate input, when you move from left to right rapidly, you'll interpolate through forward, but if you use target weight interpolation,
        ///you'll skip forward, but interpolate between left to right
        ///</remarks>
        public unsafe float TargetWeightInterpolationSpeedPerSec {
            get {return BlendSpaceBase_ptr->TargetWeightInterpolationSpeedPerSec;}
            set {BlendSpaceBase_ptr->TargetWeightInterpolationSpeedPerSec = value;}
        }
        ///<summary>The current mode used by the blendspace to decide which animation notifies to fire.</summary>
        ///<remarks>
        ///Valid options are:
        ///      - AllAnimations - All notify events will fire
        ///      - HighestWeightedAnimation - Notify events will only fire from the highest weighted animation
        ///      - None - No notify events will fire from any animations
        ///</remarks>
        public unsafe byte NotifyTriggerMode {
            get {return BlendSpaceBase_ptr->NotifyTriggerMode;}
            set {BlendSpaceBase_ptr->NotifyTriggerMode = value;}
        }
         //TODO: array not UObject TArray PerBoneBlend
        ///<summary>Track index to get marker data from.</summary>
        ///<remarks>
        ///Samples are tested for the suitability of marker based sync
        ///          during load and if we can use marker based sync we cache an index to a representative sample here
        ///</remarks>
        public unsafe int SampleIndexWithMarkers {
            get {return BlendSpaceBase_ptr->SampleIndexWithMarkers;}
            set {BlendSpaceBase_ptr->SampleIndexWithMarkers = value;}
        }
         //TODO: array not UObject TArray SampleData
         //TODO: array not UObject TArray GridSamples
        ///<summary>Blend Parameters for each axis. *</summary>
        public unsafe BlendParameter BlendParameters {
            get {return BlendSpaceBase_ptr->BlendParameters;}
            set {BlendSpaceBase_ptr->BlendParameters = value;}
        }
        static BlendSpaceBase() {
            StaticClass = Main.GetClass("BlendSpaceBase");
        }
        internal unsafe BlendSpaceBase_fields* BlendSpaceBase_ptr => (BlendSpaceBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlendSpaceBase(IntPtr p) => UObject.Make<BlendSpaceBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlendSpaceBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlendSpaceBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

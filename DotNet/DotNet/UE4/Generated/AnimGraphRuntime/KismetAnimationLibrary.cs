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
using UE4.AnimGraphRuntime.Native;
using UE4.Engine;

namespace UE4.AnimGraphRuntime {
    ///<summary>Kismet Animation Library</summary>
    public unsafe partial class KismetAnimationLibrary : BlueprintFunctionLibrary  {

        ///<summary>K2 Look At</summary>
        public static Transform K2_LookAt(Transform CurrentTransform, Vector TargetPosition, Vector LookAtVector, bool bUseUpVector, Vector UpVector, float ClampConeInDegree)  => 
            KismetAnimationLibrary_methods.K2_LookAt_method.Invoke(CurrentTransform, TargetPosition, LookAtVector, bUseUpVector, UpVector, ClampConeInDegree);

        ///<summary>K2 Two Bone IK</summary>
        public static (Vector, Vector) K2_TwoBoneIK(Vector RootPos, Vector JointPos, Vector EndPos, Vector JointTarget, Vector Effector, bool bAllowStretching, float StartStretchRatio, float MaxStretchScale)  => 
            KismetAnimationLibrary_methods.K2_TwoBoneIK_method.Invoke(RootPos, JointPos, EndPos, JointTarget, Effector, bAllowStretching, StartStretchRatio, MaxStretchScale);
        static KismetAnimationLibrary() {
            StaticClass = Main.GetClass("KismetAnimationLibrary");
        }
        internal unsafe KismetAnimationLibrary_fields* KismetAnimationLibrary_ptr => (KismetAnimationLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator KismetAnimationLibrary(IntPtr p) => UObject.Make<KismetAnimationLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static KismetAnimationLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static KismetAnimationLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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

        ///<summary>K2 Direction Between Sockets</summary>
        public static Vector K2_DirectionBetweenSockets(SkeletalMeshComponent Component, Name SocketOrBoneNameFrom, Name SocketOrBoneNameTo)  => 
            KismetAnimationLibrary_methods.K2_DirectionBetweenSockets_method.Invoke(Component, SocketOrBoneNameFrom, SocketOrBoneNameTo);

        ///<summary>K2 Distance Between Two Sockets and Map Range</summary>
        public static float K2_DistanceBetweenTwoSocketsAndMapRange(SkeletalMeshComponent Component, Name SocketOrBoneNameA, byte SocketSpaceA, Name SocketOrBoneNameB, byte SocketSpaceB, bool bRemapRange, float InRangeMin, float InRangeMax, float OutRangeMin, float OutRangeMax)  => 
            KismetAnimationLibrary_methods.K2_DistanceBetweenTwoSocketsAndMapRange_method.Invoke(Component, SocketOrBoneNameA, SocketSpaceA, SocketOrBoneNameB, SocketSpaceB, bRemapRange, InRangeMin, InRangeMax, OutRangeMin, OutRangeMax);

        ///<summary>K2 Look At</summary>
        public static Transform K2_LookAt(Transform CurrentTransform, Vector TargetPosition, Vector LookAtVector, bool bUseUpVector, Vector UpVector, float ClampConeInDegree)  => 
            KismetAnimationLibrary_methods.K2_LookAt_method.Invoke(CurrentTransform, TargetPosition, LookAtVector, bUseUpVector, UpVector, ClampConeInDegree);

        ///<summary>K2 Make Perlin Noise and Remap</summary>
        public static float K2_MakePerlinNoiseAndRemap(float Value, float RangeOutMin, float RangeOutMax)  => 
            KismetAnimationLibrary_methods.K2_MakePerlinNoiseAndRemap_method.Invoke(Value, RangeOutMin, RangeOutMax);

        ///<summary>This function creates perlin noise from input X, Y, Z, and then range map to RangeOut, and out put to OutX, OutY, OutZ</summary>
        public static Vector K2_MakePerlinNoiseVectorAndRemap(float X, float Y, float Z, float RangeOutMinX, float RangeOutMaxX, float RangeOutMinY, float RangeOutMaxY, float RangeOutMinZ, float RangeOutMaxZ)  => 
            KismetAnimationLibrary_methods.K2_MakePerlinNoiseVectorAndRemap_method.Invoke(X, Y, Z, RangeOutMinX, RangeOutMaxX, RangeOutMinY, RangeOutMaxY, RangeOutMinZ, RangeOutMaxZ);

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

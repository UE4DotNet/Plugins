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
using UE4.FunctionalTesting.Native;
using UE4.Engine;

namespace UE4.FunctionalTesting {
    ///<summary>
    ///Used to expose C++ functions to tests that we don't want to make BP accessible
    ///in the engine itself.
    ///</summary>
    public unsafe partial class FunctionalTestUtilityLibrary : BlueprintFunctionLibrary  {

        ///<summary>Helper function to trace and permute many options at once</summary>
        public static TraceQueryTestResults TraceChannelTestUtil(UObject WorldContextObject, TraceChannelTestBatchOptions BatchOptions, Vector Start, Vector End, float SphereCapsuleRadius, float CapsuleHalfHeight, Vector BoxHalfSize, Rotator Orientation, byte TraceChannel, byte ObjectTypes /*TODO: array TArray */, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, bool bIgnoreSelf, byte DrawDebugType, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            FunctionalTestUtilityLibrary_methods.TraceChannelTestUtil_method.Invoke(WorldContextObject, BatchOptions, Start, End, SphereCapsuleRadius, CapsuleHalfHeight, BoxHalfSize, Orientation, TraceChannel, ObjectTypes, ProfileName, bTraceComplex, ActorsToIgnore, bIgnoreSelf, DrawDebugType, TraceColor, TraceHitColor, DrawTime);
        static FunctionalTestUtilityLibrary() {
            StaticClass = Main.GetClass("FunctionalTestUtilityLibrary");
        }
        internal unsafe FunctionalTestUtilityLibrary_fields* FunctionalTestUtilityLibrary_ptr => (FunctionalTestUtilityLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FunctionalTestUtilityLibrary(IntPtr p) => UObject.Make<FunctionalTestUtilityLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FunctionalTestUtilityLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FunctionalTestUtilityLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

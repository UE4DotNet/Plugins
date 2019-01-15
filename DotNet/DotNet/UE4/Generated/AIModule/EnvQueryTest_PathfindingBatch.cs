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
using UE4.AIModule.Native;

namespace UE4.AIModule {
    ///<summary>Env Query Test Pathfinding Batch</summary>
    public unsafe partial class EnvQueryTest_PathfindingBatch : EnvQueryTest_Pathfinding  {
        ///<summary>multiplier for max distance between point and context</summary>
        public unsafe AIDataProviderFloatValue ScanRangeMultiplier {
            get {return EnvQueryTest_PathfindingBatch_ptr->ScanRangeMultiplier;}
            set {EnvQueryTest_PathfindingBatch_ptr->ScanRangeMultiplier = value;}
        }
        static EnvQueryTest_PathfindingBatch() {
            StaticClass = Main.GetClass("EnvQueryTest_PathfindingBatch");
        }
        internal unsafe EnvQueryTest_PathfindingBatch_fields* EnvQueryTest_PathfindingBatch_ptr => (EnvQueryTest_PathfindingBatch_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryTest_PathfindingBatch(IntPtr p) => UObject.Make<EnvQueryTest_PathfindingBatch>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryTest_PathfindingBatch DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryTest_PathfindingBatch New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

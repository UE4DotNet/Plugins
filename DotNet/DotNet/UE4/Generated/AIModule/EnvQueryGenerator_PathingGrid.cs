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
using UE4.NavigationSystem;

namespace UE4.AIModule {
    ///<summary>Navigation grid, generates points on navmesh</summary>
    ///<remarks>with paths to/from context no further than given limit</remarks>
    public unsafe partial class EnvQueryGenerator_PathingGrid : EnvQueryGenerator_SimpleGrid  {
        ///<summary>pathfinding direction</summary>
        public unsafe AIDataProviderBoolValue PathToItem {
            get {return EnvQueryGenerator_PathingGrid_ptr->PathToItem;}
            set {EnvQueryGenerator_PathingGrid_ptr->PathToItem = value;}
        }
        ///<summary>navigation filter to use in pathfinding</summary>
        public unsafe SubclassOf<NavigationQueryFilter> NavigationFilter {
            get {return EnvQueryGenerator_PathingGrid_ptr->NavigationFilter;}
            set {EnvQueryGenerator_PathingGrid_ptr->NavigationFilter = value;}
        }
        ///<summary>multiplier for max distance between point and context</summary>
        public unsafe AIDataProviderFloatValue ScanRangeMultiplier {
            get {return EnvQueryGenerator_PathingGrid_ptr->ScanRangeMultiplier;}
            set {EnvQueryGenerator_PathingGrid_ptr->ScanRangeMultiplier = value;}
        }
        static EnvQueryGenerator_PathingGrid() {
            StaticClass = Main.GetClass("EnvQueryGenerator_PathingGrid");
        }
        internal unsafe EnvQueryGenerator_PathingGrid_fields* EnvQueryGenerator_PathingGrid_ptr => (EnvQueryGenerator_PathingGrid_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryGenerator_PathingGrid(IntPtr p) => UObject.Make<EnvQueryGenerator_PathingGrid>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryGenerator_PathingGrid DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryGenerator_PathingGrid New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

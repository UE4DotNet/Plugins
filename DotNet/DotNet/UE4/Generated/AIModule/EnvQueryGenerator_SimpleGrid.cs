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
    ///<summary>Simple grid, generates points in 2D square around context</summary>
    public unsafe partial class EnvQueryGenerator_SimpleGrid : EnvQueryGenerator_ProjectedPoints  {
        ///<summary>half of square's extent, like a radius</summary>
        public unsafe AIDataProviderFloatValue GridSize {
            get {return EnvQueryGenerator_SimpleGrid_ptr->GridSize;}
            set {EnvQueryGenerator_SimpleGrid_ptr->GridSize = value;}
        }
        ///<summary>generation density</summary>
        public unsafe AIDataProviderFloatValue SpaceBetween {
            get {return EnvQueryGenerator_SimpleGrid_ptr->SpaceBetween;}
            set {EnvQueryGenerator_SimpleGrid_ptr->SpaceBetween = value;}
        }
        ///<summary>context</summary>
        public unsafe SubclassOf<EnvQueryContext> GenerateAround {
            get {return EnvQueryGenerator_SimpleGrid_ptr->GenerateAround;}
            set {EnvQueryGenerator_SimpleGrid_ptr->GenerateAround = value;}
        }
        static EnvQueryGenerator_SimpleGrid() {
            StaticClass = Main.GetClass("EnvQueryGenerator_SimpleGrid");
        }
        internal unsafe EnvQueryGenerator_SimpleGrid_fields* EnvQueryGenerator_SimpleGrid_ptr => (EnvQueryGenerator_SimpleGrid_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryGenerator_SimpleGrid(IntPtr p) => UObject.Make<EnvQueryGenerator_SimpleGrid>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryGenerator_SimpleGrid DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryGenerator_SimpleGrid New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

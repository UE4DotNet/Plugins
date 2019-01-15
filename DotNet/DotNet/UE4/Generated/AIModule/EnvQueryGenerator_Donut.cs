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
    ///<summary>Env Query Generator Donut</summary>
    public unsafe partial class EnvQueryGenerator_Donut : EnvQueryGenerator_ProjectedPoints  {
        ///<summary>min distance between point and context</summary>
        public unsafe AIDataProviderFloatValue InnerRadius {
            get {return EnvQueryGenerator_Donut_ptr->InnerRadius;}
            set {EnvQueryGenerator_Donut_ptr->InnerRadius = value;}
        }
        ///<summary>max distance between point and context</summary>
        public unsafe AIDataProviderFloatValue OuterRadius {
            get {return EnvQueryGenerator_Donut_ptr->OuterRadius;}
            set {EnvQueryGenerator_Donut_ptr->OuterRadius = value;}
        }
        ///<summary>number of rings to generate</summary>
        public unsafe AIDataProviderIntValue NumberOfRings {
            get {return EnvQueryGenerator_Donut_ptr->NumberOfRings;}
            set {EnvQueryGenerator_Donut_ptr->NumberOfRings = value;}
        }
        ///<summary>number of items to generate for each ring</summary>
        public unsafe AIDataProviderIntValue PointsPerRing {
            get {return EnvQueryGenerator_Donut_ptr->PointsPerRing;}
            set {EnvQueryGenerator_Donut_ptr->PointsPerRing = value;}
        }
        ///<summary>If you generate items on a piece of circle you define direction of Arc cut here</summary>
        public unsafe EnvDirection ArcDirection {
            get {return EnvQueryGenerator_Donut_ptr->ArcDirection;}
            set {EnvQueryGenerator_Donut_ptr->ArcDirection = value;}
        }
        ///<summary>If you generate items on a piece of circle you define angle of Arc cut here</summary>
        public unsafe AIDataProviderFloatValue ArcAngle {
            get {return EnvQueryGenerator_Donut_ptr->ArcAngle;}
            set {EnvQueryGenerator_Donut_ptr->ArcAngle = value;}
        }
        public bool bUseSpiralPattern {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSpiralPattern"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSpiralPattern", value); }
        }
        ///<summary>context</summary>
        public unsafe SubclassOf<EnvQueryContext> Center {
            get {return EnvQueryGenerator_Donut_ptr->Center;}
            set {EnvQueryGenerator_Donut_ptr->Center = value;}
        }
        public bool bDefineArc {
            get {return Main.GetGetBoolPropertyByName(this, "bDefineArc"); }
            set {Main.SetGetBoolPropertyByName(this, "bDefineArc", value); }
        }
        static EnvQueryGenerator_Donut() {
            StaticClass = Main.GetClass("EnvQueryGenerator_Donut");
        }
        internal unsafe EnvQueryGenerator_Donut_fields* EnvQueryGenerator_Donut_ptr => (EnvQueryGenerator_Donut_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryGenerator_Donut(IntPtr p) => UObject.Make<EnvQueryGenerator_Donut>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryGenerator_Donut DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryGenerator_Donut New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

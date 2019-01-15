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
    ///<summary>Env Query Generator on Circle</summary>
    public unsafe partial class EnvQueryGenerator_OnCircle : EnvQueryGenerator_ProjectedPoints  {
        ///<summary>max distance of path between point and context</summary>
        public unsafe AIDataProviderFloatValue CircleRadius {
            get {return EnvQueryGenerator_OnCircle_ptr->CircleRadius;}
            set {EnvQueryGenerator_OnCircle_ptr->CircleRadius = value;}
        }
        ///<summary>items will be generated on a circle this much apart</summary>
        public unsafe AIDataProviderFloatValue SpaceBetween {
            get {return EnvQueryGenerator_OnCircle_ptr->SpaceBetween;}
            set {EnvQueryGenerator_OnCircle_ptr->SpaceBetween = value;}
        }
        ///<summary>this many items will be generated on a circle</summary>
        public unsafe AIDataProviderIntValue NumberOfPoints {
            get {return EnvQueryGenerator_OnCircle_ptr->NumberOfPoints;}
            set {EnvQueryGenerator_OnCircle_ptr->NumberOfPoints = value;}
        }
         //TODO: enum EPointOnCircleSpacingMethod PointOnCircleSpacingMethod
        ///<summary>If you generate items on a piece of circle you define direction of Arc cut here</summary>
        public unsafe EnvDirection ArcDirection {
            get {return EnvQueryGenerator_OnCircle_ptr->ArcDirection;}
            set {EnvQueryGenerator_OnCircle_ptr->ArcDirection = value;}
        }
        ///<summary>If you generate items on a piece of circle you define angle of Arc cut here</summary>
        public unsafe AIDataProviderFloatValue ArcAngle {
            get {return EnvQueryGenerator_OnCircle_ptr->ArcAngle;}
            set {EnvQueryGenerator_OnCircle_ptr->ArcAngle = value;}
        }
        ///<summary>Angle Radians</summary>
        public unsafe float AngleRadians {
            get {return EnvQueryGenerator_OnCircle_ptr->AngleRadians;}
            set {EnvQueryGenerator_OnCircle_ptr->AngleRadians = value;}
        }
        ///<summary>context</summary>
        public unsafe SubclassOf<EnvQueryContext> CircleCenter {
            get {return EnvQueryGenerator_OnCircle_ptr->CircleCenter;}
            set {EnvQueryGenerator_OnCircle_ptr->CircleCenter = value;}
        }
        public bool bIgnoreAnyContextActorsWhenGeneratingCircle {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreAnyContextActorsWhenGeneratingCircle"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreAnyContextActorsWhenGeneratingCircle", value); }
        }
        ///<summary>context offset</summary>
        public unsafe AIDataProviderFloatValue CircleCenterZOffset {
            get {return EnvQueryGenerator_OnCircle_ptr->CircleCenterZOffset;}
            set {EnvQueryGenerator_OnCircle_ptr->CircleCenterZOffset = value;}
        }
        ///<summary>horizontal trace for nearest obstacle</summary>
        public unsafe EnvTraceData TraceData {
            get {return EnvQueryGenerator_OnCircle_ptr->TraceData;}
            set {EnvQueryGenerator_OnCircle_ptr->TraceData = value;}
        }
        public bool bDefineArc {
            get {return Main.GetGetBoolPropertyByName(this, "bDefineArc"); }
            set {Main.SetGetBoolPropertyByName(this, "bDefineArc", value); }
        }
        static EnvQueryGenerator_OnCircle() {
            StaticClass = Main.GetClass("EnvQueryGenerator_OnCircle");
        }
        internal unsafe EnvQueryGenerator_OnCircle_fields* EnvQueryGenerator_OnCircle_ptr => (EnvQueryGenerator_OnCircle_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryGenerator_OnCircle(IntPtr p) => UObject.Make<EnvQueryGenerator_OnCircle>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryGenerator_OnCircle DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryGenerator_OnCircle New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

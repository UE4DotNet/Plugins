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
using UE4.NavigationSystem.Native;
using UE4.Engine;

namespace UE4.NavigationSystem {
    ///<summary>Represents abstract Navigation Data (sub-classed as NavMesh, NavGraph, etc)</summary>
    ///<remarks>Used as a common interface for all navigation types handled by NavigationSystem</remarks>
    public unsafe partial class NavigationData : Actor  {
        ///<summary>Rendering Comp</summary>
        public unsafe PrimitiveComponent RenderingComp {
            get {return NavigationData_ptr->RenderingComp;}
            set {NavigationData_ptr->RenderingComp = value;}
        }
        ///<summary>Nav Data Config</summary>
        public unsafe NavDataConfig NavDataConfig {
            get {return NavigationData_ptr->NavDataConfig;}
            set {NavigationData_ptr->NavDataConfig = value;}
        }
        public bool bEnableDrawing {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableDrawing"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableDrawing", value); }
        }
        public bool bForceRebuildOnLoad {
            get {return Main.GetGetBoolPropertyByName(this, "bForceRebuildOnLoad"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceRebuildOnLoad", value); }
        }
        public bool bCanBeMainNavData {
            get {return Main.GetGetBoolPropertyByName(this, "bCanBeMainNavData"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanBeMainNavData", value); }
        }
        public bool bCanSpawnOnRebuild {
            get {return Main.GetGetBoolPropertyByName(this, "bCanSpawnOnRebuild"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanSpawnOnRebuild", value); }
        }
         //TODO: enum ERuntimeGenerationType RuntimeGeneration
        ///<summary>all observed paths will be processed every ObservedPathsTickInterval seconds</summary>
        public unsafe float ObservedPathsTickInterval {
            get {return NavigationData_ptr->ObservedPathsTickInterval;}
            set {NavigationData_ptr->ObservedPathsTickInterval = value;}
        }
         //TODO: numeric uint32 DataVersion
         //TODO: array not UObject TArray SupportedAreas
        static NavigationData() {
            StaticClass = Main.GetClass("NavigationData");
        }
        internal unsafe NavigationData_fields* NavigationData_ptr => (NavigationData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavigationData(IntPtr p) => UObject.Make<NavigationData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavigationData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavigationData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

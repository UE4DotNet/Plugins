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
    ///<summary>Navigation System Module Config</summary>
    public unsafe partial class NavigationSystemModuleConfig : NavigationSystemConfig  {
        public bool bStrictlyStatic {
            get {return Main.GetGetBoolPropertyByName(this, "bStrictlyStatic"); }
            set {Main.SetGetBoolPropertyByName(this, "bStrictlyStatic", value); }
        }
        public bool bCreateOnClient {
            get {return Main.GetGetBoolPropertyByName(this, "bCreateOnClient"); }
            set {Main.SetGetBoolPropertyByName(this, "bCreateOnClient", value); }
        }
        public bool bAutoSpawnMissingNavData {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoSpawnMissingNavData"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoSpawnMissingNavData", value); }
        }
        public bool bSpawnNavDataInNavBoundsLevel {
            get {return Main.GetGetBoolPropertyByName(this, "bSpawnNavDataInNavBoundsLevel"); }
            set {Main.SetGetBoolPropertyByName(this, "bSpawnNavDataInNavBoundsLevel", value); }
        }
        static NavigationSystemModuleConfig() {
            StaticClass = Main.GetClass("NavigationSystemModuleConfig");
        }
        internal unsafe NavigationSystemModuleConfig_fields* NavigationSystemModuleConfig_ptr => (NavigationSystemModuleConfig_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavigationSystemModuleConfig(IntPtr p) => UObject.Make<NavigationSystemModuleConfig>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavigationSystemModuleConfig DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavigationSystemModuleConfig New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

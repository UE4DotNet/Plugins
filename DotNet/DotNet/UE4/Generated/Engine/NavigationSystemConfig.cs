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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Navigation System Config</summary>
    public unsafe partial class NavigationSystemConfig : UObject  {
        ///<summary>Navigation System Class</summary>
        public unsafe SoftClassPath NavigationSystemClass {
            get {return NavigationSystemConfig_ptr->NavigationSystemClass;}
            set {NavigationSystemConfig_ptr->NavigationSystemClass = value;}
        }
        public bool bIsOverriden {
            get {return Main.GetGetBoolPropertyByName(this, "bIsOverriden"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsOverriden", value); }
        }
        static NavigationSystemConfig() {
            StaticClass = Main.GetClass("NavigationSystemConfig");
        }
        internal unsafe NavigationSystemConfig_fields* NavigationSystemConfig_ptr => (NavigationSystemConfig_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavigationSystemConfig(IntPtr p) => UObject.Make<NavigationSystemConfig>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavigationSystemConfig DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavigationSystemConfig New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

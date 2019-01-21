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
    ///<summary>Nav System Config Override</summary>
    public unsafe partial class NavSystemConfigOverride : Actor  {
        ///<summary>Sprite Component</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return NavSystemConfigOverride_ptr->SpriteComponent;}
            set {NavSystemConfigOverride_ptr->SpriteComponent = value;}
        }
        ///<summary>Navigation System Config</summary>
        public unsafe NavigationSystemConfig NavigationSystemConfig {
            get {return NavSystemConfigOverride_ptr->NavigationSystemConfig;}
        }
        public bool bLoadOnClient {
            get {return Main.GetGetBoolPropertyByName(this, "bLoadOnClient"); }
            set {Main.SetGetBoolPropertyByName(this, "bLoadOnClient", value); }
        }
        static NavSystemConfigOverride() {
            StaticClass = Main.GetClass("NavSystemConfigOverride");
        }
        internal unsafe NavSystemConfigOverride_fields* NavSystemConfigOverride_ptr => (NavSystemConfigOverride_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavSystemConfigOverride(IntPtr p) => UObject.Make<NavSystemConfigOverride>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavSystemConfigOverride DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavSystemConfigOverride New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

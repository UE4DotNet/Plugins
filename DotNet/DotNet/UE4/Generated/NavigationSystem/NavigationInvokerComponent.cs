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
    ///<summary>Navigation Invoker Component</summary>
    public unsafe partial class NavigationInvokerComponent : ActorComponent  {
        ///<summary>Tile Generation Radius</summary>
        public unsafe float TileGenerationRadius {
            get {return NavigationInvokerComponent_ptr->TileGenerationRadius;}
            set {NavigationInvokerComponent_ptr->TileGenerationRadius = value;}
        }
        ///<summary>Tile Removal Radius</summary>
        public unsafe float TileRemovalRadius {
            get {return NavigationInvokerComponent_ptr->TileRemovalRadius;}
            set {NavigationInvokerComponent_ptr->TileRemovalRadius = value;}
        }
        static NavigationInvokerComponent() {
            StaticClass = Main.GetClass("NavigationInvokerComponent");
        }
        internal unsafe NavigationInvokerComponent_fields* NavigationInvokerComponent_ptr => (NavigationInvokerComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavigationInvokerComponent(IntPtr p) => UObject.Make<NavigationInvokerComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavigationInvokerComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavigationInvokerComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

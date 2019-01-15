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
    ///<summary>Navigation Object Base</summary>
    public unsafe partial class NavigationObjectBase : Actor  {
        ///<summary>Capsule Component</summary>
        public unsafe CapsuleComponent CapsuleComponent {
            get {return NavigationObjectBase_ptr->CapsuleComponent;}
            set {NavigationObjectBase_ptr->CapsuleComponent = value;}
        }
        ///<summary>Normal editor sprite.</summary>
        public unsafe BillboardComponent GoodSprite {
            get {return NavigationObjectBase_ptr->GoodSprite;}
            set {NavigationObjectBase_ptr->GoodSprite = value;}
        }
        ///<summary>Used to draw bad collision intersection in editor.</summary>
        public unsafe BillboardComponent BadSprite {
            get {return NavigationObjectBase_ptr->BadSprite;}
            set {NavigationObjectBase_ptr->BadSprite = value;}
        }
        public bool bIsPIEPlayerStart {
            get {return Main.GetGetBoolPropertyByName(this, "bIsPIEPlayerStart"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsPIEPlayerStart", value); }
        }
        static NavigationObjectBase() {
            StaticClass = Main.GetClass("NavigationObjectBase");
        }
        internal unsafe NavigationObjectBase_fields* NavigationObjectBase_ptr => (NavigationObjectBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavigationObjectBase(IntPtr p) => UObject.Make<NavigationObjectBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavigationObjectBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavigationObjectBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

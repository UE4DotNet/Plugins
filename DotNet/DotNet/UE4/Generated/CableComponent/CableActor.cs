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
using UE4.CableComponent.Native;
using UE4.Engine;

namespace UE4.CableComponent {
    ///<summary>An actor that renders a simulated cable</summary>
    public unsafe partial class CableActor : Actor  {
        ///<summary>Cable component that performs simulation and rendering</summary>
        public unsafe CableComponent CableComponent {
            get {return CableActor_ptr->CableComponent;}
        }
        static CableActor() {
            StaticClass = Main.GetClass("CableActor");
        }
        internal unsafe CableActor_fields* CableActor_ptr => (CableActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CableActor(IntPtr p) => UObject.Make<CableActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CableActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CableActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
using UE4.Landscape.Native;
using UE4.Engine;

namespace UE4.Landscape {
    ///<summary>Control Point Mesh Component</summary>
    public unsafe partial class ControlPointMeshComponent : StaticMeshComponent  {
        public bool bSelected {
            get {return Main.GetGetBoolPropertyByName(this, "bSelected"); }
            set {Main.SetGetBoolPropertyByName(this, "bSelected", value); }
        }
        static ControlPointMeshComponent() {
            StaticClass = Main.GetClass("ControlPointMeshComponent");
        }
        internal unsafe ControlPointMeshComponent_fields* ControlPointMeshComponent_ptr => (ControlPointMeshComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ControlPointMeshComponent(IntPtr p) => UObject.Make<ControlPointMeshComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ControlPointMeshComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ControlPointMeshComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>Vector Field</summary>
    public unsafe partial class VectorField : UObject  {
        ///<summary>Bounds of the volume in local space.</summary>
        public unsafe Box Bounds {
            get {return VectorField_ptr->Bounds;}
            set {VectorField_ptr->Bounds = value;}
        }
        ///<summary>The intensity with which to multiplie vectors in this field.</summary>
        public unsafe float Intensity {
            get {return VectorField_ptr->Intensity;}
            set {VectorField_ptr->Intensity = value;}
        }
        static VectorField() {
            StaticClass = Main.GetClass("VectorField");
        }
        internal unsafe VectorField_fields* VectorField_ptr => (VectorField_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VectorField(IntPtr p) => UObject.Make<VectorField>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VectorField DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VectorField New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

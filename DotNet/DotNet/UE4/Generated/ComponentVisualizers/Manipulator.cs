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
using UE4.ComponentVisualizers.Native;
using UE4.Engine;

namespace UE4.ComponentVisualizers {
    ///<summary>Manipulator</summary>
    public unsafe partial class Manipulator : Actor  {
        ///<summary>The component to transform when this manipulator was moved.</summary>
        public unsafe SceneComponent AssociatedComponent {
            get {return Manipulator_ptr->AssociatedComponent;}
            set {Manipulator_ptr->AssociatedComponent = value;}
        }
        ///<summary>Visual representation of this manipulator.</summary>
        public unsafe StaticMeshComponent StaticMeshComponent {
            get {return Manipulator_ptr->StaticMeshComponent;}
            set {Manipulator_ptr->StaticMeshComponent = value;}
        }
        static Manipulator() {
            StaticClass = Main.GetClass("Manipulator");
        }
        internal unsafe Manipulator_fields* Manipulator_ptr => (Manipulator_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Manipulator(IntPtr p) => UObject.Make<Manipulator>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Manipulator DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Manipulator New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

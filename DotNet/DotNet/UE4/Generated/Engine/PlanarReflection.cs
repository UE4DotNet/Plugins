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
    ///<summary>Planar Reflection</summary>
    public unsafe partial class PlanarReflection : SceneCapture  {

        ///<summary>On Interp Toggle</summary>
        public void OnInterpToggle(bool bEnable)  => 
            PlanarReflection_methods.OnInterpToggle_method.Invoke(ObjPointer, bEnable);
        ///<summary>Planar reflection component.</summary>
        public unsafe PlanarReflectionComponent PlanarReflectionComponent {
            get {return PlanarReflection_ptr->PlanarReflectionComponent;}
        }
        ///<summary>Sprite Component</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return PlanarReflection_ptr->SpriteComponent;}
            set {PlanarReflection_ptr->SpriteComponent = value;}
        }
        public bool bShowPreviewPlane {
            get {return Main.GetGetBoolPropertyByName(this, "bShowPreviewPlane"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowPreviewPlane", value); }
        }
        static PlanarReflection() {
            StaticClass = Main.GetClass("PlanarReflection");
        }
        internal unsafe PlanarReflection_fields* PlanarReflection_ptr => (PlanarReflection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PlanarReflection(IntPtr p) => UObject.Make<PlanarReflection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PlanarReflection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PlanarReflection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

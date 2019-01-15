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
    ///<summary>Radial Force Actor</summary>
    public unsafe partial class RadialForceActor : RigidBodyBase  {

        ///<summary>Disable Force</summary>
        public void DisableForce()  => 
            RadialForceActor_methods.DisableForce_method.Invoke(ObjPointer);

        ///<summary>Enable Force</summary>
        public void EnableForce()  => 
            RadialForceActor_methods.EnableForce_method.Invoke(ObjPointer);

        ///<summary>BEGIN DEPRECATED (use component functions now in level script)</summary>
        public void FireImpulse()  => 
            RadialForceActor_methods.FireImpulse_method.Invoke(ObjPointer);

        ///<summary>Toggle Force</summary>
        public void ToggleForce()  => 
            RadialForceActor_methods.ToggleForce_method.Invoke(ObjPointer);
        ///<summary>Force component</summary>
        public unsafe RadialForceComponent ForceComponent {
            get {return RadialForceActor_ptr->ForceComponent;}
        }
        ///<summary>Sprite Component</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return RadialForceActor_ptr->SpriteComponent;}
            set {RadialForceActor_ptr->SpriteComponent = value;}
        }
        static RadialForceActor() {
            StaticClass = Main.GetClass("RadialForceActor");
        }
        internal unsafe RadialForceActor_fields* RadialForceActor_ptr => (RadialForceActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator RadialForceActor(IntPtr p) => UObject.Make<RadialForceActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static RadialForceActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static RadialForceActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

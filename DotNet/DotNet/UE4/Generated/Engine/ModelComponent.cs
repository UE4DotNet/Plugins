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
    ///<summary>ModelComponents are PrimitiveComponents that represent elements of BSP geometry in a ULevel object.</summary>
    ///<remarks>
    ///They are used exclusively by ULevel and are not intended as general-purpose components.
    ///
    ///@see ULevel
    ///</remarks>
    public unsafe partial class ModelComponent : PrimitiveComponent  {
        ///<summary>Description of collision</summary>
        public unsafe BodySetup ModelBodySetup {
            get {return ModelComponent_ptr->ModelBodySetup;}
            set {ModelComponent_ptr->ModelBodySetup = value;}
        }
        static ModelComponent() {
            StaticClass = Main.GetClass("ModelComponent");
        }
        internal unsafe ModelComponent_fields* ModelComponent_ptr => (ModelComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ModelComponent(IntPtr p) => UObject.Make<ModelComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ModelComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ModelComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

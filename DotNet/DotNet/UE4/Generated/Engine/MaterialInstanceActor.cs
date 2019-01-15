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
    ///<summary>Material Instance Actor</summary>
    public unsafe partial class MaterialInstanceActor : Actor  {
        ///<summary>Pointer to actors that we want to control paramters of using Matinee.</summary>
        public ObjectArrayField<Actor> TargetActors{ get {
            if(TargetActors_store == null) TargetActors_store = new ObjectArrayField<Actor> (&MaterialInstanceActor_ptr->TargetActors);
            return TargetActors_store;
        } }
        private ObjectArrayField<Actor> TargetActors_store;

        static MaterialInstanceActor() {
            StaticClass = Main.GetClass("MaterialInstanceActor");
        }
        internal unsafe MaterialInstanceActor_fields* MaterialInstanceActor_ptr => (MaterialInstanceActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialInstanceActor(IntPtr p) => UObject.Make<MaterialInstanceActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialInstanceActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialInstanceActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

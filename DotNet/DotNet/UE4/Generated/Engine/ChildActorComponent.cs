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
    ///<summary>A component that spawns an Actor when registered, and destroys it when unregistered.</summary>
    public unsafe partial class ChildActorComponent : SceneComponent  {

        ///<summary>Set Child Actor Class</summary>
        public void SetChildActorClass(SubclassOf<Actor> InClass)  => 
            ChildActorComponent_methods.SetChildActorClass_method.Invoke(ObjPointer, InClass);
        ///<summary>The class of Actor to spawn</summary>
        public unsafe SubclassOf<Actor> ChildActorClass {
            get {return ChildActorComponent_ptr->ChildActorClass;}
        }
        ///<summary>The actor that we spawned and own</summary>
        public unsafe Actor ChildActor {
            get {return ChildActorComponent_ptr->ChildActor;}
        }
        ///<summary>Property to point to the template child actor for details panel purposes</summary>
        public unsafe Actor ChildActorTemplate {
            get {return ChildActorComponent_ptr->ChildActorTemplate;}
            set {ChildActorComponent_ptr->ChildActorTemplate = value;}
        }
        static ChildActorComponent() {
            StaticClass = Main.GetClass("ChildActorComponent");
        }
        internal unsafe ChildActorComponent_fields* ChildActorComponent_ptr => (ChildActorComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ChildActorComponent(IntPtr p) => UObject.Make<ChildActorComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ChildActorComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ChildActorComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

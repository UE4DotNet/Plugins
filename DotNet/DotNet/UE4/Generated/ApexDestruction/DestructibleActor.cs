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
using UE4.ApexDestruction.Native;
using UE4.Engine;

namespace UE4.ApexDestruction {
    ///<summary>Destructible Actor</summary>
    public unsafe partial class DestructibleActor : Actor  {
        ///<summary>Destructible Component</summary>
        public unsafe DestructibleComponent DestructibleComponent {
            get {return DestructibleActor_ptr->DestructibleComponent;}
        }
        public bool bAffectNavigation {
            get {return Main.GetGetBoolPropertyByName(this, "bAffectNavigation"); }
            set {Main.SetGetBoolPropertyByName(this, "bAffectNavigation", value); }
        }
         //TODO: multicast delegate FActorFractureSignature OnActorFracture
        static DestructibleActor() {
            StaticClass = Main.GetClass("DestructibleActor");
        }
        internal unsafe DestructibleActor_fields* DestructibleActor_ptr => (DestructibleActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DestructibleActor(IntPtr p) => UObject.Make<DestructibleActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DestructibleActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DestructibleActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

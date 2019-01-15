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
using UE4.AIModule.Native;

namespace UE4.AIModule {
    ///<summary>AISense Event Damage</summary>
    public unsafe partial class AISenseEvent_Damage : AISenseEvent  {
        ///<summary>Event</summary>
        public unsafe AIDamageEvent Event {
            get {return AISenseEvent_Damage_ptr->Event;}
            set {AISenseEvent_Damage_ptr->Event = value;}
        }
        static AISenseEvent_Damage() {
            StaticClass = Main.GetClass("AISenseEvent_Damage");
        }
        internal unsafe AISenseEvent_Damage_fields* AISenseEvent_Damage_ptr => (AISenseEvent_Damage_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AISenseEvent_Damage(IntPtr p) => UObject.Make<AISenseEvent_Damage>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AISenseEvent_Damage DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AISenseEvent_Damage New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

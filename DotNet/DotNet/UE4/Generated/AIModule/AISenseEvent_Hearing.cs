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
    ///<summary>AISense Event Hearing</summary>
    public unsafe partial class AISenseEvent_Hearing : AISenseEvent  {
        ///<summary>Event</summary>
        public unsafe AINoiseEvent Event {
            get {return AISenseEvent_Hearing_ptr->Event;}
            set {AISenseEvent_Hearing_ptr->Event = value;}
        }
        static AISenseEvent_Hearing() {
            StaticClass = Main.GetClass("AISenseEvent_Hearing");
        }
        internal unsafe AISenseEvent_Hearing_fields* AISenseEvent_Hearing_ptr => (AISenseEvent_Hearing_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AISenseEvent_Hearing(IntPtr p) => UObject.Make<AISenseEvent_Hearing>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AISenseEvent_Hearing DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AISenseEvent_Hearing New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

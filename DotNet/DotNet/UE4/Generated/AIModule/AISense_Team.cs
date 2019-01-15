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
    ///<summary>AISense Team</summary>
    public unsafe partial class AISense_Team : AISense  {
         //TODO: array not UObject TArray RegisteredEvents
        static AISense_Team() {
            StaticClass = Main.GetClass("AISense_Team");
        }
        internal unsafe AISense_Team_fields* AISense_Team_ptr => (AISense_Team_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AISense_Team(IntPtr p) => UObject.Make<AISense_Team>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AISense_Team DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AISense_Team New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

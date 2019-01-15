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
    ///<summary>AISense Config Blueprint</summary>
    public unsafe partial class AISenseConfig_Blueprint : AISenseConfig  {
        ///<summary>Implementation</summary>
        public unsafe SubclassOf<AISense_Blueprint> Implementation {
            get {return AISenseConfig_Blueprint_ptr->Implementation;}
        }
        static AISenseConfig_Blueprint() {
            StaticClass = Main.GetClass("AISenseConfig_Blueprint");
        }
        internal unsafe AISenseConfig_Blueprint_fields* AISenseConfig_Blueprint_ptr => (AISenseConfig_Blueprint_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AISenseConfig_Blueprint(IntPtr p) => UObject.Make<AISenseConfig_Blueprint>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AISenseConfig_Blueprint DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AISenseConfig_Blueprint New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

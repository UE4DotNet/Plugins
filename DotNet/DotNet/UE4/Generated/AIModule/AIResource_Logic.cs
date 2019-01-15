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
using UE4.GameplayTasks;

namespace UE4.AIModule {
    ///<summary>AIResource Logic</summary>
    public unsafe partial class AIResource_Logic : GameplayTaskResource  {
        static AIResource_Logic() {
            StaticClass = Main.GetClass("AIResource_Logic");
        }
        internal unsafe AIResource_Logic_fields* AIResource_Logic_ptr => (AIResource_Logic_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AIResource_Logic(IntPtr p) => UObject.Make<AIResource_Logic>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AIResource_Logic DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AIResource_Logic New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

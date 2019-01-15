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
    ///<summary>Blackboard Key Type Float</summary>
    public unsafe partial class BlackboardKeyType_Float : BlackboardKeyType  {
        static BlackboardKeyType_Float() {
            StaticClass = Main.GetClass("BlackboardKeyType_Float");
        }
        internal unsafe BlackboardKeyType_Float_fields* BlackboardKeyType_Float_ptr => (BlackboardKeyType_Float_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlackboardKeyType_Float(IntPtr p) => UObject.Make<BlackboardKeyType_Float>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlackboardKeyType_Float DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlackboardKeyType_Float New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>DEPRECATED, please use UBlackboardKeyType_Enum instead</summary>
    public unsafe partial class BlackboardKeyType_NativeEnum : BlackboardKeyType  {
         //TODO: string FString EnumName
        ///<summary>Enum Type</summary>
        public unsafe UEnum EnumType {
            get {return BlackboardKeyType_NativeEnum_ptr->EnumType;}
            set {BlackboardKeyType_NativeEnum_ptr->EnumType = value;}
        }
        static BlackboardKeyType_NativeEnum() {
            StaticClass = Main.GetClass("BlackboardKeyType_NativeEnum");
        }
        internal unsafe BlackboardKeyType_NativeEnum_fields* BlackboardKeyType_NativeEnum_ptr => (BlackboardKeyType_NativeEnum_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlackboardKeyType_NativeEnum(IntPtr p) => UObject.Make<BlackboardKeyType_NativeEnum>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlackboardKeyType_NativeEnum DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlackboardKeyType_NativeEnum New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

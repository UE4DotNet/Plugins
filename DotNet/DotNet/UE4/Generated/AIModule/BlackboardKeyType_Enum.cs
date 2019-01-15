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
    ///<summary>Blackboard Key Type Enum</summary>
    public unsafe partial class BlackboardKeyType_Enum : BlackboardKeyType  {
        ///<summary>Enum Type</summary>
        public unsafe UEnum EnumType {
            get {return BlackboardKeyType_Enum_ptr->EnumType;}
            set {BlackboardKeyType_Enum_ptr->EnumType = value;}
        }
         //TODO: string FString EnumName
        public bool bIsEnumNameValid {
            get {return Main.GetGetBoolPropertyByName(this, "bIsEnumNameValid"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsEnumNameValid", value); }
        }
        static BlackboardKeyType_Enum() {
            StaticClass = Main.GetClass("BlackboardKeyType_Enum");
        }
        internal unsafe BlackboardKeyType_Enum_fields* BlackboardKeyType_Enum_ptr => (BlackboardKeyType_Enum_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlackboardKeyType_Enum(IntPtr p) => UObject.Make<BlackboardKeyType_Enum>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlackboardKeyType_Enum DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlackboardKeyType_Enum New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

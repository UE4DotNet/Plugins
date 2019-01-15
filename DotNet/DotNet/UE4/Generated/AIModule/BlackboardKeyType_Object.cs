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
    ///<summary>Blackboard Key Type Object</summary>
    public unsafe partial class BlackboardKeyType_Object : BlackboardKeyType  {
        ///<summary>Base Class</summary>
        public unsafe SubclassOf<UObject> BaseClass {
            get {return BlackboardKeyType_Object_ptr->BaseClass;}
            set {BlackboardKeyType_Object_ptr->BaseClass = value;}
        }
        static BlackboardKeyType_Object() {
            StaticClass = Main.GetClass("BlackboardKeyType_Object");
        }
        internal unsafe BlackboardKeyType_Object_fields* BlackboardKeyType_Object_ptr => (BlackboardKeyType_Object_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlackboardKeyType_Object(IntPtr p) => UObject.Make<BlackboardKeyType_Object>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlackboardKeyType_Object DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlackboardKeyType_Object New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

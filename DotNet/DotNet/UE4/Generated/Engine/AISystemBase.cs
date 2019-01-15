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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>AISystem Base</summary>
    public unsafe partial class AISystemBase : UObject  {
        ///<summary>AISystem Class Name</summary>
        public unsafe SoftClassPath AISystemClassName {
            get {return AISystemBase_ptr->AISystemClassName;}
            set {AISystemBase_ptr->AISystemClassName = value;}
        }
        ///<summary>AISystem Module Name</summary>
        public unsafe Name AISystemModuleName {
            get {return AISystemBase_ptr->AISystemModuleName;}
            set {AISystemBase_ptr->AISystemModuleName = value;}
        }
        public bool bInstantiateAISystemOnClient {
            get {return Main.GetGetBoolPropertyByName(this, "bInstantiateAISystemOnClient"); }
            set {Main.SetGetBoolPropertyByName(this, "bInstantiateAISystemOnClient", value); }
        }
        static AISystemBase() {
            StaticClass = Main.GetClass("AISystemBase");
        }
        internal unsafe AISystemBase_fields* AISystemBase_ptr => (AISystemBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AISystemBase(IntPtr p) => UObject.Make<AISystemBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AISystemBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AISystemBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

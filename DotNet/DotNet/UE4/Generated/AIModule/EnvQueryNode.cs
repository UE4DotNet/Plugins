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
    ///<summary>Env Query Node</summary>
    public unsafe partial class EnvQueryNode : UObject  {
        ///<summary>Versioning for updating deprecated properties</summary>
        public unsafe int VerNum {
            get {return EnvQueryNode_ptr->VerNum;}
            set {EnvQueryNode_ptr->VerNum = value;}
        }
        static EnvQueryNode() {
            StaticClass = Main.GetClass("EnvQueryNode");
        }
        internal unsafe EnvQueryNode_fields* EnvQueryNode_ptr => (EnvQueryNode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryNode(IntPtr p) => UObject.Make<EnvQueryNode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryNode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryNode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

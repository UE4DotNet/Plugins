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
    ///<summary>BTTask Blackboard Base</summary>
    public unsafe partial class BTTask_BlackboardBase : BTTaskNode  {
        ///<summary>blackboard key selector</summary>
        public unsafe BlackboardKeySelector BlackboardKey {
            get {return BTTask_BlackboardBase_ptr->BlackboardKey;}
            set {BTTask_BlackboardBase_ptr->BlackboardKey = value;}
        }
        static BTTask_BlackboardBase() {
            StaticClass = Main.GetClass("BTTask_BlackboardBase");
        }
        internal unsafe BTTask_BlackboardBase_fields* BTTask_BlackboardBase_ptr => (BTTask_BlackboardBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTask_BlackboardBase(IntPtr p) => UObject.Make<BTTask_BlackboardBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTask_BlackboardBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTask_BlackboardBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

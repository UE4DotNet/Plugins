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
    ///<summary>Action task node.</summary>
    ///<remarks>Push pawn action to controller.</remarks>
    public unsafe partial class BTTask_PushPawnAction : BTTask_PawnActionBase  {
        ///<summary>Action</summary>
        public unsafe PawnAction Action {
            get {return BTTask_PushPawnAction_ptr->Action;}
            set {BTTask_PushPawnAction_ptr->Action = value;}
        }
        static BTTask_PushPawnAction() {
            StaticClass = Main.GetClass("BTTask_PushPawnAction");
        }
        internal unsafe BTTask_PushPawnAction_fields* BTTask_PushPawnAction_ptr => (BTTask_PushPawnAction_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTask_PushPawnAction(IntPtr p) => UObject.Make<BTTask_PushPawnAction>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTask_PushPawnAction DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTask_PushPawnAction New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

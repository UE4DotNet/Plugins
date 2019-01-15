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
    ///<summary>
    ///Base class for managing pawn actions
    ///Task will set itself as action observer before pushing it to AI Controller,
    ///override OnActionEvent if you need any special event handling.
    ///</summary>
    ///<remarks>Please use result returned by PushAction for ExecuteTask function.</remarks>
    public unsafe partial class BTTask_PawnActionBase : BTTaskNode  {
        static BTTask_PawnActionBase() {
            StaticClass = Main.GetClass("BTTask_PawnActionBase");
        }
        internal unsafe BTTask_PawnActionBase_fields* BTTask_PawnActionBase_ptr => (BTTask_PawnActionBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTask_PawnActionBase(IntPtr p) => UObject.Make<BTTask_PawnActionBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTask_PawnActionBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTask_PawnActionBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>Reached Move Goal decorator node.</summary>
    ///<remarks>A decorator node that bases its condition on whether the AI controller's path following component returns that it has reached its goal.</remarks>
    public unsafe partial class BTDecorator_ReachedMoveGoal : BTDecorator  {
        static BTDecorator_ReachedMoveGoal() {
            StaticClass = Main.GetClass("BTDecorator_ReachedMoveGoal");
        }
        internal unsafe BTDecorator_ReachedMoveGoal_fields* BTDecorator_ReachedMoveGoal_ptr => (BTDecorator_ReachedMoveGoal_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator_ReachedMoveGoal(IntPtr p) => UObject.Make<BTDecorator_ReachedMoveGoal>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator_ReachedMoveGoal DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator_ReachedMoveGoal New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

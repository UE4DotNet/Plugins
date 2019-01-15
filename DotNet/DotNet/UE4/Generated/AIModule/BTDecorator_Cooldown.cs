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
    ///<summary>Cooldown decorator node.</summary>
    ///<remarks>A decorator node that bases its condition on whether a cooldown timer has expired.</remarks>
    public unsafe partial class BTDecorator_Cooldown : BTDecorator  {
        ///<summary>max allowed time for execution of underlying node</summary>
        public unsafe float CoolDownTime {
            get {return BTDecorator_Cooldown_ptr->CoolDownTime;}
            set {BTDecorator_Cooldown_ptr->CoolDownTime = value;}
        }
        static BTDecorator_Cooldown() {
            StaticClass = Main.GetClass("BTDecorator_Cooldown");
        }
        internal unsafe BTDecorator_Cooldown_fields* BTDecorator_Cooldown_ptr => (BTDecorator_Cooldown_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator_Cooldown(IntPtr p) => UObject.Make<BTDecorator_Cooldown>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator_Cooldown DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator_Cooldown New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

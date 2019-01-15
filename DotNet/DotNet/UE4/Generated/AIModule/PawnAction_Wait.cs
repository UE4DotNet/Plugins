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
    ///<summary>uses system timers rather then ticking</summary>
    public unsafe partial class PawnAction_Wait : PawnAction  {
        ///<summary>Time to Wait</summary>
        public unsafe float TimeToWait {
            get {return PawnAction_Wait_ptr->TimeToWait;}
            set {PawnAction_Wait_ptr->TimeToWait = value;}
        }
        static PawnAction_Wait() {
            StaticClass = Main.GetClass("PawnAction_Wait");
        }
        internal unsafe PawnAction_Wait_fields* PawnAction_Wait_ptr => (PawnAction_Wait_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PawnAction_Wait(IntPtr p) => UObject.Make<PawnAction_Wait>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PawnAction_Wait DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PawnAction_Wait New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

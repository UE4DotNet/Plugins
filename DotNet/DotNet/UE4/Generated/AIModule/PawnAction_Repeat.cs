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
    ///<summary>Pawn Action Repeat</summary>
    public unsafe partial class PawnAction_Repeat : PawnAction  {
        ///<summary>Action to repeat. This instance won't really be run, it's a source for copying actions to be actually performed</summary>
        public unsafe PawnAction ActionToRepeat {
            get {return PawnAction_Repeat_ptr->ActionToRepeat;}
            set {PawnAction_Repeat_ptr->ActionToRepeat = value;}
        }
        ///<summary>Recent Action Copy</summary>
        public unsafe PawnAction RecentActionCopy {
            get {return PawnAction_Repeat_ptr->RecentActionCopy;}
            set {PawnAction_Repeat_ptr->RecentActionCopy = value;}
        }
        ///<summary>Child Failure Handling Mode</summary>
        public unsafe byte ChildFailureHandlingMode {
            get {return PawnAction_Repeat_ptr->ChildFailureHandlingMode;}
        }
        static PawnAction_Repeat() {
            StaticClass = Main.GetClass("PawnAction_Repeat");
        }
        internal unsafe PawnAction_Repeat_fields* PawnAction_Repeat_ptr => (PawnAction_Repeat_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PawnAction_Repeat(IntPtr p) => UObject.Make<PawnAction_Repeat>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PawnAction_Repeat DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PawnAction_Repeat New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

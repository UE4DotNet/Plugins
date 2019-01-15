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
    ///<summary>Pawn Action Sequence</summary>
    public unsafe partial class PawnAction_Sequence : PawnAction  {
        ///<summary>Action Sequence</summary>
        public ObjectArrayField<PawnAction> ActionSequence{ get {
            if(ActionSequence_store == null) ActionSequence_store = new ObjectArrayField<PawnAction> (&PawnAction_Sequence_ptr->ActionSequence);
            return ActionSequence_store;
        } }
        private ObjectArrayField<PawnAction> ActionSequence_store;

        ///<summary>Child Failure Handling Mode</summary>
        public unsafe byte ChildFailureHandlingMode {
            get {return PawnAction_Sequence_ptr->ChildFailureHandlingMode;}
        }
        ///<summary>Recent Action Copy</summary>
        public unsafe PawnAction RecentActionCopy {
            get {return PawnAction_Sequence_ptr->RecentActionCopy;}
            set {PawnAction_Sequence_ptr->RecentActionCopy = value;}
        }
        static PawnAction_Sequence() {
            StaticClass = Main.GetClass("PawnAction_Sequence");
        }
        internal unsafe PawnAction_Sequence_fields* PawnAction_Sequence_ptr => (PawnAction_Sequence_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PawnAction_Sequence(IntPtr p) => UObject.Make<PawnAction_Sequence>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PawnAction_Sequence DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PawnAction_Sequence New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

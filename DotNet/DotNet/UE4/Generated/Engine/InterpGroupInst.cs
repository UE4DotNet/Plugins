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
    ///<summary>Interp Group Inst</summary>
    public unsafe partial class InterpGroupInst : UObject  {
        ///<summary>UInterpGroup within the InterpData that this is an instance of.</summary>
        public unsafe InterpGroup Group {
            get {return InterpGroupInst_ptr->Group;}
            set {InterpGroupInst_ptr->Group = value;}
        }
        ///<summary>Actor that this Group instance is acting upon.</summary>
        ///<remarks>NB: that this may be set to NULL at any time as a result of the  AActor  being destroyed.</remarks>
        public unsafe Actor GroupActor {
            get {return InterpGroupInst_ptr->GroupActor;}
            set {InterpGroupInst_ptr->GroupActor = value;}
        }
        ///<summary>Array if InterpTrack instances. TrackInst.Num() == UInterpGroup.InterpTrack.Num() must be true.</summary>
        public ObjectArrayField<InterpTrackInst> TrackInst{ get {
            if(TrackInst_store == null) TrackInst_store = new ObjectArrayField<InterpTrackInst> (&InterpGroupInst_ptr->TrackInst);
            return TrackInst_store;
        } }
        private ObjectArrayField<InterpTrackInst> TrackInst_store;

        static InterpGroupInst() {
            StaticClass = Main.GetClass("InterpGroupInst");
        }
        internal unsafe InterpGroupInst_fields* InterpGroupInst_ptr => (InterpGroupInst_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpGroupInst(IntPtr p) => UObject.Make<InterpGroupInst>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpGroupInst DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpGroupInst New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

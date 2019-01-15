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
using UE4.Sequencer.Native;
using UE4.Engine;

namespace UE4.Sequencer {
    ///<summary>Sequencer Mesh Trail</summary>
    public unsafe partial class SequencerMeshTrail : Actor  {
        static SequencerMeshTrail() {
            StaticClass = Main.GetClass("SequencerMeshTrail");
        }
        internal unsafe SequencerMeshTrail_fields* SequencerMeshTrail_ptr => (SequencerMeshTrail_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SequencerMeshTrail(IntPtr p) => UObject.Make<SequencerMeshTrail>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SequencerMeshTrail DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SequencerMeshTrail New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

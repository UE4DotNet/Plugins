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
using UE4.AudioEditor.Native;
using UE4.Engine;

namespace UE4.AudioEditor {
    ///<summary>Sound Class Graph Node</summary>
    public unsafe partial class SoundClassGraphNode : EdGraphNode  {
        ///<summary>The SoundNode this represents</summary>
        public unsafe SoundClass SoundClass {
            get {return SoundClassGraphNode_ptr->SoundClass;}
            set {SoundClassGraphNode_ptr->SoundClass = value;}
        }
        static SoundClassGraphNode() {
            StaticClass = Main.GetClass("SoundClassGraphNode");
        }
        internal unsafe SoundClassGraphNode_fields* SoundClassGraphNode_ptr => (SoundClassGraphNode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundClassGraphNode(IntPtr p) => UObject.Make<SoundClassGraphNode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundClassGraphNode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundClassGraphNode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

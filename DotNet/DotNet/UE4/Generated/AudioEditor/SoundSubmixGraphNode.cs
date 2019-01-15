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
    ///<summary>Sound Submix Graph Node</summary>
    public unsafe partial class SoundSubmixGraphNode : EdGraphNode  {
        ///<summary>The SoundSubmix this represents</summary>
        public unsafe SoundSubmix SoundSubmix {
            get {return SoundSubmixGraphNode_ptr->SoundSubmix;}
            set {SoundSubmixGraphNode_ptr->SoundSubmix = value;}
        }
        static SoundSubmixGraphNode() {
            StaticClass = Main.GetClass("SoundSubmixGraphNode");
        }
        internal unsafe SoundSubmixGraphNode_fields* SoundSubmixGraphNode_ptr => (SoundSubmixGraphNode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundSubmixGraphNode(IntPtr p) => UObject.Make<SoundSubmixGraphNode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundSubmixGraphNode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundSubmixGraphNode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>Sound Submix Graph</summary>
    public unsafe partial class SoundSubmixGraph : EdGraph  {
        static SoundSubmixGraph() {
            StaticClass = Main.GetClass("SoundSubmixGraph");
        }
        internal unsafe SoundSubmixGraph_fields* SoundSubmixGraph_ptr => (SoundSubmixGraph_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundSubmixGraph(IntPtr p) => UObject.Make<SoundSubmixGraph>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundSubmixGraph DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundSubmixGraph New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

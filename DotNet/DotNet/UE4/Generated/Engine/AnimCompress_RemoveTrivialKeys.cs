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
    ///<summary>Anim Compress Remove Trivial Keys</summary>
    public unsafe partial class AnimCompress_RemoveTrivialKeys : AnimCompress  {
        ///<summary>Max Pos Diff</summary>
        public unsafe float MaxPosDiff {
            get {return AnimCompress_RemoveTrivialKeys_ptr->MaxPosDiff;}
            set {AnimCompress_RemoveTrivialKeys_ptr->MaxPosDiff = value;}
        }
        ///<summary>Max Angle Diff</summary>
        public unsafe float MaxAngleDiff {
            get {return AnimCompress_RemoveTrivialKeys_ptr->MaxAngleDiff;}
            set {AnimCompress_RemoveTrivialKeys_ptr->MaxAngleDiff = value;}
        }
        ///<summary>Max Scale Diff</summary>
        public unsafe float MaxScaleDiff {
            get {return AnimCompress_RemoveTrivialKeys_ptr->MaxScaleDiff;}
            set {AnimCompress_RemoveTrivialKeys_ptr->MaxScaleDiff = value;}
        }
        static AnimCompress_RemoveTrivialKeys() {
            StaticClass = Main.GetClass("AnimCompress_RemoveTrivialKeys");
        }
        internal unsafe AnimCompress_RemoveTrivialKeys_fields* AnimCompress_RemoveTrivialKeys_ptr => (AnimCompress_RemoveTrivialKeys_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimCompress_RemoveTrivialKeys(IntPtr p) => UObject.Make<AnimCompress_RemoveTrivialKeys>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimCompress_RemoveTrivialKeys DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimCompress_RemoveTrivialKeys New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

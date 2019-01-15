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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Editor Anim Segment</summary>
    public unsafe partial class EditorAnimSegment : EditorAnimBaseObj  {
        ///<summary>Default blend in time.</summary>
        public unsafe AnimSegment AnimSegment {
            get {return EditorAnimSegment_ptr->AnimSegment;}
            set {EditorAnimSegment_ptr->AnimSegment = value;}
        }
        static EditorAnimSegment() {
            StaticClass = Main.GetClass("EditorAnimSegment");
        }
        internal unsafe EditorAnimSegment_fields* EditorAnimSegment_ptr => (EditorAnimSegment_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditorAnimSegment(IntPtr p) => UObject.Make<EditorAnimSegment>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditorAnimSegment DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditorAnimSegment New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

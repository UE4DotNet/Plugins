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
    ///<summary>Selects a child node based on the value of a boolean parameter</summary>
    public unsafe partial class SoundNodeBranch : SoundNode  {
        ///<summary>The name of the boolean parameter to use to determine which branch we should take</summary>
        public unsafe Name BoolParameterName {
            get {return SoundNodeBranch_ptr->BoolParameterName;}
            set {SoundNodeBranch_ptr->BoolParameterName = value;}
        }
        static SoundNodeBranch() {
            StaticClass = Main.GetClass("SoundNodeBranch");
        }
        internal unsafe SoundNodeBranch_fields* SoundNodeBranch_ptr => (SoundNodeBranch_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeBranch(IntPtr p) => UObject.Make<SoundNodeBranch>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeBranch DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeBranch New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>Material Graph Node Base</summary>
    public unsafe partial class MaterialGraphNode_Base : EdGraphNode  {
        static MaterialGraphNode_Base() {
            StaticClass = Main.GetClass("MaterialGraphNode_Base");
        }
        internal unsafe MaterialGraphNode_Base_fields* MaterialGraphNode_Base_ptr => (MaterialGraphNode_Base_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialGraphNode_Base(IntPtr p) => UObject.Make<MaterialGraphNode_Base>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialGraphNode_Base DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialGraphNode_Base New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

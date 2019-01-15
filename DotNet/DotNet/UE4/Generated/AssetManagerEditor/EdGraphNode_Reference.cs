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
using UE4.AssetManagerEditor.Native;
using UE4.Engine;

namespace UE4.AssetManagerEditor {
    ///<summary>Ed Graph Node Reference</summary>
    public unsafe partial class EdGraphNode_Reference : EdGraphNode  {
        static EdGraphNode_Reference() {
            StaticClass = Main.GetClass("EdGraphNode_Reference");
        }
        internal unsafe EdGraphNode_Reference_fields* EdGraphNode_Reference_ptr => (EdGraphNode_Reference_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EdGraphNode_Reference(IntPtr p) => UObject.Make<EdGraphNode_Reference>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EdGraphNode_Reference DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EdGraphNode_Reference New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>The line batch component buffers and draws lines (and some other line-based shapes) in a scene.</summary>
    ///<remarks>This can be useful for debug drawing, but is not very performant for runtime use.</remarks>
    public unsafe partial class LineBatchComponent : PrimitiveComponent  {
        static LineBatchComponent() {
            StaticClass = Main.GetClass("LineBatchComponent");
        }
        internal unsafe LineBatchComponent_fields* LineBatchComponent_ptr => (LineBatchComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LineBatchComponent(IntPtr p) => UObject.Make<LineBatchComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LineBatchComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LineBatchComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
using UE4.FunctionalTesting.Native;
using UE4.Engine;

namespace UE4.FunctionalTesting {
    ///<summary>Func Test Rendering Component</summary>
    public unsafe partial class FuncTestRenderingComponent : PrimitiveComponent  {
        static FuncTestRenderingComponent() {
            StaticClass = Main.GetClass("FuncTestRenderingComponent");
        }
        internal unsafe FuncTestRenderingComponent_fields* FuncTestRenderingComponent_ptr => (FuncTestRenderingComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FuncTestRenderingComponent(IntPtr p) => UObject.Make<FuncTestRenderingComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FuncTestRenderingComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FuncTestRenderingComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
using UE4.GameplayDebugger.Native;
using UE4.Engine;

namespace UE4.GameplayDebugger {
    ///<summary>Gameplay Debugger Rendering Component</summary>
    public unsafe partial class GameplayDebuggerRenderingComponent : PrimitiveComponent  {
        static GameplayDebuggerRenderingComponent() {
            StaticClass = Main.GetClass("GameplayDebuggerRenderingComponent");
        }
        internal unsafe GameplayDebuggerRenderingComponent_fields* GameplayDebuggerRenderingComponent_ptr => (GameplayDebuggerRenderingComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayDebuggerRenderingComponent(IntPtr p) => UObject.Make<GameplayDebuggerRenderingComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayDebuggerRenderingComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayDebuggerRenderingComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

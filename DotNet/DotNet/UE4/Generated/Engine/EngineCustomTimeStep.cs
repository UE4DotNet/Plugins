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
    ///<summary>A CustomTimeStep control the Engine Framerate/Timestep.</summary>
    ///<remarks>
    ///This will update the FApp::CurrentTime/FApp::DeltaTime.
    ///This is useful when you want the engine to be synchronized with an external clock (genlock).
    ///</remarks>
    public unsafe partial class EngineCustomTimeStep : UObject  {
        static EngineCustomTimeStep() {
            StaticClass = Main.GetClass("EngineCustomTimeStep");
        }
        internal unsafe EngineCustomTimeStep_fields* EngineCustomTimeStep_ptr => (EngineCustomTimeStep_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EngineCustomTimeStep(IntPtr p) => UObject.Make<EngineCustomTimeStep>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EngineCustomTimeStep DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EngineCustomTimeStep New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

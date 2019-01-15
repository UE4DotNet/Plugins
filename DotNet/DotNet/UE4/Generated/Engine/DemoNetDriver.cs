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
    ///<summary>Simulated network driver for recording and playing back game sessions.</summary>
    public unsafe partial class DemoNetDriver : NetDriver  {
         //TODO: map TMap RollbackNetStartupActors
        ///<summary>Maximum time allowed each frame to spend on saving a checkpoint.</summary>
        ///<remarks>
        ///If 0, it will save the checkpoint in a single frame, regardless of how long it takes.
        ///See also demo.CheckpointSaveMaxMSPerFrameOverride.
        ///</remarks>
        public unsafe float CheckpointSaveMaxMSPerFrame {
            get {return DemoNetDriver_ptr->CheckpointSaveMaxMSPerFrame;}
            set {DemoNetDriver_ptr->CheckpointSaveMaxMSPerFrame = value;}
        }
        public bool bIsLocalReplay {
            get {return Main.GetGetBoolPropertyByName(this, "bIsLocalReplay"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsLocalReplay", value); }
        }
        static DemoNetDriver() {
            StaticClass = Main.GetClass("DemoNetDriver");
        }
        internal unsafe DemoNetDriver_fields* DemoNetDriver_ptr => (DemoNetDriver_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DemoNetDriver(IntPtr p) => UObject.Make<DemoNetDriver>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DemoNetDriver DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DemoNetDriver New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

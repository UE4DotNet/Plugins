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
    ///<summary>Anim Notify Pause Clothing Simulation</summary>
    public unsafe partial class AnimNotify_PauseClothingSimulation : AnimNotify  {
        static AnimNotify_PauseClothingSimulation() {
            StaticClass = Main.GetClass("AnimNotify_PauseClothingSimulation");
        }
        internal unsafe AnimNotify_PauseClothingSimulation_fields* AnimNotify_PauseClothingSimulation_ptr => (AnimNotify_PauseClothingSimulation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimNotify_PauseClothingSimulation(IntPtr p) => UObject.Make<AnimNotify_PauseClothingSimulation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimNotify_PauseClothingSimulation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimNotify_PauseClothingSimulation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

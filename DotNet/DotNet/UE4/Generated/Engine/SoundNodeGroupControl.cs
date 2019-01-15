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
    ///<summary>Plays different sounds depending on the number of active sounds</summary>
    ///<remarks>Any time a new sound is played, the first group that has an available slot will be chosen</remarks>
    public unsafe partial class SoundNodeGroupControl : SoundNode  {
         //TODO: array not UObject TArray GroupSizes
        static SoundNodeGroupControl() {
            StaticClass = Main.GetClass("SoundNodeGroupControl");
        }
        internal unsafe SoundNodeGroupControl_fields* SoundNodeGroupControl_ptr => (SoundNodeGroupControl_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeGroupControl(IntPtr p) => UObject.Make<SoundNodeGroupControl>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeGroupControl DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeGroupControl New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

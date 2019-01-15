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
using UE4.AIModule.Native;
using UE4.Engine;

namespace UE4.AIModule {
    ///<summary>Play Sound task node.</summary>
    ///<remarks>Plays the specified sound when executed.</remarks>
    public unsafe partial class BTTask_PlaySound : BTTaskNode  {
        ///<summary>CUE to play</summary>
        public unsafe SoundCue SoundToPlay {
            get {return BTTask_PlaySound_ptr->SoundToPlay;}
            set {BTTask_PlaySound_ptr->SoundToPlay = value;}
        }
        static BTTask_PlaySound() {
            StaticClass = Main.GetClass("BTTask_PlaySound");
        }
        internal unsafe BTTask_PlaySound_fields* BTTask_PlaySound_ptr => (BTTask_PlaySound_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTask_PlaySound(IntPtr p) => UObject.Make<BTTask_PlaySound>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTask_PlaySound DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTask_PlaySound New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

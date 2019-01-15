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
using UE4.LightPropagationVolumeRuntime.Native;
using UE4.Renderer;

namespace UE4.LightPropagationVolumeRuntime {
    ///<summary>BlueprintType to make the object spawnable in blueprint</summary>
    public unsafe partial class LightPropagationVolumeBlendable : UObject  {
        ///<summary>Settings</summary>
        public unsafe LightPropagationVolumeSettings Settings {
            get {return LightPropagationVolumeBlendable_ptr->Settings;}
            set {LightPropagationVolumeBlendable_ptr->Settings = value;}
        }
        ///<summary>0:no effect, 1:full effect</summary>
        public unsafe float BlendWeight {
            get {return LightPropagationVolumeBlendable_ptr->BlendWeight;}
            set {LightPropagationVolumeBlendable_ptr->BlendWeight = value;}
        }
        static LightPropagationVolumeBlendable() {
            StaticClass = Main.GetClass("LightPropagationVolumeBlendable");
        }
        internal unsafe LightPropagationVolumeBlendable_fields* LightPropagationVolumeBlendable_ptr => (LightPropagationVolumeBlendable_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LightPropagationVolumeBlendable(IntPtr p) => UObject.Make<LightPropagationVolumeBlendable>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LightPropagationVolumeBlendable DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LightPropagationVolumeBlendable New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

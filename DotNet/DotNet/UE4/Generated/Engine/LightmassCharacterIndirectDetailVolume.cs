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
    ///<summary>Lightmass Character Indirect Detail Volume</summary>
    public unsafe partial class LightmassCharacterIndirectDetailVolume : Volume  {
        static LightmassCharacterIndirectDetailVolume() {
            StaticClass = Main.GetClass("LightmassCharacterIndirectDetailVolume");
        }
        internal unsafe LightmassCharacterIndirectDetailVolume_fields* LightmassCharacterIndirectDetailVolume_ptr => (LightmassCharacterIndirectDetailVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LightmassCharacterIndirectDetailVolume(IntPtr p) => UObject.Make<LightmassCharacterIndirectDetailVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LightmassCharacterIndirectDetailVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LightmassCharacterIndirectDetailVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

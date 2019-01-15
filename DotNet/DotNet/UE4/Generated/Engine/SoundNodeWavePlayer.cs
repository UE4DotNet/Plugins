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
    ///<summary>Sound node that contains a reference to the raw wave file to be played</summary>
    public unsafe partial class SoundNodeWavePlayer : SoundNodeAssetReferencer  {
         //TODO: soft object TSoftObjectPtr<USoundWave> SoundWaveAssetPtr
        ///<summary>Sound Wave</summary>
        public unsafe SoundWave SoundWave {
            get {return SoundNodeWavePlayer_ptr->SoundWave;}
            set {SoundNodeWavePlayer_ptr->SoundWave = value;}
        }
        public bool bLooping {
            get {return Main.GetGetBoolPropertyByName(this, "bLooping"); }
            set {Main.SetGetBoolPropertyByName(this, "bLooping", value); }
        }
        static SoundNodeWavePlayer() {
            StaticClass = Main.GetClass("SoundNodeWavePlayer");
        }
        internal unsafe SoundNodeWavePlayer_fields* SoundNodeWavePlayer_ptr => (SoundNodeWavePlayer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeWavePlayer(IntPtr p) => UObject.Make<SoundNodeWavePlayer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeWavePlayer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeWavePlayer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

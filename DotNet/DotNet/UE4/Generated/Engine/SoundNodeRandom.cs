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
    ///<summary>Selects sounds from a random set</summary>
    public unsafe partial class SoundNodeRandom : SoundNode  {
         //TODO: array not UObject TArray Weights
        ///<summary>
        ///If greater than 0, then upon each level load such a number of inputs will be randomly selected
        ///and the rest will be removed.
        ///</summary>
        ///<remarks>
        ///This can be used to cut down the memory usage of large randomizing
        ///cues.
        ///</remarks>
        public unsafe int PreselectAtLevelLoad {
            get {return SoundNodeRandom_ptr->PreselectAtLevelLoad;}
            set {SoundNodeRandom_ptr->PreselectAtLevelLoad = value;}
        }
        public bool bShouldExcludeFromBranchCulling {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldExcludeFromBranchCulling"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldExcludeFromBranchCulling", value); }
        }
        public bool bSoundCueExcludedFromBranchCulling {
            get {return Main.GetGetBoolPropertyByName(this, "bSoundCueExcludedFromBranchCulling"); }
            set {Main.SetGetBoolPropertyByName(this, "bSoundCueExcludedFromBranchCulling", value); }
        }
        public bool bRandomizeWithoutReplacement {
            get {return Main.GetGetBoolPropertyByName(this, "bRandomizeWithoutReplacement"); }
            set {Main.SetGetBoolPropertyByName(this, "bRandomizeWithoutReplacement", value); }
        }
         //TODO: array not UObject TArray HasBeenUsed
        ///<summary>Counter var so we don't have to count all of the used sounds each time we choose a sound *</summary>
        public unsafe int NumRandomUsed {
            get {return SoundNodeRandom_ptr->NumRandomUsed;}
            set {SoundNodeRandom_ptr->NumRandomUsed = value;}
        }
         //TODO: array not UObject TArray PIEHiddenNodes
        static SoundNodeRandom() {
            StaticClass = Main.GetClass("SoundNodeRandom");
        }
        internal unsafe SoundNodeRandom_fields* SoundNodeRandom_ptr => (SoundNodeRandom_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeRandom(IntPtr p) => UObject.Make<SoundNodeRandom>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeRandom DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeRandom New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

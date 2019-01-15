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
    ///<summary>
    ///SoundNodeDistanceCrossFade
    ///This node's purpose is to play different sounds based on the distance to the listener.
    ///</summary>
    ///<remarks>
    ///The node mixes between the N different sounds which are valid for the distance.  One should
    ///think of a SoundNodeDistanceCrossFade as Mixer node which determines the set of nodes to
    ///"mix in" based on their distance to the sound.
    ///
    ///Example:
    ///You have a gun that plays a fire sound.  At long distances you want a different sound than
    ///if you were up close.   So you use a SoundNodeDistanceCrossFade which will calculate the distance
    ///a listener is from the sound and play either:  short distance, long distance, mix of short and long sounds.
    ///
    ///A SoundNodeDistanceCrossFade differs from an SoundNodeAttenuation in that any sound is only going
    ///be played if it is within the MinRadius and MaxRadius.  So if you want the short distance sound to be
    ///heard by people close to it, the MinRadius should probably be 0
    ///
    ///The volume curve for a SoundNodeDistanceCrossFade will look like this:
    ///
    ///                         Volume (of the input)
    ///   FadeInDistance.Max --> _________________ <-- FadeOutDistance.Min
    ///                         /                 \
    ///                        /                   \
    ///                       /                     \
    ///FadeInDistance.Min -->/                       \ <-- FadeOutDistance.Max
    ///</remarks>
    public unsafe partial class SoundNodeDistanceCrossFade : SoundNode  {
         //TODO: array not UObject TArray CrossFadeInput
        static SoundNodeDistanceCrossFade() {
            StaticClass = Main.GetClass("SoundNodeDistanceCrossFade");
        }
        internal unsafe SoundNodeDistanceCrossFade_fields* SoundNodeDistanceCrossFade_ptr => (SoundNodeDistanceCrossFade_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeDistanceCrossFade(IntPtr p) => UObject.Make<SoundNodeDistanceCrossFade>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeDistanceCrossFade DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeDistanceCrossFade New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

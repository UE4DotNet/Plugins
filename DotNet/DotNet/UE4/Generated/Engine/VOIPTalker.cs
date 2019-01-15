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
    ///<summary>VOIPTalker</summary>
    public unsafe partial class VOIPTalker : ActorComponent  {

        ///<summary>Blueprint native event for when this player starts speaking.</summary>
        public event BPOnTalkingBegin_delegate BPOnTalkingBegin;
        public delegate void BPOnTalkingBegin_delegate(AudioComponent AudioComponent);
        internal void on_BPOnTalkingBegin(AudioComponent AudioComponent) =>
            BPOnTalkingBegin?.Invoke(AudioComponent);


        ///<summary>Blueprint native event for when this player stops speaking.</summary>
        public event BPOnTalkingEnd_delegate BPOnTalkingEnd;
        public delegate void BPOnTalkingEnd_delegate();
        internal void on_BPOnTalkingEnd() =>
            BPOnTalkingEnd?.Invoke();


        ///<summary>function for creating and registering a UVOIPTalker.</summary>
        public static VOIPTalker CreateTalkerForPlayer(PlayerState OwningState)  => 
            VOIPTalker_methods.CreateTalkerForPlayer_method.Invoke(OwningState);

        ///<summary>Get the current level of how loud this player is speaking.</summary>
        ///<remarks>
        ///Will return 0.0
        ///if player is not talking.
        ///</remarks>
        public float GetVoiceLevel()  => 
            VOIPTalker_methods.GetVoiceLevel_method.Invoke(ObjPointer);

        ///<summary>This function sets up this talker with a specific player.</summary>
        ///<remarks>
        ///It is necessary to use this to properly control a specific player's voice
        ///and receive events.
        ///</remarks>
        public void RegisterWithPlayerState(PlayerState OwningState)  => 
            VOIPTalker_methods.RegisterWithPlayerState_method.Invoke(ObjPointer, OwningState);
        ///<summary>Configurable settings for this player's voice. When set, this will update the next time the player speaks.</summary>
        public unsafe VoiceSettings Settings {
            get {return VOIPTalker_ptr->Settings;}
            set {VOIPTalker_ptr->Settings = value;}
        }
        static VOIPTalker() {
            StaticClass = Main.GetClass("VOIPTalker");
            VOIPTalker_events.BPOnTalkingBegin_event.Setup();
            VOIPTalker_events.BPOnTalkingEnd_event.Setup();
        }
        internal unsafe VOIPTalker_fields* VOIPTalker_ptr => (VOIPTalker_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VOIPTalker(IntPtr p) => UObject.Make<VOIPTalker>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VOIPTalker DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VOIPTalker New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

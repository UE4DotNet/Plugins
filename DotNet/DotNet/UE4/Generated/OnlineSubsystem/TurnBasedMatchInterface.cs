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
using UE4.OnlineSubsystem.Native;

namespace UE4.OnlineSubsystem {
    ///<summary>Turn Based Match Interface</summary>
    public unsafe partial class TurnBasedMatchInterface : Interface  {

        ///<summary>On Match Ended</summary>
        public event OnMatchEnded_delegate OnMatchEnded;
        public delegate void OnMatchEnded_delegate(string Match);
        internal void on_OnMatchEnded(string Match) =>
            OnMatchEnded?.Invoke(Match);


        ///<summary>On Match Received Turn</summary>
        public event OnMatchReceivedTurn_delegate OnMatchReceivedTurn;
        public delegate void OnMatchReceivedTurn_delegate(string Match, bool bDidBecomeActive);
        internal void on_OnMatchReceivedTurn(string Match, bool bDidBecomeActive) =>
            OnMatchReceivedTurn?.Invoke(Match, bDidBecomeActive);

        static TurnBasedMatchInterface() {
            StaticClass = Main.GetClass("TurnBasedMatchInterface");
            TurnBasedMatchInterface_events.OnMatchEnded_event.Setup();
            TurnBasedMatchInterface_events.OnMatchReceivedTurn_event.Setup();
        }
        internal unsafe TurnBasedMatchInterface_fields* TurnBasedMatchInterface_ptr => (TurnBasedMatchInterface_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TurnBasedMatchInterface(IntPtr p) => UObject.Make<TurnBasedMatchInterface>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TurnBasedMatchInterface DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TurnBasedMatchInterface New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

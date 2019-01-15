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
    ///<summary>Engine Message</summary>
    public unsafe partial class EngineMessage : LocalMessage  {
         //TODO: string FString FailedPlaceMessage
         //TODO: string FString MaxedOutMessage
         //TODO: string FString EnteredMessage
         //TODO: string FString LeftMessage
         //TODO: string FString GlobalNameChange
         //TODO: string FString SpecEnteredMessage
         //TODO: string FString NewPlayerMessage
         //TODO: string FString NewSpecMessage
        static EngineMessage() {
            StaticClass = Main.GetClass("EngineMessage");
        }
        internal unsafe EngineMessage_fields* EngineMessage_ptr => (EngineMessage_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EngineMessage(IntPtr p) => UObject.Make<EngineMessage>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EngineMessage DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EngineMessage New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

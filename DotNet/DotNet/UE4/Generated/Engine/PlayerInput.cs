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
    ///<summary>Object within PlayerController that processes player input.</summary>
    ///<remarks>
    ///Only exists on the client in network games.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Gameplay/Input/index.html
    ///</remarks>
    public unsafe partial class PlayerInput : UObject  {
         //TODO: array not UObject TArray DebugExecBindings
         //TODO: array not UObject TArray InvertedAxis
        static PlayerInput() {
            StaticClass = Main.GetClass("PlayerInput");
        }
        internal unsafe PlayerInput_fields* PlayerInput_ptr => (PlayerInput_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PlayerInput(IntPtr p) => UObject.Make<PlayerInput>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PlayerInput DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PlayerInput New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///Interface class between engine and OnlineSubsystem to remove dependencies between the two
    ///The real work is implemented in UOnlineEngineInterfaceImpl in OnlineSubsystemUtils
    ///The expectation is that this basic group of functions will not expand/change and that
    ///OnlineSubsystem can remain independent of the engine
    ///Games should not use this interface, use the OnlineSubsystem plugins directly
    ///Better functionality descriptions can be found in the OnlineSubsystem interfaces
    ///</summary>
    ///<remarks>Adding code here is discouraged, there is probably a better way, talk to the OGS team</remarks>
    public unsafe partial class OnlineEngineInterface : UObject  {
        static OnlineEngineInterface() {
            StaticClass = Main.GetClass("OnlineEngineInterface");
        }
        internal unsafe OnlineEngineInterface_fields* OnlineEngineInterface_ptr => (OnlineEngineInterface_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator OnlineEngineInterface(IntPtr p) => UObject.Make<OnlineEngineInterface>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static OnlineEngineInterface DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static OnlineEngineInterface New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

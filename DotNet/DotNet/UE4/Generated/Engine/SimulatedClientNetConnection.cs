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
    ///<summary>A fake connection that will absorb traffic and auto ack every packet. Useful for testing scaling. Use net.SimulateConnections command to add at runtime.</summary>
    public unsafe partial class SimulatedClientNetConnection : NetConnection  {
        static SimulatedClientNetConnection() {
            StaticClass = Main.GetClass("SimulatedClientNetConnection");
        }
        internal unsafe SimulatedClientNetConnection_fields* SimulatedClientNetConnection_ptr => (SimulatedClientNetConnection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SimulatedClientNetConnection(IntPtr p) => UObject.Make<SimulatedClientNetConnection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SimulatedClientNetConnection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SimulatedClientNetConnection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

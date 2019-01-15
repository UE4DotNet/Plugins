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
using UE4.NetcodeUnitTest.Native;

namespace UE4.NetcodeUnitTest {
    ///<summary>
    ///Base class for implementing a barebones/stripped-down game client, capable of connecting to a regular game server,
    ///but stripped/locked-down so that the absolute minimum of client/server netcode functionality is executed, for connecting the client.
    ///</summary>
    public unsafe partial class MinimalClient : UObject  {
        static MinimalClient() {
            StaticClass = Main.GetClass("MinimalClient");
        }
        internal unsafe MinimalClient_fields* MinimalClient_ptr => (MinimalClient_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MinimalClient(IntPtr p) => UObject.Make<MinimalClient>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MinimalClient DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MinimalClient New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

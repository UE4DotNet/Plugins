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
using UE4.HTML5Networking.Native;
using UE4.Engine;

namespace UE4.HTML5Networking {
    ///<summary>Web Socket Net Driver</summary>
    public unsafe partial class WebSocketNetDriver : NetDriver  {
        ///<summary>Websocket server port</summary>
        public unsafe int WebSocketPort {
            get {return WebSocketNetDriver_ptr->WebSocketPort;}
            set {WebSocketNetDriver_ptr->WebSocketPort = value;}
        }
        static WebSocketNetDriver() {
            StaticClass = Main.GetClass("WebSocketNetDriver");
        }
        internal unsafe WebSocketNetDriver_fields* WebSocketNetDriver_ptr => (WebSocketNetDriver_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WebSocketNetDriver(IntPtr p) => UObject.Make<WebSocketNetDriver>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WebSocketNetDriver DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WebSocketNetDriver New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

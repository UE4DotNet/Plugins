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
using UE4.PacketHandler;

namespace UE4.Engine {
    ///<summary>Factory class for loading HandlerComponent's contained within Engine</summary>
    public unsafe partial class EngineHandlerComponentFactory : HandlerComponentFactory  {
        static EngineHandlerComponentFactory() {
            StaticClass = Main.GetClass("EngineHandlerComponentFactory");
        }
        internal unsafe EngineHandlerComponentFactory_fields* EngineHandlerComponentFactory_ptr => (EngineHandlerComponentFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EngineHandlerComponentFactory(IntPtr p) => UObject.Make<EngineHandlerComponentFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EngineHandlerComponentFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EngineHandlerComponentFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

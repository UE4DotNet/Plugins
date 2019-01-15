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
using UE4.PacketHandler.Native;

namespace UE4.PacketHandler {
    ///<summary>A UObject alternative for loading HandlerComponents without strict module dependency</summary>
    public unsafe partial class HandlerComponentFactory : UObject  {
        static HandlerComponentFactory() {
            StaticClass = Main.GetClass("HandlerComponentFactory");
        }
        internal unsafe HandlerComponentFactory_fields* HandlerComponentFactory_ptr => (HandlerComponentFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator HandlerComponentFactory(IntPtr p) => UObject.Make<HandlerComponentFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static HandlerComponentFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static HandlerComponentFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

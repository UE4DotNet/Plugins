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
using UE4.DotNet.Native;

namespace UE4.DotNet {
    ///<summary>Dot Net Config</summary>
    public unsafe partial class DotNetConfig : UObject  {
         //TODO: string FString DLLGameFileName
         //TODO: string FString GameInstanceClass
         //TODO: string FString Argument
        static DotNetConfig() {
            StaticClass = Main.GetClass("DotNetConfig");
        }
        internal unsafe DotNetConfig_fields* DotNetConfig_ptr => (DotNetConfig_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DotNetConfig(IntPtr p) => UObject.Make<DotNetConfig>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DotNetConfig DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DotNetConfig New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

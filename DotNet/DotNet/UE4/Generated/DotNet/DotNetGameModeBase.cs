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
using UE4.Engine;

namespace UE4.DotNet {
    ///<summary>Dot Net Game Mode Base</summary>
    public unsafe partial class DotNetGameModeBase : GameModeBase  {
        static DotNetGameModeBase() {
            StaticClass = Main.GetClass("DotNetGameModeBase");
        }
        internal unsafe DotNetGameModeBase_fields* DotNetGameModeBase_ptr => (DotNetGameModeBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DotNetGameModeBase(IntPtr p) => UObject.Make<DotNetGameModeBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DotNetGameModeBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DotNetGameModeBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

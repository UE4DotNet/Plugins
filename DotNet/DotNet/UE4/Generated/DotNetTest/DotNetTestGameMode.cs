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
using UE4.DotNetTest.Native;
using UE4.Engine;

namespace UE4.DotNetTest {
    ///<summary>Dot Net Test Game Mode</summary>
    public unsafe partial class DotNetTestGameMode : GameModeBase  {
        static DotNetTestGameMode() {
            StaticClass = Main.GetClass("DotNetTestGameMode");
        }
        internal unsafe DotNetTestGameMode_fields* DotNetTestGameMode_ptr => (DotNetTestGameMode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DotNetTestGameMode(IntPtr p) => UObject.Make<DotNetTestGameMode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DotNetTestGameMode DefaultObject => Main.GetDefaultObject(StaticClass);
    }
}

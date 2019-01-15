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
using UE4.DmgTypeBP_Environmental.Native;
using UE4.Engine;

namespace UE4.DmgTypeBP_Environmental {
    ///<summary>Dmg Type BP Environmental</summary>
    public unsafe partial class DmgTypeBP_Environmental_C : DamageType  {
        static DmgTypeBP_Environmental_C() {
            StaticClass = Main.GetClass("DmgTypeBP_Environmental_C");
        }
        internal unsafe DmgTypeBP_Environmental_C_fields* DmgTypeBP_Environmental_C_ptr => (DmgTypeBP_Environmental_C_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DmgTypeBP_Environmental_C(IntPtr p) => UObject.Make<DmgTypeBP_Environmental_C>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DmgTypeBP_Environmental_C DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DmgTypeBP_Environmental_C New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

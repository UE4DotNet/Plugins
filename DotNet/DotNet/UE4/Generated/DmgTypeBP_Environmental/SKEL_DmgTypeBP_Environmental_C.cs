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
    public unsafe partial class SKEL_DmgTypeBP_Environmental_C : DamageType  {
        ///<summary>Uber Graph Frame</summary>
        public unsafe PointerToUberGraphFrame UberGraphFrame {
            get {return SKEL_DmgTypeBP_Environmental_C_ptr->UberGraphFrame;}
            set {SKEL_DmgTypeBP_Environmental_C_ptr->UberGraphFrame = value;}
        }
        static SKEL_DmgTypeBP_Environmental_C() {
            StaticClass = Main.GetClass("SKEL_DmgTypeBP_Environmental_C");
        }
        internal unsafe SKEL_DmgTypeBP_Environmental_C_fields* SKEL_DmgTypeBP_Environmental_C_ptr => (SKEL_DmgTypeBP_Environmental_C_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SKEL_DmgTypeBP_Environmental_C(IntPtr p) => UObject.Make<SKEL_DmgTypeBP_Environmental_C>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SKEL_DmgTypeBP_Environmental_C DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SKEL_DmgTypeBP_Environmental_C New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

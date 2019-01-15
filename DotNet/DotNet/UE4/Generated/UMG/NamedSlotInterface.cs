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
using UE4.UMG.Native;

namespace UE4.UMG {
    ///<summary>Named Slot Interface</summary>
    public unsafe partial class NamedSlotInterface : Interface  {
        static NamedSlotInterface() {
            StaticClass = Main.GetClass("NamedSlotInterface");
        }
        internal unsafe NamedSlotInterface_fields* NamedSlotInterface_ptr => (NamedSlotInterface_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NamedSlotInterface(IntPtr p) => UObject.Make<NamedSlotInterface>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NamedSlotInterface DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NamedSlotInterface New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

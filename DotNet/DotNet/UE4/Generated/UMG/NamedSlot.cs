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
    ///<summary>Allows you to expose an external slot for your user widget.</summary>
    ///<remarks>
    ///When others reuse your user control,
    ///they can put whatever they want in this named slot.
    ///</remarks>
    public unsafe partial class NamedSlot : ContentWidget  {
        static NamedSlot() {
            StaticClass = Main.GetClass("NamedSlot");
        }
        internal unsafe NamedSlot_fields* NamedSlot_ptr => (NamedSlot_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NamedSlot(IntPtr p) => UObject.Make<NamedSlot>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NamedSlot DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NamedSlot New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

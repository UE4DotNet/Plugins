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

namespace UE4.Engine {
    ///<summary>Bone Mask Filter</summary>
    public unsafe partial class BoneMaskFilter : UObject  {
         //TODO: array not UObject TArray BlendPoses
        static BoneMaskFilter() {
            StaticClass = Main.GetClass("BoneMaskFilter");
        }
        internal unsafe BoneMaskFilter_fields* BoneMaskFilter_ptr => (BoneMaskFilter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BoneMaskFilter(IntPtr p) => UObject.Make<BoneMaskFilter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BoneMaskFilter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BoneMaskFilter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

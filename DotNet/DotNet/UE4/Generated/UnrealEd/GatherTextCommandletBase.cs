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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>UGatherTextCommandletBase: Base class for localization commandlets. Just to force certain behaviors and provide helper functionality.</summary>
    public unsafe partial class GatherTextCommandletBase : Commandlet  {
        static GatherTextCommandletBase() {
            StaticClass = Main.GetClass("GatherTextCommandletBase");
        }
        internal unsafe GatherTextCommandletBase_fields* GatherTextCommandletBase_ptr => (GatherTextCommandletBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GatherTextCommandletBase(IntPtr p) => UObject.Make<GatherTextCommandletBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GatherTextCommandletBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GatherTextCommandletBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

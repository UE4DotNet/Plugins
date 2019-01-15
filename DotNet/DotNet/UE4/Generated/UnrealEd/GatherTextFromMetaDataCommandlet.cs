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

namespace UE4.UnrealEd {
    ///<summary>UGatherTextFromMetaDataCommandlet: Localization commandlet that collects all text to be localized from generated metadata.</summary>
    public unsafe partial class GatherTextFromMetaDataCommandlet : GatherTextCommandletBase  {
        static GatherTextFromMetaDataCommandlet() {
            StaticClass = Main.GetClass("GatherTextFromMetaDataCommandlet");
        }
        internal unsafe GatherTextFromMetaDataCommandlet_fields* GatherTextFromMetaDataCommandlet_ptr => (GatherTextFromMetaDataCommandlet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GatherTextFromMetaDataCommandlet(IntPtr p) => UObject.Make<GatherTextFromMetaDataCommandlet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GatherTextFromMetaDataCommandlet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GatherTextFromMetaDataCommandlet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>UInternationalizationExportCommandlet: Commandlet used to export internationalization data to various standard formats.</summary>
    public unsafe partial class InternationalizationExportCommandlet : GatherTextCommandletBase  {
        static InternationalizationExportCommandlet() {
            StaticClass = Main.GetClass("InternationalizationExportCommandlet");
        }
        internal unsafe InternationalizationExportCommandlet_fields* InternationalizationExportCommandlet_ptr => (InternationalizationExportCommandlet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InternationalizationExportCommandlet(IntPtr p) => UObject.Make<InternationalizationExportCommandlet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InternationalizationExportCommandlet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InternationalizationExportCommandlet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

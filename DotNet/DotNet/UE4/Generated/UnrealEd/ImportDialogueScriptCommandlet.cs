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
    ///<summary>UImportDialogueScriptCommandlet: Handles importing localized script sheets to update the translated archive text.</summary>
    public unsafe partial class ImportDialogueScriptCommandlet : GatherTextCommandletBase  {
        static ImportDialogueScriptCommandlet() {
            StaticClass = Main.GetClass("ImportDialogueScriptCommandlet");
        }
        internal unsafe ImportDialogueScriptCommandlet_fields* ImportDialogueScriptCommandlet_ptr => (ImportDialogueScriptCommandlet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ImportDialogueScriptCommandlet(IntPtr p) => UObject.Make<ImportDialogueScriptCommandlet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ImportDialogueScriptCommandlet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ImportDialogueScriptCommandlet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

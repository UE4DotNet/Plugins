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
    ///<summary>Editor World Extension</summary>
    public unsafe partial class EditorWorldExtension : UObject  {
         //TODO: array not UObject TArray ExtensionActors
        static EditorWorldExtension() {
            StaticClass = Main.GetClass("EditorWorldExtension");
        }
        internal unsafe EditorWorldExtension_fields* EditorWorldExtension_ptr => (EditorWorldExtension_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditorWorldExtension(IntPtr p) => UObject.Make<EditorWorldExtension>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditorWorldExtension DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditorWorldExtension New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

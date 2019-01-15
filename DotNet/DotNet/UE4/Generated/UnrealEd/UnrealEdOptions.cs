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
    ///<summary>Unreal Ed Options</summary>
    public unsafe partial class UnrealEdOptions : UObject  {
         //TODO: array not UObject TArray EditorCategories
         //TODO: array not UObject TArray EditorCommands
        ///<summary>Pointer to the key bindings object that actually stores key bindings for the editor.</summary>
        public unsafe UnrealEdKeyBindings EditorKeyBindings {
            get {return UnrealEdOptions_ptr->EditorKeyBindings;}
            set {UnrealEdOptions_ptr->EditorKeyBindings = value;}
        }
        public bool bExpandClassPickerClassList {
            get {return Main.GetGetBoolPropertyByName(this, "bExpandClassPickerClassList"); }
            set {Main.SetGetBoolPropertyByName(this, "bExpandClassPickerClassList", value); }
        }
         //TODO: array not UObject TArray NewAssetDefaultClasses
        static UnrealEdOptions() {
            StaticClass = Main.GetClass("UnrealEdOptions");
        }
        internal unsafe UnrealEdOptions_fields* UnrealEdOptions_ptr => (UnrealEdOptions_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UnrealEdOptions(IntPtr p) => UObject.Make<UnrealEdOptions>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UnrealEdOptions DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UnrealEdOptions New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

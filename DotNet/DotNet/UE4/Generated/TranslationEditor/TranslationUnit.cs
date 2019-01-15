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
using UE4.TranslationEditor.Native;

namespace UE4.TranslationEditor {
    ///<summary>Translation Unit</summary>
    public unsafe partial class TranslationUnit : UObject  {
         //TODO: string FString Namespace
         //TODO: string FString Key
         //TODO: string FString Source
         //TODO: string FString Translation
         //TODO: array not UObject TArray Contexts
        public bool HasBeenReviewed {
            get {return Main.GetGetBoolPropertyByName(this, "HasBeenReviewed"); }
            set {Main.SetGetBoolPropertyByName(this, "HasBeenReviewed", value); }
        }
         //TODO: string FString TranslationBeforeImport
         //TODO: string FString LocresPath
        static TranslationUnit() {
            StaticClass = Main.GetClass("TranslationUnit");
        }
        internal unsafe TranslationUnit_fields* TranslationUnit_ptr => (TranslationUnit_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TranslationUnit(IntPtr p) => UObject.Make<TranslationUnit>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TranslationUnit DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TranslationUnit New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

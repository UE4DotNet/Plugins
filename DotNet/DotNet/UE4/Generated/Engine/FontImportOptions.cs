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
    ///<summary>Holds options for importing fonts.</summary>
    public unsafe partial class FontImportOptions : UObject  {
        ///<summary>The actual data for this object.  We wrap it in a struct so that we can copy it around between objects.</summary>
        public unsafe FontImportOptionsData Data {
            get {return FontImportOptions_ptr->Data;}
            set {FontImportOptions_ptr->Data = value;}
        }
        static FontImportOptions() {
            StaticClass = Main.GetClass("FontImportOptions");
        }
        internal unsafe FontImportOptions_fields* FontImportOptions_ptr => (FontImportOptions_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FontImportOptions(IntPtr p) => UObject.Make<FontImportOptions>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FontImportOptions DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FontImportOptions New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>True Type Font Factory</summary>
    public unsafe partial class TrueTypeFontFactory : TextureFactory  {
        ///<summary>Import options for the font</summary>
        public unsafe FontImportOptions ImportOptions {
            get {return TrueTypeFontFactory_ptr->ImportOptions;}
            set {TrueTypeFontFactory_ptr->ImportOptions = value;}
        }
        public bool bPropertiesConfigured {
            get {return Main.GetGetBoolPropertyByName(this, "bPropertiesConfigured"); }
            set {Main.SetGetBoolPropertyByName(this, "bPropertiesConfigured", value); }
        }
        public bool bFontSelected {
            get {return Main.GetGetBoolPropertyByName(this, "bFontSelected"); }
            set {Main.SetGetBoolPropertyByName(this, "bFontSelected", value); }
        }
        static TrueTypeFontFactory() {
            StaticClass = Main.GetClass("TrueTypeFontFactory");
        }
        internal unsafe TrueTypeFontFactory_fields* TrueTypeFontFactory_ptr => (TrueTypeFontFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TrueTypeFontFactory(IntPtr p) => UObject.Make<TrueTypeFontFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TrueTypeFontFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TrueTypeFontFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

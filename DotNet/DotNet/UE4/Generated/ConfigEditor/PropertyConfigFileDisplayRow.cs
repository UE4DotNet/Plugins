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
using UE4.ConfigEditor.Native;

namespace UE4.ConfigEditor {
    ///<summary>Property Config File Display Row</summary>
    public unsafe partial class PropertyConfigFileDisplayRow : UObject  {
         //TODO: string FString ConfigFileName
        ///<summary>External Property</summary>
        public unsafe Property ExternalProperty {
            get {return PropertyConfigFileDisplayRow_ptr->ExternalProperty;}
            set {PropertyConfigFileDisplayRow_ptr->ExternalProperty = value;}
        }
        public bool bIsFileWritable {
            get {return Main.GetGetBoolPropertyByName(this, "bIsFileWritable"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsFileWritable", value); }
        }
        static PropertyConfigFileDisplayRow() {
            StaticClass = Main.GetClass("PropertyConfigFileDisplayRow");
        }
        internal unsafe PropertyConfigFileDisplayRow_fields* PropertyConfigFileDisplayRow_ptr => (PropertyConfigFileDisplayRow_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PropertyConfigFileDisplayRow(IntPtr p) => UObject.Make<PropertyConfigFileDisplayRow>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PropertyConfigFileDisplayRow DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PropertyConfigFileDisplayRow New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>DEditor Parameter Value</summary>
    public unsafe partial class DEditorParameterValue : UObject  {
        public bool bOverride {
            get {return Main.GetGetBoolPropertyByName(this, "bOverride"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverride", value); }
        }
        ///<summary>Parameter Info</summary>
        public unsafe MaterialParameterInfo ParameterInfo {
            get {return DEditorParameterValue_ptr->ParameterInfo;}
            set {DEditorParameterValue_ptr->ParameterInfo = value;}
        }
        ///<summary>Expression Id</summary>
        public unsafe FGuid ExpressionId {
            get {return DEditorParameterValue_ptr->ExpressionId;}
            set {DEditorParameterValue_ptr->ExpressionId = value;}
        }
        ///<summary>Controls where this parameter is displayed in a material instance parameter list.  The lower the number the higher up in the parameter list.</summary>
        public unsafe int SortPriority {
            get {return DEditorParameterValue_ptr->SortPriority;}
            set {DEditorParameterValue_ptr->SortPriority = value;}
        }
        static DEditorParameterValue() {
            StaticClass = Main.GetClass("DEditorParameterValue");
        }
        internal unsafe DEditorParameterValue_fields* DEditorParameterValue_ptr => (DEditorParameterValue_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DEditorParameterValue(IntPtr p) => UObject.Make<DEditorParameterValue>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DEditorParameterValue DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DEditorParameterValue New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

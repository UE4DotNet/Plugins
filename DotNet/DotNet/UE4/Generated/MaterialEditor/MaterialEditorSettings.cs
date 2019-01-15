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
using UE4.MaterialEditor.Native;
using UE4.Engine;

namespace UE4.MaterialEditor {
    ///<summary>Material Editor Settings</summary>
    public unsafe partial class MaterialEditorSettings : UObject  {
        ///<summary>Path to user installed Mali shader compiler that can be used by the material editor to compile and extract shader informations for Android platforms.</summary>
        ///<remarks>Official website address: https://developer.arm.com/products/software-development-tools/graphics-development-tools/mali-offline-compiler/downloads</remarks>
        public unsafe FilePath MaliOfflineCompilerPath {
            get {return MaterialEditorSettings_ptr->MaliOfflineCompilerPath;}
            set {MaterialEditorSettings_ptr->MaliOfflineCompilerPath = value;}
        }
        static MaterialEditorSettings() {
            StaticClass = Main.GetClass("MaterialEditorSettings");
        }
        internal unsafe MaterialEditorSettings_fields* MaterialEditorSettings_ptr => (MaterialEditorSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialEditorSettings(IntPtr p) => UObject.Make<MaterialEditorSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialEditorSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialEditorSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
using UE4.OculusEditor.Native;

namespace UE4.OculusEditor {
    ///<summary>Oculus Editor Settings</summary>
    public unsafe partial class OculusEditorSettings : UObject  {
         //TODO: map TMap PerfToolIgnoreList
         //TODO: enum EOculusPlatform PerfToolTargetPlatform
        static OculusEditorSettings() {
            StaticClass = Main.GetClass("OculusEditorSettings");
        }
        internal unsafe OculusEditorSettings_fields* OculusEditorSettings_ptr => (OculusEditorSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator OculusEditorSettings(IntPtr p) => UObject.Make<OculusEditorSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static OculusEditorSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static OculusEditorSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

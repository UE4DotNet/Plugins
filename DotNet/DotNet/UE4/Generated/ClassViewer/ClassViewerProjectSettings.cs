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
using UE4.ClassViewer.Native;

namespace UE4.ClassViewer {
    ///<summary>Implements the settings for the Class Viewer Project Settings</summary>
    public unsafe partial class ClassViewerProjectSettings : UObject  {
         //TODO: array not UObject TArray InternalOnlyPaths
         //TODO: array not UObject TArray InternalOnlyClasses
        static ClassViewerProjectSettings() {
            StaticClass = Main.GetClass("ClassViewerProjectSettings");
        }
        internal unsafe ClassViewerProjectSettings_fields* ClassViewerProjectSettings_ptr => (ClassViewerProjectSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ClassViewerProjectSettings(IntPtr p) => UObject.Make<ClassViewerProjectSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ClassViewerProjectSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ClassViewerProjectSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

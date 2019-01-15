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
using UE4.VREditor.Native;
using UE4.ViewportInteraction;

namespace UE4.VREditor {
    ///<summary>VREditor default interactor</summary>
    public unsafe partial class VREditorInteractor : ViewportInteractor  {
        ///<summary>The mode that owns this interactor</summary>
        public unsafe VREditorMode VRMode {
            get {return VREditorInteractor_ptr->VRMode;}
            set {VREditorInteractor_ptr->VRMode = value;}
        }
        static VREditorInteractor() {
            StaticClass = Main.GetClass("VREditorInteractor");
        }
        internal unsafe VREditorInteractor_fields* VREditorInteractor_ptr => (VREditorInteractor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VREditorInteractor(IntPtr p) => UObject.Make<VREditorInteractor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VREditorInteractor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VREditorInteractor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

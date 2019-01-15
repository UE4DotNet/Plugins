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

namespace UE4.VREditor {
    ///<summary>Automatically scales the user when dragging the world and pressing the touchpad</summary>
    public unsafe partial class VREditorAutoScaler : UObject  {
        ///<summary>Owning mode</summary>
        public unsafe VREditorMode VRMode {
            get {return VREditorAutoScaler_ptr->VRMode;}
            set {VREditorAutoScaler_ptr->VRMode = value;}
        }
        static VREditorAutoScaler() {
            StaticClass = Main.GetClass("VREditorAutoScaler");
        }
        internal unsafe VREditorAutoScaler_fields* VREditorAutoScaler_ptr => (VREditorAutoScaler_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VREditorAutoScaler(IntPtr p) => UObject.Make<VREditorAutoScaler>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VREditorAutoScaler DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VREditorAutoScaler New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

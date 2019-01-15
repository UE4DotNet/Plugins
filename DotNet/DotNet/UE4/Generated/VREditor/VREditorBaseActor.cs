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
using UE4.Engine;

namespace UE4.VREditor {
    ///<summary>Represents an actor specifically for VR Editor that has roomspace transformation</summary>
    public unsafe partial class VREditorBaseActor : Actor  {
        ///<summary>The VR mode that owns this actor</summary>
        public unsafe VREditorMode VRMode {
            get {return VREditorBaseActor_ptr->VRMode;}
            set {VREditorBaseActor_ptr->VRMode = value;}
        }
        static VREditorBaseActor() {
            StaticClass = Main.GetClass("VREditorBaseActor");
        }
        internal unsafe VREditorBaseActor_fields* VREditorBaseActor_ptr => (VREditorBaseActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VREditorBaseActor(IntPtr p) => UObject.Make<VREditorBaseActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VREditorBaseActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VREditorBaseActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

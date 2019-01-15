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
    ///<summary>Represents an interactive floating UI panel in the VR Editor</summary>
    public unsafe partial class VREditorFloatingUI : VREditorBaseActor  {
        ///<summary>UMG user widget we're drawing, or nullptr if we're drawing a Slate widget</summary>
        public unsafe VREditorBaseUserWidget UserWidget {
            get {return VREditorFloatingUI_ptr->UserWidget;}
            set {VREditorFloatingUI_ptr->UserWidget = value;}
        }
        ///<summary>When in a spawned state, this is the widget component to represent the widget</summary>
        public unsafe VREditorWidgetComponent WidgetComponent {
            get {return VREditorFloatingUI_ptr->WidgetComponent;}
            set {VREditorFloatingUI_ptr->WidgetComponent = value;}
        }
        ///<summary>The floating window mesh</summary>
        public unsafe StaticMeshComponent WindowMeshComponent {
            get {return VREditorFloatingUI_ptr->WindowMeshComponent;}
            set {VREditorFloatingUI_ptr->WindowMeshComponent = value;}
        }
        ///<summary>Class of the UMG widget we're spawning</summary>
        public unsafe SubclassOf<UObject> UserWidgetClass {
            get {return VREditorFloatingUI_ptr->UserWidgetClass;}
            set {VREditorFloatingUI_ptr->UserWidgetClass = value;}
        }
        static VREditorFloatingUI() {
            StaticClass = Main.GetClass("VREditorFloatingUI");
        }
        internal unsafe VREditorFloatingUI_fields* VREditorFloatingUI_ptr => (VREditorFloatingUI_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VREditorFloatingUI(IntPtr p) => UObject.Make<VREditorFloatingUI>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VREditorFloatingUI DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VREditorFloatingUI New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

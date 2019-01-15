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
    public unsafe partial class VREditorRadialFloatingUI : VREditorBaseActor  {
        ///<summary>When in a spawned state, this is the widget component to represent the widget</summary>
        public ObjectArrayField<VREditorWidgetComponent> WidgetComponents{ get {
            if(WidgetComponents_store == null) WidgetComponents_store = new ObjectArrayField<VREditorWidgetComponent> (&VREditorRadialFloatingUI_ptr->WidgetComponents);
            return WidgetComponents_store;
        } }
        private ObjectArrayField<VREditorWidgetComponent> WidgetComponents_store;

        ///<summary>The floating window mesh</summary>
        public unsafe StaticMeshComponent WindowMeshComponent {
            get {return VREditorRadialFloatingUI_ptr->WindowMeshComponent;}
            set {VREditorRadialFloatingUI_ptr->WindowMeshComponent = value;}
        }
        ///<summary>The arrow indicator mesh</summary>
        public unsafe StaticMeshComponent ArrowMeshComponent {
            get {return VREditorRadialFloatingUI_ptr->ArrowMeshComponent;}
            set {VREditorRadialFloatingUI_ptr->ArrowMeshComponent = value;}
        }
        ///<summary>The central helper widget</summary>
        public unsafe VREditorWidgetComponent CentralWidgetComponent {
            get {return VREditorRadialFloatingUI_ptr->CentralWidgetComponent;}
            set {VREditorRadialFloatingUI_ptr->CentralWidgetComponent = value;}
        }
        static VREditorRadialFloatingUI() {
            StaticClass = Main.GetClass("VREditorRadialFloatingUI");
        }
        internal unsafe VREditorRadialFloatingUI_fields* VREditorRadialFloatingUI_ptr => (VREditorRadialFloatingUI_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VREditorRadialFloatingUI(IntPtr p) => UObject.Make<VREditorRadialFloatingUI>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VREditorRadialFloatingUI DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VREditorRadialFloatingUI New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

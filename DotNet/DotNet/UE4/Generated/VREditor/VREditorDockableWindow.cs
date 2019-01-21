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
using UE4.ViewportInteraction;

namespace UE4.VREditor {
    ///<summary>An interactive floating UI panel that can be dragged around</summary>
    public unsafe partial class VREditorDockableWindow : VREditorFloatingUI  {
        ///<summary>Mesh underneath the window for docking it to the world</summary>
        public unsafe StaticMeshComponent DockButtonMeshComponent {
            get {return VREditorDockableWindow_ptr->DockButtonMeshComponent;}
            set {VREditorDockableWindow_ptr->DockButtonMeshComponent = value;}
        }
        ///<summary>Mesh underneath the window for easy selecting and dragging</summary>
        public unsafe StaticMeshComponent SelectionBarMeshComponent {
            get {return VREditorDockableWindow_ptr->SelectionBarMeshComponent;}
            set {VREditorDockableWindow_ptr->SelectionBarMeshComponent = value;}
        }
        ///<summary>Mesh that represents the close button for this UI</summary>
        public unsafe StaticMeshComponent CloseButtonMeshComponent {
            get {return VREditorDockableWindow_ptr->CloseButtonMeshComponent;}
            set {VREditorDockableWindow_ptr->CloseButtonMeshComponent = value;}
        }
        ///<summary>Dock Button dynamic material  (opaque)</summary>
        public unsafe MaterialInstanceDynamic DockButtonMID {
            get {return VREditorDockableWindow_ptr->DockButtonMID;}
            set {VREditorDockableWindow_ptr->DockButtonMID = value;}
        }
        ///<summary>Selection bar dynamic material  (opaque)</summary>
        public unsafe MaterialInstanceDynamic SelectionBarMID {
            get {return VREditorDockableWindow_ptr->SelectionBarMID;}
            set {VREditorDockableWindow_ptr->SelectionBarMID = value;}
        }
        ///<summary>Select bar dynamic material (translucent)</summary>
        public unsafe MaterialInstanceDynamic SelectionBarTranslucentMID {
            get {return VREditorDockableWindow_ptr->SelectionBarTranslucentMID;}
            set {VREditorDockableWindow_ptr->SelectionBarTranslucentMID = value;}
        }
        ///<summary>Close button dynamic material  (opaque)</summary>
        public unsafe MaterialInstanceDynamic CloseButtonMID {
            get {return VREditorDockableWindow_ptr->CloseButtonMID;}
            set {VREditorDockableWindow_ptr->CloseButtonMID = value;}
        }
        ///<summary>Close button dynamic material (translucent)</summary>
        public unsafe MaterialInstanceDynamic CloseButtonTranslucentMID {
            get {return VREditorDockableWindow_ptr->CloseButtonTranslucentMID;}
            set {VREditorDockableWindow_ptr->CloseButtonTranslucentMID = value;}
        }
        ///<summary>Drag Operation Component</summary>
        public unsafe ViewportDragOperationComponent DragOperationComponent {
            get {return VREditorDockableWindow_ptr->DragOperationComponent;}
            set {VREditorDockableWindow_ptr->DragOperationComponent = value;}
        }
        static VREditorDockableWindow() {
            StaticClass = Main.GetClass("VREditorDockableWindow");
        }
        internal unsafe VREditorDockableWindow_fields* VREditorDockableWindow_ptr => (VREditorDockableWindow_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VREditorDockableWindow(IntPtr p) => UObject.Make<VREditorDockableWindow>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VREditorDockableWindow DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VREditorDockableWindow New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

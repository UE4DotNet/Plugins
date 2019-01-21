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
    ///<summary>VR Editor user interface manager</summary>
    public unsafe partial class VREditorUISystem : UObject  {
        ///<summary>Owning object</summary>
        public unsafe VREditorMode VRMode {
            get {return VREditorUISystem_ptr->VRMode;}
            set {VREditorUISystem_ptr->VRMode = value;}
        }
         //TODO: map TMap FloatingUIs
         //TODO: map TMap PreviewWindowInfo
        ///<summary>Our Quick Menu UI</summary>
        public unsafe VREditorFloatingUI InfoDisplayPanel {
            get {return VREditorUISystem_ptr->InfoDisplayPanel;}
            set {VREditorUISystem_ptr->InfoDisplayPanel = value;}
        }
        ///<summary>The Radial Menu UI</summary>
        public unsafe VREditorRadialFloatingUI QuickRadialMenu {
            get {return VREditorUISystem_ptr->QuickRadialMenu;}
            set {VREditorUISystem_ptr->QuickRadialMenu = value;}
        }
        ///<summary>The current UI that is being dragged</summary>
        public unsafe VREditorDockableWindow DraggingUI {
            get {return VREditorUISystem_ptr->DraggingUI;}
            set {VREditorUISystem_ptr->DraggingUI = value;}
        }
        ///<summary>The color picker dockable window</summary>
        public unsafe VREditorDockableWindow ColorPickerUI {
            get {return VREditorUISystem_ptr->ColorPickerUI;}
            set {VREditorUISystem_ptr->ColorPickerUI = value;}
        }
        ///<summary>Interactor that has a laser and is generally interacting with the scene</summary>
        public unsafe VREditorMotionControllerInteractor LaserInteractor {
            get {return VREditorUISystem_ptr->LaserInteractor;}
            set {VREditorUISystem_ptr->LaserInteractor = value;}
        }
        ///<summary>Interactor that usually accesses UI and other helper functionality</summary>
        public unsafe VREditorMotionControllerInteractor UIInteractor {
            get {return VREditorUISystem_ptr->UIInteractor;}
            set {VREditorUISystem_ptr->UIInteractor = value;}
        }
         //TODO: array not UObject TArray VRButtons
        ///<summary>The add-on that handles radial menu switching</summary>
        public unsafe VRRadialMenuHandler RadialMenuHandler {
            get {return VREditorUISystem_ptr->RadialMenuHandler;}
            set {VREditorUISystem_ptr->RadialMenuHandler = value;}
        }
        static VREditorUISystem() {
            StaticClass = Main.GetClass("VREditorUISystem");
        }
        internal unsafe VREditorUISystem_fields* VREditorUISystem_ptr => (VREditorUISystem_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VREditorUISystem(IntPtr p) => UObject.Make<VREditorUISystem>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VREditorUISystem DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VREditorUISystem New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

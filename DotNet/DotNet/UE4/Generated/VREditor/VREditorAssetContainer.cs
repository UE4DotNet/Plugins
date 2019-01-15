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
    ///<summary>Asset container for VREditor.</summary>
    public unsafe partial class VREditorAssetContainer : DataAsset  {
        ///<summary>Sounds</summary>
        public unsafe SoundBase DockableWindowCloseSound {
            get {return VREditorAssetContainer_ptr->DockableWindowCloseSound;}
            set {VREditorAssetContainer_ptr->DockableWindowCloseSound = value;}
        }
        ///<summary>Dockable Window Open Sound</summary>
        public unsafe SoundBase DockableWindowOpenSound {
            get {return VREditorAssetContainer_ptr->DockableWindowOpenSound;}
            set {VREditorAssetContainer_ptr->DockableWindowOpenSound = value;}
        }
        ///<summary>Dockable Window Drop Sound</summary>
        public unsafe SoundBase DockableWindowDropSound {
            get {return VREditorAssetContainer_ptr->DockableWindowDropSound;}
            set {VREditorAssetContainer_ptr->DockableWindowDropSound = value;}
        }
        ///<summary>Dockable Window Drag Sound</summary>
        public unsafe SoundBase DockableWindowDragSound {
            get {return VREditorAssetContainer_ptr->DockableWindowDragSound;}
            set {VREditorAssetContainer_ptr->DockableWindowDragSound = value;}
        }
        ///<summary>Drop from Content Browser Sound</summary>
        public unsafe SoundBase DropFromContentBrowserSound {
            get {return VREditorAssetContainer_ptr->DropFromContentBrowserSound;}
            set {VREditorAssetContainer_ptr->DropFromContentBrowserSound = value;}
        }
        ///<summary>Radial Menu Open Sound</summary>
        public unsafe SoundBase RadialMenuOpenSound {
            get {return VREditorAssetContainer_ptr->RadialMenuOpenSound;}
            set {VREditorAssetContainer_ptr->RadialMenuOpenSound = value;}
        }
        ///<summary>Radial Menu Close Sound</summary>
        public unsafe SoundBase RadialMenuCloseSound {
            get {return VREditorAssetContainer_ptr->RadialMenuCloseSound;}
            set {VREditorAssetContainer_ptr->RadialMenuCloseSound = value;}
        }
        ///<summary>Teleport Sound</summary>
        public unsafe SoundBase TeleportSound {
            get {return VREditorAssetContainer_ptr->TeleportSound;}
            set {VREditorAssetContainer_ptr->TeleportSound = value;}
        }
        ///<summary>Button Press Sound</summary>
        public unsafe SoundCue ButtonPressSound {
            get {return VREditorAssetContainer_ptr->ButtonPressSound;}
            set {VREditorAssetContainer_ptr->ButtonPressSound = value;}
        }
        ///<summary>Auto Scale Sound</summary>
        public unsafe SoundBase AutoScaleSound {
            get {return VREditorAssetContainer_ptr->AutoScaleSound;}
            set {VREditorAssetContainer_ptr->AutoScaleSound = value;}
        }
        ///<summary>Meshes</summary>
        public unsafe StaticMesh GenericHMDMesh {
            get {return VREditorAssetContainer_ptr->GenericHMDMesh;}
            set {VREditorAssetContainer_ptr->GenericHMDMesh = value;}
        }
        ///<summary>Plane Mesh</summary>
        public unsafe StaticMesh PlaneMesh {
            get {return VREditorAssetContainer_ptr->PlaneMesh;}
            set {VREditorAssetContainer_ptr->PlaneMesh = value;}
        }
        ///<summary>Cylinder Mesh</summary>
        public unsafe StaticMesh CylinderMesh {
            get {return VREditorAssetContainer_ptr->CylinderMesh;}
            set {VREditorAssetContainer_ptr->CylinderMesh = value;}
        }
        ///<summary>Laser Pointer Start Mesh</summary>
        public unsafe StaticMesh LaserPointerStartMesh {
            get {return VREditorAssetContainer_ptr->LaserPointerStartMesh;}
            set {VREditorAssetContainer_ptr->LaserPointerStartMesh = value;}
        }
        ///<summary>Laser Pointer Mesh</summary>
        public unsafe StaticMesh LaserPointerMesh {
            get {return VREditorAssetContainer_ptr->LaserPointerMesh;}
            set {VREditorAssetContainer_ptr->LaserPointerMesh = value;}
        }
        ///<summary>Laser Pointer End Mesh</summary>
        public unsafe StaticMesh LaserPointerEndMesh {
            get {return VREditorAssetContainer_ptr->LaserPointerEndMesh;}
            set {VREditorAssetContainer_ptr->LaserPointerEndMesh = value;}
        }
        ///<summary>Laser Pointer Hover Mesh</summary>
        public unsafe StaticMesh LaserPointerHoverMesh {
            get {return VREditorAssetContainer_ptr->LaserPointerHoverMesh;}
            set {VREditorAssetContainer_ptr->LaserPointerHoverMesh = value;}
        }
        ///<summary>Vive Pre Controller Mesh</summary>
        public unsafe StaticMesh VivePreControllerMesh {
            get {return VREditorAssetContainer_ptr->VivePreControllerMesh;}
            set {VREditorAssetContainer_ptr->VivePreControllerMesh = value;}
        }
        ///<summary>Oculus Controller Mesh</summary>
        public unsafe StaticMesh OculusControllerMesh {
            get {return VREditorAssetContainer_ptr->OculusControllerMesh;}
            set {VREditorAssetContainer_ptr->OculusControllerMesh = value;}
        }
        ///<summary>Generic Controller Mesh</summary>
        public unsafe StaticMesh GenericControllerMesh {
            get {return VREditorAssetContainer_ptr->GenericControllerMesh;}
            set {VREditorAssetContainer_ptr->GenericControllerMesh = value;}
        }
        ///<summary>Teleport Root Mesh</summary>
        public unsafe StaticMesh TeleportRootMesh {
            get {return VREditorAssetContainer_ptr->TeleportRootMesh;}
            set {VREditorAssetContainer_ptr->TeleportRootMesh = value;}
        }
        ///<summary>Window Mesh</summary>
        public unsafe StaticMesh WindowMesh {
            get {return VREditorAssetContainer_ptr->WindowMesh;}
            set {VREditorAssetContainer_ptr->WindowMesh = value;}
        }
        ///<summary>Window Selection Bar Mesh</summary>
        public unsafe StaticMesh WindowSelectionBarMesh {
            get {return VREditorAssetContainer_ptr->WindowSelectionBarMesh;}
            set {VREditorAssetContainer_ptr->WindowSelectionBarMesh = value;}
        }
        ///<summary>Window Close Button Mesh</summary>
        public unsafe StaticMesh WindowCloseButtonMesh {
            get {return VREditorAssetContainer_ptr->WindowCloseButtonMesh;}
            set {VREditorAssetContainer_ptr->WindowCloseButtonMesh = value;}
        }
        ///<summary>Radial Menu Main Mesh</summary>
        public unsafe StaticMesh RadialMenuMainMesh {
            get {return VREditorAssetContainer_ptr->RadialMenuMainMesh;}
            set {VREditorAssetContainer_ptr->RadialMenuMainMesh = value;}
        }
        ///<summary>Radial Menu Pointer Mesh</summary>
        public unsafe StaticMesh RadialMenuPointerMesh {
            get {return VREditorAssetContainer_ptr->RadialMenuPointerMesh;}
            set {VREditorAssetContainer_ptr->RadialMenuPointerMesh = value;}
        }
        ///<summary>Pointer Cursor Mesh</summary>
        public unsafe StaticMesh PointerCursorMesh {
            get {return VREditorAssetContainer_ptr->PointerCursorMesh;}
            set {VREditorAssetContainer_ptr->PointerCursorMesh = value;}
        }
        ///<summary>Line Segment Cylinder Mesh</summary>
        public unsafe StaticMesh LineSegmentCylinderMesh {
            get {return VREditorAssetContainer_ptr->LineSegmentCylinderMesh;}
            set {VREditorAssetContainer_ptr->LineSegmentCylinderMesh = value;}
        }
        ///<summary>Joint Sphere Mesh</summary>
        public unsafe StaticMesh JointSphereMesh {
            get {return VREditorAssetContainer_ptr->JointSphereMesh;}
            set {VREditorAssetContainer_ptr->JointSphereMesh = value;}
        }
        ///<summary>Materials</summary>
        public unsafe MaterialInterface GridMaterial {
            get {return VREditorAssetContainer_ptr->GridMaterial;}
            set {VREditorAssetContainer_ptr->GridMaterial = value;}
        }
        ///<summary>Laser Pointer Material</summary>
        public unsafe MaterialInterface LaserPointerMaterial {
            get {return VREditorAssetContainer_ptr->LaserPointerMaterial;}
            set {VREditorAssetContainer_ptr->LaserPointerMaterial = value;}
        }
        ///<summary>Laser Pointer Translucent Material</summary>
        public unsafe MaterialInterface LaserPointerTranslucentMaterial {
            get {return VREditorAssetContainer_ptr->LaserPointerTranslucentMaterial;}
            set {VREditorAssetContainer_ptr->LaserPointerTranslucentMaterial = value;}
        }
        ///<summary>World Movement Post Process Material</summary>
        public unsafe Material WorldMovementPostProcessMaterial {
            get {return VREditorAssetContainer_ptr->WorldMovementPostProcessMaterial;}
            set {VREditorAssetContainer_ptr->WorldMovementPostProcessMaterial = value;}
        }
        ///<summary>Text Material</summary>
        public unsafe MaterialInterface TextMaterial {
            get {return VREditorAssetContainer_ptr->TextMaterial;}
            set {VREditorAssetContainer_ptr->TextMaterial = value;}
        }
        ///<summary>Vive Pre Controller Material</summary>
        public unsafe MaterialInterface VivePreControllerMaterial {
            get {return VREditorAssetContainer_ptr->VivePreControllerMaterial;}
            set {VREditorAssetContainer_ptr->VivePreControllerMaterial = value;}
        }
        ///<summary>Oculus Controller Material</summary>
        public unsafe MaterialInterface OculusControllerMaterial {
            get {return VREditorAssetContainer_ptr->OculusControllerMaterial;}
            set {VREditorAssetContainer_ptr->OculusControllerMaterial = value;}
        }
        ///<summary>Teleport Material</summary>
        public unsafe MaterialInterface TeleportMaterial {
            get {return VREditorAssetContainer_ptr->TeleportMaterial;}
            set {VREditorAssetContainer_ptr->TeleportMaterial = value;}
        }
        ///<summary>Window Material</summary>
        public unsafe MaterialInterface WindowMaterial {
            get {return VREditorAssetContainer_ptr->WindowMaterial;}
            set {VREditorAssetContainer_ptr->WindowMaterial = value;}
        }
        ///<summary>Window Translucent Material</summary>
        public unsafe MaterialInterface WindowTranslucentMaterial {
            get {return VREditorAssetContainer_ptr->WindowTranslucentMaterial;}
            set {VREditorAssetContainer_ptr->WindowTranslucentMaterial = value;}
        }
        ///<summary>Line Material</summary>
        public unsafe Material LineMaterial {
            get {return VREditorAssetContainer_ptr->LineMaterial;}
            set {VREditorAssetContainer_ptr->LineMaterial = value;}
        }
        ///<summary>Translucent Text Material</summary>
        public unsafe MaterialInterface TranslucentTextMaterial {
            get {return VREditorAssetContainer_ptr->TranslucentTextMaterial;}
            set {VREditorAssetContainer_ptr->TranslucentTextMaterial = value;}
        }
        ///<summary>Fonts</summary>
        public unsafe Font TextFont {
            get {return VREditorAssetContainer_ptr->TextFont;}
            set {VREditorAssetContainer_ptr->TextFont = value;}
        }
        static VREditorAssetContainer() {
            StaticClass = Main.GetClass("VREditorAssetContainer");
        }
        internal unsafe VREditorAssetContainer_fields* VREditorAssetContainer_ptr => (VREditorAssetContainer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VREditorAssetContainer(IntPtr p) => UObject.Make<VREditorAssetContainer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VREditorAssetContainer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VREditorAssetContainer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

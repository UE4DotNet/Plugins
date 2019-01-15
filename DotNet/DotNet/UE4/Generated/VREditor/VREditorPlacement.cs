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
using UE4.UMG;

namespace UE4.VREditor {
    ///<summary>VR Editor interaction with the 3D world</summary>
    public unsafe partial class VREditorPlacement : UObject  {
        ///<summary>Owning object</summary>
        public unsafe VREditorMode VRMode {
            get {return VREditorPlacement_ptr->VRMode;}
            set {VREditorPlacement_ptr->VRMode = value;}
        }
        ///<summary>The actual ViewportWorldInteraction</summary>
        public unsafe ViewportWorldInteraction ViewportWorldInteraction {
            get {return VREditorPlacement_ptr->ViewportWorldInteraction;}
            set {VREditorPlacement_ptr->ViewportWorldInteraction = value;}
        }
        ///<summary>The UI used to drag an asset into the level</summary>
        public unsafe WidgetComponent FloatingUIAssetDraggedFrom {
            get {return VREditorPlacement_ptr->FloatingUIAssetDraggedFrom;}
            set {VREditorPlacement_ptr->FloatingUIAssetDraggedFrom = value;}
        }
        ///<summary>The material or texture asset we're dragging to place on an object</summary>
        public unsafe UObject PlacingMaterialOrTextureAsset {
            get {return VREditorPlacement_ptr->PlacingMaterialOrTextureAsset;}
            set {VREditorPlacement_ptr->PlacingMaterialOrTextureAsset = value;}
        }
        static VREditorPlacement() {
            StaticClass = Main.GetClass("VREditorPlacement");
        }
        internal unsafe VREditorPlacement_fields* VREditorPlacement_ptr => (VREditorPlacement_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VREditorPlacement(IntPtr p) => UObject.Make<VREditorPlacement>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VREditorPlacement DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VREditorPlacement New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

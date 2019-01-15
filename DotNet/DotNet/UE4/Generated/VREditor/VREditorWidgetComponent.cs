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
using UE4.UMG;

namespace UE4.VREditor {
    ///<summary>A specialized WidgetComponent for the VREditor</summary>
    public unsafe partial class VREditorWidgetComponent : WidgetComponent  {
         //TODO: enum EVREditorWidgetDrawingPolicy DrawingPolicy
        public bool bIsHovering {
            get {return Main.GetGetBoolPropertyByName(this, "bIsHovering"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsHovering", value); }
        }
        public bool bHasEverDrawn {
            get {return Main.GetGetBoolPropertyByName(this, "bHasEverDrawn"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasEverDrawn", value); }
        }
        static VREditorWidgetComponent() {
            StaticClass = Main.GetClass("VREditorWidgetComponent");
        }
        internal unsafe VREditorWidgetComponent_fields* VREditorWidgetComponent_ptr => (VREditorWidgetComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VREditorWidgetComponent(IntPtr p) => UObject.Make<VREditorWidgetComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VREditorWidgetComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VREditorWidgetComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

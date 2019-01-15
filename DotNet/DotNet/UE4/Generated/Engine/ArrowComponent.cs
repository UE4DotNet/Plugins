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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>A simple arrow rendered using lines. Useful for indicating which way an object is facing.</summary>
    public unsafe partial class ArrowComponent : PrimitiveComponent  {

        ///<summary>Updates the arrow's colour, and tells it to refresh</summary>
        public void SetArrowColor(LinearColor NewColor)  => 
            ArrowComponent_methods.SetArrowColor_method.Invoke(ObjPointer, NewColor);
        ///<summary>Arrow Color</summary>
        public unsafe Color ArrowColor {
            get {return ArrowComponent_ptr->ArrowColor;}
            set {ArrowComponent_ptr->ArrowColor = value;}
        }
        ///<summary>Arrow Size</summary>
        public unsafe float ArrowSize {
            get {return ArrowComponent_ptr->ArrowSize;}
            set {ArrowComponent_ptr->ArrowSize = value;}
        }
        public bool bIsScreenSizeScaled {
            get {return Main.GetGetBoolPropertyByName(this, "bIsScreenSizeScaled"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsScreenSizeScaled", value); }
        }
        ///<summary>The size on screen to limit this arrow to (in screen space)</summary>
        public unsafe float ScreenSize {
            get {return ArrowComponent_ptr->ScreenSize;}
            set {ArrowComponent_ptr->ScreenSize = value;}
        }
        public bool bTreatAsASprite {
            get {return Main.GetGetBoolPropertyByName(this, "bTreatAsASprite"); }
            set {Main.SetGetBoolPropertyByName(this, "bTreatAsASprite", value); }
        }
        ///<summary>Sprite category information regarding the arrow component, if being treated as a sprite.</summary>
        public unsafe SpriteCategoryInfo SpriteInfo {
            get {return ArrowComponent_ptr->SpriteInfo;}
            set {ArrowComponent_ptr->SpriteInfo = value;}
        }
        public bool bLightAttachment {
            get {return Main.GetGetBoolPropertyByName(this, "bLightAttachment"); }
            set {Main.SetGetBoolPropertyByName(this, "bLightAttachment", value); }
        }
        public bool bUseInEditorScaling {
            get {return Main.GetGetBoolPropertyByName(this, "bUseInEditorScaling"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseInEditorScaling", value); }
        }
        static ArrowComponent() {
            StaticClass = Main.GetClass("ArrowComponent");
        }
        internal unsafe ArrowComponent_fields* ArrowComponent_ptr => (ArrowComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ArrowComponent(IntPtr p) => UObject.Make<ArrowComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ArrowComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ArrowComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

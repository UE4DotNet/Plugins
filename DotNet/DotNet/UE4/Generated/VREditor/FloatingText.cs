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
    ///<summary>Draws 3D text in the world along with targeting line cues</summary>
    public unsafe partial class FloatingText : Actor  {
        ///<summary>Scene component root of this actor</summary>
        public unsafe SceneComponent SceneComponent {
            get {return FloatingText_ptr->SceneComponent;}
            set {FloatingText_ptr->SceneComponent = value;}
        }
        ///<summary>First line segment component.  Starts at the designation location, goes toward the line connection point.</summary>
        public unsafe StaticMeshComponent FirstLineComponent {
            get {return FloatingText_ptr->FirstLineComponent;}
            set {FloatingText_ptr->FirstLineComponent = value;}
        }
        ///<summary>Sphere that connects the two line segments and makes the joint look smooth and round</summary>
        public unsafe StaticMeshComponent JointSphereComponent {
            get {return FloatingText_ptr->JointSphereComponent;}
            set {FloatingText_ptr->JointSphereComponent = value;}
        }
        ///<summary>Second line segment component.  Starts at the connection point and goes toward the 3D text.</summary>
        public unsafe StaticMeshComponent SecondLineComponent {
            get {return FloatingText_ptr->SecondLineComponent;}
            set {FloatingText_ptr->SecondLineComponent = value;}
        }
        ///<summary>The 3D text we're drawing.  Positioned at the end of the second line.</summary>
        public unsafe TextRenderComponent TextComponent {
            get {return FloatingText_ptr->TextComponent;}
            set {FloatingText_ptr->TextComponent = value;}
        }
        ///<summary>Masked text material.  Used after faded in</summary>
        public unsafe MaterialInterface MaskedTextMaterial {
            get {return FloatingText_ptr->MaskedTextMaterial;}
            set {FloatingText_ptr->MaskedTextMaterial = value;}
        }
        ///<summary>Translucent text material.  Used during fading</summary>
        public unsafe MaterialInterface TranslucentTextMaterial {
            get {return FloatingText_ptr->TranslucentTextMaterial;}
            set {FloatingText_ptr->TranslucentTextMaterial = value;}
        }
        ///<summary>Material to use for the line meshes</summary>
        public unsafe MaterialInterface LineMaterial {
            get {return FloatingText_ptr->LineMaterial;}
            set {FloatingText_ptr->LineMaterial = value;}
        }
        ///<summary>Dynamic material instance for fading lines in and out</summary>
        public unsafe MaterialInstanceDynamic LineMaterialMID {
            get {return FloatingText_ptr->LineMaterialMID;}
            set {FloatingText_ptr->LineMaterialMID = value;}
        }
        static FloatingText() {
            StaticClass = Main.GetClass("FloatingText");
        }
        internal unsafe FloatingText_fields* FloatingText_ptr => (FloatingText_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FloatingText(IntPtr p) => UObject.Make<FloatingText>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FloatingText DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FloatingText New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

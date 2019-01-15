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
using UE4.UMG.Native;

namespace UE4.UMG {
    ///<summary>
    ///The canvas panel is a designer friendly panel that allows widgets to be laid out at arbitrary
    ///locations, anchored and z-ordered with other children of the canvas.
    ///</summary>
    ///<remarks>
    ///The canvas is a great widget
    ///for manual layout, but bad when you want to procedurally just generate widgets and place them in a
    ///container (unless you want absolute layout).
    ///
    ///* Many Children
    ///* Absolute Layout
    ///* Anchors
    ///</remarks>
    public unsafe partial class CanvasPanel : PanelWidget  {

        ///<summary>Add Child to Canvas</summary>
        public CanvasPanelSlot AddChildToCanvas(Widget Content)  => 
            CanvasPanel_methods.AddChildToCanvas_method.Invoke(ObjPointer, Content);
        static CanvasPanel() {
            StaticClass = Main.GetClass("CanvasPanel");
        }
        internal unsafe CanvasPanel_fields* CanvasPanel_ptr => (CanvasPanel_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CanvasPanel(IntPtr p) => UObject.Make<CanvasPanel>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CanvasPanel DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CanvasPanel New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

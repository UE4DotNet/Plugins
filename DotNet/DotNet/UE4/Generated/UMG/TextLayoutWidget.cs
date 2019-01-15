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
using UE4.SlateCore;

namespace UE4.UMG {
    ///<summary>Base class for all widgets that use a text layout.</summary>
    ///<remarks>Contains the common options that should be exposed for the underlying Slate widget.</remarks>
    public unsafe partial class TextLayoutWidget : Widget  {
        ///<summary>Controls how the text within this widget should be shaped.</summary>
        public unsafe ShapedTextOptions ShapedTextOptions {
            get {return TextLayoutWidget_ptr->ShapedTextOptions;}
        }
        ///<summary>How the text should be aligned with the margin.</summary>
        public unsafe byte Justification {
            get {return TextLayoutWidget_ptr->Justification;}
            set {TextLayoutWidget_ptr->Justification = value;}
        }
         //TODO: enum ETextWrappingPolicy WrappingPolicy
        public bool AutoWrapText {
            get {return Main.GetGetBoolPropertyByName(this, "AutoWrapText"); }
        }
        ///<summary>Whether text wraps onto a new line when it's length exceeds this width; if this value is zero or negative, no wrapping occurs.</summary>
        public unsafe float WrapTextAt {
            get {return TextLayoutWidget_ptr->WrapTextAt;}
        }
        ///<summary>The amount of blank space left around the edges of text area.</summary>
        public unsafe Margin Margin {
            get {return TextLayoutWidget_ptr->Margin;}
        }
        ///<summary>The amount to scale each lines height by.</summary>
        public unsafe float LineHeightPercentage {
            get {return TextLayoutWidget_ptr->LineHeightPercentage;}
        }
        static TextLayoutWidget() {
            StaticClass = Main.GetClass("TextLayoutWidget");
        }
        internal unsafe TextLayoutWidget_fields* TextLayoutWidget_ptr => (TextLayoutWidget_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TextLayoutWidget(IntPtr p) => UObject.Make<TextLayoutWidget>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TextLayoutWidget DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TextLayoutWidget New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

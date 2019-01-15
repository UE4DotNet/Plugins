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
using UE4.Engine;

namespace UE4.UMG {
    ///<summary>
    ///A border is a container widget that can contain one child widget, providing an opportunity
    ///to surround it with a background image and adjustable padding.
    ///</summary>
    ///<remarks>
    ///* Single Child
    ///* Image
    ///</remarks>
    public unsafe partial class Border : ContentWidget  {

        ///<summary>Get Dynamic Material</summary>
        public MaterialInstanceDynamic GetDynamicMaterial()  => 
            Border_methods.GetDynamicMaterial_method.Invoke(ObjPointer);

        ///<summary>Set Brush</summary>
        public void SetBrush(SlateBrush InBrush)  => 
            Border_methods.SetBrush_method.Invoke(ObjPointer, InBrush);

        ///<summary>Set Brush Color</summary>
        public void SetBrushColor(LinearColor InBrushColor)  => 
            Border_methods.SetBrushColor_method.Invoke(ObjPointer, InBrushColor);

        ///<summary>Set Brush from Asset</summary>
        public void SetBrushFromAsset(SlateBrushAsset Asset)  => 
            Border_methods.SetBrushFromAsset_method.Invoke(ObjPointer, Asset);

        ///<summary>Set Brush from Material</summary>
        public void SetBrushFromMaterial(MaterialInterface Material)  => 
            Border_methods.SetBrushFromMaterial_method.Invoke(ObjPointer, Material);

        ///<summary>Set Brush from Texture</summary>
        public void SetBrushFromTexture(Texture2D Texture)  => 
            Border_methods.SetBrushFromTexture_method.Invoke(ObjPointer, Texture);

        ///<summary>Set Content Color and Opacity</summary>
        public void SetContentColorAndOpacity(LinearColor InContentColorAndOpacity)  => 
            Border_methods.SetContentColorAndOpacity_method.Invoke(ObjPointer, InContentColorAndOpacity);

        ///<summary>Sets the DesireSizeScale of this border.</summary>
        ///<remarks>
        ///@param InScale    The X and Y multipliers for the desired size
        ///</remarks>
        public void SetDesiredSizeScale(Vector2D InScale)  => 
            Border_methods.SetDesiredSizeScale_method.Invoke(ObjPointer, InScale);

        ///<summary>Set Horizontal Alignment</summary>
        public void SetHorizontalAlignment(byte InHorizontalAlignment)  => 
            Border_methods.SetHorizontalAlignment_method.Invoke(ObjPointer, InHorizontalAlignment);

        ///<summary>Set Padding</summary>
        public void SetPadding(Margin InPadding)  => 
            Border_methods.SetPadding_method.Invoke(ObjPointer, InPadding);

        ///<summary>Set Vertical Alignment</summary>
        public void SetVerticalAlignment(byte InVerticalAlignment)  => 
            Border_methods.SetVerticalAlignment_method.Invoke(ObjPointer, InVerticalAlignment);
        ///<summary>The alignment of the content horizontally.</summary>
        public unsafe byte HorizontalAlignment {
            get {return Border_ptr->HorizontalAlignment;}
        }
        ///<summary>The alignment of the content vertically.</summary>
        public unsafe byte VerticalAlignment {
            get {return Border_ptr->VerticalAlignment;}
        }
        public bool bShowEffectWhenDisabled {
            get {return Main.GetGetBoolPropertyByName(this, "bShowEffectWhenDisabled"); }
        }
        ///<summary>Color and opacity multiplier of content in the border</summary>
        public unsafe LinearColor ContentColorAndOpacity {
            get {return Border_ptr->ContentColorAndOpacity;}
        }
         //TODO: delegate FGetLinearColor ContentColorAndOpacityDelegate
        ///<summary>The padding area between the slot and the content it contains.</summary>
        public unsafe Margin Padding {
            get {return Border_ptr->Padding;}
        }
        ///<summary>Brush to drag as the background</summary>
        public unsafe SlateBrush Background {
            get {return Border_ptr->Background;}
        }
         //TODO: delegate FGetSlateBrush BackgroundDelegate
        ///<summary>Color and opacity of the actual border image</summary>
        public unsafe LinearColor BrushColor {
            get {return Border_ptr->BrushColor;}
        }
         //TODO: delegate FGetLinearColor BrushColorDelegate
        ///<summary>Scales the computed desired size of this border and its contents.</summary>
        ///<remarks>
        ///Useful
        ///for making things that slide open without having to hard-code their size.
        ///Note: if the parent widget is set up to ignore this widget's desired size,
        ///then changing this value will have no effect.
        ///</remarks>
        public unsafe Vector2D DesiredSizeScale {
            get {return Border_ptr->DesiredSizeScale;}
        }
         //TODO: delegate FOnPointerEvent OnMouseButtonDownEvent
         //TODO: delegate FOnPointerEvent OnMouseButtonUpEvent
         //TODO: delegate FOnPointerEvent OnMouseMoveEvent
         //TODO: delegate FOnPointerEvent OnMouseDoubleClickEvent
        static Border() {
            StaticClass = Main.GetClass("Border");
        }
        internal unsafe Border_fields* Border_ptr => (Border_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Border(IntPtr p) => UObject.Make<Border>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Border DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Border New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

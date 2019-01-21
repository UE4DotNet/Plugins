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
    ///<summary>A simple static text widget.</summary>
    ///<remarks>
    ///* No Children
    ///* Text
    ///</remarks>
    public unsafe partial class TextBlock : TextLayoutWidget  {

        ///<summary>Get Dynamic Font Material</summary>
        public MaterialInstanceDynamic GetDynamicFontMaterial()  => 
            TextBlock_methods.GetDynamicFontMaterial_method.Invoke(ObjPointer);

        ///<summary>Get Dynamic Outline Material</summary>
        public MaterialInstanceDynamic GetDynamicOutlineMaterial()  => 
            TextBlock_methods.GetDynamicOutlineMaterial_method.Invoke(ObjPointer);

        ///<summary>
        ///Gets the widget text
        ///@
        ///</summary>
        ///<remarks>return The widget text</remarks>
        public byte /*TODO: text FText*/ GetText()  => 
            TextBlock_methods.GetText_method.Invoke(ObjPointer);

        ///<summary>Set the auto wrap for this text block.</summary>
        ///<remarks>
        ///@param InAutoTextWrap to turn wrap on or off.
        ///</remarks>
        public void SetAutoWrapText(bool InAutoTextWrap)  => 
            TextBlock_methods.SetAutoWrapText_method.Invoke(ObjPointer, InAutoTextWrap);

        ///<summary>
        ///Sets the color and opacity of the text in this text block
        ///@
        ///</summary>
        ///<remarks>param InColorAndOpacity             The new text color and opacity</remarks>
        public void SetColorAndOpacity(SlateColor InColorAndOpacity)  => 
            TextBlock_methods.SetColorAndOpacity_method.Invoke(ObjPointer, InColorAndOpacity);

        ///<summary>
        ///Dynamically set the font info for this text block
        ///@
        ///</summary>
        ///<remarks>param InFontInfo THe new font info</remarks>
        public void SetFont(SlateFontInfo InFontInfo)  => 
            TextBlock_methods.SetFont_method.Invoke(ObjPointer, InFontInfo);

        ///<summary>
        ///Set the text justification for this text block
        ///@
        ///</summary>
        ///<remarks>param InJustification new justification</remarks>
        public void SetJustification(byte InJustification)  => 
            TextBlock_methods.SetJustification_method.Invoke(ObjPointer, InJustification);

        ///<summary>
        ///Set the minimum desired width for this text block
        ///@
        ///</summary>
        ///<remarks>param InMinDesiredWidth new minimum desired width</remarks>
        public void SetMinDesiredWidth(float InMinDesiredWidth)  => 
            TextBlock_methods.SetMinDesiredWidth_method.Invoke(ObjPointer, InMinDesiredWidth);

        ///<summary>
        ///Sets the opacity of the text in this text block
        ///@
        ///</summary>
        ///<remarks>param InOpacity              The new text opacity</remarks>
        public void SetOpacity(float InOpacity)  => 
            TextBlock_methods.SetOpacity_method.Invoke(ObjPointer, InOpacity);

        ///<summary>
        ///Sets the color and opacity of the text drop shadow
        ///Note: if opacity is zero no shadow will be drawn
        ///@
        ///</summary>
        ///<remarks>param InShadowColorAndOpacity               The new drop shadow color and opacity</remarks>
        public void SetShadowColorAndOpacity(LinearColor InShadowColorAndOpacity)  => 
            TextBlock_methods.SetShadowColorAndOpacity_method.Invoke(ObjPointer, InShadowColorAndOpacity);

        ///<summary>
        ///Sets the offset that the text drop shadow should be drawn at
        ///@
        ///</summary>
        ///<remarks>param InShadowOffset                The new offset</remarks>
        public void SetShadowOffset(Vector2D InShadowOffset)  => 
            TextBlock_methods.SetShadowOffset_method.Invoke(ObjPointer, InShadowOffset);

        ///<summary>Directly sets the widget text.</summary>
        ///<remarks>
        ///Warning: This will wipe any binding created for the Text property!
        ///@param InText The text to assign to the widget
        ///</remarks>
        public void SetText(byte InText /*TODO: text FText */)  => 
            TextBlock_methods.SetText_method.Invoke(ObjPointer, InText);
         //TODO: text FText Text
         //TODO: delegate FGetText TextDelegate
        ///<summary>The color of the text</summary>
        public unsafe SlateColor ColorAndOpacity {
            get {return TextBlock_ptr->ColorAndOpacity;}
        }
         //TODO: delegate FGetSlateColor ColorAndOpacityDelegate
        ///<summary>The font to render the text with</summary>
        public unsafe SlateFontInfo Font {
            get {return TextBlock_ptr->Font;}
        }
        ///<summary>The direction the shadow is cast</summary>
        public unsafe Vector2D ShadowOffset {
            get {return TextBlock_ptr->ShadowOffset;}
        }
        ///<summary>The color of the shadow</summary>
        public unsafe LinearColor ShadowColorAndOpacity {
            get {return TextBlock_ptr->ShadowColorAndOpacity;}
        }
         //TODO: delegate FGetLinearColor ShadowColorAndOpacityDelegate
        ///<summary>The minimum desired size for the text</summary>
        public unsafe float MinDesiredWidth {
            get {return TextBlock_ptr->MinDesiredWidth;}
        }
        public bool bWrapWithInvalidationPanel {
            get {return Main.GetGetBoolPropertyByName(this, "bWrapWithInvalidationPanel"); }
        }
        static TextBlock() {
            StaticClass = Main.GetClass("TextBlock");
        }
        internal unsafe TextBlock_fields* TextBlock_ptr => (TextBlock_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TextBlock(IntPtr p) => UObject.Make<TextBlock>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TextBlock DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TextBlock New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

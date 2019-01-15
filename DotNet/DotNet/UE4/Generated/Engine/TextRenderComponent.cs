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
    ///<summary>Renders text in the world with given font. Contains usual font related attributes such as Scale, Alignment, Color etc.</summary>
    public unsafe partial class TextRenderComponent : PrimitiveComponent  {

        ///<summary>Get local size of text</summary>
        public Vector GetTextLocalSize()  => 
            TextRenderComponent_methods.GetTextLocalSize_method.Invoke(ObjPointer);

        ///<summary>Get world space size of text</summary>
        public Vector GetTextWorldSize()  => 
            TextRenderComponent_methods.GetTextWorldSize_method.Invoke(ObjPointer);

        ///<summary>Change the text value and signal the primitives to be rebuilt</summary>
        public void K2_SetText(byte Value /*TODO: text FText */)  => 
            TextRenderComponent_methods.K2_SetText_method.Invoke(ObjPointer, Value);

        ///<summary>Change the font and signal the primitives to be rebuilt</summary>
        public void SetFont(Font Value)  => 
            TextRenderComponent_methods.SetFont_method.Invoke(ObjPointer, Value);

        ///<summary>Change the horizontal alignment and signal the primitives to be rebuilt</summary>
        public void SetHorizontalAlignment(byte Value)  => 
            TextRenderComponent_methods.SetHorizontalAlignment_method.Invoke(ObjPointer, Value);

        ///<summary>Change the text horizontal spacing adjustment and signal the primitives to be rebuilt</summary>
        public void SetHorizSpacingAdjust(float Value)  => 
            TextRenderComponent_methods.SetHorizSpacingAdjust_method.Invoke(ObjPointer, Value);

        ///<summary>Set Text</summary>
        public void SetText(string Value)  => 
            TextRenderComponent_methods.SetText_method.Invoke(ObjPointer, Value);

        ///<summary>Change the text material and signal the primitives to be rebuilt</summary>
        public void SetTextMaterial(MaterialInterface Material)  => 
            TextRenderComponent_methods.SetTextMaterial_method.Invoke(ObjPointer, Material);

        ///<summary>Change the text render color and signal the primitives to be rebuilt</summary>
        public void SetTextRenderColor(Color Value)  => 
            TextRenderComponent_methods.SetTextRenderColor_method.Invoke(ObjPointer, Value);

        ///<summary>Change the vertical alignment and signal the primitives to be rebuilt</summary>
        public void SetVerticalAlignment(byte Value)  => 
            TextRenderComponent_methods.SetVerticalAlignment_method.Invoke(ObjPointer, Value);

        ///<summary>Change the text vertical spacing adjustment and signal the primitives to be rebuilt</summary>
        public void SetVertSpacingAdjust(float Value)  => 
            TextRenderComponent_methods.SetVertSpacingAdjust_method.Invoke(ObjPointer, Value);

        ///<summary>Change the world size of the text and signal the primitives to be rebuilt</summary>
        public void SetWorldSize(float Value)  => 
            TextRenderComponent_methods.SetWorldSize_method.Invoke(ObjPointer, Value);

        ///<summary>Change the text X scale and signal the primitives to be rebuilt</summary>
        public void SetXScale(float Value)  => 
            TextRenderComponent_methods.SetXScale_method.Invoke(ObjPointer, Value);

        ///<summary>Change the text Y scale and signal the primitives to be rebuilt</summary>
        public void SetYScale(float Value)  => 
            TextRenderComponent_methods.SetYScale_method.Invoke(ObjPointer, Value);
         //TODO: text FText Text
        ///<summary>Text material</summary>
        public unsafe MaterialInterface TextMaterial {
            get {return TextRenderComponent_ptr->TextMaterial;}
        }
        ///<summary>Text font</summary>
        public unsafe Font Font {
            get {return TextRenderComponent_ptr->Font;}
        }
        ///<summary>Horizontal text alignment</summary>
        public unsafe byte HorizontalAlignment {
            get {return TextRenderComponent_ptr->HorizontalAlignment;}
        }
        ///<summary>Vertical text alignment</summary>
        public unsafe byte VerticalAlignment {
            get {return TextRenderComponent_ptr->VerticalAlignment;}
        }
        ///<summary>Color of the text, can be accessed as vertex color</summary>
        public unsafe Color TextRenderColor {
            get {return TextRenderComponent_ptr->TextRenderColor;}
        }
        ///<summary>Horizontal scale, default is 1.0</summary>
        public unsafe float XScale {
            get {return TextRenderComponent_ptr->XScale;}
        }
        ///<summary>Vertical scale, default is 1.0</summary>
        public unsafe float YScale {
            get {return TextRenderComponent_ptr->YScale;}
        }
        ///<summary>Vertical size of the fonts largest character in world units. Transform, XScale and YScale will affect final size.</summary>
        public unsafe float WorldSize {
            get {return TextRenderComponent_ptr->WorldSize;}
        }
        ///<summary>The inverse of the Font's character height.</summary>
        public unsafe float InvDefaultSize {
            get {return TextRenderComponent_ptr->InvDefaultSize;}
            set {TextRenderComponent_ptr->InvDefaultSize = value;}
        }
        ///<summary>Horizontal adjustment per character, default is 0.0</summary>
        public unsafe float HorizSpacingAdjust {
            get {return TextRenderComponent_ptr->HorizSpacingAdjust;}
        }
        ///<summary>Vertical adjustment per character, default is 0.0</summary>
        public unsafe float VertSpacingAdjust {
            get {return TextRenderComponent_ptr->VertSpacingAdjust;}
        }
        public bool bAlwaysRenderAsText {
            get {return Main.GetGetBoolPropertyByName(this, "bAlwaysRenderAsText"); }
        }
        static TextRenderComponent() {
            StaticClass = Main.GetClass("TextRenderComponent");
        }
        internal unsafe TextRenderComponent_fields* TextRenderComponent_ptr => (TextRenderComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TextRenderComponent(IntPtr p) => UObject.Make<TextRenderComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TextRenderComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TextRenderComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

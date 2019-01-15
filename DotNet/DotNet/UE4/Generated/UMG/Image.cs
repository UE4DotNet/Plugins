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
    ///<summary>The image widget allows you to display a Slate Brush, or texture or material in the UI.</summary>
    ///<remarks>* No Children</remarks>
    public unsafe partial class Image : Widget  {

        ///<summary>Get Dynamic Material</summary>
        public MaterialInstanceDynamic GetDynamicMaterial()  => 
            Image_methods.GetDynamicMaterial_method.Invoke(ObjPointer);

        ///<summary>Set Brush</summary>
        public void SetBrush(SlateBrush InBrush)  => 
            Image_methods.SetBrush_method.Invoke(ObjPointer, InBrush);

        ///<summary>Set Brush from Asset</summary>
        public void SetBrushFromAsset(SlateBrushAsset Asset)  => 
            Image_methods.SetBrushFromAsset_method.Invoke(ObjPointer, Asset);

        ///<summary>Set Brush from Atlas Interface</summary>
        public void SetBrushFromAtlasInterface(byte AtlasRegion /*TODO: interface TScriptInterface */, bool bMatchSize)  => 
            Image_methods.SetBrushFromAtlasInterface_method.Invoke(ObjPointer, AtlasRegion, bMatchSize);

        ///<summary>Set Brush from Material</summary>
        public void SetBrushFromMaterial(MaterialInterface Material)  => 
            Image_methods.SetBrushFromMaterial_method.Invoke(ObjPointer, Material);

        ///<summary>Set Brush from Texture</summary>
        public void SetBrushFromTexture(Texture2D Texture, bool bMatchSize)  => 
            Image_methods.SetBrushFromTexture_method.Invoke(ObjPointer, Texture, bMatchSize);

        ///<summary>Set Brush from Texture Dynamic</summary>
        public void SetBrushFromTextureDynamic(Texture2DDynamic Texture, bool bMatchSize)  => 
            Image_methods.SetBrushFromTextureDynamic_method.Invoke(ObjPointer, Texture, bMatchSize);

        ///<summary>Set Brush Size</summary>
        public void SetBrushSize(Vector2D DesiredSize)  => 
            Image_methods.SetBrushSize_method.Invoke(ObjPointer, DesiredSize);

        ///<summary>Set Brush Tint Color</summary>
        public void SetBrushTintColor(SlateColor TintColor)  => 
            Image_methods.SetBrushTintColor_method.Invoke(ObjPointer, TintColor);

        ///<summary>Set Color and Opacity</summary>
        public void SetColorAndOpacity(LinearColor InColorAndOpacity)  => 
            Image_methods.SetColorAndOpacity_method.Invoke(ObjPointer, InColorAndOpacity);

        ///<summary>Set Opacity</summary>
        public void SetOpacity(float InOpacity)  => 
            Image_methods.SetOpacity_method.Invoke(ObjPointer, InOpacity);
        ///<summary>Image to draw</summary>
        public unsafe SlateBrush Brush {
            get {return Image_ptr->Brush;}
        }
         //TODO: delegate FGetSlateBrush BrushDelegate
        ///<summary>Color and opacity</summary>
        public unsafe LinearColor ColorAndOpacity {
            get {return Image_ptr->ColorAndOpacity;}
        }
         //TODO: delegate FGetLinearColor ColorAndOpacityDelegate
         //TODO: delegate FOnPointerEvent OnMouseButtonDownEvent
        static Image() {
            StaticClass = Main.GetClass("Image");
        }
        internal unsafe Image_fields* Image_ptr => (Image_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Image(IntPtr p) => UObject.Make<Image>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Image DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Image New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

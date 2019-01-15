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
    ///<summary>A geometry layer within the stereo rendered viewport.</summary>
    public unsafe partial class StereoLayerComponent : SceneComponent  {

        ///<summary>@return the render priority</summary>
        public int GetPriority()  => 
            StereoLayerComponent_methods.GetPriority_method.Invoke(ObjPointer);

        ///<summary>@return the height and width of the rendered quad</summary>
        public Vector2D GetQuadSize()  => 
            StereoLayerComponent_methods.GetQuadSize_method.Invoke(ObjPointer);

        ///<summary>@return the texture mapped to the stereo layer quad</summary>
        public Texture GetTexture()  => 
            StereoLayerComponent_methods.GetTexture_method.Invoke(ObjPointer);

        ///<summary>@return the UV coordinates mapped to the quad face</summary>
        public Box2D GetUVRect()  => 
            StereoLayerComponent_methods.GetUVRect_method.Invoke(ObjPointer);

        ///<summary>Manually mark the stereo layer texture for updating</summary>
        public void MarkTextureForUpdate()  => 
            StereoLayerComponent_methods.MarkTextureForUpdate_method.Invoke(ObjPointer);

        ///<summary>
        ///Change the layer's render priority, higher priorities render on top of lower priorities
        ///@
        ///</summary>
        ///<remarks>param       InPriority: Priority value</remarks>
        public void SetPriority(int InPriority)  => 
            StereoLayerComponent_methods.SetPriority_method.Invoke(ObjPointer, InPriority);

        ///<summary>Change the quad size.</summary>
        ///<remarks>
        ///This is the unscaled height and width, before component scale is applied.
        ///@param       InQuadSize: new quad size.
        ///</remarks>
        public void SetQuadSize(Vector2D InQuadSize)  => 
            StereoLayerComponent_methods.SetQuadSize_method.Invoke(ObjPointer, InQuadSize);

        ///<summary>
        ///Change the texture displayed on the stereo layer quad
        ///@
        ///</summary>
        ///<remarks>param       InTexture: new Texture2D</remarks>
        public void SetTexture(Texture InTexture)  => 
            StereoLayerComponent_methods.SetTexture_method.Invoke(ObjPointer, InTexture);

        ///<summary>
        ///Change the UV coordinates mapped to the quad face
        ///@
        ///</summary>
        ///<remarks>param       InUVRect: Min and Max UV coordinates</remarks>
        public void SetUVRect(Box2D InUVRect)  => 
            StereoLayerComponent_methods.SetUVRect_method.Invoke(ObjPointer, InUVRect);
        public bool bLiveTexture {
            get {return Main.GetGetBoolPropertyByName(this, "bLiveTexture"); }
            set {Main.SetGetBoolPropertyByName(this, "bLiveTexture", value); }
        }
        public bool bSupportsDepth {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsDepth"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsDepth", value); }
        }
        public bool bNoAlphaChannel {
            get {return Main.GetGetBoolPropertyByName(this, "bNoAlphaChannel"); }
            set {Main.SetGetBoolPropertyByName(this, "bNoAlphaChannel", value); }
        }
        ///<summary>Texture displayed on the stereo layer (is stereocopic textures are supported on the platfrom and more than one texture is provided, this will be the right eye) *</summary>
        public unsafe Texture Texture {
            get {return StereoLayerComponent_ptr->Texture;}
        }
        ///<summary>Texture displayed on the stereo layer for left eye, if stereoscopic textures are supported on the platform *</summary>
        public unsafe Texture LeftTexture {
            get {return StereoLayerComponent_ptr->LeftTexture;}
        }
        public bool bQuadPreserveTextureRatio {
            get {return Main.GetGetBoolPropertyByName(this, "bQuadPreserveTextureRatio"); }
            set {Main.SetGetBoolPropertyByName(this, "bQuadPreserveTextureRatio", value); }
        }
        ///<summary>Size of the rendered stereo layer quad *</summary>
        public unsafe Vector2D QuadSize {
            get {return StereoLayerComponent_ptr->QuadSize;}
        }
        ///<summary>UV coordinates mapped to the quad face *</summary>
        public unsafe Box2D UVRect {
            get {return StereoLayerComponent_ptr->UVRect;}
        }
        ///<summary>Radial size of the rendered stereo layer cylinder *</summary>
        public unsafe float CylinderRadius {
            get {return StereoLayerComponent_ptr->CylinderRadius;}
        }
        ///<summary>Arc angle for the stereo layer cylinder *</summary>
        public unsafe float CylinderOverlayArc {
            get {return StereoLayerComponent_ptr->CylinderOverlayArc;}
        }
        ///<summary>Height of the stereo layer cylinder *</summary>
        public unsafe int CylinderHeight {
            get {return StereoLayerComponent_ptr->CylinderHeight;}
        }
        ///<summary>Specifies how and where the quad is rendered to the screen *</summary>
        public unsafe byte StereoLayerType {
            get {return StereoLayerComponent_ptr->StereoLayerType;}
        }
        ///<summary>Specifies which type of layer it is.  Note that some shapes will be supported only on certain platforms! *</summary>
        public unsafe byte StereoLayerShape {
            get {return StereoLayerComponent_ptr->StereoLayerShape;}
        }
        ///<summary>Render priority among all stereo layers, higher priority render on top of lower priority *</summary>
        public unsafe int Priority {
            get {return StereoLayerComponent_ptr->Priority;}
        }
        static StereoLayerComponent() {
            StaticClass = Main.GetClass("StereoLayerComponent");
        }
        internal unsafe StereoLayerComponent_fields* StereoLayerComponent_ptr => (StereoLayerComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator StereoLayerComponent(IntPtr p) => UObject.Make<StereoLayerComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static StereoLayerComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static StereoLayerComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

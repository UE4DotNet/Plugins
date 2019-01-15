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
using UE4.Engine;

namespace UE4.UMG {
    ///<summary>The widget component provides a surface in the 3D environment on which to render widgets normally rendered to the screen.</summary>
    ///<remarks>
    ///Widgets are first rendered to a render target, then that render target is displayed in the world.
    ///
    ///Material Properties set by this component on whatever material overrides the default.
    ///SlateUI [Texture]
    ///BackColor [Vector]
    ///TintColorAndOpacity [Vector]
    ///OpacityFromTexture [Scalar]
    ///</remarks>
    public unsafe partial class WidgetComponent : MeshComponent  {

        ///<summary>@return The draw size of the quad in the world</summary>
        public Vector2D GetDrawSize()  => 
            WidgetComponent_methods.GetDrawSize_method.Invoke(ObjPointer);

        ///<summary>@return The dynamic material instance used to render the user widget</summary>
        public MaterialInstanceDynamic GetMaterialInstance()  => 
            WidgetComponent_methods.GetMaterialInstance_method.Invoke(ObjPointer);

        ///<summary>Gets the local player that owns this widget component.</summary>
        public LocalPlayer GetOwnerPlayer()  => 
            WidgetComponent_methods.GetOwnerPlayer_method.Invoke(ObjPointer);

        ///<summary>@return The render target to which the user widget is rendered</summary>
        public TextureRenderTarget2D GetRenderTarget()  => 
            WidgetComponent_methods.GetRenderTarget_method.Invoke(ObjPointer);

        ///<summary>@return The user widget object displayed by this component</summary>
        public UserWidget GetUserWidgetObject()  => 
            WidgetComponent_methods.GetUserWidgetObject_method.Invoke(ObjPointer);

        ///<summary>Requests that the widget be redrawn.</summary>
        public void RequestRedraw()  => 
            WidgetComponent_methods.RequestRedraw_method.Invoke(ObjPointer);

        ///<summary>Sets the background color and opacityscale for this widget</summary>
        public void SetBackgroundColor(LinearColor NewBackgroundColor)  => 
            WidgetComponent_methods.SetBackgroundColor_method.Invoke(ObjPointer, NewBackgroundColor);

        ///<summary>Sets the draw size of the quad in the world</summary>
        public void SetDrawSize(Vector2D Size)  => 
            WidgetComponent_methods.SetDrawSize_method.Invoke(ObjPointer, Size);

        ///<summary>@see bManuallyRedraw</summary>
        public void SetManuallyRedraw(bool bUseManualRedraw)  => 
            WidgetComponent_methods.SetManuallyRedraw_method.Invoke(ObjPointer, bUseManualRedraw);

        ///<summary>Sets the local player that owns this widget component.</summary>
        ///<remarks>
        ///Setting the owning player controls
        ///which player's viewport the widget appears on in a split screen scenario.  Additionally it
        ///forwards the owning player to the actual UserWidget that is spawned.
        ///</remarks>
        public void SetOwnerPlayer(LocalPlayer LocalPlayer)  => 
            WidgetComponent_methods.SetOwnerPlayer_method.Invoke(ObjPointer, LocalPlayer);

        ///<summary>Sets the tint color and opacity scale for this widget</summary>
        public void SetTintColorAndOpacity(LinearColor NewTintColorAndOpacity)  => 
            WidgetComponent_methods.SetTintColorAndOpacity_method.Invoke(ObjPointer, NewTintColorAndOpacity);

        ///<summary>Sets the widget to use directly.</summary>
        ///<remarks>
        ///This function will keep track of the widget till the next time it's called
        ///    with either a newer widget or a nullptr
        ///</remarks>
        public void SetWidget(UserWidget Widget)  => 
            WidgetComponent_methods.SetWidget_method.Invoke(ObjPointer, Widget);
         //TODO: enum EWidgetSpace Space
         //TODO: enum EWidgetTimingPolicy TimingPolicy
        ///<summary>The class of User Widget to create and display an instance of</summary>
        public unsafe SubclassOf<UserWidget> WidgetClass {
            get {return WidgetComponent_ptr->WidgetClass;}
            set {WidgetComponent_ptr->WidgetClass = value;}
        }
        ///<summary>The size of the displayed quad.</summary>
        public unsafe IntPoint DrawSize {
            get {return WidgetComponent_ptr->DrawSize;}
            set {WidgetComponent_ptr->DrawSize = value;}
        }
        public bool bManuallyRedraw {
            get {return Main.GetGetBoolPropertyByName(this, "bManuallyRedraw"); }
            set {Main.SetGetBoolPropertyByName(this, "bManuallyRedraw", value); }
        }
        public bool bRedrawRequested {
            get {return Main.GetGetBoolPropertyByName(this, "bRedrawRequested"); }
            set {Main.SetGetBoolPropertyByName(this, "bRedrawRequested", value); }
        }
        ///<summary>The time in between draws, if 0 - we would redraw every frame.</summary>
        ///<remarks>
        ///If 1, we would redraw every second.
        ///This will work with bManuallyRedraw as well.  So you can say, manually redraw, but only redraw at this
        ///maximum rate.
        ///</remarks>
        public unsafe float RedrawTime {
            get {return WidgetComponent_ptr->RedrawTime;}
            set {WidgetComponent_ptr->RedrawTime = value;}
        }
        ///<summary>
        ///The actual draw size, this changes based on DrawSize - or the desired size of the widget if
        ///bDrawAtDesiredSize is true.
        ///</summary>
        public unsafe IntPoint CurrentDrawSize {
            get {return WidgetComponent_ptr->CurrentDrawSize;}
            set {WidgetComponent_ptr->CurrentDrawSize = value;}
        }
        public bool bDrawAtDesiredSize {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawAtDesiredSize"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawAtDesiredSize", value); }
        }
        ///<summary>The Alignment/Pivot point that the widget is placed at relative to the position.</summary>
        public unsafe Vector2D Pivot {
            get {return WidgetComponent_ptr->Pivot;}
            set {WidgetComponent_ptr->Pivot = value;}
        }
        public bool bReceiveHardwareInput {
            get {return Main.GetGetBoolPropertyByName(this, "bReceiveHardwareInput"); }
            set {Main.SetGetBoolPropertyByName(this, "bReceiveHardwareInput", value); }
        }
        public bool bWindowFocusable {
            get {return Main.GetGetBoolPropertyByName(this, "bWindowFocusable"); }
            set {Main.SetGetBoolPropertyByName(this, "bWindowFocusable", value); }
        }
        public bool bApplyGammaCorrection {
            get {return Main.GetGetBoolPropertyByName(this, "bApplyGammaCorrection"); }
            set {Main.SetGetBoolPropertyByName(this, "bApplyGammaCorrection", value); }
        }
        ///<summary>
        ///The owner player for a widget component, if this widget is drawn on the screen, this controls
        ///what player's screen it appears on for split screen, if not set, users player 0.
        ///</summary>
        public unsafe LocalPlayer OwnerPlayer {
            get {return WidgetComponent_ptr->OwnerPlayer;}
            set {WidgetComponent_ptr->OwnerPlayer = value;}
        }
        ///<summary>The background color of the component</summary>
        public unsafe LinearColor BackgroundColor {
            get {return WidgetComponent_ptr->BackgroundColor;}
            set {WidgetComponent_ptr->BackgroundColor = value;}
        }
        ///<summary>Tint color and opacity for this component</summary>
        public unsafe LinearColor TintColorAndOpacity {
            get {return WidgetComponent_ptr->TintColorAndOpacity;}
            set {WidgetComponent_ptr->TintColorAndOpacity = value;}
        }
        ///<summary>Sets the amount of opacity from the widget's UI texture to use when rendering the translucent or masked UI to the viewport (0.0-1.0)</summary>
        public unsafe float OpacityFromTexture {
            get {return WidgetComponent_ptr->OpacityFromTexture;}
            set {WidgetComponent_ptr->OpacityFromTexture = value;}
        }
         //TODO: enum EWidgetBlendMode BlendMode
        public bool bIsTwoSided {
            get {return Main.GetGetBoolPropertyByName(this, "bIsTwoSided"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsTwoSided", value); }
        }
        public bool TickWhenOffscreen {
            get {return Main.GetGetBoolPropertyByName(this, "TickWhenOffscreen"); }
            set {Main.SetGetBoolPropertyByName(this, "TickWhenOffscreen", value); }
        }
        ///<summary>The User Widget object displayed and managed by this component</summary>
        public unsafe UserWidget Widget {
            get {return WidgetComponent_ptr->Widget;}
            set {WidgetComponent_ptr->Widget = value;}
        }
        ///<summary>The body setup of the displayed quad</summary>
        public unsafe BodySetup BodySetup {
            get {return WidgetComponent_ptr->BodySetup;}
            set {WidgetComponent_ptr->BodySetup = value;}
        }
        ///<summary>The material instance for translucent widget components</summary>
        public unsafe MaterialInterface TranslucentMaterial {
            get {return WidgetComponent_ptr->TranslucentMaterial;}
            set {WidgetComponent_ptr->TranslucentMaterial = value;}
        }
        ///<summary>The material instance for translucent, one-sided widget components</summary>
        public unsafe MaterialInterface TranslucentMaterial_OneSided {
            get {return WidgetComponent_ptr->TranslucentMaterial_OneSided;}
            set {WidgetComponent_ptr->TranslucentMaterial_OneSided = value;}
        }
        ///<summary>The material instance for opaque widget components</summary>
        public unsafe MaterialInterface OpaqueMaterial {
            get {return WidgetComponent_ptr->OpaqueMaterial;}
            set {WidgetComponent_ptr->OpaqueMaterial = value;}
        }
        ///<summary>The material instance for opaque, one-sided widget components</summary>
        public unsafe MaterialInterface OpaqueMaterial_OneSided {
            get {return WidgetComponent_ptr->OpaqueMaterial_OneSided;}
            set {WidgetComponent_ptr->OpaqueMaterial_OneSided = value;}
        }
        ///<summary>The material instance for masked widget components.</summary>
        public unsafe MaterialInterface MaskedMaterial {
            get {return WidgetComponent_ptr->MaskedMaterial;}
            set {WidgetComponent_ptr->MaskedMaterial = value;}
        }
        ///<summary>The material instance for masked, one-sided widget components.</summary>
        public unsafe MaterialInterface MaskedMaterial_OneSided {
            get {return WidgetComponent_ptr->MaskedMaterial_OneSided;}
            set {WidgetComponent_ptr->MaskedMaterial_OneSided = value;}
        }
        ///<summary>The target to which the user widget is rendered</summary>
        public unsafe TextureRenderTarget2D RenderTarget {
            get {return WidgetComponent_ptr->RenderTarget;}
            set {WidgetComponent_ptr->RenderTarget = value;}
        }
        ///<summary>The dynamic instance of the material that the render target is attached to</summary>
        public unsafe MaterialInstanceDynamic MaterialInstance {
            get {return WidgetComponent_ptr->MaterialInstance;}
            set {WidgetComponent_ptr->MaterialInstance = value;}
        }
        public bool bAddedToScreen {
            get {return Main.GetGetBoolPropertyByName(this, "bAddedToScreen"); }
            set {Main.SetGetBoolPropertyByName(this, "bAddedToScreen", value); }
        }
        public bool bEditTimeUsable {
            get {return Main.GetGetBoolPropertyByName(this, "bEditTimeUsable"); }
            set {Main.SetGetBoolPropertyByName(this, "bEditTimeUsable", value); }
        }
        ///<summary>Layer Name the widget will live on</summary>
        public unsafe Name SharedLayerName {
            get {return WidgetComponent_ptr->SharedLayerName;}
            set {WidgetComponent_ptr->SharedLayerName = value;}
        }
        ///<summary>ZOrder the layer will be created on, note this only matters on the first time a new layer is created, subsequent additions to the same layer will use the initially defined ZOrder</summary>
        public unsafe int LayerZOrder {
            get {return WidgetComponent_ptr->LayerZOrder;}
            set {WidgetComponent_ptr->LayerZOrder = value;}
        }
         //TODO: enum EWidgetGeometryMode GeometryMode
        ///<summary>Curvature of a cylindrical widget in degrees.</summary>
        public unsafe float CylinderArcAngle {
            get {return WidgetComponent_ptr->CylinderArcAngle;}
            set {WidgetComponent_ptr->CylinderArcAngle = value;}
        }
        static WidgetComponent() {
            StaticClass = Main.GetClass("WidgetComponent");
        }
        internal unsafe WidgetComponent_fields* WidgetComponent_ptr => (WidgetComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WidgetComponent(IntPtr p) => UObject.Make<WidgetComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WidgetComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WidgetComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

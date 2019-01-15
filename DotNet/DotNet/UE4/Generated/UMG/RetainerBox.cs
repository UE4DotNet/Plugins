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
    ///<summary>
    ///The Retainer Box renders children widgets to a render target first before
    ///later rendering that render target to the screen.
    ///</summary>
    ///<remarks>
    ///This allows both frequency
    ///and phase to be controlled so that the UI can actually render less often than the
    ///frequency of the main game render.  It also has the side benefit of allow materials
    ///to be applied to the render target after drawing the widgets to apply a simple post process.
    ///
    ///* Single Child
    ///* Caching / Performance
    ///</remarks>
    public unsafe partial class RetainerBox : ContentWidget  {

        ///<summary>Get the current dynamic effect material applied to the retainer box.</summary>
        public MaterialInstanceDynamic GetEffectMaterial()  => 
            RetainerBox_methods.GetEffectMaterial_method.Invoke(ObjPointer);

        ///<summary>Requests the retainer redrawn the contents it has.</summary>
        public void RequestRender()  => 
            RetainerBox_methods.RequestRender_method.Invoke(ObjPointer);

        ///<summary>Set a new effect material to the retainer widget.</summary>
        public void SetEffectMaterial(MaterialInterface EffectMaterial)  => 
            RetainerBox_methods.SetEffectMaterial_method.Invoke(ObjPointer, EffectMaterial);

        ///<summary>Requests the retainer redrawn the contents it has.</summary>
        public void SetRenderingPhase(int RenderPhase, int TotalPhases)  => 
            RetainerBox_methods.SetRenderingPhase_method.Invoke(ObjPointer, RenderPhase, TotalPhases);

        ///<summary>Sets the name of the texture parameter to set the render target to on the material.</summary>
        public void SetTextureParameter(Name TextureParameter)  => 
            RetainerBox_methods.SetTextureParameter_method.Invoke(ObjPointer, TextureParameter);
        public bool RenderOnInvalidation {
            get {return Main.GetGetBoolPropertyByName(this, "RenderOnInvalidation"); }
        }
        public bool RenderOnPhase {
            get {return Main.GetGetBoolPropertyByName(this, "RenderOnPhase"); }
        }
        ///<summary>The Phase this widget will draw on.</summary>
        ///<remarks>
        ///If the Phase is 0, and the PhaseCount is 1, the widget will be drawn fresh every frame.
        ///If the Phase were 0, and the PhaseCount were 2, this retainer would draw a fresh frame every
        ///other frame.  So in a 60Hz game, the UI would render at 30Hz.
        ///</remarks>
        public unsafe int Phase {
            get {return RetainerBox_ptr->Phase;}
        }
        ///<summary>
        ///The PhaseCount controls how many phases are possible know what to modulus the current frame
        ///count by to determine if this is the current frame to draw the widget on.
        ///</summary>
        ///<remarks>
        ///If the Phase is 0, and the PhaseCount is 1, the widget will be drawn fresh every frame.
        ///If the Phase were 0, and the PhaseCount were 2, this retainer would draw a fresh frame every
        ///other frame.  So in a 60Hz game, the UI would render at 30Hz.
        ///</remarks>
        public unsafe int PhaseCount {
            get {return RetainerBox_ptr->PhaseCount;}
        }
        ///<summary>The effect to optionally apply to the render target.</summary>
        ///<remarks>
        ///We will set the texture sampler based on the name
        ///set in the @TextureParameter property.
        ///
        ///If you want to adjust transparency of the final image, make sure you set Blend Mode to AlphaComposite (Pre-Multiplied Alpha)
        ///and make sure to multiply the alpha you're apply across the surface to the color and the alpha of the render target, otherwise
        ///you won't see the expected color.
        ///</remarks>
        public unsafe MaterialInterface EffectMaterial {
            get {return RetainerBox_ptr->EffectMaterial;}
        }
        ///<summary>The texture sampler parameter of the @EffectMaterial, that we'll set to the render target.</summary>
        public unsafe Name TextureParameter {
            get {return RetainerBox_ptr->TextureParameter;}
        }
        static RetainerBox() {
            StaticClass = Main.GetClass("RetainerBox");
        }
        internal unsafe RetainerBox_fields* RetainerBox_ptr => (RetainerBox_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator RetainerBox(IntPtr p) => UObject.Make<RetainerBox>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static RetainerBox DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static RetainerBox New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

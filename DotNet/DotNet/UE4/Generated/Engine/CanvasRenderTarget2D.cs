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
    ///<summary>
    ///CanvasRenderTarget2D is 2D render target which exposes a Canvas interface to allow you to draw elements onto
    ///it directly.
    ///</summary>
    ///<remarks>
    ///Use CreateCanvasRenderTarget2D() to create a render target texture by unique name, then
    ///bind a function to the OnCanvasRenderTargetUpdate delegate which will be called when the render target is
    ///updated.  If you need to repaint your canvas every single frame, simply call UpdateResource() on it from a Tick
    ///function.  Also, remember to hold onto your new canvas render target with a reference so that it doesn't get
    ///garbage collected.
    ///</remarks>
    public unsafe partial class CanvasRenderTarget2D : TextureRenderTarget2D  {

        ///<summary>Allows a Blueprint to implement how this Canvas Render Target 2D should be updated.</summary>
        ///<remarks>
        ///@param       Canvas                          Canvas object that can be used to paint to the render target
        ///@param       Width                           Width of the render target.
        ///@param       Height                          Height of the render target.
        ///</remarks>
        public event ReceiveUpdate_delegate ReceiveUpdate;
        public delegate void ReceiveUpdate_delegate(Canvas Canvas, int Width, int Height);
        internal void on_ReceiveUpdate(Canvas Canvas, int Width, int Height) =>
            ReceiveUpdate?.Invoke(Canvas, Width, Height);


        ///<summary>
        ///Creates a new canvas render target and initializes it to the specified dimensions
        ///@
        ///</summary>
        ///<remarks>
        ///param       WorldContextObject      The world where this render target will be rendered for
        ///@param       CanvasRenderTarget2DClass       Class of the render target.  Unless you want to use a special sub-class, you can simply pass UCanvasRenderTarget2D::StaticClass() here.
        ///@param       Width                           Width of the render target.
        ///@param       Height                          Height of the render target.
        ///
        ///@return                                              Returns the instanced render target.
        ///</remarks>
        public static CanvasRenderTarget2D CreateCanvasRenderTarget2D(UObject WorldContextObject, SubclassOf<CanvasRenderTarget2D> CanvasRenderTarget2DClass, int Width, int Height)  => 
            CanvasRenderTarget2D_methods.CreateCanvasRenderTarget2D_method.Invoke(WorldContextObject, CanvasRenderTarget2DClass, Width, Height);

        ///<summary>Gets a specific render target's size from the global map of canvas render targets.</summary>
        ///<remarks>
        ///@param       Width   Output variable for the render target's width
        ///@param       Height  Output variable for the render target's height
        ///</remarks>
        public (int, int) GetSize()  => 
            CanvasRenderTarget2D_methods.GetSize_method.Invoke(ObjPointer);

        ///<summary>Updates the the canvas render target texture's resource.</summary>
        ///<remarks>
        ///This is where the render target will create or
        ///find a canvas object to use.  It also calls UpdateResourceImmediate() to clear the render target texture
        ///from the deferred rendering list, to stop the texture from being cleared the next frame. From there it
        ///will ask the rendering thread to set up the RHI viewport. The canvas is then set up for rendering and
        ///then the user's update delegate is called.  The canvas is then flushed and the RHI resolves the
        ///texture to make it available for rendering.
        ///</remarks>
        public void UpdateResource()  => 
            CanvasRenderTarget2D_methods.UpdateResource_method.Invoke(ObjPointer);
         //TODO: multicast delegate FOnCanvasRenderTargetUpdate OnCanvasRenderTargetUpdate
         //TODO: weak object TWeakObjectPtr<UWorld> World
        public bool bShouldClearRenderTargetOnReceiveUpdate {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldClearRenderTargetOnReceiveUpdate"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldClearRenderTargetOnReceiveUpdate", value); }
        }
        static CanvasRenderTarget2D() {
            StaticClass = Main.GetClass("CanvasRenderTarget2D");
            CanvasRenderTarget2D_events.ReceiveUpdate_event.Setup();
        }
        internal unsafe CanvasRenderTarget2D_fields* CanvasRenderTarget2D_ptr => (CanvasRenderTarget2D_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CanvasRenderTarget2D(IntPtr p) => UObject.Make<CanvasRenderTarget2D>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CanvasRenderTarget2D DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CanvasRenderTarget2D New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

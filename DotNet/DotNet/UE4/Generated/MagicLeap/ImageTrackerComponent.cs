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
using UE4.MagicLeap.Native;
using UE4.Engine;

namespace UE4.MagicLeap {
    ///<summary>
    ///The ImageTrackerComponent will keep track of whether the image that it has been provided is currently
    ///visible to the headset camera.
    ///</summary>
    ///<remarks>
    ///@note Currently only R8G8B8A8 and B8G8R8A8 textures are supported.
    ///</remarks>
    public unsafe partial class ImageTrackerComponent : SceneComponent  {

        ///<summary>Attempts to change the currently tracked target.</summary>
        ///<remarks>
        ///Initiates an asynchronous call on a worker thread.
        ///When the task completes, the instigating blueprint will be notified by either a FSetImageTargetSucceeded
        ///or FSetImageTargetFailed event.
        ///@param ImageTarget The new texture to be tracked.
        ///</remarks>
        public void SetTargetAsync(Texture2D ImageTarget)  => 
            ImageTrackerComponent_methods.SetTargetAsync_method.Invoke(ObjPointer, ImageTarget);
         //TODO: multicast delegate FSetImageTargetSucceeded OnSetImageTargetSucceeded
         //TODO: multicast delegate FSetImageTargetFailed OnSetImageTargetFailed
         //TODO: multicast delegate FImageTargetFound OnImageTargetFound
         //TODO: multicast delegate FImageTargetLost OnImageTargetLost
         //TODO: multicast delegate FImageTargetUnreliableTracking OnImageTargetUnreliableTracking
        ///<summary>The texture that will be tracked by this image tracker instance.</summary>
        public unsafe Texture2D TargetImageTexture {
            get {return ImageTrackerComponent_ptr->TargetImageTexture;}
            set {ImageTrackerComponent_ptr->TargetImageTexture = value;}
        }
         //TODO: string FString Name
        ///<summary>LongerDimension refers to the size of the longer dimension (width or height) of the physical image target in Unreal units.</summary>
        public unsafe float LongerDimension {
            get {return ImageTrackerComponent_ptr->LongerDimension;}
            set {ImageTrackerComponent_ptr->LongerDimension = value;}
        }
        public bool bIsStationary {
            get {return Main.GetGetBoolPropertyByName(this, "bIsStationary"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsStationary", value); }
        }
        public bool bUseUnreliablePose {
            get {return Main.GetGetBoolPropertyByName(this, "bUseUnreliablePose"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseUnreliablePose", value); }
        }
        static ImageTrackerComponent() {
            StaticClass = Main.GetClass("ImageTrackerComponent");
        }
        internal unsafe ImageTrackerComponent_fields* ImageTrackerComponent_ptr => (ImageTrackerComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ImageTrackerComponent(IntPtr p) => UObject.Make<ImageTrackerComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ImageTrackerComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ImageTrackerComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

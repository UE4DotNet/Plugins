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
using UE4.HeadMountedDisplay.Native;
using UE4.Engine;

namespace UE4.HeadMountedDisplay {
    ///<summary>Async Task Load XRDevice Vis Component</summary>
    public unsafe partial class AsyncTask_LoadXRDeviceVisComponent : BlueprintAsyncActionBase  {

        ///<summary>Add Device Visualization Component Async</summary>
        public static (PrimitiveComponent, AsyncTask_LoadXRDeviceVisComponent) AddDeviceVisualizationComponentAsync(Actor Target, XRDeviceId XRDeviceId, bool bManualAttachment, Transform RelativeTransform)  => 
            AsyncTask_LoadXRDeviceVisComponent_methods.AddDeviceVisualizationComponentAsync_method.Invoke(Target, XRDeviceId, bManualAttachment, RelativeTransform);

        ///<summary>Add Named Device Visualization Component Async</summary>
        public static (XRDeviceId, PrimitiveComponent, AsyncTask_LoadXRDeviceVisComponent) AddNamedDeviceVisualizationComponentAsync(Actor Target, Name SystemName, Name DeviceName, bool bManualAttachment, Transform RelativeTransform)  => 
            AsyncTask_LoadXRDeviceVisComponent_methods.AddNamedDeviceVisualizationComponentAsync_method.Invoke(Target, SystemName, DeviceName, bManualAttachment, RelativeTransform);
         //TODO: multicast delegate FDeviceModelLoadedDelegate OnModelLoaded
         //TODO: multicast delegate FDeviceModelLoadedDelegate OnLoadFailure
        ///<summary>Spawned Component</summary>
        public unsafe PrimitiveComponent SpawnedComponent {
            get {return AsyncTask_LoadXRDeviceVisComponent_ptr->SpawnedComponent;}
            set {AsyncTask_LoadXRDeviceVisComponent_ptr->SpawnedComponent = value;}
        }
        static AsyncTask_LoadXRDeviceVisComponent() {
            StaticClass = Main.GetClass("AsyncTask_LoadXRDeviceVisComponent");
        }
        internal unsafe AsyncTask_LoadXRDeviceVisComponent_fields* AsyncTask_LoadXRDeviceVisComponent_ptr => (AsyncTask_LoadXRDeviceVisComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AsyncTask_LoadXRDeviceVisComponent(IntPtr p) => UObject.Make<AsyncTask_LoadXRDeviceVisComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AsyncTask_LoadXRDeviceVisComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AsyncTask_LoadXRDeviceVisComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>UXRAssetFunctionLibrary</summary>
    public unsafe partial class XRAssetFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>Spawns a render component for the specified XR device.</summary>
        ///<remarks>
        ///NOTE: The associated XR system backend has to provide a model for this to
        ///      work - if one is not available for the specific device, then this
        ///      will fail and return an invalid (null) object.
        ///
        ///@param  Target                               The intended owner for the component to attach to.
        ///@param  XRDeviceId                   Specifies the device you're wanting a model for.
        ///@param  bManualAttachment    If set, will leave the component unattached (mirror's the same option on the generic AddComponent node). When unset the component will attach to the actor's root.
        ///@param  RelativeTransform    Specifies the component initial transform (relative to its attach parent).
        ///
        ///@return A new component representing the specified device (invalid/null if a model for the device doesn't exist).
        ///</remarks>
        public static PrimitiveComponent AddDeviceVisualizationComponentBlocking(Actor Target, XRDeviceId XRDeviceId, bool bManualAttachment, Transform RelativeTransform)  => 
            XRAssetFunctionLibrary_methods.AddDeviceVisualizationComponentBlocking_method.Invoke(Target, XRDeviceId, bManualAttachment, RelativeTransform);

        ///<summary>Spawns a render component for the specified XR device.</summary>
        ///<remarks>
        ///NOTE: The associated XR system backend has to provide a model for this to
        ///      work - if one is not available for the specific device, then this
        ///      will fail and return an invalid (null) object.
        ///
        ///@param  Target                               The intended owner for the component to attach to.
        ///@param  SystemName                   (optional) Targets a specific XR system (i.e. 'Oculus', 'SteamVR', etc.). If left as 'None', then the first system found that can render the device will be used.
        ///@param  DeviceName                   Source name of the specific device - expect the same names that the MotionControllerComponent's "MotionSource" field uses ('Left', 'Right', etc.).
        ///@param  bManualAttachment    If set, will leave the component unattached (mirror's the same option on the generic AddComponent node). When unset the component will attach to the actor's root.
        ///@param  RelativeTransform    Specifies the component initial transform (relative to its attach parent).
        ///
        ///@return A new component representing the specified device (invalid/null if a model for the device doesn't exist).
        ///</remarks>
        public static (XRDeviceId, PrimitiveComponent) AddNamedDeviceVisualizationComponentBlocking(Actor Target, Name SystemName, Name DeviceName, bool bManualAttachment, Transform RelativeTransform)  => 
            XRAssetFunctionLibrary_methods.AddNamedDeviceVisualizationComponentBlocking_method.Invoke(Target, SystemName, DeviceName, bManualAttachment, RelativeTransform);
        static XRAssetFunctionLibrary() {
            StaticClass = Main.GetClass("XRAssetFunctionLibrary");
        }
        internal unsafe XRAssetFunctionLibrary_fields* XRAssetFunctionLibrary_ptr => (XRAssetFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator XRAssetFunctionLibrary(IntPtr p) => UObject.Make<XRAssetFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static XRAssetFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static XRAssetFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

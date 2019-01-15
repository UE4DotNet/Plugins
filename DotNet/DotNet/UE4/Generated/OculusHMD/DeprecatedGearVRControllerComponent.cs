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
using UE4.OculusHMD.Native;
using UE4.Engine;
using UE4.HeadMountedDisplay;

namespace UE4.OculusHMD {
    ///<summary>DEPRECATED in 4.17 : This component (the GearVRController) is superfluous. It will be removed in a subsequent version. To emulate it, use a UStaticMeshComponent attached to a UMotionControllerComponent. The mesh used by this component can be found here: /OculusVR/Meshes/GearVRController.</summary>
    public unsafe partial class DeprecatedGearVRControllerComponent : SceneComponent  {

        ///<summary>Get Controller Mesh</summary>
        public StaticMeshComponent GetControllerMesh()  => 
            DeprecatedGearVRControllerComponent_methods.GetControllerMesh_method.Invoke(ObjPointer);

        ///<summary>Get Motion Controller</summary>
        public MotionControllerComponent GetMotionController()  => 
            DeprecatedGearVRControllerComponent_methods.GetMotionController_method.Invoke(ObjPointer);
        ///<summary>Controller Mesh</summary>
        public unsafe StaticMesh ControllerMesh {
            get {return DeprecatedGearVRControllerComponent_ptr->ControllerMesh;}
            set {DeprecatedGearVRControllerComponent_ptr->ControllerMesh = value;}
        }
        static DeprecatedGearVRControllerComponent() {
            StaticClass = Main.GetClass("DeprecatedGearVRControllerComponent");
        }
        internal unsafe DeprecatedGearVRControllerComponent_fields* DeprecatedGearVRControllerComponent_ptr => (DeprecatedGearVRControllerComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DeprecatedGearVRControllerComponent(IntPtr p) => UObject.Make<DeprecatedGearVRControllerComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DeprecatedGearVRControllerComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DeprecatedGearVRControllerComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
using UE4.SteamVRController.Native;
using UE4.Engine;

namespace UE4.SteamVRController {
    ///<summary>Steam VRController Library</summary>
    public unsafe partial class SteamVRControllerLibrary : BlueprintFunctionLibrary  {

        ///<summary>
        ///Sets which input events you want associated with the SteamVR controller's
        ///directional touchpad buttons - does so for both left and right controllers.
        ///</summary>
        ///<remarks>
        ///@param  NewMapping   Defines the set of input events you want associated with the four directional touchpad buttons.
        ///</remarks>
        public static void SetTouchDPadMapping(ESteamVRTouchDPadMapping NewMapping)  => 
            SteamVRControllerLibrary_methods.SetTouchDPadMapping_method.Invoke(NewMapping);
        static SteamVRControllerLibrary() {
            StaticClass = Main.GetClass("SteamVRControllerLibrary");
        }
        internal unsafe SteamVRControllerLibrary_fields* SteamVRControllerLibrary_ptr => (SteamVRControllerLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SteamVRControllerLibrary(IntPtr p) => UObject.Make<SteamVRControllerLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SteamVRControllerLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SteamVRControllerLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

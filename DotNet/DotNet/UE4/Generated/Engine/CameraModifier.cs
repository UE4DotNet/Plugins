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
    ///A CameraModifier is a base class for objects that may adjust the final camera properties after
    ///being computed by the APlayerCameraManager (@
    ///</summary>
    ///<remarks>
    ///see ModifyCamera). A CameraModifier
    ///can be stateful, and is associated uniquely with a specific APlayerCameraManager.
    ///</remarks>
    public unsafe partial class CameraModifier : UObject  {

        ///<summary>Called per tick that the modifier is active to allow Blueprinted modifiers to modify the camera's transform.</summary>
        ///<remarks>
        ///Scaling by Alpha happens after this in code, so no need to deal with that in the blueprint.
        ///@param       DeltaTime       Change in time since last update
        ///@param       ViewLocation            The current camera location.
        ///@param       ViewRotation            The current camera rotation.
        ///@param       FOV                                     The current camera fov.
        ///@param       NewViewLocation         (out) The modified camera location.
        ///@param       NewViewRotation         (out) The modified camera rotation.
        ///@param       NewFOV                          (out) The modified camera FOV.
        ///</remarks>
        public event BlueprintModifyCamera_delegate BlueprintModifyCamera;
        public delegate (Vector, Rotator, float) BlueprintModifyCamera_delegate(float DeltaTime, Vector ViewLocation, Rotator ViewRotation, float FOV, Vector NewViewLocation, Rotator NewViewRotation, float NewFOV);
        internal (Vector, Rotator, float) on_BlueprintModifyCamera(float DeltaTime, Vector ViewLocation, Rotator ViewRotation, float FOV, Vector NewViewLocation, Rotator NewViewRotation, float NewFOV) =>
            BlueprintModifyCamera != null ? BlueprintModifyCamera(DeltaTime, ViewLocation, ViewRotation, FOV, NewViewLocation, NewViewRotation, NewFOV) : (NewViewLocation, NewViewRotation, NewFOV);


        ///<summary>Called per tick that the modifier is active to allow Blueprinted modifiers to modify the camera's postprocess effects.</summary>
        ///<remarks>
        ///Scaling by Alpha happens after this in code, so no need to deal with that in the blueprint.
        ///@param       DeltaTime                               Change in time since last update
        ///@param       PostProcessBlendWeight  (out) Blend weight applied to the entire postprocess structure.
        ///@param       PostProcessSettings             (out) Post process structure defining what settings and values to override.
        ///</remarks>
        public event BlueprintModifyPostProcess_delegate BlueprintModifyPostProcess;
        public delegate (float, PostProcessSettings) BlueprintModifyPostProcess_delegate(float DeltaTime, float PostProcessBlendWeight, PostProcessSettings PostProcessSettings);
        internal (float, PostProcessSettings) on_BlueprintModifyPostProcess(float DeltaTime, float PostProcessBlendWeight, PostProcessSettings PostProcessSettings) =>
            BlueprintModifyPostProcess != null ? BlueprintModifyPostProcess(DeltaTime, PostProcessBlendWeight, PostProcessSettings) : (PostProcessBlendWeight, PostProcessSettings);


        ///<summary>Disables this modifier.</summary>
        ///<remarks>
        ///@param  bImmediate  - true to disable with no blend out, false (default) to allow blend out
        ///</remarks>
        public void DisableModifier(bool bImmediate)  => 
            CameraModifier_methods.DisableModifier_method.Invoke(ObjPointer, bImmediate);

        ///<summary>Enables this modifier.</summary>
        public void EnableModifier()  => 
            CameraModifier_methods.EnableModifier_method.Invoke(ObjPointer);

        ///<summary>@return Returns the actor the camera is currently viewing.</summary>
        public Actor GetViewTarget()  => 
            CameraModifier_methods.GetViewTarget_method.Invoke(ObjPointer);

        ///<summary>@return Returns true if modifier is disabled, false otherwise.</summary>
        public bool IsDisabled()  => 
            CameraModifier_methods.IsDisabled_method.Invoke(ObjPointer);
        public bool bDebug {
            get {return Main.GetGetBoolPropertyByName(this, "bDebug"); }
            set {Main.SetGetBoolPropertyByName(this, "bDebug", value); }
        }
        public bool bExclusive {
            get {return Main.GetGetBoolPropertyByName(this, "bExclusive"); }
        }
        ///<summary>Priority value that determines the order in which modifiers are applied. 0 = highest priority, 255 = lowest.</summary>
        public unsafe byte Priority {
            get {return CameraModifier_ptr->Priority;}
        }
        ///<summary>Camera this object is associated with.</summary>
        public unsafe PlayerCameraManager CameraOwner {
            get {return CameraModifier_ptr->CameraOwner;}
        }
        ///<summary>When blending in, alpha proceeds from 0 to 1 over this time</summary>
        public unsafe float AlphaInTime {
            get {return CameraModifier_ptr->AlphaInTime;}
        }
        ///<summary>When blending out, alpha proceeds from 1 to 0 over this time</summary>
        public unsafe float AlphaOutTime {
            get {return CameraModifier_ptr->AlphaOutTime;}
        }
        ///<summary>Current blend alpha.</summary>
        public unsafe float Alpha {
            get {return CameraModifier_ptr->Alpha;}
        }
        static CameraModifier() {
            StaticClass = Main.GetClass("CameraModifier");
            CameraModifier_events.BlueprintModifyCamera_event.Setup();
            CameraModifier_events.BlueprintModifyPostProcess_event.Setup();
        }
        internal unsafe CameraModifier_fields* CameraModifier_ptr => (CameraModifier_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CameraModifier(IntPtr p) => UObject.Make<CameraModifier>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CameraModifier DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CameraModifier New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

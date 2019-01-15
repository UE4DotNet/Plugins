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
using UE4.InputCore;
using UE4.Engine;

namespace UE4.HeadMountedDisplay {
    ///<summary>Motion Controller Component</summary>
    public unsafe partial class MotionControllerComponent : PrimitiveComponent  {

        ///<summary>Blueprint Implementable function for reponding to updated data from a motion controller (so we can use custom paramater values from it)</summary>
        public event OnMotionControllerUpdated_delegate OnMotionControllerUpdated;
        public delegate void OnMotionControllerUpdated_delegate();
        internal void on_OnMotionControllerUpdated() =>
            OnMotionControllerUpdated?.Invoke();


        ///<summary>Returns the value of a custom parameter on the current in use Motion Controller (see member InUseMotionController). Only valid for the duration of OnMotionControllerUpdated</summary>
        public (bool, float) GetParameterValue(Name InName)  => 
            MotionControllerComponent_methods.GetParameterValue_method.Invoke(ObjPointer, InName);

        ///<summary>Get Tracking Source</summary>
        public EControllerHand GetTrackingSource()  => 
            MotionControllerComponent_methods.GetTrackingSource_method.Invoke(ObjPointer);

        ///<summary>Whether or not this component had a valid tracked device this frame</summary>
        public bool IsTracked()  => 
            MotionControllerComponent_methods.IsTracked_method.Invoke(ObjPointer);

        ///<summary>Set Associated Player Index</summary>
        public void SetAssociatedPlayerIndex(int NewPlayer)  => 
            MotionControllerComponent_methods.SetAssociatedPlayerIndex_method.Invoke(ObjPointer, NewPlayer);

        ///<summary>Set Custom Display Mesh</summary>
        public void SetCustomDisplayMesh(StaticMesh NewDisplayMesh)  => 
            MotionControllerComponent_methods.SetCustomDisplayMesh_method.Invoke(ObjPointer, NewDisplayMesh);

        ///<summary>Set Display Model Source</summary>
        public void SetDisplayModelSource(Name NewDisplayModelSource)  => 
            MotionControllerComponent_methods.SetDisplayModelSource_method.Invoke(ObjPointer, NewDisplayModelSource);

        ///<summary>Set Show Device Model</summary>
        public void SetShowDeviceModel(bool bShowControllerModel)  => 
            MotionControllerComponent_methods.SetShowDeviceModel_method.Invoke(ObjPointer, bShowControllerModel);

        ///<summary>Set Tracking Motion Source</summary>
        public void SetTrackingMotionSource(Name NewSource)  => 
            MotionControllerComponent_methods.SetTrackingMotionSource_method.Invoke(ObjPointer, NewSource);

        ///<summary>Set Tracking Source</summary>
        public void SetTrackingSource(EControllerHand NewSource)  => 
            MotionControllerComponent_methods.SetTrackingSource_method.Invoke(ObjPointer, NewSource);
        ///<summary>Which player index this motion controller should automatically follow</summary>
        public unsafe int PlayerIndex {
            get {return MotionControllerComponent_ptr->PlayerIndex;}
            set {MotionControllerComponent_ptr->PlayerIndex = value;}
        }
        ///<summary>Motion Source</summary>
        public unsafe Name MotionSource {
            get {return MotionControllerComponent_ptr->MotionSource;}
            set {MotionControllerComponent_ptr->MotionSource = value;}
        }
        public bool bDisableLowLatencyUpdate {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableLowLatencyUpdate"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableLowLatencyUpdate", value); }
        }
         //TODO: enum ETrackingStatus CurrentTrackingStatus
        public bool bDisplayDeviceModel {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayDeviceModel"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayDeviceModel", value); }
        }
        ///<summary>Determines the source of the desired model. By default, the active XR system(s) will be queried and (if available) will provide a model for the associated device. NOTE: this may fail if there's no default model; use 'Custom' to specify your own.</summary>
        public unsafe Name DisplayModelSource {
            get {return MotionControllerComponent_ptr->DisplayModelSource;}
            set {MotionControllerComponent_ptr->DisplayModelSource = value;}
        }
        ///<summary>A mesh override that'll be displayed attached to this MotionController.</summary>
        public unsafe StaticMesh CustomDisplayMesh {
            get {return MotionControllerComponent_ptr->CustomDisplayMesh;}
            set {MotionControllerComponent_ptr->CustomDisplayMesh = value;}
        }
        ///<summary>Material overrides for the specified display mesh.</summary>
        public ObjectArrayField<MaterialInterface> DisplayMeshMaterialOverrides{ get {
            if(DisplayMeshMaterialOverrides_store == null) DisplayMeshMaterialOverrides_store = new ObjectArrayField<MaterialInterface> (&MotionControllerComponent_ptr->DisplayMeshMaterialOverrides);
            return DisplayMeshMaterialOverrides_store;
        } }
        private ObjectArrayField<MaterialInterface> DisplayMeshMaterialOverrides_store;

        ///<summary>Display Component</summary>
        public unsafe PrimitiveComponent DisplayComponent {
            get {return MotionControllerComponent_ptr->DisplayComponent;}
        }
        static MotionControllerComponent() {
            StaticClass = Main.GetClass("MotionControllerComponent");
            MotionControllerComponent_events.OnMotionControllerUpdated_event.Setup();
        }
        internal unsafe MotionControllerComponent_fields* MotionControllerComponent_ptr => (MotionControllerComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MotionControllerComponent(IntPtr p) => UObject.Make<MotionControllerComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MotionControllerComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MotionControllerComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

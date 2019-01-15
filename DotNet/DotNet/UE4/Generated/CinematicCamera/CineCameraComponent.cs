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
using UE4.CinematicCamera.Native;
using UE4.Engine;

namespace UE4.CinematicCamera {
    ///<summary>A specialized version of a camera component, geared toward cinematic usage.</summary>
    public unsafe partial class CineCameraComponent : CameraComponent  {

        ///<summary>Returns the filmback name of the camera with the current settings.</summary>
        public string GetFilmbackPresetName()  => 
            CineCameraComponent_methods.GetFilmbackPresetName_method.Invoke(ObjPointer);

        ///<summary>Returns the horizonal FOV of the camera with current settings.</summary>
        public float GetHorizontalFieldOfView()  => 
            CineCameraComponent_methods.GetHorizontalFieldOfView_method.Invoke(ObjPointer);

        ///<summary>Returns the lens name of the camera with the current settings.</summary>
        public string GetLensPresetName()  => 
            CineCameraComponent_methods.GetLensPresetName_method.Invoke(ObjPointer);

        ///<summary>Returns the vertical FOV of the camera with current settings.</summary>
        public float GetVerticalFieldOfView()  => 
            CineCameraComponent_methods.GetVerticalFieldOfView_method.Invoke(ObjPointer);

        ///<summary>Set the current preset settings by preset name.</summary>
        public void SetFilmbackPresetByName(string InPresetName)  => 
            CineCameraComponent_methods.SetFilmbackPresetByName_method.Invoke(ObjPointer, InPresetName);

        ///<summary>Set the current lens settings by preset name.</summary>
        public void SetLensPresetByName(string InPresetName)  => 
            CineCameraComponent_methods.SetLensPresetByName_method.Invoke(ObjPointer, InPresetName);
        ///<summary>Controls the filmback of the camera.</summary>
        public unsafe CameraFilmbackSettings FilmbackSettings {
            get {return CineCameraComponent_ptr->FilmbackSettings;}
            set {CineCameraComponent_ptr->FilmbackSettings = value;}
        }
        ///<summary>Controls the camera's lens.</summary>
        public unsafe CameraLensSettings LensSettings {
            get {return CineCameraComponent_ptr->LensSettings;}
            set {CineCameraComponent_ptr->LensSettings = value;}
        }
        ///<summary>Controls the camera's focus.</summary>
        public unsafe CameraFocusSettings FocusSettings {
            get {return CineCameraComponent_ptr->FocusSettings;}
            set {CineCameraComponent_ptr->FocusSettings = value;}
        }
        ///<summary>Current focal length of the camera (i.e. controls FoV, zoom)</summary>
        public unsafe float CurrentFocalLength {
            get {return CineCameraComponent_ptr->CurrentFocalLength;}
            set {CineCameraComponent_ptr->CurrentFocalLength = value;}
        }
        ///<summary>Current aperture, in terms of f-stop (e.g. 2.8 for f/2.8)</summary>
        public unsafe float CurrentAperture {
            get {return CineCameraComponent_ptr->CurrentAperture;}
            set {CineCameraComponent_ptr->CurrentAperture = value;}
        }
        ///<summary>Read-only. Control this value via FocusSettings.</summary>
        public unsafe float CurrentFocusDistance {
            get {return CineCameraComponent_ptr->CurrentFocusDistance;}
        }
        ///<summary>Read-only. Control this value with CurrentFocalLength (and filmback settings).</summary>
        public unsafe float CurrentHorizontalFOV {
            get {return CineCameraComponent_ptr->CurrentHorizontalFOV;}
            set {CineCameraComponent_ptr->CurrentHorizontalFOV = value;}
        }
        ///<summary>Mesh used for debug focus plane visualization</summary>
        public unsafe StaticMesh FocusPlaneVisualizationMesh {
            get {return CineCameraComponent_ptr->FocusPlaneVisualizationMesh;}
            set {CineCameraComponent_ptr->FocusPlaneVisualizationMesh = value;}
        }
        ///<summary>Material used for debug focus plane visualization</summary>
        public unsafe Material FocusPlaneVisualizationMaterial {
            get {return CineCameraComponent_ptr->FocusPlaneVisualizationMaterial;}
            set {CineCameraComponent_ptr->FocusPlaneVisualizationMaterial = value;}
        }
        ///<summary>Component for the debug focus plane visualization</summary>
        public unsafe StaticMeshComponent DebugFocusPlaneComponent {
            get {return CineCameraComponent_ptr->DebugFocusPlaneComponent;}
            set {CineCameraComponent_ptr->DebugFocusPlaneComponent = value;}
        }
        ///<summary>Dynamic material instance for the debug focus plane visualization</summary>
        public unsafe MaterialInstanceDynamic DebugFocusPlaneMID {
            get {return CineCameraComponent_ptr->DebugFocusPlaneMID;}
            set {CineCameraComponent_ptr->DebugFocusPlaneMID = value;}
        }
         //TODO: array not UObject TArray FilmbackPresets
         //TODO: array not UObject TArray LensPresets
         //TODO: string FString DefaultFilmbackPresetName
         //TODO: string FString DefaultLensPresetName
        ///<summary>Default focal length (will be constrained by default lens)</summary>
        public unsafe float DefaultLensFocalLength {
            get {return CineCameraComponent_ptr->DefaultLensFocalLength;}
            set {CineCameraComponent_ptr->DefaultLensFocalLength = value;}
        }
        ///<summary>Default aperture (will be constrained by default lens)</summary>
        public unsafe float DefaultLensFStop {
            get {return CineCameraComponent_ptr->DefaultLensFStop;}
            set {CineCameraComponent_ptr->DefaultLensFStop = value;}
        }
        static CineCameraComponent() {
            StaticClass = Main.GetClass("CineCameraComponent");
        }
        internal unsafe CineCameraComponent_fields* CineCameraComponent_ptr => (CineCameraComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CineCameraComponent(IntPtr p) => UObject.Make<CineCameraComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CineCameraComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CineCameraComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

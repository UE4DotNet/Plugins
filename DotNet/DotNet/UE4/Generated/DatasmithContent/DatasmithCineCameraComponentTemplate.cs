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
using UE4.DatasmithContent.Native;

namespace UE4.DatasmithContent {
    ///<summary>Datasmith Cine Camera Component Template</summary>
    public unsafe partial class DatasmithCineCameraComponentTemplate : DatasmithObjectTemplate  {
        ///<summary>Filmback Settings</summary>
        public unsafe DatasmithCameraFilmbackSettingsTemplate FilmbackSettings {
            get {return DatasmithCineCameraComponentTemplate_ptr->FilmbackSettings;}
            set {DatasmithCineCameraComponentTemplate_ptr->FilmbackSettings = value;}
        }
        ///<summary>Lens Settings</summary>
        public unsafe DatasmithCameraLensSettingsTemplate LensSettings {
            get {return DatasmithCineCameraComponentTemplate_ptr->LensSettings;}
            set {DatasmithCineCameraComponentTemplate_ptr->LensSettings = value;}
        }
        ///<summary>Focus Settings</summary>
        public unsafe DatasmithCameraFocusSettingsTemplate FocusSettings {
            get {return DatasmithCineCameraComponentTemplate_ptr->FocusSettings;}
            set {DatasmithCineCameraComponentTemplate_ptr->FocusSettings = value;}
        }
        ///<summary>Current Focal Length</summary>
        public unsafe float CurrentFocalLength {
            get {return DatasmithCineCameraComponentTemplate_ptr->CurrentFocalLength;}
            set {DatasmithCineCameraComponentTemplate_ptr->CurrentFocalLength = value;}
        }
        ///<summary>Current Aperture</summary>
        public unsafe float CurrentAperture {
            get {return DatasmithCineCameraComponentTemplate_ptr->CurrentAperture;}
            set {DatasmithCineCameraComponentTemplate_ptr->CurrentAperture = value;}
        }
        ///<summary>Post Process Settings</summary>
        public unsafe DatasmithPostProcessSettingsTemplate PostProcessSettings {
            get {return DatasmithCineCameraComponentTemplate_ptr->PostProcessSettings;}
            set {DatasmithCineCameraComponentTemplate_ptr->PostProcessSettings = value;}
        }
        static DatasmithCineCameraComponentTemplate() {
            StaticClass = Main.GetClass("DatasmithCineCameraComponentTemplate");
        }
        internal unsafe DatasmithCineCameraComponentTemplate_fields* DatasmithCineCameraComponentTemplate_ptr => (DatasmithCineCameraComponentTemplate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithCineCameraComponentTemplate(IntPtr p) => UObject.Make<DatasmithCineCameraComponentTemplate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithCineCameraComponentTemplate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithCineCameraComponentTemplate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

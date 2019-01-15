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
using UE4.Engine;

namespace UE4.DatasmithContent {
    ///<summary>Datasmith Light Component Template</summary>
    public unsafe partial class DatasmithLightComponentTemplate : DatasmithObjectTemplate  {
        public bool bVisible {
            get {return Main.GetGetBoolPropertyByName(this, "bVisible"); }
            set {Main.SetGetBoolPropertyByName(this, "bVisible", value); }
        }
        public bool CastShadows {
            get {return Main.GetGetBoolPropertyByName(this, "CastShadows"); }
            set {Main.SetGetBoolPropertyByName(this, "CastShadows", value); }
        }
        public bool bUseTemperature {
            get {return Main.GetGetBoolPropertyByName(this, "bUseTemperature"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseTemperature", value); }
        }
        public bool bUseIESBrightness {
            get {return Main.GetGetBoolPropertyByName(this, "bUseIESBrightness"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseIESBrightness", value); }
        }
        ///<summary>Intensity</summary>
        public unsafe float Intensity {
            get {return DatasmithLightComponentTemplate_ptr->Intensity;}
            set {DatasmithLightComponentTemplate_ptr->Intensity = value;}
        }
        ///<summary>Temperature</summary>
        public unsafe float Temperature {
            get {return DatasmithLightComponentTemplate_ptr->Temperature;}
            set {DatasmithLightComponentTemplate_ptr->Temperature = value;}
        }
        ///<summary>IESBrightness Scale</summary>
        public unsafe float IESBrightnessScale {
            get {return DatasmithLightComponentTemplate_ptr->IESBrightnessScale;}
            set {DatasmithLightComponentTemplate_ptr->IESBrightnessScale = value;}
        }
        ///<summary>Light Color</summary>
        public unsafe LinearColor LightColor {
            get {return DatasmithLightComponentTemplate_ptr->LightColor;}
            set {DatasmithLightComponentTemplate_ptr->LightColor = value;}
        }
        ///<summary>Light Function Material</summary>
        public unsafe MaterialInterface LightFunctionMaterial {
            get {return DatasmithLightComponentTemplate_ptr->LightFunctionMaterial;}
            set {DatasmithLightComponentTemplate_ptr->LightFunctionMaterial = value;}
        }
        ///<summary>IESTexture</summary>
        public unsafe TextureLightProfile IESTexture {
            get {return DatasmithLightComponentTemplate_ptr->IESTexture;}
            set {DatasmithLightComponentTemplate_ptr->IESTexture = value;}
        }
        static DatasmithLightComponentTemplate() {
            StaticClass = Main.GetClass("DatasmithLightComponentTemplate");
        }
        internal unsafe DatasmithLightComponentTemplate_fields* DatasmithLightComponentTemplate_ptr => (DatasmithLightComponentTemplate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithLightComponentTemplate(IntPtr p) => UObject.Make<DatasmithLightComponentTemplate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithLightComponentTemplate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithLightComponentTemplate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

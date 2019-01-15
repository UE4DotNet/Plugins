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
    ///<summary>Datasmith Point Light Component Template</summary>
    public unsafe partial class DatasmithPointLightComponentTemplate : DatasmithObjectTemplate  {
         //TODO: enum ELightUnits IntensityUnits
        ///<summary>Source Radius</summary>
        public unsafe float SourceRadius {
            get {return DatasmithPointLightComponentTemplate_ptr->SourceRadius;}
            set {DatasmithPointLightComponentTemplate_ptr->SourceRadius = value;}
        }
        ///<summary>Source Length</summary>
        public unsafe float SourceLength {
            get {return DatasmithPointLightComponentTemplate_ptr->SourceLength;}
            set {DatasmithPointLightComponentTemplate_ptr->SourceLength = value;}
        }
        ///<summary>Attenuation Radius</summary>
        public unsafe float AttenuationRadius {
            get {return DatasmithPointLightComponentTemplate_ptr->AttenuationRadius;}
            set {DatasmithPointLightComponentTemplate_ptr->AttenuationRadius = value;}
        }
        static DatasmithPointLightComponentTemplate() {
            StaticClass = Main.GetClass("DatasmithPointLightComponentTemplate");
        }
        internal unsafe DatasmithPointLightComponentTemplate_fields* DatasmithPointLightComponentTemplate_ptr => (DatasmithPointLightComponentTemplate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithPointLightComponentTemplate(IntPtr p) => UObject.Make<DatasmithPointLightComponentTemplate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithPointLightComponentTemplate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithPointLightComponentTemplate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

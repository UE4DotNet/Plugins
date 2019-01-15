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
    ///<summary>Datasmith Spot Light Component Template</summary>
    public unsafe partial class DatasmithSpotLightComponentTemplate : DatasmithObjectTemplate  {
        ///<summary>Inner Cone Angle</summary>
        public unsafe float InnerConeAngle {
            get {return DatasmithSpotLightComponentTemplate_ptr->InnerConeAngle;}
            set {DatasmithSpotLightComponentTemplate_ptr->InnerConeAngle = value;}
        }
        ///<summary>Outer Cone Angle</summary>
        public unsafe float OuterConeAngle {
            get {return DatasmithSpotLightComponentTemplate_ptr->OuterConeAngle;}
            set {DatasmithSpotLightComponentTemplate_ptr->OuterConeAngle = value;}
        }
        static DatasmithSpotLightComponentTemplate() {
            StaticClass = Main.GetClass("DatasmithSpotLightComponentTemplate");
        }
        internal unsafe DatasmithSpotLightComponentTemplate_fields* DatasmithSpotLightComponentTemplate_ptr => (DatasmithSpotLightComponentTemplate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithSpotLightComponentTemplate(IntPtr p) => UObject.Make<DatasmithSpotLightComponentTemplate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithSpotLightComponentTemplate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithSpotLightComponentTemplate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

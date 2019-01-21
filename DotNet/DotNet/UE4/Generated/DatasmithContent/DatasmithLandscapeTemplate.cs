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
    ///<summary>Datasmith Landscape Template</summary>
    public unsafe partial class DatasmithLandscapeTemplate : DatasmithObjectTemplate  {
        ///<summary>Landscape Material</summary>
        public unsafe MaterialInterface LandscapeMaterial {
            get {return DatasmithLandscapeTemplate_ptr->LandscapeMaterial;}
            set {DatasmithLandscapeTemplate_ptr->LandscapeMaterial = value;}
        }
        ///<summary>Static Lighting LOD</summary>
        public unsafe int StaticLightingLOD {
            get {return DatasmithLandscapeTemplate_ptr->StaticLightingLOD;}
            set {DatasmithLandscapeTemplate_ptr->StaticLightingLOD = value;}
        }
        static DatasmithLandscapeTemplate() {
            StaticClass = Main.GetClass("DatasmithLandscapeTemplate");
        }
        internal unsafe DatasmithLandscapeTemplate_fields* DatasmithLandscapeTemplate_ptr => (DatasmithLandscapeTemplate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithLandscapeTemplate(IntPtr p) => UObject.Make<DatasmithLandscapeTemplate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithLandscapeTemplate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithLandscapeTemplate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

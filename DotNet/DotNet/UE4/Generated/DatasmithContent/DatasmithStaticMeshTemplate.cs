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
    ///<summary>Datasmith Static Mesh Template</summary>
    public unsafe partial class DatasmithStaticMeshTemplate : DatasmithObjectTemplate  {
        ///<summary>Section Info Map</summary>
        public unsafe DatasmithMeshSectionInfoMapTemplate SectionInfoMap {
            get {return DatasmithStaticMeshTemplate_ptr->SectionInfoMap;}
            set {DatasmithStaticMeshTemplate_ptr->SectionInfoMap = value;}
        }
        ///<summary>Light Map Coordinate Index</summary>
        public unsafe int LightMapCoordinateIndex {
            get {return DatasmithStaticMeshTemplate_ptr->LightMapCoordinateIndex;}
            set {DatasmithStaticMeshTemplate_ptr->LightMapCoordinateIndex = value;}
        }
        ///<summary>Light Map Resolution</summary>
        public unsafe int LightMapResolution {
            get {return DatasmithStaticMeshTemplate_ptr->LightMapResolution;}
            set {DatasmithStaticMeshTemplate_ptr->LightMapResolution = value;}
        }
         //TODO: array not UObject TArray BuildSettings
         //TODO: array not UObject TArray StaticMaterials
        static DatasmithStaticMeshTemplate() {
            StaticClass = Main.GetClass("DatasmithStaticMeshTemplate");
        }
        internal unsafe DatasmithStaticMeshTemplate_fields* DatasmithStaticMeshTemplate_ptr => (DatasmithStaticMeshTemplate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithStaticMeshTemplate(IntPtr p) => UObject.Make<DatasmithStaticMeshTemplate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithStaticMeshTemplate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithStaticMeshTemplate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

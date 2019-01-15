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
    ///<summary>Datasmith Sky Light Component Template</summary>
    public unsafe partial class DatasmithSkyLightComponentTemplate : DatasmithObjectTemplate  {
        ///<summary>Source Type</summary>
        public unsafe byte SourceType {
            get {return DatasmithSkyLightComponentTemplate_ptr->SourceType;}
            set {DatasmithSkyLightComponentTemplate_ptr->SourceType = value;}
        }
        ///<summary>Cubemap Resolution</summary>
        public unsafe int CubemapResolution {
            get {return DatasmithSkyLightComponentTemplate_ptr->CubemapResolution;}
            set {DatasmithSkyLightComponentTemplate_ptr->CubemapResolution = value;}
        }
        ///<summary>Cubemap</summary>
        public unsafe TextureCube Cubemap {
            get {return DatasmithSkyLightComponentTemplate_ptr->Cubemap;}
            set {DatasmithSkyLightComponentTemplate_ptr->Cubemap = value;}
        }
        static DatasmithSkyLightComponentTemplate() {
            StaticClass = Main.GetClass("DatasmithSkyLightComponentTemplate");
        }
        internal unsafe DatasmithSkyLightComponentTemplate_fields* DatasmithSkyLightComponentTemplate_ptr => (DatasmithSkyLightComponentTemplate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithSkyLightComponentTemplate(IntPtr p) => UObject.Make<DatasmithSkyLightComponentTemplate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithSkyLightComponentTemplate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithSkyLightComponentTemplate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

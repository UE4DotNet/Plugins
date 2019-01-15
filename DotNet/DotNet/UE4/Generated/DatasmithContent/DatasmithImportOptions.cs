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
    ///<summary>Datasmith Import Options</summary>
    public unsafe partial class DatasmithImportOptions : UObject  {
         //TODO: enum EDatasmithImportSearchPackagePolicy SearchPackagePolicy
         //TODO: enum EDatasmithImportAssetConflictPolicy MaterialConflictPolicy
         //TODO: enum EDatasmithImportAssetConflictPolicy TextureConflictPolicy
         //TODO: enum EDatasmithImportActorPolicy StaticMeshActorImportPolicy
         //TODO: enum EDatasmithImportActorPolicy LightImportPolicy
         //TODO: enum EDatasmithImportActorPolicy CameraImportPolicy
         //TODO: enum EDatasmithImportActorPolicy OtherActorImportPolicy
         //TODO: enum EDatasmithImportMaterialQuality MaterialQuality
        ///<summary>Base Options</summary>
        public unsafe DatasmithImportBaseOptions BaseOptions {
            get {return DatasmithImportOptions_ptr->BaseOptions;}
            set {DatasmithImportOptions_ptr->BaseOptions = value;}
        }
        ///<summary>Tessellation Options</summary>
        public unsafe DatasmithTessellationOptions TessellationOptions {
            get {return DatasmithImportOptions_ptr->TessellationOptions;}
            set {DatasmithImportOptions_ptr->TessellationOptions = value;}
        }
        ///<summary>Options specific to the reimport process</summary>
        public unsafe DatasmithReimportOptions ReimportOptions {
            get {return DatasmithImportOptions_ptr->ReimportOptions;}
            set {DatasmithImportOptions_ptr->ReimportOptions = value;}
        }
        static DatasmithImportOptions() {
            StaticClass = Main.GetClass("DatasmithImportOptions");
        }
        internal unsafe DatasmithImportOptions_fields* DatasmithImportOptions_ptr => (DatasmithImportOptions_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithImportOptions(IntPtr p) => UObject.Make<DatasmithImportOptions>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithImportOptions DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithImportOptions New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

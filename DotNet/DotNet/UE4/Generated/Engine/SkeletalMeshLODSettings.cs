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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Skeletal Mesh LODSettings</summary>
    public unsafe partial class SkeletalMeshLODSettings : DataAsset  {
        ///<summary>Minimum LOD to render. Can be overridden per component as well as set here for all mesh instances here</summary>
        public unsafe PerPlatformInt MinLod {
            get {return SkeletalMeshLODSettings_ptr->MinLod;}
            set {SkeletalMeshLODSettings_ptr->MinLod = value;}
        }
         //TODO: array not UObject TArray LODGroups
        static SkeletalMeshLODSettings() {
            StaticClass = Main.GetClass("SkeletalMeshLODSettings");
        }
        internal unsafe SkeletalMeshLODSettings_fields* SkeletalMeshLODSettings_ptr => (SkeletalMeshLODSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SkeletalMeshLODSettings(IntPtr p) => UObject.Make<SkeletalMeshLODSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SkeletalMeshLODSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SkeletalMeshLODSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

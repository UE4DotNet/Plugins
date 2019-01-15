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
using UE4.StatsViewer.Native;

namespace UE4.StatsViewer {
    ///<summary>Statistics page for lighting.</summary>
    public unsafe partial class LightingBuildInfo : UObject  {
         //TODO: weak object TWeakObjectPtr<UObject> UObject
        ///<summary>The lighting time this object took.</summary>
        public unsafe float LightingTime {
            get {return LightingBuildInfo_ptr->LightingTime;}
            set {LightingBuildInfo_ptr->LightingTime = value;}
        }
        ///<summary>The percentage of unmapped texels for this object.</summary>
        public unsafe float UnmappedTexelsPercentage {
            get {return LightingBuildInfo_ptr->UnmappedTexelsPercentage;}
            set {LightingBuildInfo_ptr->UnmappedTexelsPercentage = value;}
        }
        ///<summary>The memory consumed by unmapped texels for this object, in KB</summary>
        public unsafe float UnmappedTexelsMemory {
            get {return LightingBuildInfo_ptr->UnmappedTexelsMemory;}
            set {LightingBuildInfo_ptr->UnmappedTexelsMemory = value;}
        }
        ///<summary>The memory consumed by all texels for this object, in KB</summary>
        public unsafe float TotalTexelMemory {
            get {return LightingBuildInfo_ptr->TotalTexelMemory;}
            set {LightingBuildInfo_ptr->TotalTexelMemory = value;}
        }
         //TODO: string FString LevelName
        static LightingBuildInfo() {
            StaticClass = Main.GetClass("LightingBuildInfo");
        }
        internal unsafe LightingBuildInfo_fields* LightingBuildInfo_ptr => (LightingBuildInfo_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LightingBuildInfo(IntPtr p) => UObject.Make<LightingBuildInfo>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LightingBuildInfo DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LightingBuildInfo New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

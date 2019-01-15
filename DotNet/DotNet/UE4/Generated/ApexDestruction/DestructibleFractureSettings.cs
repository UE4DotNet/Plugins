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
using UE4.ApexDestruction.Native;

namespace UE4.ApexDestruction {
    ///<summary>Information to create an NxDestructibleAsset</summary>
    public unsafe partial class DestructibleFractureSettings : UObject  {
        ///<summary>The number of voronoi cell sites.</summary>
        public unsafe int CellSiteCount {
            get {return DestructibleFractureSettings_ptr->CellSiteCount;}
            set {DestructibleFractureSettings_ptr->CellSiteCount = value;}
        }
        ///<summary>Stored interior material data.  Just need one as we only support Voronoi splitting.</summary>
        public unsafe FractureMaterial FractureMaterialDesc {
            get {return DestructibleFractureSettings_ptr->FractureMaterialDesc;}
            set {DestructibleFractureSettings_ptr->FractureMaterialDesc = value;}
        }
        ///<summary>Random seed for reproducibility</summary>
        public unsafe int RandomSeed {
            get {return DestructibleFractureSettings_ptr->RandomSeed;}
            set {DestructibleFractureSettings_ptr->RandomSeed = value;}
        }
         //TODO: array TArray VoronoiSites
        ///<summary>The mesh's original number of submeshes.  APEX needs to store this in the authoring.</summary>
        public unsafe int OriginalSubmeshCount {
            get {return DestructibleFractureSettings_ptr->OriginalSubmeshCount;}
            set {DestructibleFractureSettings_ptr->OriginalSubmeshCount = value;}
        }
         //TODO: array TArray Materials
         //TODO: array TArray ChunkParameters
        static DestructibleFractureSettings() {
            StaticClass = Main.GetClass("DestructibleFractureSettings");
        }
        internal unsafe DestructibleFractureSettings_fields* DestructibleFractureSettings_ptr => (DestructibleFractureSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DestructibleFractureSettings(IntPtr p) => UObject.Make<DestructibleFractureSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DestructibleFractureSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DestructibleFractureSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
using UE4.SpeedTreeImporter.Native;
using UE4.Engine;

namespace UE4.SpeedTreeImporter {
    ///<summary>Speed Tree Import Data</summary>
    public unsafe partial class SpeedTreeImportData : AssetImportData  {
        ///<summary>Specify the tree scale</summary>
        public unsafe float TreeScale {
            get {return SpeedTreeImportData_ptr->TreeScale;}
            set {SpeedTreeImportData_ptr->TreeScale = value;}
        }
        ///<summary>Choose weather to import as a 3D asset, billboard or both</summary>
        public unsafe byte ImportGeometryType {
            get {return SpeedTreeImportData_ptr->ImportGeometryType;}
            set {SpeedTreeImportData_ptr->ImportGeometryType = value;}
        }
        ///<summary>Choose weather painted foliage or individual actor</summary>
        public unsafe byte LODType {
            get {return SpeedTreeImportData_ptr->LODType;}
            set {SpeedTreeImportData_ptr->LODType = value;}
        }
        public bool IncludeCollision {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeCollision"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeCollision", value); }
        }
        public bool MakeMaterialsCheck {
            get {return Main.GetGetBoolPropertyByName(this, "MakeMaterialsCheck"); }
            set {Main.SetGetBoolPropertyByName(this, "MakeMaterialsCheck", value); }
        }
        public bool IncludeNormalMapCheck {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeNormalMapCheck"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeNormalMapCheck", value); }
        }
        public bool IncludeDetailMapCheck {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeDetailMapCheck"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeDetailMapCheck", value); }
        }
        public bool IncludeSpecularMapCheck {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeSpecularMapCheck"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeSpecularMapCheck", value); }
        }
        public bool IncludeBranchSeamSmoothing {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeBranchSeamSmoothing"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeBranchSeamSmoothing", value); }
        }
        public bool IncludeSpeedTreeAO {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeSpeedTreeAO"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeSpeedTreeAO", value); }
        }
        public bool IncludeColorAdjustment {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeColorAdjustment"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeColorAdjustment", value); }
        }
        public bool IncludeSubsurface {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeSubsurface"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeSubsurface", value); }
        }
        public bool IncludeVertexProcessingCheck {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeVertexProcessingCheck"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeVertexProcessingCheck", value); }
        }
        public bool IncludeWindCheck {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeWindCheck"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeWindCheck", value); }
        }
        public bool IncludeSmoothLODCheck {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeSmoothLODCheck"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeSmoothLODCheck", value); }
        }
        static SpeedTreeImportData() {
            StaticClass = Main.GetClass("SpeedTreeImportData");
        }
        internal unsafe SpeedTreeImportData_fields* SpeedTreeImportData_ptr => (SpeedTreeImportData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SpeedTreeImportData(IntPtr p) => UObject.Make<SpeedTreeImportData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SpeedTreeImportData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SpeedTreeImportData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>Fbx Export Option</summary>
    public unsafe partial class FbxExportOption : UObject  {
         //TODO: enum EFbxExportCompatibility FbxExportCompatibility
        public bool bASCII {
            get {return Main.GetGetBoolPropertyByName(this, "bASCII"); }
            set {Main.SetGetBoolPropertyByName(this, "bASCII", value); }
        }
        public bool bForceFrontXAxis {
            get {return Main.GetGetBoolPropertyByName(this, "bForceFrontXAxis"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceFrontXAxis", value); }
        }
        public bool VertexColor {
            get {return Main.GetGetBoolPropertyByName(this, "VertexColor"); }
            set {Main.SetGetBoolPropertyByName(this, "VertexColor", value); }
        }
        public bool LevelOfDetail {
            get {return Main.GetGetBoolPropertyByName(this, "LevelOfDetail"); }
            set {Main.SetGetBoolPropertyByName(this, "LevelOfDetail", value); }
        }
        public bool Collision {
            get {return Main.GetGetBoolPropertyByName(this, "Collision"); }
            set {Main.SetGetBoolPropertyByName(this, "Collision", value); }
        }
        public bool MapSkeletalMotionToRoot {
            get {return Main.GetGetBoolPropertyByName(this, "MapSkeletalMotionToRoot"); }
            set {Main.SetGetBoolPropertyByName(this, "MapSkeletalMotionToRoot", value); }
        }
        static FbxExportOption() {
            StaticClass = Main.GetClass("FbxExportOption");
        }
        internal unsafe FbxExportOption_fields* FbxExportOption_ptr => (FbxExportOption_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FbxExportOption(IntPtr p) => UObject.Make<FbxExportOption>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FbxExportOption DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FbxExportOption New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

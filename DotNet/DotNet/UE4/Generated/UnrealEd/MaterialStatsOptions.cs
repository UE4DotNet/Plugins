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
    ///<summary>Material Stats Options</summary>
    public unsafe partial class MaterialStatsOptions : UObject  {
        ///<summary>B Platform Used</summary>
        public unsafe int bPlatformUsed {
            get {return MaterialStatsOptions_ptr->bPlatformUsed;}
            set {MaterialStatsOptions_ptr->bPlatformUsed = value;}
        }
        ///<summary>B Material Quality Used</summary>
        public unsafe int bMaterialQualityUsed {
            get {return MaterialStatsOptions_ptr->bMaterialQualityUsed;}
            set {MaterialStatsOptions_ptr->bMaterialQualityUsed = value;}
        }
        static MaterialStatsOptions() {
            StaticClass = Main.GetClass("MaterialStatsOptions");
        }
        internal unsafe MaterialStatsOptions_fields* MaterialStatsOptions_ptr => (MaterialStatsOptions_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialStatsOptions(IntPtr p) => UObject.Make<MaterialStatsOptions>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialStatsOptions DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialStatsOptions New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

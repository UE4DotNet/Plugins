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
    ///<summary>Statistics for a cooked asset.</summary>
    ///<remarks>Note: We assume that asset files are not larger than 2GB, because the StatsViewer is still lacking int64 support.</remarks>
    public unsafe partial class CookerStats : UObject  {
         //TODO: array not UObject TArray Assets
        ///<summary>The size of the assets before cooking.</summary>
        public unsafe float SizeBefore {
            get {return CookerStats_ptr->SizeBefore;}
            set {CookerStats_ptr->SizeBefore = value;}
        }
        ///<summary>The size of the assets after cooking.</summary>
        public unsafe float SizeAfter {
            get {return CookerStats_ptr->SizeAfter;}
            set {CookerStats_ptr->SizeAfter = value;}
        }
         //TODO: string FString Path
        static CookerStats() {
            StaticClass = Main.GetClass("CookerStats");
        }
        internal unsafe CookerStats_fields* CookerStats_ptr => (CookerStats_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CookerStats(IntPtr p) => UObject.Make<CookerStats>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CookerStats DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CookerStats New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

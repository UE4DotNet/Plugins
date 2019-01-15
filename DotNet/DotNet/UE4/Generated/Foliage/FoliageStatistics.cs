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
using UE4.Foliage.Native;
using UE4.Engine;

namespace UE4.Foliage {
    ///<summary>Foliage Statistics</summary>
    public unsafe partial class FoliageStatistics : BlueprintFunctionLibrary  {

        ///<summary>
        ///Gets the number of instances overlapping a provided box
        ///@
        ///</summary>
        ///<remarks>
        ///param StaticMesh Mesh to count
        ///@param Box Box to overlap
        ///</remarks>
        public static int FoliageOverlappingBoxCount(UObject WorldContextObject, StaticMesh StaticMesh, Box Box)  => 
            FoliageStatistics_methods.FoliageOverlappingBoxCount_method.Invoke(WorldContextObject, StaticMesh, Box);

        ///<summary>
        ///Counts how many foliage instances overlap a given sphere
        ///@
        ///</summary>
        ///<remarks>
        ///param        Mesh                    The static mesh we are interested in counting
        ///@param        CenterPosition  The center position of the sphere
        ///@param        Radius                  The radius of the sphere.
        ///
        ///return number of foliage instances with their mesh set to Mesh that overlap the sphere
        ///</remarks>
        public static int FoliageOverlappingSphereCount(UObject WorldContextObject, StaticMesh StaticMesh, Vector CenterPosition, float Radius)  => 
            FoliageStatistics_methods.FoliageOverlappingSphereCount_method.Invoke(WorldContextObject, StaticMesh, CenterPosition, Radius);
        static FoliageStatistics() {
            StaticClass = Main.GetClass("FoliageStatistics");
        }
        internal unsafe FoliageStatistics_fields* FoliageStatistics_ptr => (FoliageStatistics_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FoliageStatistics(IntPtr p) => UObject.Make<FoliageStatistics>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FoliageStatistics DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FoliageStatistics New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

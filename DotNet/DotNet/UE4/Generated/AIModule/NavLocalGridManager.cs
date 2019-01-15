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
using UE4.AIModule.Native;

namespace UE4.AIModule {
    ///<summary>
    ///Manager for local navigation grids
    ///Builds non overlapping grid from multiple sources, that can be used later for pathfinding.
    ///</summary>
    ///<remarks>Check also: UGridPathFollowingComponent, FNavLocalGridData</remarks>
    public unsafe partial class NavLocalGridManager : UObject  {

        ///<summary>Add Local Navigation Grid for Box</summary>
        public static int AddLocalNavigationGridForBox(UObject WorldContextObject, Vector Location, Vector Extent, Rotator Rotation, int Radius2D, float Height, bool bRebuildGrids)  => 
            NavLocalGridManager_methods.AddLocalNavigationGridForBox_method.Invoke(WorldContextObject, Location, Extent, Rotation, Radius2D, Height, bRebuildGrids);

        ///<summary>Add Local Navigation Grid for Capsule</summary>
        public static int AddLocalNavigationGridForCapsule(UObject WorldContextObject, Vector Location, float CapsuleRadius, float CapsuleHalfHeight, int Radius2D, float Height, bool bRebuildGrids)  => 
            NavLocalGridManager_methods.AddLocalNavigationGridForCapsule_method.Invoke(WorldContextObject, Location, CapsuleRadius, CapsuleHalfHeight, Radius2D, Height, bRebuildGrids);

        ///<summary>creates new grid data for single point</summary>
        public static int AddLocalNavigationGridForPoint(UObject WorldContextObject, Vector Location, int Radius2D, float Height, bool bRebuildGrids)  => 
            NavLocalGridManager_methods.AddLocalNavigationGridForPoint_method.Invoke(WorldContextObject, Location, Radius2D, Height, bRebuildGrids);

        ///<summary>creates single grid data for set of points</summary>
        public static int AddLocalNavigationGridForPoints(UObject WorldContextObject, byte Locations /*TODO: array TArray */, int Radius2D, float Height, bool bRebuildGrids)  => 
            NavLocalGridManager_methods.AddLocalNavigationGridForPoints_method.Invoke(WorldContextObject, Locations, Radius2D, Height, bRebuildGrids);

        ///<summary>Find Local Navigation Grid Path</summary>
        public static (IReadOnlyCollection<Vector>, bool) FindLocalNavigationGridPath(UObject WorldContextObject, Vector Start, Vector End)  => 
            NavLocalGridManager_methods.FindLocalNavigationGridPath_method.Invoke(WorldContextObject, Start, End);

        ///<summary>Remove Local Navigation Grid</summary>
        public static void RemoveLocalNavigationGrid(UObject WorldContextObject, int GridId, bool bRebuildGrids)  => 
            NavLocalGridManager_methods.RemoveLocalNavigationGrid_method.Invoke(WorldContextObject, GridId, bRebuildGrids);

        ///<summary>Set Local Navigation Grid Density</summary>
        public static bool SetLocalNavigationGridDensity(UObject WorldContextObject, float CellSize)  => 
            NavLocalGridManager_methods.SetLocalNavigationGridDensity_method.Invoke(WorldContextObject, CellSize);
        static NavLocalGridManager() {
            StaticClass = Main.GetClass("NavLocalGridManager");
        }
        internal unsafe NavLocalGridManager_fields* NavLocalGridManager_ptr => (NavLocalGridManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavLocalGridManager(IntPtr p) => UObject.Make<NavLocalGridManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavLocalGridManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavLocalGridManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///Path following augmented with local navigation grids
    ///Keeps track of nearby grids and use them instead of navigation path when agent is inside.
    ///</summary>
    ///<remarks>
    ///Once outside grid, regular path following is resumed.
    ///
    ///This allows creating dynamic navigation obstacles with fully static navigation (e.g. static navmesh),
    ///as long as they are minor modifications for path. Not recommended for blocking off entire corridors.
    ///
    ///Does not replace proper avoidance for dynamic obstacles!
    ///</remarks>
    public unsafe partial class GridPathFollowingComponent : PathFollowingComponent  {
        ///<summary>Grid Manager</summary>
        public unsafe NavLocalGridManager GridManager {
            get {return GridPathFollowingComponent_ptr->GridManager;}
            set {GridPathFollowingComponent_ptr->GridManager = value;}
        }
        static GridPathFollowingComponent() {
            StaticClass = Main.GetClass("GridPathFollowingComponent");
        }
        internal unsafe GridPathFollowingComponent_fields* GridPathFollowingComponent_ptr => (GridPathFollowingComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GridPathFollowingComponent(IntPtr p) => UObject.Make<GridPathFollowingComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GridPathFollowingComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GridPathFollowingComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

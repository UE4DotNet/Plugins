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
    ///<summary>
    ///WorldComposition represents world structure:
    ///    - Holds list of all level packages participating in this world and theirs base parameters (bounding boxes, offset from origin)
    ///    - Holds list of streaming level objects to stream in and out based on distance from current view point
    ///</summary>
    ///<remarks>- Handles properly levels repositioning during level loading and saving</remarks>
    public unsafe partial class WorldComposition : UObject  {
        ///<summary>Streaming level objects for each tile</summary>
        public ObjectArrayField<LevelStreaming> TilesStreaming{ get {
            if(TilesStreaming_store == null) TilesStreaming_store = new ObjectArrayField<LevelStreaming> (&WorldComposition_ptr->TilesStreaming);
            return TilesStreaming_store;
        } }
        private ObjectArrayField<LevelStreaming> TilesStreaming_store;

        ///<summary>Time threshold between tile streaming state changes</summary>
        public unsafe double TilesStreamingTimeThreshold {
            get {return WorldComposition_ptr->TilesStreamingTimeThreshold;}
            set {WorldComposition_ptr->TilesStreamingTimeThreshold = value;}
        }
        public bool bLoadAllTilesDuringCinematic {
            get {return Main.GetGetBoolPropertyByName(this, "bLoadAllTilesDuringCinematic"); }
            set {Main.SetGetBoolPropertyByName(this, "bLoadAllTilesDuringCinematic", value); }
        }
        public bool bRebaseOriginIn3DSpace {
            get {return Main.GetGetBoolPropertyByName(this, "bRebaseOriginIn3DSpace"); }
            set {Main.SetGetBoolPropertyByName(this, "bRebaseOriginIn3DSpace", value); }
        }
        public bool bLockTilesLocation {
            get {return Main.GetGetBoolPropertyByName(this, "bLockTilesLocation"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockTilesLocation", value); }
        }
        ///<summary>Maximum distance to current view point where we should initiate origin rebasing</summary>
        public unsafe float RebaseOriginDistance {
            get {return WorldComposition_ptr->RebaseOriginDistance;}
            set {WorldComposition_ptr->RebaseOriginDistance = value;}
        }
        static WorldComposition() {
            StaticClass = Main.GetClass("WorldComposition");
        }
        internal unsafe WorldComposition_fields* WorldComposition_ptr => (WorldComposition_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WorldComposition(IntPtr p) => UObject.Make<WorldComposition>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WorldComposition DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WorldComposition New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

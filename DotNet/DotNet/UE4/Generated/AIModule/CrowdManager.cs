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
using UE4.NavigationSystem;

namespace UE4.AIModule {
    ///<summary>Crowd Manager</summary>
    public unsafe partial class CrowdManager : CrowdManagerBase  {
        ///<summary>My Nav Data</summary>
        public unsafe NavigationData MyNavData {
            get {return CrowdManager_ptr->MyNavData;}
            set {CrowdManager_ptr->MyNavData = value;}
        }
         //TODO: array not UObject TArray AvoidanceConfig
         //TODO: array not UObject TArray SamplingPatterns
        ///<summary>max number of agents supported by crowd</summary>
        public unsafe int MaxAgents {
            get {return CrowdManager_ptr->MaxAgents;}
            set {CrowdManager_ptr->MaxAgents = value;}
        }
        ///<summary>max radius of agent that can be added to crowd</summary>
        public unsafe float MaxAgentRadius {
            get {return CrowdManager_ptr->MaxAgentRadius;}
            set {CrowdManager_ptr->MaxAgentRadius = value;}
        }
        ///<summary>max number of neighbor agents for velocity avoidance</summary>
        public unsafe int MaxAvoidedAgents {
            get {return CrowdManager_ptr->MaxAvoidedAgents;}
            set {CrowdManager_ptr->MaxAvoidedAgents = value;}
        }
        ///<summary>max number of wall segments for velocity avoidance</summary>
        public unsafe int MaxAvoidedWalls {
            get {return CrowdManager_ptr->MaxAvoidedWalls;}
            set {CrowdManager_ptr->MaxAvoidedWalls = value;}
        }
        ///<summary>how often should agents check their position after moving off navmesh?</summary>
        public unsafe float NavmeshCheckInterval {
            get {return CrowdManager_ptr->NavmeshCheckInterval;}
            set {CrowdManager_ptr->NavmeshCheckInterval = value;}
        }
        ///<summary>how often should agents try to optimize their paths?</summary>
        public unsafe float PathOptimizationInterval {
            get {return CrowdManager_ptr->PathOptimizationInterval;}
            set {CrowdManager_ptr->PathOptimizationInterval = value;}
        }
        ///<summary>clamp separation force to left/right when neighbor is behind (dot between forward and dirToNei, -1 = disabled)</summary>
        public unsafe float SeparationDirClamp {
            get {return CrowdManager_ptr->SeparationDirClamp;}
            set {CrowdManager_ptr->SeparationDirClamp = value;}
        }
        ///<summary>agent radius multiplier for offsetting path around corners</summary>
        public unsafe float PathOffsetRadiusMultiplier {
            get {return CrowdManager_ptr->PathOffsetRadiusMultiplier;}
            set {CrowdManager_ptr->PathOffsetRadiusMultiplier = value;}
        }
        public bool bResolveCollisions {
            get {return Main.GetGetBoolPropertyByName(this, "bResolveCollisions"); }
            set {Main.SetGetBoolPropertyByName(this, "bResolveCollisions", value); }
        }
        static CrowdManager() {
            StaticClass = Main.GetClass("CrowdManager");
        }
        internal unsafe CrowdManager_fields* CrowdManager_ptr => (CrowdManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CrowdManager(IntPtr p) => UObject.Make<CrowdManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CrowdManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CrowdManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

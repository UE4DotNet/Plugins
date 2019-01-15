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
using UE4.NavigationSystem.Native;
using UE4.Engine;

namespace UE4.NavigationSystem {
    ///<summary>Nav Mesh Bounds Volume</summary>
    public unsafe partial class NavMeshBoundsVolume : Volume  {
        ///<summary>Supported Agents</summary>
        public unsafe NavAgentSelector SupportedAgents {
            get {return NavMeshBoundsVolume_ptr->SupportedAgents;}
            set {NavMeshBoundsVolume_ptr->SupportedAgents = value;}
        }
        static NavMeshBoundsVolume() {
            StaticClass = Main.GetClass("NavMeshBoundsVolume");
        }
        internal unsafe NavMeshBoundsVolume_fields* NavMeshBoundsVolume_ptr => (NavMeshBoundsVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavMeshBoundsVolume(IntPtr p) => UObject.Make<NavMeshBoundsVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavMeshBoundsVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavMeshBoundsVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

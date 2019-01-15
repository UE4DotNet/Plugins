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
using UE4.Landscape.Native;

namespace UE4.Landscape {
    ///<summary>Landscape Mesh Collision Component</summary>
    public unsafe partial class LandscapeMeshCollisionComponent : LandscapeHeightfieldCollisionComponent  {
        ///<summary>Guid used to share PhysX heightfield objects in the editor</summary>
        public unsafe FGuid MeshGuid {
            get {return LandscapeMeshCollisionComponent_ptr->MeshGuid;}
            set {LandscapeMeshCollisionComponent_ptr->MeshGuid = value;}
        }
        static LandscapeMeshCollisionComponent() {
            StaticClass = Main.GetClass("LandscapeMeshCollisionComponent");
        }
        internal unsafe LandscapeMeshCollisionComponent_fields* LandscapeMeshCollisionComponent_ptr => (LandscapeMeshCollisionComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LandscapeMeshCollisionComponent(IntPtr p) => UObject.Make<LandscapeMeshCollisionComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LandscapeMeshCollisionComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LandscapeMeshCollisionComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

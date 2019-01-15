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
    ///<summary>Nav Mesh Rendering Component</summary>
    public unsafe partial class NavMeshRenderingComponent : PrimitiveComponent  {
        static NavMeshRenderingComponent() {
            StaticClass = Main.GetClass("NavMeshRenderingComponent");
        }
        internal unsafe NavMeshRenderingComponent_fields* NavMeshRenderingComponent_ptr => (NavMeshRenderingComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavMeshRenderingComponent(IntPtr p) => UObject.Make<NavMeshRenderingComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavMeshRenderingComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavMeshRenderingComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

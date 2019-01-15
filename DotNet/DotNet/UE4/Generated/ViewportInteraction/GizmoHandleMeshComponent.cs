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
using UE4.ViewportInteraction.Native;
using UE4.Engine;

namespace UE4.ViewportInteraction {
    ///<summary>Gizmo Handle Mesh Component</summary>
    public unsafe partial class GizmoHandleMeshComponent : StaticMeshComponent  {
        static GizmoHandleMeshComponent() {
            StaticClass = Main.GetClass("GizmoHandleMeshComponent");
        }
        internal unsafe GizmoHandleMeshComponent_fields* GizmoHandleMeshComponent_ptr => (GizmoHandleMeshComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GizmoHandleMeshComponent(IntPtr p) => UObject.Make<GizmoHandleMeshComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GizmoHandleMeshComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GizmoHandleMeshComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

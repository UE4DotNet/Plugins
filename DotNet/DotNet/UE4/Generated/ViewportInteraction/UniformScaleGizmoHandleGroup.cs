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

namespace UE4.ViewportInteraction {
    ///<summary>Gizmo handle for uniform scaling</summary>
    public unsafe partial class UniformScaleGizmoHandleGroup : GizmoHandleGroup  {
        static UniformScaleGizmoHandleGroup() {
            StaticClass = Main.GetClass("UniformScaleGizmoHandleGroup");
        }
        internal unsafe UniformScaleGizmoHandleGroup_fields* UniformScaleGizmoHandleGroup_ptr => (UniformScaleGizmoHandleGroup_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UniformScaleGizmoHandleGroup(IntPtr p) => UObject.Make<UniformScaleGizmoHandleGroup>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UniformScaleGizmoHandleGroup DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UniformScaleGizmoHandleGroup New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

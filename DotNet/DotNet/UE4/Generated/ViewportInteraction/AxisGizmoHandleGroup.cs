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
    ///<summary>Base class for gizmo handles on axis</summary>
    public unsafe partial class AxisGizmoHandleGroup : GizmoHandleGroup  {
        static AxisGizmoHandleGroup() {
            StaticClass = Main.GetClass("AxisGizmoHandleGroup");
        }
        internal unsafe AxisGizmoHandleGroup_fields* AxisGizmoHandleGroup_ptr => (AxisGizmoHandleGroup_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AxisGizmoHandleGroup(IntPtr p) => UObject.Make<AxisGizmoHandleGroup>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AxisGizmoHandleGroup DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AxisGizmoHandleGroup New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

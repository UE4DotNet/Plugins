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
    ///<summary>Stretch Gizmo Handle Drag Operation</summary>
    public unsafe partial class StretchGizmoHandleDragOperation : ViewportDragOperation  {
        static StretchGizmoHandleDragOperation() {
            StaticClass = Main.GetClass("StretchGizmoHandleDragOperation");
        }
        internal unsafe StretchGizmoHandleDragOperation_fields* StretchGizmoHandleDragOperation_ptr => (StretchGizmoHandleDragOperation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator StretchGizmoHandleDragOperation(IntPtr p) => UObject.Make<StretchGizmoHandleDragOperation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static StretchGizmoHandleDragOperation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static StretchGizmoHandleDragOperation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

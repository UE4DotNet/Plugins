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
using UE4.VREditor.Native;
using UE4.ViewportInteraction;

namespace UE4.VREditor {
    ///<summary>Calculation for dragging a dockable window</summary>
    public unsafe partial class DockableWindowDragOperation : ViewportDragOperation  {
        static DockableWindowDragOperation() {
            StaticClass = Main.GetClass("DockableWindowDragOperation");
        }
        internal unsafe DockableWindowDragOperation_fields* DockableWindowDragOperation_ptr => (DockableWindowDragOperation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DockableWindowDragOperation(IntPtr p) => UObject.Make<DockableWindowDragOperation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DockableWindowDragOperation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DockableWindowDragOperation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

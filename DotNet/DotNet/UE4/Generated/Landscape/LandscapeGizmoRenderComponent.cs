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
using UE4.Engine;

namespace UE4.Landscape {
    ///<summary>Landscape Gizmo Render Component</summary>
    public unsafe partial class LandscapeGizmoRenderComponent : PrimitiveComponent  {
        static LandscapeGizmoRenderComponent() {
            StaticClass = Main.GetClass("LandscapeGizmoRenderComponent");
        }
        internal unsafe LandscapeGizmoRenderComponent_fields* LandscapeGizmoRenderComponent_ptr => (LandscapeGizmoRenderComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LandscapeGizmoRenderComponent(IntPtr p) => UObject.Make<LandscapeGizmoRenderComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LandscapeGizmoRenderComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LandscapeGizmoRenderComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

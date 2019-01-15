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
using UE4.MeshEditor.Native;
using UE4.Engine;

namespace UE4.MeshEditor {
    ///<summary>Overlay Component</summary>
    public unsafe partial class OverlayComponent : MeshComponent  {
        ///<summary>Line Material</summary>
        public unsafe MaterialInterface LineMaterial {
            get {return OverlayComponent_ptr->LineMaterial;}
            set {OverlayComponent_ptr->LineMaterial = value;}
        }
        ///<summary>Point Material</summary>
        public unsafe MaterialInterface PointMaterial {
            get {return OverlayComponent_ptr->PointMaterial;}
            set {OverlayComponent_ptr->PointMaterial = value;}
        }
        ///<summary>Bounds</summary>
        public unsafe BoxSphereBounds Bounds {
            get {return OverlayComponent_ptr->Bounds;}
            set {OverlayComponent_ptr->Bounds = value;}
        }
        public bool bBoundsDirty {
            get {return Main.GetGetBoolPropertyByName(this, "bBoundsDirty"); }
            set {Main.SetGetBoolPropertyByName(this, "bBoundsDirty", value); }
        }
        static OverlayComponent() {
            StaticClass = Main.GetClass("OverlayComponent");
        }
        internal unsafe OverlayComponent_fields* OverlayComponent_ptr => (OverlayComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator OverlayComponent(IntPtr p) => UObject.Make<OverlayComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static OverlayComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static OverlayComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>A box generally used for simple collision. Bounds are rendered as lines in the editor.</summary>
    public unsafe partial class BoxComponent : ShapeComponent  {

        ///<summary>@return the box extent, scaled by the component scale.</summary>
        public Vector GetScaledBoxExtent()  => 
            BoxComponent_methods.GetScaledBoxExtent_method.Invoke(ObjPointer);

        ///<summary>@return the box extent, ignoring component scale.</summary>
        public Vector GetUnscaledBoxExtent()  => 
            BoxComponent_methods.GetUnscaledBoxExtent_method.Invoke(ObjPointer);

        ///<summary>Change the box extent size.</summary>
        ///<remarks>
        ///This is the unscaled size, before component scale is applied.
        ///@param       InBoxExtent: new extent (radius) for the box.
        ///@param       bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
        ///</remarks>
        public void SetBoxExtent(Vector InBoxExtent, bool bUpdateOverlaps)  => 
            BoxComponent_methods.SetBoxExtent_method.Invoke(ObjPointer, InBoxExtent, bUpdateOverlaps);
        ///<summary>The extents (radii dimensions) of the box *</summary>
        public unsafe Vector BoxExtent {
            get {return BoxComponent_ptr->BoxExtent;}
        }
        static BoxComponent() {
            StaticClass = Main.GetClass("BoxComponent");
        }
        internal unsafe BoxComponent_fields* BoxComponent_ptr => (BoxComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BoxComponent(IntPtr p) => UObject.Make<BoxComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BoxComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BoxComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

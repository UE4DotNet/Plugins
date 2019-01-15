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
    ///<summary>A sphere generally used for simple collision. Bounds are rendered as lines in the editor.</summary>
    public unsafe partial class SphereComponent : ShapeComponent  {

        ///<summary>@return the radius of the sphere, with component scale applied.</summary>
        public float GetScaledSphereRadius()  => 
            SphereComponent_methods.GetScaledSphereRadius_method.Invoke(ObjPointer);

        ///<summary>Get the scale used by this shape.</summary>
        ///<remarks>
        ///This is a uniform scale that is the minimum of any non-uniform scaling.
        ///@return the scale used by this shape.
        ///</remarks>
        public float GetShapeScale()  => 
            SphereComponent_methods.GetShapeScale_method.Invoke(ObjPointer);

        ///<summary>@return the radius of the sphere, ignoring component scale.</summary>
        public float GetUnscaledSphereRadius()  => 
            SphereComponent_methods.GetUnscaledSphereRadius_method.Invoke(ObjPointer);

        ///<summary>Change the sphere radius.</summary>
        ///<remarks>
        ///This is the unscaled radius, before component scale is applied.
        ///@param       InSphereRadius: the new sphere radius
        ///@param       bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
        ///</remarks>
        public void SetSphereRadius(float InSphereRadius, bool bUpdateOverlaps)  => 
            SphereComponent_methods.SetSphereRadius_method.Invoke(ObjPointer, InSphereRadius, bUpdateOverlaps);
        ///<summary>The radius of the sphere *</summary>
        public unsafe float SphereRadius {
            get {return SphereComponent_ptr->SphereRadius;}
        }
        static SphereComponent() {
            StaticClass = Main.GetClass("SphereComponent");
        }
        internal unsafe SphereComponent_fields* SphereComponent_ptr => (SphereComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SphereComponent(IntPtr p) => UObject.Make<SphereComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SphereComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SphereComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

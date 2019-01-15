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
    ///<summary>A capsule generally used for simple collision. Bounds are rendered as lines in the editor.</summary>
    public unsafe partial class CapsuleComponent : ShapeComponent  {

        ///<summary>Returns the capsule half-height scaled by the component scale.</summary>
        ///<remarks>
        ///This includes both the cylinder and hemisphere cap.
        ///@return The capsule half-height scaled by the component scale.
        ///</remarks>
        public float GetScaledCapsuleHalfHeight()  => 
            CapsuleComponent_methods.GetScaledCapsuleHalfHeight_method.Invoke(ObjPointer);

        ///<summary>Returns the capsule half-height minus radius (to exclude the hemisphere), scaled by the component scale.</summary>
        ///<remarks>
        ///From the center of the capsule this is the vertical distance along the straight cylindrical portion to the point just before the curve of top hemisphere begins.
        ///@return The capsule half-height minus radius, scaled by the component scale.
        ///</remarks>
        public float GetScaledCapsuleHalfHeight_WithoutHemisphere()  => 
            CapsuleComponent_methods.GetScaledCapsuleHalfHeight_WithoutHemisphere_method.Invoke(ObjPointer);

        ///<summary>Returns the capsule radius scaled by the component scale.</summary>
        ///<remarks>
        ///@return The capsule radius scaled by the component scale.
        ///</remarks>
        public float GetScaledCapsuleRadius()  => 
            CapsuleComponent_methods.GetScaledCapsuleRadius_method.Invoke(ObjPointer);

        ///<summary>Returns the capsule radius and half-height scaled by the component scale.</summary>
        ///<remarks>
        ///Half-height includes the hemisphere end cap.
        ///@param OutRadius Radius of the capsule, scaled by the component scale.
        ///@param OutHalfHeight Half-height of the capsule, scaled by the component scale. Includes the hemisphere end cap.
        ///@return The capsule radius and half-height scaled by the component scale.
        ///</remarks>
        public (float, float) GetScaledCapsuleSize()  => 
            CapsuleComponent_methods.GetScaledCapsuleSize_method.Invoke(ObjPointer);

        ///<summary>Returns the capsule radius and half-height scaled by the component scale.</summary>
        ///<remarks>
        ///Half-height excludes the hemisphere end cap.
        ///@param OutRadius Radius of the capsule, ignoring component scaling.
        ///@param OutHalfHeightWithoutHemisphere Half-height of the capsule, scaled by the component scale. Excludes the hemisphere end cap.
        ///@return The capsule radius and half-height scaled by the component scale.
        ///</remarks>
        public (float, float) GetScaledCapsuleSize_WithoutHemisphere()  => 
            CapsuleComponent_methods.GetScaledCapsuleSize_WithoutHemisphere_method.Invoke(ObjPointer);

        ///<summary>Get the scale used by this shape.</summary>
        ///<remarks>
        ///This is a uniform scale that is the minimum of any non-uniform scaling.
        ///@return the scale used by this shape.
        ///</remarks>
        public float GetShapeScale()  => 
            CapsuleComponent_methods.GetShapeScale_method.Invoke(ObjPointer);

        ///<summary>Returns the capsule half-height, ignoring component scaling.</summary>
        ///<remarks>
        ///This includes the hemisphere end cap.
        ///@return The capsule radius, ignoring component scaling.
        ///</remarks>
        public float GetUnscaledCapsuleHalfHeight()  => 
            CapsuleComponent_methods.GetUnscaledCapsuleHalfHeight_method.Invoke(ObjPointer);

        ///<summary>Returns the capsule half-height minus radius (to exclude the hemisphere), ignoring component scaling.</summary>
        ///<remarks>
        ///This excludes the hemisphere end cap.
        ///From the center of the capsule this is the vertical distance along the straight cylindrical portion to the point just before the curve of top hemisphere begins.
        ///@return The capsule half-height minus radius, ignoring component scaling.
        ///</remarks>
        public float GetUnscaledCapsuleHalfHeight_WithoutHemisphere()  => 
            CapsuleComponent_methods.GetUnscaledCapsuleHalfHeight_WithoutHemisphere_method.Invoke(ObjPointer);

        ///<summary>Returns the capsule radius, ignoring component scaling.</summary>
        ///<remarks>
        ///@return the capsule radius, ignoring component scaling.
        ///</remarks>
        public float GetUnscaledCapsuleRadius()  => 
            CapsuleComponent_methods.GetUnscaledCapsuleRadius_method.Invoke(ObjPointer);

        ///<summary>Returns the capsule radius and half-height scaled by the component scale.</summary>
        ///<remarks>
        ///Half-height includes the hemisphere end cap.
        ///@param OutRadius Radius of the capsule, scaled by the component scale.
        ///@param OutHalfHeight Half-height of the capsule, scaled by the component scale. Includes the hemisphere end cap.
        ///@return The capsule radius and half-height scaled by the component scale.
        ///</remarks>
        public (float, float) GetUnscaledCapsuleSize()  => 
            CapsuleComponent_methods.GetUnscaledCapsuleSize_method.Invoke(ObjPointer);

        ///<summary>Returns the capsule radius and half-height, ignoring component scaling.</summary>
        ///<remarks>
        ///Half-height excludes the hemisphere end cap.
        ///@param OutRadius Radius of the capsule, ignoring component scaling.
        ///@param OutHalfHeightWithoutHemisphere Half-height of the capsule, scaled by the component scale. Excludes the hemisphere end cap.
        ///@return The capsule radius and half-height (excluding hemisphere end cap), ignoring component scaling.
        ///</remarks>
        public (float, float) GetUnscaledCapsuleSize_WithoutHemisphere()  => 
            CapsuleComponent_methods.GetUnscaledCapsuleSize_WithoutHemisphere_method.Invoke(ObjPointer);

        ///<summary>Set the capsule half-height.</summary>
        ///<remarks>
        ///This is the unscaled half-height, before component scale is applied.
        ///If this capsule collides, updates touching array for owner actor.
        ///@param       HalfHeight : half-height, from capsule center to end of top or bottom hemisphere.
        ///@param       bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
        ///</remarks>
        public void SetCapsuleHalfHeight(float HalfHeight, bool bUpdateOverlaps)  => 
            CapsuleComponent_methods.SetCapsuleHalfHeight_method.Invoke(ObjPointer, HalfHeight, bUpdateOverlaps);

        ///<summary>Set the capsule radius.</summary>
        ///<remarks>
        ///This is the unscaled radius, before component scale is applied.
        ///If this capsule collides, updates touching array for owner actor.
        ///@param       Radius : radius of end-cap hemispheres and center cylinder.
        ///@param       bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
        ///</remarks>
        public void SetCapsuleRadius(float Radius, bool bUpdateOverlaps)  => 
            CapsuleComponent_methods.SetCapsuleRadius_method.Invoke(ObjPointer, Radius, bUpdateOverlaps);

        ///<summary>Change the capsule size.</summary>
        ///<remarks>
        ///This is the unscaled size, before component scale is applied.
        ///@param       InRadius : radius of end-cap hemispheres and center cylinder.
        ///@param       InHalfHeight : half-height, from capsule center to end of top or bottom hemisphere.
        ///@param       bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
        ///</remarks>
        public void SetCapsuleSize(float InRadius, float InHalfHeight, bool bUpdateOverlaps)  => 
            CapsuleComponent_methods.SetCapsuleSize_method.Invoke(ObjPointer, InRadius, InHalfHeight, bUpdateOverlaps);
        ///<summary>Half-height, from center of capsule to the end of top or bottom hemisphere.</summary>
        ///<remarks>This cannot be less than CapsuleRadius.</remarks>
        public unsafe float CapsuleHalfHeight {
            get {return CapsuleComponent_ptr->CapsuleHalfHeight;}
        }
        ///<summary>Radius of cap hemispheres and center cylinder.</summary>
        ///<remarks>This cannot be more than CapsuleHalfHeight.</remarks>
        public unsafe float CapsuleRadius {
            get {return CapsuleComponent_ptr->CapsuleRadius;}
        }
        static CapsuleComponent() {
            StaticClass = Main.GetClass("CapsuleComponent");
        }
        internal unsafe CapsuleComponent_fields* CapsuleComponent_ptr => (CapsuleComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CapsuleComponent(IntPtr p) => UObject.Make<CapsuleComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CapsuleComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CapsuleComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

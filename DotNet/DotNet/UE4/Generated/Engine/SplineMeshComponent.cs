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
    ///<summary>A Spline Mesh Component is a derivation of a Static Mesh Component which can be deformed using a spline.</summary>
    ///<remarks>
    ///Only a start and end position (and tangent) can be specified.
    ///@see https://docs.unrealengine.com/latest/INT/Resources/ContentExamples/Blueprint_Splines
    ///</remarks>
    public unsafe partial class SplineMeshComponent : StaticMeshComponent  {

        ///<summary>Get the boundary max</summary>
        public float GetBoundaryMax()  => 
            SplineMeshComponent_methods.GetBoundaryMax_method.Invoke(ObjPointer);

        ///<summary>Get the boundary min</summary>
        public float GetBoundaryMin()  => 
            SplineMeshComponent_methods.GetBoundaryMin_method.Invoke(ObjPointer);

        ///<summary>Get the end offset</summary>
        public Vector2D GetEndOffset()  => 
            SplineMeshComponent_methods.GetEndOffset_method.Invoke(ObjPointer);

        ///<summary>Get the end position of spline in local space</summary>
        public Vector GetEndPosition()  => 
            SplineMeshComponent_methods.GetEndPosition_method.Invoke(ObjPointer);

        ///<summary>Get the end roll</summary>
        public float GetEndRoll()  => 
            SplineMeshComponent_methods.GetEndRoll_method.Invoke(ObjPointer);

        ///<summary>Get the end scaling</summary>
        public Vector2D GetEndScale()  => 
            SplineMeshComponent_methods.GetEndScale_method.Invoke(ObjPointer);

        ///<summary>Get the end tangent vector of spline in local space</summary>
        public Vector GetEndTangent()  => 
            SplineMeshComponent_methods.GetEndTangent_method.Invoke(ObjPointer);

        ///<summary>Get the forward axis</summary>
        public byte GetForwardAxis()  => 
            SplineMeshComponent_methods.GetForwardAxis_method.Invoke(ObjPointer);

        ///<summary>Get the spline up direction</summary>
        public Vector GetSplineUpDir()  => 
            SplineMeshComponent_methods.GetSplineUpDir_method.Invoke(ObjPointer);

        ///<summary>Get the start offset</summary>
        public Vector2D GetStartOffset()  => 
            SplineMeshComponent_methods.GetStartOffset_method.Invoke(ObjPointer);

        ///<summary>Get the start position of spline in local space</summary>
        public Vector GetStartPosition()  => 
            SplineMeshComponent_methods.GetStartPosition_method.Invoke(ObjPointer);

        ///<summary>Get the start roll</summary>
        public float GetStartRoll()  => 
            SplineMeshComponent_methods.GetStartRoll_method.Invoke(ObjPointer);

        ///<summary>Get the start scaling</summary>
        public Vector2D GetStartScale()  => 
            SplineMeshComponent_methods.GetStartScale_method.Invoke(ObjPointer);

        ///<summary>Get the start tangent vector of spline in local space</summary>
        public Vector GetStartTangent()  => 
            SplineMeshComponent_methods.GetStartTangent_method.Invoke(ObjPointer);

        ///<summary>Set the boundary max</summary>
        public void SetBoundaryMax(float InBoundaryMax, bool bUpdateMesh)  => 
            SplineMeshComponent_methods.SetBoundaryMax_method.Invoke(ObjPointer, InBoundaryMax, bUpdateMesh);

        ///<summary>Set the boundary min</summary>
        public void SetBoundaryMin(float InBoundaryMin, bool bUpdateMesh)  => 
            SplineMeshComponent_methods.SetBoundaryMin_method.Invoke(ObjPointer, InBoundaryMin, bUpdateMesh);

        ///<summary>Set the end offset</summary>
        public void SetEndOffset(Vector2D EndOffset, bool bUpdateMesh)  => 
            SplineMeshComponent_methods.SetEndOffset_method.Invoke(ObjPointer, EndOffset, bUpdateMesh);

        ///<summary>Set the end position of spline in local space</summary>
        public void SetEndPosition(Vector EndPos, bool bUpdateMesh)  => 
            SplineMeshComponent_methods.SetEndPosition_method.Invoke(ObjPointer, EndPos, bUpdateMesh);

        ///<summary>Set the end roll</summary>
        public void SetEndRoll(float EndRoll, bool bUpdateMesh)  => 
            SplineMeshComponent_methods.SetEndRoll_method.Invoke(ObjPointer, EndRoll, bUpdateMesh);

        ///<summary>Set the end scaling</summary>
        public void SetEndScale(Vector2D EndScale, bool bUpdateMesh)  => 
            SplineMeshComponent_methods.SetEndScale_method.Invoke(ObjPointer, EndScale, bUpdateMesh);

        ///<summary>Set the end tangent vector of spline in local space</summary>
        public void SetEndTangent(Vector EndTangent, bool bUpdateMesh)  => 
            SplineMeshComponent_methods.SetEndTangent_method.Invoke(ObjPointer, EndTangent, bUpdateMesh);

        ///<summary>Set the forward axis</summary>
        public void SetForwardAxis(byte InForwardAxis, bool bUpdateMesh)  => 
            SplineMeshComponent_methods.SetForwardAxis_method.Invoke(ObjPointer, InForwardAxis, bUpdateMesh);

        ///<summary>Set the spline up direction</summary>
        public void SetSplineUpDir(Vector InSplineUpDir, bool bUpdateMesh)  => 
            SplineMeshComponent_methods.SetSplineUpDir_method.Invoke(ObjPointer, InSplineUpDir, bUpdateMesh);

        ///<summary>Set the start and end, position and tangent, all in local space</summary>
        public void SetStartAndEnd(Vector StartPos, Vector StartTangent, Vector EndPos, Vector EndTangent, bool bUpdateMesh)  => 
            SplineMeshComponent_methods.SetStartAndEnd_method.Invoke(ObjPointer, StartPos, StartTangent, EndPos, EndTangent, bUpdateMesh);

        ///<summary>Set the start offset</summary>
        public void SetStartOffset(Vector2D StartOffset, bool bUpdateMesh)  => 
            SplineMeshComponent_methods.SetStartOffset_method.Invoke(ObjPointer, StartOffset, bUpdateMesh);

        ///<summary>Set the start position of spline in local space</summary>
        public void SetStartPosition(Vector StartPos, bool bUpdateMesh)  => 
            SplineMeshComponent_methods.SetStartPosition_method.Invoke(ObjPointer, StartPos, bUpdateMesh);

        ///<summary>Set the start roll</summary>
        public void SetStartRoll(float StartRoll, bool bUpdateMesh)  => 
            SplineMeshComponent_methods.SetStartRoll_method.Invoke(ObjPointer, StartRoll, bUpdateMesh);

        ///<summary>Set the start scaling</summary>
        public void SetStartScale(Vector2D StartScale, bool bUpdateMesh)  => 
            SplineMeshComponent_methods.SetStartScale_method.Invoke(ObjPointer, StartScale, bUpdateMesh);

        ///<summary>Set the start tangent vector of spline in local space</summary>
        public void SetStartTangent(Vector StartTangent, bool bUpdateMesh)  => 
            SplineMeshComponent_methods.SetStartTangent_method.Invoke(ObjPointer, StartTangent, bUpdateMesh);

        ///<summary>Update the collision and render state on the spline mesh following changes to its geometry</summary>
        public void UpdateMesh()  => 
            SplineMeshComponent_methods.UpdateMesh_method.Invoke(ObjPointer);
        ///<summary>Spline that is used to deform mesh</summary>
        public unsafe SplineMeshParams SplineParams {
            get {return SplineMeshComponent_ptr->SplineParams;}
            set {SplineMeshComponent_ptr->SplineParams = value;}
        }
        ///<summary>Axis (in component space) that is used to determine X axis for co-ordinates along spline</summary>
        public unsafe Vector SplineUpDir {
            get {return SplineMeshComponent_ptr->SplineUpDir;}
            set {SplineMeshComponent_ptr->SplineUpDir = value;}
        }
        public bool bAllowSplineEditingPerInstance {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowSplineEditingPerInstance"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowSplineEditingPerInstance", value); }
        }
        public bool bSmoothInterpRollScale {
            get {return Main.GetGetBoolPropertyByName(this, "bSmoothInterpRollScale"); }
            set {Main.SetGetBoolPropertyByName(this, "bSmoothInterpRollScale", value); }
        }
        ///<summary>Chooses the forward axis for the spline mesh orientation</summary>
        public unsafe byte ForwardAxis {
            get {return SplineMeshComponent_ptr->ForwardAxis;}
            set {SplineMeshComponent_ptr->ForwardAxis = value;}
        }
        ///<summary>Minimum coordinate along the spline forward axis which corresponds to start of spline. If set to 0.0, will use bounding box to determine bounds</summary>
        public unsafe float SplineBoundaryMin {
            get {return SplineMeshComponent_ptr->SplineBoundaryMin;}
            set {SplineMeshComponent_ptr->SplineBoundaryMin = value;}
        }
        ///<summary>Maximum coordinate along the spline forward axis which corresponds to end of spline. If set to 0.0, will use bounding box to determine bounds</summary>
        public unsafe float SplineBoundaryMax {
            get {return SplineMeshComponent_ptr->SplineBoundaryMax;}
            set {SplineMeshComponent_ptr->SplineBoundaryMax = value;}
        }
        ///<summary>Physics data.</summary>
        public unsafe BodySetup BodySetup {
            get {return SplineMeshComponent_ptr->BodySetup;}
            set {SplineMeshComponent_ptr->BodySetup = value;}
        }
        ///<summary>Used to automatically trigger rebuild of collision data</summary>
        public unsafe FGuid CachedMeshBodySetupGuid {
            get {return SplineMeshComponent_ptr->CachedMeshBodySetupGuid;}
            set {SplineMeshComponent_ptr->CachedMeshBodySetupGuid = value;}
        }
        public bool bSelected {
            get {return Main.GetGetBoolPropertyByName(this, "bSelected"); }
            set {Main.SetGetBoolPropertyByName(this, "bSelected", value); }
        }
        public bool bMeshDirty {
            get {return Main.GetGetBoolPropertyByName(this, "bMeshDirty"); }
            set {Main.SetGetBoolPropertyByName(this, "bMeshDirty", value); }
        }
        static SplineMeshComponent() {
            StaticClass = Main.GetClass("SplineMeshComponent");
        }
        internal unsafe SplineMeshComponent_fields* SplineMeshComponent_ptr => (SplineMeshComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SplineMeshComponent(IntPtr p) => UObject.Make<SplineMeshComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SplineMeshComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SplineMeshComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>A spline component is a spline shape which can be used for other purposes (e.</summary>
    ///<remarks>
    ///g. animating objects). It contains debug rendering capabilities.
    ///@see https://docs.unrealengine.com/latest/INT/Resources/ContentExamples/Blueprint_Splines
    ///</remarks>
    public unsafe partial class SplineComponent : PrimitiveComponent  {

        ///<summary>Adds an FSplinePoint to the spline. This contains its input key, position, tangent, rotation and scale.</summary>
        public void AddPoint(SplinePoint Point, bool bUpdateSpline)  => 
            SplineComponent_methods.AddPoint_method.Invoke(ObjPointer, Point, bUpdateSpline);

        ///<summary>Adds an array of FSplinePoints to the spline.</summary>
        public void AddPoints(byte Points /*TODO: array TArray */, bool bUpdateSpline)  => 
            SplineComponent_methods.AddPoints_method.Invoke(ObjPointer, Points, bUpdateSpline);

        ///<summary>Adds a local space point to the spline</summary>
        public void AddSplineLocalPoint(Vector Position)  => 
            SplineComponent_methods.AddSplineLocalPoint_method.Invoke(ObjPointer, Position);

        ///<summary>Adds a point to the spline</summary>
        public void AddSplinePoint(Vector Position, byte CoordinateSpace, bool bUpdateSpline)  => 
            SplineComponent_methods.AddSplinePoint_method.Invoke(ObjPointer, Position, CoordinateSpace, bUpdateSpline);

        ///<summary>Adds a point to the spline at the specified index</summary>
        public void AddSplinePointAtIndex(Vector Position, int Index, byte CoordinateSpace, bool bUpdateSpline)  => 
            SplineComponent_methods.AddSplinePointAtIndex_method.Invoke(ObjPointer, Position, Index, CoordinateSpace, bUpdateSpline);

        ///<summary>Adds a world space point to the spline</summary>
        public void AddSplineWorldPoint(Vector Position)  => 
            SplineComponent_methods.AddSplineWorldPoint_method.Invoke(ObjPointer, Position);

        ///<summary>Clears all the points in the spline</summary>
        public void ClearSplinePoints(bool bUpdateSpline)  => 
            SplineComponent_methods.ClearSplinePoints_method.Invoke(ObjPointer, bUpdateSpline);

        ///<summary>Given a location, in world spcae, return a unit direction vector of the spline tangent closest to the location.</summary>
        public Vector FindDirectionClosestToWorldLocation(Vector WorldLocation, byte CoordinateSpace)  => 
            SplineComponent_methods.FindDirectionClosestToWorldLocation_method.Invoke(ObjPointer, WorldLocation, CoordinateSpace);

        ///<summary>Given a location, in world space, return the input key closest to that location.</summary>
        public float FindInputKeyClosestToWorldLocation(Vector WorldLocation)  => 
            SplineComponent_methods.FindInputKeyClosestToWorldLocation_method.Invoke(ObjPointer, WorldLocation);

        ///<summary>Given a location, in world space, return the point on the curve that is closest to the location.</summary>
        public Vector FindLocationClosestToWorldLocation(Vector WorldLocation, byte CoordinateSpace)  => 
            SplineComponent_methods.FindLocationClosestToWorldLocation_method.Invoke(ObjPointer, WorldLocation, CoordinateSpace);

        ///<summary>Given a location, in world space, return a unit direction vector corresponding to the spline's right vector closest to the location.</summary>
        public Vector FindRightVectorClosestToWorldLocation(Vector WorldLocation, byte CoordinateSpace)  => 
            SplineComponent_methods.FindRightVectorClosestToWorldLocation_method.Invoke(ObjPointer, WorldLocation, CoordinateSpace);

        ///<summary>Given a location, in world space, return the spline's roll closest to the location, in degrees.</summary>
        public float FindRollClosestToWorldLocation(Vector WorldLocation, byte CoordinateSpace)  => 
            SplineComponent_methods.FindRollClosestToWorldLocation_method.Invoke(ObjPointer, WorldLocation, CoordinateSpace);

        ///<summary>Given a location, in world space, return rotation corresponding to the spline's rotation closest to the location.</summary>
        public Rotator FindRotationClosestToWorldLocation(Vector WorldLocation, byte CoordinateSpace)  => 
            SplineComponent_methods.FindRotationClosestToWorldLocation_method.Invoke(ObjPointer, WorldLocation, CoordinateSpace);

        ///<summary>Given a location, in world space, return the spline's scale closest to the location.</summary>
        public Vector FindScaleClosestToWorldLocation(Vector WorldLocation)  => 
            SplineComponent_methods.FindScaleClosestToWorldLocation_method.Invoke(ObjPointer, WorldLocation);

        ///<summary>Given a location, in world space, return the tangent vector of the spline closest to the location.</summary>
        public Vector FindTangentClosestToWorldLocation(Vector WorldLocation, byte CoordinateSpace)  => 
            SplineComponent_methods.FindTangentClosestToWorldLocation_method.Invoke(ObjPointer, WorldLocation, CoordinateSpace);

        ///<summary>Given a location, in world space, return an FTransform closest to that location.</summary>
        public Transform FindTransformClosestToWorldLocation(Vector WorldLocation, byte CoordinateSpace, bool bUseScale)  => 
            SplineComponent_methods.FindTransformClosestToWorldLocation_method.Invoke(ObjPointer, WorldLocation, CoordinateSpace, bUseScale);

        ///<summary>Given a location, in world space, return a unit direction vector corresponding to the spline's up vector closest to the location.</summary>
        public Vector FindUpVectorClosestToWorldLocation(Vector WorldLocation, byte CoordinateSpace)  => 
            SplineComponent_methods.FindUpVectorClosestToWorldLocation_method.Invoke(ObjPointer, WorldLocation, CoordinateSpace);

        ///<summary>Get the arrive tangent at spline point</summary>
        public Vector GetArriveTangentAtSplinePoint(int PointIndex, byte CoordinateSpace)  => 
            SplineComponent_methods.GetArriveTangentAtSplinePoint_method.Invoke(ObjPointer, PointIndex, CoordinateSpace);

        ///<summary>Gets the default up vector used by this spline</summary>
        public Vector GetDefaultUpVector(byte CoordinateSpace)  => 
            SplineComponent_methods.GetDefaultUpVector_method.Invoke(ObjPointer, CoordinateSpace);

        ///<summary>Given a distance along the length of this spline, return a unit direction vector of the spline tangent there.</summary>
        public Vector GetDirectionAtDistanceAlongSpline(float Distance, byte CoordinateSpace)  => 
            SplineComponent_methods.GetDirectionAtDistanceAlongSpline_method.Invoke(ObjPointer, Distance, CoordinateSpace);

        ///<summary>Get the location at spline point</summary>
        public Vector GetDirectionAtSplinePoint(int PointIndex, byte CoordinateSpace)  => 
            SplineComponent_methods.GetDirectionAtSplinePoint_method.Invoke(ObjPointer, PointIndex, CoordinateSpace);

        ///<summary>Given a time from 0 to the spline duration, return a unit direction vector of the spline tangent there.</summary>
        public Vector GetDirectionAtTime(float Time, byte CoordinateSpace, bool bUseConstantVelocity)  => 
            SplineComponent_methods.GetDirectionAtTime_method.Invoke(ObjPointer, Time, CoordinateSpace, bUseConstantVelocity);

        ///<summary>Get the distance along the spline at the spline point</summary>
        public float GetDistanceAlongSplineAtSplinePoint(int PointIndex)  => 
            SplineComponent_methods.GetDistanceAlongSplineAtSplinePoint_method.Invoke(ObjPointer, PointIndex);

        ///<summary>Given a distance along the length of this spline, return the corresponding input key at that point</summary>
        public float GetInputKeyAtDistanceAlongSpline(float Distance)  => 
            SplineComponent_methods.GetInputKeyAtDistanceAlongSpline_method.Invoke(ObjPointer, Distance);

        ///<summary>Get the leave tangent at spline point</summary>
        public Vector GetLeaveTangentAtSplinePoint(int PointIndex, byte CoordinateSpace)  => 
            SplineComponent_methods.GetLeaveTangentAtSplinePoint_method.Invoke(ObjPointer, PointIndex, CoordinateSpace);

        ///<summary>Get local location and tangent at a spline point</summary>
        public (Vector, Vector) GetLocalLocationAndTangentAtSplinePoint(int PointIndex)  => 
            SplineComponent_methods.GetLocalLocationAndTangentAtSplinePoint_method.Invoke(ObjPointer, PointIndex);

        ///<summary>Get location and tangent at a spline point</summary>
        public (Vector, Vector) GetLocationAndTangentAtSplinePoint(int PointIndex, byte CoordinateSpace)  => 
            SplineComponent_methods.GetLocationAndTangentAtSplinePoint_method.Invoke(ObjPointer, PointIndex, CoordinateSpace);

        ///<summary>Given a distance along the length of this spline, return the point in space where this puts you</summary>
        public Vector GetLocationAtDistanceAlongSpline(float Distance, byte CoordinateSpace)  => 
            SplineComponent_methods.GetLocationAtDistanceAlongSpline_method.Invoke(ObjPointer, Distance, CoordinateSpace);

        ///<summary>Get the location at spline point</summary>
        public Vector GetLocationAtSplinePoint(int PointIndex, byte CoordinateSpace)  => 
            SplineComponent_methods.GetLocationAtSplinePoint_method.Invoke(ObjPointer, PointIndex, CoordinateSpace);

        ///<summary>Given a time from 0 to the spline duration, return the point in space where this puts you</summary>
        public Vector GetLocationAtTime(float Time, byte CoordinateSpace, bool bUseConstantVelocity)  => 
            SplineComponent_methods.GetLocationAtTime_method.Invoke(ObjPointer, Time, CoordinateSpace, bUseConstantVelocity);

        ///<summary>Get the number of points that make up this spline</summary>
        public int GetNumberOfSplinePoints()  => 
            SplineComponent_methods.GetNumberOfSplinePoints_method.Invoke(ObjPointer);

        ///<summary>Given a distance along the length of this spline, return a unit direction vector corresponding to the spline's right vector there.</summary>
        public Vector GetRightVectorAtDistanceAlongSpline(float Distance, byte CoordinateSpace)  => 
            SplineComponent_methods.GetRightVectorAtDistanceAlongSpline_method.Invoke(ObjPointer, Distance, CoordinateSpace);

        ///<summary>Get the right vector at spline point</summary>
        public Vector GetRightVectorAtSplinePoint(int PointIndex, byte CoordinateSpace)  => 
            SplineComponent_methods.GetRightVectorAtSplinePoint_method.Invoke(ObjPointer, PointIndex, CoordinateSpace);

        ///<summary>Given a time from 0 to the spline duration, return the spline's right vector there.</summary>
        public Vector GetRightVectorAtTime(float Time, byte CoordinateSpace, bool bUseConstantVelocity)  => 
            SplineComponent_methods.GetRightVectorAtTime_method.Invoke(ObjPointer, Time, CoordinateSpace, bUseConstantVelocity);

        ///<summary>Given a distance along the length of this spline, return the spline's roll there, in degrees.</summary>
        public float GetRollAtDistanceAlongSpline(float Distance, byte CoordinateSpace)  => 
            SplineComponent_methods.GetRollAtDistanceAlongSpline_method.Invoke(ObjPointer, Distance, CoordinateSpace);

        ///<summary>Get the amount of roll at spline point, in degrees</summary>
        public float GetRollAtSplinePoint(int PointIndex, byte CoordinateSpace)  => 
            SplineComponent_methods.GetRollAtSplinePoint_method.Invoke(ObjPointer, PointIndex, CoordinateSpace);

        ///<summary>Given a time from 0 to the spline duration, return the spline's roll there, in degrees.</summary>
        public float GetRollAtTime(float Time, byte CoordinateSpace, bool bUseConstantVelocity)  => 
            SplineComponent_methods.GetRollAtTime_method.Invoke(ObjPointer, Time, CoordinateSpace, bUseConstantVelocity);

        ///<summary>Given a distance along the length of this spline, return a rotation corresponding to the spline's rotation there.</summary>
        public Rotator GetRotationAtDistanceAlongSpline(float Distance, byte CoordinateSpace)  => 
            SplineComponent_methods.GetRotationAtDistanceAlongSpline_method.Invoke(ObjPointer, Distance, CoordinateSpace);

        ///<summary>Get the rotation at spline point as a rotator</summary>
        public Rotator GetRotationAtSplinePoint(int PointIndex, byte CoordinateSpace)  => 
            SplineComponent_methods.GetRotationAtSplinePoint_method.Invoke(ObjPointer, PointIndex, CoordinateSpace);

        ///<summary>Given a time from 0 to the spline duration, return a rotation corresponding to the spline's position and direction there.</summary>
        public Rotator GetRotationAtTime(float Time, byte CoordinateSpace, bool bUseConstantVelocity)  => 
            SplineComponent_methods.GetRotationAtTime_method.Invoke(ObjPointer, Time, CoordinateSpace, bUseConstantVelocity);

        ///<summary>Given a distance along the length of this spline, return the spline's scale there.</summary>
        public Vector GetScaleAtDistanceAlongSpline(float Distance)  => 
            SplineComponent_methods.GetScaleAtDistanceAlongSpline_method.Invoke(ObjPointer, Distance);

        ///<summary>Get the scale at spline point</summary>
        public Vector GetScaleAtSplinePoint(int PointIndex)  => 
            SplineComponent_methods.GetScaleAtSplinePoint_method.Invoke(ObjPointer, PointIndex);

        ///<summary>Given a time from 0 to the spline duration, return the spline's scale there.</summary>
        public Vector GetScaleAtTime(float Time, bool bUseConstantVelocity)  => 
            SplineComponent_methods.GetScaleAtTime_method.Invoke(ObjPointer, Time, bUseConstantVelocity);

        ///<summary>Returns total length along this spline</summary>
        public float GetSplineLength()  => 
            SplineComponent_methods.GetSplineLength_method.Invoke(ObjPointer);

        ///<summary>Get the type of a spline point</summary>
        public byte GetSplinePointType(int PointIndex)  => 
            SplineComponent_methods.GetSplinePointType_method.Invoke(ObjPointer, PointIndex);

        ///<summary>Given a distance along the length of this spline, return the tangent vector of the spline there.</summary>
        public Vector GetTangentAtDistanceAlongSpline(float Distance, byte CoordinateSpace)  => 
            SplineComponent_methods.GetTangentAtDistanceAlongSpline_method.Invoke(ObjPointer, Distance, CoordinateSpace);

        ///<summary>Get the tangent at spline point. This fetches the Leave tangent of the point.</summary>
        public Vector GetTangentAtSplinePoint(int PointIndex, byte CoordinateSpace)  => 
            SplineComponent_methods.GetTangentAtSplinePoint_method.Invoke(ObjPointer, PointIndex, CoordinateSpace);

        ///<summary>Given a time from 0 to the spline duration, return the spline's tangent there.</summary>
        public Vector GetTangentAtTime(float Time, byte CoordinateSpace, bool bUseConstantVelocity)  => 
            SplineComponent_methods.GetTangentAtTime_method.Invoke(ObjPointer, Time, CoordinateSpace, bUseConstantVelocity);

        ///<summary>Given a distance along the length of this spline, return an FTransform corresponding to that point on the spline.</summary>
        public Transform GetTransformAtDistanceAlongSpline(float Distance, byte CoordinateSpace, bool bUseScale)  => 
            SplineComponent_methods.GetTransformAtDistanceAlongSpline_method.Invoke(ObjPointer, Distance, CoordinateSpace, bUseScale);

        ///<summary>Get the transform at spline point</summary>
        public Transform GetTransformAtSplinePoint(int PointIndex, byte CoordinateSpace, bool bUseScale)  => 
            SplineComponent_methods.GetTransformAtSplinePoint_method.Invoke(ObjPointer, PointIndex, CoordinateSpace, bUseScale);

        ///<summary>Given a time from 0 to the spline duration, return the spline's transform at the corresponding position.</summary>
        public Transform GetTransformAtTime(float Time, byte CoordinateSpace, bool bUseConstantVelocity, bool bUseScale)  => 
            SplineComponent_methods.GetTransformAtTime_method.Invoke(ObjPointer, Time, CoordinateSpace, bUseConstantVelocity, bUseScale);

        ///<summary>Given a distance along the length of this spline, return a unit direction vector corresponding to the spline's up vector there.</summary>
        public Vector GetUpVectorAtDistanceAlongSpline(float Distance, byte CoordinateSpace)  => 
            SplineComponent_methods.GetUpVectorAtDistanceAlongSpline_method.Invoke(ObjPointer, Distance, CoordinateSpace);

        ///<summary>Get the up vector at spline point</summary>
        public Vector GetUpVectorAtSplinePoint(int PointIndex, byte CoordinateSpace)  => 
            SplineComponent_methods.GetUpVectorAtSplinePoint_method.Invoke(ObjPointer, PointIndex, CoordinateSpace);

        ///<summary>Given a time from 0 to the spline duration, return the spline's up vector there.</summary>
        public Vector GetUpVectorAtTime(float Time, byte CoordinateSpace, bool bUseConstantVelocity)  => 
            SplineComponent_methods.GetUpVectorAtTime_method.Invoke(ObjPointer, Time, CoordinateSpace, bUseConstantVelocity);

        ///<summary>Given a distance along the length of this spline, return a unit direction vector of the spline tangent there, in world space.</summary>
        public Vector GetWorldDirectionAtDistanceAlongSpline(float Distance)  => 
            SplineComponent_methods.GetWorldDirectionAtDistanceAlongSpline_method.Invoke(ObjPointer, Distance);

        ///<summary>Given a time from 0 to the spline duration, return a unit direction vector of the spline tangent there.</summary>
        public Vector GetWorldDirectionAtTime(float Time, bool bUseConstantVelocity)  => 
            SplineComponent_methods.GetWorldDirectionAtTime_method.Invoke(ObjPointer, Time, bUseConstantVelocity);

        ///<summary>Given a distance along the length of this spline, return the point in world space where this puts you</summary>
        public Vector GetWorldLocationAtDistanceAlongSpline(float Distance)  => 
            SplineComponent_methods.GetWorldLocationAtDistanceAlongSpline_method.Invoke(ObjPointer, Distance);

        ///<summary>Get the world location at spline point</summary>
        public Vector GetWorldLocationAtSplinePoint(int PointIndex)  => 
            SplineComponent_methods.GetWorldLocationAtSplinePoint_method.Invoke(ObjPointer, PointIndex);

        ///<summary>Given a time from 0 to the spline duration, return the point in space where this puts you</summary>
        public Vector GetWorldLocationAtTime(float Time, bool bUseConstantVelocity)  => 
            SplineComponent_methods.GetWorldLocationAtTime_method.Invoke(ObjPointer, Time, bUseConstantVelocity);

        ///<summary>Given a distance along the length of this spline, return a rotation corresponding to the spline's rotation there, in world space.</summary>
        public Rotator GetWorldRotationAtDistanceAlongSpline(float Distance)  => 
            SplineComponent_methods.GetWorldRotationAtDistanceAlongSpline_method.Invoke(ObjPointer, Distance);

        ///<summary>Given a time from 0 to the spline duration, return a rotation corresponding to the spline's position and direction there.</summary>
        public Rotator GetWorldRotationAtTime(float Time, bool bUseConstantVelocity)  => 
            SplineComponent_methods.GetWorldRotationAtTime_method.Invoke(ObjPointer, Time, bUseConstantVelocity);

        ///<summary>Given a distance along the length of this spline, return the tangent vector of the spline there, in world space.</summary>
        public Vector GetWorldTangentAtDistanceAlongSpline(float Distance)  => 
            SplineComponent_methods.GetWorldTangentAtDistanceAlongSpline_method.Invoke(ObjPointer, Distance);

        ///<summary>Check whether the spline is a closed loop or not</summary>
        public bool IsClosedLoop()  => 
            SplineComponent_methods.IsClosedLoop_method.Invoke(ObjPointer);

        ///<summary>Removes point at specified index from the spline</summary>
        public void RemoveSplinePoint(int Index, bool bUpdateSpline)  => 
            SplineComponent_methods.RemoveSplinePoint_method.Invoke(ObjPointer, Index, bUpdateSpline);

        ///<summary>Specify whether the spline is a closed loop or not. The loop position will be at 1.0 after the last point's input key</summary>
        public void SetClosedLoop(bool bInClosedLoop, bool bUpdateSpline)  => 
            SplineComponent_methods.SetClosedLoop_method.Invoke(ObjPointer, bInClosedLoop, bUpdateSpline);

        ///<summary>Specify whether the spline is a closed loop or not, and if so, the input key corresponding to the loop point</summary>
        public void SetClosedLoopAtPosition(bool bInClosedLoop, float Key, bool bUpdateSpline)  => 
            SplineComponent_methods.SetClosedLoopAtPosition_method.Invoke(ObjPointer, bInClosedLoop, Key, bUpdateSpline);

        ///<summary>Sets the default up vector used by this spline</summary>
        public void SetDefaultUpVector(Vector UpVector, byte CoordinateSpace)  => 
            SplineComponent_methods.SetDefaultUpVector_method.Invoke(ObjPointer, UpVector, CoordinateSpace);

        ///<summary>Specify whether this spline should be rendered when the Editor/Game spline show flag is set</summary>
        public void SetDrawDebug(bool bShow)  => 
            SplineComponent_methods.SetDrawDebug_method.Invoke(ObjPointer, bShow);

        ///<summary>Move an existing point to a new location</summary>
        public void SetLocationAtSplinePoint(int PointIndex, Vector InLocation, byte CoordinateSpace, bool bUpdateSpline)  => 
            SplineComponent_methods.SetLocationAtSplinePoint_method.Invoke(ObjPointer, PointIndex, InLocation, CoordinateSpace, bUpdateSpline);

        ///<summary>Specify selected spline component segment color in the editor</summary>
        public void SetSelectedSplineSegmentColor(LinearColor SegmentColor)  => 
            SplineComponent_methods.SetSelectedSplineSegmentColor_method.Invoke(ObjPointer, SegmentColor);

        ///<summary>Sets the spline to an array of local space points</summary>
        public void SetSplineLocalPoints(byte Points /*TODO: array TArray */)  => 
            SplineComponent_methods.SetSplineLocalPoints_method.Invoke(ObjPointer, Points);

        ///<summary>Sets the spline to an array of points</summary>
        public void SetSplinePoints(byte Points /*TODO: array TArray */, byte CoordinateSpace, bool bUpdateSpline)  => 
            SplineComponent_methods.SetSplinePoints_method.Invoke(ObjPointer, Points, CoordinateSpace, bUpdateSpline);

        ///<summary>Specify the type of a spline point</summary>
        public void SetSplinePointType(int PointIndex, byte Type, bool bUpdateSpline)  => 
            SplineComponent_methods.SetSplinePointType_method.Invoke(ObjPointer, PointIndex, Type, bUpdateSpline);

        ///<summary>Sets the spline to an array of world space points</summary>
        public void SetSplineWorldPoints(byte Points /*TODO: array TArray */)  => 
            SplineComponent_methods.SetSplineWorldPoints_method.Invoke(ObjPointer, Points);

        ///<summary>Specify the tangent at a given spline point</summary>
        public void SetTangentAtSplinePoint(int PointIndex, Vector InTangent, byte CoordinateSpace, bool bUpdateSpline)  => 
            SplineComponent_methods.SetTangentAtSplinePoint_method.Invoke(ObjPointer, PointIndex, InTangent, CoordinateSpace, bUpdateSpline);

        ///<summary>Specify the tangents at a given spline point</summary>
        public void SetTangentsAtSplinePoint(int PointIndex, Vector InArriveTangent, Vector InLeaveTangent, byte CoordinateSpace, bool bUpdateSpline)  => 
            SplineComponent_methods.SetTangentsAtSplinePoint_method.Invoke(ObjPointer, PointIndex, InArriveTangent, InLeaveTangent, CoordinateSpace, bUpdateSpline);

        ///<summary>Specify unselected spline component segment color in the editor</summary>
        public void SetUnselectedSplineSegmentColor(LinearColor SegmentColor)  => 
            SplineComponent_methods.SetUnselectedSplineSegmentColor_method.Invoke(ObjPointer, SegmentColor);

        ///<summary>Specify the up vector at a given spline point</summary>
        public void SetUpVectorAtSplinePoint(int PointIndex, Vector InUpVector, byte CoordinateSpace, bool bUpdateSpline)  => 
            SplineComponent_methods.SetUpVectorAtSplinePoint_method.Invoke(ObjPointer, PointIndex, InUpVector, CoordinateSpace, bUpdateSpline);

        ///<summary>Move an existing point to a new world location</summary>
        public void SetWorldLocationAtSplinePoint(int PointIndex, Vector InLocation)  => 
            SplineComponent_methods.SetWorldLocationAtSplinePoint_method.Invoke(ObjPointer, PointIndex, InLocation);

        ///<summary>Update the spline tangents and SplineReparamTable</summary>
        public void UpdateSpline()  => 
            SplineComponent_methods.UpdateSpline_method.Invoke(ObjPointer);
        ///<summary>Spline Curves</summary>
        public unsafe SplineCurves SplineCurves {
            get {return SplineComponent_ptr->SplineCurves;}
            set {SplineComponent_ptr->SplineCurves = value;}
        }
        ///<summary>Number of steps per spline segment to place in the reparameterization table</summary>
        public unsafe int ReparamStepsPerSegment {
            get {return SplineComponent_ptr->ReparamStepsPerSegment;}
            set {SplineComponent_ptr->ReparamStepsPerSegment = value;}
        }
        ///<summary>Specifies the duration of the spline in seconds</summary>
        public unsafe float Duration {
            get {return SplineComponent_ptr->Duration;}
            set {SplineComponent_ptr->Duration = value;}
        }
        public bool bStationaryEndpoints {
            get {return Main.GetGetBoolPropertyByName(this, "bStationaryEndpoints"); }
            set {Main.SetGetBoolPropertyByName(this, "bStationaryEndpoints", value); }
        }
        public bool bSplineHasBeenEdited {
            get {return Main.GetGetBoolPropertyByName(this, "bSplineHasBeenEdited"); }
            set {Main.SetGetBoolPropertyByName(this, "bSplineHasBeenEdited", value); }
        }
        public bool bModifiedByConstructionScript {
            get {return Main.GetGetBoolPropertyByName(this, "bModifiedByConstructionScript"); }
            set {Main.SetGetBoolPropertyByName(this, "bModifiedByConstructionScript", value); }
        }
        public bool bInputSplinePointsToConstructionScript {
            get {return Main.GetGetBoolPropertyByName(this, "bInputSplinePointsToConstructionScript"); }
            set {Main.SetGetBoolPropertyByName(this, "bInputSplinePointsToConstructionScript", value); }
        }
        public bool bDrawDebug {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawDebug"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawDebug", value); }
        }
        public bool bClosedLoop {
            get {return Main.GetGetBoolPropertyByName(this, "bClosedLoop"); }
            set {Main.SetGetBoolPropertyByName(this, "bClosedLoop", value); }
        }
        public bool bLoopPositionOverride {
            get {return Main.GetGetBoolPropertyByName(this, "bLoopPositionOverride"); }
            set {Main.SetGetBoolPropertyByName(this, "bLoopPositionOverride", value); }
        }
        ///<summary>Loop Position</summary>
        public unsafe float LoopPosition {
            get {return SplineComponent_ptr->LoopPosition;}
            set {SplineComponent_ptr->LoopPosition = value;}
        }
        ///<summary>Default up vector in local space to be used when calculating transforms along the spline</summary>
        public unsafe Vector DefaultUpVector {
            get {return SplineComponent_ptr->DefaultUpVector;}
            set {SplineComponent_ptr->DefaultUpVector = value;}
        }
        ///<summary>Color of an unselected spline component segment in the editor</summary>
        public unsafe LinearColor EditorUnselectedSplineSegmentColor {
            get {return SplineComponent_ptr->EditorUnselectedSplineSegmentColor;}
            set {SplineComponent_ptr->EditorUnselectedSplineSegmentColor = value;}
        }
        ///<summary>Color of a selected spline component segment in the editor</summary>
        public unsafe LinearColor EditorSelectedSplineSegmentColor {
            get {return SplineComponent_ptr->EditorSelectedSplineSegmentColor;}
            set {SplineComponent_ptr->EditorSelectedSplineSegmentColor = value;}
        }
        public bool bAllowDiscontinuousSpline {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowDiscontinuousSpline"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowDiscontinuousSpline", value); }
        }
        public bool bShouldVisualizeScale {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldVisualizeScale"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldVisualizeScale", value); }
        }
        ///<summary>Width of spline in editor for use with scale visualization</summary>
        public unsafe float ScaleVisualizationWidth {
            get {return SplineComponent_ptr->ScaleVisualizationWidth;}
            set {SplineComponent_ptr->ScaleVisualizationWidth = value;}
        }
        static SplineComponent() {
            StaticClass = Main.GetClass("SplineComponent");
        }
        internal unsafe SplineComponent_fields* SplineComponent_ptr => (SplineComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SplineComponent(IntPtr p) => UObject.Make<SplineComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SplineComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SplineComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=1776 )]
    internal unsafe struct SplineComponent_fields {
        [FieldOffset(1504)] public SplineCurves SplineCurves;
        [FieldOffset(1700)] public int ReparamStepsPerSegment;
        [FieldOffset(1704)] public float Duration;
        [FieldOffset(1708)] public bool bStationaryEndpoints;
        [FieldOffset(1709)] public bool bSplineHasBeenEdited;
        [FieldOffset(1710)] public bool bModifiedByConstructionScript;
        [FieldOffset(1711)] public bool bInputSplinePointsToConstructionScript;
        [FieldOffset(1712)] public bool bDrawDebug;
        [FieldOffset(1713)] public bool bClosedLoop;
        [FieldOffset(1714)] public bool bLoopPositionOverride;
        [FieldOffset(1716)] public float LoopPosition;
        [FieldOffset(1720)] public Vector DefaultUpVector;
        [FieldOffset(1732)] public LinearColor EditorUnselectedSplineSegmentColor;
        [FieldOffset(1748)] public LinearColor EditorSelectedSplineSegmentColor;
        [FieldOffset(1764)] public bool bAllowDiscontinuousSpline;
        [FieldOffset(1765)] public bool bShouldVisualizeScale;
        [FieldOffset(1768)] public float ScaleVisualizationWidth;
    }
    internal unsafe struct SplineComponent_methods {
        internal struct AddPoint_method {
            static internal IntPtr AddPoint_ptr;
            static AddPoint_method() {
                AddPoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "AddPoint");
            }

            internal static unsafe void Invoke(IntPtr obj, SplinePoint Point, bool bUpdateSpline) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SplinePoint*)(b+0)) = Point;
                *((bool*)(b+68)) = bUpdateSpline;
                Main.GetProcessEvent(obj, AddPoint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddPoints_method {
            static internal IntPtr AddPoints_ptr;
            static AddPoints_method() {
                AddPoints_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "AddPoints");
            }

            internal static unsafe void Invoke(IntPtr obj, byte Points /*TODO: array TArray */, bool bUpdateSpline) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray Points
                *((bool*)(b+16)) = bUpdateSpline;
                Main.GetProcessEvent(obj, AddPoints_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Points
            }
        }
        internal struct AddSplineLocalPoint_method {
            static internal IntPtr AddSplineLocalPoint_ptr;
            static AddSplineLocalPoint_method() {
                AddSplineLocalPoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "AddSplineLocalPoint");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Position) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Position;
                Main.GetProcessEvent(obj, AddSplineLocalPoint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddSplinePoint_method {
            static internal IntPtr AddSplinePoint_ptr;
            static AddSplinePoint_method() {
                AddSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "AddSplinePoint");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Position, byte CoordinateSpace, bool bUpdateSpline) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Position;
                *(b+12) = CoordinateSpace;
                *((bool*)(b+13)) = bUpdateSpline;
                Main.GetProcessEvent(obj, AddSplinePoint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddSplinePointAtIndex_method {
            static internal IntPtr AddSplinePointAtIndex_ptr;
            static AddSplinePointAtIndex_method() {
                AddSplinePointAtIndex_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "AddSplinePointAtIndex");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Position, int Index, byte CoordinateSpace, bool bUpdateSpline) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Position;
                *((int*)(b+12)) = Index;
                *(b+16) = CoordinateSpace;
                *((bool*)(b+17)) = bUpdateSpline;
                Main.GetProcessEvent(obj, AddSplinePointAtIndex_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddSplineWorldPoint_method {
            static internal IntPtr AddSplineWorldPoint_ptr;
            static AddSplineWorldPoint_method() {
                AddSplineWorldPoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "AddSplineWorldPoint");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Position) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Position;
                Main.GetProcessEvent(obj, AddSplineWorldPoint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearSplinePoints_method {
            static internal IntPtr ClearSplinePoints_ptr;
            static ClearSplinePoints_method() {
                ClearSplinePoints_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "ClearSplinePoints");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bUpdateSpline) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bUpdateSpline;
                Main.GetProcessEvent(obj, ClearSplinePoints_ptr, new IntPtr(p)); ;
            }
        }
        internal struct FindDirectionClosestToWorldLocation_method {
            static internal IntPtr FindDirectionClosestToWorldLocation_ptr;
            static FindDirectionClosestToWorldLocation_method() {
                FindDirectionClosestToWorldLocation_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "FindDirectionClosestToWorldLocation");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Vector WorldLocation, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = WorldLocation;
                *(b+12) = CoordinateSpace;
                Main.GetProcessEvent(obj, FindDirectionClosestToWorldLocation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct FindInputKeyClosestToWorldLocation_method {
            static internal IntPtr FindInputKeyClosestToWorldLocation_ptr;
            static FindInputKeyClosestToWorldLocation_method() {
                FindInputKeyClosestToWorldLocation_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "FindInputKeyClosestToWorldLocation");
            }

            internal static unsafe float Invoke(IntPtr obj, Vector WorldLocation) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = WorldLocation;
                Main.GetProcessEvent(obj, FindInputKeyClosestToWorldLocation_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct FindLocationClosestToWorldLocation_method {
            static internal IntPtr FindLocationClosestToWorldLocation_ptr;
            static FindLocationClosestToWorldLocation_method() {
                FindLocationClosestToWorldLocation_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "FindLocationClosestToWorldLocation");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Vector WorldLocation, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = WorldLocation;
                *(b+12) = CoordinateSpace;
                Main.GetProcessEvent(obj, FindLocationClosestToWorldLocation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct FindRightVectorClosestToWorldLocation_method {
            static internal IntPtr FindRightVectorClosestToWorldLocation_ptr;
            static FindRightVectorClosestToWorldLocation_method() {
                FindRightVectorClosestToWorldLocation_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "FindRightVectorClosestToWorldLocation");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Vector WorldLocation, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = WorldLocation;
                *(b+12) = CoordinateSpace;
                Main.GetProcessEvent(obj, FindRightVectorClosestToWorldLocation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct FindRollClosestToWorldLocation_method {
            static internal IntPtr FindRollClosestToWorldLocation_ptr;
            static FindRollClosestToWorldLocation_method() {
                FindRollClosestToWorldLocation_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "FindRollClosestToWorldLocation");
            }

            internal static unsafe float Invoke(IntPtr obj, Vector WorldLocation, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = WorldLocation;
                *(b+12) = CoordinateSpace;
                Main.GetProcessEvent(obj, FindRollClosestToWorldLocation_ptr, new IntPtr(p)); ;
                return *((float*)(b+16));
            }
        }
        internal struct FindRotationClosestToWorldLocation_method {
            static internal IntPtr FindRotationClosestToWorldLocation_ptr;
            static FindRotationClosestToWorldLocation_method() {
                FindRotationClosestToWorldLocation_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "FindRotationClosestToWorldLocation");
            }

            internal static unsafe Rotator Invoke(IntPtr obj, Vector WorldLocation, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = WorldLocation;
                *(b+12) = CoordinateSpace;
                Main.GetProcessEvent(obj, FindRotationClosestToWorldLocation_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+16));
            }
        }
        internal struct FindScaleClosestToWorldLocation_method {
            static internal IntPtr FindScaleClosestToWorldLocation_ptr;
            static FindScaleClosestToWorldLocation_method() {
                FindScaleClosestToWorldLocation_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "FindScaleClosestToWorldLocation");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Vector WorldLocation) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = WorldLocation;
                Main.GetProcessEvent(obj, FindScaleClosestToWorldLocation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct FindTangentClosestToWorldLocation_method {
            static internal IntPtr FindTangentClosestToWorldLocation_ptr;
            static FindTangentClosestToWorldLocation_method() {
                FindTangentClosestToWorldLocation_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "FindTangentClosestToWorldLocation");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Vector WorldLocation, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = WorldLocation;
                *(b+12) = CoordinateSpace;
                Main.GetProcessEvent(obj, FindTangentClosestToWorldLocation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct FindTransformClosestToWorldLocation_method {
            static internal IntPtr FindTransformClosestToWorldLocation_ptr;
            static FindTransformClosestToWorldLocation_method() {
                FindTransformClosestToWorldLocation_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "FindTransformClosestToWorldLocation");
            }

            internal static unsafe Transform Invoke(IntPtr obj, Vector WorldLocation, byte CoordinateSpace, bool bUseScale) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = WorldLocation;
                *(b+12) = CoordinateSpace;
                *((bool*)(b+13)) = bUseScale;
                Main.GetProcessEvent(obj, FindTransformClosestToWorldLocation_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+16));
            }
        }
        internal struct FindUpVectorClosestToWorldLocation_method {
            static internal IntPtr FindUpVectorClosestToWorldLocation_ptr;
            static FindUpVectorClosestToWorldLocation_method() {
                FindUpVectorClosestToWorldLocation_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "FindUpVectorClosestToWorldLocation");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Vector WorldLocation, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = WorldLocation;
                *(b+12) = CoordinateSpace;
                Main.GetProcessEvent(obj, FindUpVectorClosestToWorldLocation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct GetArriveTangentAtSplinePoint_method {
            static internal IntPtr GetArriveTangentAtSplinePoint_ptr;
            static GetArriveTangentAtSplinePoint_method() {
                GetArriveTangentAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetArriveTangentAtSplinePoint");
            }

            internal static unsafe Vector Invoke(IntPtr obj, int PointIndex, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *(b+4) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetArriveTangentAtSplinePoint_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetDefaultUpVector_method {
            static internal IntPtr GetDefaultUpVector_ptr;
            static GetDefaultUpVector_method() {
                GetDefaultUpVector_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetDefaultUpVector");
            }

            internal static unsafe Vector Invoke(IntPtr obj, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetDefaultUpVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+4));
            }
        }
        internal struct GetDirectionAtDistanceAlongSpline_method {
            static internal IntPtr GetDirectionAtDistanceAlongSpline_ptr;
            static GetDirectionAtDistanceAlongSpline_method() {
                GetDirectionAtDistanceAlongSpline_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetDirectionAtDistanceAlongSpline");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Distance, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Distance;
                *(b+4) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetDirectionAtDistanceAlongSpline_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetDirectionAtSplinePoint_method {
            static internal IntPtr GetDirectionAtSplinePoint_ptr;
            static GetDirectionAtSplinePoint_method() {
                GetDirectionAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetDirectionAtSplinePoint");
            }

            internal static unsafe Vector Invoke(IntPtr obj, int PointIndex, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *(b+4) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetDirectionAtSplinePoint_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetDirectionAtTime_method {
            static internal IntPtr GetDirectionAtTime_ptr;
            static GetDirectionAtTime_method() {
                GetDirectionAtTime_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetDirectionAtTime");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Time, byte CoordinateSpace, bool bUseConstantVelocity) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Time;
                *(b+4) = CoordinateSpace;
                *((bool*)(b+5)) = bUseConstantVelocity;
                Main.GetProcessEvent(obj, GetDirectionAtTime_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetDistanceAlongSplineAtSplinePoint_method {
            static internal IntPtr GetDistanceAlongSplineAtSplinePoint_ptr;
            static GetDistanceAlongSplineAtSplinePoint_method() {
                GetDistanceAlongSplineAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetDistanceAlongSplineAtSplinePoint");
            }

            internal static unsafe float Invoke(IntPtr obj, int PointIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                Main.GetProcessEvent(obj, GetDistanceAlongSplineAtSplinePoint_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct GetInputKeyAtDistanceAlongSpline_method {
            static internal IntPtr GetInputKeyAtDistanceAlongSpline_ptr;
            static GetInputKeyAtDistanceAlongSpline_method() {
                GetInputKeyAtDistanceAlongSpline_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetInputKeyAtDistanceAlongSpline");
            }

            internal static unsafe float Invoke(IntPtr obj, float Distance) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Distance;
                Main.GetProcessEvent(obj, GetInputKeyAtDistanceAlongSpline_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct GetLeaveTangentAtSplinePoint_method {
            static internal IntPtr GetLeaveTangentAtSplinePoint_ptr;
            static GetLeaveTangentAtSplinePoint_method() {
                GetLeaveTangentAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetLeaveTangentAtSplinePoint");
            }

            internal static unsafe Vector Invoke(IntPtr obj, int PointIndex, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *(b+4) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetLeaveTangentAtSplinePoint_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetLocalLocationAndTangentAtSplinePoint_method {
            static internal IntPtr GetLocalLocationAndTangentAtSplinePoint_ptr;
            static GetLocalLocationAndTangentAtSplinePoint_method() {
                GetLocalLocationAndTangentAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetLocalLocationAndTangentAtSplinePoint");
            }

            internal static unsafe (Vector, Vector) Invoke(IntPtr obj, int PointIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                Main.GetProcessEvent(obj, GetLocalLocationAndTangentAtSplinePoint_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+4)),*((Vector*)(b+16)));
            }
        }
        internal struct GetLocationAndTangentAtSplinePoint_method {
            static internal IntPtr GetLocationAndTangentAtSplinePoint_ptr;
            static GetLocationAndTangentAtSplinePoint_method() {
                GetLocationAndTangentAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetLocationAndTangentAtSplinePoint");
            }

            internal static unsafe (Vector, Vector) Invoke(IntPtr obj, int PointIndex, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *(b+28) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetLocationAndTangentAtSplinePoint_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+4)),*((Vector*)(b+16)));
            }
        }
        internal struct GetLocationAtDistanceAlongSpline_method {
            static internal IntPtr GetLocationAtDistanceAlongSpline_ptr;
            static GetLocationAtDistanceAlongSpline_method() {
                GetLocationAtDistanceAlongSpline_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetLocationAtDistanceAlongSpline");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Distance, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Distance;
                *(b+4) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetLocationAtDistanceAlongSpline_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetLocationAtSplinePoint_method {
            static internal IntPtr GetLocationAtSplinePoint_ptr;
            static GetLocationAtSplinePoint_method() {
                GetLocationAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetLocationAtSplinePoint");
            }

            internal static unsafe Vector Invoke(IntPtr obj, int PointIndex, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *(b+4) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetLocationAtSplinePoint_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetLocationAtTime_method {
            static internal IntPtr GetLocationAtTime_ptr;
            static GetLocationAtTime_method() {
                GetLocationAtTime_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetLocationAtTime");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Time, byte CoordinateSpace, bool bUseConstantVelocity) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Time;
                *(b+4) = CoordinateSpace;
                *((bool*)(b+5)) = bUseConstantVelocity;
                Main.GetProcessEvent(obj, GetLocationAtTime_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetNumberOfSplinePoints_method {
            static internal IntPtr GetNumberOfSplinePoints_ptr;
            static GetNumberOfSplinePoints_method() {
                GetNumberOfSplinePoints_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetNumberOfSplinePoints");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumberOfSplinePoints_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetRightVectorAtDistanceAlongSpline_method {
            static internal IntPtr GetRightVectorAtDistanceAlongSpline_ptr;
            static GetRightVectorAtDistanceAlongSpline_method() {
                GetRightVectorAtDistanceAlongSpline_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetRightVectorAtDistanceAlongSpline");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Distance, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Distance;
                *(b+4) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetRightVectorAtDistanceAlongSpline_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetRightVectorAtSplinePoint_method {
            static internal IntPtr GetRightVectorAtSplinePoint_ptr;
            static GetRightVectorAtSplinePoint_method() {
                GetRightVectorAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetRightVectorAtSplinePoint");
            }

            internal static unsafe Vector Invoke(IntPtr obj, int PointIndex, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *(b+4) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetRightVectorAtSplinePoint_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetRightVectorAtTime_method {
            static internal IntPtr GetRightVectorAtTime_ptr;
            static GetRightVectorAtTime_method() {
                GetRightVectorAtTime_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetRightVectorAtTime");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Time, byte CoordinateSpace, bool bUseConstantVelocity) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Time;
                *(b+4) = CoordinateSpace;
                *((bool*)(b+5)) = bUseConstantVelocity;
                Main.GetProcessEvent(obj, GetRightVectorAtTime_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetRollAtDistanceAlongSpline_method {
            static internal IntPtr GetRollAtDistanceAlongSpline_ptr;
            static GetRollAtDistanceAlongSpline_method() {
                GetRollAtDistanceAlongSpline_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetRollAtDistanceAlongSpline");
            }

            internal static unsafe float Invoke(IntPtr obj, float Distance, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Distance;
                *(b+4) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetRollAtDistanceAlongSpline_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetRollAtSplinePoint_method {
            static internal IntPtr GetRollAtSplinePoint_ptr;
            static GetRollAtSplinePoint_method() {
                GetRollAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetRollAtSplinePoint");
            }

            internal static unsafe float Invoke(IntPtr obj, int PointIndex, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *(b+4) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetRollAtSplinePoint_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetRollAtTime_method {
            static internal IntPtr GetRollAtTime_ptr;
            static GetRollAtTime_method() {
                GetRollAtTime_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetRollAtTime");
            }

            internal static unsafe float Invoke(IntPtr obj, float Time, byte CoordinateSpace, bool bUseConstantVelocity) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Time;
                *(b+4) = CoordinateSpace;
                *((bool*)(b+5)) = bUseConstantVelocity;
                Main.GetProcessEvent(obj, GetRollAtTime_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetRotationAtDistanceAlongSpline_method {
            static internal IntPtr GetRotationAtDistanceAlongSpline_ptr;
            static GetRotationAtDistanceAlongSpline_method() {
                GetRotationAtDistanceAlongSpline_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetRotationAtDistanceAlongSpline");
            }

            internal static unsafe Rotator Invoke(IntPtr obj, float Distance, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Distance;
                *(b+4) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetRotationAtDistanceAlongSpline_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+8));
            }
        }
        internal struct GetRotationAtSplinePoint_method {
            static internal IntPtr GetRotationAtSplinePoint_ptr;
            static GetRotationAtSplinePoint_method() {
                GetRotationAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetRotationAtSplinePoint");
            }

            internal static unsafe Rotator Invoke(IntPtr obj, int PointIndex, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *(b+4) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetRotationAtSplinePoint_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+8));
            }
        }
        internal struct GetRotationAtTime_method {
            static internal IntPtr GetRotationAtTime_ptr;
            static GetRotationAtTime_method() {
                GetRotationAtTime_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetRotationAtTime");
            }

            internal static unsafe Rotator Invoke(IntPtr obj, float Time, byte CoordinateSpace, bool bUseConstantVelocity) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Time;
                *(b+4) = CoordinateSpace;
                *((bool*)(b+5)) = bUseConstantVelocity;
                Main.GetProcessEvent(obj, GetRotationAtTime_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+8));
            }
        }
        internal struct GetScaleAtDistanceAlongSpline_method {
            static internal IntPtr GetScaleAtDistanceAlongSpline_ptr;
            static GetScaleAtDistanceAlongSpline_method() {
                GetScaleAtDistanceAlongSpline_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetScaleAtDistanceAlongSpline");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Distance) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Distance;
                Main.GetProcessEvent(obj, GetScaleAtDistanceAlongSpline_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+4));
            }
        }
        internal struct GetScaleAtSplinePoint_method {
            static internal IntPtr GetScaleAtSplinePoint_ptr;
            static GetScaleAtSplinePoint_method() {
                GetScaleAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetScaleAtSplinePoint");
            }

            internal static unsafe Vector Invoke(IntPtr obj, int PointIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                Main.GetProcessEvent(obj, GetScaleAtSplinePoint_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+4));
            }
        }
        internal struct GetScaleAtTime_method {
            static internal IntPtr GetScaleAtTime_ptr;
            static GetScaleAtTime_method() {
                GetScaleAtTime_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetScaleAtTime");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Time, bool bUseConstantVelocity) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Time;
                *((bool*)(b+4)) = bUseConstantVelocity;
                Main.GetProcessEvent(obj, GetScaleAtTime_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetSplineLength_method {
            static internal IntPtr GetSplineLength_ptr;
            static GetSplineLength_method() {
                GetSplineLength_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetSplineLength");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSplineLength_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetSplinePointType_method {
            static internal IntPtr GetSplinePointType_ptr;
            static GetSplinePointType_method() {
                GetSplinePointType_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetSplinePointType");
            }

            internal static unsafe byte Invoke(IntPtr obj, int PointIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                Main.GetProcessEvent(obj, GetSplinePointType_ptr, new IntPtr(p)); ;
                return *(b+4);
            }
        }
        internal struct GetTangentAtDistanceAlongSpline_method {
            static internal IntPtr GetTangentAtDistanceAlongSpline_ptr;
            static GetTangentAtDistanceAlongSpline_method() {
                GetTangentAtDistanceAlongSpline_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetTangentAtDistanceAlongSpline");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Distance, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Distance;
                *(b+4) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetTangentAtDistanceAlongSpline_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetTangentAtSplinePoint_method {
            static internal IntPtr GetTangentAtSplinePoint_ptr;
            static GetTangentAtSplinePoint_method() {
                GetTangentAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetTangentAtSplinePoint");
            }

            internal static unsafe Vector Invoke(IntPtr obj, int PointIndex, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *(b+4) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetTangentAtSplinePoint_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetTangentAtTime_method {
            static internal IntPtr GetTangentAtTime_ptr;
            static GetTangentAtTime_method() {
                GetTangentAtTime_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetTangentAtTime");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Time, byte CoordinateSpace, bool bUseConstantVelocity) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Time;
                *(b+4) = CoordinateSpace;
                *((bool*)(b+5)) = bUseConstantVelocity;
                Main.GetProcessEvent(obj, GetTangentAtTime_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetTransformAtDistanceAlongSpline_method {
            static internal IntPtr GetTransformAtDistanceAlongSpline_ptr;
            static GetTransformAtDistanceAlongSpline_method() {
                GetTransformAtDistanceAlongSpline_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetTransformAtDistanceAlongSpline");
            }

            internal static unsafe Transform Invoke(IntPtr obj, float Distance, byte CoordinateSpace, bool bUseScale) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Distance;
                *(b+4) = CoordinateSpace;
                *((bool*)(b+5)) = bUseScale;
                Main.GetProcessEvent(obj, GetTransformAtDistanceAlongSpline_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+16));
            }
        }
        internal struct GetTransformAtSplinePoint_method {
            static internal IntPtr GetTransformAtSplinePoint_ptr;
            static GetTransformAtSplinePoint_method() {
                GetTransformAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetTransformAtSplinePoint");
            }

            internal static unsafe Transform Invoke(IntPtr obj, int PointIndex, byte CoordinateSpace, bool bUseScale) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *(b+4) = CoordinateSpace;
                *((bool*)(b+5)) = bUseScale;
                Main.GetProcessEvent(obj, GetTransformAtSplinePoint_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+16));
            }
        }
        internal struct GetTransformAtTime_method {
            static internal IntPtr GetTransformAtTime_ptr;
            static GetTransformAtTime_method() {
                GetTransformAtTime_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetTransformAtTime");
            }

            internal static unsafe Transform Invoke(IntPtr obj, float Time, byte CoordinateSpace, bool bUseConstantVelocity, bool bUseScale) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Time;
                *(b+4) = CoordinateSpace;
                *((bool*)(b+5)) = bUseConstantVelocity;
                *((bool*)(b+6)) = bUseScale;
                Main.GetProcessEvent(obj, GetTransformAtTime_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+16));
            }
        }
        internal struct GetUpVectorAtDistanceAlongSpline_method {
            static internal IntPtr GetUpVectorAtDistanceAlongSpline_ptr;
            static GetUpVectorAtDistanceAlongSpline_method() {
                GetUpVectorAtDistanceAlongSpline_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetUpVectorAtDistanceAlongSpline");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Distance, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Distance;
                *(b+4) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetUpVectorAtDistanceAlongSpline_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetUpVectorAtSplinePoint_method {
            static internal IntPtr GetUpVectorAtSplinePoint_ptr;
            static GetUpVectorAtSplinePoint_method() {
                GetUpVectorAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetUpVectorAtSplinePoint");
            }

            internal static unsafe Vector Invoke(IntPtr obj, int PointIndex, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *(b+4) = CoordinateSpace;
                Main.GetProcessEvent(obj, GetUpVectorAtSplinePoint_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetUpVectorAtTime_method {
            static internal IntPtr GetUpVectorAtTime_ptr;
            static GetUpVectorAtTime_method() {
                GetUpVectorAtTime_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetUpVectorAtTime");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Time, byte CoordinateSpace, bool bUseConstantVelocity) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Time;
                *(b+4) = CoordinateSpace;
                *((bool*)(b+5)) = bUseConstantVelocity;
                Main.GetProcessEvent(obj, GetUpVectorAtTime_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetWorldDirectionAtDistanceAlongSpline_method {
            static internal IntPtr GetWorldDirectionAtDistanceAlongSpline_ptr;
            static GetWorldDirectionAtDistanceAlongSpline_method() {
                GetWorldDirectionAtDistanceAlongSpline_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetWorldDirectionAtDistanceAlongSpline");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Distance) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Distance;
                Main.GetProcessEvent(obj, GetWorldDirectionAtDistanceAlongSpline_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+4));
            }
        }
        internal struct GetWorldDirectionAtTime_method {
            static internal IntPtr GetWorldDirectionAtTime_ptr;
            static GetWorldDirectionAtTime_method() {
                GetWorldDirectionAtTime_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetWorldDirectionAtTime");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Time, bool bUseConstantVelocity) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Time;
                *((bool*)(b+4)) = bUseConstantVelocity;
                Main.GetProcessEvent(obj, GetWorldDirectionAtTime_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetWorldLocationAtDistanceAlongSpline_method {
            static internal IntPtr GetWorldLocationAtDistanceAlongSpline_ptr;
            static GetWorldLocationAtDistanceAlongSpline_method() {
                GetWorldLocationAtDistanceAlongSpline_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetWorldLocationAtDistanceAlongSpline");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Distance) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Distance;
                Main.GetProcessEvent(obj, GetWorldLocationAtDistanceAlongSpline_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+4));
            }
        }
        internal struct GetWorldLocationAtSplinePoint_method {
            static internal IntPtr GetWorldLocationAtSplinePoint_ptr;
            static GetWorldLocationAtSplinePoint_method() {
                GetWorldLocationAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetWorldLocationAtSplinePoint");
            }

            internal static unsafe Vector Invoke(IntPtr obj, int PointIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                Main.GetProcessEvent(obj, GetWorldLocationAtSplinePoint_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+4));
            }
        }
        internal struct GetWorldLocationAtTime_method {
            static internal IntPtr GetWorldLocationAtTime_ptr;
            static GetWorldLocationAtTime_method() {
                GetWorldLocationAtTime_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetWorldLocationAtTime");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Time, bool bUseConstantVelocity) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Time;
                *((bool*)(b+4)) = bUseConstantVelocity;
                Main.GetProcessEvent(obj, GetWorldLocationAtTime_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetWorldRotationAtDistanceAlongSpline_method {
            static internal IntPtr GetWorldRotationAtDistanceAlongSpline_ptr;
            static GetWorldRotationAtDistanceAlongSpline_method() {
                GetWorldRotationAtDistanceAlongSpline_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetWorldRotationAtDistanceAlongSpline");
            }

            internal static unsafe Rotator Invoke(IntPtr obj, float Distance) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Distance;
                Main.GetProcessEvent(obj, GetWorldRotationAtDistanceAlongSpline_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+4));
            }
        }
        internal struct GetWorldRotationAtTime_method {
            static internal IntPtr GetWorldRotationAtTime_ptr;
            static GetWorldRotationAtTime_method() {
                GetWorldRotationAtTime_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetWorldRotationAtTime");
            }

            internal static unsafe Rotator Invoke(IntPtr obj, float Time, bool bUseConstantVelocity) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Time;
                *((bool*)(b+4)) = bUseConstantVelocity;
                Main.GetProcessEvent(obj, GetWorldRotationAtTime_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+8));
            }
        }
        internal struct GetWorldTangentAtDistanceAlongSpline_method {
            static internal IntPtr GetWorldTangentAtDistanceAlongSpline_ptr;
            static GetWorldTangentAtDistanceAlongSpline_method() {
                GetWorldTangentAtDistanceAlongSpline_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "GetWorldTangentAtDistanceAlongSpline");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float Distance) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Distance;
                Main.GetProcessEvent(obj, GetWorldTangentAtDistanceAlongSpline_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+4));
            }
        }
        internal struct IsClosedLoop_method {
            static internal IntPtr IsClosedLoop_ptr;
            static IsClosedLoop_method() {
                IsClosedLoop_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "IsClosedLoop");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsClosedLoop_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct RemoveSplinePoint_method {
            static internal IntPtr RemoveSplinePoint_ptr;
            static RemoveSplinePoint_method() {
                RemoveSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "RemoveSplinePoint");
            }

            internal static unsafe void Invoke(IntPtr obj, int Index, bool bUpdateSpline) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                *((bool*)(b+4)) = bUpdateSpline;
                Main.GetProcessEvent(obj, RemoveSplinePoint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetClosedLoop_method {
            static internal IntPtr SetClosedLoop_ptr;
            static SetClosedLoop_method() {
                SetClosedLoop_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "SetClosedLoop");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInClosedLoop, bool bUpdateSpline) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInClosedLoop;
                *((bool*)(b+1)) = bUpdateSpline;
                Main.GetProcessEvent(obj, SetClosedLoop_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetClosedLoopAtPosition_method {
            static internal IntPtr SetClosedLoopAtPosition_ptr;
            static SetClosedLoopAtPosition_method() {
                SetClosedLoopAtPosition_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "SetClosedLoopAtPosition");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInClosedLoop, float Key, bool bUpdateSpline) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInClosedLoop;
                *((float*)(b+4)) = Key;
                *((bool*)(b+8)) = bUpdateSpline;
                Main.GetProcessEvent(obj, SetClosedLoopAtPosition_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDefaultUpVector_method {
            static internal IntPtr SetDefaultUpVector_ptr;
            static SetDefaultUpVector_method() {
                SetDefaultUpVector_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "SetDefaultUpVector");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector UpVector, byte CoordinateSpace) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = UpVector;
                *(b+12) = CoordinateSpace;
                Main.GetProcessEvent(obj, SetDefaultUpVector_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDrawDebug_method {
            static internal IntPtr SetDrawDebug_ptr;
            static SetDrawDebug_method() {
                SetDrawDebug_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "SetDrawDebug");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bShow) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bShow;
                Main.GetProcessEvent(obj, SetDrawDebug_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLocationAtSplinePoint_method {
            static internal IntPtr SetLocationAtSplinePoint_ptr;
            static SetLocationAtSplinePoint_method() {
                SetLocationAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "SetLocationAtSplinePoint");
            }

            internal static unsafe void Invoke(IntPtr obj, int PointIndex, Vector InLocation, byte CoordinateSpace, bool bUpdateSpline) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *((Vector*)(b+4)) = InLocation;
                *(b+16) = CoordinateSpace;
                *((bool*)(b+17)) = bUpdateSpline;
                Main.GetProcessEvent(obj, SetLocationAtSplinePoint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSelectedSplineSegmentColor_method {
            static internal IntPtr SetSelectedSplineSegmentColor_ptr;
            static SetSelectedSplineSegmentColor_method() {
                SetSelectedSplineSegmentColor_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "SetSelectedSplineSegmentColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor SegmentColor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = SegmentColor;
                Main.GetProcessEvent(obj, SetSelectedSplineSegmentColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSplineLocalPoints_method {
            static internal IntPtr SetSplineLocalPoints_ptr;
            static SetSplineLocalPoints_method() {
                SetSplineLocalPoints_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "SetSplineLocalPoints");
            }

            internal static unsafe void Invoke(IntPtr obj, byte Points /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray Points
                Main.GetProcessEvent(obj, SetSplineLocalPoints_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Points
            }
        }
        internal struct SetSplinePoints_method {
            static internal IntPtr SetSplinePoints_ptr;
            static SetSplinePoints_method() {
                SetSplinePoints_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "SetSplinePoints");
            }

            internal static unsafe void Invoke(IntPtr obj, byte Points /*TODO: array TArray */, byte CoordinateSpace, bool bUpdateSpline) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray Points
                *(b+16) = CoordinateSpace;
                *((bool*)(b+17)) = bUpdateSpline;
                Main.GetProcessEvent(obj, SetSplinePoints_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Points
            }
        }
        internal struct SetSplinePointType_method {
            static internal IntPtr SetSplinePointType_ptr;
            static SetSplinePointType_method() {
                SetSplinePointType_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "SetSplinePointType");
            }

            internal static unsafe void Invoke(IntPtr obj, int PointIndex, byte Type, bool bUpdateSpline) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *(b+4) = Type;
                *((bool*)(b+5)) = bUpdateSpline;
                Main.GetProcessEvent(obj, SetSplinePointType_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSplineWorldPoints_method {
            static internal IntPtr SetSplineWorldPoints_ptr;
            static SetSplineWorldPoints_method() {
                SetSplineWorldPoints_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "SetSplineWorldPoints");
            }

            internal static unsafe void Invoke(IntPtr obj, byte Points /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray Points
                Main.GetProcessEvent(obj, SetSplineWorldPoints_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Points
            }
        }
        internal struct SetTangentAtSplinePoint_method {
            static internal IntPtr SetTangentAtSplinePoint_ptr;
            static SetTangentAtSplinePoint_method() {
                SetTangentAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "SetTangentAtSplinePoint");
            }

            internal static unsafe void Invoke(IntPtr obj, int PointIndex, Vector InTangent, byte CoordinateSpace, bool bUpdateSpline) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *((Vector*)(b+4)) = InTangent;
                *(b+16) = CoordinateSpace;
                *((bool*)(b+17)) = bUpdateSpline;
                Main.GetProcessEvent(obj, SetTangentAtSplinePoint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTangentsAtSplinePoint_method {
            static internal IntPtr SetTangentsAtSplinePoint_ptr;
            static SetTangentsAtSplinePoint_method() {
                SetTangentsAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "SetTangentsAtSplinePoint");
            }

            internal static unsafe void Invoke(IntPtr obj, int PointIndex, Vector InArriveTangent, Vector InLeaveTangent, byte CoordinateSpace, bool bUpdateSpline) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *((Vector*)(b+4)) = InArriveTangent;
                *((Vector*)(b+16)) = InLeaveTangent;
                *(b+28) = CoordinateSpace;
                *((bool*)(b+29)) = bUpdateSpline;
                Main.GetProcessEvent(obj, SetTangentsAtSplinePoint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetUnselectedSplineSegmentColor_method {
            static internal IntPtr SetUnselectedSplineSegmentColor_ptr;
            static SetUnselectedSplineSegmentColor_method() {
                SetUnselectedSplineSegmentColor_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "SetUnselectedSplineSegmentColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor SegmentColor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = SegmentColor;
                Main.GetProcessEvent(obj, SetUnselectedSplineSegmentColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetUpVectorAtSplinePoint_method {
            static internal IntPtr SetUpVectorAtSplinePoint_ptr;
            static SetUpVectorAtSplinePoint_method() {
                SetUpVectorAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "SetUpVectorAtSplinePoint");
            }

            internal static unsafe void Invoke(IntPtr obj, int PointIndex, Vector InUpVector, byte CoordinateSpace, bool bUpdateSpline) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *((Vector*)(b+4)) = InUpVector;
                *(b+16) = CoordinateSpace;
                *((bool*)(b+17)) = bUpdateSpline;
                Main.GetProcessEvent(obj, SetUpVectorAtSplinePoint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetWorldLocationAtSplinePoint_method {
            static internal IntPtr SetWorldLocationAtSplinePoint_ptr;
            static SetWorldLocationAtSplinePoint_method() {
                SetWorldLocationAtSplinePoint_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "SetWorldLocationAtSplinePoint");
            }

            internal static unsafe void Invoke(IntPtr obj, int PointIndex, Vector InLocation) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PointIndex;
                *((Vector*)(b+4)) = InLocation;
                Main.GetProcessEvent(obj, SetWorldLocationAtSplinePoint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UpdateSpline_method {
            static internal IntPtr UpdateSpline_ptr;
            static UpdateSpline_method() {
                UpdateSpline_ptr = Main.GetMethodUFunction(SplineComponent.StaticClass, "UpdateSpline");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, UpdateSpline_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SplineComponent_events {
    }
}

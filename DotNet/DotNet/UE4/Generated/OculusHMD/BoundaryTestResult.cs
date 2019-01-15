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


namespace UE4.OculusHMD{
        ///<summary>
        ///* Information about relationships between a triggered boundary (EBoundaryType::Boundary_Outer or
        ///* EBoundaryType::Boundary_PlayArea) and a device or point in the world.
        ///</summary>
        ///<remarks>* All dimensions, points, and vectors are returned in Unreal world coordinate space.</remarks>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct BoundaryTestResult {
            [FieldOffset(0)] public bool IsTriggering;

            [FieldOffset(1)] byte DeviceType; //TODO: enum ETrackedDeviceType DeviceType

            [FieldOffset(4)] public float ClosestDistance;

            ///<summary>Closest point on surface corresponding to specified boundary</summary>
            [FieldOffset(8)] Vector ClosestPoint;

            ///<summary>Normal of closest point</summary>
            [FieldOffset(20)] Vector ClosestPointNormal;

        }
}

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

using UE4.Engine;

namespace UE4.AnimGraphRuntime{
        ///<summary>
        ///This node uses a source transform of a socket on the skeletal mesh to automatically calculate
        ///Yaw and Pitch directions for a referenced aim offset given a point in the world to look at.
        ///</summary>
        [StructLayout( LayoutKind.Explicit, Size=544 )]
        public unsafe struct AnimNode_AimOffsetLookAt {
            ///<summary>Base Pose</summary>
            [FieldOffset(304)] PoseLink BasePose;

            [FieldOffset(328)] public int LODThreshold;

            [FieldOffset(332)] public bool bIsLODEnabled;

            ///<summary>Location, in world space to look at</summary>
            [FieldOffset(336)] Vector LookAtLocation;

            [FieldOffset(348)] public Name SourceSocketName;

            [FieldOffset(360)] public Name PivotSocketName;

            ///<summary>Axis in the socket transform to consider the 'forward' or look at axis</summary>
            [FieldOffset(372)] Vector SocketAxis;

            [FieldOffset(384)] public float Alpha;

            ///<summary>Cached reference to the source socket's bone</summary>
            [FieldOffset(388)] BoneReference SocketBoneReference;

            ///<summary>Cached local transform of the source socket</summary>
            [FieldOffset(416)] Transform SocketLocalTransform;

            ///<summary>Cached reference to the pivot socket's bone</summary>
            [FieldOffset(464)] BoneReference PivotSocketBoneReference;

            ///<summary>Cached local transform of the pivot socket</summary>
            [FieldOffset(496)] Transform PivotSocketLocalTransform;

        }
}

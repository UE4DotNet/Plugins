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


namespace UE4.UnrealEd{
        ///<summary>Parameters for PhysicsAsset creation</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct PhysAssetCreateParams {
            [FieldOffset(0)] public float MinBoneSize;

            [FieldOffset(4)] public float MinWeldSize;

            [FieldOffset(8)] public byte GeomType;

            [FieldOffset(9)] public byte VertWeight;

            [FieldOffset(10)] public bool bAutoOrientToBone;

            [FieldOffset(11)] public bool bCreateConstraints;

            [FieldOffset(12)] public bool bWalkPastSmall;

            [FieldOffset(13)] public bool bBodyForAll;

            [FieldOffset(14)] public byte AngularConstraintMode;

            [FieldOffset(16)] public int HullCount;

            [FieldOffset(20)] public int MaxHullVerts;

        }
}

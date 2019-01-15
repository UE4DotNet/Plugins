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


namespace UE4.Engine{
        ///<summary>* Base class for attenuation settings.</summary>
        [StructLayout( LayoutKind.Explicit, Size=160 )]
        public unsafe struct BaseAttenuationSettings {
            [FieldOffset(8)] byte DistanceAlgorithm; //TODO: enum EAttenuationDistanceModel DistanceAlgorithm

            [FieldOffset(9)] public byte AttenuationShape;

            [FieldOffset(12)] public float dBAttenuationAtMax;

            ///<summary>The dimensions to use for the attenuation shape.</summary>
            ///<remarks>
            ///Interpretation of the values differ per shape.
            ///         Sphere  - X is Sphere Radius. Y and Z are unused
            ///         Capsule - X is Capsule Half Height, Y is Capsule Radius, Z is unused
            ///         Box     - X, Y, and Z are the Box's dimensions
            ///         Cone    - X is Cone Radius, Y is Cone Angle, Z is Cone Falloff Angle
            ///</remarks>
            [FieldOffset(16)] Vector AttenuationShapeExtents;

            [FieldOffset(28)] public float ConeOffset;

            [FieldOffset(32)] public float FalloffDistance;

            ///<summary>The custom volume attenuation curve to use.</summary>
            [FieldOffset(40)] RuntimeFloatCurve CustomAttenuationCurve;

        }
}

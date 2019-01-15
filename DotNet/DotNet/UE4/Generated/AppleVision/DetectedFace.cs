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


namespace UE4.AppleVision{
        ///<summary>Area of the image that the computer vision task detected as being a face</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct DetectedFace {
            ///<summary>The bounding box of the detected face</summary>
            [FieldOffset(24)] Box2D BoundingBox;

            [FieldOffset(48)] byte Features; //TODO: array TArray Features

            [FieldOffset(64)] byte FeatureRegions; //TODO: array TArray FeatureRegions

        }
}

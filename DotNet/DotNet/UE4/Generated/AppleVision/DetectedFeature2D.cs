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
        ///<summary>Area of the image that the computer vision task detected as being of a particular type</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct DetectedFeature2D {
            ///<summary>The bounding box of the detected feature in the image</summary>
            [FieldOffset(4)] Box2D BoundingBox;

        }
}

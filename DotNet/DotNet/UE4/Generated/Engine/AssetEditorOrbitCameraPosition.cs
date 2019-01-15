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
        ///<summary>Asset Editor Orbit Camera Position</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct AssetEditorOrbitCameraPosition {
            [FieldOffset(0)] public bool bIsSet;

            ///<summary>The position to orbit the camera around</summary>
            [FieldOffset(4)] Vector CamOrbitPoint;

            ///<summary>The distance of the camera from the orbit point</summary>
            [FieldOffset(16)] Vector CamOrbitZoom;

            ///<summary>The rotation to apply around the orbit point</summary>
            [FieldOffset(28)] Rotator CamOrbitRotation;

        }
}

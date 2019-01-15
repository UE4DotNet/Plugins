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
        ///<summary>Saved editor viewport state information</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct LevelViewportInfo {
            ///<summary>Where the camera is positioned within the viewport.</summary>
            [FieldOffset(0)] Vector CamPosition;

            ///<summary>The camera's position within the viewport.</summary>
            [FieldOffset(12)] Rotator CamRotation;

            [FieldOffset(24)] public float CamOrthoZoom;

            [FieldOffset(28)] public bool CamUpdated;

        }
}

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
        ///<summary>Settings that control the behavior of the "snap to surface" feature</summary>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct SnapToSurfaceSettings {
            [FieldOffset(0)] public bool bEnabled;

            [FieldOffset(4)] public float SnapOffsetExtent;

            [FieldOffset(8)] public bool bSnapRotation;

        }
}

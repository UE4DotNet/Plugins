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


namespace UE4.GeometryCacheTracks{
        ///<summary>Movie Scene Geometry Cache Params</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct MovieSceneGeometryCacheParams {
            ///<summary>The animation this section plays</summary>
            [FieldOffset(0)] SoftObjectPath GeometryCache;

            [FieldOffset(32)] public float StartOffset;

            [FieldOffset(36)] public float EndOffset;

            [FieldOffset(40)] public float PlayRate;

            [FieldOffset(44)] public bool bReverse;

        }
}

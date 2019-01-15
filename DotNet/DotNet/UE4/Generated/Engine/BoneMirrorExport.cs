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
        ///<summary>Structure to export/import bone mirroring information</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct BoneMirrorExport {
            [FieldOffset(0)] public Name BoneName;

            [FieldOffset(12)] public Name SourceBoneName;

            [FieldOffset(24)] public byte BoneFlipAxis;

        }
}

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
        ///<summary>Due to BulkSerialize we can't edit the struct, so we must deprecated this one and create a new one</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct ClusterNode_DEPRECATED {
            ///<summary>Bound Min</summary>
            [FieldOffset(0)] Vector BoundMin;

            [FieldOffset(12)] public int FirstChild;

            ///<summary>Bound Max</summary>
            [FieldOffset(16)] Vector BoundMax;

            [FieldOffset(28)] public int LastChild;

            [FieldOffset(32)] public int FirstInstance;

            [FieldOffset(36)] public int LastInstance;

        }
}

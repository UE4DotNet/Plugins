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
        ///<summary>Float curve data for one track</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct AnimCurveBase {
            ///<summary>Name</summary>
            [FieldOffset(12)] SmartName Name;

            [FieldOffset(28)] public int CurveTypeFlags;

        }
}

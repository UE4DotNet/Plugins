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
        ///<summary>Navigation Segment Link</summary>
        [StructLayout( LayoutKind.Explicit, Size=120 )]
        public unsafe struct NavigationSegmentLink {
            ///<summary>Left Start</summary>
            [FieldOffset(72)] Vector LeftStart;

            ///<summary>Left End</summary>
            [FieldOffset(84)] Vector LeftEnd;

            ///<summary>Right Start</summary>
            [FieldOffset(96)] Vector RightStart;

            ///<summary>Right End</summary>
            [FieldOffset(108)] Vector RightEnd;

        }
}

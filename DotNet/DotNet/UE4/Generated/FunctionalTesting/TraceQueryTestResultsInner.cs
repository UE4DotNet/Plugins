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


namespace UE4.FunctionalTesting{
        ///<summary>Trace Query Test Results Inner</summary>
        [StructLayout( LayoutKind.Explicit, Size=896 )]
        public unsafe struct TraceQueryTestResultsInner {
            ///<summary>The results associated with the line trace</summary>
            [FieldOffset(0)] TraceQueryTestResultsInnerMost LineResults;

            ///<summary>The results associated with the sphere</summary>
            [FieldOffset(224)] TraceQueryTestResultsInnerMost SphereResults;

            ///<summary>The results associated with the capsule</summary>
            [FieldOffset(448)] TraceQueryTestResultsInnerMost CapsuleResults;

            ///<summary>The results associated with the box</summary>
            [FieldOffset(672)] TraceQueryTestResultsInnerMost BoxResults;

        }
}

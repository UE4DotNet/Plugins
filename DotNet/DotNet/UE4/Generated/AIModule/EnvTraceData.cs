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

using UE4.NavigationSystem;

namespace UE4.AIModule{
        ///<summary>Env Trace Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct EnvTraceData {
            [FieldOffset(0)] public int VersionNum;

            ///<summary>navigation filter for tracing</summary>
            public SubclassOf<NavigationQueryFilter> NavigationFilter {
                get {return NavigationFilter_class; }
                set {NavigationFilter_class = value; }
            }
            [FieldOffset(8)] private IntPtr NavigationFilter_class;

            [FieldOffset(16)] public float ProjectDown;

            [FieldOffset(20)] public float ProjectUp;

            [FieldOffset(24)] public float ExtentX;

            [FieldOffset(28)] public float ExtentY;

            [FieldOffset(32)] public float ExtentZ;

            [FieldOffset(36)] public float PostProjectionVerticalOffset;

            [FieldOffset(40)] public byte TraceChannel;

            [FieldOffset(41)] public byte SerializedChannel;

            [FieldOffset(42)] public byte TraceShape;

            [FieldOffset(43)] public byte TraceMode;

            [FieldOffset(44)] public bool bTraceComplex;

            [FieldOffset(44)] public bool bOnlyBlockingHits;

            [FieldOffset(44)] public bool bCanTraceOnNavMesh;

            [FieldOffset(44)] public bool bCanTraceOnGeometry;

            [FieldOffset(44)] public bool bCanDisableTrace;

            [FieldOffset(44)] public bool bCanProjectDown;

        }
}

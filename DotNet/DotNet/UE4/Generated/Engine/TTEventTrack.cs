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
        ///<summary>Structure storing information about one event track</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct TTEventTrack {
            [FieldOffset(16)] 
            private IntPtr  CurveKeys_field;
            ///<summary>Curve object used to store keys</summary>
            public CurveFloat CurveKeys {
                get {return CurveKeys_field;}
                set {CurveKeys_field = value;}
            }

        }
}

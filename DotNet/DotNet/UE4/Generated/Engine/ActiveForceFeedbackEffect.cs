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
        ///<summary>Active Force Feedback Effect</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct ActiveForceFeedbackEffect {
            [FieldOffset(0)] 
            private IntPtr  ForceFeedbackEffect_field;
            ///<summary>Force Feedback Effect</summary>
            public ForceFeedbackEffect ForceFeedbackEffect {
                get {return ForceFeedbackEffect_field;}
                set {ForceFeedbackEffect_field = value;}
            }

        }
}

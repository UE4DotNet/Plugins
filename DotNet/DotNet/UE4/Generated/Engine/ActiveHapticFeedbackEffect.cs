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
        ///<summary>Active Haptic Feedback Effect</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct ActiveHapticFeedbackEffect {
            [FieldOffset(0)] 
            private IntPtr  HapticEffect_field;
            ///<summary>Haptic Effect</summary>
            public HapticFeedbackEffect_Base HapticEffect {
                get {return HapticEffect_field;}
                set {HapticEffect_field = value;}
            }

        }
}

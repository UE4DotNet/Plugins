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

using UE4.Engine;

namespace UE4.AIModule{
        ///<summary>AITouch Event</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct AITouchEvent {
            [FieldOffset(16)] 
            private IntPtr  TouchReceiver_field;
            ///<summary>Touch Receiver</summary>
            public Actor TouchReceiver {
                get {return TouchReceiver_field;}
                set {TouchReceiver_field = value;}
            }

            [FieldOffset(24)] 
            private IntPtr  OtherActor_field;
            ///<summary>Other Actor</summary>
            public Actor OtherActor {
                get {return OtherActor_field;}
                set {OtherActor_field = value;}
            }

        }
}

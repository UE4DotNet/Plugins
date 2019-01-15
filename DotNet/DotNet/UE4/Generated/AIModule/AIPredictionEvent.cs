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
        ///<summary>AIPrediction Event</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct AIPredictionEvent {
            [FieldOffset(0)] 
            private IntPtr  Requestor_field;
            ///<summary>Requestor</summary>
            public Actor Requestor {
                get {return Requestor_field;}
                set {Requestor_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  PredictedActor_field;
            ///<summary>Predicted Actor</summary>
            public Actor PredictedActor {
                get {return PredictedActor_field;}
                set {PredictedActor_field = value;}
            }

        }
}

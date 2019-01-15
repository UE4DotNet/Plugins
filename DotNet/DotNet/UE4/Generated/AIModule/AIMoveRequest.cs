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
        ///<summary>AIMove Request</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct AIMoveRequest {
            [FieldOffset(0)] 
            private IntPtr  GoalActor_field;
            ///<summary>move goal: actor</summary>
            public Actor GoalActor {
                get {return GoalActor_field;}
                set {GoalActor_field = value;}
            }

        }
}

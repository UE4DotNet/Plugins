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

namespace UE4.LevelSequence{
        ///<summary>Bound Actor Proxy</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct BoundActorProxy {
            [FieldOffset(0)] 
            private IntPtr  BoundActor_field;
            ///<summary>Specifies the actor to override the binding with</summary>
            public Actor BoundActor {
                get {return BoundActor_field;}
                set {BoundActor_field = value;}
            }

        }
}

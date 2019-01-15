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

namespace UE4.GameplayDebugger{
        ///<summary>Gameplay Debugger Debug Actor</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct GameplayDebuggerDebugActor {
            [FieldOffset(0)] 
            private IntPtr  Actor_field;
            ///<summary>Actor</summary>
            public Actor Actor {
                get {return Actor_field;}
                set {Actor_field = value;}
            }

            [FieldOffset(8)] public Name ActorName;

            [FieldOffset(20)] public int SyncCounter;

        }
}

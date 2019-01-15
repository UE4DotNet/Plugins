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
        ///<summary>AITeam Stimulus Event</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct AITeamStimulusEvent {
            [FieldOffset(40)] 
            private IntPtr  Broadcaster_field;
            ///<summary>Broadcaster</summary>
            public Actor Broadcaster {
                get {return Broadcaster_field;}
                set {Broadcaster_field = value;}
            }

            [FieldOffset(48)] 
            private IntPtr  Enemy_field;
            ///<summary>Enemy</summary>
            public Actor Enemy {
                get {return Enemy_field;}
                set {Enemy_field = value;}
            }

        }
}

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
        ///<summary>AINoise Event</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct AINoiseEvent {
            ///<summary>if not set Instigator's location will be used</summary>
            [FieldOffset(4)] Vector NoiseLocation;

            [FieldOffset(16)] public float Loudness;

            [FieldOffset(20)] public float MaxRange;

            [FieldOffset(24)] 
            private IntPtr  Instigator_field;
            ///<summary>Actor triggering the sound.</summary>
            public Actor Instigator {
                get {return Instigator_field;}
                set {Instigator_field = value;}
            }

            [FieldOffset(32)] public Name Tag;

        }
}

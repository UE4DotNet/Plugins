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

namespace UE4.AnimGraphRuntime{
        ///<summary>
        ///The random player node holds a list of sequences and parameter ranges which will be played continuously
        ///In a random order.
        ///</summary>
        ///<remarks>If shuffle mode is enabled then each entry will be played once before repeating any</remarks>
        [StructLayout( LayoutKind.Explicit, Size=88 )]
        public unsafe struct RandomPlayerSequenceEntry {
            [FieldOffset(0)] 
            private IntPtr  Sequence_field;
            ///<summary>Sequence to play when this entry is picked</summary>
            public AnimSequence Sequence {
                get {return Sequence_field;}
                set {Sequence_field = value;}
            }

            [FieldOffset(8)] public float ChanceToPlay;

            [FieldOffset(12)] public int MinLoopCount;

            [FieldOffset(16)] public int MaxLoopCount;

            [FieldOffset(20)] public float MinPlayRate;

            [FieldOffset(24)] public float MaxPlayRate;

            ///<summary>Blending properties used when this entry is blending in ontop of another entry</summary>
            [FieldOffset(32)] AlphaBlend BlendIn;

        }
}

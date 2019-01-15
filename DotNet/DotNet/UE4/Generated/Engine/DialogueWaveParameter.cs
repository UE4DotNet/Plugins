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
        ///<summary>Dialogue Wave Parameter</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct DialogueWaveParameter {
            [FieldOffset(0)] 
            private IntPtr  DialogueWave_field;
            ///<summary>The dialogue wave to play.</summary>
            public DialogueWave DialogueWave {
                get {return DialogueWave_field;}
                set {DialogueWave_field = value;}
            }

            ///<summary>The context to use for the dialogue wave.</summary>
            [FieldOffset(8)] DialogueContext Context;

        }
}

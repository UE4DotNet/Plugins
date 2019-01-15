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
        ///<summary>Struct used for storing one per-instance named parameter for this AudioComponent.</summary>
        ///<remarks>Certain nodes in the SoundCue may reference parameters by name so they can be adjusted per-instance.</remarks>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct AudioComponentParam {
            [FieldOffset(0)] public Name ParamName;

            [FieldOffset(12)] public float FloatParam;

            [FieldOffset(16)] public bool BoolParam;

            [FieldOffset(20)] public int IntParam;

            [FieldOffset(24)] 
            private IntPtr  SoundWaveParam_field;
            ///<summary>Value of the parameter when used as a sound wave</summary>
            public SoundWave SoundWaveParam {
                get {return SoundWaveParam_field;}
                set {SoundWaveParam_field = value;}
            }

        }
}

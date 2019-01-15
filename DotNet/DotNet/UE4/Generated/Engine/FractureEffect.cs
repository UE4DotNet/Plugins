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
        ///<summary>Struct used to hold effects for destructible damage events</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct FractureEffect {
            [FieldOffset(0)] 
            private IntPtr  ParticleSystem_field;
            ///<summary>Particle system effect to play at fracture location.</summary>
            public ParticleSystem ParticleSystem {
                get {return ParticleSystem_field;}
                set {ParticleSystem_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  Sound_field;
            ///<summary>Sound cue to play at fracture location.</summary>
            public SoundBase Sound {
                get {return Sound_field;}
                set {Sound_field = value;}
            }

        }
}

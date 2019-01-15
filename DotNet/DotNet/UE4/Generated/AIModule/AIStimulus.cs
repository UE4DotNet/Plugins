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


namespace UE4.AIModule{
        ///<summary>AIStimulus</summary>
        [StructLayout( LayoutKind.Explicit, Size=68 )]
        public unsafe struct AIStimulus {
            [FieldOffset(0)] public float Age;

            [FieldOffset(4)] public float ExpirationAge;

            [FieldOffset(8)] public float Strength;

            ///<summary>Stimulus Location</summary>
            [FieldOffset(12)] Vector StimulusLocation;

            ///<summary>Receiver Location</summary>
            [FieldOffset(24)] Vector ReceiverLocation;

            [FieldOffset(36)] public Name Tag;

            [FieldOffset(64)] public bool bSuccessfullySensed;

        }
}

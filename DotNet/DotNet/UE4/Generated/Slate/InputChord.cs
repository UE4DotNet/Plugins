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

using UE4.InputCore;

namespace UE4.Slate{
        ///<summary>An Input Chord is a key and the modifier keys that are to be held with it.</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct InputChord {
            ///<summary>The Key is the core of the chord.</summary>
            [FieldOffset(0)] Key Key;

            [FieldOffset(32)] public bool bShift;

            [FieldOffset(32)] public bool bCtrl;

            [FieldOffset(32)] public bool bAlt;

            [FieldOffset(32)] public bool bCmd;

        }
}

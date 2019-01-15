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
        ///<summary>
        ///A group, associated with a particular  AActor  or set of Actors, which contains a set of InterpTracks for interpolating
        ///properties of the  AActor  over time.
        ///</summary>
        ///<remarks>The Outer of an UInterpGroup is an InterpData.</remarks>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct InterpEdSelKey {
            [FieldOffset(0)] 
            private IntPtr  Group_field;
            ///<summary>Group</summary>
            public InterpGroup Group {
                get {return Group_field;}
                set {Group_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  Track_field;
            ///<summary>Track</summary>
            public InterpTrack Track {
                get {return Track_field;}
                set {Track_field = value;}
            }

            [FieldOffset(16)] public int KeyIndex;

            [FieldOffset(20)] public float UnsnappedPosition;

        }
}

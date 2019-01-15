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
        ///<summary>Single Animation Play Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct SingleAnimationPlayData {
            [FieldOffset(0)] 
            private IntPtr  AnimToPlay_field;
            ///<summary>@</summary>
            ///<remarks>
            ///todo in the future, we should make this one UObject
            ///and have detail customization to display different things
            ///The default sequence to play on this skeletal mesh
            ///</remarks>
            public AnimationAsset AnimToPlay {
                get {return AnimToPlay_field;}
                set {AnimToPlay_field = value;}
            }

            [FieldOffset(8)] public bool bSavedLooping;

            [FieldOffset(8)] public bool bSavedPlaying;

            [FieldOffset(12)] public float SavedPosition;

            [FieldOffset(16)] public float SavedPlayRate;

        }
}

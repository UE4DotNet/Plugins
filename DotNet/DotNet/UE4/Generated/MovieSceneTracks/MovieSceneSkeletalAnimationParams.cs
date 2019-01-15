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
using UE4.MovieScene;

namespace UE4.MovieSceneTracks{
        ///<summary>Movie Scene Skeletal Animation Params</summary>
        [StructLayout( LayoutKind.Explicit, Size=208 )]
        public unsafe struct MovieSceneSkeletalAnimationParams {
            [FieldOffset(0)] 
            private IntPtr  Animation_field;
            ///<summary>The animation this section plays</summary>
            public AnimSequenceBase Animation {
                get {return Animation_field;}
                set {Animation_field = value;}
            }

            [FieldOffset(8)] public float StartOffset;

            [FieldOffset(12)] public float EndOffset;

            [FieldOffset(16)] public float PlayRate;

            [FieldOffset(20)] public bool bReverse;

            [FieldOffset(24)] public Name SlotName;

            ///<summary>The weight curve for this animation section</summary>
            [FieldOffset(40)] MovieSceneFloatChannel Weight;

            [FieldOffset(200)] public bool bSkipAnimNotifiers;

        }
}

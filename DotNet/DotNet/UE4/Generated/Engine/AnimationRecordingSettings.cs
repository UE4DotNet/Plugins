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
        ///<summary>Settings describing how to record an animation</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct AnimationRecordingSettings {
            [FieldOffset(0)] public bool bRecordInWorldSpace;

            [FieldOffset(1)] public bool bRemoveRootAnimation;

            [FieldOffset(2)] public bool bAutoSaveAsset;

            [FieldOffset(4)] public float SampleRate;

            [FieldOffset(8)] public float Length;

            [FieldOffset(12)] public byte InterpMode;

            [FieldOffset(13)] public byte TangentMode;

        }
}

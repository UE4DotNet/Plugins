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


namespace UE4.MovieScene{
        ///<summary>Settings for the level sequence player actor.</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct MovieSceneSequencePlaybackSettings {
            [FieldOffset(0)] public int LoopCount;

            [FieldOffset(4)] public float PlayRate;

            [FieldOffset(8)] public bool bRandomStartTime;

            [FieldOffset(12)] public float StartTime;

            [FieldOffset(16)] public bool bRestoreState;

            [FieldOffset(17)] public bool bDisableMovementInput;

            [FieldOffset(18)] public bool bDisableLookAtInput;

            [FieldOffset(19)] public bool bHidePlayer;

            [FieldOffset(20)] public bool bHideHud;

            [FieldOffset(21)] public bool bDisableCameraCuts;

            [FieldOffset(22)] public bool bPauseAtEnd;

            [FieldOffset(24)] 
            private IntPtr  InstanceData_field;
            ///<summary>An object that can implement specific instance overrides for the sequence</summary>
            public UObject InstanceData {
                get {return InstanceData_field;}
                set {InstanceData_field = value;}
            }

            [FieldOffset(32)] byte BindingOverrides; //TODO: interface TScriptInterface BindingOverrides

        }
}

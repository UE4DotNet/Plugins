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
        ///<summary>Movie Scene Easing Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct MovieSceneEasingSettings {
            [FieldOffset(0)] public int AutoEaseInDuration;

            [FieldOffset(4)] public int AutoEaseOutDuration;

            [FieldOffset(8)] byte EaseIn; //TODO: interface TScriptInterface EaseIn

            [FieldOffset(24)] public bool bManualEaseIn;

            [FieldOffset(28)] public int ManualEaseInDuration;

            [FieldOffset(32)] byte EaseOut; //TODO: interface TScriptInterface EaseOut

            [FieldOffset(48)] public bool bManualEaseOut;

            [FieldOffset(52)] public int ManualEaseOutDuration;

        }
}

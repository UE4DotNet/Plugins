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
        ///<summary>Struct encapsulating settings for reverb effects.</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct ReverbSettings {
            [FieldOffset(0)] public bool bApplyReverb;

            [FieldOffset(8)] 
            private IntPtr  ReverbEffect_field;
            ///<summary>The reverb asset to employ.</summary>
            public ReverbEffect ReverbEffect {
                get {return ReverbEffect_field;}
                set {ReverbEffect_field = value;}
            }

            [FieldOffset(16)] 
            private IntPtr  ReverbPluginEffect_field;
            ///<summary>This is used to apply plugin-specific settings when a Reverb Plugin is being used.</summary>
            public SoundEffectSubmixPreset ReverbPluginEffect {
                get {return ReverbPluginEffect_field;}
                set {ReverbPluginEffect_field = value;}
            }

            [FieldOffset(24)] public float Volume;

            [FieldOffset(28)] public float FadeTime;

        }
}

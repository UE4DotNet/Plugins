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
        ///<summary>Sound Attenuation Plugin Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct SoundAttenuationPluginSettings {
            [FieldOffset(0)] byte SpatializationPluginSettingsArray; //TODO: array TArray SpatializationPluginSettingsArray

            [FieldOffset(16)] byte OcclusionPluginSettingsArray; //TODO: array TArray OcclusionPluginSettingsArray

            [FieldOffset(32)] byte ReverbPluginSettingsArray; //TODO: array TArray ReverbPluginSettingsArray

        }
}

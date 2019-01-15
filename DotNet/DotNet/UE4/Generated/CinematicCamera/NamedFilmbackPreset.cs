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


namespace UE4.CinematicCamera{
        ///<summary>A named bundle of filmback settings used to implement filmback presets</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct NamedFilmbackPreset {
            [FieldOffset(0)] byte Name; //TODO: string FString Name

            ///<summary>Filmback Settings</summary>
            [FieldOffset(16)] CameraFilmbackSettings FilmbackSettings;

        }
}

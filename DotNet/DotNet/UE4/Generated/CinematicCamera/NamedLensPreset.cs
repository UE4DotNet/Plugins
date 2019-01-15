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
        ///<summary>A named bundle of lens settings used to implement lens presets.</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct NamedLensPreset {
            [FieldOffset(0)] byte Name; //TODO: string FString Name

            ///<summary>Lens Settings</summary>
            [FieldOffset(16)] CameraLensSettings LensSettings;

        }
}

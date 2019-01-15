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

namespace UE4.MovieSceneCapture{
        ///<summary>Common movie-scene capture settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct MovieSceneCaptureSettings {
            ///<summary>The directory to output the captured file(s) in</summary>
            [FieldOffset(0)] DirectoryPath OutputDirectory;

            ///<summary>Optional game mode to override the map's default game mode with.  This can be useful if the game's normal mode displays UI elements or loading screens that you don't want captured.</summary>
            public SubclassOf<GameModeBase> GameModeOverride {
                get {return GameModeOverride_class; }
                set {GameModeOverride_class = value; }
            }
            [FieldOffset(16)] private IntPtr GameModeOverride_class;

            [FieldOffset(24)] byte OutputFormat; //TODO: string FString OutputFormat

            [FieldOffset(40)] public bool bOverwriteExisting;

            [FieldOffset(41)] public bool bUseRelativeFrameNumbers;

            [FieldOffset(44)] public int HandleFrames;

            [FieldOffset(48)] public byte ZeroPadFrameNumbers;

            ///<summary>The frame rate at which to capture</summary>
            [FieldOffset(52)] FrameRate FrameRate;

            ///<summary>The resolution at which to capture</summary>
            [FieldOffset(60)] CaptureResolution Resolution;

            [FieldOffset(68)] public bool bEnableTextureStreaming;

            [FieldOffset(69)] public bool bCinematicEngineScalability;

            [FieldOffset(70)] public bool bCinematicMode;

            [FieldOffset(71)] public bool bAllowMovement;

            [FieldOffset(72)] public bool bAllowTurning;

            [FieldOffset(73)] public bool bShowPlayer;

            [FieldOffset(74)] public bool bShowHUD;

        }
}

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

namespace UE4.LevelSequence{
        ///<summary>Frame snapshot information for a level sequence</summary>
        [StructLayout( LayoutKind.Explicit, Size=136 )]
        public unsafe struct LevelSequencePlayerSnapshot {
            [FieldOffset(0)] byte MasterName; //TODO: string FString MasterName

            ///<summary>Master Time</summary>
            [FieldOffset(16)] QualifiedFrameTime MasterTime;

            ///<summary>Source Time</summary>
            [FieldOffset(32)] QualifiedFrameTime SourceTime;

            [FieldOffset(48)] byte CurrentShotName; //TODO: string FString CurrentShotName

            ///<summary>Current Shot Local Time</summary>
            [FieldOffset(64)] QualifiedFrameTime CurrentShotLocalTime;

            ///<summary>Current Shot Source Time</summary>
            [FieldOffset(80)] QualifiedFrameTime CurrentShotSourceTime;

            [FieldOffset(96)] byte SourceTimecode; //TODO: string FString SourceTimecode

            [FieldOffset(112)] 
            private IntPtr  CameraComponent_field;
            ///<summary>Camera Component</summary>
            public CameraComponent CameraComponent {
                get {return CameraComponent_field;}
            }

            ///<summary>Settings</summary>
            [FieldOffset(120)] LevelSequenceSnapshotSettings Settings;

            ///<summary>Shot ID</summary>
            [FieldOffset(132)] MovieSceneSequenceID ShotID;

        }
}

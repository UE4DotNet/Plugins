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


namespace UE4.MovieSceneTools{
        ///<summary>Movie Scene Tools Fbx Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct MovieSceneToolsFbxSettings {
            [FieldOffset(0)] byte FbxPropertyName; //TODO: string FString FbxPropertyName

            ///<summary>The property track setting to map to</summary>
            [FieldOffset(16)] MovieSceneToolsPropertyTrackSettings PropertyPath;

        }
}

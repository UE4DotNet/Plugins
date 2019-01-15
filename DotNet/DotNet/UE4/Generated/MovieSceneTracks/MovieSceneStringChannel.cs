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


namespace UE4.MovieSceneTracks{
        ///<summary>Movie Scene String Channel</summary>
        [StructLayout( LayoutKind.Explicit, Size=160 )]
        public unsafe struct MovieSceneStringChannel {
            [FieldOffset(8)] byte Times; //TODO: array TArray Times

            [FieldOffset(24)] byte Values; //TODO: array TArray Values

            [FieldOffset(40)] byte DefaultValue; //TODO: string FString DefaultValue

            [FieldOffset(56)] public bool bHasDefaultValue;

        }
}

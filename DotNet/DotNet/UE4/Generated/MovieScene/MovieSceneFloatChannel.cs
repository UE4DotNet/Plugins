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
        ///<summary>Movie Scene Float Channel</summary>
        [StructLayout( LayoutKind.Explicit, Size=160 )]
        public unsafe struct MovieSceneFloatChannel {
            [FieldOffset(8)] public byte PreInfinityExtrap;

            [FieldOffset(9)] public byte PostInfinityExtrap;

            [FieldOffset(16)] byte Times; //TODO: array TArray Times

            [FieldOffset(32)] byte Values; //TODO: array TArray Values

            [FieldOffset(48)] public float DefaultValue;

            [FieldOffset(52)] public bool bHasDefaultValue;

            ///<summary>This needs to be a UPROPERTY so it gets saved into editor transactions but transient so it doesn't get saved into assets.</summary>
            [FieldOffset(56)] MovieSceneKeyHandleMap KeyHandles;

            ///<summary>Tick Resolution</summary>
            [FieldOffset(152)] FrameRate TickResolution;

        }
}

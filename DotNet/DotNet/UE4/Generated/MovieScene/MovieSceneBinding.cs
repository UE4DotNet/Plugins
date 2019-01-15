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
        ///<summary>A set of tracks bound to runtime objects</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct MovieSceneBinding {
            ///<summary>Object binding guid for runtime objects</summary>
            [FieldOffset(0)] FGuid ObjectGuid;

            [FieldOffset(16)] byte BindingName; //TODO: string FString BindingName

            [FieldOffset(32)] byte Tracks; //TODO: array TArray Tracks

            [FieldOffset(48)] public int SortingOrder;

        }
}

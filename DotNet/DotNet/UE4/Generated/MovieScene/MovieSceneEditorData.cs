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
        ///<summary>Editor only data that needs to be saved between sessions for editing but has no runtime purpose</summary>
        [StructLayout( LayoutKind.Explicit, Size=224 )]
        public unsafe struct MovieSceneEditorData {
            [FieldOffset(0)] byte ExpansionStates; //TODO: map TMap ExpansionStates

            [FieldOffset(80)] public double ViewStart;

            [FieldOffset(88)] public double ViewEnd;

            [FieldOffset(96)] public double WorkStart;

            [FieldOffset(104)] public double WorkEnd;

            [FieldOffset(112)] byte MarkedFrames; //TODO: set TSet MarkedFrames

        }
}

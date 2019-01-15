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


namespace UE4.UnrealEd{
        ///<summary>Holds information about a screen resolution to be used for playing.</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct PlayScreenResolution {
            [FieldOffset(0)] byte Description; //TODO: string FString Description

            [FieldOffset(16)] public int Width;

            [FieldOffset(20)] public int Height;

            [FieldOffset(24)] byte AspectRatio; //TODO: string FString AspectRatio

            [FieldOffset(40)] public bool bCanSwapAspectRatio;

            [FieldOffset(48)] byte ProfileName; //TODO: string FString ProfileName

        }
}

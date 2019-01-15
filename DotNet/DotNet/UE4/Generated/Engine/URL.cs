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


namespace UE4.Engine{
        ///<summary>URL structure.</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct URL {
            [FieldOffset(0)] byte Protocol; //TODO: string FString Protocol

            [FieldOffset(16)] byte Host; //TODO: string FString Host

            [FieldOffset(32)] public int Port;

            [FieldOffset(40)] byte Map; //TODO: string FString Map

            [FieldOffset(56)] byte RedirectURL; //TODO: string FString RedirectURL

            [FieldOffset(72)] byte Op; //TODO: array TArray Op

            [FieldOffset(88)] byte Portal; //TODO: string FString Portal

            [FieldOffset(104)] public int Valid;

        }
}

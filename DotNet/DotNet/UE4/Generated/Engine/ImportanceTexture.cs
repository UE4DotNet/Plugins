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
        ///<summary>Texture processed for importance sampling</summary>
        ///<remarks>Holds marginal PDF of the rows, as well as the PDF of each row</remarks>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct ImportanceTexture {
            ///<summary>active texture dimensions, capped to 1024 x 1024</summary>
            [FieldOffset(0)] IntPoint Size;

            [FieldOffset(8)] public int NumMips;

            [FieldOffset(16)] byte MarginalCDF; //TODO: array TArray MarginalCDF

            [FieldOffset(32)] byte ConditionalCDF; //TODO: array TArray ConditionalCDF

            [FieldOffset(48)] byte TextureData; //TODO: array TArray TextureData

            [FieldOffset(64)] byte Texture; //TODO: weak object TWeakObjectPtr<UTexture2D> Texture

            [FieldOffset(72)] public byte Weighting;

        }
}

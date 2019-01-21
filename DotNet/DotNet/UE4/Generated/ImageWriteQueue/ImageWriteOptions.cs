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


namespace UE4.ImageWriteQueue{
        ///<summary>Options specific to writing image files to disk</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct ImageWriteOptions {
            [FieldOffset(0)] byte Format; //TODO: enum EDesiredImageFormat Format

            [FieldOffset(4)] byte OnComplete; //TODO: delegate FOnImageWriteComplete OnComplete

            [FieldOffset(24)] public int CompressionQuality;

            [FieldOffset(28)] public bool bOverwriteFile;

            [FieldOffset(29)] public bool bAsync;

        }
}

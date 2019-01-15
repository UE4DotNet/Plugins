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


namespace UE4.CoreUObject{
        ///<summary>An object path, this is saved as a name/string pair</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct SoftObjectPath {
            [FieldOffset(0)] public Name AssetPathName;

            [FieldOffset(16)] byte SubPathString; //TODO: string FString SubPathString

        }
}

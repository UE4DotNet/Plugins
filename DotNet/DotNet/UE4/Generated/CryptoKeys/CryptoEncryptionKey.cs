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


namespace UE4.CryptoKeys{
        ///<summary>UStruct representing a named encryption key</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct CryptoEncryptionKey {
            ///<summary>Guid</summary>
            [FieldOffset(0)] FGuid FGuid;

            [FieldOffset(16)] byte Name; //TODO: string FString Name

            [FieldOffset(32)] byte Key; //TODO: string FString Key

        }
}

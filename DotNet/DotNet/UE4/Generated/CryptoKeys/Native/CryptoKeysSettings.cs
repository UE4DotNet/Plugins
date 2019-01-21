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


namespace UE4.CryptoKeys.Native {
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct CryptoKeysSettings_fields {
        [FieldOffset(56)] byte EncryptionKey; //TODO: string FString EncryptionKey
        [FieldOffset(72)] public NativeArray SecondaryEncryptionKeys;
        [FieldOffset(88)] public bool bEncryptPakIniFiles;
        [FieldOffset(89)] public bool bEncryptPakIndex;
        [FieldOffset(90)] public bool bEncryptUAssetFiles;
        [FieldOffset(91)] public bool bEncryptAllAssetFiles;
        [FieldOffset(96)] byte SigningPublicExponent; //TODO: string FString SigningPublicExponent
        [FieldOffset(112)] byte SigningModulus; //TODO: string FString SigningModulus
        [FieldOffset(128)] byte SigningPrivateExponent; //TODO: string FString SigningPrivateExponent
        [FieldOffset(144)] public bool bEnablePakSigning;
    }
    internal unsafe struct CryptoKeysSettings_methods {
    }
    internal unsafe struct CryptoKeysSettings_events {
    }
}

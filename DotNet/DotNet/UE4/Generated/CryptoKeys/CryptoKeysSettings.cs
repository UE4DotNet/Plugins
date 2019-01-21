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

#pragma warning disable CS0108
using UE4.CryptoKeys.Native;

namespace UE4.CryptoKeys {
    ///<summary>Implements the settings for imported Paper2D assets, such as sprite sheet textures.</summary>
    public unsafe partial class CryptoKeysSettings : UObject  {
         //TODO: string FString EncryptionKey
         //TODO: array not UObject TArray SecondaryEncryptionKeys
        public bool bEncryptPakIniFiles {
            get {return Main.GetGetBoolPropertyByName(this, "bEncryptPakIniFiles"); }
            set {Main.SetGetBoolPropertyByName(this, "bEncryptPakIniFiles", value); }
        }
        public bool bEncryptPakIndex {
            get {return Main.GetGetBoolPropertyByName(this, "bEncryptPakIndex"); }
            set {Main.SetGetBoolPropertyByName(this, "bEncryptPakIndex", value); }
        }
        public bool bEncryptUAssetFiles {
            get {return Main.GetGetBoolPropertyByName(this, "bEncryptUAssetFiles"); }
            set {Main.SetGetBoolPropertyByName(this, "bEncryptUAssetFiles", value); }
        }
        public bool bEncryptAllAssetFiles {
            get {return Main.GetGetBoolPropertyByName(this, "bEncryptAllAssetFiles"); }
            set {Main.SetGetBoolPropertyByName(this, "bEncryptAllAssetFiles", value); }
        }
         //TODO: string FString SigningPublicExponent
         //TODO: string FString SigningModulus
         //TODO: string FString SigningPrivateExponent
        public bool bEnablePakSigning {
            get {return Main.GetGetBoolPropertyByName(this, "bEnablePakSigning"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnablePakSigning", value); }
        }
        static CryptoKeysSettings() {
            StaticClass = Main.GetClass("CryptoKeysSettings");
        }
        internal unsafe CryptoKeysSettings_fields* CryptoKeysSettings_ptr => (CryptoKeysSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CryptoKeysSettings(IntPtr p) => UObject.Make<CryptoKeysSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CryptoKeysSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CryptoKeysSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>A seed file that is created to mark referenced assets as part of this primary asset</summary>
    public unsafe partial class PrimaryAssetLabel : PrimaryDataAsset  {
        ///<summary>Management rules for this specific asset, if set it will override the type rules</summary>
        public unsafe PrimaryAssetRules Rules {
            get {return PrimaryAssetLabel_ptr->Rules;}
            set {PrimaryAssetLabel_ptr->Rules = value;}
        }
        public bool bLabelAssetsInMyDirectory {
            get {return Main.GetGetBoolPropertyByName(this, "bLabelAssetsInMyDirectory"); }
            set {Main.SetGetBoolPropertyByName(this, "bLabelAssetsInMyDirectory", value); }
        }
        public bool bIsRuntimeLabel {
            get {return Main.GetGetBoolPropertyByName(this, "bIsRuntimeLabel"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsRuntimeLabel", value); }
        }
         //TODO: array not UObject TArray ExplicitAssets
         //TODO: array not UObject TArray ExplicitBlueprints
        ///<summary>Collection to load asset references out of</summary>
        public unsafe CollectionReference AssetCollection {
            get {return PrimaryAssetLabel_ptr->AssetCollection;}
            set {PrimaryAssetLabel_ptr->AssetCollection = value;}
        }
        static PrimaryAssetLabel() {
            StaticClass = Main.GetClass("PrimaryAssetLabel");
        }
        internal unsafe PrimaryAssetLabel_fields* PrimaryAssetLabel_ptr => (PrimaryAssetLabel_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PrimaryAssetLabel(IntPtr p) => UObject.Make<PrimaryAssetLabel>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PrimaryAssetLabel DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PrimaryAssetLabel New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

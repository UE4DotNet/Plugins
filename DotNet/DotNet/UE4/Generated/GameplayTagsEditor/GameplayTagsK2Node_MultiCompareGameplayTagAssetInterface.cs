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
using UE4.GameplayTagsEditor.Native;

namespace UE4.GameplayTagsEditor {
    ///<summary>Gameplay Tags K2Node Multi Compare Gameplay Tag Asset Interface</summary>
    public unsafe partial class GameplayTagsK2Node_MultiCompareGameplayTagAssetInterface : GameplayTagsK2Node_MultiCompareBase  {
        static GameplayTagsK2Node_MultiCompareGameplayTagAssetInterface() {
            StaticClass = Main.GetClass("GameplayTagsK2Node_MultiCompareGameplayTagAssetInterface");
        }
        internal unsafe GameplayTagsK2Node_MultiCompareGameplayTagAssetInterface_fields* GameplayTagsK2Node_MultiCompareGameplayTagAssetInterface_ptr => (GameplayTagsK2Node_MultiCompareGameplayTagAssetInterface_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayTagsK2Node_MultiCompareGameplayTagAssetInterface(IntPtr p) => UObject.Make<GameplayTagsK2Node_MultiCompareGameplayTagAssetInterface>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayTagsK2Node_MultiCompareGameplayTagAssetInterface DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayTagsK2Node_MultiCompareGameplayTagAssetInterface New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

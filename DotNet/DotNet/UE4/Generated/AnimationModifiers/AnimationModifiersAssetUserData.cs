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
using UE4.AnimationModifiers.Native;
using UE4.Engine;

namespace UE4.AnimationModifiers {
    ///<summary>Asset user data which can be added to a USkeleton or UAnimSequence to keep track of Animation Modifiers</summary>
    public unsafe partial class AnimationModifiersAssetUserData : AssetUserData  {
        ///<summary>Animation Modifier Instances</summary>
        public ObjectArrayField<AnimationModifier> AnimationModifierInstances{ get {
            if(AnimationModifierInstances_store == null) AnimationModifierInstances_store = new ObjectArrayField<AnimationModifier> (&AnimationModifiersAssetUserData_ptr->AnimationModifierInstances);
            return AnimationModifierInstances_store;
        } }
        private ObjectArrayField<AnimationModifier> AnimationModifierInstances_store;

        static AnimationModifiersAssetUserData() {
            StaticClass = Main.GetClass("AnimationModifiersAssetUserData");
        }
        internal unsafe AnimationModifiersAssetUserData_fields* AnimationModifiersAssetUserData_ptr => (AnimationModifiersAssetUserData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimationModifiersAssetUserData(IntPtr p) => UObject.Make<AnimationModifiersAssetUserData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimationModifiersAssetUserData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimationModifiersAssetUserData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

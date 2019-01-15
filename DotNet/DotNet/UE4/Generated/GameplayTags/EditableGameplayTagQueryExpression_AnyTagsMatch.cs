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
using UE4.GameplayTags.Native;

namespace UE4.GameplayTags {
    ///<summary>Editable Gameplay Tag Query Expression Any Tags Match</summary>
    public unsafe partial class EditableGameplayTagQueryExpression_AnyTagsMatch : EditableGameplayTagQueryExpression  {
        ///<summary>Tags</summary>
        public unsafe GameplayTagContainer Tags {
            get {return EditableGameplayTagQueryExpression_AnyTagsMatch_ptr->Tags;}
            set {EditableGameplayTagQueryExpression_AnyTagsMatch_ptr->Tags = value;}
        }
        static EditableGameplayTagQueryExpression_AnyTagsMatch() {
            StaticClass = Main.GetClass("EditableGameplayTagQueryExpression_AnyTagsMatch");
        }
        internal unsafe EditableGameplayTagQueryExpression_AnyTagsMatch_fields* EditableGameplayTagQueryExpression_AnyTagsMatch_ptr => (EditableGameplayTagQueryExpression_AnyTagsMatch_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditableGameplayTagQueryExpression_AnyTagsMatch(IntPtr p) => UObject.Make<EditableGameplayTagQueryExpression_AnyTagsMatch>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditableGameplayTagQueryExpression_AnyTagsMatch DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditableGameplayTagQueryExpression_AnyTagsMatch New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

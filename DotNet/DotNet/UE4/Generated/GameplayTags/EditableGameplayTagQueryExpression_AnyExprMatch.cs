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
    ///<summary>Editable Gameplay Tag Query Expression Any Expr Match</summary>
    public unsafe partial class EditableGameplayTagQueryExpression_AnyExprMatch : EditableGameplayTagQueryExpression  {
        ///<summary>Expressions</summary>
        public ObjectArrayField<EditableGameplayTagQueryExpression> Expressions{ get {
            if(Expressions_store == null) Expressions_store = new ObjectArrayField<EditableGameplayTagQueryExpression> (&EditableGameplayTagQueryExpression_AnyExprMatch_ptr->Expressions);
            return Expressions_store;
        } }
        private ObjectArrayField<EditableGameplayTagQueryExpression> Expressions_store;

        static EditableGameplayTagQueryExpression_AnyExprMatch() {
            StaticClass = Main.GetClass("EditableGameplayTagQueryExpression_AnyExprMatch");
        }
        internal unsafe EditableGameplayTagQueryExpression_AnyExprMatch_fields* EditableGameplayTagQueryExpression_AnyExprMatch_ptr => (EditableGameplayTagQueryExpression_AnyExprMatch_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditableGameplayTagQueryExpression_AnyExprMatch(IntPtr p) => UObject.Make<EditableGameplayTagQueryExpression_AnyExprMatch>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditableGameplayTagQueryExpression_AnyExprMatch DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditableGameplayTagQueryExpression_AnyExprMatch New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>Editable Gameplay Tag Query Expression All Expr Match</summary>
    public unsafe partial class EditableGameplayTagQueryExpression_AllExprMatch : EditableGameplayTagQueryExpression  {
        ///<summary>Expressions</summary>
        public ObjectArrayField<EditableGameplayTagQueryExpression> Expressions{ get {
            if(Expressions_store == null) Expressions_store = new ObjectArrayField<EditableGameplayTagQueryExpression> (&EditableGameplayTagQueryExpression_AllExprMatch_ptr->Expressions);
            return Expressions_store;
        } }
        private ObjectArrayField<EditableGameplayTagQueryExpression> Expressions_store;

        static EditableGameplayTagQueryExpression_AllExprMatch() {
            StaticClass = Main.GetClass("EditableGameplayTagQueryExpression_AllExprMatch");
        }
        internal unsafe EditableGameplayTagQueryExpression_AllExprMatch_fields* EditableGameplayTagQueryExpression_AllExprMatch_ptr => (EditableGameplayTagQueryExpression_AllExprMatch_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditableGameplayTagQueryExpression_AllExprMatch(IntPtr p) => UObject.Make<EditableGameplayTagQueryExpression_AllExprMatch>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditableGameplayTagQueryExpression_AllExprMatch DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditableGameplayTagQueryExpression_AllExprMatch New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>Editable Gameplay Tag Query Expression No Expr Match</summary>
    public unsafe partial class EditableGameplayTagQueryExpression_NoExprMatch : EditableGameplayTagQueryExpression  {
        ///<summary>Expressions</summary>
        public ObjectArrayField<EditableGameplayTagQueryExpression> Expressions{ get {
            if(Expressions_store == null) Expressions_store = new ObjectArrayField<EditableGameplayTagQueryExpression> (&EditableGameplayTagQueryExpression_NoExprMatch_ptr->Expressions);
            return Expressions_store;
        } }
        private ObjectArrayField<EditableGameplayTagQueryExpression> Expressions_store;

        static EditableGameplayTagQueryExpression_NoExprMatch() {
            StaticClass = Main.GetClass("EditableGameplayTagQueryExpression_NoExprMatch");
        }
        internal unsafe EditableGameplayTagQueryExpression_NoExprMatch_fields* EditableGameplayTagQueryExpression_NoExprMatch_ptr => (EditableGameplayTagQueryExpression_NoExprMatch_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditableGameplayTagQueryExpression_NoExprMatch(IntPtr p) => UObject.Make<EditableGameplayTagQueryExpression_NoExprMatch>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditableGameplayTagQueryExpression_NoExprMatch DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditableGameplayTagQueryExpression_NoExprMatch New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

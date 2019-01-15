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
    ///<summary>This is an editor-only representation of a query, designed to be editable with a typical property window.</summary>
    ///<remarks>
    ///To edit a query in the editor, an FGameplayTagQuery is converted to a set of UObjects and edited,  When finished,
    ///the query struct is rewritten and these UObjects are discarded.
    ///This query representation is not intended for runtime use.
    ///</remarks>
    public unsafe partial class EditableGameplayTagQuery : UObject  {
         //TODO: string FString UserDescription
        ///<summary>The base expression of this query.</summary>
        public unsafe EditableGameplayTagQueryExpression RootExpression {
            get {return EditableGameplayTagQuery_ptr->RootExpression;}
            set {EditableGameplayTagQuery_ptr->RootExpression = value;}
        }
        ///<summary>Property to hold a gameplay tag query so we can use the exporttext path to get a string representation.</summary>
        public unsafe GameplayTagQuery TagQueryExportText_Helper {
            get {return EditableGameplayTagQuery_ptr->TagQueryExportText_Helper;}
            set {EditableGameplayTagQuery_ptr->TagQueryExportText_Helper = value;}
        }
        static EditableGameplayTagQuery() {
            StaticClass = Main.GetClass("EditableGameplayTagQuery");
        }
        internal unsafe EditableGameplayTagQuery_fields* EditableGameplayTagQuery_ptr => (EditableGameplayTagQuery_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditableGameplayTagQuery(IntPtr p) => UObject.Make<EditableGameplayTagQuery>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditableGameplayTagQuery DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditableGameplayTagQuery New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

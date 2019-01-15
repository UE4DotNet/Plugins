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
using UE4.AnimGraph.Native;
using UE4.BlueprintGraph;

namespace UE4.AnimGraph {
    ///<summary>Animation Graph Schema</summary>
    public unsafe partial class AnimationGraphSchema : EdGraphSchema_K2  {
         //TODO: string FString PN_SequenceName
        ///<summary>PC_Object+PSC_Sequence</summary>
        public unsafe Name NAME_NeverAsPin {
            get {return AnimationGraphSchema_ptr->NAME_NeverAsPin;}
            set {AnimationGraphSchema_ptr->NAME_NeverAsPin = value;}
        }
        ///<summary>NAME Pin Hidden by Default</summary>
        public unsafe Name NAME_PinHiddenByDefault {
            get {return AnimationGraphSchema_ptr->NAME_PinHiddenByDefault;}
            set {AnimationGraphSchema_ptr->NAME_PinHiddenByDefault = value;}
        }
        ///<summary>NAME Pin Shown by Default</summary>
        public unsafe Name NAME_PinShownByDefault {
            get {return AnimationGraphSchema_ptr->NAME_PinShownByDefault;}
            set {AnimationGraphSchema_ptr->NAME_PinShownByDefault = value;}
        }
        ///<summary>NAME Always as Pin</summary>
        public unsafe Name NAME_AlwaysAsPin {
            get {return AnimationGraphSchema_ptr->NAME_AlwaysAsPin;}
            set {AnimationGraphSchema_ptr->NAME_AlwaysAsPin = value;}
        }
        ///<summary>NAME Customize Property</summary>
        public unsafe Name NAME_CustomizeProperty {
            get {return AnimationGraphSchema_ptr->NAME_CustomizeProperty;}
            set {AnimationGraphSchema_ptr->NAME_CustomizeProperty = value;}
        }
        ///<summary>NAME on Evaluate</summary>
        public unsafe Name NAME_OnEvaluate {
            get {return AnimationGraphSchema_ptr->NAME_OnEvaluate;}
            set {AnimationGraphSchema_ptr->NAME_OnEvaluate = value;}
        }
        ///<summary>Default Evaluation Handler Name</summary>
        public unsafe Name DefaultEvaluationHandlerName {
            get {return AnimationGraphSchema_ptr->DefaultEvaluationHandlerName;}
            set {AnimationGraphSchema_ptr->DefaultEvaluationHandlerName = value;}
        }
        static AnimationGraphSchema() {
            StaticClass = Main.GetClass("AnimationGraphSchema");
        }
        internal unsafe AnimationGraphSchema_fields* AnimationGraphSchema_ptr => (AnimationGraphSchema_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimationGraphSchema(IntPtr p) => UObject.Make<AnimationGraphSchema>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimationGraphSchema DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimationGraphSchema New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

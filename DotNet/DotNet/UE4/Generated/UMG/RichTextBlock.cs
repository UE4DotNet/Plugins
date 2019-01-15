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
using UE4.UMG.Native;
using UE4.Engine;

namespace UE4.UMG {
    ///<summary>
    ///The rich text block
    ///* Fancy Text
    ///</summary>
    ///<remarks>* No Children</remarks>
    public unsafe partial class RichTextBlock : TextLayoutWidget  {

        ///<summary>Get Decorator by Class</summary>
        public RichTextBlockDecorator GetDecoratorByClass(SubclassOf<RichTextBlockDecorator> DecoratorClass)  => 
            RichTextBlock_methods.GetDecoratorByClass_method.Invoke(ObjPointer, DecoratorClass);

        ///<summary>Set Text</summary>
        public void SetText(byte InText /*TODO: text FText */)  => 
            RichTextBlock_methods.SetText_method.Invoke(ObjPointer, InText);
         //TODO: text FText Text
        ///<summary>Text Style Set</summary>
        public unsafe DataTable TextStyleSet {
            get {return RichTextBlock_ptr->TextStyleSet;}
            set {RichTextBlock_ptr->TextStyleSet = value;}
        }
        ///<summary>Decorator Classes</summary>
        public ObjectArrayField<Class> DecoratorClasses{ get {
            if(DecoratorClasses_store == null) DecoratorClasses_store = new ObjectArrayField<Class> (&RichTextBlock_ptr->DecoratorClasses);
            return DecoratorClasses_store;
        } }
        private ObjectArrayField<Class> DecoratorClasses_store;

        ///<summary>Instance Decorators</summary>
        public ObjectArrayField<RichTextBlockDecorator> InstanceDecorators{ get {
            if(InstanceDecorators_store == null) InstanceDecorators_store = new ObjectArrayField<RichTextBlockDecorator> (&RichTextBlock_ptr->InstanceDecorators);
            return InstanceDecorators_store;
        } }
        private ObjectArrayField<RichTextBlockDecorator> InstanceDecorators_store;

        static RichTextBlock() {
            StaticClass = Main.GetClass("RichTextBlock");
        }
        internal unsafe RichTextBlock_fields* RichTextBlock_ptr => (RichTextBlock_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator RichTextBlock(IntPtr p) => UObject.Make<RichTextBlock>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static RichTextBlock DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static RichTextBlock New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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

namespace UE4.UMG {
    ///<summary>Rich Text Block Decorator</summary>
    public unsafe partial class RichTextBlockDecorator : UObject  {
        static RichTextBlockDecorator() {
            StaticClass = Main.GetClass("RichTextBlockDecorator");
        }
        internal unsafe RichTextBlockDecorator_fields* RichTextBlockDecorator_ptr => (RichTextBlockDecorator_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator RichTextBlockDecorator(IntPtr p) => UObject.Make<RichTextBlockDecorator>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static RichTextBlockDecorator DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static RichTextBlockDecorator New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

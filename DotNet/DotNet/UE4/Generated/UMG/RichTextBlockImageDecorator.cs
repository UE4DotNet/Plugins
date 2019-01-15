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
    ///Allows you to setup an image decorator that can be configured
    ///to map certain keys to certain images.
    ///</summary>
    ///<remarks>
    ///We recommend you subclass this
    ///as a blueprint to configure the instance.
    ///</remarks>
    public unsafe partial class RichTextBlockImageDecorator : RichTextBlockDecorator  {
        ///<summary>Image Set</summary>
        public unsafe DataTable ImageSet {
            get {return RichTextBlockImageDecorator_ptr->ImageSet;}
            set {RichTextBlockImageDecorator_ptr->ImageSet = value;}
        }
        static RichTextBlockImageDecorator() {
            StaticClass = Main.GetClass("RichTextBlockImageDecorator");
        }
        internal unsafe RichTextBlockImageDecorator_fields* RichTextBlockImageDecorator_ptr => (RichTextBlockImageDecorator_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator RichTextBlockImageDecorator(IntPtr p) => UObject.Make<RichTextBlockImageDecorator>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static RichTextBlockImageDecorator DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static RichTextBlockImageDecorator New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

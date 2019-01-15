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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>A camera position the current level.</summary>
    public unsafe partial class BookMark : UObject  {
        ///<summary>Camera position</summary>
        public unsafe Vector Location {
            get {return BookMark_ptr->Location;}
            set {BookMark_ptr->Location = value;}
        }
        ///<summary>Camera rotation</summary>
        public unsafe Rotator Rotation {
            get {return BookMark_ptr->Rotation;}
            set {BookMark_ptr->Rotation = value;}
        }
         //TODO: array not UObject TArray HiddenLevels
        static BookMark() {
            StaticClass = Main.GetClass("BookMark");
        }
        internal unsafe BookMark_fields* BookMark_ptr => (BookMark_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BookMark(IntPtr p) => UObject.Make<BookMark>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BookMark DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BookMark New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

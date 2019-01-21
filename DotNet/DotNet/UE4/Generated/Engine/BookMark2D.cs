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
    ///<summary>Simple class to store 2D camera information.</summary>
    public unsafe partial class BookMark2D : BookmarkBase  {
        ///<summary>Zoom of the camera</summary>
        public unsafe float Zoom2D {
            get {return BookMark2D_ptr->Zoom2D;}
            set {BookMark2D_ptr->Zoom2D = value;}
        }
        ///<summary>Location of the camera</summary>
        public unsafe IntPoint Location {
            get {return BookMark2D_ptr->Location;}
            set {BookMark2D_ptr->Location = value;}
        }
        static BookMark2D() {
            StaticClass = Main.GetClass("BookMark2D");
        }
        internal unsafe BookMark2D_fields* BookMark2D_ptr => (BookMark2D_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BookMark2D(IntPtr p) => UObject.Make<BookMark2D>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BookMark2D DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BookMark2D New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

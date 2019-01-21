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
    ///<summary>
    ///Bookmarks are objects that can keep track of specific locations within a level or scene, without
    ///necessarily adding additional actors to that scene.
    ///</summary>
    ///<remarks>
    ///Different implementations can be used depending on specific needs, and new implementations can
    ///be generated by implementing a class Derived on UBookmarkBase.
    ///
    ///See UBookMark, UBookMark2D, AGameWorldSettings::DefaultBookmarkClass, IBookmarkEditorInteractor.
    ///</remarks>
    public unsafe partial class BookmarkBase : UObject  {
        static BookmarkBase() {
            StaticClass = Main.GetClass("BookmarkBase");
        }
        internal unsafe BookmarkBase_fields* BookmarkBase_ptr => (BookmarkBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BookmarkBase(IntPtr p) => UObject.Make<BookmarkBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BookmarkBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BookmarkBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
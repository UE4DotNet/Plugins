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
using UE4.ContentBrowser.Native;

namespace UE4.ContentBrowser {
    ///<summary>Override this class in order to make an additional front-end filter available in the Content Browser</summary>
    public unsafe partial class ContentBrowserFrontEndFilterExtension : UObject  {
        static ContentBrowserFrontEndFilterExtension() {
            StaticClass = Main.GetClass("ContentBrowserFrontEndFilterExtension");
        }
        internal unsafe ContentBrowserFrontEndFilterExtension_fields* ContentBrowserFrontEndFilterExtension_ptr => (ContentBrowserFrontEndFilterExtension_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ContentBrowserFrontEndFilterExtension(IntPtr p) => UObject.Make<ContentBrowserFrontEndFilterExtension>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ContentBrowserFrontEndFilterExtension DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ContentBrowserFrontEndFilterExtension New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

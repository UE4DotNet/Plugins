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
using UE4.GameplayTagsEditor.Native;
using UE4.ContentBrowser;

namespace UE4.GameplayTagsEditor {
    ///<summary>Gameplay Tag Search Filter</summary>
    public unsafe partial class GameplayTagSearchFilter : ContentBrowserFrontEndFilterExtension  {
        static GameplayTagSearchFilter() {
            StaticClass = Main.GetClass("GameplayTagSearchFilter");
        }
        internal unsafe GameplayTagSearchFilter_fields* GameplayTagSearchFilter_ptr => (GameplayTagSearchFilter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayTagSearchFilter(IntPtr p) => UObject.Make<GameplayTagSearchFilter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayTagSearchFilter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayTagSearchFilter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>Native User List Entry</summary>
    public unsafe partial class NativeUserListEntry : Interface  {

        ///<summary>@return True if the item represented by this entry is currently expanded and showing its children. Tree view entries only.</summary>
        public bool IsListItemExpanded()  => 
            NativeUserListEntry_methods.IsListItemExpanded_method.Invoke(ObjPointer);

        ///<summary>@return True if the item represented by this entry is currently selected.</summary>
        public bool IsListItemSelected()  => 
            NativeUserListEntry_methods.IsListItemSelected_method.Invoke(ObjPointer);
        static NativeUserListEntry() {
            StaticClass = Main.GetClass("NativeUserListEntry");
        }
        internal unsafe NativeUserListEntry_fields* NativeUserListEntry_ptr => (NativeUserListEntry_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NativeUserListEntry(IntPtr p) => UObject.Make<NativeUserListEntry>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NativeUserListEntry DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NativeUserListEntry New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>User Object List Entry</summary>
    public unsafe partial class UserObjectListEntry : UserListEntry  {

        ///<summary>Called when the item object represented by this entry is established</summary>
        public event OnListItemObjectSet_delegate OnListItemObjectSet;
        public delegate void OnListItemObjectSet_delegate(UObject ListItemObject);
        internal void on_OnListItemObjectSet(UObject ListItemObject) =>
            OnListItemObjectSet?.Invoke(ListItemObject);


        ///<summary>Returns the item object that this entry currently represents</summary>
        public event GetListItemObject_delegate GetListItemObject;
        public delegate UObject GetListItemObject_delegate(UObject ReturnValue);
        internal UObject on_GetListItemObject(UObject ReturnValue) =>
            GetListItemObject != null ? GetListItemObject(ReturnValue) : ReturnValue;

        static UserObjectListEntry() {
            StaticClass = Main.GetClass("UserObjectListEntry");
            UserObjectListEntry_events.OnListItemObjectSet_event.Setup();
            UserObjectListEntry_events.GetListItemObject_event.Setup();
        }
        internal unsafe UserObjectListEntry_fields* UserObjectListEntry_ptr => (UserObjectListEntry_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UserObjectListEntry(IntPtr p) => UObject.Make<UserObjectListEntry>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UserObjectListEntry DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UserObjectListEntry New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

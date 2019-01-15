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
    ///<summary>User List Entry</summary>
    public unsafe partial class UserListEntry : NativeUserListEntry  {

        ///<summary>Called when this entry is released from the owning table and no longer represents any list item</summary>
        public event BP_OnEntryReleased_delegate BP_OnEntryReleased;
        public delegate void BP_OnEntryReleased_delegate();
        internal void on_BP_OnEntryReleased() =>
            BP_OnEntryReleased?.Invoke();


        ///<summary>Called when the expansion state of the item represented by this entry changes. Tree view entries only.</summary>
        public event BP_OnItemExpansionChanged_delegate BP_OnItemExpansionChanged;
        public delegate void BP_OnItemExpansionChanged_delegate(bool bIsExpanded);
        internal void on_BP_OnItemExpansionChanged(bool bIsExpanded) =>
            BP_OnItemExpansionChanged?.Invoke(bIsExpanded);


        ///<summary>Called when the selection state of the item represented by this entry changes.</summary>
        public event BP_OnItemSelectionChanged_delegate BP_OnItemSelectionChanged;
        public delegate void BP_OnItemSelectionChanged_delegate(bool bIsSelected);
        internal void on_BP_OnItemSelectionChanged(bool bIsSelected) =>
            BP_OnItemSelectionChanged?.Invoke(bIsSelected);

        static UserListEntry() {
            StaticClass = Main.GetClass("UserListEntry");
            UserListEntry_events.BP_OnEntryReleased_event.Setup();
            UserListEntry_events.BP_OnItemExpansionChanged_event.Setup();
            UserListEntry_events.BP_OnItemSelectionChanged_event.Setup();
        }
        internal unsafe UserListEntry_fields* UserListEntry_ptr => (UserListEntry_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UserListEntry(IntPtr p) => UObject.Make<UserListEntry>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UserListEntry DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UserListEntry New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

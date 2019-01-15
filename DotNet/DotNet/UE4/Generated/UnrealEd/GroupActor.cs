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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Group Actor</summary>
    public unsafe partial class GroupActor : Actor  {
        public bool bLocked {
            get {return Main.GetGetBoolPropertyByName(this, "bLocked"); }
            set {Main.SetGetBoolPropertyByName(this, "bLocked", value); }
        }
        ///<summary>Group Actors</summary>
        public ObjectArrayField<Actor> GroupActors{ get {
            if(GroupActors_store == null) GroupActors_store = new ObjectArrayField<Actor> (&GroupActor_ptr->GroupActors);
            return GroupActors_store;
        } }
        private ObjectArrayField<Actor> GroupActors_store;

        ///<summary>Sub Groups</summary>
        public ObjectArrayField<GroupActor> SubGroups{ get {
            if(SubGroups_store == null) SubGroups_store = new ObjectArrayField<GroupActor> (&GroupActor_ptr->SubGroups);
            return SubGroups_store;
        } }
        private ObjectArrayField<GroupActor> SubGroups_store;

        static GroupActor() {
            StaticClass = Main.GetClass("GroupActor");
        }
        internal unsafe GroupActor_fields* GroupActor_ptr => (GroupActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GroupActor(IntPtr p) => UObject.Make<GroupActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GroupActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GroupActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

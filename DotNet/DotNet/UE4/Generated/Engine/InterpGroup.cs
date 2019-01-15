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
    ///<summary>Interp Group</summary>
    public unsafe partial class InterpGroup : UObject  {
        ///<summary>Interp Tracks</summary>
        public ObjectArrayField<InterpTrack> InterpTracks{ get {
            if(InterpTracks_store == null) InterpTracks_store = new ObjectArrayField<InterpTrack> (&InterpGroup_ptr->InterpTracks);
            return InterpTracks_store;
        } }
        private ObjectArrayField<InterpTrack> InterpTracks_store;

        ///<summary>Within an InterpData, all GroupNames must be unique.</summary>
        ///<remarks>Used for naming Variable connectors on the Action in Kismet and finding each groups object.</remarks>
        public unsafe Name GroupName {
            get {return InterpGroup_ptr->GroupName;}
            set {InterpGroup_ptr->GroupName = value;}
        }
        ///<summary>Colour used for drawing tracks etc. related to this group.</summary>
        public unsafe Color GroupColor {
            get {return InterpGroup_ptr->GroupColor;}
            set {InterpGroup_ptr->GroupColor = value;}
        }
        public bool bCollapsed {
            get {return Main.GetGetBoolPropertyByName(this, "bCollapsed"); }
            set {Main.SetGetBoolPropertyByName(this, "bCollapsed", value); }
        }
        public bool bVisible {
            get {return Main.GetGetBoolPropertyByName(this, "bVisible"); }
            set {Main.SetGetBoolPropertyByName(this, "bVisible", value); }
        }
        public bool bIsFolder {
            get {return Main.GetGetBoolPropertyByName(this, "bIsFolder"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsFolder", value); }
        }
        public bool bIsParented {
            get {return Main.GetGetBoolPropertyByName(this, "bIsParented"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsParented", value); }
        }
        public bool bIsSelected {
            get {return Main.GetGetBoolPropertyByName(this, "bIsSelected"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsSelected", value); }
        }
        static InterpGroup() {
            StaticClass = Main.GetClass("InterpGroup");
        }
        internal unsafe InterpGroup_fields* InterpGroup_ptr => (InterpGroup_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpGroup(IntPtr p) => UObject.Make<InterpGroup>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpGroup DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpGroup New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

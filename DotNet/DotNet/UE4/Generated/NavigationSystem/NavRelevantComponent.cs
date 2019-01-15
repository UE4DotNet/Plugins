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
using UE4.NavigationSystem.Native;
using UE4.Engine;

namespace UE4.NavigationSystem {
    ///<summary>Nav Relevant Component</summary>
    public unsafe partial class NavRelevantComponent : ActorComponent  {

        ///<summary>Set Navigation Relevancy</summary>
        public void SetNavigationRelevancy(bool bRelevant)  => 
            NavRelevantComponent_methods.SetNavigationRelevancy_method.Invoke(ObjPointer, bRelevant);
        public bool bAttachToOwnersRoot {
            get {return Main.GetGetBoolPropertyByName(this, "bAttachToOwnersRoot"); }
            set {Main.SetGetBoolPropertyByName(this, "bAttachToOwnersRoot", value); }
        }
        ///<summary>Cached Nav Parent</summary>
        public unsafe UObject CachedNavParent {
            get {return NavRelevantComponent_ptr->CachedNavParent;}
            set {NavRelevantComponent_ptr->CachedNavParent = value;}
        }
        static NavRelevantComponent() {
            StaticClass = Main.GetClass("NavRelevantComponent");
        }
        internal unsafe NavRelevantComponent_fields* NavRelevantComponent_ptr => (NavRelevantComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavRelevantComponent(IntPtr p) => UObject.Make<NavRelevantComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavRelevantComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavRelevantComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

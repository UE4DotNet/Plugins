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

namespace UE4.NavigationSystem {
    ///<summary>Nav Modifier Component</summary>
    public unsafe partial class NavModifierComponent : NavRelevantComponent  {

        ///<summary>Set Area Class</summary>
        public void SetAreaClass(SubclassOf<NavArea> NewAreaClass)  => 
            NavModifierComponent_methods.SetAreaClass_method.Invoke(ObjPointer, NewAreaClass);
        ///<summary>Area Class</summary>
        public unsafe SubclassOf<NavArea> AreaClass {
            get {return NavModifierComponent_ptr->AreaClass;}
        }
        ///<summary>box extent used ONLY when owning actor doesn't have collision component</summary>
        public unsafe Vector FailsafeExtent {
            get {return NavModifierComponent_ptr->FailsafeExtent;}
            set {NavModifierComponent_ptr->FailsafeExtent = value;}
        }
        public bool bIncludeAgentHeight {
            get {return Main.GetGetBoolPropertyByName(this, "bIncludeAgentHeight"); }
            set {Main.SetGetBoolPropertyByName(this, "bIncludeAgentHeight", value); }
        }
        static NavModifierComponent() {
            StaticClass = Main.GetClass("NavModifierComponent");
        }
        internal unsafe NavModifierComponent_fields* NavModifierComponent_ptr => (NavModifierComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavModifierComponent(IntPtr p) => UObject.Make<NavModifierComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavModifierComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavModifierComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

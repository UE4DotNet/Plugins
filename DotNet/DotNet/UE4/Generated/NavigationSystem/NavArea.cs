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
    ///<summary>Class containing definition of a navigation area</summary>
    public unsafe partial class NavArea : NavAreaBase  {
        ///<summary>travel cost multiplier for path distance</summary>
        public unsafe float DefaultCost {
            get {return NavArea_ptr->DefaultCost;}
            set {NavArea_ptr->DefaultCost = value;}
        }
        ///<summary>entering cost</summary>
        public unsafe float FixedAreaEnteringCost {
            get {return NavArea_ptr->FixedAreaEnteringCost;}
            set {NavArea_ptr->FixedAreaEnteringCost = value;}
        }
        ///<summary>area color in navigation view</summary>
        public unsafe Color DrawColor {
            get {return NavArea_ptr->DrawColor;}
            set {NavArea_ptr->DrawColor = value;}
        }
        ///<summary>restrict area only to specified agents</summary>
        public unsafe NavAgentSelector SupportedAgents {
            get {return NavArea_ptr->SupportedAgents;}
            set {NavArea_ptr->SupportedAgents = value;}
        }
        public bool bSupportsAgent0 {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsAgent0"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsAgent0", value); }
        }
        public bool bSupportsAgent1 {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsAgent1"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsAgent1", value); }
        }
        public bool bSupportsAgent2 {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsAgent2"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsAgent2", value); }
        }
        public bool bSupportsAgent3 {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsAgent3"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsAgent3", value); }
        }
        public bool bSupportsAgent4 {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsAgent4"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsAgent4", value); }
        }
        public bool bSupportsAgent5 {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsAgent5"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsAgent5", value); }
        }
        public bool bSupportsAgent6 {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsAgent6"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsAgent6", value); }
        }
        public bool bSupportsAgent7 {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsAgent7"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsAgent7", value); }
        }
        public bool bSupportsAgent8 {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsAgent8"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsAgent8", value); }
        }
        public bool bSupportsAgent9 {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsAgent9"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsAgent9", value); }
        }
        public bool bSupportsAgent10 {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsAgent10"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsAgent10", value); }
        }
        public bool bSupportsAgent11 {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsAgent11"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsAgent11", value); }
        }
        public bool bSupportsAgent12 {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsAgent12"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsAgent12", value); }
        }
        public bool bSupportsAgent13 {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsAgent13"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsAgent13", value); }
        }
        public bool bSupportsAgent14 {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsAgent14"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsAgent14", value); }
        }
        public bool bSupportsAgent15 {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsAgent15"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsAgent15", value); }
        }
        static NavArea() {
            StaticClass = Main.GetClass("NavArea");
        }
        internal unsafe NavArea_fields* NavArea_ptr => (NavArea_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavArea(IntPtr p) => UObject.Make<NavArea>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavArea DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavArea New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

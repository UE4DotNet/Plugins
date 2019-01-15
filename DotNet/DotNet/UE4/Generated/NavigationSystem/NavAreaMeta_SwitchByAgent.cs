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
    ///<summary>Class containing definition of a navigation area</summary>
    public unsafe partial class NavAreaMeta_SwitchByAgent : NavAreaMeta  {
        ///<summary>Agent 0Area</summary>
        public unsafe SubclassOf<NavArea> Agent0Area {
            get {return NavAreaMeta_SwitchByAgent_ptr->Agent0Area;}
            set {NavAreaMeta_SwitchByAgent_ptr->Agent0Area = value;}
        }
        ///<summary>Agent 1Area</summary>
        public unsafe SubclassOf<NavArea> Agent1Area {
            get {return NavAreaMeta_SwitchByAgent_ptr->Agent1Area;}
            set {NavAreaMeta_SwitchByAgent_ptr->Agent1Area = value;}
        }
        ///<summary>Agent 2Area</summary>
        public unsafe SubclassOf<NavArea> Agent2Area {
            get {return NavAreaMeta_SwitchByAgent_ptr->Agent2Area;}
            set {NavAreaMeta_SwitchByAgent_ptr->Agent2Area = value;}
        }
        ///<summary>Agent 3Area</summary>
        public unsafe SubclassOf<NavArea> Agent3Area {
            get {return NavAreaMeta_SwitchByAgent_ptr->Agent3Area;}
            set {NavAreaMeta_SwitchByAgent_ptr->Agent3Area = value;}
        }
        ///<summary>Agent 4Area</summary>
        public unsafe SubclassOf<NavArea> Agent4Area {
            get {return NavAreaMeta_SwitchByAgent_ptr->Agent4Area;}
            set {NavAreaMeta_SwitchByAgent_ptr->Agent4Area = value;}
        }
        ///<summary>Agent 5Area</summary>
        public unsafe SubclassOf<NavArea> Agent5Area {
            get {return NavAreaMeta_SwitchByAgent_ptr->Agent5Area;}
            set {NavAreaMeta_SwitchByAgent_ptr->Agent5Area = value;}
        }
        ///<summary>Agent 6Area</summary>
        public unsafe SubclassOf<NavArea> Agent6Area {
            get {return NavAreaMeta_SwitchByAgent_ptr->Agent6Area;}
            set {NavAreaMeta_SwitchByAgent_ptr->Agent6Area = value;}
        }
        ///<summary>Agent 7Area</summary>
        public unsafe SubclassOf<NavArea> Agent7Area {
            get {return NavAreaMeta_SwitchByAgent_ptr->Agent7Area;}
            set {NavAreaMeta_SwitchByAgent_ptr->Agent7Area = value;}
        }
        ///<summary>Agent 8Area</summary>
        public unsafe SubclassOf<NavArea> Agent8Area {
            get {return NavAreaMeta_SwitchByAgent_ptr->Agent8Area;}
            set {NavAreaMeta_SwitchByAgent_ptr->Agent8Area = value;}
        }
        ///<summary>Agent 9Area</summary>
        public unsafe SubclassOf<NavArea> Agent9Area {
            get {return NavAreaMeta_SwitchByAgent_ptr->Agent9Area;}
            set {NavAreaMeta_SwitchByAgent_ptr->Agent9Area = value;}
        }
        ///<summary>Agent 10Area</summary>
        public unsafe SubclassOf<NavArea> Agent10Area {
            get {return NavAreaMeta_SwitchByAgent_ptr->Agent10Area;}
            set {NavAreaMeta_SwitchByAgent_ptr->Agent10Area = value;}
        }
        ///<summary>Agent 11Area</summary>
        public unsafe SubclassOf<NavArea> Agent11Area {
            get {return NavAreaMeta_SwitchByAgent_ptr->Agent11Area;}
            set {NavAreaMeta_SwitchByAgent_ptr->Agent11Area = value;}
        }
        ///<summary>Agent 12Area</summary>
        public unsafe SubclassOf<NavArea> Agent12Area {
            get {return NavAreaMeta_SwitchByAgent_ptr->Agent12Area;}
            set {NavAreaMeta_SwitchByAgent_ptr->Agent12Area = value;}
        }
        ///<summary>Agent 13Area</summary>
        public unsafe SubclassOf<NavArea> Agent13Area {
            get {return NavAreaMeta_SwitchByAgent_ptr->Agent13Area;}
            set {NavAreaMeta_SwitchByAgent_ptr->Agent13Area = value;}
        }
        ///<summary>Agent 14Area</summary>
        public unsafe SubclassOf<NavArea> Agent14Area {
            get {return NavAreaMeta_SwitchByAgent_ptr->Agent14Area;}
            set {NavAreaMeta_SwitchByAgent_ptr->Agent14Area = value;}
        }
        ///<summary>Agent 15Area</summary>
        public unsafe SubclassOf<NavArea> Agent15Area {
            get {return NavAreaMeta_SwitchByAgent_ptr->Agent15Area;}
            set {NavAreaMeta_SwitchByAgent_ptr->Agent15Area = value;}
        }
        static NavAreaMeta_SwitchByAgent() {
            StaticClass = Main.GetClass("NavAreaMeta_SwitchByAgent");
        }
        internal unsafe NavAreaMeta_SwitchByAgent_fields* NavAreaMeta_SwitchByAgent_ptr => (NavAreaMeta_SwitchByAgent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavAreaMeta_SwitchByAgent(IntPtr p) => UObject.Make<NavAreaMeta_SwitchByAgent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavAreaMeta_SwitchByAgent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavAreaMeta_SwitchByAgent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

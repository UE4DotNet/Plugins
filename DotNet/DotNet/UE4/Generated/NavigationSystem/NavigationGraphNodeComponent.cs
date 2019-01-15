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
    ///<summary>Navigation Graph Node Component</summary>
    public unsafe partial class NavigationGraphNodeComponent : SceneComponent  {
        ///<summary>Node</summary>
        public unsafe NavGraphNode Node {
            get {return NavigationGraphNodeComponent_ptr->Node;}
            set {NavigationGraphNodeComponent_ptr->Node = value;}
        }
        ///<summary>Next Node Component</summary>
        public unsafe NavigationGraphNodeComponent NextNodeComponent {
            get {return NavigationGraphNodeComponent_ptr->NextNodeComponent;}
            set {NavigationGraphNodeComponent_ptr->NextNodeComponent = value;}
        }
        ///<summary>Prev Node Component</summary>
        public unsafe NavigationGraphNodeComponent PrevNodeComponent {
            get {return NavigationGraphNodeComponent_ptr->PrevNodeComponent;}
            set {NavigationGraphNodeComponent_ptr->PrevNodeComponent = value;}
        }
        static NavigationGraphNodeComponent() {
            StaticClass = Main.GetClass("NavigationGraphNodeComponent");
        }
        internal unsafe NavigationGraphNodeComponent_fields* NavigationGraphNodeComponent_ptr => (NavigationGraphNodeComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavigationGraphNodeComponent(IntPtr p) => UObject.Make<NavigationGraphNodeComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavigationGraphNodeComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavigationGraphNodeComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

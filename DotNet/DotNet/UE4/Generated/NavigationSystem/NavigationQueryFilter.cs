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
    ///<summary>Class containing definition of a navigation query filter</summary>
    public unsafe partial class NavigationQueryFilter : UObject  {
         //TODO: array not UObject TArray Areas
        ///<summary>required flags of navigation nodes</summary>
        public unsafe NavigationFilterFlags IncludeFlags {
            get {return NavigationQueryFilter_ptr->IncludeFlags;}
            set {NavigationQueryFilter_ptr->IncludeFlags = value;}
        }
        ///<summary>forbidden flags of navigation nodes</summary>
        public unsafe NavigationFilterFlags ExcludeFlags {
            get {return NavigationQueryFilter_ptr->ExcludeFlags;}
            set {NavigationQueryFilter_ptr->ExcludeFlags = value;}
        }
        static NavigationQueryFilter() {
            StaticClass = Main.GetClass("NavigationQueryFilter");
        }
        internal unsafe NavigationQueryFilter_fields* NavigationQueryFilter_ptr => (NavigationQueryFilter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavigationQueryFilter(IntPtr p) => UObject.Make<NavigationQueryFilter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavigationQueryFilter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavigationQueryFilter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

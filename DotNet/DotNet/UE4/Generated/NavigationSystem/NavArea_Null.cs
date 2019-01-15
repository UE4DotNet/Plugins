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
    ///<summary>In general represents an empty area, that cannot be traversed by anyone. Ever.</summary>
    public unsafe partial class NavArea_Null : NavArea  {
        static NavArea_Null() {
            StaticClass = Main.GetClass("NavArea_Null");
        }
        internal unsafe NavArea_Null_fields* NavArea_Null_ptr => (NavArea_Null_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavArea_Null(IntPtr p) => UObject.Make<NavArea_Null>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavArea_Null DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavArea_Null New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

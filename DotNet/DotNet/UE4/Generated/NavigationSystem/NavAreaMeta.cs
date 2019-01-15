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
    ///<summary>A convenience class for an area that has IsMetaArea() == true.</summary>
    ///<remarks>
    ///Do not use this class when determining whether an area class is "meta".
    ///   Call IsMetaArea instead.
    ///</remarks>
    public unsafe partial class NavAreaMeta : NavArea  {
        static NavAreaMeta() {
            StaticClass = Main.GetClass("NavAreaMeta");
        }
        internal unsafe NavAreaMeta_fields* NavAreaMeta_ptr => (NavAreaMeta_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavAreaMeta(IntPtr p) => UObject.Make<NavAreaMeta>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavAreaMeta DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavAreaMeta New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

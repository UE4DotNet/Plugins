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
    ///<summary>Special area that can be generated in spaces with insufficient free height above. Cannot be traversed by anyone.</summary>
    public unsafe partial class NavArea_LowHeight : NavArea  {
        static NavArea_LowHeight() {
            StaticClass = Main.GetClass("NavArea_LowHeight");
        }
        internal unsafe NavArea_LowHeight_fields* NavArea_LowHeight_ptr => (NavArea_LowHeight_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavArea_LowHeight(IntPtr p) => UObject.Make<NavArea_LowHeight>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavArea_LowHeight DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavArea_LowHeight New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

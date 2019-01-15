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
    ///<summary>Base class for Crowd Managers.</summary>
    ///<remarks>
    ///If you want to create a custom crowd manager
    ///   implement a class extending this one and set UNavigationSystem::CrowdManagerClass
    ///   to point at your class
    ///</remarks>
    public unsafe partial class CrowdManagerBase : UObject  {
        static CrowdManagerBase() {
            StaticClass = Main.GetClass("CrowdManagerBase");
        }
        internal unsafe CrowdManagerBase_fields* CrowdManagerBase_ptr => (CrowdManagerBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CrowdManagerBase(IntPtr p) => UObject.Make<CrowdManagerBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CrowdManagerBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CrowdManagerBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

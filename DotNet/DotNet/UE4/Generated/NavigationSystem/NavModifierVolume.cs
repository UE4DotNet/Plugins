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
    ///<summary>Allows applying selected AreaClass to navmesh, using Volume's shape</summary>
    public unsafe partial class NavModifierVolume : Volume  {

        ///<summary>Set Area Class</summary>
        public void SetAreaClass(SubclassOf<NavArea> NewAreaClass)  => 
            NavModifierVolume_methods.SetAreaClass_method.Invoke(ObjPointer, NewAreaClass);
        ///<summary>Area Class</summary>
        public unsafe SubclassOf<NavArea> AreaClass {
            get {return NavModifierVolume_ptr->AreaClass;}
        }
        static NavModifierVolume() {
            StaticClass = Main.GetClass("NavModifierVolume");
        }
        internal unsafe NavModifierVolume_fields* NavModifierVolume_ptr => (NavModifierVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavModifierVolume(IntPtr p) => UObject.Make<NavModifierVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavModifierVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavModifierVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

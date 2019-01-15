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
    ///<summary>Regular navigation area, applied to entire navigation data by default</summary>
    public unsafe partial class RecastFilter_UseDefaultArea : NavigationQueryFilter  {
        static RecastFilter_UseDefaultArea() {
            StaticClass = Main.GetClass("RecastFilter_UseDefaultArea");
        }
        internal unsafe RecastFilter_UseDefaultArea_fields* RecastFilter_UseDefaultArea_ptr => (RecastFilter_UseDefaultArea_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator RecastFilter_UseDefaultArea(IntPtr p) => UObject.Make<RecastFilter_UseDefaultArea>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static RecastFilter_UseDefaultArea DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static RecastFilter_UseDefaultArea New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

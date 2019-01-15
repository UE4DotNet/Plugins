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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Class containing definition of a navigation area</summary>
    public unsafe partial class NavLinkDefinition : UObject  {
         //TODO: array not UObject TArray Links
         //TODO: array not UObject TArray SegmentLinks
        static NavLinkDefinition() {
            StaticClass = Main.GetClass("NavLinkDefinition");
        }
        internal unsafe NavLinkDefinition_fields* NavLinkDefinition_ptr => (NavLinkDefinition_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavLinkDefinition(IntPtr p) => UObject.Make<NavLinkDefinition>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavLinkDefinition DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavLinkDefinition New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

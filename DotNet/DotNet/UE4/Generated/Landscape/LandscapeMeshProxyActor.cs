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
using UE4.Landscape.Native;
using UE4.Engine;

namespace UE4.Landscape {
    ///<summary>Landscape Mesh Proxy Actor</summary>
    public unsafe partial class LandscapeMeshProxyActor : Actor  {
        ///<summary>Landscape Mesh Proxy Component</summary>
        public unsafe LandscapeMeshProxyComponent LandscapeMeshProxyComponent {
            get {return LandscapeMeshProxyActor_ptr->LandscapeMeshProxyComponent;}
        }
        static LandscapeMeshProxyActor() {
            StaticClass = Main.GetClass("LandscapeMeshProxyActor");
        }
        internal unsafe LandscapeMeshProxyActor_fields* LandscapeMeshProxyActor_ptr => (LandscapeMeshProxyActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LandscapeMeshProxyActor(IntPtr p) => UObject.Make<LandscapeMeshProxyActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LandscapeMeshProxyActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LandscapeMeshProxyActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>Landscape Mesh Proxy Component</summary>
    public unsafe partial class LandscapeMeshProxyComponent : StaticMeshComponent  {
        ///<summary>The landscape this proxy was generated for</summary>
        public unsafe FGuid LandscapeGuid {
            get {return LandscapeMeshProxyComponent_ptr->LandscapeGuid;}
            set {LandscapeMeshProxyComponent_ptr->LandscapeGuid = value;}
        }
         //TODO: array not UObject TArray ProxyComponentBases
        ///<summary>LOD level proxy was generated for</summary>
        public unsafe sbyte ProxyLOD {
            get {return LandscapeMeshProxyComponent_ptr->ProxyLOD;}
            set {LandscapeMeshProxyComponent_ptr->ProxyLOD = value;}
        }
        static LandscapeMeshProxyComponent() {
            StaticClass = Main.GetClass("LandscapeMeshProxyComponent");
        }
        internal unsafe LandscapeMeshProxyComponent_fields* LandscapeMeshProxyComponent_ptr => (LandscapeMeshProxyComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LandscapeMeshProxyComponent(IntPtr p) => UObject.Make<LandscapeMeshProxyComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LandscapeMeshProxyComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LandscapeMeshProxyComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

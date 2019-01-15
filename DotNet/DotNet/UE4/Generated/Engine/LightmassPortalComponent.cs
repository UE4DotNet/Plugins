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
    ///<summary>Lightmass Portal Component</summary>
    public unsafe partial class LightmassPortalComponent : SceneComponent  {
        ///<summary>Preview Box</summary>
        public unsafe BoxComponent PreviewBox {
            get {return LightmassPortalComponent_ptr->PreviewBox;}
            set {LightmassPortalComponent_ptr->PreviewBox = value;}
        }
        static LightmassPortalComponent() {
            StaticClass = Main.GetClass("LightmassPortalComponent");
        }
        internal unsafe LightmassPortalComponent_fields* LightmassPortalComponent_ptr => (LightmassPortalComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LightmassPortalComponent(IntPtr p) => UObject.Make<LightmassPortalComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LightmassPortalComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LightmassPortalComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

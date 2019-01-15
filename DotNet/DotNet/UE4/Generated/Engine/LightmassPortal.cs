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
    ///<summary>Lightmass Portal</summary>
    public unsafe partial class LightmassPortal : Actor  {
        ///<summary>Portal Component</summary>
        public unsafe LightmassPortalComponent PortalComponent {
            get {return LightmassPortal_ptr->PortalComponent;}
        }
        ///<summary>Sprite Component</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return LightmassPortal_ptr->SpriteComponent;}
            set {LightmassPortal_ptr->SpriteComponent = value;}
        }
        static LightmassPortal() {
            StaticClass = Main.GetClass("LightmassPortal");
        }
        internal unsafe LightmassPortal_fields* LightmassPortal_ptr => (LightmassPortal_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LightmassPortal(IntPtr p) => UObject.Make<LightmassPortal>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LightmassPortal DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LightmassPortal New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

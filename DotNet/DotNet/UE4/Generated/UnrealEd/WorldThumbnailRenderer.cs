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
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>World Thumbnail Renderer</summary>
    public unsafe partial class WorldThumbnailRenderer : DefaultSizedThumbnailRenderer  {
        ///<summary>Offset used to orient all worlds to show a more vertical camera, if necessary. Individual thumbnail infos can provide additional offset.</summary>
        public unsafe float GlobalOrbitPitchOffset {
            get {return WorldThumbnailRenderer_ptr->GlobalOrbitPitchOffset;}
            set {WorldThumbnailRenderer_ptr->GlobalOrbitPitchOffset = value;}
        }
        ///<summary>Offset used to orient all worlds to face the camera in degrees when using a perspective camera. Individual thumbnail infos can provide additional offset.</summary>
        public unsafe float GlobalOrbitYawOffset {
            get {return WorldThumbnailRenderer_ptr->GlobalOrbitYawOffset;}
            set {WorldThumbnailRenderer_ptr->GlobalOrbitYawOffset = value;}
        }
        public bool bUseUnlitScene {
            get {return Main.GetGetBoolPropertyByName(this, "bUseUnlitScene"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseUnlitScene", value); }
        }
        public bool bAllowWorldThumbnails {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowWorldThumbnails"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowWorldThumbnails", value); }
        }
        static WorldThumbnailRenderer() {
            StaticClass = Main.GetClass("WorldThumbnailRenderer");
        }
        internal unsafe WorldThumbnailRenderer_fields* WorldThumbnailRenderer_ptr => (WorldThumbnailRenderer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WorldThumbnailRenderer(IntPtr p) => UObject.Make<WorldThumbnailRenderer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WorldThumbnailRenderer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WorldThumbnailRenderer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
using UE4.StatsViewer.Native;

namespace UE4.StatsViewer {
    ///<summary>Statistics page for static meshes.</summary>
    public unsafe partial class StaticMeshLightingInfo : UObject  {
         //TODO: weak object TWeakObjectPtr<AActor> StaticMeshActor
         //TODO: weak object TWeakObjectPtr<UStaticMesh> StaticMesh
         //TODO: string FString LevelName
         //TODO: string FString TextureMapping
        public bool bTextureMapping {
            get {return Main.GetGetBoolPropertyByName(this, "bTextureMapping"); }
            set {Main.SetGetBoolPropertyByName(this, "bTextureMapping", value); }
        }
        public bool bHasLightmapTexCoords {
            get {return Main.GetGetBoolPropertyByName(this, "bHasLightmapTexCoords"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasLightmapTexCoords", value); }
        }
        ///<summary>The static lighting resolution the texture mapping was estimated with.</summary>
        public unsafe int StaticLightingResolution {
            get {return StaticMeshLightingInfo_ptr->StaticLightingResolution;}
            set {StaticMeshLightingInfo_ptr->StaticLightingResolution = value;}
        }
        ///<summary>Estimated memory usage in KB for light map texel data.</summary>
        public unsafe float TextureLightMapMemoryUsage {
            get {return StaticMeshLightingInfo_ptr->TextureLightMapMemoryUsage;}
            set {StaticMeshLightingInfo_ptr->TextureLightMapMemoryUsage = value;}
        }
        ///<summary>Estimated memory usage in KB for light map vertex data.</summary>
        public unsafe float VertexLightMapMemoryUsage {
            get {return StaticMeshLightingInfo_ptr->VertexLightMapMemoryUsage;}
            set {StaticMeshLightingInfo_ptr->VertexLightMapMemoryUsage = value;}
        }
        ///<summary>Num lightmap lights</summary>
        public unsafe int LightMapLightCount {
            get {return StaticMeshLightingInfo_ptr->LightMapLightCount;}
            set {StaticMeshLightingInfo_ptr->LightMapLightCount = value;}
        }
        ///<summary>Estimated memory usage in KB for shadow map texel data.</summary>
        public unsafe float TextureShadowMapMemoryUsage {
            get {return StaticMeshLightingInfo_ptr->TextureShadowMapMemoryUsage;}
            set {StaticMeshLightingInfo_ptr->TextureShadowMapMemoryUsage = value;}
        }
        ///<summary>Estimated memory usage in KB for shadow map vertex data.</summary>
        public unsafe float VertexShadowMapMemoryUsage {
            get {return StaticMeshLightingInfo_ptr->VertexShadowMapMemoryUsage;}
            set {StaticMeshLightingInfo_ptr->VertexShadowMapMemoryUsage = value;}
        }
        ///<summary>Number of lights generating shadow maps on the primitive.</summary>
        public unsafe int ShadowMapLightCount {
            get {return StaticMeshLightingInfo_ptr->ShadowMapLightCount;}
            set {StaticMeshLightingInfo_ptr->ShadowMapLightCount = value;}
        }
        static StaticMeshLightingInfo() {
            StaticClass = Main.GetClass("StaticMeshLightingInfo");
        }
        internal unsafe StaticMeshLightingInfo_fields* StaticMeshLightingInfo_ptr => (StaticMeshLightingInfo_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator StaticMeshLightingInfo(IntPtr p) => UObject.Make<StaticMeshLightingInfo>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static StaticMeshLightingInfo DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static StaticMeshLightingInfo New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

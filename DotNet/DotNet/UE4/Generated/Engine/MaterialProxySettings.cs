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


namespace UE4.Engine{
        ///<summary>Material Proxy Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=140 )]
        public unsafe struct MaterialProxySettings {
            ///<summary>Size of generated BaseColor map</summary>
            [FieldOffset(0)] IntPoint TextureSize;

            [FieldOffset(8)] public byte TextureSizingType;

            [FieldOffset(12)] public float GutterSpace;

            [FieldOffset(16)] public bool bNormalMap;

            [FieldOffset(17)] public bool bMetallicMap;

            [FieldOffset(20)] public float MetallicConstant;

            [FieldOffset(24)] public bool bRoughnessMap;

            [FieldOffset(28)] public float RoughnessConstant;

            [FieldOffset(32)] public bool bSpecularMap;

            [FieldOffset(36)] public float SpecularConstant;

            [FieldOffset(40)] public bool bEmissiveMap;

            [FieldOffset(41)] public bool bOpacityMap;

            [FieldOffset(44)] public float OpacityConstant;

            [FieldOffset(48)] public bool bOpacityMaskMap;

            [FieldOffset(52)] public float OpacityMaskConstant;

            [FieldOffset(56)] public bool bAmbientOcclusionMap;

            [FieldOffset(60)] public float AmbientOcclusionConstant;

            ///<summary>Override diffuse map size</summary>
            [FieldOffset(64)] IntPoint DiffuseTextureSize;

            ///<summary>Override normal map size</summary>
            [FieldOffset(72)] IntPoint NormalTextureSize;

            ///<summary>Override metallic map size</summary>
            [FieldOffset(80)] IntPoint MetallicTextureSize;

            ///<summary>Override roughness map size</summary>
            [FieldOffset(88)] IntPoint RoughnessTextureSize;

            ///<summary>Override specular map size</summary>
            [FieldOffset(96)] IntPoint SpecularTextureSize;

            ///<summary>Override emissive map size</summary>
            [FieldOffset(104)] IntPoint EmissiveTextureSize;

            ///<summary>Override opacity map size</summary>
            [FieldOffset(112)] IntPoint OpacityTextureSize;

            ///<summary>Override opacity map size</summary>
            [FieldOffset(120)] IntPoint OpacityMaskTextureSize;

            ///<summary>Ambient Occlusion Texture Size</summary>
            [FieldOffset(128)] IntPoint AmbientOcclusionTextureSize;

            [FieldOffset(136)] public byte MaterialMergeType;

            [FieldOffset(137)] public byte BlendMode;

        }
}

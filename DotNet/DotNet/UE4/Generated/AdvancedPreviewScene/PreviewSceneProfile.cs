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

using UE4.Engine;

namespace UE4.AdvancedPreviewScene{
        ///<summary>Preview scene profile settings structure.</summary>
        [StructLayout( LayoutKind.Explicit, Size=1456 )]
        public unsafe struct PreviewSceneProfile {
            [FieldOffset(0)] byte ProfileName; //TODO: string FString ProfileName

            [FieldOffset(16)] public bool bSharedProfile;

            [FieldOffset(20)] public float DirectionalLightIntensity;

            ///<summary>Manually set the directional light colour</summary>
            [FieldOffset(24)] LinearColor DirectionalLightColor;

            [FieldOffset(40)] public float SkyLightIntensity;

            [FieldOffset(44)] public bool bRotateLightingRig;

            [FieldOffset(45)] public bool bShowEnvironment;

            [FieldOffset(46)] public bool bShowFloor;

            ///<summary>The environment color, used if Show Environment is false.</summary>
            [FieldOffset(48)] LinearColor EnvironmentColor;

            [FieldOffset(64)] public float EnvironmentIntensity;

            [FieldOffset(72)] byte EnvironmentCubeMap; //TODO: soft object TSoftObjectPtr<UTextureCube> EnvironmentCubeMap

            [FieldOffset(120)] byte EnvironmentCubeMapPath; //TODO: string FString EnvironmentCubeMapPath

            ///<summary>Manual set post processing settings</summary>
            [FieldOffset(144)] PostProcessSettings PostProcessingSettings;

            [FieldOffset(1424)] public bool bPostProcessingEnabled;

            [FieldOffset(1428)] public float LightingRigRotation;

            [FieldOffset(1432)] public float RotationSpeed;

            ///<summary>Rotation for directional light</summary>
            [FieldOffset(1436)] Rotator DirectionalLightRotation;

        }
}

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
        ///<summary>UMaterial interface settings for Lightmass</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct LightmassMaterialInterfaceSettings {
            [FieldOffset(0)] public bool bCastShadowAsMasked;

            [FieldOffset(4)] public float EmissiveBoost;

            [FieldOffset(8)] public float DiffuseBoost;

            [FieldOffset(12)] public float ExportResolutionScale;

            [FieldOffset(16)] public bool bOverrideCastShadowAsMasked;

            [FieldOffset(16)] public bool bOverrideEmissiveBoost;

            [FieldOffset(16)] public bool bOverrideDiffuseBoost;

            [FieldOffset(16)] public bool bOverrideExportResolutionScale;

        }
}

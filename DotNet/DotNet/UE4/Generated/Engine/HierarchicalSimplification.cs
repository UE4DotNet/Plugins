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
        ///<summary>Hierarchical Simplification</summary>
        [StructLayout( LayoutKind.Explicit, Size=448 )]
        public unsafe struct HierarchicalSimplification {
            [FieldOffset(4)] public float TransitionScreenSize;

            [FieldOffset(8)] public float OverrideDrawDistance;

            [FieldOffset(12)] public bool bUseOverrideDrawDistance;

            [FieldOffset(13)] public bool bAllowSpecificExclusion;

            [FieldOffset(14)] public bool bSimplifyMesh;

            ///<summary>Simplification Setting if bSimplifyMesh is true</summary>
            [FieldOffset(16)] MeshProxySettings ProxySetting;

            ///<summary>Merge Mesh Setting if bSimplifyMesh is false</summary>
            [FieldOffset(228)] MeshMergingSettings MergeSetting;

            [FieldOffset(432)] public float DesiredBoundRadius;

            [FieldOffset(436)] public float DesiredFillingPercentage;

            [FieldOffset(440)] public int MinNumberOfActorsToBuild;

            [FieldOffset(444)] public bool bOnlyGenerateClustersForVolumes;

            [FieldOffset(445)] public bool bReusePreviousLevelClusters;

        }
}

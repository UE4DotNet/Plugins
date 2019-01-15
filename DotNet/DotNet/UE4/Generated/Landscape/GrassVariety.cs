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

namespace UE4.Landscape{
        ///<summary>Grass Variety</summary>
        [StructLayout( LayoutKind.Explicit, Size=320 )]
        public unsafe struct GrassVariety {
            [FieldOffset(0)] 
            private IntPtr  GrassMesh_field;
            ///<summary>Grass Mesh</summary>
            public StaticMesh GrassMesh {
                get {return GrassMesh_field;}
                set {GrassMesh_field = value;}
            }

            ///<summary>Instances per 10 square meters.</summary>
            [FieldOffset(8)] PerPlatformFloat GrassDensity;

            [FieldOffset(96)] public bool bUseGrid;

            [FieldOffset(100)] public float PlacementJitter;

            ///<summary>The distance where instances will begin to fade out if using a PerInstanceFadeAmount material node. 0 disables.</summary>
            [FieldOffset(104)] PerPlatformInt StartCullDistance;

            ///<summary>The distance where instances will have completely faded out when using a PerInstanceFadeAmount material node.</summary>
            ///<remarks>
            ///0 disables.
            ///When the entire cluster is beyond this distance, the cluster is completely culled and not rendered at all.
            ///</remarks>
            [FieldOffset(192)] PerPlatformInt EndCullDistance;

            [FieldOffset(280)] public int MinLOD;

            [FieldOffset(284)] byte Scaling; //TODO: enum EGrassScaling Scaling

            ///<summary>Specifies the range of scale, from minimum to maximum, to apply to a grass instance's X Scale property</summary>
            [FieldOffset(288)] FloatInterval ScaleX;

            ///<summary>Specifies the range of scale, from minimum to maximum, to apply to a grass instance's Y Scale property</summary>
            [FieldOffset(296)] FloatInterval ScaleY;

            ///<summary>Specifies the range of scale, from minimum to maximum, to apply to a grass instance's Z Scale property</summary>
            [FieldOffset(304)] FloatInterval ScaleZ;

            [FieldOffset(312)] public bool RandomRotation;

            [FieldOffset(313)] public bool AlignToSurface;

            [FieldOffset(314)] public bool bUseLandscapeLightmap;

            ///<summary>Lighting channels that the grass will be assigned.</summary>
            ///<remarks>
            ///Lights with matching channels will affect the grass.
            ///These channels only apply to opaque materials, direct lighting, and dynamic lighting and shadowing.
            ///</remarks>
            [FieldOffset(315)] LightingChannels LightingChannels;

            [FieldOffset(316)] public bool bReceivesDecals;

            [FieldOffset(317)] public bool bCastDynamicShadow;

            [FieldOffset(318)] public bool bKeepInstanceBufferCPUCopy;

        }
}

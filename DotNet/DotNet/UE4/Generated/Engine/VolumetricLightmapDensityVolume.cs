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
    ///<summary>Provides local control over volumetric lightmap density.  Only convex shapes supported.</summary>
    public unsafe partial class VolumetricLightmapDensityVolume : Volume  {
        ///<summary>The Volumetric Lightmap has 3 mipmaps, where the highest density mipmap (mip0) corresponds to VolumetricLightmapDetailCellSize.</summary>
        ///<remarks>
        ///mip0: DetailCellSize
        ///mip1: DetailCellSize * 4
        ///mip2: DetailCellSize * 16
        ///
        ///By default, highest density will be placed around static geometry and static lights, but AllowedMipLevelRange can be used to override this behavior.
        ///Examples:
        ///[0, 3] = Volume does nothing
        ///[1, 3] = Volume removes highest density mip, even near static geometry, which can be useful to save memory ('stat MapBuildData')
        ///[0, 0] = Volume forces highest density.  Warning: using this on a large area can greatly increase memory and build times!
        ///When multiple volumes overlap, the smallest (highest density) values will be used.
        ///</remarks>
        public unsafe Int32Interval AllowedMipLevelRange {
            get {return VolumetricLightmapDensityVolume_ptr->AllowedMipLevelRange;}
            set {VolumetricLightmapDensityVolume_ptr->AllowedMipLevelRange = value;}
        }
        static VolumetricLightmapDensityVolume() {
            StaticClass = Main.GetClass("VolumetricLightmapDensityVolume");
        }
        internal unsafe VolumetricLightmapDensityVolume_fields* VolumetricLightmapDensityVolume_ptr => (VolumetricLightmapDensityVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VolumetricLightmapDensityVolume(IntPtr p) => UObject.Make<VolumetricLightmapDensityVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VolumetricLightmapDensityVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VolumetricLightmapDensityVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

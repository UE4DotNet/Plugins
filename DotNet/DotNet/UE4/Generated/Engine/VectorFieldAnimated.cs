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
    ///<summary>Vector Field Animated</summary>
    public unsafe partial class VectorFieldAnimated : VectorField  {
        ///<summary>The texture from which to create the vector field.</summary>
        public unsafe Texture2D Texture {
            get {return VectorFieldAnimated_ptr->Texture;}
            set {VectorFieldAnimated_ptr->Texture = value;}
        }
        ///<summary>The operation used to construct the vector field.</summary>
        public unsafe byte ConstructionOp {
            get {return VectorFieldAnimated_ptr->ConstructionOp;}
            set {VectorFieldAnimated_ptr->ConstructionOp = value;}
        }
        ///<summary>The size of the volume. Valid sizes: 16, 32, 64.</summary>
        public unsafe int VolumeSizeX {
            get {return VectorFieldAnimated_ptr->VolumeSizeX;}
            set {VectorFieldAnimated_ptr->VolumeSizeX = value;}
        }
        ///<summary>The size of the volume. Valid sizes: 16, 32, 64.</summary>
        public unsafe int VolumeSizeY {
            get {return VectorFieldAnimated_ptr->VolumeSizeY;}
            set {VectorFieldAnimated_ptr->VolumeSizeY = value;}
        }
        ///<summary>The size of the volume. Valid sizes: 16, 32, 64.</summary>
        public unsafe int VolumeSizeZ {
            get {return VectorFieldAnimated_ptr->VolumeSizeZ;}
            set {VectorFieldAnimated_ptr->VolumeSizeZ = value;}
        }
        ///<summary>The number of horizontal subimages in the texture atlas.</summary>
        public unsafe int SubImagesX {
            get {return VectorFieldAnimated_ptr->SubImagesX;}
            set {VectorFieldAnimated_ptr->SubImagesX = value;}
        }
        ///<summary>The number of vertical subimages in the texture atlas.</summary>
        public unsafe int SubImagesY {
            get {return VectorFieldAnimated_ptr->SubImagesY;}
            set {VectorFieldAnimated_ptr->SubImagesY = value;}
        }
        ///<summary>The number of frames in the atlas.</summary>
        public unsafe int FrameCount {
            get {return VectorFieldAnimated_ptr->FrameCount;}
            set {VectorFieldAnimated_ptr->FrameCount = value;}
        }
        ///<summary>The rate at which to interpolate between frames.</summary>
        public unsafe float FramesPerSecond {
            get {return VectorFieldAnimated_ptr->FramesPerSecond;}
            set {VectorFieldAnimated_ptr->FramesPerSecond = value;}
        }
        public bool bLoop {
            get {return Main.GetGetBoolPropertyByName(this, "bLoop"); }
            set {Main.SetGetBoolPropertyByName(this, "bLoop", value); }
        }
        ///<summary>A static vector field used to add noise.</summary>
        public unsafe VectorFieldStatic NoiseField {
            get {return VectorFieldAnimated_ptr->NoiseField;}
            set {VectorFieldAnimated_ptr->NoiseField = value;}
        }
        ///<summary>Scale to apply to vectors in the noise field.</summary>
        public unsafe float NoiseScale {
            get {return VectorFieldAnimated_ptr->NoiseScale;}
            set {VectorFieldAnimated_ptr->NoiseScale = value;}
        }
        ///<summary>The maximum magnitude of noise vectors to apply.</summary>
        public unsafe float NoiseMax {
            get {return VectorFieldAnimated_ptr->NoiseMax;}
            set {VectorFieldAnimated_ptr->NoiseMax = value;}
        }
        static VectorFieldAnimated() {
            StaticClass = Main.GetClass("VectorFieldAnimated");
        }
        internal unsafe VectorFieldAnimated_fields* VectorFieldAnimated_ptr => (VectorFieldAnimated_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VectorFieldAnimated(IntPtr p) => UObject.Make<VectorFieldAnimated>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VectorFieldAnimated DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VectorFieldAnimated New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

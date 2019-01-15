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
    ///<summary>SubUV animation asset, which caches bounding geometry for regions in the SubUVTexture with non-zero opacity.</summary>
    ///<remarks>Particle emitters with a SubUV module which use this asset leverage the optimal bounding geometry to reduce overdraw.</remarks>
    public unsafe partial class SubUVAnimation : UObject  {
        ///<summary>Texture to generate bounding geometry from.</summary>
        public unsafe Texture2D SubUVTexture {
            get {return SubUVAnimation_ptr->SubUVTexture;}
            set {SubUVAnimation_ptr->SubUVTexture = value;}
        }
        ///<summary>The number of sub-images horizontally in the texture</summary>
        public unsafe int SubImages_Horizontal {
            get {return SubUVAnimation_ptr->SubImages_Horizontal;}
            set {SubUVAnimation_ptr->SubImages_Horizontal = value;}
        }
        ///<summary>The number of sub-images vertically in the texture</summary>
        public unsafe int SubImages_Vertical {
            get {return SubUVAnimation_ptr->SubImages_Vertical;}
            set {SubUVAnimation_ptr->SubImages_Vertical = value;}
        }
        ///<summary>More bounding vertices results in reduced overdraw, but adds more triangle overhead.</summary>
        ///<remarks>
        ///The eight vertex mode is best used when the SubUV texture has a lot of space to cut out that is not captured by the four vertex version,
        ///and when the particles using the texture will be few and large.
        ///</remarks>
        public unsafe byte BoundingMode {
            get {return SubUVAnimation_ptr->BoundingMode;}
            set {SubUVAnimation_ptr->BoundingMode = value;}
        }
        ///<summary>Opacity Source Mode</summary>
        public unsafe byte OpacitySourceMode {
            get {return SubUVAnimation_ptr->OpacitySourceMode;}
            set {SubUVAnimation_ptr->OpacitySourceMode = value;}
        }
        ///<summary>Alpha channel values larger than the threshold are considered occupied and will be contained in the bounding geometry.</summary>
        ///<remarks>Raising this threshold slightly can reduce overdraw in particles using this animation asset.</remarks>
        public unsafe float AlphaThreshold {
            get {return SubUVAnimation_ptr->AlphaThreshold;}
            set {SubUVAnimation_ptr->AlphaThreshold = value;}
        }
        static SubUVAnimation() {
            StaticClass = Main.GetClass("SubUVAnimation");
        }
        internal unsafe SubUVAnimation_fields* SubUVAnimation_ptr => (SubUVAnimation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SubUVAnimation(IntPtr p) => UObject.Make<SubUVAnimation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SubUVAnimation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SubUVAnimation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

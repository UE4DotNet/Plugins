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


namespace UE4.SlateCore{
        ///<summary>An brush which contains information about how to draw a Slate element</summary>
        ///<remarks>//, meta = (HasNativeMake = ""))</remarks>
        [StructLayout( LayoutKind.Explicit, Size=160 )]
        public unsafe struct SlateBrush {
            ///<summary>Size of the resource in Slate Units</summary>
            [FieldOffset(8)] Vector2D ImageSize;

            ///<summary>The margin to use in Box and Border modes</summary>
            [FieldOffset(16)] Margin Margin;

            ///<summary>Tinting applied to the image.</summary>
            [FieldOffset(48)] SlateColor TintColor;

            [FieldOffset(88)] 
            private IntPtr  ResourceObject_field;
            ///<summary>
            ///The image to render for this brush, can be a UTexture or UMaterialInterface or an object implementing
            ///the AtlasedTextureInterface.
            ///</summary>
            public UObject ResourceObject {
                get {return ResourceObject_field;}
                set {ResourceObject_field = value;}
            }

            [FieldOffset(96)] public Name ResourceName;

            ///<summary>Optional UV region for an image</summary>
            ///<remarks>When valid - overrides UV region specified in resource proxy</remarks>
            [FieldOffset(108)] Box2D UVRegion;

            [FieldOffset(128)] public byte DrawAs;

            [FieldOffset(129)] public byte Tiling;

            [FieldOffset(130)] public byte Mirroring;

            [FieldOffset(131)] public byte ImageType;

            [FieldOffset(152)] public bool bIsDynamicallyLoaded;

        }
}

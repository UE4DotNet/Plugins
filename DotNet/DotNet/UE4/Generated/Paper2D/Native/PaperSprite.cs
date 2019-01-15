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


namespace UE4.Paper2D.Native {
    [StructLayout( LayoutKind.Explicit, Size=416 )]
    internal unsafe struct PaperSprite_fields {
        [FieldOffset(72)] public Vector2D OriginInSourceImageBeforeTrimming;
        [FieldOffset(80)] public Vector2D SourceImageDimensionBeforeTrimming;
        [FieldOffset(88)] public bool bTrimmedInSourceImage;
        [FieldOffset(89)] public bool bRotatedInSourceImage;
        [FieldOffset(92)] public Vector2D SourceTextureDimension;
        [FieldOffset(100)] public Vector2D SourceUV;
        [FieldOffset(108)] public Vector2D SourceDimension;
        [FieldOffset(120)]  public IntPtr  SourceTexture;
        [FieldOffset(128)] public NativeArray AdditionalSourceTextures;
        [FieldOffset(144)] public Vector2D BakedSourceUV;
        [FieldOffset(152)] public Vector2D BakedSourceDimension;
        [FieldOffset(160)]  public IntPtr  BakedSourceTexture;
        [FieldOffset(168)]  public IntPtr  DefaultMaterial;
        [FieldOffset(176)]  public IntPtr  AlternateMaterial;
        [FieldOffset(184)] public NativeArray Sockets;
        [FieldOffset(200)] public byte SpriteCollisionDomain;
        [FieldOffset(204)] public float PixelsPerUnrealUnit;
        [FieldOffset(208)]  public IntPtr  BodySetup;
        [FieldOffset(216)] public byte PivotMode;
        [FieldOffset(220)] public Vector2D CustomPivotPoint;
        [FieldOffset(228)] public bool bSnapPivotToPixelGrid;
        [FieldOffset(232)] public SpriteGeometryCollection CollisionGeometry;
        [FieldOffset(280)] public float CollisionThickness;
        [FieldOffset(288)] public SpriteGeometryCollection RenderGeometry;
        [FieldOffset(336)]  public IntPtr  AtlasGroup;
        [FieldOffset(392)] public int AlternateMaterialSplitIndex;
        [FieldOffset(400)] public NativeArray BakedRenderData;
    }
    internal unsafe struct PaperSprite_methods {
    }
    internal unsafe struct PaperSprite_events {
    }
}

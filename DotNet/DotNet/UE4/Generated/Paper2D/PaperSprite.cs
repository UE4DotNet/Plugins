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
using UE4.Paper2D.Native;
using UE4.Engine;

namespace UE4.Paper2D {
    ///<summary>
    ///Sprite Asset
    ///Stores the data necessary to render a single 2D sprite (from a region of a texture)
    ///Can also contain collision shapes for the sprite.
    ///</summary>
    ///<remarks>
    ///@see UPaperSpriteComponent
    ///</remarks>
    public unsafe partial class PaperSprite : UObject  {
        ///<summary>Origin within SourceImage, prior to atlasing</summary>
        public unsafe Vector2D OriginInSourceImageBeforeTrimming {
            get {return PaperSprite_ptr->OriginInSourceImageBeforeTrimming;}
            set {PaperSprite_ptr->OriginInSourceImageBeforeTrimming = value;}
        }
        ///<summary>Dimensions of SourceImage</summary>
        public unsafe Vector2D SourceImageDimensionBeforeTrimming {
            get {return PaperSprite_ptr->SourceImageDimensionBeforeTrimming;}
            set {PaperSprite_ptr->SourceImageDimensionBeforeTrimming = value;}
        }
        public bool bTrimmedInSourceImage {
            get {return Main.GetGetBoolPropertyByName(this, "bTrimmedInSourceImage"); }
            set {Main.SetGetBoolPropertyByName(this, "bTrimmedInSourceImage", value); }
        }
        public bool bRotatedInSourceImage {
            get {return Main.GetGetBoolPropertyByName(this, "bRotatedInSourceImage"); }
            set {Main.SetGetBoolPropertyByName(this, "bRotatedInSourceImage", value); }
        }
        ///<summary>Dimension of the texture when this sprite was created</summary>
        ///<remarks>Used when the sprite is resized at some point</remarks>
        public unsafe Vector2D SourceTextureDimension {
            get {return PaperSprite_ptr->SourceTextureDimension;}
            set {PaperSprite_ptr->SourceTextureDimension = value;}
        }
        ///<summary>Position within SourceTexture (in pixels)</summary>
        public unsafe Vector2D SourceUV {
            get {return PaperSprite_ptr->SourceUV;}
            set {PaperSprite_ptr->SourceUV = value;}
        }
        ///<summary>Dimensions within SourceTexture (in pixels)</summary>
        public unsafe Vector2D SourceDimension {
            get {return PaperSprite_ptr->SourceDimension;}
            set {PaperSprite_ptr->SourceDimension = value;}
        }
        ///<summary>The source texture that the sprite comes from</summary>
        public unsafe Texture2D SourceTexture {
            get {return PaperSprite_ptr->SourceTexture;}
            set {PaperSprite_ptr->SourceTexture = value;}
        }
        ///<summary>Additional source textures for other slots</summary>
        public ObjectArrayField<Texture> AdditionalSourceTextures{ get {
            if(AdditionalSourceTextures_store == null) AdditionalSourceTextures_store = new ObjectArrayField<Texture> (&PaperSprite_ptr->AdditionalSourceTextures);
            return AdditionalSourceTextures_store;
        } }
        private ObjectArrayField<Texture> AdditionalSourceTextures_store;

        ///<summary>Position within BakedSourceTexture (in pixels)</summary>
        public unsafe Vector2D BakedSourceUV {
            get {return PaperSprite_ptr->BakedSourceUV;}
            set {PaperSprite_ptr->BakedSourceUV = value;}
        }
        ///<summary>Dimensions within BakedSourceTexture (in pixels)</summary>
        public unsafe Vector2D BakedSourceDimension {
            get {return PaperSprite_ptr->BakedSourceDimension;}
            set {PaperSprite_ptr->BakedSourceDimension = value;}
        }
        ///<summary>Baked Source Texture</summary>
        public unsafe Texture2D BakedSourceTexture {
            get {return PaperSprite_ptr->BakedSourceTexture;}
            set {PaperSprite_ptr->BakedSourceTexture = value;}
        }
        ///<summary>The material to use on a sprite instance if not overridden (this is the default material when only one is being used, and is the translucent/masked material for Diced render geometry, slot 0)</summary>
        public unsafe MaterialInterface DefaultMaterial {
            get {return PaperSprite_ptr->DefaultMaterial;}
        }
        ///<summary>The alternate material to use on a sprite instance if not overridden (this is only used for Diced render geometry, and will be the opaque material in that case, slot 1)</summary>
        public unsafe MaterialInterface AlternateMaterial {
            get {return PaperSprite_ptr->AlternateMaterial;}
        }
         //TODO: array not UObject TArray Sockets
        ///<summary>Collision domain (no collision, 2D, or 3D)</summary>
        public unsafe byte SpriteCollisionDomain {
            get {return PaperSprite_ptr->SpriteCollisionDomain;}
            set {PaperSprite_ptr->SpriteCollisionDomain = value;}
        }
        ///<summary>The scaling factor between pixels and Unreal units (cm) (e.g., 0.64 would make a 64 pixel wide sprite take up 100 cm)</summary>
        public unsafe float PixelsPerUnrealUnit {
            get {return PaperSprite_ptr->PixelsPerUnrealUnit;}
            set {PaperSprite_ptr->PixelsPerUnrealUnit = value;}
        }
        ///<summary>Baked physics data.</summary>
        public unsafe BodySetup BodySetup {
            get {return PaperSprite_ptr->BodySetup;}
            set {PaperSprite_ptr->BodySetup = value;}
        }
        ///<summary>Pivot mode</summary>
        public unsafe byte PivotMode {
            get {return PaperSprite_ptr->PivotMode;}
            set {PaperSprite_ptr->PivotMode = value;}
        }
        ///<summary>Custom pivot point (relative to the sprite rectangle)</summary>
        public unsafe Vector2D CustomPivotPoint {
            get {return PaperSprite_ptr->CustomPivotPoint;}
            set {PaperSprite_ptr->CustomPivotPoint = value;}
        }
        public bool bSnapPivotToPixelGrid {
            get {return Main.GetGetBoolPropertyByName(this, "bSnapPivotToPixelGrid"); }
            set {Main.SetGetBoolPropertyByName(this, "bSnapPivotToPixelGrid", value); }
        }
        ///<summary>Custom collision geometry polygons (in texture space)</summary>
        public unsafe SpriteGeometryCollection CollisionGeometry {
            get {return PaperSprite_ptr->CollisionGeometry;}
            set {PaperSprite_ptr->CollisionGeometry = value;}
        }
        ///<summary>The extrusion thickness of collision geometry when using a 3D collision domain</summary>
        public unsafe float CollisionThickness {
            get {return PaperSprite_ptr->CollisionThickness;}
            set {PaperSprite_ptr->CollisionThickness = value;}
        }
        ///<summary>Custom render geometry polygons (in texture space)</summary>
        public unsafe SpriteGeometryCollection RenderGeometry {
            get {return PaperSprite_ptr->RenderGeometry;}
            set {PaperSprite_ptr->RenderGeometry = value;}
        }
        ///<summary>Spritesheet group that this sprite belongs to</summary>
        public unsafe PaperSpriteAtlas AtlasGroup {
            get {return PaperSprite_ptr->AtlasGroup;}
            set {PaperSprite_ptr->AtlasGroup = value;}
        }
        ///<summary>The point at which the alternate material takes over in the baked render data (or INDEX_NONE)</summary>
        public unsafe int AlternateMaterialSplitIndex {
            get {return PaperSprite_ptr->AlternateMaterialSplitIndex;}
            set {PaperSprite_ptr->AlternateMaterialSplitIndex = value;}
        }
         //TODO: array not UObject TArray BakedRenderData
        static PaperSprite() {
            StaticClass = Main.GetClass("PaperSprite");
        }
        internal unsafe PaperSprite_fields* PaperSprite_ptr => (PaperSprite_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperSprite(IntPtr p) => UObject.Make<PaperSprite>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperSprite DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperSprite New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

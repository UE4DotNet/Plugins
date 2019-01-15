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
    ///<summary>The terrain visualization component for an associated spline component.</summary>
    ///<remarks>This takes a 2D terrain material and instances sprite geometry along the spline path.</remarks>
    public unsafe partial class PaperTerrainComponent : PrimitiveComponent  {

        ///<summary>Set color of the terrain</summary>
        public void SetTerrainColor(LinearColor NewColor)  => 
            PaperTerrainComponent_methods.SetTerrainColor_method.Invoke(ObjPointer, NewColor);
        ///<summary>The terrain material to apply to this component (set of rules for which sprites are used on different surfaces or the interior)</summary>
        public unsafe PaperTerrainMaterial TerrainMaterial {
            get {return PaperTerrainComponent_ptr->TerrainMaterial;}
        }
        public bool bClosedSpline {
            get {return Main.GetGetBoolPropertyByName(this, "bClosedSpline"); }
        }
        public bool bFilledSpline {
            get {return Main.GetGetBoolPropertyByName(this, "bFilledSpline"); }
        }
        ///<summary>Associated Spline</summary>
        public unsafe PaperTerrainSplineComponent AssociatedSpline {
            get {return PaperTerrainComponent_ptr->AssociatedSpline;}
            set {PaperTerrainComponent_ptr->AssociatedSpline = value;}
        }
        ///<summary>Random seed used for choosing which spline meshes to use.</summary>
        public unsafe int RandomSeed {
            get {return PaperTerrainComponent_ptr->RandomSeed;}
            set {PaperTerrainComponent_ptr->RandomSeed = value;}
        }
        ///<summary>The overlap amount between segments</summary>
        public unsafe float SegmentOverlapAmount {
            get {return PaperTerrainComponent_ptr->SegmentOverlapAmount;}
            set {PaperTerrainComponent_ptr->SegmentOverlapAmount = value;}
        }
        ///<summary>The color of the terrain (passed to the sprite material as a vertex color)</summary>
        public unsafe LinearColor TerrainColor {
            get {return PaperTerrainComponent_ptr->TerrainColor;}
        }
        ///<summary>Number of steps per spline segment to place in the reparameterization table</summary>
        public unsafe int ReparamStepsPerSegment {
            get {return PaperTerrainComponent_ptr->ReparamStepsPerSegment;}
            set {PaperTerrainComponent_ptr->ReparamStepsPerSegment = value;}
        }
        ///<summary>Collision domain (no collision, 2D (experimental), or 3D)</summary>
        public unsafe byte SpriteCollisionDomain {
            get {return PaperTerrainComponent_ptr->SpriteCollisionDomain;}
            set {PaperTerrainComponent_ptr->SpriteCollisionDomain = value;}
        }
        ///<summary>The extrusion thickness of collision geometry when using a 3D collision domain</summary>
        public unsafe float CollisionThickness {
            get {return PaperTerrainComponent_ptr->CollisionThickness;}
            set {PaperTerrainComponent_ptr->CollisionThickness = value;}
        }
        ///<summary>Description of collision</summary>
        public unsafe BodySetup CachedBodySetup {
            get {return PaperTerrainComponent_ptr->CachedBodySetup;}
            set {PaperTerrainComponent_ptr->CachedBodySetup = value;}
        }
        static PaperTerrainComponent() {
            StaticClass = Main.GetClass("PaperTerrainComponent");
        }
        internal unsafe PaperTerrainComponent_fields* PaperTerrainComponent_ptr => (PaperTerrainComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperTerrainComponent(IntPtr p) => UObject.Make<PaperTerrainComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperTerrainComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperTerrainComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

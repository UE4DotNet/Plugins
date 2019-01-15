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
    ///<summary>Particle Module Type Data Beam 2</summary>
    public unsafe partial class ParticleModuleTypeDataBeam2 : ParticleModuleTypeDataBase  {
        ///<summary>The method with which to form the beam(s).</summary>
        ///<remarks>
        ///Must be one of the following:
        ///        PEB2M_Distance  - Use the distance property to emit a beam along the X-axis of the emitter.
        ///        PEB2M_Target    - Emit a beam from the source to the supplied target.
        ///        PEB2M_Branch    - Currently unimplemented.
        ///</remarks>
        public unsafe byte BeamMethod {
            get {return ParticleModuleTypeDataBeam2_ptr->BeamMethod;}
            set {ParticleModuleTypeDataBeam2_ptr->BeamMethod = value;}
        }
        ///<summary>The number of times to tile the texture along each beam.</summary>
        ///<remarks>
        ///Overridden by TextureTilingDistance if it is > 0.0.
        ///    1st UV set only. 2nd UV set does not Tile.
        ///</remarks>
        public unsafe int TextureTile {
            get {return ParticleModuleTypeDataBeam2_ptr->TextureTile;}
            set {ParticleModuleTypeDataBeam2_ptr->TextureTile = value;}
        }
        ///<summary>The distance per texture tile.</summary>
        ///<remarks>1st UV set only. 2nd UV set does not Tile.</remarks>
        public unsafe float TextureTileDistance {
            get {return ParticleModuleTypeDataBeam2_ptr->TextureTileDistance;}
            set {ParticleModuleTypeDataBeam2_ptr->TextureTileDistance = value;}
        }
        ///<summary>The number of sheets to render</summary>
        public unsafe int Sheets {
            get {return ParticleModuleTypeDataBeam2_ptr->Sheets;}
            set {ParticleModuleTypeDataBeam2_ptr->Sheets = value;}
        }
        ///<summary>The number of live beams</summary>
        public unsafe int MaxBeamCount {
            get {return ParticleModuleTypeDataBeam2_ptr->MaxBeamCount;}
            set {ParticleModuleTypeDataBeam2_ptr->MaxBeamCount = value;}
        }
        ///<summary>The speed at which the beam should move from source to target when firing up.</summary>
        ///<remarks>'0' indicates instantaneous</remarks>
        public unsafe float Speed {
            get {return ParticleModuleTypeDataBeam2_ptr->Speed;}
            set {ParticleModuleTypeDataBeam2_ptr->Speed = value;}
        }
        ///<summary>Indicates whether the beam should be interpolated.</summary>
        ///<remarks>
        ///<= 0 --> no
        ///    >  0 --> yes (and is equal to the number of interpolation steps that should be taken.
        ///</remarks>
        public unsafe int InterpolationPoints {
            get {return ParticleModuleTypeDataBeam2_ptr->InterpolationPoints;}
            set {ParticleModuleTypeDataBeam2_ptr->InterpolationPoints = value;}
        }
        public bool bAlwaysOn {
            get {return Main.GetGetBoolPropertyByName(this, "bAlwaysOn"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlwaysOn", value); }
        }
        ///<summary>The approach to use for determining the Up vector(s) for the beam.</summary>
        ///<remarks>
        ///0 indicates that the Up FVector should be calculated at EVERY point in the beam.
        ///1 indicates a single Up FVector should be determined at the start of the beam and used at every point.
        ///N indicates an Up FVector should be calculated every N points of the beam and interpolated between them.
        ///    [NOTE: This mode is currently unsupported.]
        ///</remarks>
        public unsafe int UpVectorStepSize {
            get {return ParticleModuleTypeDataBeam2_ptr->UpVectorStepSize;}
            set {ParticleModuleTypeDataBeam2_ptr->UpVectorStepSize = value;}
        }
        ///<summary>The name of the emitter to branch from (if mode is PEB2M_Branch)</summary>
        ///<remarks>MUST BE IN THE SAME PARTICLE SYSTEM!</remarks>
        public unsafe Name BranchParentName {
            get {return ParticleModuleTypeDataBeam2_ptr->BranchParentName;}
            set {ParticleModuleTypeDataBeam2_ptr->BranchParentName = value;}
        }
        ///<summary>The distance along the X-axis to stretch the beam</summary>
        ///<remarks>Distance is only used if BeamMethod is PEB2M_Distance</remarks>
        public unsafe RawDistributionFloat Distance {
            get {return ParticleModuleTypeDataBeam2_ptr->Distance;}
            set {ParticleModuleTypeDataBeam2_ptr->Distance = value;}
        }
        ///<summary>
        ///Tapering mode - one of the following:
        ///PEBTM_None              - No tapering is applied
        ///PEBTM_Full              - Taper the beam relative to source-->target, regardless of current beam length
        ///</summary>
        ///<remarks>PEBTM_Partial   - Taper the beam relative to source-->location, 0=source,1=endpoint</remarks>
        public unsafe byte TaperMethod {
            get {return ParticleModuleTypeDataBeam2_ptr->TaperMethod;}
            set {ParticleModuleTypeDataBeam2_ptr->TaperMethod = value;}
        }
        ///<summary>Tapering factor, 0 = source of beam, 1 = target</summary>
        public unsafe RawDistributionFloat TaperFactor {
            get {return ParticleModuleTypeDataBeam2_ptr->TaperFactor;}
            set {ParticleModuleTypeDataBeam2_ptr->TaperFactor = value;}
        }
        ///<summary>
        ///Tapering scaling
        ///    This is intended to be either a constant, uniform or a ParticleParam.
        ///</summary>
        ///<remarks>
        ///If a curve is used, 0/1 mapping of source/target... which could be integrated into
        ///    the taper factor itself, and therefore makes no sense.
        ///</remarks>
        public unsafe RawDistributionFloat TaperScale {
            get {return ParticleModuleTypeDataBeam2_ptr->TaperScale;}
            set {ParticleModuleTypeDataBeam2_ptr->TaperScale = value;}
        }
        public bool RenderGeometry {
            get {return Main.GetGetBoolPropertyByName(this, "RenderGeometry"); }
            set {Main.SetGetBoolPropertyByName(this, "RenderGeometry", value); }
        }
        public bool RenderDirectLine {
            get {return Main.GetGetBoolPropertyByName(this, "RenderDirectLine"); }
            set {Main.SetGetBoolPropertyByName(this, "RenderDirectLine", value); }
        }
        public bool RenderLines {
            get {return Main.GetGetBoolPropertyByName(this, "RenderLines"); }
            set {Main.SetGetBoolPropertyByName(this, "RenderLines", value); }
        }
        public bool RenderTessellation {
            get {return Main.GetGetBoolPropertyByName(this, "RenderTessellation"); }
            set {Main.SetGetBoolPropertyByName(this, "RenderTessellation", value); }
        }
        static ParticleModuleTypeDataBeam2() {
            StaticClass = Main.GetClass("ParticleModuleTypeDataBeam2");
        }
        internal unsafe ParticleModuleTypeDataBeam2_fields* ParticleModuleTypeDataBeam2_ptr => (ParticleModuleTypeDataBeam2_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleTypeDataBeam2(IntPtr p) => UObject.Make<ParticleModuleTypeDataBeam2>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleTypeDataBeam2 DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleTypeDataBeam2 New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>Particle Module Required</summary>
    public unsafe partial class ParticleModuleRequired : ParticleModule  {
        ///<summary>The material to utilize for the emitter at this LOD level.</summary>
        public unsafe MaterialInterface Material {
            get {return ParticleModuleRequired_ptr->Material;}
            set {ParticleModuleRequired_ptr->Material = value;}
        }
        ///<summary>Emitter Origin</summary>
        public unsafe Vector EmitterOrigin {
            get {return ParticleModuleRequired_ptr->EmitterOrigin;}
            set {ParticleModuleRequired_ptr->EmitterOrigin = value;}
        }
        ///<summary>Emitter Rotation</summary>
        public unsafe Rotator EmitterRotation {
            get {return ParticleModuleRequired_ptr->EmitterRotation;}
            set {ParticleModuleRequired_ptr->EmitterRotation = value;}
        }
        ///<summary>The screen alignment to utilize for the emitter at this LOD level.</summary>
        ///<remarks>
        ///One of the following:
        ///PSA_FacingCameraPosition - Faces the camera position, but is not dependent on the camera rotation.
        ///                                                        This method produces more stable particles under camera rotation.
        ///PSA_Square                      - Uniform scale (via SizeX) facing the camera
        ///PSA_Rectangle           - Non-uniform scale (via SizeX and SizeY) facing the camera
        ///PSA_Velocity            - Orient the particle towards both the camera and the direction
        ///                                          the particle is moving. Non-uniform scaling is allowed.
        ///PSA_TypeSpecific        - Use the alignment method indicated in the type data module.
        ///PSA_FacingCameraDistanceBlend - Blends between PSA_FacingCameraPosition and PSA_Square over specified distance.
        ///</remarks>
        public unsafe byte ScreenAlignment {
            get {return ParticleModuleRequired_ptr->ScreenAlignment;}
            set {ParticleModuleRequired_ptr->ScreenAlignment = value;}
        }
        ///<summary>The distance at which PSA_FacingCameraDistanceBlend    is fully PSA_Square</summary>
        public unsafe float MinFacingCameraBlendDistance {
            get {return ParticleModuleRequired_ptr->MinFacingCameraBlendDistance;}
            set {ParticleModuleRequired_ptr->MinFacingCameraBlendDistance = value;}
        }
        ///<summary>The distance at which PSA_FacingCameraDistanceBlend    is fully PSA_FacingCameraPosition</summary>
        public unsafe float MaxFacingCameraBlendDistance {
            get {return ParticleModuleRequired_ptr->MaxFacingCameraBlendDistance;}
            set {ParticleModuleRequired_ptr->MaxFacingCameraBlendDistance = value;}
        }
        public bool bUseLocalSpace {
            get {return Main.GetGetBoolPropertyByName(this, "bUseLocalSpace"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseLocalSpace", value); }
        }
        public bool bKillOnDeactivate {
            get {return Main.GetGetBoolPropertyByName(this, "bKillOnDeactivate"); }
            set {Main.SetGetBoolPropertyByName(this, "bKillOnDeactivate", value); }
        }
        public bool bKillOnCompleted {
            get {return Main.GetGetBoolPropertyByName(this, "bKillOnCompleted"); }
            set {Main.SetGetBoolPropertyByName(this, "bKillOnCompleted", value); }
        }
        ///<summary>The sorting mode to use for this emitter.</summary>
        ///<remarks>
        ///PSORTMODE_None                          - No sorting required.
        ///PSORTMODE_ViewProjDepth         - Sort by view projected depth of the particle.
        ///PSORTMODE_DistanceToView        - Sort by distance of particle to view in world space.
        ///PSORTMODE_Age_OldestFirst       - Sort by age, oldest drawn first.
        ///PSORTMODE_Age_NewestFirst       - Sort by age, newest drawn first.
        ///</remarks>
        public unsafe byte SortMode {
            get {return ParticleModuleRequired_ptr->SortMode;}
            set {ParticleModuleRequired_ptr->SortMode = value;}
        }
        public bool bUseLegacyEmitterTime {
            get {return Main.GetGetBoolPropertyByName(this, "bUseLegacyEmitterTime"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseLegacyEmitterTime", value); }
        }
        public bool bRemoveHMDRoll {
            get {return Main.GetGetBoolPropertyByName(this, "bRemoveHMDRoll"); }
            set {Main.SetGetBoolPropertyByName(this, "bRemoveHMDRoll", value); }
        }
        ///<summary>How long, in seconds, the emitter will run before looping.</summary>
        public unsafe float EmitterDuration {
            get {return ParticleModuleRequired_ptr->EmitterDuration;}
            set {ParticleModuleRequired_ptr->EmitterDuration = value;}
        }
        ///<summary>The low end of the emitter duration if using a range.</summary>
        public unsafe float EmitterDurationLow {
            get {return ParticleModuleRequired_ptr->EmitterDurationLow;}
            set {ParticleModuleRequired_ptr->EmitterDurationLow = value;}
        }
        public bool bEmitterDurationUseRange {
            get {return Main.GetGetBoolPropertyByName(this, "bEmitterDurationUseRange"); }
            set {Main.SetGetBoolPropertyByName(this, "bEmitterDurationUseRange", value); }
        }
        public bool bDurationRecalcEachLoop {
            get {return Main.GetGetBoolPropertyByName(this, "bDurationRecalcEachLoop"); }
            set {Main.SetGetBoolPropertyByName(this, "bDurationRecalcEachLoop", value); }
        }
        ///<summary>The number of times to loop the emitter.</summary>
        ///<remarks>0 indicates loop continuously</remarks>
        public unsafe int EmitterLoops {
            get {return ParticleModuleRequired_ptr->EmitterLoops;}
            set {ParticleModuleRequired_ptr->EmitterLoops = value;}
        }
        ///<summary>The rate at which to spawn particles</summary>
        public unsafe RawDistributionFloat SpawnRate {
            get {return ParticleModuleRequired_ptr->SpawnRate;}
            set {ParticleModuleRequired_ptr->SpawnRate = value;}
        }
        ///<summary>The method to utilize when burst-emitting particles</summary>
        public unsafe byte ParticleBurstMethod {
            get {return ParticleModuleRequired_ptr->ParticleBurstMethod;}
            set {ParticleModuleRequired_ptr->ParticleBurstMethod = value;}
        }
         //TODO: array not UObject TArray BurstList
        ///<summary>Indicates the time (in seconds) that this emitter should be delayed in the particle system.</summary>
        public unsafe float EmitterDelay {
            get {return ParticleModuleRequired_ptr->EmitterDelay;}
            set {ParticleModuleRequired_ptr->EmitterDelay = value;}
        }
        ///<summary>The low end of the emitter delay if using a range.</summary>
        public unsafe float EmitterDelayLow {
            get {return ParticleModuleRequired_ptr->EmitterDelayLow;}
            set {ParticleModuleRequired_ptr->EmitterDelayLow = value;}
        }
        public bool bEmitterDelayUseRange {
            get {return Main.GetGetBoolPropertyByName(this, "bEmitterDelayUseRange"); }
            set {Main.SetGetBoolPropertyByName(this, "bEmitterDelayUseRange", value); }
        }
        public bool bDelayFirstLoopOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bDelayFirstLoopOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bDelayFirstLoopOnly", value); }
        }
        ///<summary>The interpolation method to used for the SubUV image selection.</summary>
        ///<remarks>
        ///One of the following:
        ///PSUVIM_None                     - Do not apply SubUV modules to this emitter.
        ///PSUVIM_Linear           - Smoothly transition between sub-images in the given order,
        ///                                          with no blending between the current and the next
        ///PSUVIM_Linear_Blend     - Smoothly transition between sub-images in the given order,
        ///                                          blending between the current and the next
        ///PSUVIM_Random           - Pick the next image at random, with no blending between
        ///                                          the current and the next
        ///PSUVIM_Random_Blend     - Pick the next image at random, blending between the current
        ///                                          and the next
        ///</remarks>
        public unsafe byte InterpolationMethod {
            get {return ParticleModuleRequired_ptr->InterpolationMethod;}
            set {ParticleModuleRequired_ptr->InterpolationMethod = value;}
        }
        ///<summary>The number of sub-images horizontally in the texture</summary>
        public unsafe int SubImages_Horizontal {
            get {return ParticleModuleRequired_ptr->SubImages_Horizontal;}
            set {ParticleModuleRequired_ptr->SubImages_Horizontal = value;}
        }
        ///<summary>The number of sub-images vertically in the texture</summary>
        public unsafe int SubImages_Vertical {
            get {return ParticleModuleRequired_ptr->SubImages_Vertical;}
            set {ParticleModuleRequired_ptr->SubImages_Vertical = value;}
        }
        public bool bScaleUV {
            get {return Main.GetGetBoolPropertyByName(this, "bScaleUV"); }
            set {Main.SetGetBoolPropertyByName(this, "bScaleUV", value); }
        }
        ///<summary>The amount of time (particle-relative, 0.</summary>
        ///<remarks>
        ///0 to 1.0) to 'lock' on a random sub image
        ///    0.0 = change every frame
        ///1.0 = select a random image at spawn and hold for the life of the particle
        ///</remarks>
        public unsafe float RandomImageTime {
            get {return ParticleModuleRequired_ptr->RandomImageTime;}
            set {ParticleModuleRequired_ptr->RandomImageTime = value;}
        }
        ///<summary>The number of times to change a random image over the life of the particle.</summary>
        public unsafe int RandomImageChanges {
            get {return ParticleModuleRequired_ptr->RandomImageChanges;}
            set {ParticleModuleRequired_ptr->RandomImageChanges = value;}
        }
        public bool bOverrideSystemMacroUV {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideSystemMacroUV"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideSystemMacroUV", value); }
        }
        ///<summary>Local space position that UVs generated with the ParticleMacroUV material node will be centered on.</summary>
        public unsafe Vector MacroUVPosition {
            get {return ParticleModuleRequired_ptr->MacroUVPosition;}
            set {ParticleModuleRequired_ptr->MacroUVPosition = value;}
        }
        ///<summary>World space radius that UVs generated with the ParticleMacroUV material node will tile based on.</summary>
        public unsafe float MacroUVRadius {
            get {return ParticleModuleRequired_ptr->MacroUVRadius;}
            set {ParticleModuleRequired_ptr->MacroUVRadius = value;}
        }
        public bool bUseMaxDrawCount {
            get {return Main.GetGetBoolPropertyByName(this, "bUseMaxDrawCount"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseMaxDrawCount", value); }
        }
        ///<summary>The maximum number of particles to DRAW for this emitter.</summary>
        ///<remarks>If set to 0, it will use whatever number are present.</remarks>
        public unsafe int MaxDrawCount {
            get {return ParticleModuleRequired_ptr->MaxDrawCount;}
            set {ParticleModuleRequired_ptr->MaxDrawCount = value;}
        }
         //TODO: enum EParticleUVFlipMode UVFlippingMode
        ///<summary>Texture to generate bounding geometry from.</summary>
        public unsafe Texture2D CutoutTexture {
            get {return ParticleModuleRequired_ptr->CutoutTexture;}
            set {ParticleModuleRequired_ptr->CutoutTexture = value;}
        }
        ///<summary>More bounding vertices results in reduced overdraw, but adds more triangle overhead.</summary>
        ///<remarks>
        ///The eight vertex mode is best used when the SubUV texture has a lot of space to cut out that is not captured by the four vertex version,
        ///and when the particles using the texture will be few and large.
        ///</remarks>
        public unsafe byte BoundingMode {
            get {return ParticleModuleRequired_ptr->BoundingMode;}
            set {ParticleModuleRequired_ptr->BoundingMode = value;}
        }
        ///<summary>Opacity Source Mode</summary>
        public unsafe byte OpacitySourceMode {
            get {return ParticleModuleRequired_ptr->OpacitySourceMode;}
            set {ParticleModuleRequired_ptr->OpacitySourceMode = value;}
        }
        ///<summary>Alpha channel values larger than the threshold are considered occupied and will be contained in the bounding geometry.</summary>
        ///<remarks>Raising this threshold slightly can reduce overdraw in particles using this animation asset.</remarks>
        public unsafe float AlphaThreshold {
            get {return ParticleModuleRequired_ptr->AlphaThreshold;}
            set {ParticleModuleRequired_ptr->AlphaThreshold = value;}
        }
        ///<summary>Normal generation mode for this emitter LOD.</summary>
        public unsafe byte EmitterNormalsMode {
            get {return ParticleModuleRequired_ptr->EmitterNormalsMode;}
            set {ParticleModuleRequired_ptr->EmitterNormalsMode = value;}
        }
        ///<summary>When EmitterNormalsMode is ENM_Spherical, particle normals are created to face away from NormalsSphereCenter.</summary>
        ///<remarks>NormalsSphereCenter is in local space.</remarks>
        public unsafe Vector NormalsSphereCenter {
            get {return ParticleModuleRequired_ptr->NormalsSphereCenter;}
            set {ParticleModuleRequired_ptr->NormalsSphereCenter = value;}
        }
        ///<summary>
        ///When EmitterNormalsMode is ENM_Cylindrical,
        ///particle normals are created to face away from the cylinder going through NormalsSphereCenter in the direction NormalsCylinderDirection.
        ///</summary>
        ///<remarks>NormalsCylinderDirection is in local space.</remarks>
        public unsafe Vector NormalsCylinderDirection {
            get {return ParticleModuleRequired_ptr->NormalsCylinderDirection;}
            set {ParticleModuleRequired_ptr->NormalsCylinderDirection = value;}
        }
        public bool bOrbitModuleAffectsVelocityAlignment {
            get {return Main.GetGetBoolPropertyByName(this, "bOrbitModuleAffectsVelocityAlignment"); }
            set {Main.SetGetBoolPropertyByName(this, "bOrbitModuleAffectsVelocityAlignment", value); }
        }
         //TODO: array not UObject TArray NamedMaterialOverrides
        static ParticleModuleRequired() {
            StaticClass = Main.GetClass("ParticleModuleRequired");
        }
        internal unsafe ParticleModuleRequired_fields* ParticleModuleRequired_ptr => (ParticleModuleRequired_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleRequired(IntPtr p) => UObject.Make<ParticleModuleRequired>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleRequired DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleRequired New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

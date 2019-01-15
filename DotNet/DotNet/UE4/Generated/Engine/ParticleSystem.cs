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
    ///<summary>A ParticleSystem is a complete particle effect that contains any number of ParticleEmitters.</summary>
    ///<remarks>
    ///By allowing multiple emitters
    ///in a system, the designer can create elaborate particle effects that are held in a single system. Once created using
    ///Cascade, a ParticleSystem can then be inserted into a level or created in script.
    ///</remarks>
    public unsafe partial class ParticleSystem : UObject  {

        ///<summary>Returns true if this system contains an emitter of the pasesd type.</summary>
        ///<remarks>
        ///@ param TypeData - The emitter type to check for. Must be a child class of UParticleModuleTypeDataBase
        ///</remarks>
        public bool ContainsEmitterType(SubclassOf<UObject> TypeData)  => 
            ParticleSystem_methods.ContainsEmitterType_method.Invoke(ObjPointer, TypeData);
        ///<summary>System Update Mode</summary>
        public unsafe byte SystemUpdateMode {
            get {return ParticleSystem_ptr->SystemUpdateMode;}
            set {ParticleSystem_ptr->SystemUpdateMode = value;}
        }
        ///<summary>UpdateTime_FPS - the frame per second to update at in FixedTime mode</summary>
        public unsafe float UpdateTime_FPS {
            get {return ParticleSystem_ptr->UpdateTime_FPS;}
            set {ParticleSystem_ptr->UpdateTime_FPS = value;}
        }
        ///<summary>UpdateTime_Delta       - internal</summary>
        public unsafe float UpdateTime_Delta {
            get {return ParticleSystem_ptr->UpdateTime_Delta;}
            set {ParticleSystem_ptr->UpdateTime_Delta = value;}
        }
        ///<summary>
        ///WarmupTime - the time to warm-up the particle system when first rendered
        ///Warning: WarmupTime is implemented by simulating the particle system for the time requested upon activation.
        ///</summary>
        ///<remarks>This is extremely prone to cause hitches, especially with large particle counts - use with caution.</remarks>
        public unsafe float WarmupTime {
            get {return ParticleSystem_ptr->WarmupTime;}
            set {ParticleSystem_ptr->WarmupTime = value;}
        }
        ///<summary>WarmupTickRate - the time step for each tick during warm up.</summary>
        ///<remarks>
        ///Increasing this improves performance. Decreasing, improves accuracy.
        ///       Set to 0 to use the default tick time.
        ///</remarks>
        public unsafe float WarmupTickRate {
            get {return ParticleSystem_ptr->WarmupTickRate;}
            set {ParticleSystem_ptr->WarmupTickRate = value;}
        }
        ///<summary>Emitters       - internal - the array of emitters in the system</summary>
        public ObjectArrayField<ParticleEmitter> Emitters{ get {
            if(Emitters_store == null) Emitters_store = new ObjectArrayField<ParticleEmitter> (&ParticleSystem_ptr->Emitters);
            return Emitters_store;
        } }
        private ObjectArrayField<ParticleEmitter> Emitters_store;

        ///<summary>The component used to preview the particle system in Cascade</summary>
        public unsafe ParticleSystemComponent PreviewComponent {
            get {return ParticleSystem_ptr->PreviewComponent;}
            set {ParticleSystem_ptr->PreviewComponent = value;}
        }
        ///<summary>The angle to use when rendering the thumbnail image</summary>
        public unsafe Rotator ThumbnailAngle {
            get {return ParticleSystem_ptr->ThumbnailAngle;}
            set {ParticleSystem_ptr->ThumbnailAngle = value;}
        }
        ///<summary>The distance to place the system when rendering the thumbnail image</summary>
        public unsafe float ThumbnailDistance {
            get {return ParticleSystem_ptr->ThumbnailDistance;}
            set {ParticleSystem_ptr->ThumbnailDistance = value;}
        }
        ///<summary>The time to warm-up the system for the thumbnail image</summary>
        public unsafe float ThumbnailWarmup {
            get {return ParticleSystem_ptr->ThumbnailWarmup;}
            set {ParticleSystem_ptr->ThumbnailWarmup = value;}
        }
        ///<summary>Used for curve editor to remember curve-editing setup.</summary>
        public unsafe InterpCurveEdSetup CurveEdSetup {
            get {return ParticleSystem_ptr->CurveEdSetup;}
            set {ParticleSystem_ptr->CurveEdSetup = value;}
        }
        public bool bOrientZAxisTowardCamera {
            get {return Main.GetGetBoolPropertyByName(this, "bOrientZAxisTowardCamera"); }
            set {Main.SetGetBoolPropertyByName(this, "bOrientZAxisTowardCamera", value); }
        }
        ///<summary>How often (in seconds) the system should perform the LOD distance check.</summary>
        public unsafe float LODDistanceCheckTime {
            get {return ParticleSystem_ptr->LODDistanceCheckTime;}
            set {ParticleSystem_ptr->LODDistanceCheckTime = value;}
        }
        ///<summary>
        ///The method of LOD level determination to utilize for this particle system
        ///  PARTICLESYSTEMLODMETHOD_Automatic - Automatically set the LOD level, checking every LODDistanceCheckTime seconds.
        ///</summary>
        ///<remarks>
        ///PARTICLESYSTEMLODMETHOD_DirectSet - LOD level is directly set by the game code.
        ///PARTICLESYSTEMLODMETHOD_ActivateAutomatic - LOD level is determined at Activation time, then left alone unless directly set by game code.
        ///</remarks>
        public unsafe byte LODMethod {
            get {return ParticleSystem_ptr->LODMethod;}
            set {ParticleSystem_ptr->LODMethod = value;}
        }
         //TODO: array not UObject TArray LODDistances
        ///<summary>LOD setting for intepolation (set by Cascade) Range [0..100]</summary>
        public unsafe int EditorLODSetting {
            get {return ParticleSystem_ptr->EditorLODSetting;}
            set {ParticleSystem_ptr->EditorLODSetting = value;}
        }
        public bool bRegenerateLODDuplicate {
            get {return Main.GetGetBoolPropertyByName(this, "bRegenerateLODDuplicate"); }
            set {Main.SetGetBoolPropertyByName(this, "bRegenerateLODDuplicate", value); }
        }
         //TODO: array not UObject TArray LODSettings
        public bool bUseFixedRelativeBoundingBox {
            get {return Main.GetGetBoolPropertyByName(this, "bUseFixedRelativeBoundingBox"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseFixedRelativeBoundingBox", value); }
        }
        ///<summary>Fixed relative bounding box for particle system.</summary>
        public unsafe Box FixedRelativeBoundingBox {
            get {return ParticleSystem_ptr->FixedRelativeBoundingBox;}
            set {ParticleSystem_ptr->FixedRelativeBoundingBox = value;}
        }
        ///<summary>
        ///Number of seconds of emitter not being rendered that need to pass before it
        ///no longer gets ticked/ becomes inactive.
        ///</summary>
        public unsafe float SecondsBeforeInactive {
            get {return ParticleSystem_ptr->SecondsBeforeInactive;}
            set {ParticleSystem_ptr->SecondsBeforeInactive = value;}
        }
         //TODO: string FString FloorMesh
        ///<summary>Floor Position</summary>
        public unsafe Vector FloorPosition {
            get {return ParticleSystem_ptr->FloorPosition;}
            set {ParticleSystem_ptr->FloorPosition = value;}
        }
        ///<summary>Floor Rotation</summary>
        public unsafe Rotator FloorRotation {
            get {return ParticleSystem_ptr->FloorRotation;}
            set {ParticleSystem_ptr->FloorRotation = value;}
        }
        ///<summary>Floor Scale</summary>
        public unsafe float FloorScale {
            get {return ParticleSystem_ptr->FloorScale;}
            set {ParticleSystem_ptr->FloorScale = value;}
        }
        ///<summary>Floor Scale 3D</summary>
        public unsafe Vector FloorScale3D {
            get {return ParticleSystem_ptr->FloorScale3D;}
            set {ParticleSystem_ptr->FloorScale3D = value;}
        }
        ///<summary>The background color to display in Cascade</summary>
        public unsafe Color BackgroundColor {
            get {return ParticleSystem_ptr->BackgroundColor;}
            set {ParticleSystem_ptr->BackgroundColor = value;}
        }
        public bool bShouldResetPeakCounts {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldResetPeakCounts"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldResetPeakCounts", value); }
        }
        public bool bHasPhysics {
            get {return Main.GetGetBoolPropertyByName(this, "bHasPhysics"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasPhysics", value); }
        }
        public bool bUseRealtimeThumbnail {
            get {return Main.GetGetBoolPropertyByName(this, "bUseRealtimeThumbnail"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseRealtimeThumbnail", value); }
        }
        public bool ThumbnailImageOutOfDate {
            get {return Main.GetGetBoolPropertyByName(this, "ThumbnailImageOutOfDate"); }
            set {Main.SetGetBoolPropertyByName(this, "ThumbnailImageOutOfDate", value); }
        }
        ///<summary>Internal: The PSys thumbnail image</summary>
        public unsafe Texture2D ThumbnailImage {
            get {return ParticleSystem_ptr->ThumbnailImage;}
            set {ParticleSystem_ptr->ThumbnailImage = value;}
        }
        ///<summary>How long this Particle system should delay when ActivateSystem is called on it.</summary>
        public unsafe float Delay {
            get {return ParticleSystem_ptr->Delay;}
            set {ParticleSystem_ptr->Delay = value;}
        }
        ///<summary>The low end of the emitter delay if using a range.</summary>
        public unsafe float DelayLow {
            get {return ParticleSystem_ptr->DelayLow;}
            set {ParticleSystem_ptr->DelayLow = value;}
        }
        public bool bUseDelayRange {
            get {return Main.GetGetBoolPropertyByName(this, "bUseDelayRange"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseDelayRange", value); }
        }
        public bool bAutoDeactivate {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoDeactivate"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoDeactivate", value); }
        }
         //TODO: numeric uint32 MinTimeBetweenTicks
         //TODO: enum EParticleSystemInsignificanceReaction InsignificantReaction
        ///<summary>Time delay between all emitters becoming insignificant and the systems insignificant reaction.</summary>
        public unsafe float InsignificanceDelay {
            get {return ParticleSystem_ptr->InsignificanceDelay;}
            set {ParticleSystem_ptr->InsignificanceDelay = value;}
        }
         //TODO: enum EParticleSignificanceLevel MaxSignificanceLevel
         //TODO: numeric uint32 MaxPoolSize
        ///<summary>Local space position that UVs generated with the ParticleMacroUV material node will be centered on.</summary>
        public unsafe Vector MacroUVPosition {
            get {return ParticleSystem_ptr->MacroUVPosition;}
            set {ParticleSystem_ptr->MacroUVPosition = value;}
        }
        ///<summary>World space radius that UVs generated with the ParticleMacroUV material node will tile based on.</summary>
        public unsafe float MacroUVRadius {
            get {return ParticleSystem_ptr->MacroUVRadius;}
            set {ParticleSystem_ptr->MacroUVRadius = value;}
        }
        ///<summary>Which occlusion bounds method to use for this particle system.</summary>
        ///<remarks>
        ///EPSOBM_None - Don't determine occlusion for this system.
        ///EPSOBM_ParticleBounds - Use the bounds of the component when determining occlusion.
        ///</remarks>
        public unsafe byte OcclusionBoundsMethod {
            get {return ParticleSystem_ptr->OcclusionBoundsMethod;}
            set {ParticleSystem_ptr->OcclusionBoundsMethod = value;}
        }
        ///<summary>The occlusion bounds to use if OcclusionBoundsMethod is set to EPSOBM_CustomBounds</summary>
        public unsafe Box CustomOcclusionBounds {
            get {return ParticleSystem_ptr->CustomOcclusionBounds;}
            set {ParticleSystem_ptr->CustomOcclusionBounds = value;}
        }
         //TODO: array not UObject TArray SoloTracking
         //TODO: array not UObject TArray NamedMaterialSlots
        static ParticleSystem() {
            StaticClass = Main.GetClass("ParticleSystem");
        }
        internal unsafe ParticleSystem_fields* ParticleSystem_ptr => (ParticleSystem_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleSystem(IntPtr p) => UObject.Make<ParticleSystem>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleSystem DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleSystem New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

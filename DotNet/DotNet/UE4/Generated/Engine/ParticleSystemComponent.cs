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
    ///<summary>A particle emitter.</summary>
    public unsafe partial class ParticleSystemComponent : PrimitiveComponent  {

        ///<summary>Begins all trail emitters in this component.</summary>
        ///<remarks>
        ///@param        InFirstSocketName       The name of the first socket for the trail.
        ///@param        InSecondSocketName      The name of the second socket for the trail.
        ///@param        InWidthMode                     How the width value is applied to the trail.
        ///@param        InWidth                         The width of the trail.
        ///</remarks>
        public void BeginTrails(Name InFirstSocketName, Name InSecondSocketName, byte InWidthMode, float InWidth)  => 
            ParticleSystemComponent_methods.BeginTrails_method.Invoke(ObjPointer, InFirstSocketName, InSecondSocketName, InWidthMode, InWidth);

        ///<summary>Creates a Dynamic Material Instance for the specified named material override, optionally from the supplied material.</summary>
        ///<remarks>
        ///@param Name - The slot name of the material to replace.  If invalid, the material is unchanged and NULL is returned.
        ///</remarks>
        public MaterialInstanceDynamic CreateNamedDynamicMaterialInstance(Name InName, MaterialInterface SourceMaterial)  => 
            ParticleSystemComponent_methods.CreateNamedDynamicMaterialInstance_method.Invoke(ObjPointer, InName, SourceMaterial);

        ///<summary>Ends all trail emitters in this component.</summary>
        public void EndTrails()  => 
            ParticleSystemComponent_methods.EndTrails_method.Invoke(ObjPointer);

        ///<summary>Record a kismet event.</summary>
        ///<remarks>
        ///@param  InEventName                             The name of the event that fired.
        ///@param  InEmitterTime                   The emitter time when the event fired.
        ///@param  InLocation                              The location of the particle when the event fired.
        ///@param  InVelocity                              The velocity of the particle when the event fired.
        ///@param  InNormal                                Normal vector of the collision in coordinate system of the returner. Zero=none.
        ///</remarks>
        public void GenerateParticleEvent(Name InEventName, float InEmitterTime, Vector InLocation, Vector InDirection, Vector InVelocity)  => 
            ParticleSystemComponent_methods.GenerateParticleEvent_method.Invoke(ObjPointer, InEventName, InEmitterTime, InLocation, InDirection, InVelocity);

        ///<summary>
        ///Get the beam end point
        ///@
        ///</summary>
        ///<remarks>
        ///param  EmitterIndex            The index of the emitter to get the value of
        ///
        ///@return true            EmitterIndex is valid and End point is set - OutEndPoint is valid
        ///                false           EmitterIndex invalid or End point is not set - OutEndPoint is invalid
        ///</remarks>
        public (Vector, bool) GetBeamEndPoint(int EmitterIndex)  => 
            ParticleSystemComponent_methods.GetBeamEndPoint_method.Invoke(ObjPointer, EmitterIndex);

        ///<summary>
        ///Get the beam source point
        ///@
        ///</summary>
        ///<remarks>
        ///param  EmitterIndex            The index of the emitter to get
        ///@param  SourceIndex                     Which beam within the emitter to get
        ///@param  OutSourcePoint          Value of source point
        ///
        ///@return true            EmitterIndex and SourceIndex are valid - OutSourcePoint is valid
        ///                false           EmitterIndex or SourceIndex is invalid - OutSourcePoint is invalid
        ///</remarks>
        public (Vector, bool) GetBeamSourcePoint(int EmitterIndex, int SourceIndex)  => 
            ParticleSystemComponent_methods.GetBeamSourcePoint_method.Invoke(ObjPointer, EmitterIndex, SourceIndex);

        ///<summary>
        ///Get the beam source strength
        ///@
        ///</summary>
        ///<remarks>
        ///param  EmitterIndex            The index of the emitter to get
        ///@param  SourceIndex                     Which beam within the emitter to get
        ///@param  OutSourceStrength               Value of source tangent
        ///
        ///@return true            EmitterIndex and SourceIndex are valid - OutSourceStrength is valid
        ///                false           EmitterIndex or SourceIndex is invalid - OutSourceStrength is invalid
        ///</remarks>
        public (float, bool) GetBeamSourceStrength(int EmitterIndex, int SourceIndex)  => 
            ParticleSystemComponent_methods.GetBeamSourceStrength_method.Invoke(ObjPointer, EmitterIndex, SourceIndex);

        ///<summary>
        ///Get the beam source tangent
        ///@
        ///</summary>
        ///<remarks>
        ///param  EmitterIndex            The index of the emitter to get
        ///@param  SourceIndex                     Which beam within the emitter to get
        ///@param  OutTangentPoint         Value of source tangent
        ///
        ///@return true            EmitterIndex and SourceIndex are valid - OutTangentPoint is valid
        ///                false           EmitterIndex or SourceIndex is invalid - OutTangentPoint is invalid
        ///</remarks>
        public (Vector, bool) GetBeamSourceTangent(int EmitterIndex, int SourceIndex)  => 
            ParticleSystemComponent_methods.GetBeamSourceTangent_method.Invoke(ObjPointer, EmitterIndex, SourceIndex);

        ///<summary>
        ///Get the beam target point
        ///@
        ///</summary>
        ///<remarks>
        ///param  EmitterIndex            The index of the emitter to get
        ///@param  TargetIndex                     Which beam within the emitter to get
        ///@param  OutTargetPoint          Value of target point
        ///
        ///@return true            EmitterIndex and TargetIndex are valid - OutTargetPoint is valid
        ///                false           EmitterIndex or TargetIndex is invalid - OutTargetPoint is invalid
        ///</remarks>
        public (Vector, bool) GetBeamTargetPoint(int EmitterIndex, int TargetIndex)  => 
            ParticleSystemComponent_methods.GetBeamTargetPoint_method.Invoke(ObjPointer, EmitterIndex, TargetIndex);

        ///<summary>
        ///Get the beam target strength
        ///@
        ///</summary>
        ///<remarks>
        ///param  EmitterIndex            The index of the emitter to get
        ///@param  TargetIndex                     Which beam within the emitter to get
        ///@param  OutTargetStrength       Value of target tangent
        ///
        ///@return true            EmitterIndex and TargetIndex are valid - OutTargetStrength is valid
        ///                false           EmitterIndex or TargetIndex is invalid - OutTargetStrength is invalid
        ///</remarks>
        public (float, bool) GetBeamTargetStrength(int EmitterIndex, int TargetIndex)  => 
            ParticleSystemComponent_methods.GetBeamTargetStrength_method.Invoke(ObjPointer, EmitterIndex, TargetIndex);

        ///<summary>
        ///Get the beam target tangent
        ///@
        ///</summary>
        ///<remarks>
        ///param  EmitterIndex            The index of the emitter to get
        ///@param  TargetIndex                     Which beam within the emitter to get
        ///@param  OutTangentPoint         Value of target tangent
        ///
        ///@return true            EmitterIndex and TargetIndex are valid - OutTangentPoint is valid
        ///                false           EmitterIndex or TargetIndex is invalid - OutTangentPoint is invalid
        ///</remarks>
        public (Vector, bool) GetBeamTargetTangent(int EmitterIndex, int TargetIndex)  => 
            ParticleSystemComponent_methods.GetBeamTargetTangent_method.Invoke(ObjPointer, EmitterIndex, TargetIndex);

        ///<summary>Returns a named material. If this named material is not found, returns NULL.</summary>
        public MaterialInterface GetNamedMaterial(Name InName)  => 
            ParticleSystemComponent_methods.GetNamedMaterial_method.Invoke(ObjPointer, InName);

        ///<summary>Get the current number of active particles in this system</summary>
        public int GetNumActiveParticles()  => 
            ParticleSystemComponent_methods.GetNumActiveParticles_method.Invoke(ObjPointer);

        ///<summary>Deactivates this system and releases it to the pool on completion.</summary>
        ///<remarks>
        ///Usage of this PSC reference after this call is unsafe.
        ///You should clear out your references to it.
        ///</remarks>
        public void ReleaseToPool()  => 
            ParticleSystemComponent_methods.ReleaseToPool_method.Invoke(ObjPointer);

        ///<summary>Set a named actor instance parameter on this ParticleSystemComponent.</summary>
        ///<remarks>Updates the parameter if it already exists, or creates a new entry if not.</remarks>
        public void SetActorParameter(Name ParameterName, Actor Param)  => 
            ParticleSystemComponent_methods.SetActorParameter_method.Invoke(ObjPointer, ParameterName, Param);

        ///<summary>Set AutoAttachParent, AutoAttachSocketName, AutoAttachLocationRule, AutoAttachRotationRule, AutoAttachScaleRule to the specified parameters.</summary>
        ///<remarks>
        ///Does not change bAutoManageAttachment; that must be set separately.
        ///@param  Parent                       Component to attach to.
        ///@param  SocketName           Socket on Parent to attach to.
        ///@param  LocationRule         Option for how we handle our location when we attach to Parent.
        ///@param  RotationRule         Option for how we handle our rotation when we attach to Parent.
        ///@param  ScaleRule            Option for how we handle our scale when we attach to Parent.
        ///@see bAutoManageAttachment, AutoAttachParent, AutoAttachSocketName, AutoAttachLocationRule, AutoAttachRotationRule, AutoAttachScaleRule
        ///</remarks>
        public void SetAutoAttachmentParameters(SceneComponent Parent, Name SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule)  => 
            ParticleSystemComponent_methods.SetAutoAttachmentParameters_method.Invoke(ObjPointer, Parent, SocketName, LocationRule, RotationRule, ScaleRule);

        ///<summary>DEPRECATED: Set AutoAttachParent, AutoAttachSocketName, AutoAttachLocationType to the specified parameters.</summary>
        ///<remarks>
        ///Does not change bAutoManageAttachment; that must be set separately.
        ///@param  Parent                       Component to attach to.
        ///@param  SocketName           Socket on Parent to attach to.
        ///@param  LocationType         Option for how we handle our location when we attach to Parent.
        ///@see bAutoManageAttachment, AutoAttachParent, AutoAttachSocketName, AutoAttachLocationType
        ///</remarks>
        public void SetAutoAttachParams(SceneComponent Parent, Name SocketName, byte LocationType)  => 
            ParticleSystemComponent_methods.SetAutoAttachParams_method.Invoke(ObjPointer, Parent, SocketName, LocationType);

        ///<summary>
        ///Set the beam end point
        ///@
        ///</summary>
        ///<remarks>
        ///param  EmitterIndex            The index of the emitter to set it on
        ///@param  NewEndPoint                     The value to set it to
        ///</remarks>
        public void SetBeamEndPoint(int EmitterIndex, Vector NewEndPoint)  => 
            ParticleSystemComponent_methods.SetBeamEndPoint_method.Invoke(ObjPointer, EmitterIndex, NewEndPoint);

        ///<summary>
        ///Set the beam source point
        ///@
        ///</summary>
        ///<remarks>
        ///param  EmitterIndex            The index of the emitter to set it on
        ///@param  NewSourcePoint          The value to set it to
        ///@param  SourceIndex                     Which beam within the emitter to set it on
        ///</remarks>
        public void SetBeamSourcePoint(int EmitterIndex, Vector NewSourcePoint, int SourceIndex)  => 
            ParticleSystemComponent_methods.SetBeamSourcePoint_method.Invoke(ObjPointer, EmitterIndex, NewSourcePoint, SourceIndex);

        ///<summary>
        ///Set the beam source strength
        ///@
        ///</summary>
        ///<remarks>
        ///param  EmitterIndex            The index of the emitter to set it on
        ///@param  NewSourceStrength       The value to set it to
        ///@param  SourceIndex                     Which beam within the emitter to set it on
        ///</remarks>
        public void SetBeamSourceStrength(int EmitterIndex, float NewSourceStrength, int SourceIndex)  => 
            ParticleSystemComponent_methods.SetBeamSourceStrength_method.Invoke(ObjPointer, EmitterIndex, NewSourceStrength, SourceIndex);

        ///<summary>
        ///Set the beam source tangent
        ///@
        ///</summary>
        ///<remarks>
        ///param  EmitterIndex            The index of the emitter to set it on
        ///@param  NewTangentPoint         The value to set it to
        ///@param  SourceIndex                     Which beam within the emitter to set it on
        ///</remarks>
        public void SetBeamSourceTangent(int EmitterIndex, Vector NewTangentPoint, int SourceIndex)  => 
            ParticleSystemComponent_methods.SetBeamSourceTangent_method.Invoke(ObjPointer, EmitterIndex, NewTangentPoint, SourceIndex);

        ///<summary>
        ///Set the beam target point
        ///@
        ///</summary>
        ///<remarks>
        ///param  EmitterIndex            The index of the emitter to set it on
        ///@param  NewTargetPoint          The value to set it to
        ///@param  TargetIndex                     Which beam within the emitter to set it on
        ///</remarks>
        public void SetBeamTargetPoint(int EmitterIndex, Vector NewTargetPoint, int TargetIndex)  => 
            ParticleSystemComponent_methods.SetBeamTargetPoint_method.Invoke(ObjPointer, EmitterIndex, NewTargetPoint, TargetIndex);

        ///<summary>
        ///Set the beam target strength
        ///@
        ///</summary>
        ///<remarks>
        ///param  EmitterIndex            The index of the emitter to set it on
        ///@param  NewTargetStrength       The value to set it to
        ///@param  TargetIndex                     Which beam within the emitter to set it on
        ///</remarks>
        public void SetBeamTargetStrength(int EmitterIndex, float NewTargetStrength, int TargetIndex)  => 
            ParticleSystemComponent_methods.SetBeamTargetStrength_method.Invoke(ObjPointer, EmitterIndex, NewTargetStrength, TargetIndex);

        ///<summary>
        ///Set the beam target tangent
        ///@
        ///</summary>
        ///<remarks>
        ///param  EmitterIndex            The index of the emitter to set it on
        ///@param  NewTangentPoint         The value to set it to
        ///@param  TargetIndex                     Which beam within the emitter to set it on
        ///</remarks>
        public void SetBeamTargetTangent(int EmitterIndex, Vector NewTangentPoint, int TargetIndex)  => 
            ParticleSystemComponent_methods.SetBeamTargetTangent_method.Invoke(ObjPointer, EmitterIndex, NewTangentPoint, TargetIndex);

        ///<summary>Set a named color instance parameter on this ParticleSystemComponent.</summary>
        ///<remarks>Updates the parameter if it already exists, or creates a new entry if not.</remarks>
        public void SetColorParameter(Name ParameterName, LinearColor Param)  => 
            ParticleSystemComponent_methods.SetColorParameter_method.Invoke(ObjPointer, ParameterName, Param);

        ///<summary>
        ///Enables/Disables a sub-emitter
        ///@
        ///</summary>
        ///<remarks>
        ///param  EmitterName                     The name of the sub-emitter to set it on
        ///@param  bNewEnableState         The value to set it to
        ///</remarks>
        public void SetEmitterEnable(Name EmitterName, bool bNewEnableState)  => 
            ParticleSystemComponent_methods.SetEmitterEnable_method.Invoke(ObjPointer, EmitterName, bNewEnableState);

        ///<summary>Change a named float parameter</summary>
        public void SetFloatParameter(Name ParameterName, float Param)  => 
            ParticleSystemComponent_methods.SetFloatParameter_method.Invoke(ObjPointer, ParameterName, Param);

        ///<summary>Set a named material instance parameter on this ParticleSystemComponent.</summary>
        ///<remarks>Updates the parameter if it already exists, or creates a new entry if not.</remarks>
        public void SetMaterialParameter(Name ParameterName, MaterialInterface Param)  => 
            ParticleSystemComponent_methods.SetMaterialParameter_method.Invoke(ObjPointer, ParameterName, Param);

        ///<summary>Change the ParticleSystem used by this ParticleSystemComponent</summary>
        public void SetTemplate(ParticleSystem NewTemplate)  => 
            ParticleSystemComponent_methods.SetTemplate_method.Invoke(ObjPointer, NewTemplate);

        ///<summary>Sets the defining data for all trails in this component.</summary>
        ///<remarks>
        ///@param        InFirstSocketName       The name of the first socket for the trail.
        ///@param        InSecondSocketName      The name of the second socket for the trail.
        ///@param        InWidthMode                     How the width value is applied to the trail.
        ///@param        InWidth                         The width of the trail.
        ///</remarks>
        public void SetTrailSourceData(Name InFirstSocketName, Name InSecondSocketName, byte InWidthMode, float InWidth)  => 
            ParticleSystemComponent_methods.SetTrailSourceData_method.Invoke(ObjPointer, InFirstSocketName, InSecondSocketName, InWidthMode, InWidth);

        ///<summary>Set a named vector instance parameter on this ParticleSystemComponent.</summary>
        ///<remarks>Updates the parameter if it already exists, or creates a new entry if not.</remarks>
        public void SetVectorParameter(Name ParameterName, Vector Param)  => 
            ParticleSystemComponent_methods.SetVectorParameter_method.Invoke(ObjPointer, ParameterName, Param);
        ///<summary>Template</summary>
        public unsafe ParticleSystem Template {
            get {return ParticleSystemComponent_ptr->Template;}
        }
        ///<summary>Emitter Materials</summary>
        public ObjectArrayField<MaterialInterface> EmitterMaterials{ get {
            if(EmitterMaterials_store == null) EmitterMaterials_store = new ObjectArrayField<MaterialInterface> (&ParticleSystemComponent_ptr->EmitterMaterials);
            return EmitterMaterials_store;
        } }
        private ObjectArrayField<MaterialInterface> EmitterMaterials_store;

        ///<summary>The skeletal mesh components used with the socket location module.</summary>
        ///<remarks>This is to prevent them from being garbage collected.</remarks>
        public ObjectArrayField<SkeletalMeshComponent> SkelMeshComponents{ get {
            if(SkelMeshComponents_store == null) SkelMeshComponents_store = new ObjectArrayField<SkeletalMeshComponent> (&ParticleSystemComponent_ptr->SkelMeshComponents);
            return SkelMeshComponents_store;
        } }
        private ObjectArrayField<SkeletalMeshComponent> SkelMeshComponents_store;

        public bool bResetOnDetach {
            get {return Main.GetGetBoolPropertyByName(this, "bResetOnDetach"); }
            set {Main.SetGetBoolPropertyByName(this, "bResetOnDetach", value); }
        }
        public bool bUpdateOnDedicatedServer {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdateOnDedicatedServer"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdateOnDedicatedServer", value); }
        }
        public bool bAllowRecycling {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowRecycling"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowRecycling", value); }
        }
        public bool bAutoManageAttachment {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoManageAttachment"); }
        }
        public bool bWarmingUp {
            get {return Main.GetGetBoolPropertyByName(this, "bWarmingUp"); }
            set {Main.SetGetBoolPropertyByName(this, "bWarmingUp", value); }
        }
        public bool bOverrideLODMethod {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideLODMethod"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideLODMethod", value); }
        }
        public bool bSkipUpdateDynamicDataDuringTick {
            get {return Main.GetGetBoolPropertyByName(this, "bSkipUpdateDynamicDataDuringTick"); }
            set {Main.SetGetBoolPropertyByName(this, "bSkipUpdateDynamicDataDuringTick", value); }
        }
        ///<summary>The method of LOD level determination to utilize for this particle system</summary>
        public unsafe byte LODMethod {
            get {return ParticleSystemComponent_ptr->LODMethod;}
            set {ParticleSystemComponent_ptr->LODMethod = value;}
        }
         //TODO: enum EParticleSignificanceLevel RequiredSignificance
         //TODO: array not UObject TArray InstanceParameters
         //TODO: multicast delegate FParticleSpawnSignature OnParticleSpawn
         //TODO: multicast delegate FParticleBurstSignature OnParticleBurst
         //TODO: multicast delegate FParticleDeathSignature OnParticleDeath
         //TODO: multicast delegate FParticleCollisionSignature OnParticleCollide
        ///<summary>Old Position</summary>
        public unsafe Vector OldPosition {
            get {return ParticleSystemComponent_ptr->OldPosition;}
            set {ParticleSystemComponent_ptr->OldPosition = value;}
        }
        ///<summary>Part Sys Velocity</summary>
        public unsafe Vector PartSysVelocity {
            get {return ParticleSystemComponent_ptr->PartSysVelocity;}
            set {ParticleSystemComponent_ptr->PartSysVelocity = value;}
        }
        ///<summary>Warmup Time</summary>
        public unsafe float WarmupTime {
            get {return ParticleSystemComponent_ptr->WarmupTime;}
            set {ParticleSystemComponent_ptr->WarmupTime = value;}
        }
        ///<summary>Warmup Tick Rate</summary>
        public unsafe float WarmupTickRate {
            get {return ParticleSystemComponent_ptr->WarmupTickRate;}
            set {ParticleSystemComponent_ptr->WarmupTickRate = value;}
        }
        ///<summary>
        ///Number of seconds of emitter not being rendered that need to pass before it
        ///no longer gets ticked/ becomes inactive.
        ///</summary>
        public unsafe float SecondsBeforeInactive {
            get {return ParticleSystemComponent_ptr->SecondsBeforeInactive;}
            set {ParticleSystemComponent_ptr->SecondsBeforeInactive = value;}
        }
        ///<summary>
        ///Time between forced UpdateTransforms for systems that use dynamically calculated bounds,
        ///Which is effectively how often the bounds are shrunk.
        ///</summary>
        public unsafe float MaxTimeBeforeForceUpdateTransform {
            get {return ParticleSystemComponent_ptr->MaxTimeBeforeForceUpdateTransform;}
            set {ParticleSystemComponent_ptr->MaxTimeBeforeForceUpdateTransform = value;}
        }
        ///<summary>INTERNAL. Used by the editor to set the LODLevel</summary>
        public unsafe int EditorLODLevel {
            get {return ParticleSystemComponent_ptr->EditorLODLevel;}
            set {ParticleSystemComponent_ptr->EditorLODLevel = value;}
        }
        ///<summary>Used for applying Cascade's detail mode setting to in-level particle systems</summary>
        public unsafe int EditorDetailMode {
            get {return ParticleSystemComponent_ptr->EditorDetailMode;}
            set {ParticleSystemComponent_ptr->EditorDetailMode = value;}
        }
        ///<summary>Array of replay clips for this particle system component.  These are serialized to disk.  You really should never add anything to this in the editor.  It's exposed so that you can delete clips if you need to, but be careful when doing so!</summary>
        public ObjectArrayField<ParticleSystemReplay> ReplayClips{ get {
            if(ReplayClips_store == null) ReplayClips_store = new ObjectArrayField<ParticleSystemReplay> (&ParticleSystemComponent_ptr->ReplayClips);
            return ReplayClips_store;
        } }
        private ObjectArrayField<ParticleSystemReplay> ReplayClips_store;

        ///<summary>Scales DeltaTime in UParticleSystemComponent::Tick(...)</summary>
        public unsafe float CustomTimeDilation {
            get {return ParticleSystemComponent_ptr->CustomTimeDilation;}
            set {ParticleSystemComponent_ptr->CustomTimeDilation = value;}
        }
         //TODO: weak object TWeakObjectPtr<USceneComponent> AutoAttachParent
        ///<summary>Socket we automatically attach to on the AutoAttachParent, if bAutoManageAttachment is true.</summary>
        ///<remarks>
        ///@see bAutoManageAttachment
        ///</remarks>
        public unsafe Name AutoAttachSocketName {
            get {return ParticleSystemComponent_ptr->AutoAttachSocketName;}
            set {ParticleSystemComponent_ptr->AutoAttachSocketName = value;}
        }
         //TODO: enum EAttachmentRule AutoAttachLocationRule
         //TODO: enum EAttachmentRule AutoAttachRotationRule
         //TODO: enum EAttachmentRule AutoAttachScaleRule
         //TODO: multicast delegate FOnSystemFinished OnSystemFinished
        static ParticleSystemComponent() {
            StaticClass = Main.GetClass("ParticleSystemComponent");
        }
        internal unsafe ParticleSystemComponent_fields* ParticleSystemComponent_ptr => (ParticleSystemComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleSystemComponent(IntPtr p) => UObject.Make<ParticleSystemComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleSystemComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleSystemComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

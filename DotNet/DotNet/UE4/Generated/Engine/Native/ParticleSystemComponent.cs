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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=2112 )]
    internal unsafe struct ParticleSystemComponent_fields {
        [FieldOffset(1504)]  public IntPtr  Template;
        [FieldOffset(1512)] public NativeArray EmitterMaterials;
        [FieldOffset(1528)] public NativeArray SkelMeshComponents;
        [FieldOffset(1544)] public bool bResetOnDetach;
        [FieldOffset(1545)] public bool bUpdateOnDedicatedServer;
        [FieldOffset(1545)] public bool bAllowRecycling;
        [FieldOffset(1545)] public bool bAutoManageAttachment;
        [FieldOffset(1545)] public bool bWarmingUp;
        [FieldOffset(1546)] public bool bOverrideLODMethod;
        [FieldOffset(1546)] public bool bSkipUpdateDynamicDataDuringTick;
        [FieldOffset(1549)] public byte LODMethod;
        [FieldOffset(1550)] byte RequiredSignificance; //TODO: enum EParticleSignificanceLevel RequiredSignificance
        [FieldOffset(1552)] public NativeArray InstanceParameters;
        [FieldOffset(1568)] byte OnParticleSpawn; //TODO: multicast delegate FParticleSpawnSignature OnParticleSpawn
        [FieldOffset(1584)] byte OnParticleBurst; //TODO: multicast delegate FParticleBurstSignature OnParticleBurst
        [FieldOffset(1600)] byte OnParticleDeath; //TODO: multicast delegate FParticleDeathSignature OnParticleDeath
        [FieldOffset(1616)] byte OnParticleCollide; //TODO: multicast delegate FParticleCollisionSignature OnParticleCollide
        [FieldOffset(1632)] public Vector OldPosition;
        [FieldOffset(1644)] public Vector PartSysVelocity;
        [FieldOffset(1656)] public float WarmupTime;
        [FieldOffset(1660)] public float WarmupTickRate;
        [FieldOffset(1668)] public float SecondsBeforeInactive;
        [FieldOffset(1676)] public float MaxTimeBeforeForceUpdateTransform;
        [FieldOffset(1680)] public int EditorLODLevel;
        [FieldOffset(1684)] public int EditorDetailMode;
        [FieldOffset(1720)] public NativeArray ReplayClips;
        [FieldOffset(1744)] public float CustomTimeDilation;
        [FieldOffset(1832)] byte AutoAttachParent; //TODO: weak object TWeakObjectPtr<USceneComponent> AutoAttachParent
        [FieldOffset(1840)] public Name AutoAttachSocketName;
        [FieldOffset(1853)] byte AutoAttachLocationRule; //TODO: enum EAttachmentRule AutoAttachLocationRule
        [FieldOffset(1854)] byte AutoAttachRotationRule; //TODO: enum EAttachmentRule AutoAttachRotationRule
        [FieldOffset(1855)] byte AutoAttachScaleRule; //TODO: enum EAttachmentRule AutoAttachScaleRule
        [FieldOffset(1904)] byte OnSystemFinished; //TODO: multicast delegate FOnSystemFinished OnSystemFinished
    }
    internal unsafe struct ParticleSystemComponent_methods {
        internal struct BeginTrails_method {
            static internal IntPtr BeginTrails_ptr;
            static BeginTrails_method() {
                BeginTrails_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "BeginTrails");
            }

            internal static unsafe void Invoke(IntPtr obj, Name InFirstSocketName, Name InSecondSocketName, byte InWidthMode, float InWidth) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InFirstSocketName;
                *((Name*)(b+12)) = InSecondSocketName;
                *(b+24) = InWidthMode;
                *((float*)(b+28)) = InWidth;
                Main.GetProcessEvent(obj, BeginTrails_ptr, new IntPtr(p)); ;
            }
        }
        internal struct CreateNamedDynamicMaterialInstance_method {
            static internal IntPtr CreateNamedDynamicMaterialInstance_ptr;
            static CreateNamedDynamicMaterialInstance_method() {
                CreateNamedDynamicMaterialInstance_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "CreateNamedDynamicMaterialInstance");
            }

            internal static unsafe MaterialInstanceDynamic Invoke(IntPtr obj, Name InName, MaterialInterface SourceMaterial) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InName;
                *((IntPtr*)(b+16)) = SourceMaterial;
                Main.GetProcessEvent(obj, CreateNamedDynamicMaterialInstance_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+24));
            }
        }
        internal struct EndTrails_method {
            static internal IntPtr EndTrails_ptr;
            static EndTrails_method() {
                EndTrails_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "EndTrails");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, EndTrails_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GenerateParticleEvent_method {
            static internal IntPtr GenerateParticleEvent_ptr;
            static GenerateParticleEvent_method() {
                GenerateParticleEvent_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "GenerateParticleEvent");
            }

            internal static unsafe void Invoke(IntPtr obj, Name InEventName, float InEmitterTime, Vector InLocation, Vector InDirection, Vector InVelocity) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InEventName;
                *((float*)(b+12)) = InEmitterTime;
                *((Vector*)(b+16)) = InLocation;
                *((Vector*)(b+28)) = InDirection;
                *((Vector*)(b+40)) = InVelocity;
                Main.GetProcessEvent(obj, GenerateParticleEvent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetBeamEndPoint_method {
            static internal IntPtr GetBeamEndPoint_ptr;
            static GetBeamEndPoint_method() {
                GetBeamEndPoint_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "GetBeamEndPoint");
            }

            internal static unsafe (Vector, bool) Invoke(IntPtr obj, int EmitterIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = EmitterIndex;
                Main.GetProcessEvent(obj, GetBeamEndPoint_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+4)),*((bool*)(b+16)));
            }
        }
        internal struct GetBeamSourcePoint_method {
            static internal IntPtr GetBeamSourcePoint_ptr;
            static GetBeamSourcePoint_method() {
                GetBeamSourcePoint_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "GetBeamSourcePoint");
            }

            internal static unsafe (Vector, bool) Invoke(IntPtr obj, int EmitterIndex, int SourceIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = EmitterIndex;
                *((int*)(b+4)) = SourceIndex;
                Main.GetProcessEvent(obj, GetBeamSourcePoint_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+8)),*((bool*)(b+20)));
            }
        }
        internal struct GetBeamSourceStrength_method {
            static internal IntPtr GetBeamSourceStrength_ptr;
            static GetBeamSourceStrength_method() {
                GetBeamSourceStrength_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "GetBeamSourceStrength");
            }

            internal static unsafe (float, bool) Invoke(IntPtr obj, int EmitterIndex, int SourceIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = EmitterIndex;
                *((int*)(b+4)) = SourceIndex;
                Main.GetProcessEvent(obj, GetBeamSourceStrength_ptr, new IntPtr(p)); ;
                return (*((float*)(b+8)),*((bool*)(b+12)));
            }
        }
        internal struct GetBeamSourceTangent_method {
            static internal IntPtr GetBeamSourceTangent_ptr;
            static GetBeamSourceTangent_method() {
                GetBeamSourceTangent_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "GetBeamSourceTangent");
            }

            internal static unsafe (Vector, bool) Invoke(IntPtr obj, int EmitterIndex, int SourceIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = EmitterIndex;
                *((int*)(b+4)) = SourceIndex;
                Main.GetProcessEvent(obj, GetBeamSourceTangent_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+8)),*((bool*)(b+20)));
            }
        }
        internal struct GetBeamTargetPoint_method {
            static internal IntPtr GetBeamTargetPoint_ptr;
            static GetBeamTargetPoint_method() {
                GetBeamTargetPoint_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "GetBeamTargetPoint");
            }

            internal static unsafe (Vector, bool) Invoke(IntPtr obj, int EmitterIndex, int TargetIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = EmitterIndex;
                *((int*)(b+4)) = TargetIndex;
                Main.GetProcessEvent(obj, GetBeamTargetPoint_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+8)),*((bool*)(b+20)));
            }
        }
        internal struct GetBeamTargetStrength_method {
            static internal IntPtr GetBeamTargetStrength_ptr;
            static GetBeamTargetStrength_method() {
                GetBeamTargetStrength_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "GetBeamTargetStrength");
            }

            internal static unsafe (float, bool) Invoke(IntPtr obj, int EmitterIndex, int TargetIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = EmitterIndex;
                *((int*)(b+4)) = TargetIndex;
                Main.GetProcessEvent(obj, GetBeamTargetStrength_ptr, new IntPtr(p)); ;
                return (*((float*)(b+8)),*((bool*)(b+12)));
            }
        }
        internal struct GetBeamTargetTangent_method {
            static internal IntPtr GetBeamTargetTangent_ptr;
            static GetBeamTargetTangent_method() {
                GetBeamTargetTangent_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "GetBeamTargetTangent");
            }

            internal static unsafe (Vector, bool) Invoke(IntPtr obj, int EmitterIndex, int TargetIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = EmitterIndex;
                *((int*)(b+4)) = TargetIndex;
                Main.GetProcessEvent(obj, GetBeamTargetTangent_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+8)),*((bool*)(b+20)));
            }
        }
        internal struct GetNamedMaterial_method {
            static internal IntPtr GetNamedMaterial_ptr;
            static GetNamedMaterial_method() {
                GetNamedMaterial_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "GetNamedMaterial");
            }

            internal static unsafe MaterialInterface Invoke(IntPtr obj, Name InName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InName;
                Main.GetProcessEvent(obj, GetNamedMaterial_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct GetNumActiveParticles_method {
            static internal IntPtr GetNumActiveParticles_ptr;
            static GetNumActiveParticles_method() {
                GetNumActiveParticles_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "GetNumActiveParticles");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumActiveParticles_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct ReleaseToPool_method {
            static internal IntPtr ReleaseToPool_ptr;
            static ReleaseToPool_method() {
                ReleaseToPool_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "ReleaseToPool");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ReleaseToPool_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetActorParameter_method {
            static internal IntPtr SetActorParameter_ptr;
            static SetActorParameter_method() {
                SetActorParameter_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetActorParameter");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, Actor Param) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((IntPtr*)(b+16)) = Param;
                Main.GetProcessEvent(obj, SetActorParameter_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAutoAttachmentParameters_method {
            static internal IntPtr SetAutoAttachmentParameters_ptr;
            static SetAutoAttachmentParameters_method() {
                SetAutoAttachmentParameters_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetAutoAttachmentParameters");
            }

            internal static unsafe void Invoke(IntPtr obj, SceneComponent Parent, Name SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Parent;
                *((Name*)(b+8)) = SocketName;
                *(b+20) = (byte)LocationRule;
                *(b+21) = (byte)RotationRule;
                *(b+22) = (byte)ScaleRule;
                Main.GetProcessEvent(obj, SetAutoAttachmentParameters_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAutoAttachParams_method {
            static internal IntPtr SetAutoAttachParams_ptr;
            static SetAutoAttachParams_method() {
                SetAutoAttachParams_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetAutoAttachParams");
            }

            internal static unsafe void Invoke(IntPtr obj, SceneComponent Parent, Name SocketName, byte LocationType) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Parent;
                *((Name*)(b+8)) = SocketName;
                *(b+20) = LocationType;
                Main.GetProcessEvent(obj, SetAutoAttachParams_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBeamEndPoint_method {
            static internal IntPtr SetBeamEndPoint_ptr;
            static SetBeamEndPoint_method() {
                SetBeamEndPoint_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetBeamEndPoint");
            }

            internal static unsafe void Invoke(IntPtr obj, int EmitterIndex, Vector NewEndPoint) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = EmitterIndex;
                *((Vector*)(b+4)) = NewEndPoint;
                Main.GetProcessEvent(obj, SetBeamEndPoint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBeamSourcePoint_method {
            static internal IntPtr SetBeamSourcePoint_ptr;
            static SetBeamSourcePoint_method() {
                SetBeamSourcePoint_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetBeamSourcePoint");
            }

            internal static unsafe void Invoke(IntPtr obj, int EmitterIndex, Vector NewSourcePoint, int SourceIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = EmitterIndex;
                *((Vector*)(b+4)) = NewSourcePoint;
                *((int*)(b+16)) = SourceIndex;
                Main.GetProcessEvent(obj, SetBeamSourcePoint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBeamSourceStrength_method {
            static internal IntPtr SetBeamSourceStrength_ptr;
            static SetBeamSourceStrength_method() {
                SetBeamSourceStrength_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetBeamSourceStrength");
            }

            internal static unsafe void Invoke(IntPtr obj, int EmitterIndex, float NewSourceStrength, int SourceIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = EmitterIndex;
                *((float*)(b+4)) = NewSourceStrength;
                *((int*)(b+8)) = SourceIndex;
                Main.GetProcessEvent(obj, SetBeamSourceStrength_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBeamSourceTangent_method {
            static internal IntPtr SetBeamSourceTangent_ptr;
            static SetBeamSourceTangent_method() {
                SetBeamSourceTangent_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetBeamSourceTangent");
            }

            internal static unsafe void Invoke(IntPtr obj, int EmitterIndex, Vector NewTangentPoint, int SourceIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = EmitterIndex;
                *((Vector*)(b+4)) = NewTangentPoint;
                *((int*)(b+16)) = SourceIndex;
                Main.GetProcessEvent(obj, SetBeamSourceTangent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBeamTargetPoint_method {
            static internal IntPtr SetBeamTargetPoint_ptr;
            static SetBeamTargetPoint_method() {
                SetBeamTargetPoint_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetBeamTargetPoint");
            }

            internal static unsafe void Invoke(IntPtr obj, int EmitterIndex, Vector NewTargetPoint, int TargetIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = EmitterIndex;
                *((Vector*)(b+4)) = NewTargetPoint;
                *((int*)(b+16)) = TargetIndex;
                Main.GetProcessEvent(obj, SetBeamTargetPoint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBeamTargetStrength_method {
            static internal IntPtr SetBeamTargetStrength_ptr;
            static SetBeamTargetStrength_method() {
                SetBeamTargetStrength_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetBeamTargetStrength");
            }

            internal static unsafe void Invoke(IntPtr obj, int EmitterIndex, float NewTargetStrength, int TargetIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = EmitterIndex;
                *((float*)(b+4)) = NewTargetStrength;
                *((int*)(b+8)) = TargetIndex;
                Main.GetProcessEvent(obj, SetBeamTargetStrength_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBeamTargetTangent_method {
            static internal IntPtr SetBeamTargetTangent_ptr;
            static SetBeamTargetTangent_method() {
                SetBeamTargetTangent_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetBeamTargetTangent");
            }

            internal static unsafe void Invoke(IntPtr obj, int EmitterIndex, Vector NewTangentPoint, int TargetIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = EmitterIndex;
                *((Vector*)(b+4)) = NewTangentPoint;
                *((int*)(b+16)) = TargetIndex;
                Main.GetProcessEvent(obj, SetBeamTargetTangent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetColorParameter_method {
            static internal IntPtr SetColorParameter_ptr;
            static SetColorParameter_method() {
                SetColorParameter_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetColorParameter");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, LinearColor Param) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((LinearColor*)(b+12)) = Param;
                Main.GetProcessEvent(obj, SetColorParameter_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEmitterEnable_method {
            static internal IntPtr SetEmitterEnable_ptr;
            static SetEmitterEnable_method() {
                SetEmitterEnable_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetEmitterEnable");
            }

            internal static unsafe void Invoke(IntPtr obj, Name EmitterName, bool bNewEnableState) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = EmitterName;
                *((bool*)(b+12)) = bNewEnableState;
                Main.GetProcessEvent(obj, SetEmitterEnable_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFloatParameter_method {
            static internal IntPtr SetFloatParameter_ptr;
            static SetFloatParameter_method() {
                SetFloatParameter_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetFloatParameter");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, float Param) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((float*)(b+12)) = Param;
                Main.GetProcessEvent(obj, SetFloatParameter_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMaterialParameter_method {
            static internal IntPtr SetMaterialParameter_ptr;
            static SetMaterialParameter_method() {
                SetMaterialParameter_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetMaterialParameter");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, MaterialInterface Param) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((IntPtr*)(b+16)) = Param;
                Main.GetProcessEvent(obj, SetMaterialParameter_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTemplate_method {
            static internal IntPtr SetTemplate_ptr;
            static SetTemplate_method() {
                SetTemplate_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetTemplate");
            }

            internal static unsafe void Invoke(IntPtr obj, ParticleSystem NewTemplate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewTemplate;
                Main.GetProcessEvent(obj, SetTemplate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTrailSourceData_method {
            static internal IntPtr SetTrailSourceData_ptr;
            static SetTrailSourceData_method() {
                SetTrailSourceData_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetTrailSourceData");
            }

            internal static unsafe void Invoke(IntPtr obj, Name InFirstSocketName, Name InSecondSocketName, byte InWidthMode, float InWidth) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InFirstSocketName;
                *((Name*)(b+12)) = InSecondSocketName;
                *(b+24) = InWidthMode;
                *((float*)(b+28)) = InWidth;
                Main.GetProcessEvent(obj, SetTrailSourceData_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVectorParameter_method {
            static internal IntPtr SetVectorParameter_ptr;
            static SetVectorParameter_method() {
                SetVectorParameter_ptr = Main.GetMethodUFunction(ParticleSystemComponent.StaticClass, "SetVectorParameter");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, Vector Param) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((Vector*)(b+12)) = Param;
                Main.GetProcessEvent(obj, SetVectorParameter_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ParticleSystemComponent_events {
    }
}

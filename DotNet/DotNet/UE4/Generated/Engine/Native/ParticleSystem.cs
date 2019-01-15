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
    [StructLayout( LayoutKind.Explicit, Size=432 )]
    internal unsafe struct ParticleSystem_fields {
        [FieldOffset(56)] public byte SystemUpdateMode;
        [FieldOffset(60)] public float UpdateTime_FPS;
        [FieldOffset(64)] public float UpdateTime_Delta;
        [FieldOffset(68)] public float WarmupTime;
        [FieldOffset(72)] public float WarmupTickRate;
        [FieldOffset(80)] public NativeArray Emitters;
        [FieldOffset(96)]  public IntPtr  PreviewComponent;
        [FieldOffset(104)] public Rotator ThumbnailAngle;
        [FieldOffset(116)] public float ThumbnailDistance;
        [FieldOffset(120)] public float ThumbnailWarmup;
        [FieldOffset(128)]  public IntPtr  CurveEdSetup;
        [FieldOffset(136)] public bool bOrientZAxisTowardCamera;
        [FieldOffset(140)] public float LODDistanceCheckTime;
        [FieldOffset(144)] public byte LODMethod;
        [FieldOffset(152)] public NativeArray LODDistances;
        [FieldOffset(168)] public int EditorLODSetting;
        [FieldOffset(172)] public bool bRegenerateLODDuplicate;
        [FieldOffset(176)] public NativeArray LODSettings;
        [FieldOffset(192)] public bool bUseFixedRelativeBoundingBox;
        [FieldOffset(196)] public Box FixedRelativeBoundingBox;
        [FieldOffset(224)] public float SecondsBeforeInactive;
        [FieldOffset(232)] byte FloorMesh; //TODO: string FString FloorMesh
        [FieldOffset(248)] public Vector FloorPosition;
        [FieldOffset(260)] public Rotator FloorRotation;
        [FieldOffset(272)] public float FloorScale;
        [FieldOffset(276)] public Vector FloorScale3D;
        [FieldOffset(288)] public Color BackgroundColor;
        [FieldOffset(292)] public bool bShouldResetPeakCounts;
        [FieldOffset(292)] public bool bHasPhysics;
        [FieldOffset(292)] public bool bUseRealtimeThumbnail;
        [FieldOffset(292)] public bool ThumbnailImageOutOfDate;
        [FieldOffset(296)]  public IntPtr  ThumbnailImage;
        [FieldOffset(304)] public float Delay;
        [FieldOffset(308)] public float DelayLow;
        [FieldOffset(312)] public bool bUseDelayRange;
        [FieldOffset(316)] public bool bAutoDeactivate;
        [FieldOffset(320)] byte MinTimeBetweenTicks; //TODO: numeric uint32 MinTimeBetweenTicks
        [FieldOffset(324)] byte InsignificantReaction; //TODO: enum EParticleSystemInsignificanceReaction InsignificantReaction
        [FieldOffset(328)] public float InsignificanceDelay;
        [FieldOffset(332)] byte MaxSignificanceLevel; //TODO: enum EParticleSignificanceLevel MaxSignificanceLevel
        [FieldOffset(336)] byte MaxPoolSize; //TODO: numeric uint32 MaxPoolSize
        [FieldOffset(340)] public Vector MacroUVPosition;
        [FieldOffset(352)] public float MacroUVRadius;
        [FieldOffset(356)] public byte OcclusionBoundsMethod;
        [FieldOffset(360)] public Box CustomOcclusionBounds;
        [FieldOffset(392)] public NativeArray SoloTracking;
        [FieldOffset(408)] public NativeArray NamedMaterialSlots;
    }
    internal unsafe struct ParticleSystem_methods {
        internal struct ContainsEmitterType_method {
            static internal IntPtr ContainsEmitterType_ptr;
            static ContainsEmitterType_method() {
                ContainsEmitterType_ptr = Main.GetMethodUFunction(ParticleSystem.StaticClass, "ContainsEmitterType");
            }

            internal static unsafe bool Invoke(IntPtr obj, SubclassOf<UObject> TypeData) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = TypeData;
                Main.GetProcessEvent(obj, ContainsEmitterType_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
    }
    internal unsafe struct ParticleSystem_events {
    }
}

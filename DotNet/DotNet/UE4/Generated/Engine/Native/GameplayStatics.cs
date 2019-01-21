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
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct GameplayStatics_fields {
    }
    internal unsafe struct GameplayStatics_methods {
        internal struct ActivateReverbEffect_method {
            static internal IntPtr ActivateReverbEffect_ptr;
            static ActivateReverbEffect_method() {
                ActivateReverbEffect_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "ActivateReverbEffect");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, ReverbEffect ReverbEffect, Name TagName, float Priority, float Volume, float FadeTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = ReverbEffect;
                *((Name*)(b+16)) = TagName;
                *((float*)(b+28)) = Priority;
                *((float*)(b+32)) = Volume;
                *((float*)(b+36)) = FadeTime;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, ActivateReverbEffect_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ApplyDamage_method {
            static internal IntPtr ApplyDamage_ptr;
            static ApplyDamage_method() {
                ApplyDamage_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "ApplyDamage");
            }

            internal static unsafe float Invoke(Actor DamagedActor, float BaseDamage, Controller EventInstigator, Actor DamageCauser, SubclassOf<DamageType> DamageTypeClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = DamagedActor;
                *((float*)(b+8)) = BaseDamage;
                *((IntPtr*)(b+16)) = EventInstigator;
                *((IntPtr*)(b+24)) = DamageCauser;
                *((IntPtr*)(b+32)) = DamageTypeClass;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, ApplyDamage_ptr, new IntPtr(p)); ;
                return *((float*)(b+40));
            }
        }
        internal struct ApplyPointDamage_method {
            static internal IntPtr ApplyPointDamage_ptr;
            static ApplyPointDamage_method() {
                ApplyPointDamage_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "ApplyPointDamage");
            }

            internal static unsafe float Invoke(Actor DamagedActor, float BaseDamage, Vector HitFromDirection, HitResult HitInfo, Controller EventInstigator, Actor DamageCauser, SubclassOf<DamageType> DamageTypeClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = DamagedActor;
                *((float*)(b+8)) = BaseDamage;
                *((Vector*)(b+12)) = HitFromDirection;
                *((HitResult*)(b+24)) = HitInfo;
                *((IntPtr*)(b+168)) = EventInstigator;
                *((IntPtr*)(b+176)) = DamageCauser;
                *((IntPtr*)(b+184)) = DamageTypeClass;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, ApplyPointDamage_ptr, new IntPtr(p)); ;
                return *((float*)(b+192));
            }
        }
        internal struct ApplyRadialDamage_method {
            static internal IntPtr ApplyRadialDamage_ptr;
            static ApplyRadialDamage_method() {
                ApplyRadialDamage_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "ApplyRadialDamage");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject, float BaseDamage, Vector Origin, float DamageRadius, SubclassOf<DamageType> DamageTypeClass, byte IgnoreActors /*TODO: array TArray */, Actor DamageCauser, Controller InstigatedByController, bool bDoFullDamage, byte DamagePreventionChannel) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((float*)(b+8)) = BaseDamage;
                *((Vector*)(b+12)) = Origin;
                *((float*)(b+24)) = DamageRadius;
                *((IntPtr*)(b+32)) = DamageTypeClass;
                throw new NotImplementedException(); //TODO: array TArray IgnoreActors
                *((IntPtr*)(b+56)) = DamageCauser;
                *((IntPtr*)(b+64)) = InstigatedByController;
                *((bool*)(b+72)) = bDoFullDamage;
                *(b+73) = DamagePreventionChannel;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, ApplyRadialDamage_ptr, new IntPtr(p)); ;
                 //TODO: array TArray IgnoreActors
                return *((bool*)(b+74));
            }
        }
        internal struct ApplyRadialDamageWithFalloff_method {
            static internal IntPtr ApplyRadialDamageWithFalloff_ptr;
            static ApplyRadialDamageWithFalloff_method() {
                ApplyRadialDamageWithFalloff_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "ApplyRadialDamageWithFalloff");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject, float BaseDamage, float MinimumDamage, Vector Origin, float DamageInnerRadius, float DamageOuterRadius, float DamageFalloff, SubclassOf<DamageType> DamageTypeClass, byte IgnoreActors /*TODO: array TArray */, Actor DamageCauser, Controller InstigatedByController, byte DamagePreventionChannel) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((float*)(b+8)) = BaseDamage;
                *((float*)(b+12)) = MinimumDamage;
                *((Vector*)(b+16)) = Origin;
                *((float*)(b+28)) = DamageInnerRadius;
                *((float*)(b+32)) = DamageOuterRadius;
                *((float*)(b+36)) = DamageFalloff;
                *((IntPtr*)(b+40)) = DamageTypeClass;
                throw new NotImplementedException(); //TODO: array TArray IgnoreActors
                *((IntPtr*)(b+64)) = DamageCauser;
                *((IntPtr*)(b+72)) = InstigatedByController;
                *(b+80) = DamagePreventionChannel;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, ApplyRadialDamageWithFalloff_ptr, new IntPtr(p)); ;
                 //TODO: array TArray IgnoreActors
                return *((bool*)(b+81));
            }
        }
        internal struct AreAnyListenersWithinRange_method {
            static internal IntPtr AreAnyListenersWithinRange_ptr;
            static AreAnyListenersWithinRange_method() {
                AreAnyListenersWithinRange_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "AreAnyListenersWithinRange");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject, Vector Location, float MaximumRange) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Location;
                *((float*)(b+20)) = MaximumRange;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, AreAnyListenersWithinRange_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct AreSubtitlesEnabled_method {
            static internal IntPtr AreSubtitlesEnabled_ptr;
            static AreSubtitlesEnabled_method() {
                AreSubtitlesEnabled_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "AreSubtitlesEnabled");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, AreSubtitlesEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct BeginDeferredActorSpawnFromClass_method {
            static internal IntPtr BeginDeferredActorSpawnFromClass_ptr;
            static BeginDeferredActorSpawnFromClass_method() {
                BeginDeferredActorSpawnFromClass_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "BeginDeferredActorSpawnFromClass");
            }

            internal static unsafe Actor Invoke(UObject WorldContextObject, SubclassOf<Actor> ActorClass, Transform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride, Actor Owner) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = ActorClass;
                *((Transform*)(b+16)) = SpawnTransform;
                *(b+64) = (byte)CollisionHandlingOverride;
                *((IntPtr*)(b+72)) = Owner;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, BeginDeferredActorSpawnFromClass_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+80));
            }
        }
        internal struct BeginSpawningActorFromBlueprint_method {
            static internal IntPtr BeginSpawningActorFromBlueprint_ptr;
            static BeginSpawningActorFromBlueprint_method() {
                BeginSpawningActorFromBlueprint_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "BeginSpawningActorFromBlueprint");
            }

            internal static unsafe Actor Invoke(UObject WorldContextObject, Blueprint Blueprint, Transform SpawnTransform, bool bNoCollisionFail) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Blueprint;
                *((Transform*)(b+16)) = SpawnTransform;
                *((bool*)(b+64)) = bNoCollisionFail;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, BeginSpawningActorFromBlueprint_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+72));
            }
        }
        internal struct BeginSpawningActorFromClass_method {
            static internal IntPtr BeginSpawningActorFromClass_ptr;
            static BeginSpawningActorFromClass_method() {
                BeginSpawningActorFromClass_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "BeginSpawningActorFromClass");
            }

            internal static unsafe Actor Invoke(UObject WorldContextObject, SubclassOf<Actor> ActorClass, Transform SpawnTransform, bool bNoCollisionFail, Actor Owner) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = ActorClass;
                *((Transform*)(b+16)) = SpawnTransform;
                *((bool*)(b+64)) = bNoCollisionFail;
                *((IntPtr*)(b+72)) = Owner;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, BeginSpawningActorFromClass_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+80));
            }
        }
        internal struct Blueprint_PredictProjectilePath_Advanced_method {
            static internal IntPtr Blueprint_PredictProjectilePath_Advanced_ptr;
            static Blueprint_PredictProjectilePath_Advanced_method() {
                Blueprint_PredictProjectilePath_Advanced_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "Blueprint_PredictProjectilePath_Advanced");
            }

            internal static unsafe (PredictProjectilePathResult, bool) Invoke(UObject WorldContextObject, PredictProjectilePathParams PredictParams) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((PredictProjectilePathParams*)(b+8)) = PredictParams;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, Blueprint_PredictProjectilePath_Advanced_ptr, new IntPtr(p)); ;
                return (*((PredictProjectilePathResult*)(b+104)),*((bool*)(b+296)));
            }
        }
        internal struct Blueprint_PredictProjectilePath_ByObjectType_method {
            static internal IntPtr Blueprint_PredictProjectilePath_ByObjectType_ptr;
            static Blueprint_PredictProjectilePath_ByObjectType_method() {
                Blueprint_PredictProjectilePath_ByObjectType_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "Blueprint_PredictProjectilePath_ByObjectType");
            }

            internal static unsafe (HitResult, IReadOnlyCollection<Vector>, Vector, bool) Invoke(UObject WorldContextObject, Vector StartPos, Vector LaunchVelocity, bool bTracePath, float ProjectileRadius, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, float DrawDebugTime, float SimFrequency, float MaxSimTime, float OverrideGravityZ) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+180)) = StartPos;
                *((Vector*)(b+192)) = LaunchVelocity;
                *((bool*)(b+204)) = bTracePath;
                *((float*)(b+208)) = ProjectileRadius;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((bool*)(b+232)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+256) = DrawDebugType;
                *((float*)(b+260)) = DrawDebugTime;
                *((float*)(b+264)) = SimFrequency;
                *((float*)(b+268)) = MaxSimTime;
                *((float*)(b+272)) = OverrideGravityZ;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, Blueprint_PredictProjectilePath_ByObjectType_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutPathPositions
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                return (*((HitResult*)(b+8)),UObject.ToUnmangedCollection<Vector>(b+152),*((Vector*)(b+168)),*((bool*)(b+276)));
            }
        }
        internal struct Blueprint_PredictProjectilePath_ByTraceChannel_method {
            static internal IntPtr Blueprint_PredictProjectilePath_ByTraceChannel_ptr;
            static Blueprint_PredictProjectilePath_ByTraceChannel_method() {
                Blueprint_PredictProjectilePath_ByTraceChannel_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "Blueprint_PredictProjectilePath_ByTraceChannel");
            }

            internal static unsafe (HitResult, IReadOnlyCollection<Vector>, Vector, bool) Invoke(UObject WorldContextObject, Vector StartPos, Vector LaunchVelocity, bool bTracePath, float ProjectileRadius, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, float DrawDebugTime, float SimFrequency, float MaxSimTime, float OverrideGravityZ) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+180)) = StartPos;
                *((Vector*)(b+192)) = LaunchVelocity;
                *((bool*)(b+204)) = bTracePath;
                *((float*)(b+208)) = ProjectileRadius;
                *(b+212) = TraceChannel;
                *((bool*)(b+213)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+232) = DrawDebugType;
                *((float*)(b+236)) = DrawDebugTime;
                *((float*)(b+240)) = SimFrequency;
                *((float*)(b+244)) = MaxSimTime;
                *((float*)(b+248)) = OverrideGravityZ;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, Blueprint_PredictProjectilePath_ByTraceChannel_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutPathPositions
                 //TODO: array TArray ActorsToIgnore
                return (*((HitResult*)(b+8)),UObject.ToUnmangedCollection<Vector>(b+152),*((Vector*)(b+168)),*((bool*)(b+252)));
            }
        }
        internal struct BlueprintSuggestProjectileVelocity_method {
            static internal IntPtr BlueprintSuggestProjectileVelocity_ptr;
            static BlueprintSuggestProjectileVelocity_method() {
                BlueprintSuggestProjectileVelocity_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "BlueprintSuggestProjectileVelocity");
            }

            internal static unsafe (Vector, bool) Invoke(UObject WorldContextObject, Vector StartLocation, Vector EndLocation, float LaunchSpeed, float OverrideGravityZ, byte TraceOption, float CollisionRadius, bool bFavorHighArc, bool bDrawDebug) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+20)) = StartLocation;
                *((Vector*)(b+32)) = EndLocation;
                *((float*)(b+44)) = LaunchSpeed;
                *((float*)(b+48)) = OverrideGravityZ;
                *(b+52) = TraceOption;
                *((float*)(b+56)) = CollisionRadius;
                *((bool*)(b+60)) = bFavorHighArc;
                *((bool*)(b+61)) = bDrawDebug;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, BlueprintSuggestProjectileVelocity_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+8)),*((bool*)(b+62)));
            }
        }
        internal struct BreakHitResult_method {
            static internal IntPtr BreakHitResult_ptr;
            static BreakHitResult_method() {
                BreakHitResult_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "BreakHitResult");
            }

            internal static unsafe (bool, bool, float, float, Vector, Vector, Vector, Vector, PhysicalMaterial, Actor, PrimitiveComponent, Name, int, int, Vector, Vector) Invoke(HitResult Hit) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((HitResult*)(b+0)) = Hit;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, BreakHitResult_ptr, new IntPtr(p)); ;
                return (*((bool*)(b+144)),*((bool*)(b+145)),*((float*)(b+148)),*((float*)(b+152)),*((Vector*)(b+156)),*((Vector*)(b+168)),*((Vector*)(b+180)),*((Vector*)(b+192)),*((IntPtr*)(b+208)),*((IntPtr*)(b+216)),*((IntPtr*)(b+224)),*((Name*)(b+232)),*((int*)(b+244)),*((int*)(b+248)),*((Vector*)(b+252)),*((Vector*)(b+264)));
            }
        }
        internal struct CancelAsyncLoading_method {
            static internal IntPtr CancelAsyncLoading_ptr;
            static CancelAsyncLoading_method() {
                CancelAsyncLoading_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "CancelAsyncLoading");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, CancelAsyncLoading_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearSoundMixClassOverride_method {
            static internal IntPtr ClearSoundMixClassOverride_ptr;
            static ClearSoundMixClassOverride_method() {
                ClearSoundMixClassOverride_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "ClearSoundMixClassOverride");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, SoundMix InSoundMixModifier, SoundClass InSoundClass, float FadeOutTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = InSoundMixModifier;
                *((IntPtr*)(b+16)) = InSoundClass;
                *((float*)(b+24)) = FadeOutTime;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, ClearSoundMixClassOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearSoundMixModifiers_method {
            static internal IntPtr ClearSoundMixModifiers_ptr;
            static ClearSoundMixModifiers_method() {
                ClearSoundMixModifiers_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "ClearSoundMixModifiers");
            }

            internal static unsafe void Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, ClearSoundMixModifiers_ptr, new IntPtr(p)); ;
            }
        }
        internal struct CreatePlayer_method {
            static internal IntPtr CreatePlayer_ptr;
            static CreatePlayer_method() {
                CreatePlayer_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "CreatePlayer");
            }

            internal static unsafe PlayerController Invoke(UObject WorldContextObject, int ControllerId, bool bSpawnPawn) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((int*)(b+8)) = ControllerId;
                *((bool*)(b+12)) = bSpawnPawn;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, CreatePlayer_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct CreateSaveGameObject_method {
            static internal IntPtr CreateSaveGameObject_ptr;
            static CreateSaveGameObject_method() {
                CreateSaveGameObject_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "CreateSaveGameObject");
            }

            internal static unsafe SaveGame Invoke(SubclassOf<SaveGame> SaveGameClass) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SaveGameClass;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, CreateSaveGameObject_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct CreateSaveGameObjectFromBlueprint_method {
            static internal IntPtr CreateSaveGameObjectFromBlueprint_ptr;
            static CreateSaveGameObjectFromBlueprint_method() {
                CreateSaveGameObjectFromBlueprint_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "CreateSaveGameObjectFromBlueprint");
            }

            internal static unsafe SaveGame Invoke(Blueprint SaveGameBlueprint) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SaveGameBlueprint;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, CreateSaveGameObjectFromBlueprint_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct CreateSound2D_method {
            static internal IntPtr CreateSound2D_ptr;
            static CreateSound2D_method() {
                CreateSound2D_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "CreateSound2D");
            }

            internal static unsafe AudioComponent Invoke(UObject WorldContextObject, SoundBase Sound, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundConcurrency ConcurrencySettings, bool bPersistAcrossLevelTransition, bool bAutoDestroy) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Sound;
                *((float*)(b+16)) = VolumeMultiplier;
                *((float*)(b+20)) = PitchMultiplier;
                *((float*)(b+24)) = StartTime;
                *((IntPtr*)(b+32)) = ConcurrencySettings;
                *((bool*)(b+40)) = bPersistAcrossLevelTransition;
                *((bool*)(b+41)) = bAutoDestroy;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, CreateSound2D_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+48));
            }
        }
        internal struct DeactivateReverbEffect_method {
            static internal IntPtr DeactivateReverbEffect_ptr;
            static DeactivateReverbEffect_method() {
                DeactivateReverbEffect_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "DeactivateReverbEffect");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Name TagName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Name*)(b+8)) = TagName;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, DeactivateReverbEffect_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DeleteGameInSlot_method {
            static internal IntPtr DeleteGameInSlot_ptr;
            static DeleteGameInSlot_method() {
                DeleteGameInSlot_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "DeleteGameInSlot");
            }

            internal static unsafe bool Invoke(string SlotName, int UserIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SlotName_handle = GCHandle.Alloc(SlotName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SlotName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SlotName.Length;
                *(int*)(b+IntPtr.Size+4+0) = SlotName.Length;
                *((int*)(b+16)) = UserIndex;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, DeleteGameInSlot_ptr, new IntPtr(p)); ;
                SlotName_handle.Free();
                return *((bool*)(b+20));
            }
        }
        internal struct DeprojectScreenToWorld_method {
            static internal IntPtr DeprojectScreenToWorld_ptr;
            static DeprojectScreenToWorld_method() {
                DeprojectScreenToWorld_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "DeprojectScreenToWorld");
            }

            internal static unsafe (Vector, Vector, bool) Invoke(PlayerController Player, Vector2D ScreenPosition) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Player;
                *((Vector2D*)(b+8)) = ScreenPosition;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, DeprojectScreenToWorld_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+16)),*((Vector*)(b+28)),*((bool*)(b+40)));
            }
        }
        internal struct DoesSaveGameExist_method {
            static internal IntPtr DoesSaveGameExist_ptr;
            static DoesSaveGameExist_method() {
                DoesSaveGameExist_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "DoesSaveGameExist");
            }

            internal static unsafe bool Invoke(string SlotName, int UserIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SlotName_handle = GCHandle.Alloc(SlotName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SlotName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SlotName.Length;
                *(int*)(b+IntPtr.Size+4+0) = SlotName.Length;
                *((int*)(b+16)) = UserIndex;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, DoesSaveGameExist_ptr, new IntPtr(p)); ;
                SlotName_handle.Free();
                return *((bool*)(b+20));
            }
        }
        internal struct EnableLiveStreaming_method {
            static internal IntPtr EnableLiveStreaming_ptr;
            static EnableLiveStreaming_method() {
                EnableLiveStreaming_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "EnableLiveStreaming");
            }

            internal static unsafe void Invoke(bool Enable) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = Enable;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, EnableLiveStreaming_ptr, new IntPtr(p)); ;
            }
        }
        internal struct FindCollisionUV_method {
            static internal IntPtr FindCollisionUV_ptr;
            static FindCollisionUV_method() {
                FindCollisionUV_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "FindCollisionUV");
            }

            internal static unsafe (Vector2D, bool) Invoke(HitResult Hit, int UVChannel) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((HitResult*)(b+0)) = Hit;
                *((int*)(b+144)) = UVChannel;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, FindCollisionUV_ptr, new IntPtr(p)); ;
                return (*((Vector2D*)(b+148)),*((bool*)(b+156)));
            }
        }
        internal struct FinishSpawningActor_method {
            static internal IntPtr FinishSpawningActor_ptr;
            static FinishSpawningActor_method() {
                FinishSpawningActor_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "FinishSpawningActor");
            }

            internal static unsafe Actor Invoke(Actor Actor, Transform SpawnTransform) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Actor;
                *((Transform*)(b+16)) = SpawnTransform;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, FinishSpawningActor_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+64));
            }
        }
        internal struct FlushLevelStreaming_method {
            static internal IntPtr FlushLevelStreaming_ptr;
            static FlushLevelStreaming_method() {
                FlushLevelStreaming_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "FlushLevelStreaming");
            }

            internal static unsafe void Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, FlushLevelStreaming_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetAccurateRealTime_method {
            static internal IntPtr GetAccurateRealTime_ptr;
            static GetAccurateRealTime_method() {
                GetAccurateRealTime_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetAccurateRealTime");
            }

            internal static unsafe (int, float) Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetAccurateRealTime_ptr, new IntPtr(p)); ;
                return (*((int*)(b+8)),*((float*)(b+12)));
            }
        }
        internal struct GetActorArrayAverageLocation_method {
            static internal IntPtr GetActorArrayAverageLocation_ptr;
            static GetActorArrayAverageLocation_method() {
                GetActorArrayAverageLocation_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetActorArrayAverageLocation");
            }

            internal static unsafe Vector Invoke(byte Actors /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray Actors
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetActorArrayAverageLocation_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Actors
                return *((Vector*)(b+16));
            }
        }
        internal struct GetActorArrayBounds_method {
            static internal IntPtr GetActorArrayBounds_ptr;
            static GetActorArrayBounds_method() {
                GetActorArrayBounds_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetActorArrayBounds");
            }

            internal static unsafe (Vector, Vector) Invoke(byte Actors /*TODO: array TArray */, bool bOnlyCollidingComponents) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray Actors
                *((bool*)(b+16)) = bOnlyCollidingComponents;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetActorArrayBounds_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Actors
                return (*((Vector*)(b+20)),*((Vector*)(b+32)));
            }
        }
        internal struct GetAllActorsOfClass_method {
            static internal IntPtr GetAllActorsOfClass_ptr;
            static GetAllActorsOfClass_method() {
                GetAllActorsOfClass_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetAllActorsOfClass");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(UObject WorldContextObject, SubclassOf<Actor> ActorClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = ActorClass;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetAllActorsOfClass_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutActors
                return UObject.ToUObjectCollection<Actor>(b+16);
            }
        }
        internal struct GetAllActorsWithInterface_method {
            static internal IntPtr GetAllActorsWithInterface_ptr;
            static GetAllActorsWithInterface_method() {
                GetAllActorsWithInterface_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetAllActorsWithInterface");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(UObject WorldContextObject, SubclassOf<Interface> Interface) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Interface;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetAllActorsWithInterface_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutActors
                return UObject.ToUObjectCollection<Actor>(b+16);
            }
        }
        internal struct GetAllActorsWithTag_method {
            static internal IntPtr GetAllActorsWithTag_ptr;
            static GetAllActorsWithTag_method() {
                GetAllActorsWithTag_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetAllActorsWithTag");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(UObject WorldContextObject, Name Tag) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Name*)(b+8)) = Tag;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetAllActorsWithTag_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutActors
                return UObject.ToUObjectCollection<Actor>(b+24);
            }
        }
        internal struct GetAudioTimeSeconds_method {
            static internal IntPtr GetAudioTimeSeconds_ptr;
            static GetAudioTimeSeconds_method() {
                GetAudioTimeSeconds_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetAudioTimeSeconds");
            }

            internal static unsafe float Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetAudioTimeSeconds_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetCurrentLevelName_method {
            static internal IntPtr GetCurrentLevelName_ptr;
            static GetCurrentLevelName_method() {
                GetCurrentLevelName_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetCurrentLevelName");
            }

            internal static unsafe string Invoke(UObject WorldContextObject, bool bRemovePrefixString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((bool*)(b+8)) = bRemovePrefixString;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetCurrentLevelName_ptr, new IntPtr(p)); ;
                return FString.Get(b+16);
            }
        }
        internal struct GetCurrentReverbEffect_method {
            static internal IntPtr GetCurrentReverbEffect_ptr;
            static GetCurrentReverbEffect_method() {
                GetCurrentReverbEffect_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetCurrentReverbEffect");
            }

            internal static unsafe ReverbEffect Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetCurrentReverbEffect_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetEnableWorldRendering_method {
            static internal IntPtr GetEnableWorldRendering_ptr;
            static GetEnableWorldRendering_method() {
                GetEnableWorldRendering_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetEnableWorldRendering");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetEnableWorldRendering_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct GetGameInstance_method {
            static internal IntPtr GetGameInstance_ptr;
            static GetGameInstance_method() {
                GetGameInstance_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetGameInstance");
            }

            internal static unsafe GameInstance Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetGameInstance_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetGameMode_method {
            static internal IntPtr GetGameMode_ptr;
            static GetGameMode_method() {
                GetGameMode_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetGameMode");
            }

            internal static unsafe GameModeBase Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetGameMode_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetGameState_method {
            static internal IntPtr GetGameState_ptr;
            static GetGameState_method() {
                GetGameState_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetGameState");
            }

            internal static unsafe GameStateBase Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetGameState_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetGlobalTimeDilation_method {
            static internal IntPtr GetGlobalTimeDilation_ptr;
            static GetGlobalTimeDilation_method() {
                GetGlobalTimeDilation_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetGlobalTimeDilation");
            }

            internal static unsafe float Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetGlobalTimeDilation_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetIntOption_method {
            static internal IntPtr GetIntOption_ptr;
            static GetIntOption_method() {
                GetIntOption_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetIntOption");
            }

            internal static unsafe int Invoke(string Options, string Key, int DefaultValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Options_handle = GCHandle.Alloc(Options, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Options_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Options.Length;
                *(int*)(b+IntPtr.Size+4+0) = Options.Length;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Key.Length;
                *(int*)(b+IntPtr.Size+4+16) = Key.Length;
                *((int*)(b+32)) = DefaultValue;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetIntOption_ptr, new IntPtr(p)); ;
                Options_handle.Free();
                Key_handle.Free();
                return *((int*)(b+36));
            }
        }
        internal struct GetKeyValue_method {
            static internal IntPtr GetKeyValue_ptr;
            static GetKeyValue_method() {
                GetKeyValue_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetKeyValue");
            }

            internal static unsafe (string, string) Invoke(string Pair) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Pair_handle = GCHandle.Alloc(Pair, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Pair_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Pair.Length;
                *(int*)(b+IntPtr.Size+4+0) = Pair.Length;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetKeyValue_ptr, new IntPtr(p)); ;
                Pair_handle.Free();
                return (FString.Get(b+16),FString.Get(b+32));
            }
        }
        internal struct GetObjectClass_method {
            static internal IntPtr GetObjectClass_ptr;
            static GetObjectClass_method() {
                GetObjectClass_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetObjectClass");
            }

            internal static unsafe SubclassOf<UObject> Invoke(UObject UObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetObjectClass_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetPlatformName_method {
            static internal IntPtr GetPlatformName_ptr;
            static GetPlatformName_method() {
                GetPlatformName_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetPlatformName");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetPlatformName_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetPlayerCameraManager_method {
            static internal IntPtr GetPlayerCameraManager_ptr;
            static GetPlayerCameraManager_method() {
                GetPlayerCameraManager_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetPlayerCameraManager");
            }

            internal static unsafe PlayerCameraManager Invoke(UObject WorldContextObject, int PlayerIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((int*)(b+8)) = PlayerIndex;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetPlayerCameraManager_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct GetPlayerCharacter_method {
            static internal IntPtr GetPlayerCharacter_ptr;
            static GetPlayerCharacter_method() {
                GetPlayerCharacter_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetPlayerCharacter");
            }

            internal static unsafe Character Invoke(UObject WorldContextObject, int PlayerIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((int*)(b+8)) = PlayerIndex;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetPlayerCharacter_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct GetPlayerController_method {
            static internal IntPtr GetPlayerController_ptr;
            static GetPlayerController_method() {
                GetPlayerController_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetPlayerController");
            }

            internal static unsafe PlayerController Invoke(UObject WorldContextObject, int PlayerIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((int*)(b+8)) = PlayerIndex;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetPlayerController_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct GetPlayerControllerID_method {
            static internal IntPtr GetPlayerControllerID_ptr;
            static GetPlayerControllerID_method() {
                GetPlayerControllerID_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetPlayerControllerID");
            }

            internal static unsafe int Invoke(PlayerController Player) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Player;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetPlayerControllerID_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetPlayerPawn_method {
            static internal IntPtr GetPlayerPawn_ptr;
            static GetPlayerPawn_method() {
                GetPlayerPawn_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetPlayerPawn");
            }

            internal static unsafe Pawn Invoke(UObject WorldContextObject, int PlayerIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((int*)(b+8)) = PlayerIndex;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetPlayerPawn_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct GetRealTimeSeconds_method {
            static internal IntPtr GetRealTimeSeconds_ptr;
            static GetRealTimeSeconds_method() {
                GetRealTimeSeconds_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetRealTimeSeconds");
            }

            internal static unsafe float Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetRealTimeSeconds_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetStreamingLevel_method {
            static internal IntPtr GetStreamingLevel_ptr;
            static GetStreamingLevel_method() {
                GetStreamingLevel_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetStreamingLevel");
            }

            internal static unsafe LevelStreaming Invoke(UObject WorldContextObject, Name PackageName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Name*)(b+8)) = PackageName;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetStreamingLevel_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+24));
            }
        }
        internal struct GetSurfaceType_method {
            static internal IntPtr GetSurfaceType_ptr;
            static GetSurfaceType_method() {
                GetSurfaceType_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetSurfaceType");
            }

            internal static unsafe byte Invoke(HitResult Hit) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((HitResult*)(b+0)) = Hit;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetSurfaceType_ptr, new IntPtr(p)); ;
                return *(b+144);
            }
        }
        internal struct GetTimeSeconds_method {
            static internal IntPtr GetTimeSeconds_ptr;
            static GetTimeSeconds_method() {
                GetTimeSeconds_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetTimeSeconds");
            }

            internal static unsafe float Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetTimeSeconds_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetUnpausedTimeSeconds_method {
            static internal IntPtr GetUnpausedTimeSeconds_ptr;
            static GetUnpausedTimeSeconds_method() {
                GetUnpausedTimeSeconds_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetUnpausedTimeSeconds");
            }

            internal static unsafe float Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetUnpausedTimeSeconds_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetWorldDeltaSeconds_method {
            static internal IntPtr GetWorldDeltaSeconds_ptr;
            static GetWorldDeltaSeconds_method() {
                GetWorldDeltaSeconds_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetWorldDeltaSeconds");
            }

            internal static unsafe float Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetWorldDeltaSeconds_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetWorldOriginLocation_method {
            static internal IntPtr GetWorldOriginLocation_ptr;
            static GetWorldOriginLocation_method() {
                GetWorldOriginLocation_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GetWorldOriginLocation");
            }

            internal static unsafe IntVector Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GetWorldOriginLocation_ptr, new IntPtr(p)); ;
                return *((IntVector*)(b+8));
            }
        }
        internal struct GrassOverlappingSphereCount_method {
            static internal IntPtr GrassOverlappingSphereCount_ptr;
            static GrassOverlappingSphereCount_method() {
                GrassOverlappingSphereCount_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "GrassOverlappingSphereCount");
            }

            internal static unsafe int Invoke(UObject WorldContextObject, StaticMesh StaticMesh, Vector CenterPosition, float Radius) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = StaticMesh;
                *((Vector*)(b+16)) = CenterPosition;
                *((float*)(b+28)) = Radius;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, GrassOverlappingSphereCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+32));
            }
        }
        internal struct HasLaunchOption_method {
            static internal IntPtr HasLaunchOption_ptr;
            static HasLaunchOption_method() {
                HasLaunchOption_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "HasLaunchOption");
            }

            internal static unsafe bool Invoke(string OptionToCheck) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var OptionToCheck_handle = GCHandle.Alloc(OptionToCheck, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = OptionToCheck_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = OptionToCheck.Length;
                *(int*)(b+IntPtr.Size+4+0) = OptionToCheck.Length;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, HasLaunchOption_ptr, new IntPtr(p)); ;
                OptionToCheck_handle.Free();
                return *((bool*)(b+16));
            }
        }
        internal struct HasOption_method {
            static internal IntPtr HasOption_ptr;
            static HasOption_method() {
                HasOption_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "HasOption");
            }

            internal static unsafe bool Invoke(string Options, string InKey) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Options_handle = GCHandle.Alloc(Options, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Options_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Options.Length;
                *(int*)(b+IntPtr.Size+4+0) = Options.Length;
                var InKey_handle = GCHandle.Alloc(InKey, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = InKey_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = InKey.Length;
                *(int*)(b+IntPtr.Size+4+16) = InKey.Length;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, HasOption_ptr, new IntPtr(p)); ;
                Options_handle.Free();
                InKey_handle.Free();
                return *((bool*)(b+32));
            }
        }
        internal struct IsGamePaused_method {
            static internal IntPtr IsGamePaused_ptr;
            static IsGamePaused_method() {
                IsGamePaused_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "IsGamePaused");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, IsGamePaused_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct LoadGameFromSlot_method {
            static internal IntPtr LoadGameFromSlot_ptr;
            static LoadGameFromSlot_method() {
                LoadGameFromSlot_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "LoadGameFromSlot");
            }

            internal static unsafe SaveGame Invoke(string SlotName, int UserIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SlotName_handle = GCHandle.Alloc(SlotName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SlotName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SlotName.Length;
                *(int*)(b+IntPtr.Size+4+0) = SlotName.Length;
                *((int*)(b+16)) = UserIndex;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, LoadGameFromSlot_ptr, new IntPtr(p)); ;
                SlotName_handle.Free();
                return *((IntPtr*)(b+24));
            }
        }
        internal struct LoadStreamLevel_method {
            static internal IntPtr LoadStreamLevel_ptr;
            static LoadStreamLevel_method() {
                LoadStreamLevel_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "LoadStreamLevel");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Name LevelName, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad, LatentActionInfo LatentInfo) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Name*)(b+8)) = LevelName;
                *((bool*)(b+20)) = bMakeVisibleAfterLoad;
                *((bool*)(b+21)) = bShouldBlockOnLoad;
                *((LatentActionInfo*)(b+24)) = LatentInfo;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, LoadStreamLevel_ptr, new IntPtr(p)); ;
            }
        }
        internal struct MakeHitResult_method {
            static internal IntPtr MakeHitResult_ptr;
            static MakeHitResult_method() {
                MakeHitResult_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "MakeHitResult");
            }

            internal static unsafe HitResult Invoke(bool bBlockingHit, bool bInitialOverlap, float Time, float Distance, Vector Location, Vector ImpactPoint, Vector Normal, Vector ImpactNormal, PhysicalMaterial PhysMat, Actor HitActor, PrimitiveComponent HitComponent, Name HitBoneName, int HitItem, int FaceIndex, Vector TraceStart, Vector TraceEnd) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bBlockingHit;
                *((bool*)(b+1)) = bInitialOverlap;
                *((float*)(b+4)) = Time;
                *((float*)(b+8)) = Distance;
                *((Vector*)(b+12)) = Location;
                *((Vector*)(b+24)) = ImpactPoint;
                *((Vector*)(b+36)) = Normal;
                *((Vector*)(b+48)) = ImpactNormal;
                *((IntPtr*)(b+64)) = PhysMat;
                *((IntPtr*)(b+72)) = HitActor;
                *((IntPtr*)(b+80)) = HitComponent;
                *((Name*)(b+88)) = HitBoneName;
                *((int*)(b+100)) = HitItem;
                *((int*)(b+104)) = FaceIndex;
                *((Vector*)(b+108)) = TraceStart;
                *((Vector*)(b+120)) = TraceEnd;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, MakeHitResult_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+132));
            }
        }
        internal struct OpenLevel_method {
            static internal IntPtr OpenLevel_ptr;
            static OpenLevel_method() {
                OpenLevel_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "OpenLevel");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Name LevelName, bool bAbsolute, string Options) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Name*)(b+8)) = LevelName;
                *((bool*)(b+20)) = bAbsolute;
                var Options_handle = GCHandle.Alloc(Options, GCHandleType.Pinned);
                *(IntPtr*)(b+24) = Options_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+24) = Options.Length;
                *(int*)(b+IntPtr.Size+4+24) = Options.Length;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, OpenLevel_ptr, new IntPtr(p)); ;
                Options_handle.Free();
            }
        }
        internal struct ParseOption_method {
            static internal IntPtr ParseOption_ptr;
            static ParseOption_method() {
                ParseOption_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "ParseOption");
            }

            internal static unsafe string Invoke(string Options, string Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Options_handle = GCHandle.Alloc(Options, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Options_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Options.Length;
                *(int*)(b+IntPtr.Size+4+0) = Options.Length;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Key.Length;
                *(int*)(b+IntPtr.Size+4+16) = Key.Length;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, ParseOption_ptr, new IntPtr(p)); ;
                Options_handle.Free();
                Key_handle.Free();
                return FString.Get(b+32);
            }
        }
        internal struct PlayDialogue2D_method {
            static internal IntPtr PlayDialogue2D_ptr;
            static PlayDialogue2D_method() {
                PlayDialogue2D_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "PlayDialogue2D");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, DialogueWave Dialogue, DialogueContext Context, float VolumeMultiplier, float PitchMultiplier, float StartTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Dialogue;
                *((DialogueContext*)(b+16)) = Context;
                *((float*)(b+40)) = VolumeMultiplier;
                *((float*)(b+44)) = PitchMultiplier;
                *((float*)(b+48)) = StartTime;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, PlayDialogue2D_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlayDialogueAtLocation_method {
            static internal IntPtr PlayDialogueAtLocation_ptr;
            static PlayDialogueAtLocation_method() {
                PlayDialogueAtLocation_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "PlayDialogueAtLocation");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, DialogueWave Dialogue, DialogueContext Context, Vector Location, Rotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundAttenuation AttenuationSettings) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Dialogue;
                *((DialogueContext*)(b+16)) = Context;
                *((Vector*)(b+40)) = Location;
                *((Rotator*)(b+52)) = Rotation;
                *((float*)(b+64)) = VolumeMultiplier;
                *((float*)(b+68)) = PitchMultiplier;
                *((float*)(b+72)) = StartTime;
                *((IntPtr*)(b+80)) = AttenuationSettings;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, PlayDialogueAtLocation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlaySound2D_method {
            static internal IntPtr PlaySound2D_ptr;
            static PlaySound2D_method() {
                PlaySound2D_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "PlaySound2D");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, SoundBase Sound, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundConcurrency ConcurrencySettings, Actor OwningActor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Sound;
                *((float*)(b+16)) = VolumeMultiplier;
                *((float*)(b+20)) = PitchMultiplier;
                *((float*)(b+24)) = StartTime;
                *((IntPtr*)(b+32)) = ConcurrencySettings;
                *((IntPtr*)(b+40)) = OwningActor;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, PlaySound2D_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlaySoundAtLocation_method {
            static internal IntPtr PlaySoundAtLocation_ptr;
            static PlaySoundAtLocation_method() {
                PlaySoundAtLocation_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "PlaySoundAtLocation");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, SoundBase Sound, Vector Location, Rotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundAttenuation AttenuationSettings, SoundConcurrency ConcurrencySettings, Actor OwningActor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Sound;
                *((Vector*)(b+16)) = Location;
                *((Rotator*)(b+28)) = Rotation;
                *((float*)(b+40)) = VolumeMultiplier;
                *((float*)(b+44)) = PitchMultiplier;
                *((float*)(b+48)) = StartTime;
                *((IntPtr*)(b+56)) = AttenuationSettings;
                *((IntPtr*)(b+64)) = ConcurrencySettings;
                *((IntPtr*)(b+72)) = OwningActor;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, PlaySoundAtLocation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlayWorldCameraShake_method {
            static internal IntPtr PlayWorldCameraShake_ptr;
            static PlayWorldCameraShake_method() {
                PlayWorldCameraShake_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "PlayWorldCameraShake");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, SubclassOf<CameraShake> Shake, Vector Epicenter, float InnerRadius, float OuterRadius, float Falloff, bool bOrientShakeTowardsEpicenter) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Shake;
                *((Vector*)(b+16)) = Epicenter;
                *((float*)(b+28)) = InnerRadius;
                *((float*)(b+32)) = OuterRadius;
                *((float*)(b+36)) = Falloff;
                *((bool*)(b+40)) = bOrientShakeTowardsEpicenter;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, PlayWorldCameraShake_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PopSoundMixModifier_method {
            static internal IntPtr PopSoundMixModifier_ptr;
            static PopSoundMixModifier_method() {
                PopSoundMixModifier_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "PopSoundMixModifier");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, SoundMix InSoundMixModifier) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = InSoundMixModifier;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, PopSoundMixModifier_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ProjectWorldToScreen_method {
            static internal IntPtr ProjectWorldToScreen_ptr;
            static ProjectWorldToScreen_method() {
                ProjectWorldToScreen_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "ProjectWorldToScreen");
            }

            internal static unsafe (Vector2D, bool) Invoke(PlayerController Player, Vector WorldPosition, bool bPlayerViewportRelative) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Player;
                *((Vector*)(b+8)) = WorldPosition;
                *((bool*)(b+28)) = bPlayerViewportRelative;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, ProjectWorldToScreen_ptr, new IntPtr(p)); ;
                return (*((Vector2D*)(b+20)),*((bool*)(b+29)));
            }
        }
        internal struct PushSoundMixModifier_method {
            static internal IntPtr PushSoundMixModifier_ptr;
            static PushSoundMixModifier_method() {
                PushSoundMixModifier_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "PushSoundMixModifier");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, SoundMix InSoundMixModifier) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = InSoundMixModifier;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, PushSoundMixModifier_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RebaseLocalOriginOntoZero_method {
            static internal IntPtr RebaseLocalOriginOntoZero_ptr;
            static RebaseLocalOriginOntoZero_method() {
                RebaseLocalOriginOntoZero_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "RebaseLocalOriginOntoZero");
            }

            internal static unsafe Vector Invoke(UObject WorldContextObject, Vector WorldLocation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = WorldLocation;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, RebaseLocalOriginOntoZero_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+20));
            }
        }
        internal struct RebaseZeroOriginOntoLocal_method {
            static internal IntPtr RebaseZeroOriginOntoLocal_ptr;
            static RebaseZeroOriginOntoLocal_method() {
                RebaseZeroOriginOntoLocal_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "RebaseZeroOriginOntoLocal");
            }

            internal static unsafe Vector Invoke(UObject WorldContextObject, Vector WorldLocation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = WorldLocation;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, RebaseZeroOriginOntoLocal_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+20));
            }
        }
        internal struct RemovePlayer_method {
            static internal IntPtr RemovePlayer_ptr;
            static RemovePlayer_method() {
                RemovePlayer_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "RemovePlayer");
            }

            internal static unsafe void Invoke(PlayerController Player, bool bDestroyPawn) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Player;
                *((bool*)(b+8)) = bDestroyPawn;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, RemovePlayer_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SaveGameToSlot_method {
            static internal IntPtr SaveGameToSlot_ptr;
            static SaveGameToSlot_method() {
                SaveGameToSlot_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SaveGameToSlot");
            }

            internal static unsafe bool Invoke(SaveGame SaveGameObject, string SlotName, int UserIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SaveGameObject;
                var SlotName_handle = GCHandle.Alloc(SlotName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = SlotName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = SlotName.Length;
                *(int*)(b+IntPtr.Size+4+8) = SlotName.Length;
                *((int*)(b+24)) = UserIndex;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SaveGameToSlot_ptr, new IntPtr(p)); ;
                SlotName_handle.Free();
                return *((bool*)(b+28));
            }
        }
        internal struct SetBaseSoundMix_method {
            static internal IntPtr SetBaseSoundMix_ptr;
            static SetBaseSoundMix_method() {
                SetBaseSoundMix_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SetBaseSoundMix");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, SoundMix InSoundMix) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = InSoundMix;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SetBaseSoundMix_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEnableWorldRendering_method {
            static internal IntPtr SetEnableWorldRendering_ptr;
            static SetEnableWorldRendering_method() {
                SetEnableWorldRendering_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SetEnableWorldRendering");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, bool bEnable) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((bool*)(b+8)) = bEnable;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SetEnableWorldRendering_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetGamePaused_method {
            static internal IntPtr SetGamePaused_ptr;
            static SetGamePaused_method() {
                SetGamePaused_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SetGamePaused");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject, bool bPaused) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((bool*)(b+8)) = bPaused;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SetGamePaused_ptr, new IntPtr(p)); ;
                return *((bool*)(b+9));
            }
        }
        internal struct SetGlobalListenerFocusParameters_method {
            static internal IntPtr SetGlobalListenerFocusParameters_ptr;
            static SetGlobalListenerFocusParameters_method() {
                SetGlobalListenerFocusParameters_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SetGlobalListenerFocusParameters");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, float FocusAzimuthScale, float NonFocusAzimuthScale, float FocusDistanceScale, float NonFocusDistanceScale, float FocusVolumeScale, float NonFocusVolumeScale, float FocusPriorityScale, float NonFocusPriorityScale) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((float*)(b+8)) = FocusAzimuthScale;
                *((float*)(b+12)) = NonFocusAzimuthScale;
                *((float*)(b+16)) = FocusDistanceScale;
                *((float*)(b+20)) = NonFocusDistanceScale;
                *((float*)(b+24)) = FocusVolumeScale;
                *((float*)(b+28)) = NonFocusVolumeScale;
                *((float*)(b+32)) = FocusPriorityScale;
                *((float*)(b+36)) = NonFocusPriorityScale;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SetGlobalListenerFocusParameters_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetGlobalPitchModulation_method {
            static internal IntPtr SetGlobalPitchModulation_ptr;
            static SetGlobalPitchModulation_method() {
                SetGlobalPitchModulation_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SetGlobalPitchModulation");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, float PitchModulation, float TimeSec) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((float*)(b+8)) = PitchModulation;
                *((float*)(b+12)) = TimeSec;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SetGlobalPitchModulation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetGlobalTimeDilation_method {
            static internal IntPtr SetGlobalTimeDilation_ptr;
            static SetGlobalTimeDilation_method() {
                SetGlobalTimeDilation_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SetGlobalTimeDilation");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, float TimeDilation) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((float*)(b+8)) = TimeDilation;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SetGlobalTimeDilation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlayerControllerID_method {
            static internal IntPtr SetPlayerControllerID_ptr;
            static SetPlayerControllerID_method() {
                SetPlayerControllerID_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SetPlayerControllerID");
            }

            internal static unsafe void Invoke(PlayerController Player, int ControllerId) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Player;
                *((int*)(b+8)) = ControllerId;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SetPlayerControllerID_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSoundMixClassOverride_method {
            static internal IntPtr SetSoundMixClassOverride_ptr;
            static SetSoundMixClassOverride_method() {
                SetSoundMixClassOverride_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SetSoundMixClassOverride");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, SoundMix InSoundMixModifier, SoundClass InSoundClass, float Volume, float Pitch, float FadeInTime, bool bApplyToChildren) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = InSoundMixModifier;
                *((IntPtr*)(b+16)) = InSoundClass;
                *((float*)(b+24)) = Volume;
                *((float*)(b+28)) = Pitch;
                *((float*)(b+32)) = FadeInTime;
                *((bool*)(b+36)) = bApplyToChildren;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SetSoundMixClassOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSubtitlesEnabled_method {
            static internal IntPtr SetSubtitlesEnabled_ptr;
            static SetSubtitlesEnabled_method() {
                SetSubtitlesEnabled_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SetSubtitlesEnabled");
            }

            internal static unsafe void Invoke(bool bEnabled) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnabled;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SetSubtitlesEnabled_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetWorldOriginLocation_method {
            static internal IntPtr SetWorldOriginLocation_ptr;
            static SetWorldOriginLocation_method() {
                SetWorldOriginLocation_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SetWorldOriginLocation");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, IntVector NewLocation) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntVector*)(b+8)) = NewLocation;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SetWorldOriginLocation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SpawnDecalAtLocation_method {
            static internal IntPtr SpawnDecalAtLocation_ptr;
            static SpawnDecalAtLocation_method() {
                SpawnDecalAtLocation_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SpawnDecalAtLocation");
            }

            internal static unsafe DecalComponent Invoke(UObject WorldContextObject, MaterialInterface DecalMaterial, Vector DecalSize, Vector Location, Rotator Rotation, float LifeSpan) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = DecalMaterial;
                *((Vector*)(b+16)) = DecalSize;
                *((Vector*)(b+28)) = Location;
                *((Rotator*)(b+40)) = Rotation;
                *((float*)(b+52)) = LifeSpan;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SpawnDecalAtLocation_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+56));
            }
        }
        internal struct SpawnDecalAttached_method {
            static internal IntPtr SpawnDecalAttached_ptr;
            static SpawnDecalAttached_method() {
                SpawnDecalAttached_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SpawnDecalAttached");
            }

            internal static unsafe DecalComponent Invoke(MaterialInterface DecalMaterial, Vector DecalSize, SceneComponent AttachToComponent, Name AttachPointName, Vector Location, Rotator Rotation, byte LocationType, float LifeSpan) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = DecalMaterial;
                *((Vector*)(b+8)) = DecalSize;
                *((IntPtr*)(b+24)) = AttachToComponent;
                *((Name*)(b+32)) = AttachPointName;
                *((Vector*)(b+44)) = Location;
                *((Rotator*)(b+56)) = Rotation;
                *(b+68) = LocationType;
                *((float*)(b+72)) = LifeSpan;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SpawnDecalAttached_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+80));
            }
        }
        internal struct SpawnDialogue2D_method {
            static internal IntPtr SpawnDialogue2D_ptr;
            static SpawnDialogue2D_method() {
                SpawnDialogue2D_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SpawnDialogue2D");
            }

            internal static unsafe AudioComponent Invoke(UObject WorldContextObject, DialogueWave Dialogue, DialogueContext Context, float VolumeMultiplier, float PitchMultiplier, float StartTime, bool bAutoDestroy) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Dialogue;
                *((DialogueContext*)(b+16)) = Context;
                *((float*)(b+40)) = VolumeMultiplier;
                *((float*)(b+44)) = PitchMultiplier;
                *((float*)(b+48)) = StartTime;
                *((bool*)(b+52)) = bAutoDestroy;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SpawnDialogue2D_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+56));
            }
        }
        internal struct SpawnDialogueAtLocation_method {
            static internal IntPtr SpawnDialogueAtLocation_ptr;
            static SpawnDialogueAtLocation_method() {
                SpawnDialogueAtLocation_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SpawnDialogueAtLocation");
            }

            internal static unsafe AudioComponent Invoke(UObject WorldContextObject, DialogueWave Dialogue, DialogueContext Context, Vector Location, Rotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundAttenuation AttenuationSettings, bool bAutoDestroy) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Dialogue;
                *((DialogueContext*)(b+16)) = Context;
                *((Vector*)(b+40)) = Location;
                *((Rotator*)(b+52)) = Rotation;
                *((float*)(b+64)) = VolumeMultiplier;
                *((float*)(b+68)) = PitchMultiplier;
                *((float*)(b+72)) = StartTime;
                *((IntPtr*)(b+80)) = AttenuationSettings;
                *((bool*)(b+88)) = bAutoDestroy;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SpawnDialogueAtLocation_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+96));
            }
        }
        internal struct SpawnDialogueAttached_method {
            static internal IntPtr SpawnDialogueAttached_ptr;
            static SpawnDialogueAttached_method() {
                SpawnDialogueAttached_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SpawnDialogueAttached");
            }

            internal static unsafe AudioComponent Invoke(DialogueWave Dialogue, DialogueContext Context, SceneComponent AttachToComponent, Name AttachPointName, Vector Location, Rotator Rotation, byte LocationType, bool bStopWhenAttachedToDestroyed, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundAttenuation AttenuationSettings, bool bAutoDestroy) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Dialogue;
                *((DialogueContext*)(b+8)) = Context;
                *((IntPtr*)(b+32)) = AttachToComponent;
                *((Name*)(b+40)) = AttachPointName;
                *((Vector*)(b+52)) = Location;
                *((Rotator*)(b+64)) = Rotation;
                *(b+76) = LocationType;
                *((bool*)(b+77)) = bStopWhenAttachedToDestroyed;
                *((float*)(b+80)) = VolumeMultiplier;
                *((float*)(b+84)) = PitchMultiplier;
                *((float*)(b+88)) = StartTime;
                *((IntPtr*)(b+96)) = AttenuationSettings;
                *((bool*)(b+104)) = bAutoDestroy;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SpawnDialogueAttached_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+112));
            }
        }
        internal struct SpawnEmitterAtLocation_method {
            static internal IntPtr SpawnEmitterAtLocation_ptr;
            static SpawnEmitterAtLocation_method() {
                SpawnEmitterAtLocation_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SpawnEmitterAtLocation");
            }

            internal static unsafe ParticleSystemComponent Invoke(UObject WorldContextObject, ParticleSystem EmitterTemplate, Vector Location, Rotator Rotation, Vector Scale, bool bAutoDestroy, EPSCPoolMethod PoolingMethod) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = EmitterTemplate;
                *((Vector*)(b+16)) = Location;
                *((Rotator*)(b+28)) = Rotation;
                *((Vector*)(b+40)) = Scale;
                *((bool*)(b+52)) = bAutoDestroy;
                *(b+53) = (byte)PoolingMethod;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SpawnEmitterAtLocation_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+56));
            }
        }
        internal struct SpawnEmitterAttached_method {
            static internal IntPtr SpawnEmitterAttached_ptr;
            static SpawnEmitterAttached_method() {
                SpawnEmitterAttached_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SpawnEmitterAttached");
            }

            internal static unsafe ParticleSystemComponent Invoke(ParticleSystem EmitterTemplate, SceneComponent AttachToComponent, Name AttachPointName, Vector Location, Rotator Rotation, Vector Scale, byte LocationType, bool bAutoDestroy, EPSCPoolMethod PoolingMethod) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = EmitterTemplate;
                *((IntPtr*)(b+8)) = AttachToComponent;
                *((Name*)(b+16)) = AttachPointName;
                *((Vector*)(b+28)) = Location;
                *((Rotator*)(b+40)) = Rotation;
                *((Vector*)(b+52)) = Scale;
                *(b+64) = LocationType;
                *((bool*)(b+65)) = bAutoDestroy;
                *(b+66) = (byte)PoolingMethod;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SpawnEmitterAttached_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+72));
            }
        }
        internal struct SpawnForceFeedbackAtLocation_method {
            static internal IntPtr SpawnForceFeedbackAtLocation_ptr;
            static SpawnForceFeedbackAtLocation_method() {
                SpawnForceFeedbackAtLocation_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SpawnForceFeedbackAtLocation");
            }

            internal static unsafe ForceFeedbackComponent Invoke(UObject WorldContextObject, ForceFeedbackEffect ForceFeedbackEffect, Vector Location, Rotator Rotation, bool bLooping, float IntensityMultiplier, float StartTime, ForceFeedbackAttenuation AttenuationSettings, bool bAutoDestroy) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = ForceFeedbackEffect;
                *((Vector*)(b+16)) = Location;
                *((Rotator*)(b+28)) = Rotation;
                *((bool*)(b+40)) = bLooping;
                *((float*)(b+44)) = IntensityMultiplier;
                *((float*)(b+48)) = StartTime;
                *((IntPtr*)(b+56)) = AttenuationSettings;
                *((bool*)(b+64)) = bAutoDestroy;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SpawnForceFeedbackAtLocation_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+72));
            }
        }
        internal struct SpawnForceFeedbackAttached_method {
            static internal IntPtr SpawnForceFeedbackAttached_ptr;
            static SpawnForceFeedbackAttached_method() {
                SpawnForceFeedbackAttached_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SpawnForceFeedbackAttached");
            }

            internal static unsafe ForceFeedbackComponent Invoke(ForceFeedbackEffect ForceFeedbackEffect, SceneComponent AttachToComponent, Name AttachPointName, Vector Location, Rotator Rotation, byte LocationType, bool bStopWhenAttachedToDestroyed, bool bLooping, float IntensityMultiplier, float StartTime, ForceFeedbackAttenuation AttenuationSettings, bool bAutoDestroy) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ForceFeedbackEffect;
                *((IntPtr*)(b+8)) = AttachToComponent;
                *((Name*)(b+16)) = AttachPointName;
                *((Vector*)(b+28)) = Location;
                *((Rotator*)(b+40)) = Rotation;
                *(b+52) = LocationType;
                *((bool*)(b+53)) = bStopWhenAttachedToDestroyed;
                *((bool*)(b+54)) = bLooping;
                *((float*)(b+56)) = IntensityMultiplier;
                *((float*)(b+60)) = StartTime;
                *((IntPtr*)(b+64)) = AttenuationSettings;
                *((bool*)(b+72)) = bAutoDestroy;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SpawnForceFeedbackAttached_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+80));
            }
        }
        internal struct SpawnObject_method {
            static internal IntPtr SpawnObject_ptr;
            static SpawnObject_method() {
                SpawnObject_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SpawnObject");
            }

            internal static unsafe UObject Invoke(SubclassOf<UObject> ObjectClass, UObject Outer) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ObjectClass;
                *((IntPtr*)(b+8)) = Outer;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SpawnObject_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct SpawnSound2D_method {
            static internal IntPtr SpawnSound2D_ptr;
            static SpawnSound2D_method() {
                SpawnSound2D_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SpawnSound2D");
            }

            internal static unsafe AudioComponent Invoke(UObject WorldContextObject, SoundBase Sound, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundConcurrency ConcurrencySettings, bool bPersistAcrossLevelTransition, bool bAutoDestroy) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Sound;
                *((float*)(b+16)) = VolumeMultiplier;
                *((float*)(b+20)) = PitchMultiplier;
                *((float*)(b+24)) = StartTime;
                *((IntPtr*)(b+32)) = ConcurrencySettings;
                *((bool*)(b+40)) = bPersistAcrossLevelTransition;
                *((bool*)(b+41)) = bAutoDestroy;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SpawnSound2D_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+48));
            }
        }
        internal struct SpawnSoundAtLocation_method {
            static internal IntPtr SpawnSoundAtLocation_ptr;
            static SpawnSoundAtLocation_method() {
                SpawnSoundAtLocation_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SpawnSoundAtLocation");
            }

            internal static unsafe AudioComponent Invoke(UObject WorldContextObject, SoundBase Sound, Vector Location, Rotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundAttenuation AttenuationSettings, SoundConcurrency ConcurrencySettings, bool bAutoDestroy) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Sound;
                *((Vector*)(b+16)) = Location;
                *((Rotator*)(b+28)) = Rotation;
                *((float*)(b+40)) = VolumeMultiplier;
                *((float*)(b+44)) = PitchMultiplier;
                *((float*)(b+48)) = StartTime;
                *((IntPtr*)(b+56)) = AttenuationSettings;
                *((IntPtr*)(b+64)) = ConcurrencySettings;
                *((bool*)(b+72)) = bAutoDestroy;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SpawnSoundAtLocation_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+80));
            }
        }
        internal struct SpawnSoundAttached_method {
            static internal IntPtr SpawnSoundAttached_ptr;
            static SpawnSoundAttached_method() {
                SpawnSoundAttached_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SpawnSoundAttached");
            }

            internal static unsafe AudioComponent Invoke(SoundBase Sound, SceneComponent AttachToComponent, Name AttachPointName, Vector Location, Rotator Rotation, byte LocationType, bool bStopWhenAttachedToDestroyed, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundAttenuation AttenuationSettings, SoundConcurrency ConcurrencySettings, bool bAutoDestroy) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Sound;
                *((IntPtr*)(b+8)) = AttachToComponent;
                *((Name*)(b+16)) = AttachPointName;
                *((Vector*)(b+28)) = Location;
                *((Rotator*)(b+40)) = Rotation;
                *(b+52) = LocationType;
                *((bool*)(b+53)) = bStopWhenAttachedToDestroyed;
                *((float*)(b+56)) = VolumeMultiplier;
                *((float*)(b+60)) = PitchMultiplier;
                *((float*)(b+64)) = StartTime;
                *((IntPtr*)(b+72)) = AttenuationSettings;
                *((IntPtr*)(b+80)) = ConcurrencySettings;
                *((bool*)(b+88)) = bAutoDestroy;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SpawnSoundAttached_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+96));
            }
        }
        internal struct SuggestProjectileVelocity_CustomArc_method {
            static internal IntPtr SuggestProjectileVelocity_CustomArc_ptr;
            static SuggestProjectileVelocity_CustomArc_method() {
                SuggestProjectileVelocity_CustomArc_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "SuggestProjectileVelocity_CustomArc");
            }

            internal static unsafe (Vector, bool) Invoke(UObject WorldContextObject, Vector StartPos, Vector EndPos, float OverrideGravityZ, float ArcParam) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+20)) = StartPos;
                *((Vector*)(b+32)) = EndPos;
                *((float*)(b+44)) = OverrideGravityZ;
                *((float*)(b+48)) = ArcParam;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, SuggestProjectileVelocity_CustomArc_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+8)),*((bool*)(b+52)));
            }
        }
        internal struct UnloadStreamLevel_method {
            static internal IntPtr UnloadStreamLevel_ptr;
            static UnloadStreamLevel_method() {
                UnloadStreamLevel_ptr = Main.GetMethodUFunction(GameplayStatics.StaticClass, "UnloadStreamLevel");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Name LevelName, LatentActionInfo LatentInfo, bool bShouldBlockOnUnload) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Name*)(b+8)) = LevelName;
                *((LatentActionInfo*)(b+24)) = LatentInfo;
                *((bool*)(b+56)) = bShouldBlockOnUnload;
                Main.GetProcessEvent(GameplayStatics.DefaultObject, UnloadStreamLevel_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct GameplayStatics_events {
    }
}

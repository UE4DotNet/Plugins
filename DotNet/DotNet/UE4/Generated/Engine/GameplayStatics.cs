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
    ///<summary>Gameplay Statics</summary>
    public unsafe partial class GameplayStatics : BlueprintFunctionLibrary  {

        ///<summary>
        ///Activates a Reverb Effect without the need for a volume
        ///@
        ///</summary>
        ///<remarks>
        ///param ReverbEffect Reverb Effect to use
        ///@param TagName Tag to associate with Reverb Effect
        ///@param Priority Priority of the Reverb Effect
        ///@param Volume Volume level of Reverb Effect
        ///@param FadeTime Time before Reverb Effect is fully active
        ///</remarks>
        public static void ActivateReverbEffect(UObject WorldContextObject, ReverbEffect ReverbEffect, Name TagName, float Priority, float Volume, float FadeTime)  => 
            GameplayStatics_methods.ActivateReverbEffect_method.Invoke(WorldContextObject, ReverbEffect, TagName, Priority, Volume, FadeTime);

        ///<summary>Hurts the specified actor with generic damage.</summary>
        ///<remarks>
        ///@param DamagedActor - Actor that will be damaged.
        ///@param BaseDamage - The base damage to apply.
        ///@param EventInstigator - Controller that was responsible for causing this damage (e.g. player who shot the weapon)
        ///@param DamageCauser - Actor that actually caused the damage (e.g. the grenade that exploded)
        ///@param DamageTypeClass - Class that describes the damage that was done.
        ///@return Actual damage the ended up being applied to the actor.
        ///</remarks>
        public static float ApplyDamage(Actor DamagedActor, float BaseDamage, Controller EventInstigator, Actor DamageCauser, SubclassOf<DamageType> DamageTypeClass)  => 
            GameplayStatics_methods.ApplyDamage_method.Invoke(DamagedActor, BaseDamage, EventInstigator, DamageCauser, DamageTypeClass);

        ///<summary>Hurts the specified actor with the specified impact.</summary>
        ///<remarks>
        ///@param DamagedActor - Actor that will be damaged.
        ///@param BaseDamage - The base damage to apply.
        ///@param HitFromDirection - Direction the hit came FROM
        ///@param HitInfo - Collision or trace result that describes the hit
        ///@param EventInstigator - Controller that was responsible for causing this damage (e.g. player who shot the weapon)
        ///@param DamageCauser - Actor that actually caused the damage (e.g. the grenade that exploded)
        ///@param DamageTypeClass - Class that describes the damage that was done.
        ///@return Actual damage the ended up being applied to the actor.
        ///</remarks>
        public static float ApplyPointDamage(Actor DamagedActor, float BaseDamage, Vector HitFromDirection, HitResult HitInfo, Controller EventInstigator, Actor DamageCauser, SubclassOf<DamageType> DamageTypeClass)  => 
            GameplayStatics_methods.ApplyPointDamage_method.Invoke(DamagedActor, BaseDamage, HitFromDirection, HitInfo, EventInstigator, DamageCauser, DamageTypeClass);

        ///<summary>Hurt locally authoritative actors within the radius.</summary>
        ///<remarks>
        ///Will only hit components that block the Visibility channel.
        ///@param BaseDamage - The base damage to apply, i.e. the damage at the origin.
        ///@param Origin - Epicenter of the damage area.
        ///@param DamageRadius - Radius of the damage area, from Origin
        ///@param DamageTypeClass - Class that describes the damage that was done.
        ///@param DamageCauser - Actor that actually caused the damage (e.g. the grenade that exploded).  This actor will not be damaged and it will not block damage.
        ///@param InstigatedByController - Controller that was responsible for causing this damage (e.g. player who threw the grenade)
        ///@param bFullDamage - if true, damage not scaled based on distance from Origin
        ///@param DamagePreventionChannel - Damage will not be applied to victim if there is something between the origin and the victim which blocks traces on this channel
        ///@return true if damage was applied to at least one actor.
        ///</remarks>
        public static bool ApplyRadialDamage(UObject WorldContextObject, float BaseDamage, Vector Origin, float DamageRadius, SubclassOf<DamageType> DamageTypeClass, byte IgnoreActors /*TODO: array TArray */, Actor DamageCauser, Controller InstigatedByController, bool bDoFullDamage, byte DamagePreventionChannel)  => 
            GameplayStatics_methods.ApplyRadialDamage_method.Invoke(WorldContextObject, BaseDamage, Origin, DamageRadius, DamageTypeClass, IgnoreActors, DamageCauser, InstigatedByController, bDoFullDamage, DamagePreventionChannel);

        ///<summary>Hurt locally authoritative actors within the radius.</summary>
        ///<remarks>
        ///Will only hit components that block the Visibility channel.
        ///@param BaseDamage - The base damage to apply, i.e. the damage at the origin.
        ///@param Origin - Epicenter of the damage area.
        ///@param DamageInnerRadius - Radius of the full damage area, from Origin
        ///@param DamageOuterRadius - Radius of the minimum damage area, from Origin
        ///@param DamageFalloff - Falloff exponent of damage from DamageInnerRadius to DamageOuterRadius
        ///@param DamageTypeClass - Class that describes the damage that was done.
        ///@param DamageCauser - Actor that actually caused the damage (e.g. the grenade that exploded)
        ///@param InstigatedByController - Controller that was responsible for causing this damage (e.g. player who threw the grenade)
        ///@param bFullDamage - if true, damage not scaled based on distance from Origin
        ///@param DamagePreventionChannel - Damage will not be applied to victim if there is something between the origin and the victim which blocks traces on this channel
        ///@return true if damage was applied to at least one actor.
        ///</remarks>
        public static bool ApplyRadialDamageWithFalloff(UObject WorldContextObject, float BaseDamage, float MinimumDamage, Vector Origin, float DamageInnerRadius, float DamageOuterRadius, float DamageFalloff, SubclassOf<DamageType> DamageTypeClass, byte IgnoreActors /*TODO: array TArray */, Actor DamageCauser, Controller InstigatedByController, byte DamagePreventionChannel)  => 
            GameplayStatics_methods.ApplyRadialDamageWithFalloff_method.Invoke(WorldContextObject, BaseDamage, MinimumDamage, Origin, DamageInnerRadius, DamageOuterRadius, DamageFalloff, DamageTypeClass, IgnoreActors, DamageCauser, InstigatedByController, DamagePreventionChannel);

        ///<summary>
        ///Determines if any audio listeners are within range of the specified location
        ///@
        ///</summary>
        ///<remarks>
        ///param Location              The location to potentially play a sound at
        ///@param MaximumRange  The maximum distance away from Location that a listener can be
        ///@note This will always return false if there is no audio device, or the audio device is disabled.
        ///</remarks>
        public static bool AreAnyListenersWithinRange(UObject WorldContextObject, Vector Location, float MaximumRange)  => 
            GameplayStatics_methods.AreAnyListenersWithinRange_method.Invoke(WorldContextObject, Location, MaximumRange);

        ///<summary>Returns whether or not subtitles are currently enabled.</summary>
        ///<remarks>
        ///@return true if subtitles are enabled.
        ///</remarks>
        public static bool AreSubtitlesEnabled()  => 
            GameplayStatics_methods.AreSubtitlesEnabled_method.Invoke();

        ///<summary>Spawns an instance of an actor class, but does not automatically run its construction script.</summary>
        public static Actor BeginDeferredActorSpawnFromClass(UObject WorldContextObject, SubclassOf<Actor> ActorClass, Transform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride, Actor Owner)  => 
            GameplayStatics_methods.BeginDeferredActorSpawnFromClass_method.Invoke(WorldContextObject, ActorClass, SpawnTransform, CollisionHandlingOverride, Owner);

        ///<summary>Spawns an instance of a blueprint, but does not automatically run its construction script.</summary>
        public static Actor BeginSpawningActorFromBlueprint(UObject WorldContextObject, Blueprint Blueprint, Transform SpawnTransform, bool bNoCollisionFail)  => 
            GameplayStatics_methods.BeginSpawningActorFromBlueprint_method.Invoke(WorldContextObject, Blueprint, SpawnTransform, bNoCollisionFail);

        ///<summary>Begin Spawning Actor from Class</summary>
        public static Actor BeginSpawningActorFromClass(UObject WorldContextObject, SubclassOf<Actor> ActorClass, Transform SpawnTransform, bool bNoCollisionFail, Actor Owner)  => 
            GameplayStatics_methods.BeginSpawningActorFromClass_method.Invoke(WorldContextObject, ActorClass, SpawnTransform, bNoCollisionFail, Owner);

        ///<summary>Predict the arc of a virtual projectile affected by gravity with collision checks along the arc.</summary>
        ///<remarks>
        ///Returns true if it hit something.
        ///
        ///@param PredictParams                          Input params to the trace (start location, velocity, time to simulate, etc).
        ///@param PredictResult                          Output result of the trace (Hit result, array of location/velocity/times for each trace step, etc).
        ///@return                                                       True if hit something along the path (if tracing with collision).
        ///</remarks>
        public static (PredictProjectilePathResult, bool) Blueprint_PredictProjectilePath_Advanced(UObject WorldContextObject, PredictProjectilePathParams PredictParams)  => 
            GameplayStatics_methods.Blueprint_PredictProjectilePath_Advanced_method.Invoke(WorldContextObject, PredictParams);

        ///<summary>Predict the arc of a virtual projectile affected by gravity with collision checks along the arc.</summary>
        ///<remarks>
        ///Returns a list of positions of the simulated arc and the destination reached by the simulation.
        ///Returns true if it hit something.
        ///
        ///@param OutPathPositions                       Predicted projectile path. Ordered series of positions from StartPos to the end. Includes location at point of impact if it hit something.
        ///@param OutHit                                         Predicted hit result, if the projectile will hit something
        ///@param OutLastTraceDestination        Goal position of the final trace it did. Will not be in the path if there is a hit.
        ///@param StartPos                                       First start trace location
        ///@param LaunchVelocity                         Velocity the "virtual projectile" is launched at
        ///@param bTracePath                                     Trace along the entire path to look for blocking hits
        ///@param ProjectileRadius                       Radius of the virtual projectile to sweep against the environment
        ///@param ObjectTypes                            ObjectTypes to trace against, if bTracePath is true.
        ///@param bTraceComplex                          Use TraceComplex (trace against triangles not primitives)
        ///@param ActorsToIgnore                         Actors to exclude from the traces
        ///@param DrawDebugType                          Debug type (one-frame, duration, persistent)
        ///@param DrawDebugTime                          Duration of debug lines (only relevant for DrawDebugType::Duration)
        ///@param SimFrequency                           Determines size of each sub-step in the simulation (chopping up MaxSimTime)
        ///@param MaxSimTime                                     Maximum simulation time for the virtual projectile.
        ///@param OverrideGravityZ                       Optional override of Gravity (if 0, uses WorldGravityZ)
        ///@return                                                       True if hit something along the path if tracing for collision.
        ///</remarks>
        public static (HitResult, IReadOnlyCollection<Vector>, Vector, bool) Blueprint_PredictProjectilePath_ByObjectType(UObject WorldContextObject, Vector StartPos, Vector LaunchVelocity, bool bTracePath, float ProjectileRadius, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, float DrawDebugTime, float SimFrequency, float MaxSimTime, float OverrideGravityZ)  => 
            GameplayStatics_methods.Blueprint_PredictProjectilePath_ByObjectType_method.Invoke(WorldContextObject, StartPos, LaunchVelocity, bTracePath, ProjectileRadius, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, DrawDebugTime, SimFrequency, MaxSimTime, OverrideGravityZ);

        ///<summary>Predict the arc of a virtual projectile affected by gravity with collision checks along the arc.</summary>
        ///<remarks>
        ///Returns a list of positions of the simulated arc and the destination reached by the simulation.
        ///Returns true if it hit something (if tracing with collision).
        ///
        ///@param OutPathPositions                       Predicted projectile path. Ordered series of positions from StartPos to the end. Includes location at point of impact if it hit something.
        ///@param OutHit                                         Predicted hit result, if the projectile will hit something
        ///@param OutLastTraceDestination        Goal position of the final trace it did. Will not be in the path if there is a hit.
        ///@param StartPos                                       First start trace location
        ///@param LaunchVelocity                         Velocity the "virtual projectile" is launched at
        ///@param bTracePath                                     Trace along the entire path to look for blocking hits
        ///@param ProjectileRadius                       Radius of the virtual projectile to sweep against the environment
        ///@param TraceChannel                           TraceChannel to trace against, if bTracePath is true.
        ///@param bTraceComplex                          Use TraceComplex (trace against triangles not primitives)
        ///@param ActorsToIgnore                         Actors to exclude from the traces
        ///@param DrawDebugType                          Debug type (one-frame, duration, persistent)
        ///@param DrawDebugTime                          Duration of debug lines (only relevant for DrawDebugType::Duration)
        ///@param SimFrequency                           Determines size of each sub-step in the simulation (chopping up MaxSimTime)
        ///@param MaxSimTime                                     Maximum simulation time for the virtual projectile.
        ///@param OverrideGravityZ                       Optional override of Gravity (if 0, uses WorldGravityZ)
        ///@return                                                       True if hit something along the path (if tracing with collision).
        ///</remarks>
        public static (HitResult, IReadOnlyCollection<Vector>, Vector, bool) Blueprint_PredictProjectilePath_ByTraceChannel(UObject WorldContextObject, Vector StartPos, Vector LaunchVelocity, bool bTracePath, float ProjectileRadius, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, float DrawDebugTime, float SimFrequency, float MaxSimTime, float OverrideGravityZ)  => 
            GameplayStatics_methods.Blueprint_PredictProjectilePath_ByTraceChannel_method.Invoke(WorldContextObject, StartPos, LaunchVelocity, bTracePath, ProjectileRadius, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, DrawDebugTime, SimFrequency, MaxSimTime, OverrideGravityZ);

        ///<summary>Calculates an launch velocity for a projectile to hit a specified point.</summary>
        ///<remarks>
        ///@param TossVelocity          (output) Result launch velocity.
        ///@param StartLocation         Intended launch location
        ///@param EndLocation           Desired landing location
        ///@param LaunchSpeed           Desired launch speed
        ///@param OverrideGravityZ      Optional gravity override.  0 means "do not override".
        ///@param TraceOption           Controls whether or not to validate a clear path by tracing along the calculated arc
        ///@param CollisionRadius       Radius of the projectile (assumed spherical), used when tracing
        ///@param bFavorHighArc         If true and there are 2 valid solutions, will return the higher arc.  If false, will favor the lower arc.
        ///@param bDrawDebug            When true, a debug arc is drawn (red for an invalid arc, green for a valid arc)
        ///@return                                      Returns false if there is no valid solution or the valid solutions are blocked.  Returns true otherwise.
        ///</remarks>
        public static (Vector, bool) BlueprintSuggestProjectileVelocity(UObject WorldContextObject, Vector StartLocation, Vector EndLocation, float LaunchSpeed, float OverrideGravityZ, byte TraceOption, float CollisionRadius, bool bFavorHighArc, bool bDrawDebug)  => 
            GameplayStatics_methods.BlueprintSuggestProjectileVelocity_method.Invoke(WorldContextObject, StartLocation, EndLocation, LaunchSpeed, OverrideGravityZ, TraceOption, CollisionRadius, bFavorHighArc, bDrawDebug);

        ///<summary>Extracts data from a HitResult.</summary>
        ///<remarks>
        ///@param Hit                   The source HitResult.
        ///@param bBlockingHit  True if there was a blocking hit, false otherwise.
        ///@param bInitialOverlap True if the hit started in an initial overlap. In this case some other values should be interpreted differently. Time will be 0, ImpactPoint will equal Location, and normals will be equal and indicate a depenetration vector.
        ///@param Time                  'Time' of impact along trace direction ranging from [0.0 to 1.0) if there is a hit, indicating time between start and end. Equals 1.0 if there is no hit.
        ///@param Distance              The distance from the TraceStart to the Location in world space. This value is 0 if there was an initial overlap (trace started inside another colliding object).
        ///@param Location              Location of the hit in world space. If this was a swept shape test, this is the location where we can place the shape in the world where it will not penetrate.
        ///@param Normal                Normal of the hit in world space, for the object that was swept (e.g. for a sphere trace this points towards the sphere's center). Equal to ImpactNormal for line tests.
        ///@param ImpactPoint   Location of the actual contact point of the trace shape with the surface of the hit object. Equal to Location in the case of an initial overlap.
        ///@param ImpactNormal  Normal of the hit in world space, for the object that was hit by the sweep.
        ///@param PhysMat               Physical material that was hit. Must set bReturnPhysicalMaterial to true in the query params for this to be returned.
        ///@param HitActor              Actor hit by the trace.
        ///@param HitComponent  PrimitiveComponent hit by the trace.
        ///@param HitBoneName   Name of the bone hit (valid only if we hit a skeletal mesh).
        ///@param HitItem               Primitive-specific data recording which item in the primitive was hit
        ///@param FaceIndex             If colliding with trimesh or landscape, index of face that was hit.
        ///</remarks>
        public static (bool, bool, float, float, Vector, Vector, Vector, Vector, PhysicalMaterial, Actor, PrimitiveComponent, Name, int, int, Vector, Vector) BreakHitResult(HitResult Hit)  => 
            GameplayStatics_methods.BreakHitResult_method.Invoke(Hit);

        ///<summary>Cancels all currently queued streaming packages</summary>
        public static void CancelAsyncLoading()  => 
            GameplayStatics_methods.CancelAsyncLoading_method.Invoke();

        ///<summary>Clears the override of the sound class adjuster in the given sound mix.</summary>
        ///<remarks>
        ///If the override did not exist in the sound mix, this will do nothing.
        ///@param InSoundMixModifier The sound mix to modify.
        ///@param InSoundClass The sound class to override (or add) in the sound mix.
        ///@param FadeOutTime The interpolation time to use to go from the current sound class adjuster override values to the non-override values.
        ///</remarks>
        public static void ClearSoundMixClassOverride(UObject WorldContextObject, SoundMix InSoundMixModifier, SoundClass InSoundClass, float FadeOutTime)  => 
            GameplayStatics_methods.ClearSoundMixClassOverride_method.Invoke(WorldContextObject, InSoundMixModifier, InSoundClass, FadeOutTime);

        ///<summary>Clear all sound mix modifiers from the audio system *</summary>
        public static void ClearSoundMixModifiers(UObject WorldContextObject)  => 
            GameplayStatics_methods.ClearSoundMixModifiers_method.Invoke(WorldContextObject);

        ///<summary>Create a new player for this game.</summary>
        ///<remarks>
        ///@param ControllerId         The ID of the controller that the should control the newly created player.  A value of -1 specifies to use the next available ID
        ///@param bSpawnPawn           Whether a pawn should be spawned immediately. If false a pawn will not be created until transition to the next map.
        ///</remarks>
        public static PlayerController CreatePlayer(UObject WorldContextObject, int ControllerId, bool bSpawnPawn)  => 
            GameplayStatics_methods.CreatePlayer_method.Invoke(WorldContextObject, ControllerId, bSpawnPawn);

        ///<summary>Create a new, empty SaveGame object to set data on and then pass to SaveGameToSlot.</summary>
        ///<remarks>
        ///@param  SaveGameClass   Class of SaveGame to create
        ///@return                                 New SaveGame object to write data to
        ///</remarks>
        public static SaveGame CreateSaveGameObject(SubclassOf<SaveGame> SaveGameClass)  => 
            GameplayStatics_methods.CreateSaveGameObject_method.Invoke(SaveGameClass);

        ///<summary>Create a new, empty SaveGame object to set data on and then pass to SaveGameToSlot.</summary>
        ///<remarks>
        ///@param  SaveGameBlueprint       Blueprint of SaveGame to create
        ///@return                                         New SaveGame object to write data to
        ///</remarks>
        public static SaveGame CreateSaveGameObjectFromBlueprint(Blueprint SaveGameBlueprint)  => 
            GameplayStatics_methods.CreateSaveGameObjectFromBlueprint_method.Invoke(SaveGameBlueprint);

        ///<summary>Creates a sound with no attenuation, perfect for UI sounds.</summary>
        ///<remarks>
        ///This does NOT play the sound
        ///
        ///* Not Replicated.
        ///@param Sound - Sound to create.
        ///@param VolumeMultiplier - Multiplied with the volume to make the sound louder or softer.
        ///@param PitchMultiplier - Multiplies the pitch.
        ///@param StartTime - How far in to the sound to begin playback at
        ///@param ConcurrencySettings - Override concurrency settings package to play sound with
        ///@param PersistAcrossLevelTransition - Whether the sound should continue to play when the map it was played in is unloaded
        ///@param bAutoDestroy - Whether the returned audio component will be automatically cleaned up when the sound finishes (by completing or stopping) or whether it can be reactivated
        ///@return An audio component to manipulate the created sound
        ///</remarks>
        public static AudioComponent CreateSound2D(UObject WorldContextObject, SoundBase Sound, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundConcurrency ConcurrencySettings, bool bPersistAcrossLevelTransition, bool bAutoDestroy)  => 
            GameplayStatics_methods.CreateSound2D_method.Invoke(WorldContextObject, Sound, VolumeMultiplier, PitchMultiplier, StartTime, ConcurrencySettings, bPersistAcrossLevelTransition, bAutoDestroy);

        ///<summary>
        ///Deactivates a Reverb Effect not applied by a volume
        ///@
        ///</summary>
        ///<remarks>param TagName Tag associated with Reverb Effect to remove</remarks>
        public static void DeactivateReverbEffect(UObject WorldContextObject, Name TagName)  => 
            GameplayStatics_methods.DeactivateReverbEffect_method.Invoke(WorldContextObject, TagName);

        ///<summary>Delete a save game in a particular slot.</summary>
        ///<remarks>
        ///@param SlotName                 Name of save game slot to delete.
        /// @param UserIndex            For some platforms, master user index to identify the user doing the deletion.
        /// @return True if a file was actually able to be deleted. use DoesSaveGameExist to distinguish between delete failures and failure due to file not existing.
        ///</remarks>
        public static bool DeleteGameInSlot(string SlotName, int UserIndex)  => 
            GameplayStatics_methods.DeleteGameInSlot_method.Invoke(SlotName, UserIndex);

        ///<summary>Transforms the given 2D screen space coordinate into a 3D world-space point and direction.</summary>
        ///<remarks>
        ///@param Player                        Deproject using this player's view.
        ///@param ScreenPosition        2D screen space to deproject.
        ///@param WorldPosition         (out) Corresponding 3D position in world space.
        ///@param WorldDirection        (out) World space direction vector away from the camera at the given 2d point.
        ///</remarks>
        public static (Vector, Vector, bool) DeprojectScreenToWorld(PlayerController Player, Vector2D ScreenPosition)  => 
            GameplayStatics_methods.DeprojectScreenToWorld_method.Invoke(Player, ScreenPosition);

        ///<summary>See if a save game exists with the specified name.</summary>
        ///<remarks>
        ///@param SlotName                 Name of save game slot.
        ///@param UserIndex            For some platforms, master user index to identify the user doing the saving.
        ///</remarks>
        public static bool DoesSaveGameExist(string SlotName, int UserIndex)  => 
            GameplayStatics_methods.DoesSaveGameExist_method.Invoke(SlotName, UserIndex);

        ///<summary>Toggle live DVR streaming.</summary>
        ///<remarks>
        ///@param Enable                        If true enable streaming, otherwise disable.
        ///</remarks>
        public static void EnableLiveStreaming(bool Enable)  => 
            GameplayStatics_methods.EnableLiveStreaming_method.Invoke(Enable);

        ///<summary>Try and find the UV for a collision impact. Note this ONLY works if 'Support UV From Hit Results' is enabled in Physics Settings.</summary>
        public static (Vector2D, bool) FindCollisionUV(HitResult Hit, int UVChannel)  => 
            GameplayStatics_methods.FindCollisionUV_method.Invoke(Hit, UVChannel);

        ///<summary>'Finish' spawning an actor.  This will run the construction script.</summary>
        public static Actor FinishSpawningActor(Actor Actor, Transform SpawnTransform)  => 
            GameplayStatics_methods.FinishSpawningActor_method.Invoke(Actor, SpawnTransform);

        ///<summary>Flushes level streaming in blocking fashion and returns when all sub-levels are loaded / visible / hidden</summary>
        public static void FlushLevelStreaming(UObject WorldContextObject)  => 
            GameplayStatics_methods.FlushLevelStreaming_method.Invoke(WorldContextObject);

        ///<summary>Get Accurate Real Time</summary>
        public static (int, float) GetAccurateRealTime(UObject WorldContextObject)  => 
            GameplayStatics_methods.GetAccurateRealTime_method.Invoke(WorldContextObject);

        ///<summary>Find the average location (centroid) of an array of Actors</summary>
        public static Vector GetActorArrayAverageLocation(byte Actors /*TODO: array TArray */)  => 
            GameplayStatics_methods.GetActorArrayAverageLocation_method.Invoke(Actors);

        ///<summary>Bind the bounds of an array of Actors</summary>
        public static (Vector, Vector) GetActorArrayBounds(byte Actors /*TODO: array TArray */, bool bOnlyCollidingComponents)  => 
            GameplayStatics_methods.GetActorArrayBounds_method.Invoke(Actors, bOnlyCollidingComponents);

        ///<summary>Find all Actors in the world of the specified class.</summary>
        ///<remarks>
        ///This is a slow operation, use with caution e.g. do not use every frame.
        ///@param  ActorClass      Class of Actor to find. Must be specified or result array will be empty.
        ///@param  OutActors       Output array of Actors of the specified class.
        ///</remarks>
        public static IReadOnlyCollection<Actor> GetAllActorsOfClass(UObject WorldContextObject, SubclassOf<Actor> ActorClass)  => 
            GameplayStatics_methods.GetAllActorsOfClass_method.Invoke(WorldContextObject, ActorClass);

        ///<summary>Find all Actors in the world with the specified interface.</summary>
        ///<remarks>
        ///This is a slow operation, use with caution e.g. do not use every frame.
        ///@param  Interface       Interface to find. Must be specified or result array will be empty.
        ///@param  OutActors       Output array of Actors of the specified interface.
        ///</remarks>
        public static IReadOnlyCollection<Actor> GetAllActorsWithInterface(UObject WorldContextObject, SubclassOf<Interface> Interface)  => 
            GameplayStatics_methods.GetAllActorsWithInterface_method.Invoke(WorldContextObject, Interface);

        ///<summary>Find all Actors in the world with the specified tag.</summary>
        ///<remarks>
        ///This is a slow operation, use with caution e.g. do not use every frame.
        ///@param  Tag                     Tag to find. Must be specified or result array will be empty.
        ///@param  OutActors       Output array of Actors of the specified tag.
        ///</remarks>
        public static IReadOnlyCollection<Actor> GetAllActorsWithTag(UObject WorldContextObject, Name Tag)  => 
            GameplayStatics_methods.GetAllActorsWithTag_method.Invoke(WorldContextObject, Tag);

        ///<summary>Returns time in seconds since world was brought up for play, IS stopped when game pauses, NOT dilated/clamped.</summary>
        public static float GetAudioTimeSeconds(UObject WorldContextObject)  => 
            GameplayStatics_methods.GetAudioTimeSeconds_method.Invoke(WorldContextObject);

        ///<summary>Get the name of the currently-open level.</summary>
        ///<remarks>
        ///@param bRemovePrefixString    remove any streaming- or editor- added prefixes from the level name.
        ///</remarks>
        public static string GetCurrentLevelName(UObject WorldContextObject, bool bRemovePrefixString)  => 
            GameplayStatics_methods.GetCurrentLevelName_method.Invoke(WorldContextObject, bRemovePrefixString);

        ///<summary>Returns the highest priority reverb settings currently active from any source (volumes or manual setting).</summary>
        public static ReverbEffect GetCurrentReverbEffect(UObject WorldContextObject)  => 
            GameplayStatics_methods.GetCurrentReverbEffect_method.Invoke(WorldContextObject);

        ///<summary>Returns the game instance object</summary>
        public static GameInstance GetGameInstance(UObject WorldContextObject)  => 
            GameplayStatics_methods.GetGameInstance_method.Invoke(WorldContextObject);

        ///<summary>Returns the current GameModeBase or Null if it can't be retrieved, such as on the client</summary>
        public static GameModeBase GetGameMode(UObject WorldContextObject)  => 
            GameplayStatics_methods.GetGameMode_method.Invoke(WorldContextObject);

        ///<summary>Returns the current GameStateBase or Null if it can't be retrieved</summary>
        public static GameStateBase GetGameState(UObject WorldContextObject)  => 
            GameplayStatics_methods.GetGameState_method.Invoke(WorldContextObject);

        ///<summary>Gets the current global time dilation.</summary>
        ///<remarks>
        ///@return Current time dilation.
        ///</remarks>
        public static float GetGlobalTimeDilation(UObject WorldContextObject)  => 
            GameplayStatics_methods.GetGlobalTimeDilation_method.Invoke(WorldContextObject);

        ///<summary>Find an option in the options string and return it as an integer.</summary>
        ///<remarks>
        ///@param Options               The string containing the options.
        ///@param Key                   The key to find the value of in Options.
        ///@return                              The value associated with Key as an integer if Key found in Options string, otherwise DefaultValue.
        ///</remarks>
        public static int GetIntOption(string Options, string Key, int DefaultValue)  => 
            GameplayStatics_methods.GetIntOption_method.Invoke(Options, Key, DefaultValue);

        ///<summary>Break up a key=value pair into its key and value.</summary>
        ///<remarks>
        ///@param Pair                  The string containing a pair to split apart.
        ///@param Key                   (out) Key portion of Pair. If no = in string will be the same as Pair.
        ///@param Value                 (out) Value portion of Pair. If no = in string will be empty.
        ///</remarks>
        public static (string, string) GetKeyValue(string Pair)  => 
            GameplayStatics_methods.GetKeyValue_method.Invoke(Pair);

        ///<summary>Returns the class of a passed in Object, will always be valid if Object is not NULL</summary>
        public static SubclassOf<UObject> GetObjectClass(UObject UObject)  => 
            GameplayStatics_methods.GetObjectClass_method.Invoke(UObject);

        ///<summary>Returns the string name of the current platform, to perform different behavior based on platform.</summary>
        ///<remarks>(Platform names include Windows, Mac, IOS, Android, PS4, XboxOne, HTML5, Linux)</remarks>
        public static string GetPlatformName()  => 
            GameplayStatics_methods.GetPlatformName_method.Invoke();

        ///<summary>Returns the player's camera manager for the specified player index</summary>
        public static PlayerCameraManager GetPlayerCameraManager(UObject WorldContextObject, int PlayerIndex)  => 
            GameplayStatics_methods.GetPlayerCameraManager_method.Invoke(WorldContextObject, PlayerIndex);

        ///<summary>Returns the player character (NULL if the player pawn doesn't exist OR is not a character) at the specified player index</summary>
        public static Character GetPlayerCharacter(UObject WorldContextObject, int PlayerIndex)  => 
            GameplayStatics_methods.GetPlayerCharacter_method.Invoke(WorldContextObject, PlayerIndex);

        ///<summary>Returns the player controller at the specified player index</summary>
        public static PlayerController GetPlayerController(UObject WorldContextObject, int PlayerIndex)  => 
            GameplayStatics_methods.GetPlayerController_method.Invoke(WorldContextObject, PlayerIndex);

        ///<summary>
        ///Gets what controller ID a Player is using
        ///@
        ///</summary>
        ///<remarks>
        ///param Player         The player controller of the player to get the ID of
        ///@return                       The ID of the passed in player. -1 if there is no controller for the passed in player
        ///</remarks>
        public static int GetPlayerControllerID(PlayerController Player)  => 
            GameplayStatics_methods.GetPlayerControllerID_method.Invoke(Player);

        ///<summary>Returns the player pawn at the specified player index</summary>
        public static Pawn GetPlayerPawn(UObject WorldContextObject, int PlayerIndex)  => 
            GameplayStatics_methods.GetPlayerPawn_method.Invoke(WorldContextObject, PlayerIndex);

        ///<summary>Returns time in seconds since world was brought up for play, does NOT stop when game pauses, NOT dilated/clamped</summary>
        public static float GetRealTimeSeconds(UObject WorldContextObject)  => 
            GameplayStatics_methods.GetRealTimeSeconds_method.Invoke(WorldContextObject);

        ///<summary>Returns level streaming object with specified level package name</summary>
        public static LevelStreaming GetStreamingLevel(UObject WorldContextObject, Name PackageName)  => 
            GameplayStatics_methods.GetStreamingLevel_method.Invoke(WorldContextObject, PackageName);

        ///<summary>Returns the EPhysicalSurface type of the given Hit.</summary>
        ///<remarks>To edit surface type for your project, use ProjectSettings/Physics/PhysicalSurface section</remarks>
        public static byte GetSurfaceType(HitResult Hit)  => 
            GameplayStatics_methods.GetSurfaceType_method.Invoke(Hit);

        ///<summary>Returns time in seconds since world was brought up for play, adjusted by time dilation and IS stopped when game pauses</summary>
        public static float GetTimeSeconds(UObject WorldContextObject)  => 
            GameplayStatics_methods.GetTimeSeconds_method.Invoke(WorldContextObject);

        ///<summary>Returns time in seconds since world was brought up for play, adjusted by time dilation and IS NOT stopped when game pauses</summary>
        public static float GetUnpausedTimeSeconds(UObject WorldContextObject)  => 
            GameplayStatics_methods.GetUnpausedTimeSeconds_method.Invoke(WorldContextObject);

        ///<summary>Returns the frame delta time in seconds, adjusted by time dilation.</summary>
        public static float GetWorldDeltaSeconds(UObject WorldContextObject)  => 
            GameplayStatics_methods.GetWorldDeltaSeconds_method.Invoke(WorldContextObject);

        ///<summary>Returns world origin current location.</summary>
        public static IntVector GetWorldOriginLocation(UObject WorldContextObject)  => 
            GameplayStatics_methods.GetWorldOriginLocation_method.Invoke(WorldContextObject);

        ///<summary>Counts how many grass foliage instances overlap a given sphere.</summary>
        ///<remarks>
        ///@param        Mesh                    The static mesh we are interested in counting.
        ///@param        CenterPosition  The center position of the sphere.
        ///@param        Radius                  The radius of the sphere.
        ///
        ///@return Number of foliage instances with their mesh set to Mesh that overlap the sphere.
        ///</remarks>
        public static int GrassOverlappingSphereCount(UObject WorldContextObject, StaticMesh StaticMesh, Vector CenterPosition, float Radius)  => 
            GameplayStatics_methods.GrassOverlappingSphereCount_method.Invoke(WorldContextObject, StaticMesh, CenterPosition, Radius);

        ///<summary>Checks the commandline to see if the desired option was specified on the commandline (e.</summary>
        ///<remarks>
        ///g. -demobuild)
        ///@return                               True if the launch option was specified on the commandline, false otherwise
        ///</remarks>
        public static bool HasLaunchOption(string OptionToCheck)  => 
            GameplayStatics_methods.HasLaunchOption_method.Invoke(OptionToCheck);

        ///<summary>Returns whether a key exists in an options string.</summary>
        ///<remarks>
        ///@param Options               The string containing the options.
        ///@param Key                   The key to determine if it exists in Options.
        ///@return                              Whether Key was found in Options.
        ///</remarks>
        public static bool HasOption(string Options, string InKey)  => 
            GameplayStatics_methods.HasOption_method.Invoke(Options, InKey);

        ///<summary>
        ///Returns the game's paused state
        ///@
        ///</summary>
        ///<remarks>return      Whether the game is currently paused or not</remarks>
        public static bool IsGamePaused(UObject WorldContextObject)  => 
            GameplayStatics_methods.IsGamePaused_method.Invoke(WorldContextObject);

        ///<summary>Load the contents from a given slot.</summary>
        ///<remarks>
        ///@param SlotName                 Name of the save game slot to load from.
        ///@param UserIndex            For some platforms, master user index to identify the user doing the loading.
        ///@return SaveGameObject  Object containing loaded game state (NULL if load fails)
        ///</remarks>
        public static SaveGame LoadGameFromSlot(string SlotName, int UserIndex)  => 
            GameplayStatics_methods.LoadGameFromSlot_method.Invoke(SlotName, UserIndex);

        ///<summary>Stream the level with the LevelName ; Calling again before it finishes has no effect</summary>
        public static void LoadStreamLevel(UObject WorldContextObject, Name LevelName, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad, LatentActionInfo LatentInfo)  => 
            GameplayStatics_methods.LoadStreamLevel_method.Invoke(WorldContextObject, LevelName, bMakeVisibleAfterLoad, bShouldBlockOnLoad, LatentInfo);

        ///<summary>
        ///Create a HitResult struct
        ///@
        ///</summary>
        ///<remarks>
        ///param Hit                   The source HitResult.
        ///@param bBlockingHit  True if there was a blocking hit, false otherwise.
        ///@param bInitialOverlap True if the hit started in an initial overlap. In this case some other values should be interpreted differently. Time will be 0, ImpactPoint will equal Location, and normals will be equal and indicate a depenetration vector.
        ///@param Time                  'Time' of impact along trace direction ranging from [0.0 to 1.0) if there is a hit, indicating time between start and end. Equals 1.0 if there is no hit.
        ///@param Distance              The distance from the TraceStart to the Location in world space. This value is 0 if there was an initial overlap (trace started inside another colliding object).
        ///@param Location              Location of the hit in world space. If this was a swept shape test, this is the location where we can place the shape in the world where it will not penetrate.
        ///@param Normal                Normal of the hit in world space, for the object that was swept (e.g. for a sphere trace this points towards the sphere's center). Equal to ImpactNormal for line tests.
        ///@param ImpactPoint   Location of the actual contact point of the trace shape with the surface of the hit object. Equal to Location in the case of an initial overlap.
        ///@param ImpactNormal  Normal of the hit in world space, for the object that was hit by the sweep.
        ///@param PhysMat               Physical material that was hit. Must set bReturnPhysicalMaterial to true in the query params for this to be returned.
        ///@param HitActor              Actor hit by the trace.
        ///@param HitComponent  PrimitiveComponent hit by the trace.
        ///@param HitBoneName   Name of the bone hit (valid only if we hit a skeletal mesh).
        ///@param HitItem               Primitive-specific data recording which item in the primitive was hit
        ///@param FaceIndex             If colliding with trimesh or landscape, index of face that was hit.
        ///</remarks>
        public static HitResult MakeHitResult(bool bBlockingHit, bool bInitialOverlap, float Time, float Distance, Vector Location, Vector ImpactPoint, Vector Normal, Vector ImpactNormal, PhysicalMaterial PhysMat, Actor HitActor, PrimitiveComponent HitComponent, Name HitBoneName, int HitItem, int FaceIndex, Vector TraceStart, Vector TraceEnd)  => 
            GameplayStatics_methods.MakeHitResult_method.Invoke(bBlockingHit, bInitialOverlap, Time, Distance, Location, ImpactPoint, Normal, ImpactNormal, PhysMat, HitActor, HitComponent, HitBoneName, HitItem, FaceIndex, TraceStart, TraceEnd);

        ///<summary>
        ///Travel to another level
        ///@
        ///</summary>
        ///<remarks>
        ///param       LevelName                       the level to open
        ///@param       bAbsolute                       if true options are reset, if false options are carried over from current level
        ///@param       Options                         a string of options to use for the travel URL
        ///</remarks>
        public static void OpenLevel(UObject WorldContextObject, Name LevelName, bool bAbsolute, string Options)  => 
            GameplayStatics_methods.OpenLevel_method.Invoke(WorldContextObject, LevelName, bAbsolute, Options);

        ///<summary>Find an option in the options string and return it.</summary>
        ///<remarks>
        ///@param Options               The string containing the options.
        ///@param Key                   The key to find the value of in Options.
        ///@return                              The value associated with Key if Key found in Options string.
        ///</remarks>
        public static string ParseOption(string Options, string Key)  => 
            GameplayStatics_methods.ParseOption_method.Invoke(Options, Key);

        ///<summary>Plays a dialogue directly with no attenuation, perfect for UI.</summary>
        ///<remarks>
        ///* Fire and Forget.
        ///* Not Replicated.
        ///@param Dialogue - dialogue to play
        ///@param Context - context the dialogue is to play in
        ///@param VolumeMultiplier - Multiplied with the volume to make the sound louder or softer.
        ///@param PitchMultiplier - Multiplies the pitch.
        ///@param StartTime - How far in to the dialogue to begin playback at
        ///</remarks>
        public static void PlayDialogue2D(UObject WorldContextObject, DialogueWave Dialogue, DialogueContext Context, float VolumeMultiplier, float PitchMultiplier, float StartTime)  => 
            GameplayStatics_methods.PlayDialogue2D_method.Invoke(WorldContextObject, Dialogue, Context, VolumeMultiplier, PitchMultiplier, StartTime);

        ///<summary>Plays a dialogue at the given location.</summary>
        ///<remarks>
        ///This is a fire and forget sound and does not travel with any actor. Replication is also not handled at this point.
        ///@param Dialogue - dialogue to play
        ///@param Context - context the dialogue is to play in
        ///@param Location - World position to play dialogue at
        ///@param Rotation - World rotation to play dialogue at
        ///@param VolumeMultiplier - Volume multiplier
        ///@param PitchMultiplier - Pitch multiplier
        ///@param StartTime - How far in to the dialogue to begin playback at
        ///@param AttenuationSettings - Override attenuation settings package to play sound with
        ///</remarks>
        public static void PlayDialogueAtLocation(UObject WorldContextObject, DialogueWave Dialogue, DialogueContext Context, Vector Location, Rotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundAttenuation AttenuationSettings)  => 
            GameplayStatics_methods.PlayDialogueAtLocation_method.Invoke(WorldContextObject, Dialogue, Context, Location, Rotation, VolumeMultiplier, PitchMultiplier, StartTime, AttenuationSettings);

        ///<summary>Plays a sound directly with no attenuation, perfect for UI sounds.</summary>
        ///<remarks>
        ///* Fire and Forget.
        ///* Not Replicated.
        ///@param Sound - Sound to play.
        ///@param VolumeMultiplier - Multiplied with the volume to make the sound louder or softer.
        ///@param PitchMultiplier - Multiplies the pitch.
        ///@param ConcurrencySettings - Override concurrency settings package to play sound with
        ///@param StartTime - How far in to the sound to begin playback at
        ///@param ConcurrencySettings - Override concurrency settings package to play sound with
        ///@param OwningActor - The actor to use as the "owner" for concurrency settings purposes. Allows PlaySound calls to do a concurrency limit per owner.
        ///</remarks>
        public static void PlaySound2D(UObject WorldContextObject, SoundBase Sound, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundConcurrency ConcurrencySettings, Actor OwningActor)  => 
            GameplayStatics_methods.PlaySound2D_method.Invoke(WorldContextObject, Sound, VolumeMultiplier, PitchMultiplier, StartTime, ConcurrencySettings, OwningActor);

        ///<summary>Plays a sound at the given location.</summary>
        ///<remarks>
        ///This is a fire and forget sound and does not travel with any actor. Replication is also not handled at this point.
        ///@param Sound - sound to play
        ///@param Location - World position to play sound at
        ///@param Rotation - World rotation to play sound at
        ///@param VolumeMultiplier - Volume multiplier
        ///@param PitchMultiplier - PitchMultiplier
        ///@param StartTime - How far in to the sound to begin playback at
        ///@param AttenuationSettings - Override attenuation settings package to play sound with
        ///@param ConcurrencySettings - Override concurrency settings package to play sound with
        ///@param OwningActor - The actor to use as the "owner" for concurrency settings purposes. Allows PlaySound calls to do a concurrency limit per owner.
        ///</remarks>
        public static void PlaySoundAtLocation(UObject WorldContextObject, SoundBase Sound, Vector Location, Rotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundAttenuation AttenuationSettings, SoundConcurrency ConcurrencySettings, Actor OwningActor)  => 
            GameplayStatics_methods.PlaySoundAtLocation_method.Invoke(WorldContextObject, Sound, Location, Rotation, VolumeMultiplier, PitchMultiplier, StartTime, AttenuationSettings, ConcurrencySettings, OwningActor);

        ///<summary>Plays an in-world camera shake that affects all nearby local players, with distance-based attenuation.</summary>
        ///<remarks>
        ///Does not replicate.
        ///@param WorldContextObject - Object that we can obtain a world context from
        ///@param Shake - Camera shake asset to use
        ///@param Epicenter - location to place the effect in world space
        ///@param InnerRadius - Cameras inside this radius are ignored
        ///@param OuterRadius - Cameras outside of InnerRadius and inside this are effected
        ///@param Falloff - Affects falloff of effect as it nears OuterRadius
        ///@param bOrientShakeTowardsEpicenter - Changes the rotation of shake to point towards epicenter instead of forward
        ///</remarks>
        public static void PlayWorldCameraShake(UObject WorldContextObject, SubclassOf<CameraShake> Shake, Vector Epicenter, float InnerRadius, float OuterRadius, float Falloff, bool bOrientShakeTowardsEpicenter)  => 
            GameplayStatics_methods.PlayWorldCameraShake_method.Invoke(WorldContextObject, Shake, Epicenter, InnerRadius, OuterRadius, Falloff, bOrientShakeTowardsEpicenter);

        ///<summary>Pop a sound mix modifier from the audio system *</summary>
        public static void PopSoundMixModifier(UObject WorldContextObject, SoundMix InSoundMixModifier)  => 
            GameplayStatics_methods.PopSoundMixModifier_method.Invoke(WorldContextObject, InSoundMixModifier);

        ///<summary>Transforms the given 3D world-space point into a its 2D screen space coordinate.</summary>
        ///<remarks>
        ///@param Player                        Project using this player's view.
        ///@param WorldPosition         World position to project.
        ///@param ScreenPosition        (out) Corresponding 2D position in screen space
        ///@param bPlayerViewportRelative       Should this be relative to the player viewport subregion (useful when using player attached widgets in split screen)
        ///</remarks>
        public static (Vector2D, bool) ProjectWorldToScreen(PlayerController Player, Vector WorldPosition, bool bPlayerViewportRelative)  => 
            GameplayStatics_methods.ProjectWorldToScreen_method.Invoke(Player, WorldPosition, bPlayerViewportRelative);

        ///<summary>Push a sound mix modifier onto the audio system *</summary>
        public static void PushSoundMixModifier(UObject WorldContextObject, SoundMix InSoundMixModifier)  => 
            GameplayStatics_methods.PushSoundMixModifier_method.Invoke(WorldContextObject, InSoundMixModifier);

        ///<summary>Returns origin based position for local world location.</summary>
        public static Vector RebaseLocalOriginOntoZero(UObject WorldContextObject, Vector WorldLocation)  => 
            GameplayStatics_methods.RebaseLocalOriginOntoZero_method.Invoke(WorldContextObject, WorldLocation);

        ///<summary>Returns local location for origin based position.</summary>
        public static Vector RebaseZeroOriginOntoLocal(UObject WorldContextObject, Vector WorldLocation)  => 
            GameplayStatics_methods.RebaseZeroOriginOntoLocal_method.Invoke(WorldContextObject, WorldLocation);

        ///<summary>Removes a player from this game.</summary>
        ///<remarks>
        ///@param Player                       The player controller of the player to be removed
        ///@param bDestroyPawn         Whether the controlled pawn should be deleted as well
        ///</remarks>
        public static void RemovePlayer(PlayerController Player, bool bDestroyPawn)  => 
            GameplayStatics_methods.RemovePlayer_method.Invoke(Player, bDestroyPawn);

        ///<summary>Save the contents of the SaveGameObject to a slot.</summary>
        ///<remarks>
        ///@param SaveGameObject   Object that contains data about the save game that we want to write out
        ///@param SlotName                 Name of save game slot to save to.
        ///@param UserIndex            For some platforms, master user index to identify the user doing the saving.
        ///@return                                 Whether we successfully saved this information
        ///</remarks>
        public static bool SaveGameToSlot(SaveGame SaveGameObject, string SlotName, int UserIndex)  => 
            GameplayStatics_methods.SaveGameToSlot_method.Invoke(SaveGameObject, SlotName, UserIndex);

        ///<summary>Set the sound mix of the audio system for special EQing *</summary>
        public static void SetBaseSoundMix(UObject WorldContextObject, SoundMix InSoundMix)  => 
            GameplayStatics_methods.SetBaseSoundMix_method.Invoke(WorldContextObject, InSoundMix);

        ///<summary>
        ///Sets the game's paused state
        ///@
        ///</summary>
        ///<remarks>
        ///param       bPaused         Whether the game should be paused or not
        ///@return      Whether the game was successfully paused/unpaused
        ///</remarks>
        public static bool SetGamePaused(UObject WorldContextObject, bool bPaused)  => 
            GameplayStatics_methods.SetGamePaused_method.Invoke(WorldContextObject, bPaused);

        ///<summary>Sets the global listener focus parameters which will scale focus behavior of sounds based on their focus azimuth settings in their attenuation settings.</summary>
        ///<remarks>
        ///* Fire and Forget.
        ///* Not Replicated.
        ///@param FocusAzimuthScale - An angle scale value used to scale the azimuth angle that defines where sounds are in-focus.
        ///@param NonFocusAzimuthScale- An angle scale value used to scale the azimuth angle that defines where sounds are out-of-focus.
        ///@param FocusDistanceScale - A distance scale value to use for sounds which are in-focus. Values < 1.0 will reduce perceived distance to sounds, values > 1.0 will increase perceived distance to in-focus sounds.
        ///@param NonFocusDistanceScale - A distance scale value to use for sounds which are out-of-focus. Values < 1.0 will reduce perceived distance to sounds, values > 1.0 will increase perceived distance to in-focus sounds.
        ///@param FocusVolumeScale- A volume attenuation value to use for sounds which are in-focus.
        ///@param NonFocusVolumeScale- A volume attenuation value to use for sounds which are out-of-focus.
        ///@param FocusPriorityScale - A priority scale value (> 0.0) to use for sounds which are in-focus. Values < 1.0 will reduce the priority of in-focus sounds, values > 1.0 will increase the priority of in-focus sounds.
        ///@param NonFocusPriorityScale - A priority scale value (> 0.0) to use for sounds which are out-of-focus. Values < 1.0 will reduce the priority of sounds out-of-focus sounds, values > 1.0 will increase the priority of out-of-focus sounds.
        ///</remarks>
        public static void SetGlobalListenerFocusParameters(UObject WorldContextObject, float FocusAzimuthScale, float NonFocusAzimuthScale, float FocusDistanceScale, float NonFocusDistanceScale, float FocusVolumeScale, float NonFocusVolumeScale, float FocusPriorityScale, float NonFocusPriorityScale)  => 
            GameplayStatics_methods.SetGlobalListenerFocusParameters_method.Invoke(WorldContextObject, FocusAzimuthScale, NonFocusAzimuthScale, FocusDistanceScale, NonFocusDistanceScale, FocusVolumeScale, NonFocusVolumeScale, FocusPriorityScale, NonFocusPriorityScale);

        ///<summary>
        ///Sets a global pitch modulation scalar that will apply to all non-UI sounds
        ///* Fire and Forget.
        ///</summary>
        ///<remarks>
        ///* Not Replicated.
        ///@param PitchModulation - A pitch modulation value to globally set.
        ///@param TimeSec - A time value to linearly interpolate the global modulation pitch over from it's current value.
        ///</remarks>
        public static void SetGlobalPitchModulation(UObject WorldContextObject, float PitchModulation, float TimeSec)  => 
            GameplayStatics_methods.SetGlobalPitchModulation_method.Invoke(WorldContextObject, PitchModulation, TimeSec);

        ///<summary>Sets the global time dilation.</summary>
        ///<remarks>
        ///@param       TimeDilation    value to set the global time dilation to
        ///</remarks>
        public static void SetGlobalTimeDilation(UObject WorldContextObject, float TimeDilation)  => 
            GameplayStatics_methods.SetGlobalTimeDilation_method.Invoke(WorldContextObject, TimeDilation);

        ///<summary>
        ///Sets what controller ID a Player should be using
        ///@
        ///</summary>
        ///<remarks>
        ///param Player                        The player controller of the player to change the controller ID of
        ///@param ControllerId          The controller ID to assign to this player
        ///</remarks>
        public static void SetPlayerControllerID(PlayerController Player, int ControllerId)  => 
            GameplayStatics_methods.SetPlayerControllerID_method.Invoke(Player, ControllerId);

        ///<summary>Overrides the sound class adjuster in the given sound mix.</summary>
        ///<remarks>
        ///If the sound class does not exist in the input sound mix, the sound class adjustment will be added to the sound mix.
        ///@param InSoundMixModifier The sound mix to modify.
        ///@param InSoundClass The sound class to override (or add) in the sound mix.
        ///@param Volume The volume scale to set the sound class adjuster to.
        ///@param Pitch The pitch scale to set the sound class adjuster to.
        ///@param FadeInTime The interpolation time to use to go from the current sound class adjuster values to the new values.
        ///@param bApplyToChildren Whether or not to apply this override to the sound class' children or to just the specified sound class.
        ///</remarks>
        public static void SetSoundMixClassOverride(UObject WorldContextObject, SoundMix InSoundMixModifier, SoundClass InSoundClass, float Volume, float Pitch, float FadeInTime, bool bApplyToChildren)  => 
            GameplayStatics_methods.SetSoundMixClassOverride_method.Invoke(WorldContextObject, InSoundMixModifier, InSoundClass, Volume, Pitch, FadeInTime, bApplyToChildren);

        ///<summary>Will set subtitles to be enabled or disabled.</summary>
        ///<remarks>
        ///@param bEnabled will enable subtitle drawing if true, disable if false.
        ///</remarks>
        public static void SetSubtitlesEnabled(bool bEnabled)  => 
            GameplayStatics_methods.SetSubtitlesEnabled_method.Invoke(bEnabled);

        ///<summary>Requests a new location for a world origin.</summary>
        public static void SetWorldOriginLocation(UObject WorldContextObject, IntVector NewLocation)  => 
            GameplayStatics_methods.SetWorldOriginLocation_method.Invoke(WorldContextObject, NewLocation);

        ///<summary>Spawns a decal at the given location and rotation, fire and forget.</summary>
        ///<remarks>
        ///Does not replicate.
        ///@param DecalMaterial - decal's material
        ///@param DecalSize - size of decal
        ///@param Location - location to place the decal in world space
        ///@param Rotation - rotation to place the decal in world space
        ///@param LifeSpan - destroy decal component after time runs out (0 = infinite)
        ///</remarks>
        public static DecalComponent SpawnDecalAtLocation(UObject WorldContextObject, MaterialInterface DecalMaterial, Vector DecalSize, Vector Location, Rotator Rotation, float LifeSpan)  => 
            GameplayStatics_methods.SpawnDecalAtLocation_method.Invoke(WorldContextObject, DecalMaterial, DecalSize, Location, Rotation, LifeSpan);

        ///<summary>Spawns a decal attached to and following the specified component.</summary>
        ///<remarks>
        ///Does not replicate.
        ///@param DecalMaterial - decal's material
        ///@param DecalSize - size of decal
        ///@param AttachComponent - Component to attach to.
        ///@param AttachPointName - Optional named point within the AttachComponent to spawn the emitter at
        ///@param Location - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world position that will be translated to a relative offset
        ///@param Rotation - Depending on the value of LocationType this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a realative offset
        ///@param LocationType - Specifies whether Location is a relative offset or an absolute world position
        ///@param LifeSpan - destroy decal component after time runs out (0 = infinite)
        ///</remarks>
        public static DecalComponent SpawnDecalAttached(MaterialInterface DecalMaterial, Vector DecalSize, SceneComponent AttachToComponent, Name AttachPointName, Vector Location, Rotator Rotation, byte LocationType, float LifeSpan)  => 
            GameplayStatics_methods.SpawnDecalAttached_method.Invoke(DecalMaterial, DecalSize, AttachToComponent, AttachPointName, Location, Rotation, LocationType, LifeSpan);

        ///<summary>Spawns a dialogue with no attenuation, perfect for UI.</summary>
        ///<remarks>
        ///* Not Replicated.
        ///@param Dialogue - dialogue to play
        ///@param Context - context the dialogue is to play in
        ///@param VolumeMultiplier - Multiplied with the volume to make the sound louder or softer.
        ///@param PitchMultiplier - Multiplies the pitch.
        ///@param StartTime - How far in to the dialogue to begin playback at
        ///@param bAutoDestroy - Whether the returned audio component will be automatically cleaned up when the sound finishes (by completing or stopping) or whether it can be reactivated
        ///@return An audio component to manipulate the spawned sound
        ///</remarks>
        public static AudioComponent SpawnDialogue2D(UObject WorldContextObject, DialogueWave Dialogue, DialogueContext Context, float VolumeMultiplier, float PitchMultiplier, float StartTime, bool bAutoDestroy)  => 
            GameplayStatics_methods.SpawnDialogue2D_method.Invoke(WorldContextObject, Dialogue, Context, VolumeMultiplier, PitchMultiplier, StartTime, bAutoDestroy);

        ///<summary>Plays a dialogue at the given location.</summary>
        ///<remarks>
        ///This is a fire and forget sound and does not travel with any actor. Replication is also not handled at this point.
        ///@param Dialogue - dialogue to play
        ///@param Context - context the dialogue is to play in
        ///@param Location - World position to play dialogue at
        ///@param Rotation - World rotation to play dialogue at
        ///@param VolumeMultiplier - Volume multiplier
        ///@param PitchMultiplier - PitchMultiplier
        ///@param StartTime - How far in to the dialogue to begin playback at
        ///@param AttenuationSettings - Override attenuation settings package to play sound with
        ///@param bAutoDestroy - Whether the returned audio component will be automatically cleaned up when the sound finishes (by completing or stopping) or whether it can be reactivated
        ///@return Audio Component to manipulate the playing dialogue with
        ///</remarks>
        public static AudioComponent SpawnDialogueAtLocation(UObject WorldContextObject, DialogueWave Dialogue, DialogueContext Context, Vector Location, Rotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundAttenuation AttenuationSettings, bool bAutoDestroy)  => 
            GameplayStatics_methods.SpawnDialogueAtLocation_method.Invoke(WorldContextObject, Dialogue, Context, Location, Rotation, VolumeMultiplier, PitchMultiplier, StartTime, AttenuationSettings, bAutoDestroy);

        ///<summary>Spawns a dialogue attached to and following the specified component.</summary>
        ///<remarks>
        ///This is a fire and forget sound. Replication is also not handled at this point.
        ///@param Dialogue - dialogue to play
        ///@param Context - context the dialogue is to play in
        ///@param AttachComponent - Component to attach to.
        ///@param AttachPointName - Optional named point within the AttachComponent to play the sound at
        ///@param Location - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world position that will be translated to a relative offset
        ///@param Rotation - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a relative offset
        ///@param LocationType - Specifies whether Location is a relative offset or an absolute world position
        ///@param bStopWhenAttachedToDestroyed - Specifies whether the sound should stop playing when the owner of the attach to component is destroyed.
        ///@param VolumeMultiplier - Volume multiplier
        ///@param PitchMultiplier - PitchMultiplier
        ///@param StartTime - How far in to the dialogue to begin playback at
        ///@param AttenuationSettings - Override attenuation settings package to play sound with
        ///@param bAutoDestroy - Whether the returned audio component will be automatically cleaned up when the sound finishes (by completing or stopping) or whether it can be reactivated
        ///@return Audio Component to manipulate the playing dialogue with
        ///</remarks>
        public static AudioComponent SpawnDialogueAttached(DialogueWave Dialogue, DialogueContext Context, SceneComponent AttachToComponent, Name AttachPointName, Vector Location, Rotator Rotation, byte LocationType, bool bStopWhenAttachedToDestroyed, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundAttenuation AttenuationSettings, bool bAutoDestroy)  => 
            GameplayStatics_methods.SpawnDialogueAttached_method.Invoke(Dialogue, Context, AttachToComponent, AttachPointName, Location, Rotation, LocationType, bStopWhenAttachedToDestroyed, VolumeMultiplier, PitchMultiplier, StartTime, AttenuationSettings, bAutoDestroy);

        ///<summary>Plays the specified effect at the given location and rotation, fire and forget.</summary>
        ///<remarks>
        ///The system will go away when the effect is complete. Does not replicate.
        ///@param WorldContextObject - Object that we can obtain a world context from
        ///@param EmitterTemplate - particle system to create
        ///@param Location - location to place the effect in world space
        ///@param Rotation - rotation to place the effect in world space
        ///@param Scale - scale to create the effect at
        ///@param bAutoDestroy - Whether the component will automatically be destroyed when the particle system completes playing or whether it can be reactivated
        ///@param PoolingMethod - Method used for pooling this component. Defaults to none.
        ///</remarks>
        public static ParticleSystemComponent SpawnEmitterAtLocation(UObject WorldContextObject, ParticleSystem EmitterTemplate, Vector Location, Rotator Rotation, Vector Scale, bool bAutoDestroy, EPSCPoolMethod PoolingMethod)  => 
            GameplayStatics_methods.SpawnEmitterAtLocation_method.Invoke(WorldContextObject, EmitterTemplate, Location, Rotation, Scale, bAutoDestroy, PoolingMethod);

        ///<summary>Plays the specified effect attached to and following the specified component.</summary>
        ///<remarks>
        ///The system will go away when the effect is complete. Does not replicate.
        ///@param EmitterTemplate - particle system to create
        ///@param AttachComponent - Component to attach to.
        ///@param AttachPointName - Optional named point within the AttachComponent to spawn the emitter at
        ///@param Location - Depending on the value of LocationType this is either a relative offset from the attach component/point or an absolute world location that will be translated to a relative offset (if LocationType is KeepWorldPosition).
        ///@param Rotation - Depending on the value of LocationType this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a relative offset (if LocationType is KeepWorldPosition).
        ///@param Scale - Depending on the value of LocationType this is either a relative scale from the attach component or an absolute world scale that will be translated to a relative scale (if LocationType is KeepWorldPosition).
        ///@param LocationType - Specifies whether Location is a relative offset or an absolute world position
        ///@param bAutoDestroy - Whether the component will automatically be destroyed when the particle system completes playing or whether it can be reactivated
        ///@param PoolingMethod - Method used for pooling this component. Defaults to none.
        ///</remarks>
        public static ParticleSystemComponent SpawnEmitterAttached(ParticleSystem EmitterTemplate, SceneComponent AttachToComponent, Name AttachPointName, Vector Location, Rotator Rotation, Vector Scale, byte LocationType, bool bAutoDestroy, EPSCPoolMethod PoolingMethod)  => 
            GameplayStatics_methods.SpawnEmitterAttached_method.Invoke(EmitterTemplate, AttachToComponent, AttachPointName, Location, Rotation, Scale, LocationType, bAutoDestroy, PoolingMethod);

        ///<summary>Plays a force feedback effect at the given location.</summary>
        ///<remarks>
        ///This is a fire and forget effect and does not travel with any actor. Replication is also not handled at this point.
        ///@param ForceFeedbackEffect - effect to play
        ///@param Location - World position to center the effect at
        ///@param Rotation - World rotation to center the effect at
        ///@param IntensityMultiplier - Intensity multiplier
        ///@param StartTime - How far in to the feedback effect to begin playback at
        ///@param AttenuationSettings - Override attenuation settings package to play effect with
        ///@param bAutoDestroy - Whether the returned force feedback component will be automatically cleaned up when the feedback patern finishes (by completing or stopping) or whether it can be reactivated
        ///@return Force Feedback Component to manipulate the playing feedback effect with
        ///</remarks>
        public static ForceFeedbackComponent SpawnForceFeedbackAtLocation(UObject WorldContextObject, ForceFeedbackEffect ForceFeedbackEffect, Vector Location, Rotator Rotation, bool bLooping, float IntensityMultiplier, float StartTime, ForceFeedbackAttenuation AttenuationSettings, bool bAutoDestroy)  => 
            GameplayStatics_methods.SpawnForceFeedbackAtLocation_method.Invoke(WorldContextObject, ForceFeedbackEffect, Location, Rotation, bLooping, IntensityMultiplier, StartTime, AttenuationSettings, bAutoDestroy);

        ///<summary>Plays a force feedback effect attached to and following the specified component.</summary>
        ///<remarks>
        ///This is a fire and forget effect. Replication is also not handled at this point.
        ///@param ForceFeedbackEffect - effect to play
        ///@param AttachComponent - Component to attach to.
        ///@param AttachPointName - Optional named point within the AttachComponent to attach to
        ///@param Location - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world position that will be translated to a relative offset
        ///@param Rotation - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a relative offset
        ///@param LocationType - Specifies whether Location is a relative offset or an absolute world position
        ///@param bStopWhenAttachedToDestroyed - Specifies whether the feedback effect should stop playing when the owner of the attach to component is destroyed.
        ///@param IntensityMultiplier - Intensity multiplier
        ///@param StartTime - How far in to the feedback effect to begin playback at
        ///@param AttenuationSettings - Override attenuation settings package to play effect with
        ///@param bAutoDestroy - Whether the returned force feedback component will be automatically cleaned up when the feedback patern finishes (by completing or stopping) or whether it can be reactivated
        ///@return Force Feedback Component to manipulate the playing feedback effect with
        ///</remarks>
        public static ForceFeedbackComponent SpawnForceFeedbackAttached(ForceFeedbackEffect ForceFeedbackEffect, SceneComponent AttachToComponent, Name AttachPointName, Vector Location, Rotator Rotation, byte LocationType, bool bStopWhenAttachedToDestroyed, bool bLooping, float IntensityMultiplier, float StartTime, ForceFeedbackAttenuation AttenuationSettings, bool bAutoDestroy)  => 
            GameplayStatics_methods.SpawnForceFeedbackAttached_method.Invoke(ForceFeedbackEffect, AttachToComponent, AttachPointName, Location, Rotation, LocationType, bStopWhenAttachedToDestroyed, bLooping, IntensityMultiplier, StartTime, AttenuationSettings, bAutoDestroy);

        ///<summary>--- Create Object</summary>
        public static UObject SpawnObject(SubclassOf<UObject> ObjectClass, UObject Outer)  => 
            GameplayStatics_methods.SpawnObject_method.Invoke(ObjectClass, Outer);

        ///<summary>Spawns a sound with no attenuation, perfect for UI sounds.</summary>
        ///<remarks>
        ///* Not Replicated.
        ///@param Sound - Sound to play.
        ///@param VolumeMultiplier - Multiplied with the volume to make the sound louder or softer.
        ///@param PitchMultiplier - Multiplies the pitch.
        ///@param StartTime - How far in to the sound to begin playback at
        ///@param ConcurrencySettings - Override concurrency settings package to play sound with
        ///@param PersistAcrossLevelTransition - Whether the sound should continue to play when the map it was played in is unloaded
        ///@param bAutoDestroy - Whether the returned audio component will be automatically cleaned up when the sound finishes (by completing or stopping) or whether it can be reactivated
        ///@return An audio component to manipulate the spawned sound
        ///</remarks>
        public static AudioComponent SpawnSound2D(UObject WorldContextObject, SoundBase Sound, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundConcurrency ConcurrencySettings, bool bPersistAcrossLevelTransition, bool bAutoDestroy)  => 
            GameplayStatics_methods.SpawnSound2D_method.Invoke(WorldContextObject, Sound, VolumeMultiplier, PitchMultiplier, StartTime, ConcurrencySettings, bPersistAcrossLevelTransition, bAutoDestroy);

        ///<summary>Spawns a sound at the given location.</summary>
        ///<remarks>
        ///This does not travel with any actor. Replication is also not handled at this point.
        ///@param Sound - sound to play
        ///@param Location - World position to play sound at
        ///@param Rotation - World rotation to play sound at
        ///@param VolumeMultiplier - Volume multiplier
        ///@param PitchMultiplier - PitchMultiplier
        ///@param StartTime - How far in to the sound to begin playback at
        ///@param AttenuationSettings - Override attenuation settings package to play sound with
        ///@param ConcurrencySettings - Override concurrency settings package to play sound with
        ///@param bAutoDestroy - Whether the returned audio component will be automatically cleaned up when the sound finishes (by completing or stopping) or whether it can be reactivated
        ///@return An audio component to manipulate the spawned sound
        ///</remarks>
        public static AudioComponent SpawnSoundAtLocation(UObject WorldContextObject, SoundBase Sound, Vector Location, Rotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundAttenuation AttenuationSettings, SoundConcurrency ConcurrencySettings, bool bAutoDestroy)  => 
            GameplayStatics_methods.SpawnSoundAtLocation_method.Invoke(WorldContextObject, Sound, Location, Rotation, VolumeMultiplier, PitchMultiplier, StartTime, AttenuationSettings, ConcurrencySettings, bAutoDestroy);

        ///<summary>Plays a sound attached to and following the specified component.</summary>
        ///<remarks>
        ///This is a fire and forget sound. Replication is also not handled at this point.
        ///@param Sound - sound to play
        ///@param AttachComponent - Component to attach to.
        ///@param AttachPointName - Optional named point within the AttachComponent to play the sound at
        ///@param Location - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world position that will be translated to a relative offset
        ///@param Rotation - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a relative offset
        ///@param LocationType - Specifies whether Location is a relative offset or an absolute world position
        ///@param bStopWhenAttachedToDestroyed - Specifies whether the sound should stop playing when the owner of the attach to component is destroyed.
        ///@param VolumeMultiplier - Volume multiplier
        ///@param PitchMultiplier - PitchMultiplier
        ///@param StartTime - How far in to the sound to begin playback at
        ///@param AttenuationSettings - Override attenuation settings package to play sound with
        ///@param ConcurrencySettings - Override concurrency settings package to play sound with
        ///@param bAutoDestroy - Whether the returned audio component will be automatically cleaned up when the sound finishes (by completing or stopping) or whether it can be reactivated
        ///@return An audio component to manipulate the spawned sound
        ///</remarks>
        public static AudioComponent SpawnSoundAttached(SoundBase Sound, SceneComponent AttachToComponent, Name AttachPointName, Vector Location, Rotator Rotation, byte LocationType, bool bStopWhenAttachedToDestroyed, float VolumeMultiplier, float PitchMultiplier, float StartTime, SoundAttenuation AttenuationSettings, SoundConcurrency ConcurrencySettings, bool bAutoDestroy)  => 
            GameplayStatics_methods.SpawnSoundAttached_method.Invoke(Sound, AttachToComponent, AttachPointName, Location, Rotation, LocationType, bStopWhenAttachedToDestroyed, VolumeMultiplier, PitchMultiplier, StartTime, AttenuationSettings, ConcurrencySettings, bAutoDestroy);

        ///<summary>Returns the launch velocity needed for a projectile at rest at StartPos to land on EndPos.</summary>
        ///<remarks>
        ///Assumes a medium arc (e.g. 45 deg on level ground). Projectile velocity is variable and unconstrained.
        ///Does no tracing.
        ///
        ///@param OutLaunchVelocity                      Returns the launch velocity required to reach the EndPos
        ///@param StartPos                                       Start position of the simulation
        ///@param EndPos                                         Desired end location for the simulation
        ///@param OverrideGravityZ                       Optional override of WorldGravityZ
        ///@param ArcParam                                       Change height of arc between 0.0-1.0 where 0.5 is the default medium arc, 0 is up, and 1 is directly toward EndPos.
        ///</remarks>
        public static (Vector, bool) SuggestProjectileVelocity_CustomArc(UObject WorldContextObject, Vector StartPos, Vector EndPos, float OverrideGravityZ, float ArcParam)  => 
            GameplayStatics_methods.SuggestProjectileVelocity_CustomArc_method.Invoke(WorldContextObject, StartPos, EndPos, OverrideGravityZ, ArcParam);

        ///<summary>Unload a streamed in level</summary>
        public static void UnloadStreamLevel(UObject WorldContextObject, Name LevelName, LatentActionInfo LatentInfo, bool bShouldBlockOnUnload)  => 
            GameplayStatics_methods.UnloadStreamLevel_method.Invoke(WorldContextObject, LevelName, LatentInfo, bShouldBlockOnUnload);
        static GameplayStatics() {
            StaticClass = Main.GetClass("GameplayStatics");
        }
        internal unsafe GameplayStatics_fields* GameplayStatics_ptr => (GameplayStatics_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayStatics(IntPtr p) => UObject.Make<GameplayStatics>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayStatics DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayStatics New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>
    ///A PlayerCameraManager is responsible for managing the camera for a particular
    ///player.
    ///</summary>
    ///<remarks>
    ///It defines the final view properties used by other systems (e.g. the renderer),
    ///meaning you can think of it as your virtual eyeball in the world. It can compute the
    ///final camera properties directly, or it can arbitrate/blend between other objects or
    ///actors that influence the camera (e.g. blending from one CameraActor to another).
    ///
    ///The PlayerCameraManagers primary external responsibility is to reliably respond to
    ///various Get*() functions, such as GetCameraViewPoint. Most everything else is
    ///implementation detail and overrideable by user projects.
    ///
    ///By default, a PlayerCameraManager maintains a "view target", which is the primary actor
    ///the camera is associated with. It can also apply various "post" effects to the final
    ///view state, such as camera animations, shakes, post-process effects or special
    ///effects such as dirt on the lens.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/Camera/
    ///</remarks>
    public unsafe partial class PlayerCameraManager : Actor  {

        ///<summary>Blueprint hook to allow blueprints to override existing camera behavior or implement custom cameras.</summary>
        ///<remarks>
        ///If this function returns true, we will use the given returned values and skip further calculations to determine
        ///final camera POV.
        ///</remarks>
        public event BlueprintUpdateCamera_delegate BlueprintUpdateCamera;
        public delegate (Vector, Rotator, float, bool) BlueprintUpdateCamera_delegate(Actor CameraTarget, Vector NewCameraLocation, Rotator NewCameraRotation, float NewCameraFOV, bool ReturnValue);
        internal (Vector, Rotator, float, bool) on_BlueprintUpdateCamera(Actor CameraTarget, Vector NewCameraLocation, Rotator NewCameraRotation, float NewCameraFOV, bool ReturnValue) =>
            BlueprintUpdateCamera != null ? BlueprintUpdateCamera(CameraTarget, NewCameraLocation, NewCameraRotation, NewCameraFOV, ReturnValue) : (NewCameraLocation, NewCameraRotation, NewCameraFOV, ReturnValue);


        ///<summary>
        ///Event triggered upon the end of a multi-part photograph capture, when manual
        ///free-roaming photographic camera control is about to be returned to the user.
        ///</summary>
        ///<remarks>
        ///Here you may re-enable whatever was turned off within
        ///OnPhotographyMultiPartCaptureStart.
        ///</remarks>
        public event OnPhotographyMultiPartCaptureEnd_delegate OnPhotographyMultiPartCaptureEnd;
        public delegate void OnPhotographyMultiPartCaptureEnd_delegate();
        internal void on_OnPhotographyMultiPartCaptureEnd() =>
            OnPhotographyMultiPartCaptureEnd?.Invoke();


        ///<summary>Event triggered upon the start of a multi-part photograph capture (i.</summary>
        ///<remarks>
        ///e. a
        ///stereoscopic or 360-degree shot).  This is an ideal time to turn off
        ///rendering effects that tile badly (UI, subtitles, vignette, very aggressive
        ///bloom, etc; most of these are automatically disabled when
        ///r.Photography.AutoPostprocess is 1).
        ///</remarks>
        public event OnPhotographyMultiPartCaptureStart_delegate OnPhotographyMultiPartCaptureStart;
        public delegate void OnPhotographyMultiPartCaptureStart_delegate();
        internal void on_OnPhotographyMultiPartCaptureStart() =>
            OnPhotographyMultiPartCaptureStart?.Invoke();


        ///<summary>
        ///Event triggered upon leaving Photography mode (after unpausing, if
        ///r.
        ///</summary>
        ///<remarks>Photography.AutoPause is 1).</remarks>
        public event OnPhotographySessionEnd_delegate OnPhotographySessionEnd;
        public delegate void OnPhotographySessionEnd_delegate();
        internal void on_OnPhotographySessionEnd() =>
            OnPhotographySessionEnd?.Invoke();


        ///<summary>
        ///Event triggered upon entering Photography mode (before pausing, if
        ///r.
        ///</summary>
        ///<remarks>Photography.AutoPause is 1).</remarks>
        public event OnPhotographySessionStart_delegate OnPhotographySessionStart;
        public delegate void OnPhotographySessionStart_delegate();
        internal void on_OnPhotographySessionStart() =>
            OnPhotographySessionStart?.Invoke();


        ///<summary>
        ///Implementable blueprint hook to allow a PlayerCameraManager subclass to
        ///constrain or otherwise modify the camera during free-camera photography.
        ///</summary>
        ///<remarks>
        ///For example, a blueprint may wish to limit the distance from the camera's
        ///original point, or forbid the camera from passing through walls.
        ///NewCameraLocation contains the proposed new camera location.
        ///PreviousCameraLocation contains the camera location in the previous frame.
        ///OriginalCameraLocation contains the camera location before the game was put
        ///into photography mode.
        ///Return ResultCameraLocation as modified according to your constraints.
        ///</remarks>
        public event PhotographyCameraModify_delegate PhotographyCameraModify;
        public delegate Vector PhotographyCameraModify_delegate(Vector NewCameraLocation, Vector PreviousCameraLocation, Vector OriginalCameraLocation, Vector ResultCameraLocation);
        internal Vector on_PhotographyCameraModify(Vector NewCameraLocation, Vector PreviousCameraLocation, Vector OriginalCameraLocation, Vector ResultCameraLocation) =>
            PhotographyCameraModify != null ? PhotographyCameraModify(NewCameraLocation, PreviousCameraLocation, OriginalCameraLocation, ResultCameraLocation) : ResultCameraLocation;


        ///<summary>Creates a camera lens effect of the given class on this camera.</summary>
        ///<remarks>
        ///@param LensEffectEmitterClass - Class of lens effect emitter to create.
        ///@return Returns the new emitter actor.
        ///</remarks>
        public EmitterCameraLensEffectBase AddCameraLensEffect(SubclassOf<EmitterCameraLensEffectBase> LensEffectEmitterClass)  => 
            PlayerCameraManager_methods.AddCameraLensEffect_method.Invoke(ObjPointer, LensEffectEmitterClass);

        ///<summary>Creates and initializes a new camera modifier of the specified class.</summary>
        ///<remarks>
        ///@param ModifierClass - The class of camera modifier to create.
        ///@return Returns the newly created camera modifier.
        ///</remarks>
        public CameraModifier AddNewCameraModifier(SubclassOf<CameraModifier> ModifierClass)  => 
            PlayerCameraManager_methods.AddNewCameraModifier_method.Invoke(ObjPointer, ModifierClass);

        ///<summary>Removes all camera lens effects.</summary>
        public void ClearCameraLensEffects()  => 
            PlayerCameraManager_methods.ClearCameraLensEffects_method.Invoke(ObjPointer);

        ///<summary>Returns camera modifier for this camera of the given class, if it exists.</summary>
        ///<remarks>Exact class match only. If there are multiple modifiers of the same class, the first one is returned.</remarks>
        public CameraModifier FindCameraModifierByClass(SubclassOf<CameraModifier> ModifierClass)  => 
            PlayerCameraManager_methods.FindCameraModifierByClass_method.Invoke(ObjPointer, ModifierClass);

        ///<summary>@return Returns camera's current location.</summary>
        public Vector GetCameraLocation()  => 
            PlayerCameraManager_methods.GetCameraLocation_method.Invoke(ObjPointer);

        ///<summary>@return Returns camera's current rotation.</summary>
        public Rotator GetCameraRotation()  => 
            PlayerCameraManager_methods.GetCameraRotation_method.Invoke(ObjPointer);

        ///<summary>@return Returns the camera's current full FOV angle, in degrees.</summary>
        public float GetFOVAngle()  => 
            PlayerCameraManager_methods.GetFOVAngle_method.Invoke(ObjPointer);

        ///<summary>Returns the PlayerController that owns this camera.</summary>
        public PlayerController GetOwningPlayerController()  => 
            PlayerCameraManager_methods.GetOwningPlayerController_method.Invoke(ObjPointer);

        ///<summary>Play the indicated CameraAnim on this camera.</summary>
        ///<remarks>
        ///@param Anim The animation that should play on this instance.
        ///@param Rate                          How fast to play the animation. 1.0 is normal.
        ///@param Scale                         How "intense" to play the animation. 1.0 is normal.
        ///@param BlendInTime           Time to linearly ramp in.
        ///@param BlendOutTime          Time to linearly ramp out.
        ///@param bLoop                         True to loop the animation if it hits the end.
        ///@param bRandomStartTime      Whether or not to choose a random time to start playing. Useful with bLoop=true and a duration to randomize things like shakes.
        ///@param Duration                      Optional total playtime for this animation, including blends. 0 means to use animations natural duration, or infinite if looping.
        ///@param PlaySpace                     Which space to play the animation in.
        ///@param UserPlaySpaceRot  Custom play space, used when PlaySpace is UserDefined.
        ///@return The CameraAnim instance, which can be stored to manipulate/stop the anim after the fact.
        ///</remarks>
        public CameraAnimInst PlayCameraAnim(CameraAnim Anim, float Rate, float Scale, float BlendInTime, float BlendOutTime, bool bLoop, bool bRandomStartTime, float Duration, byte PlaySpace, Rotator UserPlaySpaceRot)  => 
            PlayerCameraManager_methods.PlayCameraAnim_method.Invoke(ObjPointer, Anim, Rate, Scale, BlendInTime, BlendOutTime, bLoop, bRandomStartTime, Duration, PlaySpace, UserPlaySpaceRot);

        ///<summary>Plays a camera shake on this camera.</summary>
        ///<remarks>
        ///@param Shake - The class of camera shake to play.
        ///@param Scale - Scalar defining how "intense" to play the shake. 1.0 is normal (as authored).
        ///@param PlaySpace - Which coordinate system to play the shake in (affects oscillations and camera anims)
        ///@param UserPlaySpaceRot - Coordinate system to play shake when PlaySpace == CAPS_UserDefined.
        ///</remarks>
        public CameraShake PlayCameraShake(SubclassOf<CameraShake> ShakeClass, float Scale, byte PlaySpace, Rotator UserPlaySpaceRot)  => 
            PlayerCameraManager_methods.PlayCameraShake_method.Invoke(ObjPointer, ShakeClass, Scale, PlaySpace, UserPlaySpaceRot);

        ///<summary>Removes the given lens effect from the camera.</summary>
        ///<remarks>
        ///@param Emitter - the emitter actor to remove from the camera
        ///</remarks>
        public void RemoveCameraLensEffect(EmitterCameraLensEffectBase Emitter)  => 
            PlayerCameraManager_methods.RemoveCameraLensEffect_method.Invoke(ObjPointer, Emitter);

        ///<summary>Removes the given camera modifier from this camera (if it's on the camera in the first place) and discards it.</summary>
        ///<remarks>
        ///@return True if successfully removed, false otherwise.
        ///</remarks>
        public bool RemoveCameraModifier(CameraModifier ModifierToRemove)  => 
            PlayerCameraManager_methods.RemoveCameraModifier_method.Invoke(ObjPointer, ModifierToRemove);

        ///<summary>Turns on camera fading at the given opacity.</summary>
        ///<remarks>
        ///Does not auto-animate, allowing user to animate themselves.
        ///Call StopCameraFade to turn fading back off.
        ///</remarks>
        public void SetManualCameraFade(float InFadeAmount, LinearColor Color, bool bInFadeAudio)  => 
            PlayerCameraManager_methods.SetManualCameraFade_method.Invoke(ObjPointer, InFadeAmount, Color, bInFadeAudio);

        ///<summary>Does a camera fade to/from a solid color.</summary>
        ///<remarks>
        ///Animates automatically.
        ///@param FromAlpha - Alpha at which to begin the fade. Range [0..1], where 0 is fully transparent and 1 is fully opaque solid color.
        ///@param ToAlpha - Alpha at which to finish the fade.
        ///@param Duration - How long the fade should take, in seconds.
        ///@param Color - Color to fade to/from.
        ///@param bShouldFadeAudio - True to fade audio volume along with the alpha of the solid color.
        ///@param bHoldWhenFinished - True for fade to hold at the ToAlpha until explicitly stopped (e.g. with StopCameraFade)
        ///</remarks>
        public void StartCameraFade(float FromAlpha, float ToAlpha, float Duration, LinearColor Color, bool bShouldFadeAudio, bool bHoldWhenFinished)  => 
            PlayerCameraManager_methods.StartCameraFade_method.Invoke(ObjPointer, FromAlpha, ToAlpha, Duration, Color, bShouldFadeAudio, bHoldWhenFinished);

        ///<summary>Stop playing all CameraAnims on this CameraManager.</summary>
        ///<remarks>
        ///@param bImmediate    True to stop it right now and ignore blend out, false to let it blend out as indicated.
        ///</remarks>
        public void StopAllCameraAnims(bool bImmediate)  => 
            PlayerCameraManager_methods.StopAllCameraAnims_method.Invoke(ObjPointer, bImmediate);

        ///<summary>Stops all active camera shakes on this camera.</summary>
        public void StopAllCameraShakes(bool bImmediately)  => 
            PlayerCameraManager_methods.StopAllCameraShakes_method.Invoke(ObjPointer, bImmediately);

        ///<summary>Stop playing all instances of the indicated CameraAnim.</summary>
        ///<remarks>
        ///@param bImmediate    True to stop it right now and ignore blend out, false to let it blend out as indicated.
        ///</remarks>
        public void StopAllInstancesOfCameraAnim(CameraAnim Anim, bool bImmediate)  => 
            PlayerCameraManager_methods.StopAllInstancesOfCameraAnim_method.Invoke(ObjPointer, Anim, bImmediate);

        ///<summary>Stops playing CameraShake of the given class.</summary>
        public void StopAllInstancesOfCameraShake(SubclassOf<CameraShake> Shake, bool bImmediately)  => 
            PlayerCameraManager_methods.StopAllInstancesOfCameraShake_method.Invoke(ObjPointer, Shake, bImmediately);

        ///<summary>Stops the given CameraAnimInst from playing.</summary>
        ///<remarks>
        ///The given pointer should be considered invalid after this.
        ///@param bImmediate    True to stop it right now and ignore blend out, false to let it blend out as indicated.
        ///</remarks>
        public void StopCameraAnimInst(CameraAnimInst AnimInst, bool bImmediate)  => 
            PlayerCameraManager_methods.StopCameraAnimInst_method.Invoke(ObjPointer, AnimInst, bImmediate);

        ///<summary>Stops camera fading.</summary>
        public void StopCameraFade()  => 
            PlayerCameraManager_methods.StopCameraFade_method.Invoke(ObjPointer);

        ///<summary>Immediately stops the given shake instance and invalidates it.</summary>
        public void StopCameraShake(CameraShake ShakeInstance, bool bImmediately)  => 
            PlayerCameraManager_methods.StopCameraShake_method.Invoke(ObjPointer, ShakeInstance, bImmediately);
        ///<summary>PlayerController that owns this Camera actor</summary>
        public unsafe PlayerController PCOwner {
            get {return PlayerCameraManager_ptr->PCOwner;}
            set {PlayerCameraManager_ptr->PCOwner = value;}
        }
        ///<summary>Dummy component we can use to attach things to the camera.</summary>
        public unsafe SceneComponent TransformComponent {
            get {return PlayerCameraManager_ptr->TransformComponent;}
        }
        ///<summary>FOV to use by default.</summary>
        public unsafe float DefaultFOV {
            get {return PlayerCameraManager_ptr->DefaultFOV;}
            set {PlayerCameraManager_ptr->DefaultFOV = value;}
        }
        ///<summary>The default desired width (in world units) of the orthographic view (ignored in Perspective mode)</summary>
        public unsafe float DefaultOrthoWidth {
            get {return PlayerCameraManager_ptr->DefaultOrthoWidth;}
            set {PlayerCameraManager_ptr->DefaultOrthoWidth = value;}
        }
        ///<summary>Default aspect ratio (used when a view target override the aspect ratio and bConstrainAspectRatio is set; most of the time the value from a camera component will be used instead)</summary>
        public unsafe float DefaultAspectRatio {
            get {return PlayerCameraManager_ptr->DefaultAspectRatio;}
            set {PlayerCameraManager_ptr->DefaultAspectRatio = value;}
        }
        ///<summary>Camera Cache</summary>
        public unsafe CameraCacheEntry CameraCache {
            get {return PlayerCameraManager_ptr->CameraCache;}
            set {PlayerCameraManager_ptr->CameraCache = value;}
        }
        ///<summary>Last Frame Camera Cache</summary>
        public unsafe CameraCacheEntry LastFrameCameraCache {
            get {return PlayerCameraManager_ptr->LastFrameCameraCache;}
            set {PlayerCameraManager_ptr->LastFrameCameraCache = value;}
        }
        ///<summary>Current ViewTarget</summary>
        public unsafe TViewTarget ViewTarget {
            get {return PlayerCameraManager_ptr->ViewTarget;}
            set {PlayerCameraManager_ptr->ViewTarget = value;}
        }
        ///<summary>Pending view target for blending</summary>
        public unsafe TViewTarget PendingViewTarget {
            get {return PlayerCameraManager_ptr->PendingViewTarget;}
            set {PlayerCameraManager_ptr->PendingViewTarget = value;}
        }
        ///<summary>Cached camera properties.</summary>
        public unsafe CameraCacheEntry CameraCachePrivate {
            get {return PlayerCameraManager_ptr->CameraCachePrivate;}
            set {PlayerCameraManager_ptr->CameraCachePrivate = value;}
        }
        ///<summary>Cached camera properties, one frame old.</summary>
        public unsafe CameraCacheEntry LastFrameCameraCachePrivate {
            get {return PlayerCameraManager_ptr->LastFrameCameraCachePrivate;}
            set {PlayerCameraManager_ptr->LastFrameCameraCachePrivate = value;}
        }
        ///<summary>List of active camera modifier instances that have a chance to update the final camera POV</summary>
        public ObjectArrayField<CameraModifier> ModifierList{ get {
            if(ModifierList_store == null) ModifierList_store = new ObjectArrayField<CameraModifier> (&PlayerCameraManager_ptr->ModifierList);
            return ModifierList_store;
        } }
        private ObjectArrayField<CameraModifier> ModifierList_store;

        ///<summary>List of modifiers to create by default for this camera</summary>
        public ObjectArrayField<Class> DefaultModifiers{ get {
            if(DefaultModifiers_store == null) DefaultModifiers_store = new ObjectArrayField<Class> (&PlayerCameraManager_ptr->DefaultModifiers);
            return DefaultModifiers_store;
        } }
        private ObjectArrayField<Class> DefaultModifiers_store;

        ///<summary>Distance to place free camera from view target (used in certain CameraStyles)</summary>
        public unsafe float FreeCamDistance {
            get {return PlayerCameraManager_ptr->FreeCamDistance;}
            set {PlayerCameraManager_ptr->FreeCamDistance = value;}
        }
        ///<summary>Offset to Z free camera position (used in certain CameraStyles)</summary>
        public unsafe Vector FreeCamOffset {
            get {return PlayerCameraManager_ptr->FreeCamOffset;}
            set {PlayerCameraManager_ptr->FreeCamOffset = value;}
        }
        ///<summary>Offset to view target (used in certain CameraStyles)</summary>
        public unsafe Vector ViewTargetOffset {
            get {return PlayerCameraManager_ptr->ViewTargetOffset;}
            set {PlayerCameraManager_ptr->ViewTargetOffset = value;}
        }
        ///<summary>CameraBlood emitter attached to this camera</summary>
        public ObjectArrayField<EmitterCameraLensEffectBase> CameraLensEffects{ get {
            if(CameraLensEffects_store == null) CameraLensEffects_store = new ObjectArrayField<EmitterCameraLensEffectBase> (&PlayerCameraManager_ptr->CameraLensEffects);
            return CameraLensEffects_store;
        } }
        private ObjectArrayField<EmitterCameraLensEffectBase> CameraLensEffects_store;

        ///<summary>Cached ref to modifier for code-driven screen shakes</summary>
        public unsafe CameraModifier_CameraShake CachedCameraShakeMod {
            get {return PlayerCameraManager_ptr->CachedCameraShakeMod;}
            set {PlayerCameraManager_ptr->CachedCameraShakeMod = value;}
        }
        ///<summary>Internal pool of camera anim instance objects available for playing camera animations. Defines the max number of camera anims that can play simultaneously.</summary>
        public unsafe CameraAnimInst AnimInstPool {
            get {return PlayerCameraManager_ptr->AnimInstPool;}
            set {PlayerCameraManager_ptr->AnimInstPool = value;}
        }
         //TODO: array not UObject TArray PostProcessBlendCache
        ///<summary>Array of camera anim instances that are currently playing and in-use</summary>
        public ObjectArrayField<CameraAnimInst> ActiveAnims{ get {
            if(ActiveAnims_store == null) ActiveAnims_store = new ObjectArrayField<CameraAnimInst> (&PlayerCameraManager_ptr->ActiveAnims);
            return ActiveAnims_store;
        } }
        private ObjectArrayField<CameraAnimInst> ActiveAnims_store;

        ///<summary>Array of camera anim instances that are not playing and available to be used.</summary>
        public ObjectArrayField<CameraAnimInst> FreeAnims{ get {
            if(FreeAnims_store == null) FreeAnims_store = new ObjectArrayField<CameraAnimInst> (&PlayerCameraManager_ptr->FreeAnims);
            return FreeAnims_store;
        } }
        private ObjectArrayField<CameraAnimInst> FreeAnims_store;

        ///<summary>Internal. Receives the output of individual camera animations.</summary>
        public unsafe CameraActor AnimCameraActor {
            get {return PlayerCameraManager_ptr->AnimCameraActor;}
            set {PlayerCameraManager_ptr->AnimCameraActor = value;}
        }
        public bool bIsOrthographic {
            get {return Main.GetGetBoolPropertyByName(this, "bIsOrthographic"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsOrthographic", value); }
        }
        public bool bDefaultConstrainAspectRatio {
            get {return Main.GetGetBoolPropertyByName(this, "bDefaultConstrainAspectRatio"); }
            set {Main.SetGetBoolPropertyByName(this, "bDefaultConstrainAspectRatio", value); }
        }
        public bool bClientSimulatingViewTarget {
            get {return Main.GetGetBoolPropertyByName(this, "bClientSimulatingViewTarget"); }
            set {Main.SetGetBoolPropertyByName(this, "bClientSimulatingViewTarget", value); }
        }
        public bool bUseClientSideCameraUpdates {
            get {return Main.GetGetBoolPropertyByName(this, "bUseClientSideCameraUpdates"); }
        }
        public bool bGameCameraCutThisFrame {
            get {return Main.GetGetBoolPropertyByName(this, "bGameCameraCutThisFrame"); }
        }
        ///<summary>Minimum view pitch, in degrees.</summary>
        public unsafe float ViewPitchMin {
            get {return PlayerCameraManager_ptr->ViewPitchMin;}
            set {PlayerCameraManager_ptr->ViewPitchMin = value;}
        }
        ///<summary>Maximum view pitch, in degrees.</summary>
        public unsafe float ViewPitchMax {
            get {return PlayerCameraManager_ptr->ViewPitchMax;}
            set {PlayerCameraManager_ptr->ViewPitchMax = value;}
        }
        ///<summary>Minimum view yaw, in degrees.</summary>
        public unsafe float ViewYawMin {
            get {return PlayerCameraManager_ptr->ViewYawMin;}
            set {PlayerCameraManager_ptr->ViewYawMin = value;}
        }
        ///<summary>Maximum view yaw, in degrees.</summary>
        public unsafe float ViewYawMax {
            get {return PlayerCameraManager_ptr->ViewYawMax;}
            set {PlayerCameraManager_ptr->ViewYawMax = value;}
        }
        ///<summary>Minimum view roll, in degrees.</summary>
        public unsafe float ViewRollMin {
            get {return PlayerCameraManager_ptr->ViewRollMin;}
            set {PlayerCameraManager_ptr->ViewRollMin = value;}
        }
        ///<summary>Maximum view roll, in degrees.</summary>
        public unsafe float ViewRollMax {
            get {return PlayerCameraManager_ptr->ViewRollMax;}
            set {PlayerCameraManager_ptr->ViewRollMax = value;}
        }
        static PlayerCameraManager() {
            StaticClass = Main.GetClass("PlayerCameraManager");
            PlayerCameraManager_events.BlueprintUpdateCamera_event.Setup();
            PlayerCameraManager_events.OnPhotographyMultiPartCaptureEnd_event.Setup();
            PlayerCameraManager_events.OnPhotographyMultiPartCaptureStart_event.Setup();
            PlayerCameraManager_events.OnPhotographySessionEnd_event.Setup();
            PlayerCameraManager_events.OnPhotographySessionStart_event.Setup();
            PlayerCameraManager_events.PhotographyCameraModify_event.Setup();
        }
        internal unsafe PlayerCameraManager_fields* PlayerCameraManager_ptr => (PlayerCameraManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PlayerCameraManager(IntPtr p) => UObject.Make<PlayerCameraManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PlayerCameraManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PlayerCameraManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

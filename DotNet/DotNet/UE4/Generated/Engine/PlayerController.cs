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
using UE4.InputCore;
using UE4.UMG;

namespace UE4.Engine {
    ///<summary>PlayerControllers are used by human players to control Pawns.</summary>
    ///<remarks>
    ///ControlRotation (accessed via GetControlRotation()), determines the aiming
    ///orientation of the controlled Pawn.
    ///
    ///In networked games, PlayerControllers exist on the server for every player-controlled pawn,
    ///and also on the controlling client's machine. They do NOT exist on a client's
    ///machine for pawns controlled by remote players elsewhere on the network.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/Controller/PlayerController/
    ///</remarks>
    public unsafe partial class PlayerController : Controller  {

        ///<summary>Activates a new touch interface for this player controller</summary>
        public void ActivateTouchInterface(TouchInterface NewTouchInterface)  => 
            PlayerController_methods.ActivateTouchInterface_method.Invoke(ObjPointer, NewTouchInterface);

        ///<summary>Add Pitch (look up) input.</summary>
        ///<remarks>
        ///This value is multiplied by InputPitchScale.
        ///@param Val Amount to add to Pitch. This value is multiplied by InputPitchScale.
        ///</remarks>
        public void AddPitchInput(float Val)  => 
            PlayerController_methods.AddPitchInput_method.Invoke(ObjPointer, Val);

        ///<summary>Add Roll input.</summary>
        ///<remarks>
        ///This value is multiplied by InputRollScale.
        ///@param Val Amount to add to Roll. This value is multiplied by InputRollScale.
        ///</remarks>
        public void AddRollInput(float Val)  => 
            PlayerController_methods.AddRollInput_method.Invoke(ObjPointer, Val);

        ///<summary>Add Yaw (turn) input.</summary>
        ///<remarks>
        ///This value is multiplied by InputYawScale.
        ///@param Val Amount to add to Yaw. This value is multiplied by InputYawScale.
        ///</remarks>
        public void AddYawInput(float Val)  => 
            PlayerController_methods.AddYawInput_method.Invoke(ObjPointer, Val);

        ///<summary>@return true if this controller thinks it's able to restart. Called from GameModeBase::PlayerCanRestart</summary>
        public bool CanRestartPlayer()  => 
            PlayerController_methods.CanRestartPlayer_method.Invoke(ObjPointer);

        ///<summary>Clear Audio Listener Attenuation Override</summary>
        public void ClearAudioListenerAttenuationOverride()  => 
            PlayerController_methods.ClearAudioListenerAttenuationOverride_method.Invoke(ObjPointer);

        ///<summary>Clear any overrides that have been applied to audio listener</summary>
        public void ClearAudioListenerOverride()  => 
            PlayerController_methods.ClearAudioListenerOverride_method.Invoke(ObjPointer);

        ///<summary>Removes all Camera Lens Effects.</summary>
        public void ClientClearCameraLensEffects()  => 
            PlayerController_methods.ClientClearCameraLensEffects_method.Invoke(ObjPointer);

        ///<summary>Play the indicated CameraAnim on this camera.</summary>
        ///<remarks>
        ///@param AnimToPlay - Camera animation to play
        ///@param Scale - "Intensity" scalar.  This is the scale at which the anim was first played.
        ///@param Rate -  Multiplier for playback rate.  1.0 = normal.
        ///@param BlendInTime - Time to interpolate in from zero, for smooth starts
        ///@param BlendOutTime - Time to interpolate out to zero, for smooth finishes
        ///@param bLoop - True if the animation should loop, false otherwise
        ///@param bRandomStartTime - Whether or not to choose a random time to start playing.  Only really makes sense for bLoop = true
        ///@param Space - Animation play area
        ///@param CustomPlaySpace - Matrix used when Space = CAPS_UserDefined
        ///</remarks>
        public void ClientPlayCameraAnim(CameraAnim AnimToPlay, float Scale, float Rate, float BlendInTime, float BlendOutTime, bool bLoop, bool bRandomStartTime, byte Space, Rotator CustomPlaySpace)  => 
            PlayerController_methods.ClientPlayCameraAnim_method.Invoke(ObjPointer, AnimToPlay, Scale, Rate, BlendInTime, BlendOutTime, bLoop, bRandomStartTime, Space, CustomPlaySpace);

        ///<summary>
        ///Play Camera Shake
        ///@
        ///</summary>
        ///<remarks>
        ///param Shake - Camera shake animation to play
        ///@param Scale - Scalar defining how "intense" to play the anim
        ///@param PlaySpace - Which coordinate system to play the shake in (used for CameraAnims within the shake).
        ///@param UserPlaySpaceRot - Matrix used when PlaySpace = CAPS_UserDefined
        ///</remarks>
        public void ClientPlayCameraShake(SubclassOf<CameraShake> Shake, float Scale, byte PlaySpace, Rotator UserPlaySpaceRot)  => 
            PlayerController_methods.ClientPlayCameraShake_method.Invoke(ObjPointer, Shake, Scale, PlaySpace, UserPlaySpaceRot);

        ///<summary>
        ///Play a force feedback pattern on the player's controller
        ///@
        ///</summary>
        ///<remarks>
        ///param       ForceFeedbackEffect             The force feedback pattern to play
        ///@param       bLooping                                Whether the pattern should be played repeatedly or be a single one shot
        ///@param       bIgnoreTimeDilation             Whether the pattern should ignore time dilation
        ///@param       Tag                                             A tag that allows stopping of an effect.  If another effect with this Tag is playing, it will be stopped and replaced
        ///</remarks>
        public void ClientPlayForceFeedback(ForceFeedbackEffect ForceFeedbackEffect, bool bLooping, bool bIgnoreTimeDilation, Name Tag)  => 
            PlayerController_methods.ClientPlayForceFeedback_method.Invoke(ObjPointer, ForceFeedbackEffect, bLooping, bIgnoreTimeDilation, Tag);

        ///<summary>Set the client's class of HUD and spawns a new instance of it. If there was already a HUD active, it is destroyed.</summary>
        public void ClientSetHUD(SubclassOf<HUD> NewHUDClass)  => 
            PlayerController_methods.ClientSetHUD_method.Invoke(ObjPointer, NewHUDClass);

        ///<summary>Spawn a camera lens effect (e.g. blood).</summary>
        public void ClientSpawnCameraLensEffect(SubclassOf<EmitterCameraLensEffectBase> LensEffectEmitterClass)  => 
            PlayerController_methods.ClientSpawnCameraLensEffect_method.Invoke(ObjPointer, LensEffectEmitterClass);

        ///<summary>Stop camera shake on client.</summary>
        public void ClientStopCameraShake(SubclassOf<CameraShake> Shake, bool bImmediately)  => 
            PlayerController_methods.ClientStopCameraShake_method.Invoke(ObjPointer, Shake, bImmediately);

        ///<summary>
        ///Stops a playing force feedback pattern
        ///@
        ///</summary>
        ///<remarks>
        ///param       ForceFeedbackEffect             If set only patterns from that effect will be stopped
        ///@param       Tag                                             If not none only the pattern with this tag will be stopped
        ///</remarks>
        public void ClientStopForceFeedback(ForceFeedbackEffect ForceFeedbackEffect, Name Tag)  => 
            PlayerController_methods.ClientStopForceFeedback_method.Invoke(ObjPointer, ForceFeedbackEffect, Tag);

        ///<summary>Convert current mouse 2D position to World Space 3D position and direction. Returns false if unable to determine value. *</summary>
        public (Vector, Vector, bool) DeprojectMousePositionToWorld()  => 
            PlayerController_methods.DeprojectMousePositionToWorld_method.Invoke(ObjPointer);

        ///<summary>Convert 2D screen position to World Space 3D position and direction. Returns false if unable to determine value. *</summary>
        public (Vector, Vector, bool) DeprojectScreenPositionToWorld(float ScreenX, float ScreenY)  => 
            PlayerController_methods.DeprojectScreenPositionToWorld_method.Invoke(ObjPointer, ScreenX, ScreenY);

        ///<summary>Returns the location the PlayerController is focused on.</summary>
        ///<remarks>
        ///If there is a possessed Pawn, returns the Pawn's location.
        /// If there is a spectator Pawn, returns that Pawn's location.
        /// Otherwise, returns the PlayerController's spawn location (usually the last known Pawn location after it has died).
        ///</remarks>
        public Vector GetFocalLocation()  => 
            PlayerController_methods.GetFocalLocation_method.Invoke(ObjPointer);

        ///<summary>Get Hit Result Under Cursor</summary>
        public (HitResult, bool) GetHitResultUnderCursor(byte TraceChannel, bool bTraceComplex)  => 
            PlayerController_methods.GetHitResultUnderCursor_method.Invoke(ObjPointer, TraceChannel, bTraceComplex);

        ///<summary>Performs a collision query under the mouse cursor, looking on a trace channel</summary>
        public (HitResult, bool) GetHitResultUnderCursorByChannel(byte TraceChannel, bool bTraceComplex)  => 
            PlayerController_methods.GetHitResultUnderCursorByChannel_method.Invoke(ObjPointer, TraceChannel, bTraceComplex);

        ///<summary>Performs a collision query under the mouse cursor, looking for object types</summary>
        public (HitResult, bool) GetHitResultUnderCursorForObjects(byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex)  => 
            PlayerController_methods.GetHitResultUnderCursorForObjects_method.Invoke(ObjPointer, ObjectTypes, bTraceComplex);

        ///<summary>Get Hit Result Under Finger</summary>
        public (HitResult, bool) GetHitResultUnderFinger(byte FingerIndex, byte TraceChannel, bool bTraceComplex)  => 
            PlayerController_methods.GetHitResultUnderFinger_method.Invoke(ObjPointer, FingerIndex, TraceChannel, bTraceComplex);

        ///<summary>Performs a collision query under the finger, looking on a trace channel</summary>
        public (HitResult, bool) GetHitResultUnderFingerByChannel(byte FingerIndex, byte TraceChannel, bool bTraceComplex)  => 
            PlayerController_methods.GetHitResultUnderFingerByChannel_method.Invoke(ObjPointer, FingerIndex, TraceChannel, bTraceComplex);

        ///<summary>Performs a collision query under the finger, looking for object types</summary>
        public (HitResult, bool) GetHitResultUnderFingerForObjects(byte FingerIndex, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex)  => 
            PlayerController_methods.GetHitResultUnderFingerForObjects_method.Invoke(ObjPointer, FingerIndex, ObjectTypes, bTraceComplex);

        ///<summary>Gets the HUD currently being used by this player controller</summary>
        public HUD GetHUD()  => 
            PlayerController_methods.GetHUD_method.Invoke(ObjPointer);

        ///<summary>Returns the analog value for the given key/button.  If analog isn't supported, returns 1 for down and 0 for up.</summary>
        public float GetInputAnalogKeyState(Key Key)  => 
            PlayerController_methods.GetInputAnalogKeyState_method.Invoke(ObjPointer, Key);

        ///<summary>Retrieves the X and Y displacement of the given analog stick.</summary>
        public (float, float) GetInputAnalogStickState(byte WhichStick)  => 
            PlayerController_methods.GetInputAnalogStickState_method.Invoke(ObjPointer, WhichStick);

        ///<summary>Returns how long the given key/button has been down.  Returns 0 if it's up or it just went down this frame.</summary>
        public float GetInputKeyTimeDown(Key Key)  => 
            PlayerController_methods.GetInputKeyTimeDown_method.Invoke(ObjPointer, Key);

        ///<summary>Retrieves the current motion state of the player's input device</summary>
        public (Vector, Vector, Vector, Vector) GetInputMotionState()  => 
            PlayerController_methods.GetInputMotionState_method.Invoke(ObjPointer);

        ///<summary>Retrieves how far the mouse moved this frame.</summary>
        public (float, float) GetInputMouseDelta()  => 
            PlayerController_methods.GetInputMouseDelta_method.Invoke(ObjPointer);

        ///<summary>Retrieves the X and Y screen coordinates of the specified touch key. Returns false if the touch index is not down</summary>
        public (float, float, bool) GetInputTouchState(byte FingerIndex)  => 
            PlayerController_methods.GetInputTouchState_method.Invoke(ObjPointer, FingerIndex);

        ///<summary>Returns the vector value for the given key/button.</summary>
        public Vector GetInputVectorKeyState(Key Key)  => 
            PlayerController_methods.GetInputVectorKeyState_method.Invoke(ObjPointer, Key);

        ///<summary>Retrieves the X and Y screen coordinates of the mouse cursor. Returns false if there is no associated mouse device</summary>
        public (float, float, bool) GetMousePosition()  => 
            PlayerController_methods.GetMousePosition_method.Invoke(ObjPointer);

        ///<summary>Get the Pawn used when spectating. nullptr when not spectating.</summary>
        public SpectatorPawn GetSpectatorPawn()  => 
            PlayerController_methods.GetSpectatorPawn_method.Invoke(ObjPointer);

        ///<summary>Helper to get the size of the HUD canvas for this player controller.  Returns 0 if there is no HUD</summary>
        public (int, int) GetViewportSize()  => 
            PlayerController_methods.GetViewportSize_method.Invoke(ObjPointer);

        ///<summary>Returns true if the given key/button is pressed on the input of the controller (if present)</summary>
        public bool IsInputKeyDown(Key Key)  => 
            PlayerController_methods.IsInputKeyDown_method.Invoke(ObjPointer, Key);

        ///<summary>
        ///Latent action that controls the playing of force feedback
        ///Begins playing when Start is called.
        ///</summary>
        ///<remarks>
        ///Calling Update or Stop if the feedback is not active will have no effect.
        ///Completed will execute when Stop is called or the duration ends.
        ///When Update is called the Intensity, Duration, and affect values will be updated with the current inputs
        ///@param       Intensity                               How strong the feedback should be.  Valid values are between 0.0 and 1.0
        ///@param       Duration                                How long the feedback should play for.  If the value is negative it will play until stopped
        ///@param   bAffectsLeftLarge           Whether the intensity should be applied to the large left servo
        ///@param   bAffectsLeftSmall           Whether the intensity should be applied to the small left servo
        ///@param   bAffectsRightLarge          Whether the intensity should be applied to the large right servo
        ///@param   bAffectsRightSmall          Whether the intensity should be applied to the small right servo
        ///</remarks>
        public void PlayDynamicForceFeedback(float Intensity, float Duration, bool bAffectsLeftLarge, bool bAffectsLeftSmall, bool bAffectsRightLarge, bool bAffectsRightSmall, byte Action, LatentActionInfo LatentInfo)  => 
            PlayerController_methods.PlayDynamicForceFeedback_method.Invoke(ObjPointer, Intensity, Duration, bAffectsLeftLarge, bAffectsLeftSmall, bAffectsRightLarge, bAffectsRightSmall, Action, LatentInfo);

        ///<summary>
        ///Play a haptic feedback curve on the player's controller
        ///@
        ///</summary>
        ///<remarks>
        ///param       HapticEffect                    The haptic effect to play
        ///@param       Hand                                    Which hand to play the effect on
        ///@param       Scale                                   Scale between 0.0 and 1.0 on the intensity of playback
        ///</remarks>
        public void PlayHapticEffect(HapticFeedbackEffect_Base HapticEffect, EControllerHand Hand, float Scale, bool bLoop)  => 
            PlayerController_methods.PlayHapticEffect_method.Invoke(ObjPointer, HapticEffect, Hand, Scale, bLoop);

        ///<summary>Convert a World Space 3D position into a 2D Screen Space position.</summary>
        ///<remarks>
        ///@return true if the world coordinate was successfully projected to the screen.
        ///</remarks>
        public (Vector2D, bool) ProjectWorldLocationToScreen(Vector WorldLocation, bool bPlayerViewportRelative)  => 
            PlayerController_methods.ProjectWorldLocationToScreen_method.Invoke(ObjPointer, WorldLocation, bPlayerViewportRelative);

        ///<summary>Set Audio Listener Attenuation Override</summary>
        public void SetAudioListenerAttenuationOverride(SceneComponent AttachToComponent, Vector AttenuationLocationOVerride)  => 
            PlayerController_methods.SetAudioListenerAttenuationOverride_method.Invoke(ObjPointer, AttachToComponent, AttenuationLocationOVerride);

        ///<summary>
        ///Used to override the default positioning of the audio listener
        ///@
        ///</summary>
        ///<remarks>
        ///param AttachToComponent Optional component to attach the audio listener to
        ///@param Location Depending on whether Component is attached this is either an offset from its location or an absolute position
        ///@param Rotation Depending on whether Component is attached this is either an offset from its rotation or an absolute rotation
        ///</remarks>
        public void SetAudioListenerOverride(SceneComponent AttachToComponent, Vector Location, Rotator Rotation)  => 
            PlayerController_methods.SetAudioListenerOverride_method.Invoke(ObjPointer, AttachToComponent, Location, Rotation);

        ///<summary>Server/SP only function for changing whether the player is in cinematic mode.</summary>
        ///<remarks>
        ///Updates values of various state variables, then replicates the call to the client
        ///to sync the current cinematic mode.
        ///@param       bInCinematicMode        specify true if the player is entering cinematic mode; false if the player is leaving cinematic mode.
        ///@param       bHidePlayer                     specify true to hide the player's pawn (only relevant if bInCinematicMode is true)
        ///@param       bAffectsHUD                     specify true if we should show/hide the HUD to match the value of bCinematicMode
        ///@param       bAffectsMovement        specify true to disable movement in cinematic mode, enable it when leaving
        ///@param       bAffectsTurning         specify true to disable turning in cinematic mode or enable it when leaving
        ///</remarks>
        public void SetCinematicMode(bool bInCinematicMode, bool bHidePlayer, bool bAffectsHUD, bool bAffectsMovement, bool bAffectsTurning)  => 
            PlayerController_methods.SetCinematicMode_method.Invoke(ObjPointer, bInCinematicMode, bHidePlayer, bAffectsHUD, bAffectsMovement, bAffectsTurning);

        ///<summary>
        ///Sets the light color of the player's controller
        ///@
        ///</summary>
        ///<remarks>param       Color                                   The color for the light to be</remarks>
        public void SetControllerLightColor(Color Color)  => 
            PlayerController_methods.SetControllerLightColor_method.Invoke(ObjPointer, Color);

        ///<summary>Allows the player controller to disable all haptic requests from being fired, e.</summary>
        ///<remarks>
        ///g. in the case of a level loading
        ///
        ///@param       bNewDisabled    If TRUE, the haptics will stop and prevented from being enabled again until set to FALSE
        ///</remarks>
        public void SetDisableHaptics(bool bNewDisabled)  => 
            PlayerController_methods.SetDisableHaptics_method.Invoke(ObjPointer, bNewDisabled);

        ///<summary>Sets the value of the haptics for the specified hand directly, using frequency and amplitude.</summary>
        ///<remarks>
        ///NOTE:  If a curve is already
        ///playing for this hand, it will be cancelled in favour of the specified values.
        ///
        ///@param       Frequency                               The normalized frequency [0.0, 1.0] to play through the haptics system
        ///@param       Amplitude                               The normalized amplitude [0.0, 1.0] to set the haptic feedback to
        ///@param       Hand                                    Which hand to play the effect on
        ///</remarks>
        public void SetHapticsByValue(float Frequency, float Amplitude, EControllerHand Hand)  => 
            PlayerController_methods.SetHapticsByValue_method.Invoke(ObjPointer, Frequency, Amplitude, Hand);

        ///<summary>
        ///Sets the Widget for the Mouse Cursor to display
        ///@
        ///</summary>
        ///<remarks>
        ///param Cursor - the cursor to set the widget for
        ///@param CursorWidget - the widget to set the cursor to
        ///</remarks>
        public void SetMouseCursorWidget(byte Cursor, UserWidget CursorWidget)  => 
            PlayerController_methods.SetMouseCursorWidget_method.Invoke(ObjPointer, Cursor, CursorWidget);

        ///<summary>Positions the mouse cursor in screen space, in pixels.</summary>
        public void SetMouseLocation(int X, int Y)  => 
            PlayerController_methods.SetMouseLocation_method.Invoke(ObjPointer, X, Y);

        ///<summary>
        ///Set the view target blending with variable control
        ///@
        ///</summary>
        ///<remarks>
        ///param NewViewTarget - new actor to set as view target
        ///@param BlendTime - time taken to blend
        ///@param BlendFunc - Cubic, Linear etc functions for blending
        ///@param BlendExp -  Exponent, used by certain blend functions to control the shape of the curve.
        ///@param bLockOutgoing - If true, lock outgoing viewtarget to last frame's camera position for the remainder of the blend.
        ///</remarks>
        public void SetViewTargetWithBlend(Actor NewViewTarget, float BlendTime, byte BlendFunc, float BlendExp, bool bLockOutgoing)  => 
            PlayerController_methods.SetViewTargetWithBlend_method.Invoke(ObjPointer, NewViewTarget, BlendTime, BlendFunc, BlendExp, bLockOutgoing);

        ///<summary>Set the virtual joystick visibility.</summary>
        public void SetVirtualJoystickVisibility(bool bVisible)  => 
            PlayerController_methods.SetVirtualJoystickVisibility_method.Invoke(ObjPointer, bVisible);

        ///<summary>
        ///Stops a playing haptic feedback curve
        ///@
        ///</summary>
        ///<remarks>
        ///param       HapticEffect                    The haptic effect to stop
        ///@param       Hand                                    Which hand to stop the effect for
        ///</remarks>
        public void StopHapticEffect(EControllerHand Hand)  => 
            PlayerController_methods.StopHapticEffect_method.Invoke(ObjPointer, Hand);

        ///<summary>Returns true if the given key/button was up last frame and down this frame.</summary>
        public bool WasInputKeyJustPressed(Key Key)  => 
            PlayerController_methods.WasInputKeyJustPressed_method.Invoke(ObjPointer, Key);

        ///<summary>Returns true if the given key/button was down last frame and up this frame.</summary>
        public bool WasInputKeyJustReleased(Key Key)  => 
            PlayerController_methods.WasInputKeyJustReleased_method.Invoke(ObjPointer, Key);
        ///<summary>UPlayer associated with this PlayerController.  Could be a local player or a net connection.</summary>
        public unsafe Player Player {
            get {return PlayerController_ptr->Player;}
            set {PlayerController_ptr->Player = value;}
        }
        ///<summary>Used in net games so client can acknowledge it possessed a specific pawn.</summary>
        public unsafe Pawn AcknowledgedPawn {
            get {return PlayerController_ptr->AcknowledgedPawn;}
            set {PlayerController_ptr->AcknowledgedPawn = value;}
        }
        ///<summary>Director track that's currently possessing this player controller, or none if not possessed.</summary>
        public unsafe InterpTrackInstDirector ControllingDirTrackInst {
            get {return PlayerController_ptr->ControllingDirTrackInst;}
            set {PlayerController_ptr->ControllingDirTrackInst = value;}
        }
        ///<summary>Heads up display associated with this PlayerController.</summary>
        public unsafe HUD MyHUD {
            get {return PlayerController_ptr->MyHUD;}
            set {PlayerController_ptr->MyHUD = value;}
        }
        ///<summary>Camera manager associated with this Player Controller.</summary>
        public unsafe PlayerCameraManager PlayerCameraManager {
            get {return PlayerController_ptr->PlayerCameraManager;}
        }
        ///<summary>PlayerCamera class should be set for each game, otherwise Engine.PlayerCameraManager is used</summary>
        public unsafe SubclassOf<PlayerCameraManager> PlayerCameraManagerClass {
            get {return PlayerController_ptr->PlayerCameraManagerClass;}
        }
        public bool bAutoManageActiveCameraTarget {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoManageActiveCameraTarget"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoManageActiveCameraTarget", value); }
        }
        ///<summary>Used to replicate the view rotation of targets not owned/possessed by this PlayerController.</summary>
        public unsafe Rotator TargetViewRotation {
            get {return PlayerController_ptr->TargetViewRotation;}
            set {PlayerController_ptr->TargetViewRotation = value;}
        }
        ///<summary>Interp speed for blending remote view rotation for smoother client updates</summary>
        public unsafe float SmoothTargetViewRotationSpeed {
            get {return PlayerController_ptr->SmoothTargetViewRotationSpeed;}
            set {PlayerController_ptr->SmoothTargetViewRotationSpeed = value;}
        }
        ///<summary>The actors which the camera shouldn't see - e.g. used to hide actors which the camera penetrates</summary>
        public ObjectArrayField<Actor> HiddenActors{ get {
            if(HiddenActors_store == null) HiddenActors_store = new ObjectArrayField<Actor> (&PlayerController_ptr->HiddenActors);
            return HiddenActors_store;
        } }
        private ObjectArrayField<Actor> HiddenActors_store;

         //TODO: array not UObject TArray HiddenPrimitiveComponents
        ///<summary>Used to make sure the client is kept synchronized when in a spectator state</summary>
        public unsafe float LastSpectatorStateSynchTime {
            get {return PlayerController_ptr->LastSpectatorStateSynchTime;}
            set {PlayerController_ptr->LastSpectatorStateSynchTime = value;}
        }
        ///<summary>Last location synced on the server for a spectator.</summary>
        public unsafe Vector LastSpectatorSyncLocation {
            get {return PlayerController_ptr->LastSpectatorSyncLocation;}
            set {PlayerController_ptr->LastSpectatorSyncLocation = value;}
        }
        ///<summary>Last rotation synced on the server for a spectator.</summary>
        public unsafe Rotator LastSpectatorSyncRotation {
            get {return PlayerController_ptr->LastSpectatorSyncRotation;}
            set {PlayerController_ptr->LastSpectatorSyncRotation = value;}
        }
        ///<summary>Cap set by server on bandwidth from client to server in bytes/sec (only has impact if >=2600)</summary>
        public unsafe int ClientCap {
            get {return PlayerController_ptr->ClientCap;}
            set {PlayerController_ptr->ClientCap = value;}
        }
        ///<summary>Object that manages "cheat" commands.  Not instantiated in shipping builds.</summary>
        public unsafe CheatManager CheatManager {
            get {return PlayerController_ptr->CheatManager;}
        }
        ///<summary>Class of my CheatManager.  The Cheat Manager is not created in shipping builds</summary>
        public unsafe SubclassOf<CheatManager> CheatClass {
            get {return PlayerController_ptr->CheatClass;}
        }
        ///<summary>Object that manages player input.</summary>
        public unsafe PlayerInput PlayerInput {
            get {return PlayerController_ptr->PlayerInput;}
            set {PlayerController_ptr->PlayerInput = value;}
        }
         //TODO: array not UObject TArray ActiveForceFeedbackEffects
        public bool bPlayerIsWaiting {
            get {return Main.GetGetBoolPropertyByName(this, "bPlayerIsWaiting"); }
        }
        ///<summary>
        ///Index identifying players using the same base connection (splitscreen clients)
        ///Used by netcode to match replicated PlayerControllers to the correct splitscreen viewport and child connection
        ///</summary>
        ///<remarks>replicated via special internal code, not through normal variable replication</remarks>
        public unsafe byte NetPlayerIndex {
            get {return PlayerController_ptr->NetPlayerIndex;}
            set {PlayerController_ptr->NetPlayerIndex = value;}
        }
        ///<summary>
        ///This is set on the OLD PlayerController when performing a swap over a network connection
        ///so we know what connection we're waiting on acknowledgment from to finish destroying this PC
        ///(or when the connection is closed)
        ///@
        ///</summary>
        ///<remarks>see GameModeBase::SwapPlayerControllers()</remarks>
        public unsafe NetConnection PendingSwapConnection {
            get {return PlayerController_ptr->PendingSwapConnection;}
            set {PlayerController_ptr->PendingSwapConnection = value;}
        }
        ///<summary>The net connection this controller is communicating on, nullptr for local players on server</summary>
        public unsafe NetConnection NetConnection {
            get {return PlayerController_ptr->NetConnection;}
            set {PlayerController_ptr->NetConnection = value;}
        }
        ///<summary>Yaw input speed scaling</summary>
        public unsafe float InputYawScale {
            get {return PlayerController_ptr->InputYawScale;}
            set {PlayerController_ptr->InputYawScale = value;}
        }
        ///<summary>Pitch input speed scaling</summary>
        public unsafe float InputPitchScale {
            get {return PlayerController_ptr->InputPitchScale;}
            set {PlayerController_ptr->InputPitchScale = value;}
        }
        ///<summary>Roll input speed scaling</summary>
        public unsafe float InputRollScale {
            get {return PlayerController_ptr->InputRollScale;}
            set {PlayerController_ptr->InputRollScale = value;}
        }
        public bool bShowMouseCursor {
            get {return Main.GetGetBoolPropertyByName(this, "bShowMouseCursor"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowMouseCursor", value); }
        }
        public bool bEnableClickEvents {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableClickEvents"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableClickEvents", value); }
        }
        public bool bEnableTouchEvents {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableTouchEvents"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableTouchEvents", value); }
        }
        public bool bEnableMouseOverEvents {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableMouseOverEvents"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableMouseOverEvents", value); }
        }
        public bool bEnableTouchOverEvents {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableTouchOverEvents"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableTouchOverEvents", value); }
        }
        public bool bForceFeedbackEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bForceFeedbackEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceFeedbackEnabled", value); }
        }
        ///<summary>Scale applied to force feedback values</summary>
        public unsafe float ForceFeedbackScale {
            get {return PlayerController_ptr->ForceFeedbackScale;}
            set {PlayerController_ptr->ForceFeedbackScale = value;}
        }
         //TODO: array not UObject TArray ClickEventKeys
        ///<summary>Type of mouse cursor to show by default</summary>
        public unsafe byte DefaultMouseCursor {
            get {return PlayerController_ptr->DefaultMouseCursor;}
        }
        ///<summary>Currently visible mouse cursor</summary>
        public unsafe byte CurrentMouseCursor {
            get {return PlayerController_ptr->CurrentMouseCursor;}
            set {PlayerController_ptr->CurrentMouseCursor = value;}
        }
        ///<summary>Default trace channel used for determining what world object was clicked on.</summary>
        public unsafe byte DefaultClickTraceChannel {
            get {return PlayerController_ptr->DefaultClickTraceChannel;}
        }
        ///<summary>Trace channel currently being used for determining what world object was clicked on.</summary>
        public unsafe byte CurrentClickTraceChannel {
            get {return PlayerController_ptr->CurrentClickTraceChannel;}
            set {PlayerController_ptr->CurrentClickTraceChannel = value;}
        }
        ///<summary>Distance to trace when computing click events</summary>
        public unsafe float HitResultTraceDistance {
            get {return PlayerController_ptr->HitResultTraceDistance;}
            set {PlayerController_ptr->HitResultTraceDistance = value;}
        }
         //TODO: numeric uint16 SeamlessTravelCount
         //TODO: numeric uint16 LastCompletedSeamlessTravelCount
        ///<summary>InputComponent we use when player is in Inactive state.</summary>
        public unsafe InputComponent InactiveStateInputComponent {
            get {return PlayerController_ptr->InactiveStateInputComponent;}
            set {PlayerController_ptr->InactiveStateInputComponent = value;}
        }
        public bool bShouldPerformFullTickWhenPaused {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldPerformFullTickWhenPaused"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldPerformFullTickWhenPaused", value); }
        }
        ///<summary>The currently set touch interface</summary>
        public unsafe TouchInterface CurrentTouchInterface {
            get {return PlayerController_ptr->CurrentTouchInterface;}
            set {PlayerController_ptr->CurrentTouchInterface = value;}
        }
        ///<summary>The pawn used when spectating (nullptr if not spectating).</summary>
        public unsafe SpectatorPawn SpectatorPawn {
            get {return PlayerController_ptr->SpectatorPawn;}
            set {PlayerController_ptr->SpectatorPawn = value;}
        }
        public bool bIsLocalPlayerController {
            get {return Main.GetGetBoolPropertyByName(this, "bIsLocalPlayerController"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsLocalPlayerController", value); }
        }
        ///<summary>The location used internally when there is no pawn or spectator, to know where to spawn the spectator or focus the camera on death.</summary>
        public unsafe Vector SpawnLocation {
            get {return PlayerController_ptr->SpawnLocation;}
            set {PlayerController_ptr->SpawnLocation = value;}
        }
        static PlayerController() {
            StaticClass = Main.GetClass("PlayerController");
        }
        internal unsafe PlayerController_fields* PlayerController_ptr => (PlayerController_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PlayerController(IntPtr p) => UObject.Make<PlayerController>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PlayerController DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PlayerController New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

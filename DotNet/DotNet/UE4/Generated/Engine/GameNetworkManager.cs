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
    ///<summary>Handles game-specific networking management (cheat detection, bandwidth management, etc.).</summary>
    public unsafe partial class GameNetworkManager : Info  {
        ///<summary>Current adjusted net speed - Used for dynamically managing netspeed for listen servers</summary>
        public unsafe int AdjustedNetSpeed {
            get {return GameNetworkManager_ptr->AdjustedNetSpeed;}
            set {GameNetworkManager_ptr->AdjustedNetSpeed = value;}
        }
        ///<summary>Last time netspeed was updated for server (by client entering or leaving)</summary>
        public unsafe float LastNetSpeedUpdateTime {
            get {return GameNetworkManager_ptr->LastNetSpeedUpdateTime;}
            set {GameNetworkManager_ptr->LastNetSpeedUpdateTime = value;}
        }
        ///<summary>Total available bandwidth for listen server, split dynamically across net connections</summary>
        public unsafe int TotalNetBandwidth {
            get {return GameNetworkManager_ptr->TotalNetBandwidth;}
            set {GameNetworkManager_ptr->TotalNetBandwidth = value;}
        }
        ///<summary>Minimum bandwidth dynamically set per connection</summary>
        public unsafe int MinDynamicBandwidth {
            get {return GameNetworkManager_ptr->MinDynamicBandwidth;}
            set {GameNetworkManager_ptr->MinDynamicBandwidth = value;}
        }
        ///<summary>Maximum bandwidth dynamically set per connection</summary>
        public unsafe int MaxDynamicBandwidth {
            get {return GameNetworkManager_ptr->MaxDynamicBandwidth;}
            set {GameNetworkManager_ptr->MaxDynamicBandwidth = value;}
        }
        public bool bIsStandbyCheckingEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bIsStandbyCheckingEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsStandbyCheckingEnabled", value); }
        }
        public bool bHasStandbyCheatTriggered {
            get {return Main.GetGetBoolPropertyByName(this, "bHasStandbyCheatTriggered"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasStandbyCheatTriggered", value); }
        }
        ///<summary>The amount of time without packets before triggering the cheat code</summary>
        public unsafe float StandbyRxCheatTime {
            get {return GameNetworkManager_ptr->StandbyRxCheatTime;}
            set {GameNetworkManager_ptr->StandbyRxCheatTime = value;}
        }
        ///<summary>The amount of time without packets before triggering the cheat code</summary>
        public unsafe float StandbyTxCheatTime {
            get {return GameNetworkManager_ptr->StandbyTxCheatTime;}
            set {GameNetworkManager_ptr->StandbyTxCheatTime = value;}
        }
        ///<summary>The point we determine the server is either delaying packets or has bad upstream</summary>
        public unsafe int BadPingThreshold {
            get {return GameNetworkManager_ptr->BadPingThreshold;}
            set {GameNetworkManager_ptr->BadPingThreshold = value;}
        }
        ///<summary>The percentage of clients missing RX data before triggering the standby code</summary>
        public unsafe float PercentMissingForRxStandby {
            get {return GameNetworkManager_ptr->PercentMissingForRxStandby;}
            set {GameNetworkManager_ptr->PercentMissingForRxStandby = value;}
        }
        ///<summary>The percentage of clients missing TX data before triggering the standby code</summary>
        public unsafe float PercentMissingForTxStandby {
            get {return GameNetworkManager_ptr->PercentMissingForTxStandby;}
            set {GameNetworkManager_ptr->PercentMissingForTxStandby = value;}
        }
        ///<summary>The percentage of clients with bad ping before triggering the standby code</summary>
        public unsafe float PercentForBadPing {
            get {return GameNetworkManager_ptr->PercentForBadPing;}
            set {GameNetworkManager_ptr->PercentForBadPing = value;}
        }
        ///<summary>The amount of time to wait before checking a connection for standby issues</summary>
        public unsafe float JoinInProgressStandbyWaitTime {
            get {return GameNetworkManager_ptr->JoinInProgressStandbyWaitTime;}
            set {GameNetworkManager_ptr->JoinInProgressStandbyWaitTime = value;}
        }
        ///<summary>Average size of replicated move packet (ServerMove() packet size) from player</summary>
        public unsafe float MoveRepSize {
            get {return GameNetworkManager_ptr->MoveRepSize;}
            set {GameNetworkManager_ptr->MoveRepSize = value;}
        }
        ///<summary>MAXPOSITIONERRORSQUARED is the square of the max position error that is accepted (not corrected) in net play</summary>
        public unsafe float MAXPOSITIONERRORSQUARED {
            get {return GameNetworkManager_ptr->MAXPOSITIONERRORSQUARED;}
            set {GameNetworkManager_ptr->MAXPOSITIONERRORSQUARED = value;}
        }
        ///<summary>MAXNEARZEROVELOCITYSQUARED is the square of the max velocity that is considered zero (not corrected) in net play</summary>
        public unsafe float MAXNEARZEROVELOCITYSQUARED {
            get {return GameNetworkManager_ptr->MAXNEARZEROVELOCITYSQUARED;}
            set {GameNetworkManager_ptr->MAXNEARZEROVELOCITYSQUARED = value;}
        }
        ///<summary>CLIENTADJUSTUPDATECOST is the bandwidth cost in bytes of sending a client adjustment update.</summary>
        ///<remarks>
        ///180 is greater than the actual cost, but represents a tweaked value reserving enough bandwidth for
        ///      other updates sent to the client.  Increase this value to reduce client adjustment update frequency, or if the amount of data sent in the clientadjustment() call increases
        ///</remarks>
        public unsafe float CLIENTADJUSTUPDATECOST {
            get {return GameNetworkManager_ptr->CLIENTADJUSTUPDATECOST;}
            set {GameNetworkManager_ptr->CLIENTADJUSTUPDATECOST = value;}
        }
        ///<summary>MAXCLIENTUPDATEINTERVAL is the maximum time between movement updates from the client before the server forces an update.</summary>
        public unsafe float MAXCLIENTUPDATEINTERVAL {
            get {return GameNetworkManager_ptr->MAXCLIENTUPDATEINTERVAL;}
            set {GameNetworkManager_ptr->MAXCLIENTUPDATEINTERVAL = value;}
        }
        ///<summary>MaxMoveDeltaTime is the default maximum time delta of CharacterMovement ServerMoves. Should be less than or equal to MAXCLIENTUPDATEINTERVAL, otherwise server will interfere by forcing position updates.</summary>
        public unsafe float MaxMoveDeltaTime {
            get {return GameNetworkManager_ptr->MaxMoveDeltaTime;}
            set {GameNetworkManager_ptr->MaxMoveDeltaTime = value;}
        }
        ///<summary>ClientNetSendMoveDeltaTime is the default minimum time delta of CharacterMovement client moves to the server.</summary>
        ///<remarks>
        ///When updates occur more frequently, they may be combined to save bandwidth.
        ///This value is not used when player count is over ClientNetSendMoveThrottleOverPlayerCount or player net speed is <= ClientNetSendMoveThrottleAtNetSpeed (see ClientNetSendMoveDeltaTimeThrottled).
        ///</remarks>
        public unsafe float ClientNetSendMoveDeltaTime {
            get {return GameNetworkManager_ptr->ClientNetSendMoveDeltaTime;}
            set {GameNetworkManager_ptr->ClientNetSendMoveDeltaTime = value;}
        }
        ///<summary>ClientNetSendMoveDeltaTimeThrottled is used in place of ClientNetSendMoveDeltaTime when player count is high or net speed is low. See ClientNetSendMoveDeltaTime for more info.</summary>
        public unsafe float ClientNetSendMoveDeltaTimeThrottled {
            get {return GameNetworkManager_ptr->ClientNetSendMoveDeltaTimeThrottled;}
            set {GameNetworkManager_ptr->ClientNetSendMoveDeltaTimeThrottled = value;}
        }
        ///<summary>ClientNetSendMoveDeltaTimeStationary is used when players are determined to not be moving or changing their view. See ClientNetSendMoveDeltaTime for more info.</summary>
        public unsafe float ClientNetSendMoveDeltaTimeStationary {
            get {return GameNetworkManager_ptr->ClientNetSendMoveDeltaTimeStationary;}
            set {GameNetworkManager_ptr->ClientNetSendMoveDeltaTimeStationary = value;}
        }
        ///<summary>When player net speed (CurrentNetSpeed, based on ConfiguredInternetSpeed or ConfiguredLanSpeed) is less than or equal to this amount, ClientNetSendMoveDeltaTimeThrottled is used instead of ClientNetSendMoveDeltaTime.</summary>
        public unsafe int ClientNetSendMoveThrottleAtNetSpeed {
            get {return GameNetworkManager_ptr->ClientNetSendMoveThrottleAtNetSpeed;}
            set {GameNetworkManager_ptr->ClientNetSendMoveThrottleAtNetSpeed = value;}
        }
        ///<summary>When player count is greater than this amount, ClientNetSendMoveDeltaTimeThrottled is used instead of ClientNetSendMoveDeltaTime.</summary>
        public unsafe int ClientNetSendMoveThrottleOverPlayerCount {
            get {return GameNetworkManager_ptr->ClientNetSendMoveThrottleOverPlayerCount;}
            set {GameNetworkManager_ptr->ClientNetSendMoveThrottleOverPlayerCount = value;}
        }
        public bool ClientAuthorativePosition {
            get {return Main.GetGetBoolPropertyByName(this, "ClientAuthorativePosition"); }
            set {Main.SetGetBoolPropertyByName(this, "ClientAuthorativePosition", value); }
        }
        ///<summary>Minimum delay between the server sending error corrections to a client, in seconds.</summary>
        public unsafe float ClientErrorUpdateRateLimit {
            get {return GameNetworkManager_ptr->ClientErrorUpdateRateLimit;}
            set {GameNetworkManager_ptr->ClientErrorUpdateRateLimit = value;}
        }
        public bool bMovementTimeDiscrepancyDetection {
            get {return Main.GetGetBoolPropertyByName(this, "bMovementTimeDiscrepancyDetection"); }
            set {Main.SetGetBoolPropertyByName(this, "bMovementTimeDiscrepancyDetection", value); }
        }
        public bool bMovementTimeDiscrepancyResolution {
            get {return Main.GetGetBoolPropertyByName(this, "bMovementTimeDiscrepancyResolution"); }
            set {Main.SetGetBoolPropertyByName(this, "bMovementTimeDiscrepancyResolution", value); }
        }
        ///<summary>Maximum time client can be ahead before triggering movement time discrepancy detection/resolution (if enabled).</summary>
        public unsafe float MovementTimeDiscrepancyMaxTimeMargin {
            get {return GameNetworkManager_ptr->MovementTimeDiscrepancyMaxTimeMargin;}
            set {GameNetworkManager_ptr->MovementTimeDiscrepancyMaxTimeMargin = value;}
        }
        ///<summary>Maximum time client can be behind.</summary>
        public unsafe float MovementTimeDiscrepancyMinTimeMargin {
            get {return GameNetworkManager_ptr->MovementTimeDiscrepancyMinTimeMargin;}
            set {GameNetworkManager_ptr->MovementTimeDiscrepancyMinTimeMargin = value;}
        }
        ///<summary>During time discrepancy resolution, we "pay back" the time discrepancy at this rate for future moves until total error is zero.</summary>
        ///<remarks>
        ///1.0 = 100% resolution rate, meaning the next X ServerMoves from the client are fully paying back the time,
        ///0.5 = 50% resolution rate, meaning future ServerMoves will spend 50% of tick continuing to move the character and 50% paying back.
        ///Lowering from 100% could be used to produce less severe/noticeable corrections, although typically we would want to correct
        ///the client as quickly as possible.
        ///</remarks>
        public unsafe float MovementTimeDiscrepancyResolutionRate {
            get {return GameNetworkManager_ptr->MovementTimeDiscrepancyResolutionRate;}
            set {GameNetworkManager_ptr->MovementTimeDiscrepancyResolutionRate = value;}
        }
        ///<summary>Accepted drift in clocks between client and server as a percent per second allowed.</summary>
        ///<remarks>
        ///0.0 is "no forgiveness" and all logic would run on raw values, no tampering on the server side.
        ///0.02 would be a 2% per second difference "forgiven" - if the time discrepancy in a given second was less than 2%,
        ///the error handling/detection code effectively ignores it.
        ///
        ///Increasing this value above 0% lessens the chance of false positives on time discrepancy (burst packet loss, performance
        ///hitches), but also means anyone tampering with their client time below that percent will not be detected and no resolution
        ///action will be taken, and anyone above that threshold will still gain the advantage of this % of time boost (if running at
        ///10% speed-up and this value is 0.05 or 5% allowance, they would only be resolved down to a 5% speed boost).
        ///
        ///Time discrepancy detection code DOES keep track of LifetimeRawTimeDiscrepancy, which is unaffected by this drift allowance,
        ///so cheating below DriftAllowance percent could be tracked and acted on outside of an individual game. For example, if DriftAllowance
        ///was 0.05 (meaning we're not going to actively prevent any cheating below 5% boosts to ensure less false positives for normal players),
        ///we could still post-process analytics of the game showing that Player X regularly runs at 4% speed boost and take action.
        ///</remarks>
        public unsafe float MovementTimeDiscrepancyDriftAllowance {
            get {return GameNetworkManager_ptr->MovementTimeDiscrepancyDriftAllowance;}
            set {GameNetworkManager_ptr->MovementTimeDiscrepancyDriftAllowance = value;}
        }
        public bool bMovementTimeDiscrepancyForceCorrectionsDuringResolution {
            get {return Main.GetGetBoolPropertyByName(this, "bMovementTimeDiscrepancyForceCorrectionsDuringResolution"); }
            set {Main.SetGetBoolPropertyByName(this, "bMovementTimeDiscrepancyForceCorrectionsDuringResolution", value); }
        }
        public bool bUseDistanceBasedRelevancy {
            get {return Main.GetGetBoolPropertyByName(this, "bUseDistanceBasedRelevancy"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseDistanceBasedRelevancy", value); }
        }
        static GameNetworkManager() {
            StaticClass = Main.GetClass("GameNetworkManager");
        }
        internal unsafe GameNetworkManager_fields* GameNetworkManager_ptr => (GameNetworkManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameNetworkManager(IntPtr p) => UObject.Make<GameNetworkManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameNetworkManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameNetworkManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

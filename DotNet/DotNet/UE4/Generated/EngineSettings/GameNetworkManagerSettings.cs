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
using UE4.EngineSettings.Native;

namespace UE4.EngineSettings {
    ///<summary>Holds the settings for the AGameNetworkManager class.</summary>
    public unsafe partial class GameNetworkManagerSettings : UObject  {
        ///<summary>Minimum bandwidth dynamically set per connection.</summary>
        public unsafe int MinDynamicBandwidth {
            get {return GameNetworkManagerSettings_ptr->MinDynamicBandwidth;}
            set {GameNetworkManagerSettings_ptr->MinDynamicBandwidth = value;}
        }
        ///<summary>Maximum bandwidth dynamically set per connection.</summary>
        public unsafe int MaxDynamicBandwidth {
            get {return GameNetworkManagerSettings_ptr->MaxDynamicBandwidth;}
            set {GameNetworkManagerSettings_ptr->MaxDynamicBandwidth = value;}
        }
        ///<summary>Total available bandwidth for listen server, split dynamically across net connections.</summary>
        public unsafe int TotalNetBandwidth {
            get {return GameNetworkManagerSettings_ptr->TotalNetBandwidth;}
            set {GameNetworkManagerSettings_ptr->TotalNetBandwidth = value;}
        }
        ///<summary>The point we determine the server is either delaying packets or has bad upstream.</summary>
        public unsafe int BadPingThreshold {
            get {return GameNetworkManagerSettings_ptr->BadPingThreshold;}
            set {GameNetworkManagerSettings_ptr->BadPingThreshold = value;}
        }
        public bool bIsStandbyCheckingEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bIsStandbyCheckingEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsStandbyCheckingEnabled", value); }
        }
        ///<summary>The amount of time without packets before triggering the cheat code.</summary>
        public unsafe float StandbyRxCheatTime {
            get {return GameNetworkManagerSettings_ptr->StandbyRxCheatTime;}
            set {GameNetworkManagerSettings_ptr->StandbyRxCheatTime = value;}
        }
        ///<summary>The amount of time without packets before triggering the cheat code.</summary>
        public unsafe float StandbyTxCheatTime {
            get {return GameNetworkManagerSettings_ptr->StandbyTxCheatTime;}
            set {GameNetworkManagerSettings_ptr->StandbyTxCheatTime = value;}
        }
        ///<summary>The percentage of clients missing RX data before triggering the standby code.</summary>
        public unsafe float PercentMissingForRxStandby {
            get {return GameNetworkManagerSettings_ptr->PercentMissingForRxStandby;}
            set {GameNetworkManagerSettings_ptr->PercentMissingForRxStandby = value;}
        }
        ///<summary>The percentage of clients missing TX data before triggering the standby code.</summary>
        public unsafe float PercentMissingForTxStandby {
            get {return GameNetworkManagerSettings_ptr->PercentMissingForTxStandby;}
            set {GameNetworkManagerSettings_ptr->PercentMissingForTxStandby = value;}
        }
        ///<summary>The percentage of clients with bad ping before triggering the standby code.</summary>
        public unsafe float PercentForBadPing {
            get {return GameNetworkManagerSettings_ptr->PercentForBadPing;}
            set {GameNetworkManagerSettings_ptr->PercentForBadPing = value;}
        }
        ///<summary>The amount of time to wait before checking a connection for standby issues.</summary>
        public unsafe float JoinInProgressStandbyWaitTime {
            get {return GameNetworkManagerSettings_ptr->JoinInProgressStandbyWaitTime;}
            set {GameNetworkManagerSettings_ptr->JoinInProgressStandbyWaitTime = value;}
        }
        static GameNetworkManagerSettings() {
            StaticClass = Main.GetClass("GameNetworkManagerSettings");
        }
        internal unsafe GameNetworkManagerSettings_fields* GameNetworkManagerSettings_ptr => (GameNetworkManagerSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameNetworkManagerSettings(IntPtr p) => UObject.Make<GameNetworkManagerSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameNetworkManagerSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameNetworkManagerSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

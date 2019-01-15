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


namespace UE4.LaunchDaemonMessages{
        ///<summary>IOSLaunch Daemon Pong</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct IOSLaunchDaemonPong {
            [FieldOffset(0)] byte DeviceID; //TODO: string FString DeviceID

            [FieldOffset(16)] byte DeviceName; //TODO: string FString DeviceName

            [FieldOffset(32)] byte DeviceStatus; //TODO: string FString DeviceStatus

            [FieldOffset(48)] byte DeviceType; //TODO: string FString DeviceType

            [FieldOffset(64)] public bool bCanPowerOff;

            [FieldOffset(65)] public bool bCanPowerOn;

            [FieldOffset(66)] public bool bCanReboot;

        }
}

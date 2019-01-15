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
        ///<summary>IOSLaunch Daemon Launch App</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct IOSLaunchDaemonLaunchApp {
            [FieldOffset(0)] byte AppID; //TODO: string FString AppID

            [FieldOffset(16)] byte Parameters; //TODO: string FString Parameters

        }
}

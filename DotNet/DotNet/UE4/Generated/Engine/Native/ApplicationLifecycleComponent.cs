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
    [StructLayout( LayoutKind.Explicit, Size=400 )]
    internal unsafe struct ApplicationLifecycleComponent_fields {
        [FieldOffset(256)] byte ApplicationWillDeactivateDelegate; //TODO: multicast delegate FApplicationLifetimeDelegate ApplicationWillDeactivateDelegate
        [FieldOffset(272)] byte ApplicationHasReactivatedDelegate; //TODO: multicast delegate FApplicationLifetimeDelegate ApplicationHasReactivatedDelegate
        [FieldOffset(288)] byte ApplicationWillEnterBackgroundDelegate; //TODO: multicast delegate FApplicationLifetimeDelegate ApplicationWillEnterBackgroundDelegate
        [FieldOffset(304)] byte ApplicationHasEnteredForegroundDelegate; //TODO: multicast delegate FApplicationLifetimeDelegate ApplicationHasEnteredForegroundDelegate
        [FieldOffset(320)] byte ApplicationWillTerminateDelegate; //TODO: multicast delegate FApplicationLifetimeDelegate ApplicationWillTerminateDelegate
        [FieldOffset(336)] byte ApplicationShouldUnloadResourcesDelegate; //TODO: multicast delegate FApplicationLifetimeDelegate ApplicationShouldUnloadResourcesDelegate
        [FieldOffset(352)] byte ApplicationReceivedStartupArgumentsDelegate; //TODO: multicast delegate FApplicationStartupArgumentsDelegate ApplicationReceivedStartupArgumentsDelegate
        [FieldOffset(368)] byte OnTemperatureChangeDelegate; //TODO: multicast delegate FOnTemperatureChangeDelegate OnTemperatureChangeDelegate
        [FieldOffset(384)] byte OnLowPowerModeDelegate; //TODO: multicast delegate FOnLowPowerModeDelegate OnLowPowerModeDelegate
    }
    internal unsafe struct ApplicationLifecycleComponent_methods {
    }
    internal unsafe struct ApplicationLifecycleComponent_events {
    }
}

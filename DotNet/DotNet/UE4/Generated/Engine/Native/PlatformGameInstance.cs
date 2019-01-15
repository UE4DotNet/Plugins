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
    [StructLayout( LayoutKind.Explicit, Size=384 )]
    internal unsafe struct PlatformGameInstance_fields {
        [FieldOffset(176)] byte ApplicationWillDeactivateDelegate; //TODO: multicast delegate FPlatformDelegate ApplicationWillDeactivateDelegate
        [FieldOffset(192)] byte ApplicationHasReactivatedDelegate; //TODO: multicast delegate FPlatformDelegate ApplicationHasReactivatedDelegate
        [FieldOffset(208)] byte ApplicationWillEnterBackgroundDelegate; //TODO: multicast delegate FPlatformDelegate ApplicationWillEnterBackgroundDelegate
        [FieldOffset(224)] byte ApplicationHasEnteredForegroundDelegate; //TODO: multicast delegate FPlatformDelegate ApplicationHasEnteredForegroundDelegate
        [FieldOffset(240)] byte ApplicationWillTerminateDelegate; //TODO: multicast delegate FPlatformDelegate ApplicationWillTerminateDelegate
        [FieldOffset(256)] byte ApplicationShouldUnloadResourcesDelegate; //TODO: multicast delegate FPlatformDelegate ApplicationShouldUnloadResourcesDelegate
        [FieldOffset(272)] byte ApplicationReceivedStartupArgumentsDelegate; //TODO: multicast delegate FPlatformStartupArgumentsDelegate ApplicationReceivedStartupArgumentsDelegate
        [FieldOffset(288)] byte ApplicationRegisteredForRemoteNotificationsDelegate; //TODO: multicast delegate FPlatformRegisteredForRemoteNotificationsDelegate ApplicationRegisteredForRemoteNotificationsDelegate
        [FieldOffset(304)] byte ApplicationRegisteredForUserNotificationsDelegate; //TODO: multicast delegate FPlatformRegisteredForUserNotificationsDelegate ApplicationRegisteredForUserNotificationsDelegate
        [FieldOffset(320)] byte ApplicationFailedToRegisterForRemoteNotificationsDelegate; //TODO: multicast delegate FPlatformFailedToRegisterForRemoteNotificationsDelegate ApplicationFailedToRegisterForRemoteNotificationsDelegate
        [FieldOffset(336)] byte ApplicationReceivedRemoteNotificationDelegate; //TODO: multicast delegate FPlatformReceivedRemoteNotificationDelegate ApplicationReceivedRemoteNotificationDelegate
        [FieldOffset(352)] byte ApplicationReceivedLocalNotificationDelegate; //TODO: multicast delegate FPlatformReceivedLocalNotificationDelegate ApplicationReceivedLocalNotificationDelegate
        [FieldOffset(368)] byte ApplicationReceivedScreenOrientationChangedNotificationDelegate; //TODO: multicast delegate FPlatformScreenOrientationChangedDelegate ApplicationReceivedScreenOrientationChangedNotificationDelegate
    }
    internal unsafe struct PlatformGameInstance_methods {
    }
    internal unsafe struct PlatformGameInstance_events {
    }
}

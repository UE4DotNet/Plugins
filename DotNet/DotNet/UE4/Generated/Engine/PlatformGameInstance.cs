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
    ///<summary>UObject based class for handling mobile events. Having this object as an option gives the app lifetime access to these global delegates. The component UApplicationLifecycleComponent is destroyed at level loads</summary>
    public unsafe partial class PlatformGameInstance : GameInstance  {
         //TODO: multicast delegate FPlatformDelegate ApplicationWillDeactivateDelegate
         //TODO: multicast delegate FPlatformDelegate ApplicationHasReactivatedDelegate
         //TODO: multicast delegate FPlatformDelegate ApplicationWillEnterBackgroundDelegate
         //TODO: multicast delegate FPlatformDelegate ApplicationHasEnteredForegroundDelegate
         //TODO: multicast delegate FPlatformDelegate ApplicationWillTerminateDelegate
         //TODO: multicast delegate FPlatformDelegate ApplicationShouldUnloadResourcesDelegate
         //TODO: multicast delegate FPlatformStartupArgumentsDelegate ApplicationReceivedStartupArgumentsDelegate
         //TODO: multicast delegate FPlatformRegisteredForRemoteNotificationsDelegate ApplicationRegisteredForRemoteNotificationsDelegate
         //TODO: multicast delegate FPlatformRegisteredForUserNotificationsDelegate ApplicationRegisteredForUserNotificationsDelegate
         //TODO: multicast delegate FPlatformFailedToRegisterForRemoteNotificationsDelegate ApplicationFailedToRegisterForRemoteNotificationsDelegate
         //TODO: multicast delegate FPlatformReceivedRemoteNotificationDelegate ApplicationReceivedRemoteNotificationDelegate
         //TODO: multicast delegate FPlatformReceivedLocalNotificationDelegate ApplicationReceivedLocalNotificationDelegate
         //TODO: multicast delegate FPlatformScreenOrientationChangedDelegate ApplicationReceivedScreenOrientationChangedNotificationDelegate
        static PlatformGameInstance() {
            StaticClass = Main.GetClass("PlatformGameInstance");
        }
        internal unsafe PlatformGameInstance_fields* PlatformGameInstance_ptr => (PlatformGameInstance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PlatformGameInstance(IntPtr p) => UObject.Make<PlatformGameInstance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PlatformGameInstance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PlatformGameInstance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

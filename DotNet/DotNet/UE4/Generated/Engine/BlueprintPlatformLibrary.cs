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
    ///<summary>Blueprint Platform Library</summary>
    public unsafe partial class BlueprintPlatformLibrary : BlueprintFunctionLibrary  {

        ///<summary>
        ///Cancel a local notification given the ActivationEvent
        ///@
        ///</summary>
        ///<remarks>param ActivationEvent The string passed into the Schedule call for the notification to be cancelled</remarks>
        public static void CancelLocalNotification(string ActivationEvent)  => 
            BlueprintPlatformLibrary_methods.CancelLocalNotification_method.Invoke(ActivationEvent);

        ///<summary>Clear all pending local notifications. Typically this will be done before scheduling new notifications when going into the background</summary>
        public static void ClearAllLocalNotifications()  => 
            BlueprintPlatformLibrary_methods.ClearAllLocalNotifications_method.Invoke();

        ///<summary>
        ///Get the local notification that was used to launch the app
        ///@
        ///</summary>
        ///<remarks>
        ///param NotificationLaunchedApp Return true if a notification was used to launch the app
        ///@param ActivationEvent Returns the name of the ActivationEvent if a notification was used to launch the app
        ///@param FireDate Returns the time the notification was activated
        ///</remarks>
        public static (bool, string, int) GetLaunchNotification()  => 
            BlueprintPlatformLibrary_methods.GetLaunchNotification_method.Invoke();

        ///<summary>
        ///Schedule a local notification at a specific time, inLocalTime specifies the current local time or if UTC time should be used
        ///@
        ///</summary>
        ///<remarks>
        ///param FireDateTime The time at which to fire the local notification
        ///@param LocalTime If true the provided time is in the local timezone, if false it is in UTC
        ///@param Title The title of the notification
        ///@param Body The more detailed description of the notification
        ///@param Action The text to be displayed on the slider controller
        ///@param ActivationEvent A string that is passed in the delegate callback when the app is brought into the foreground from the user activating the notification
        ///</remarks>
        public static void ScheduleLocalNotificationAtTime(FDateTime FireDateTime, bool LocalTime, byte Title /*TODO: text FText */, byte Body /*TODO: text FText */, byte Action /*TODO: text FText */, string ActivationEvent)  => 
            BlueprintPlatformLibrary_methods.ScheduleLocalNotificationAtTime_method.Invoke(FireDateTime, LocalTime, Title, Body, Action, ActivationEvent);

        ///<summary>
        ///Schedule a local notification badge at a specific time, inLocalTime specifies the current local time or if UTC time should be used
        ///@
        ///</summary>
        ///<remarks>
        ///param FireDateTime The time at which to fire the local notification
        ///@param LocalTime If true the provided time is in the local timezone, if false it is in UTC
        ///@param ActivationEvent A string that is passed in the delegate callback when the app is brought into the foreground from the user activating the notification
        ///</remarks>
        public static void ScheduleLocalNotificationBadgeAtTime(FDateTime FireDateTime, bool LocalTime, string ActivationEvent)  => 
            BlueprintPlatformLibrary_methods.ScheduleLocalNotificationBadgeAtTime_method.Invoke(FireDateTime, LocalTime, ActivationEvent);

        ///<summary>
        ///Schedule a local notification badge to fire inSecondsFromNow from now
        ///@
        ///</summary>
        ///<remarks>
        ///param inSecondsFromNow The seconds until the notification should fire
        ///@param ActivationEvent A string that is passed in the delegate callback when the app is brought into the foreground from the user activating the notification
        ///</remarks>
        public static void ScheduleLocalNotificationBadgeFromNow(int inSecondsFromNow, string ActivationEvent)  => 
            BlueprintPlatformLibrary_methods.ScheduleLocalNotificationBadgeFromNow_method.Invoke(inSecondsFromNow, ActivationEvent);

        ///<summary>
        ///Schedule a local notification to fire inSecondsFromNow from now
        ///@
        ///</summary>
        ///<remarks>
        ///param inSecondsFromNow The seconds until the notification should fire
        ///@param LocalTime If true the provided time is in the local timezone, if false it is in UTC
        ///@param Title The title of the notification
        ///@param Body The more detailed description of the notification
        ///@param Action The text to be displayed on the slider controller
        ///@param ActivationEvent A string that is passed in the delegate callback when the app is brought into the foreground from the user activating the notification
        ///</remarks>
        public static void ScheduleLocalNotificationFromNow(int inSecondsFromNow, byte Title /*TODO: text FText */, byte Body /*TODO: text FText */, byte Action /*TODO: text FText */, string ActivationEvent)  => 
            BlueprintPlatformLibrary_methods.ScheduleLocalNotificationFromNow_method.Invoke(inSecondsFromNow, Title, Body, Action, ActivationEvent);
        static BlueprintPlatformLibrary() {
            StaticClass = Main.GetClass("BlueprintPlatformLibrary");
        }
        internal unsafe BlueprintPlatformLibrary_fields* BlueprintPlatformLibrary_ptr => (BlueprintPlatformLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintPlatformLibrary(IntPtr p) => UObject.Make<BlueprintPlatformLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintPlatformLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintPlatformLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

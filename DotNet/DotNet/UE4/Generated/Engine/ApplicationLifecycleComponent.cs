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
    ///<summary>Component to handle receiving notifications from the OS about application state (activated, suspended, termination, etc).</summary>
    public unsafe partial class ApplicationLifecycleComponent : ActorComponent  {
         //TODO: multicast delegate FApplicationLifetimeDelegate ApplicationWillDeactivateDelegate
         //TODO: multicast delegate FApplicationLifetimeDelegate ApplicationHasReactivatedDelegate
         //TODO: multicast delegate FApplicationLifetimeDelegate ApplicationWillEnterBackgroundDelegate
         //TODO: multicast delegate FApplicationLifetimeDelegate ApplicationHasEnteredForegroundDelegate
         //TODO: multicast delegate FApplicationLifetimeDelegate ApplicationWillTerminateDelegate
         //TODO: multicast delegate FApplicationLifetimeDelegate ApplicationShouldUnloadResourcesDelegate
         //TODO: multicast delegate FApplicationStartupArgumentsDelegate ApplicationReceivedStartupArgumentsDelegate
         //TODO: multicast delegate FOnTemperatureChangeDelegate OnTemperatureChangeDelegate
         //TODO: multicast delegate FOnLowPowerModeDelegate OnLowPowerModeDelegate
        static ApplicationLifecycleComponent() {
            StaticClass = Main.GetClass("ApplicationLifecycleComponent");
        }
        internal unsafe ApplicationLifecycleComponent_fields* ApplicationLifecycleComponent_ptr => (ApplicationLifecycleComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ApplicationLifecycleComponent(IntPtr p) => UObject.Make<ApplicationLifecycleComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ApplicationLifecycleComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ApplicationLifecycleComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

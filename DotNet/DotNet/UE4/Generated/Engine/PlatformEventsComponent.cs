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
    ///<summary>Component to handle receiving notifications from the OS about platform events.</summary>
    public unsafe partial class PlatformEventsComponent : ActorComponent  {

        ///<summary>Check whether a convertible laptop is laptop mode.</summary>
        ///<remarks>
        ///@return true if in laptop mode, false otherwise or if not a convertible laptop.
        ///@see IsInTabletMode, SupportsConvertibleLaptops
        ///</remarks>
        public bool IsInLaptopMode()  => 
            PlatformEventsComponent_methods.IsInLaptopMode_method.Invoke(ObjPointer);

        ///<summary>Check whether a convertible laptop is laptop mode.</summary>
        ///<remarks>
        ///@return true if in tablet mode, false otherwise or if not a convertible laptop.
        ///@see IsInLaptopMode, SupportsConvertibleLaptops
        ///</remarks>
        public bool IsInTabletMode()  => 
            PlatformEventsComponent_methods.IsInTabletMode_method.Invoke(ObjPointer);

        ///<summary>Check whether the platform supports convertible laptops.</summary>
        ///<remarks>
        ///Note: This does not necessarily mean that the platform is a convertible laptop.
        ///For example, convertible laptops running Windows 7 or older will return false,
        ///and regular laptops running Windows 8 or newer will return true.
        ///
        ///@return true for convertible laptop platforms, false otherwise.
        ///@see IsInLaptopMode, IsInTabletMode
        ///</remarks>
        public bool SupportsConvertibleLaptops()  => 
            PlatformEventsComponent_methods.SupportsConvertibleLaptops_method.Invoke(ObjPointer);
         //TODO: multicast delegate FPlatformEventDelegate PlatformChangedToLaptopModeDelegate
         //TODO: multicast delegate FPlatformEventDelegate PlatformChangedToTabletModeDelegate
        static PlatformEventsComponent() {
            StaticClass = Main.GetClass("PlatformEventsComponent");
        }
        internal unsafe PlatformEventsComponent_fields* PlatformEventsComponent_ptr => (PlatformEventsComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PlatformEventsComponent(IntPtr p) => UObject.Make<PlatformEventsComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PlatformEventsComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PlatformEventsComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

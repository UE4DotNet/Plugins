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
using UE4.SteamVR.Native;
using UE4.Engine;

namespace UE4.SteamVR {
    ///<summary>SteamVR Extensions Function Library</summary>
    public unsafe partial class SteamVRChaperoneComponent : ActorComponent  {

        ///<summary>Returns the bounds from the Chaperone, in Unreal-scale HMD-space coordinates, centered around the HMD's calibration origin (0,0,0).  Each set of four bounds will form a quad to define a set of bounds</summary>
        public IReadOnlyCollection<Vector> GetBounds()  => 
            SteamVRChaperoneComponent_methods.GetBounds_method.Invoke(ObjPointer);
         //TODO: multicast delegate FSteamVRChaperoneEvent OnLeaveBounds
         //TODO: multicast delegate FSteamVRChaperoneEvent OnReturnToBounds
        static SteamVRChaperoneComponent() {
            StaticClass = Main.GetClass("SteamVRChaperoneComponent");
        }
        internal unsafe SteamVRChaperoneComponent_fields* SteamVRChaperoneComponent_ptr => (SteamVRChaperoneComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SteamVRChaperoneComponent(IntPtr p) => UObject.Make<SteamVRChaperoneComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SteamVRChaperoneComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SteamVRChaperoneComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

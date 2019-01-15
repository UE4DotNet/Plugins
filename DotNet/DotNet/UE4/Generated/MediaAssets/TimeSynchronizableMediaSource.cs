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
using UE4.MediaAssets.Native;

namespace UE4.MediaAssets {
    ///<summary>Base class for media sources that can be synchronized with the engine's timecode.</summary>
    public unsafe partial class TimeSynchronizableMediaSource : BaseMediaSource  {
        public bool bUseTimeSynchronization {
            get {return Main.GetGetBoolPropertyByName(this, "bUseTimeSynchronization"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseTimeSynchronization", value); }
        }
        static TimeSynchronizableMediaSource() {
            StaticClass = Main.GetClass("TimeSynchronizableMediaSource");
        }
        internal unsafe TimeSynchronizableMediaSource_fields* TimeSynchronizableMediaSource_ptr => (TimeSynchronizableMediaSource_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TimeSynchronizableMediaSource(IntPtr p) => UObject.Make<TimeSynchronizableMediaSource>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TimeSynchronizableMediaSource DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TimeSynchronizableMediaSource New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

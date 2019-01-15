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
using UE4.TimeManagement.Native;

namespace UE4.TimeManagement {
    ///<summary>Base class for sources to be used for time synchronization</summary>
    public unsafe partial class TimeSynchronizationSource : UObject  {
        public bool bUseForSynchronization {
            get {return Main.GetGetBoolPropertyByName(this, "bUseForSynchronization"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseForSynchronization", value); }
        }
        ///<summary>Extra frame to buffered before allowing the Manager to by in synchronized mode.</summary>
        public unsafe int NumberOfExtraBufferedFrame {
            get {return TimeSynchronizationSource_ptr->NumberOfExtraBufferedFrame;}
            set {TimeSynchronizationSource_ptr->NumberOfExtraBufferedFrame = value;}
        }
        ///<summary>Fixed delay in seconds to align with other sources.</summary>
        public unsafe float TimeDelay {
            get {return TimeSynchronizationSource_ptr->TimeDelay;}
            set {TimeSynchronizationSource_ptr->TimeDelay = value;}
        }
        static TimeSynchronizationSource() {
            StaticClass = Main.GetClass("TimeSynchronizationSource");
        }
        internal unsafe TimeSynchronizationSource_fields* TimeSynchronizationSource_ptr => (TimeSynchronizationSource_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TimeSynchronizationSource(IntPtr p) => UObject.Make<TimeSynchronizationSource>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TimeSynchronizationSource DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TimeSynchronizationSource New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

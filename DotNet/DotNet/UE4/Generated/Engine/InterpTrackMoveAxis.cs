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
    ///<summary>Interp Track Move Axis</summary>
    public unsafe partial class InterpTrackMoveAxis : InterpTrackFloatBase  {
        ///<summary>The axis which this track will use when transforming an actor</summary>
        public unsafe byte MoveAxis {
            get {return InterpTrackMoveAxis_ptr->MoveAxis;}
            set {InterpTrackMoveAxis_ptr->MoveAxis = value;}
        }
        ///<summary>Lookup track to use when looking at different groups for transform information</summary>
        public unsafe InterpLookupTrack LookupTrack {
            get {return InterpTrackMoveAxis_ptr->LookupTrack;}
            set {InterpTrackMoveAxis_ptr->LookupTrack = value;}
        }
        static InterpTrackMoveAxis() {
            StaticClass = Main.GetClass("InterpTrackMoveAxis");
        }
        internal unsafe InterpTrackMoveAxis_fields* InterpTrackMoveAxis_ptr => (InterpTrackMoveAxis_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackMoveAxis(IntPtr p) => UObject.Make<InterpTrackMoveAxis>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackMoveAxis DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackMoveAxis New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

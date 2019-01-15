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
    ///<summary>Interp Track Float Prop</summary>
    public unsafe partial class InterpTrackFloatProp : InterpTrackFloatBase  {
        ///<summary>Name of property in Group  AActor  which this track mill modify over time.</summary>
        public unsafe Name PropertyName {
            get {return InterpTrackFloatProp_ptr->PropertyName;}
            set {InterpTrackFloatProp_ptr->PropertyName = value;}
        }
        static InterpTrackFloatProp() {
            StaticClass = Main.GetClass("InterpTrackFloatProp");
        }
        internal unsafe InterpTrackFloatProp_fields* InterpTrackFloatProp_ptr => (InterpTrackFloatProp_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackFloatProp(IntPtr p) => UObject.Make<InterpTrackFloatProp>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackFloatProp DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackFloatProp New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>Interp Track Bool Prop</summary>
    public unsafe partial class InterpTrackBoolProp : InterpTrack  {
         //TODO: array not UObject TArray BoolTrack
        ///<summary>Name of property in Group  AActor  which this track will modify over time.</summary>
        public unsafe Name PropertyName {
            get {return InterpTrackBoolProp_ptr->PropertyName;}
            set {InterpTrackBoolProp_ptr->PropertyName = value;}
        }
        static InterpTrackBoolProp() {
            StaticClass = Main.GetClass("InterpTrackBoolProp");
        }
        internal unsafe InterpTrackBoolProp_fields* InterpTrackBoolProp_ptr => (InterpTrackBoolProp_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackBoolProp(IntPtr p) => UObject.Make<InterpTrackBoolProp>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackBoolProp DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackBoolProp New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

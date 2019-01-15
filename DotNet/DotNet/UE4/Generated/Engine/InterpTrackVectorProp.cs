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
    ///<summary>Interp Track Vector Prop</summary>
    public unsafe partial class InterpTrackVectorProp : InterpTrackVectorBase  {
        ///<summary>Name of property in Group  AActor  which this track mill modify over time.</summary>
        public unsafe Name PropertyName {
            get {return InterpTrackVectorProp_ptr->PropertyName;}
            set {InterpTrackVectorProp_ptr->PropertyName = value;}
        }
        static InterpTrackVectorProp() {
            StaticClass = Main.GetClass("InterpTrackVectorProp");
        }
        internal unsafe InterpTrackVectorProp_fields* InterpTrackVectorProp_ptr => (InterpTrackVectorProp_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackVectorProp(IntPtr p) => UObject.Make<InterpTrackVectorProp>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackVectorProp DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackVectorProp New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

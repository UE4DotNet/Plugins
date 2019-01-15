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
    ///<summary>Interp Track Inst Vector Prop</summary>
    public unsafe partial class InterpTrackInstVectorProp : InterpTrackInstProperty  {
        ///<summary>Saved value for restoring state when exiting Matinee.</summary>
        public unsafe Vector ResetVector {
            get {return InterpTrackInstVectorProp_ptr->ResetVector;}
            set {InterpTrackInstVectorProp_ptr->ResetVector = value;}
        }
        static InterpTrackInstVectorProp() {
            StaticClass = Main.GetClass("InterpTrackInstVectorProp");
        }
        internal unsafe InterpTrackInstVectorProp_fields* InterpTrackInstVectorProp_ptr => (InterpTrackInstVectorProp_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstVectorProp(IntPtr p) => UObject.Make<InterpTrackInstVectorProp>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstVectorProp DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstVectorProp New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

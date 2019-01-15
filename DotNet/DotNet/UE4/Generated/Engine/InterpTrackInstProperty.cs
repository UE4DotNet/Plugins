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
    ///<summary>Interp Track Inst Property</summary>
    public unsafe partial class InterpTrackInstProperty : InterpTrackInst  {
        ///<summary>Function to call after updating the value of the color property.</summary>
        public unsafe Property InterpProperty {
            get {return InterpTrackInstProperty_ptr->InterpProperty;}
            set {InterpTrackInstProperty_ptr->InterpProperty = value;}
        }
        ///<summary>Pointer to the UObject instance that is the outer of the color property we are interpolating on, this is used to process the property update callback.</summary>
        public unsafe UObject PropertyOuterObjectInst {
            get {return InterpTrackInstProperty_ptr->PropertyOuterObjectInst;}
            set {InterpTrackInstProperty_ptr->PropertyOuterObjectInst = value;}
        }
        static InterpTrackInstProperty() {
            StaticClass = Main.GetClass("InterpTrackInstProperty");
        }
        internal unsafe InterpTrackInstProperty_fields* InterpTrackInstProperty_ptr => (InterpTrackInstProperty_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstProperty(IntPtr p) => UObject.Make<InterpTrackInstProperty>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstProperty DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstProperty New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

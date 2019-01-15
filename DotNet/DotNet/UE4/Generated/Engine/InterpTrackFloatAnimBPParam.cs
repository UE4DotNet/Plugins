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
    ///<summary>Interp Track Float Anim BPParam</summary>
    public unsafe partial class InterpTrackFloatAnimBPParam : InterpTrackFloatBase  {
        ///<summary>Anim Blueprint Class</summary>
        public unsafe SubclassOf<UObject> AnimBlueprintClass {
            get {return InterpTrackFloatAnimBPParam_ptr->AnimBlueprintClass;}
            set {InterpTrackFloatAnimBPParam_ptr->AnimBlueprintClass = value;}
        }
        ///<summary>Materials whose parameters we want to change and the references to those materials.</summary>
        public unsafe SubclassOf<AnimInstance> AnimClass {
            get {return InterpTrackFloatAnimBPParam_ptr->AnimClass;}
            set {InterpTrackFloatAnimBPParam_ptr->AnimClass = value;}
        }
        ///<summary>Name of parameter in the MaterialInstance which this track will modify over time.</summary>
        public unsafe Name ParamName {
            get {return InterpTrackFloatAnimBPParam_ptr->ParamName;}
            set {InterpTrackFloatAnimBPParam_ptr->ParamName = value;}
        }
        static InterpTrackFloatAnimBPParam() {
            StaticClass = Main.GetClass("InterpTrackFloatAnimBPParam");
        }
        internal unsafe InterpTrackFloatAnimBPParam_fields* InterpTrackFloatAnimBPParam_ptr => (InterpTrackFloatAnimBPParam_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackFloatAnimBPParam(IntPtr p) => UObject.Make<InterpTrackFloatAnimBPParam>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackFloatAnimBPParam DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackFloatAnimBPParam New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

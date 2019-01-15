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
    ///<summary>Interp Track Anim Control</summary>
    public unsafe partial class InterpTrackAnimControl : InterpTrackFloatBase  {
        ///<summary>Name of slot to use when playing animation.</summary>
        ///<remarks>
        ///Passed to Actor.
        ///When multiple tracks use the same slot name, they are each given a different ChannelIndex when SetAnimPosition is called.
        ///</remarks>
        public unsafe Name SlotName {
            get {return InterpTrackAnimControl_ptr->SlotName;}
            set {InterpTrackAnimControl_ptr->SlotName = value;}
        }
         //TODO: array not UObject TArray AnimSeqs
        public bool bSkipAnimNotifiers {
            get {return Main.GetGetBoolPropertyByName(this, "bSkipAnimNotifiers"); }
            set {Main.SetGetBoolPropertyByName(this, "bSkipAnimNotifiers", value); }
        }
        static InterpTrackAnimControl() {
            StaticClass = Main.GetClass("InterpTrackAnimControl");
        }
        internal unsafe InterpTrackAnimControl_fields* InterpTrackAnimControl_ptr => (InterpTrackAnimControl_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackAnimControl(IntPtr p) => UObject.Make<InterpTrackAnimControl>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackAnimControl DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackAnimControl New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

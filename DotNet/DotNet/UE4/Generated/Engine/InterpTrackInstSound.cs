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
    ///<summary>Interp Track Inst Sound</summary>
    public unsafe partial class InterpTrackInstSound : InterpTrackInst  {
        ///<summary>Last Update Position</summary>
        public unsafe float LastUpdatePosition {
            get {return InterpTrackInstSound_ptr->LastUpdatePosition;}
            set {InterpTrackInstSound_ptr->LastUpdatePosition = value;}
        }
        ///<summary>Play Audio Comp</summary>
        public unsafe AudioComponent PlayAudioComp {
            get {return InterpTrackInstSound_ptr->PlayAudioComp;}
            set {InterpTrackInstSound_ptr->PlayAudioComp = value;}
        }
        static InterpTrackInstSound() {
            StaticClass = Main.GetClass("InterpTrackInstSound");
        }
        internal unsafe InterpTrackInstSound_fields* InterpTrackInstSound_ptr => (InterpTrackInstSound_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstSound(IntPtr p) => UObject.Make<InterpTrackInstSound>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstSound DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstSound New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
using UE4.UMG.Native;

namespace UE4.UMG {
    ///<summary>UMGSequence Player</summary>
    public unsafe partial class UMGSequencePlayer : UObject  {
        ///<summary>Animation being played</summary>
        public unsafe WidgetAnimation Animation {
            get {return UMGSequencePlayer_ptr->Animation;}
            set {UMGSequencePlayer_ptr->Animation = value;}
        }
        static UMGSequencePlayer() {
            StaticClass = Main.GetClass("UMGSequencePlayer");
        }
        internal unsafe UMGSequencePlayer_fields* UMGSequencePlayer_ptr => (UMGSequencePlayer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UMGSequencePlayer(IntPtr p) => UObject.Make<UMGSequencePlayer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UMGSequencePlayer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UMGSequencePlayer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

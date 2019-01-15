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
    ///<summary>Spectator Pawn Movement</summary>
    public unsafe partial class SpectatorPawnMovement : FloatingPawnMovement  {
        public bool bIgnoreTimeDilation {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreTimeDilation"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreTimeDilation", value); }
        }
        static SpectatorPawnMovement() {
            StaticClass = Main.GetClass("SpectatorPawnMovement");
        }
        internal unsafe SpectatorPawnMovement_fields* SpectatorPawnMovement_ptr => (SpectatorPawnMovement_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SpectatorPawnMovement(IntPtr p) => UObject.Make<SpectatorPawnMovement>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SpectatorPawnMovement DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SpectatorPawnMovement New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>Pending Net Game</summary>
    public unsafe partial class PendingNetGame : UObject  {
        ///<summary>Net driver created for contacting the new server</summary>
        ///<remarks>Transferred to world on successful connection</remarks>
        public unsafe NetDriver NetDriver {
            get {return PendingNetGame_ptr->NetDriver;}
            set {PendingNetGame_ptr->NetDriver = value;}
        }
        ///<summary>Demo Net driver created for loading demos, but we need to go through pending net game</summary>
        ///<remarks>Transferred to world on successful connection</remarks>
        public unsafe DemoNetDriver DemoNetDriver {
            get {return PendingNetGame_ptr->DemoNetDriver;}
            set {PendingNetGame_ptr->DemoNetDriver = value;}
        }
        static PendingNetGame() {
            StaticClass = Main.GetClass("PendingNetGame");
        }
        internal unsafe PendingNetGame_fields* PendingNetGame_ptr => (PendingNetGame_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PendingNetGame(IntPtr p) => UObject.Make<PendingNetGame>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PendingNetGame DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PendingNetGame New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

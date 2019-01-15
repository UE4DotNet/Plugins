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
    ///<summary>Volume that causes damage over time to any Actor that overlaps its collision.</summary>
    public unsafe partial class PainCausingVolume : PhysicsVolume  {
        public bool bPainCausing {
            get {return Main.GetGetBoolPropertyByName(this, "bPainCausing"); }
            set {Main.SetGetBoolPropertyByName(this, "bPainCausing", value); }
        }
        ///<summary>Damage done per second to actors in this volume when bPainCausing=true</summary>
        public unsafe float DamagePerSec {
            get {return PainCausingVolume_ptr->DamagePerSec;}
            set {PainCausingVolume_ptr->DamagePerSec = value;}
        }
        ///<summary>Type of damage done</summary>
        public unsafe SubclassOf<DamageType> DamageType {
            get {return PainCausingVolume_ptr->DamageType;}
            set {PainCausingVolume_ptr->DamageType = value;}
        }
        ///<summary>If pain causing, time between damage applications.</summary>
        public unsafe float PainInterval {
            get {return PainCausingVolume_ptr->PainInterval;}
            set {PainCausingVolume_ptr->PainInterval = value;}
        }
        public bool bEntryPain {
            get {return Main.GetGetBoolPropertyByName(this, "bEntryPain"); }
            set {Main.SetGetBoolPropertyByName(this, "bEntryPain", value); }
        }
        public bool BACKUP_bPainCausing {
            get {return Main.GetGetBoolPropertyByName(this, "BACKUP_bPainCausing"); }
            set {Main.SetGetBoolPropertyByName(this, "BACKUP_bPainCausing", value); }
        }
        ///<summary>Controller that gets credit for any damage caused by this volume</summary>
        public unsafe Controller DamageInstigator {
            get {return PainCausingVolume_ptr->DamageInstigator;}
            set {PainCausingVolume_ptr->DamageInstigator = value;}
        }
        static PainCausingVolume() {
            StaticClass = Main.GetClass("PainCausingVolume");
        }
        internal unsafe PainCausingVolume_fields* PainCausingVolume_ptr => (PainCausingVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PainCausingVolume(IntPtr p) => UObject.Make<PainCausingVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PainCausingVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PainCausingVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

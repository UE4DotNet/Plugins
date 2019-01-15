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
using UE4.LevelSequence.Native;

namespace UE4.LevelSequence {
    ///<summary>Level Sequence Burn in Options</summary>
    public unsafe partial class LevelSequenceBurnInOptions : UObject  {

        ///<summary>Loads the specified class path and initializes an instance, then stores it in Settings.</summary>
        public void SetBurnIn(SoftClassPath InBurnInClass)  => 
            LevelSequenceBurnInOptions_methods.SetBurnIn_method.Invoke(ObjPointer, InBurnInClass);
        public bool bUseBurnIn {
            get {return Main.GetGetBoolPropertyByName(this, "bUseBurnIn"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseBurnIn", value); }
        }
        ///<summary>Burn in Class</summary>
        public unsafe SoftClassPath BurnInClass {
            get {return LevelSequenceBurnInOptions_ptr->BurnInClass;}
            set {LevelSequenceBurnInOptions_ptr->BurnInClass = value;}
        }
        ///<summary>Settings</summary>
        public unsafe LevelSequenceBurnInInitSettings Settings {
            get {return LevelSequenceBurnInOptions_ptr->Settings;}
            set {LevelSequenceBurnInOptions_ptr->Settings = value;}
        }
        static LevelSequenceBurnInOptions() {
            StaticClass = Main.GetClass("LevelSequenceBurnInOptions");
        }
        internal unsafe LevelSequenceBurnInOptions_fields* LevelSequenceBurnInOptions_ptr => (LevelSequenceBurnInOptions_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelSequenceBurnInOptions(IntPtr p) => UObject.Make<LevelSequenceBurnInOptions>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelSequenceBurnInOptions DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelSequenceBurnInOptions New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

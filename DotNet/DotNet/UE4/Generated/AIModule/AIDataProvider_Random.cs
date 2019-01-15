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
using UE4.AIModule.Native;

namespace UE4.AIModule {
    ///<summary>AIData Provider Random</summary>
    public unsafe partial class AIDataProvider_Random : AIDataProvider_QueryParams  {
        ///<summary>Min</summary>
        public unsafe float Min {
            get {return AIDataProvider_Random_ptr->Min;}
            set {AIDataProvider_Random_ptr->Min = value;}
        }
        ///<summary>Max</summary>
        public unsafe float Max {
            get {return AIDataProvider_Random_ptr->Max;}
            set {AIDataProvider_Random_ptr->Max = value;}
        }
        public bool bInteger {
            get {return Main.GetGetBoolPropertyByName(this, "bInteger"); }
            set {Main.SetGetBoolPropertyByName(this, "bInteger", value); }
        }
        static AIDataProvider_Random() {
            StaticClass = Main.GetClass("AIDataProvider_Random");
        }
        internal unsafe AIDataProvider_Random_fields* AIDataProvider_Random_ptr => (AIDataProvider_Random_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AIDataProvider_Random(IntPtr p) => UObject.Make<AIDataProvider_Random>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AIDataProvider_Random DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AIDataProvider_Random New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
    ///<summary>Make Noise task node.</summary>
    ///<remarks>A task node that calls MakeNoise() on this Pawn when executed.</remarks>
    public unsafe partial class BTTask_MakeNoise : BTTaskNode  {
        ///<summary>Loudnes of generated noise</summary>
        public unsafe float Loudnes {
            get {return BTTask_MakeNoise_ptr->Loudnes;}
            set {BTTask_MakeNoise_ptr->Loudnes = value;}
        }
        static BTTask_MakeNoise() {
            StaticClass = Main.GetClass("BTTask_MakeNoise");
        }
        internal unsafe BTTask_MakeNoise_fields* BTTask_MakeNoise_ptr => (BTTask_MakeNoise_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTask_MakeNoise(IntPtr p) => UObject.Make<BTTask_MakeNoise>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTask_MakeNoise DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTask_MakeNoise New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

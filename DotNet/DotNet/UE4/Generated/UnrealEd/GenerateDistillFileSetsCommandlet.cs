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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Generate Distill File Sets Commandlet</summary>
    public unsafe partial class GenerateDistillFileSetsCommandlet : Commandlet  {
        static GenerateDistillFileSetsCommandlet() {
            StaticClass = Main.GetClass("GenerateDistillFileSetsCommandlet");
        }
        internal unsafe GenerateDistillFileSetsCommandlet_fields* GenerateDistillFileSetsCommandlet_ptr => (GenerateDistillFileSetsCommandlet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GenerateDistillFileSetsCommandlet(IntPtr p) => UObject.Make<GenerateDistillFileSetsCommandlet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GenerateDistillFileSetsCommandlet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GenerateDistillFileSetsCommandlet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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
using UE4.UMGEditor.Native;
using UE4.UnrealEd;

namespace UE4.UMGEditor {
    ///<summary>Slate Vector Art Data Factory</summary>
    public unsafe partial class SlateVectorArtDataFactory : Factory  {
        static SlateVectorArtDataFactory() {
            StaticClass = Main.GetClass("SlateVectorArtDataFactory");
        }
        internal unsafe SlateVectorArtDataFactory_fields* SlateVectorArtDataFactory_ptr => (SlateVectorArtDataFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SlateVectorArtDataFactory(IntPtr p) => UObject.Make<SlateVectorArtDataFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SlateVectorArtDataFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SlateVectorArtDataFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

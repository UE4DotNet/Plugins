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
using UE4.AudioEditor.Native;

namespace UE4.AudioEditor {
    ///<summary>Reimport Sound Surround Factory</summary>
    public unsafe partial class ReimportSoundSurroundFactory : SoundSurroundFactory  {
         //TODO: array not UObject TArray ReimportPaths
        static ReimportSoundSurroundFactory() {
            StaticClass = Main.GetClass("ReimportSoundSurroundFactory");
        }
        internal unsafe ReimportSoundSurroundFactory_fields* ReimportSoundSurroundFactory_ptr => (ReimportSoundSurroundFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ReimportSoundSurroundFactory(IntPtr p) => UObject.Make<ReimportSoundSurroundFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ReimportSoundSurroundFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ReimportSoundSurroundFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

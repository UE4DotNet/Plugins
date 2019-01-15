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
using UE4.MovieSceneTools.Native;

namespace UE4.MovieSceneTools {
    ///<summary>Settings for the level sequences</summary>
    public unsafe partial class MovieSceneToolsProjectSettings : UObject  {
        ///<summary>The default start time for new level sequences, in seconds.</summary>
        public unsafe float DefaultStartTime {
            get {return MovieSceneToolsProjectSettings_ptr->DefaultStartTime;}
            set {MovieSceneToolsProjectSettings_ptr->DefaultStartTime = value;}
        }
        ///<summary>The default duration for new level sequences in seconds.</summary>
        public unsafe float DefaultDuration {
            get {return MovieSceneToolsProjectSettings_ptr->DefaultDuration;}
            set {MovieSceneToolsProjectSettings_ptr->DefaultDuration = value;}
        }
         //TODO: string FString ShotDirectory
         //TODO: string FString ShotPrefix
         //TODO: numeric uint32 FirstShotNumber
         //TODO: numeric uint32 ShotIncrement
         //TODO: numeric uint32 ShotNumDigits
         //TODO: numeric uint32 TakeNumDigits
         //TODO: numeric uint32 FirstTakeNumber
         //TODO: string FString TakeSeparator
         //TODO: string FString SubSequenceSeparator
         //TODO: array not UObject TArray FbxSettings
        static MovieSceneToolsProjectSettings() {
            StaticClass = Main.GetClass("MovieSceneToolsProjectSettings");
        }
        internal unsafe MovieSceneToolsProjectSettings_fields* MovieSceneToolsProjectSettings_ptr => (MovieSceneToolsProjectSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneToolsProjectSettings(IntPtr p) => UObject.Make<MovieSceneToolsProjectSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneToolsProjectSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneToolsProjectSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

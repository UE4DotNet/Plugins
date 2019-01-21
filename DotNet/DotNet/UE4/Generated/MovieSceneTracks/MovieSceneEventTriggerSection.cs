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
using UE4.MovieSceneTracks.Native;

namespace UE4.MovieSceneTracks {
    ///<summary>Event section that triggeres specific timed events.</summary>
    public unsafe partial class MovieSceneEventTriggerSection : MovieSceneEventSectionBase  {
        ///<summary>The channel that defines this section's timed events</summary>
        public unsafe MovieSceneEventChannel EventChannel {
            get {return MovieSceneEventTriggerSection_ptr->EventChannel;}
            set {MovieSceneEventTriggerSection_ptr->EventChannel = value;}
        }
        static MovieSceneEventTriggerSection() {
            StaticClass = Main.GetClass("MovieSceneEventTriggerSection");
        }
        internal unsafe MovieSceneEventTriggerSection_fields* MovieSceneEventTriggerSection_ptr => (MovieSceneEventTriggerSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneEventTriggerSection(IntPtr p) => UObject.Make<MovieSceneEventTriggerSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneEventTriggerSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneEventTriggerSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

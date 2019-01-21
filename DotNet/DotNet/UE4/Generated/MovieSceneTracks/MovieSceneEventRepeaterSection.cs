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
    ///<summary>Event section that will trigger its event exactly once, every time it is evaluated.</summary>
    public unsafe partial class MovieSceneEventRepeaterSection : MovieSceneEventSectionBase  {
        ///<summary>The event that should be triggered each time this section is evaluated</summary>
        public unsafe MovieSceneEvent Event {
            get {return MovieSceneEventRepeaterSection_ptr->Event;}
            set {MovieSceneEventRepeaterSection_ptr->Event = value;}
        }
        static MovieSceneEventRepeaterSection() {
            StaticClass = Main.GetClass("MovieSceneEventRepeaterSection");
        }
        internal unsafe MovieSceneEventRepeaterSection_fields* MovieSceneEventRepeaterSection_ptr => (MovieSceneEventRepeaterSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneEventRepeaterSection(IntPtr p) => UObject.Make<MovieSceneEventRepeaterSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneEventRepeaterSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneEventRepeaterSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

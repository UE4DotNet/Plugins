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
    ///<summary>A single floating point section.</summary>
    public unsafe partial class MovieSceneSlomoSection : MovieSceneFloatSection  {
        static MovieSceneSlomoSection() {
            StaticClass = Main.GetClass("MovieSceneSlomoSection");
        }
        internal unsafe MovieSceneSlomoSection_fields* MovieSceneSlomoSection_ptr => (MovieSceneSlomoSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneSlomoSection(IntPtr p) => UObject.Make<MovieSceneSlomoSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneSlomoSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneSlomoSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

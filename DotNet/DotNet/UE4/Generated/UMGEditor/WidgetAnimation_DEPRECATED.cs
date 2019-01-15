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

using UE4.MovieScene;

namespace UE4.UMGEditor{
        ///<summary>Struct used only for loading old animations</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct WidgetAnimation_DEPRECATED {
            [FieldOffset(0)] 
            private IntPtr  UMovieScene_field;
            ///<summary>Movie Scene</summary>
            public UMovieScene UMovieScene {
                get {return UMovieScene_field;}
                set {UMovieScene_field = value;}
            }

            [FieldOffset(8)] byte AnimationBindings; //TODO: array TArray AnimationBindings

        }
}

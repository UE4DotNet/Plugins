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


namespace UE4.Engine{
        ///<summary>Helper struct for creating sub tracks supported by this track</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct SupportedSubTrackInfo {
            ///<summary>The sub track class which is supported by this track</summary>
            public SubclassOf<InterpTrack> SupportedClass {
                get {return SupportedClass_class; }
                set {SupportedClass_class = value; }
            }
            [FieldOffset(0)] private IntPtr SupportedClass_class;

            [FieldOffset(8)] byte SubTrackName; //TODO: string FString SubTrackName

            [FieldOffset(24)] public int GroupIndex;

        }
}

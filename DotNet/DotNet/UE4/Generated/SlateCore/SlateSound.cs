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


namespace UE4.SlateCore{
        ///<summary>An intermediary to make UBaseSound available for Slate to play sounds</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct SlateSound {
            [FieldOffset(0)] 
            private IntPtr  ResourceObject_field;
            ///<summary>Pointer to the USoundBase.</summary>
            ///<remarks>
            ///Holding onto it as a UObject because USoundBase is not available in Slate core.
            ///Edited via FSlateSoundStructCustomization to ensure you can only set USoundBase assets on it.
            ///</remarks>
            public UObject ResourceObject {
                get {return ResourceObject_field;}
                set {ResourceObject_field = value;}
            }

        }
}

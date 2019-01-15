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
        ///<summary>Composite Font</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct CompositeFont {
            ///<summary>The default typeface that will be used when not overridden by a sub-typeface</summary>
            [FieldOffset(0)] Typeface DefaultTypeface;

            ///<summary>The fallback typeface that will be used as a last resort when no other typeface provides a match</summary>
            [FieldOffset(16)] CompositeFallbackFont FallbackTypeface;

            [FieldOffset(40)] byte SubTypefaces; //TODO: array TArray SubTypefaces

        }
}

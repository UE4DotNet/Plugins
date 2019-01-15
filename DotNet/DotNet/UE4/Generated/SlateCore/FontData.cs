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
        ///<summary>Payload data describing an individual font in a typeface. Keep this lean as it's also used as a key!</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct FontData {
            [FieldOffset(0)] byte FontFilename; //TODO: string FString FontFilename

            [FieldOffset(16)] byte Hinting; //TODO: enum EFontHinting Hinting

            [FieldOffset(17)] byte LoadingPolicy; //TODO: enum EFontLoadingPolicy LoadingPolicy

            [FieldOffset(20)] public int SubFaceIndex;

            [FieldOffset(24)] 
            private IntPtr  FontFaceAsset_field;
            ///<summary>Font data v3. This points to a font face asset.</summary>
            public UObject FontFaceAsset {
                get {return FontFaceAsset_field;}
                set {FontFaceAsset_field = value;}
            }

        }
}

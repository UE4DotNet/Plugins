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

using UE4.Engine;

namespace UE4.UnrealEd{
        ///<summary>Used during asset renaming/duplication to specify class-specific package/group targets.</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct TemplateMapInfo {
            [FieldOffset(0)] 
            private IntPtr  ThumbnailTexture_field;
            ///<summary>The Texture2D associated with this map template</summary>
            public Texture2D ThumbnailTexture {
                get {return ThumbnailTexture_field;}
                set {ThumbnailTexture_field = value;}
            }

            [FieldOffset(8)] byte Map; //TODO: string FString Map

        }
}

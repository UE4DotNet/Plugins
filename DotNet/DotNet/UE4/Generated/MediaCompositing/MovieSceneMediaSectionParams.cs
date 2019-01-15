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

using UE4.MediaAssets;

namespace UE4.MediaCompositing{
        ///<summary>Movie Scene Media Section Params</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct MovieSceneMediaSectionParams {
            [FieldOffset(0)] 
            private IntPtr  MediaSoundComponent_field;
            ///<summary>Media Sound Component</summary>
            public MediaSoundComponent MediaSoundComponent {
                get {return MediaSoundComponent_field;}
                set {MediaSoundComponent_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  MediaSource_field;
            ///<summary>Media Source</summary>
            public MediaSource MediaSource {
                get {return MediaSource_field;}
                set {MediaSource_field = value;}
            }

            [FieldOffset(16)] 
            private IntPtr  MediaTexture_field;
            ///<summary>Media Texture</summary>
            public MediaTexture MediaTexture {
                get {return MediaTexture_field;}
                set {MediaTexture_field = value;}
            }

            [FieldOffset(24)] byte Proxy; //TODO: string FString Proxy

            ///<summary>Section Start Frame</summary>
            [FieldOffset(40)] FrameNumber SectionStartFrame;

            ///<summary>Section End Frame</summary>
            [FieldOffset(44)] FrameNumber SectionEndFrame;

        }
}

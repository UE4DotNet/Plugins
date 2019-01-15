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


namespace UE4.UnrealEd{
        ///<summary>Holds the settings for a class that needs a thumbnail renderer.</summary>
        ///<remarks>
        ///Each entry
        ///maps to a corresponding class and holds the information needed
        ///to render the thumbnail, including which object to render via and its
        ///border color.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct ThumbnailRenderingInfo {
            [FieldOffset(0)] byte ClassNeedingThumbnailName; //TODO: string FString ClassNeedingThumbnailName

            ///<summary>This is the class that this entry is for, i.</summary>
            ///<remarks>
            ///e. the class that
            ///will be rendered in the thumbnail views
            ///</remarks>
            public SubclassOf<UObject> ClassNeedingThumbnail {
                get {return ClassNeedingThumbnail_class; }
                set {ClassNeedingThumbnail_class = value; }
            }
            [FieldOffset(16)] private IntPtr ClassNeedingThumbnail_class;

            [FieldOffset(24)] byte RendererClassName; //TODO: string FString RendererClassName

            [FieldOffset(40)] 
            private IntPtr  Renderer_field;
            ///<summary>The instance of the renderer class</summary>
            public ThumbnailRenderer Renderer {
                get {return Renderer_field;}
                set {Renderer_field = value;}
            }

        }
}

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

namespace UE4.AppleVision.Native {
    [StructLayout( LayoutKind.Explicit, Size=136 )]
    internal unsafe struct AppleVisionDetectFacesAsyncTaskBlueprintProxy_fields {
        [FieldOffset(64)] byte OnSuccess; //TODO: multicast delegate FAppleVisionDetectFacesDelegate OnSuccess
        [FieldOffset(80)] byte OnFailure; //TODO: multicast delegate FAppleVisionDetectFacesDelegate OnFailure
        [FieldOffset(112)] public FaceDetectionResult FaceDetectionResult;
    }
    internal unsafe struct AppleVisionDetectFacesAsyncTaskBlueprintProxy_methods {
        internal struct CreateProxyObjectForDetectFaces_method {
            static internal IntPtr CreateProxyObjectForDetectFaces_ptr;
            static CreateProxyObjectForDetectFaces_method() {
                CreateProxyObjectForDetectFaces_ptr = Main.GetMethodUFunction(AppleVisionDetectFacesAsyncTaskBlueprintProxy.StaticClass, "CreateProxyObjectForDetectFaces");
            }

            internal static unsafe AppleVisionDetectFacesAsyncTaskBlueprintProxy Invoke(Texture SourceImage) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SourceImage;
                Main.GetProcessEvent(AppleVisionDetectFacesAsyncTaskBlueprintProxy.DefaultObject, CreateProxyObjectForDetectFaces_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
    }
    internal unsafe struct AppleVisionDetectFacesAsyncTaskBlueprintProxy_events {
    }
}

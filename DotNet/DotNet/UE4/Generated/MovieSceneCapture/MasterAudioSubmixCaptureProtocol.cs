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
using UE4.MovieSceneCapture.Native;

namespace UE4.MovieSceneCapture {
    ///<summary>This is an experimental audio capture implementation which captures the final output from the master submix.</summary>
    ///<remarks>
    ///This requires the new audiomixer (launch with "-audiomixer") and requires that your sequence can be played
    ///back in real-time (when rendering is disabled). If the sequence evaluation hitches the audio will become
    ///desynchronized due to their being more time passed in real time (platform time) than in the sequence itself.
    ///</remarks>
    public unsafe partial class MasterAudioSubmixCaptureProtocol : MovieSceneAudioCaptureProtocolBase  {
         //TODO: string FString FileName
        static MasterAudioSubmixCaptureProtocol() {
            StaticClass = Main.GetClass("MasterAudioSubmixCaptureProtocol");
        }
        internal unsafe MasterAudioSubmixCaptureProtocol_fields* MasterAudioSubmixCaptureProtocol_ptr => (MasterAudioSubmixCaptureProtocol_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MasterAudioSubmixCaptureProtocol(IntPtr p) => UObject.Make<MasterAudioSubmixCaptureProtocol>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MasterAudioSubmixCaptureProtocol DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MasterAudioSubmixCaptureProtocol New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

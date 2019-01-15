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
using UE4.LinearTimecode.Native;
using UE4.Engine;
using UE4.MediaAssets;

namespace UE4.LinearTimecode {
    ///<summary>Implements a Linear timecode decoder.</summary>
    public unsafe partial class LinearTimecodeComponent : SceneComponent  {

        ///<summary>
        ///Get the Frame Number
        ///@
        ///</summary>
        ///<remarks>return Frame Number</remarks>
        public int GetDropFrameNumber()  => 
            LinearTimecodeComponent_methods.GetDropFrameNumber_method.Invoke(ObjPointer);

        ///<summary>
        ///Convert a drop timecode into a frame number
        ///@
        ///</summary>
        ///<remarks>
        ///param Timecode - Used to access the framerate, and drop flag
        ///@param FrameNumber - returned calculated frame number
        ///</remarks>
        public static int GetDropTimeCodeFrameNumber(DropTimecode Timecode)  => 
            LinearTimecodeComponent_methods.GetDropTimeCodeFrameNumber_method.Invoke(Timecode);

        ///<summary>
        ///Convert frame number into a drop timecode
        ///@
        ///</summary>
        ///<remarks>
        ///param Timecode - used to access the framerate, and drop flag
        ///@param FrameNumber - Frame number to set in the returned timecode
        ///@param OutTimecode - Returned drop timecode
        ///</remarks>
        public static DropTimecode SetDropTimecodeFrameNumber(DropTimecode Timecode, int FrameNumber)  => 
            LinearTimecodeComponent_methods.SetDropTimecodeFrameNumber_method.Invoke(Timecode, FrameNumber);
        ///<summary>The media player asset associated with this component.</summary>
        public unsafe MediaPlayer MediaPlayer {
            get {return LinearTimecodeComponent_ptr->MediaPlayer;}
            set {LinearTimecodeComponent_ptr->MediaPlayer = value;}
        }
        ///<summary>Drop Timecode</summary>
        public unsafe DropTimecode DropTimecode {
            get {return LinearTimecodeComponent_ptr->DropTimecode;}
        }
         //TODO: multicast delegate FOnTimecodeChange OnTimecodeChange
        static LinearTimecodeComponent() {
            StaticClass = Main.GetClass("LinearTimecodeComponent");
        }
        internal unsafe LinearTimecodeComponent_fields* LinearTimecodeComponent_ptr => (LinearTimecodeComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LinearTimecodeComponent(IntPtr p) => UObject.Make<LinearTimecodeComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LinearTimecodeComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LinearTimecodeComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

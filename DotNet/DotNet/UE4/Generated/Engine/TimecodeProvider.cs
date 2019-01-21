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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>A class responsible of fetching a timecode from a source.</summary>
    ///<remarks>
    ///Note, FApp::GetTimecode and FApp::GetTimecodeFramerate should be used to retrieve
    ///the current system Timecode and Framerate.
    ///</remarks>
    public unsafe partial class TimecodeProvider : UObject  {

        ///<summary>Return the frame rate.</summary>
        ///<remarks>Depending on the implementation, it may or may not be valid only when GetSynchronizationState() is Synchronized.</remarks>
        public FrameRate GetFrameRate()  => 
            TimecodeProvider_methods.GetFrameRate_method.Invoke(ObjPointer);

        ///<summary>The state of the TimecodeProvider and if it's currently synchronized and the Timecode and FrameRate are valid.</summary>
        public ETimecodeProviderSynchronizationState GetSynchronizationState()  => 
            TimecodeProvider_methods.GetSynchronizationState_method.Invoke(ObjPointer);

        ///<summary>Return the Timecode at that moment.</summary>
        ///<remarks>
        ///It may not be in sync with the current frame.
        ///Only valid when GetSynchronizationState() is Synchronized.
        ///</remarks>
        public Timecode GetTimecode()  => 
            TimecodeProvider_methods.GetTimecode_method.Invoke(ObjPointer);
        static TimecodeProvider() {
            StaticClass = Main.GetClass("TimecodeProvider");
        }
        internal unsafe TimecodeProvider_fields* TimecodeProvider_ptr => (TimecodeProvider_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TimecodeProvider(IntPtr p) => UObject.Make<TimecodeProvider>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TimecodeProvider DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TimecodeProvider New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

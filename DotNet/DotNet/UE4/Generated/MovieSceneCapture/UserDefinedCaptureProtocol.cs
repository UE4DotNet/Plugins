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
using UE4.Engine;

namespace UE4.MovieSceneCapture {
    ///<summary>A blueprintable capture protocol that defines how to capture frames from the engine</summary>
    public unsafe partial class UserDefinedCaptureProtocol : MovieSceneImageCaptureProtocolBase  {

        ///<summary>Called when this protocol is going to be shut down - should not capture any more frames</summary>
        public event OnBeginFinalize_delegate OnBeginFinalize;
        public delegate void OnBeginFinalize_delegate();
        internal void on_OnBeginFinalize() =>
            OnBeginFinalize?.Invoke();


        ///<summary>Called when this protocol should capture the current frame</summary>
        public event OnCaptureFrame_delegate OnCaptureFrame;
        public delegate void OnCaptureFrame_delegate();
        internal void on_OnCaptureFrame() =>
            OnCaptureFrame?.Invoke();


        ///<summary>Called to complete finalization of this protocol</summary>
        public event OnFinalize_delegate OnFinalize;
        public delegate void OnFinalize_delegate();
        internal void on_OnFinalize() =>
            OnFinalize?.Invoke();


        ///<summary>Called when this protocol should temporarily stop capturing frames</summary>
        public event OnPauseCapture_delegate OnPauseCapture;
        public delegate void OnPauseCapture_delegate();
        internal void on_OnPauseCapture() =>
            OnPauseCapture?.Invoke();


        ///<summary>Called before the capture process itself is ticked, before each frame is set up for capture</summary>
        ///<remarks>Useful for any pre-frame set up or resetting the previous frame's state</remarks>
        public event OnPreTick_delegate OnPreTick;
        public delegate void OnPreTick_delegate();
        internal void on_OnPreTick() =>
            OnPreTick?.Invoke();


        ///<summary>Called when this protocol should start capturing frames</summary>
        public event OnStartCapture_delegate OnStartCapture;
        public delegate void OnStartCapture_delegate();
        internal void on_OnStartCapture() =>
            OnStartCapture?.Invoke();


        ///<summary>Called after the capture process itself is ticked, after the frame is set up for capture, but before most actors have ticked</summary>
        public event OnTick_delegate OnTick;
        public delegate void OnTick_delegate();
        internal void on_OnTick() =>
            OnTick?.Invoke();


        ///<summary>Called when the capture process is warming up. Protocols may transition from either an initialized, or capturing state to warm-up</summary>
        public event OnWarmUp_delegate OnWarmUp;
        public delegate void OnWarmUp_delegate();
        internal void on_OnWarmUp() =>
            OnWarmUp?.Invoke();


        ///<summary>Called to check whether this protocol has finished any pending tasks, and can now be shut down</summary>
        public event OnCanFinalize_delegate OnCanFinalize;
        public delegate bool OnCanFinalize_delegate(bool ReturnValue);
        internal bool on_OnCanFinalize(bool ReturnValue) =>
            OnCanFinalize != null ? OnCanFinalize(ReturnValue) : ReturnValue;


        ///<summary>
        ///Called once at the start of the capture process, but before any warmup frames
        ///@
        ///</summary>
        ///<remarks>return true if this protocol set up successfully, false otherwise</remarks>
        public event OnSetup_delegate OnSetup;
        public delegate bool OnSetup_delegate(bool ReturnValue);
        internal bool on_OnSetup(bool ReturnValue) =>
            OnSetup != null ? OnSetup(ReturnValue) : ReturnValue;


        ///<summary>Add a handler to the specified stream that will be called whenever it receives data.</summary>
        ///<remarks>
        ///Push data to a stream with either StartCapturingFinalPixels() or PushBufferToStream()
        ///
        ///@param StreamName      The name of the stream to bind this handler to. The handler will be invoked whenever pixels are received on that stream.
        ///@param Handler         A delegate for handling the pixels received on this stream name
        ///</remarks>
        public void BindToStream(Name StreamName, byte Handler /*TODO: delegate FOnReceiveCapturedPixels */)  => 
            UserDefinedCaptureProtocol_methods.BindToStream_method.Invoke(ObjPointer, StreamName, Handler);

        ///<summary>Generate a filename for the current frame</summary>
        public string GenerateFilename(FrameMetrics InFrameMetrics)  => 
            UserDefinedCaptureProtocol_methods.GenerateFilename_method.Invoke(ObjPointer, InFrameMetrics);

        ///<summary>Access this protocol's current frame metrics</summary>
        public FrameMetrics GetCurrentFrameMetrics()  => 
            UserDefinedCaptureProtocol_methods.GetCurrentFrameMetrics_method.Invoke(ObjPointer);

        ///<summary>
        ///* Capture the specified texture buffer using this protocol's settings
        ///*
        ///* @
        ///</summary>
        ///<remarks>
        ///param Buffer          The desired buffer to save
        ///* @param StreamName      The name of the stream to push the buffer onto (e.g. a composition pass name). Bind to the stream with BindStreamHandler.
        ///</remarks>
        public void PushBufferToStream(Texture Buffer, Name StreamName)  => 
            UserDefinedCaptureProtocol_methods.PushBufferToStream_method.Invoke(ObjPointer, Buffer, StreamName);

        ///<summary>
        ///* Resolve the specified buffer and pass it directly to the specified handler when done (does not pass to any bound streams)
        ///*
        ///* @
        ///</summary>
        ///<remarks>
        ///param Buffer          The desired buffer to save
        ///* @param BufferName      The name of this buffer that is passed to the resulting handler (e.g. a composition pass name).
        ///* @param Handler         A delegate for handling the pixels received on this stream name
        ///</remarks>
        public void ResolveBuffer(Texture Buffer, Name BufferName, byte Handler /*TODO: delegate FOnReceiveCapturedPixels */)  => 
            UserDefinedCaptureProtocol_methods.ResolveBuffer_method.Invoke(ObjPointer, Buffer, BufferName, Handler);

        ///<summary>
        ///Instruct this protocol to start capturing LDR final pixels (including slate widgets and burn-ins)
        ///@
        ///</summary>
        ///<remarks>param StreamName      The name of the stream to send final pixels to. Bind to streams with BindStreamHandler.</remarks>
        public void StartCapturingFinalPixels(Name StreamName)  => 
            UserDefinedCaptureProtocol_methods.StartCapturingFinalPixels_method.Invoke(ObjPointer, StreamName);

        ///<summary>Instruct this protocol to stop capturing LDR final pixels</summary>
        public void StopCapturingFinalPixels()  => 
            UserDefinedCaptureProtocol_methods.StopCapturingFinalPixels_method.Invoke(ObjPointer);
        ///<summary>World pointer assigned on Setup</summary>
        public unsafe World World {
            get {return UserDefinedCaptureProtocol_ptr->World;}
        }
        static UserDefinedCaptureProtocol() {
            StaticClass = Main.GetClass("UserDefinedCaptureProtocol");
            UserDefinedCaptureProtocol_events.OnBeginFinalize_event.Setup();
            UserDefinedCaptureProtocol_events.OnCaptureFrame_event.Setup();
            UserDefinedCaptureProtocol_events.OnFinalize_event.Setup();
            UserDefinedCaptureProtocol_events.OnPauseCapture_event.Setup();
            UserDefinedCaptureProtocol_events.OnPreTick_event.Setup();
            UserDefinedCaptureProtocol_events.OnStartCapture_event.Setup();
            UserDefinedCaptureProtocol_events.OnTick_event.Setup();
            UserDefinedCaptureProtocol_events.OnWarmUp_event.Setup();
            UserDefinedCaptureProtocol_events.OnCanFinalize_event.Setup();
            UserDefinedCaptureProtocol_events.OnSetup_event.Setup();
        }
        internal unsafe UserDefinedCaptureProtocol_fields* UserDefinedCaptureProtocol_ptr => (UserDefinedCaptureProtocol_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UserDefinedCaptureProtocol(IntPtr p) => UObject.Make<UserDefinedCaptureProtocol>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UserDefinedCaptureProtocol DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UserDefinedCaptureProtocol New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

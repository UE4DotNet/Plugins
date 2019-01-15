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
using UE4.Paper2D.Native;
using UE4.Engine;

namespace UE4.Paper2D {
    ///<summary>Contains an animation sequence of sprite frames</summary>
    public unsafe partial class PaperFlipbook : UObject  {

        ///<summary>Returns the keyframe index that covers the specified time (in seconds), or INDEX_NONE if none exists.</summary>
        ///<remarks>When bClampToEnds is true, it will choose the first or last keyframe if the time is out of range.</remarks>
        public int GetKeyFrameIndexAtTime(float Time, bool bClampToEnds)  => 
            PaperFlipbook_methods.GetKeyFrameIndexAtTime_method.Invoke(ObjPointer, Time, bClampToEnds);

        ///<summary>Returns the total number of frames</summary>
        public int GetNumFrames()  => 
            PaperFlipbook_methods.GetNumFrames_method.Invoke(ObjPointer);

        ///<summary>Returns the number of key frames</summary>
        public int GetNumKeyFrames()  => 
            PaperFlipbook_methods.GetNumKeyFrames_method.Invoke(ObjPointer);

        ///<summary>Returns the sprite at the specified keyframe index, or nullptr if none exists</summary>
        public PaperSprite GetSpriteAtFrame(int FrameIndex)  => 
            PaperFlipbook_methods.GetSpriteAtFrame_method.Invoke(ObjPointer, FrameIndex);

        ///<summary>Returns the sprite at the specified time (in seconds), or nullptr if none exists.</summary>
        ///<remarks>When bClampToEnds is true, it will choose the first or last sprite if the time is out of range.</remarks>
        public PaperSprite GetSpriteAtTime(float Time, bool bClampToEnds)  => 
            PaperFlipbook_methods.GetSpriteAtTime_method.Invoke(ObjPointer, Time, bClampToEnds);

        ///<summary>Returns the total duration in seconds</summary>
        public float GetTotalDuration()  => 
            PaperFlipbook_methods.GetTotalDuration_method.Invoke(ObjPointer);

        ///<summary>Is the specified Index within the valid range of key frames?</summary>
        public bool IsValidKeyFrameIndex(int Index)  => 
            PaperFlipbook_methods.IsValidKeyFrameIndex_method.Invoke(ObjPointer, Index);
        ///<summary>The nominal frame rate to play this flipbook animation back at</summary>
        public unsafe float FramesPerSecond {
            get {return PaperFlipbook_ptr->FramesPerSecond;}
        }
         //TODO: array not UObject TArray KeyFrames
        ///<summary>The material to use on a flipbook player instance if not overridden</summary>
        public unsafe MaterialInterface DefaultMaterial {
            get {return PaperFlipbook_ptr->DefaultMaterial;}
        }
        ///<summary>Collision source</summary>
        public unsafe byte CollisionSource {
            get {return PaperFlipbook_ptr->CollisionSource;}
        }
        static PaperFlipbook() {
            StaticClass = Main.GetClass("PaperFlipbook");
        }
        internal unsafe PaperFlipbook_fields* PaperFlipbook_ptr => (PaperFlipbook_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperFlipbook(IntPtr p) => UObject.Make<PaperFlipbook>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperFlipbook DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperFlipbook New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

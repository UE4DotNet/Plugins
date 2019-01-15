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
using UE4.UMG.Native;
using UE4.MovieScene;

namespace UE4.UMG {
    ///<summary>Widget Animation</summary>
    public unsafe partial class WidgetAnimation : MovieSceneSequence  {

        ///<summary>Get the end time of this animation.</summary>
        ///<remarks>
        ///@return End time in seconds.
        ///@see GetStartTime
        ///</remarks>
        public float GetEndTime()  => 
            WidgetAnimation_methods.GetEndTime_method.Invoke(ObjPointer);

        ///<summary>Get the start time of this animation.</summary>
        ///<remarks>
        ///@return Start time in seconds.
        ///@see GetEndTime
        ///</remarks>
        public float GetStartTime()  => 
            WidgetAnimation_methods.GetStartTime_method.Invoke(ObjPointer);
         //TODO: multicast delegate FOnWidgetAnimationPlaybackStatusChanged OnAnimationStarted
         //TODO: multicast delegate FOnWidgetAnimationPlaybackStatusChanged OnAnimationFinished
        ///<summary>Pointer to the movie scene that controls this animation.</summary>
        public unsafe UMovieScene UMovieScene {
            get {return WidgetAnimation_ptr->UMovieScene;}
            set {WidgetAnimation_ptr->UMovieScene = value;}
        }
         //TODO: array not UObject TArray AnimationBindings
        public bool bLegacyFinishOnStop {
            get {return Main.GetGetBoolPropertyByName(this, "bLegacyFinishOnStop"); }
            set {Main.SetGetBoolPropertyByName(this, "bLegacyFinishOnStop", value); }
        }
        static WidgetAnimation() {
            StaticClass = Main.GetClass("WidgetAnimation");
        }
        internal unsafe WidgetAnimation_fields* WidgetAnimation_ptr => (WidgetAnimation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WidgetAnimation(IntPtr p) => UObject.Make<WidgetAnimation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WidgetAnimation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WidgetAnimation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

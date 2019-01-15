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
using UE4.AnimGraphRuntime.Native;
using UE4.Engine;

namespace UE4.AnimGraphRuntime {
    ///<summary>Play Montage Callback Proxy</summary>
    public unsafe partial class PlayMontageCallbackProxy : UObject  {

        ///<summary>Called to perform the query internally</summary>
        public static PlayMontageCallbackProxy CreateProxyObjectForPlayMontage(SkeletalMeshComponent InSkeletalMeshComponent, AnimMontage MontageToPlay, float PlayRate, float StartingPosition, Name StartingSection)  => 
            PlayMontageCallbackProxy_methods.CreateProxyObjectForPlayMontage_method.Invoke(InSkeletalMeshComponent, MontageToPlay, PlayRate, StartingPosition, StartingSection);
         //TODO: multicast delegate FOnMontagePlayDelegate OnCompleted
         //TODO: multicast delegate FOnMontagePlayDelegate OnBlendOut
         //TODO: multicast delegate FOnMontagePlayDelegate OnInterrupted
         //TODO: multicast delegate FOnMontagePlayDelegate OnNotifyBegin
         //TODO: multicast delegate FOnMontagePlayDelegate OnNotifyEnd
        static PlayMontageCallbackProxy() {
            StaticClass = Main.GetClass("PlayMontageCallbackProxy");
        }
        internal unsafe PlayMontageCallbackProxy_fields* PlayMontageCallbackProxy_ptr => (PlayMontageCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PlayMontageCallbackProxy(IntPtr p) => UObject.Make<PlayMontageCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PlayMontageCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PlayMontageCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}

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


namespace UE4.Engine{
        ///<summary>Triggers an animation notify.</summary>
        ///<remarks>
        ///Each AnimNotifyEvent contains an AnimNotify object
        ///which has its Notify method called and passed to the animation.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=184 )]
        public unsafe struct AnimNotifyEvent {
            [FieldOffset(52)] public float TriggerTimeOffset;

            [FieldOffset(56)] public float EndTriggerTimeOffset;

            [FieldOffset(60)] public float TriggerWeightThreshold;

            [FieldOffset(64)] public Name NotifyName;

            [FieldOffset(80)] 
            private IntPtr  Notify_field;
            ///<summary>Notify</summary>
            public AnimNotify Notify {
                get {return Notify_field;}
                set {Notify_field = value;}
            }

            [FieldOffset(88)] 
            private IntPtr  NotifyStateClass_field;
            ///<summary>Notify State Class</summary>
            public AnimNotifyState NotifyStateClass {
                get {return NotifyStateClass_field;}
                set {NotifyStateClass_field = value;}
            }

            [FieldOffset(96)] public float Duration;

            ///<summary>Linkable element to use for the end handle representing a notify state duration</summary>
            [FieldOffset(104)] AnimLinkableElement EndLink;

            [FieldOffset(152)] public bool bConvertedFromBranchingPoint;

            [FieldOffset(153)] public byte MontageTickType;

            [FieldOffset(156)] public float NotifyTriggerChance;

            [FieldOffset(160)] public byte NotifyFilterType;

            [FieldOffset(164)] public int NotifyFilterLOD;

            [FieldOffset(168)] public bool bTriggerOnDedicatedServer;

            [FieldOffset(169)] public bool bTriggerOnFollower;

            ///<summary>Color of Notify in editor</summary>
            [FieldOffset(172)] Color NotifyColor;

            [FieldOffset(176)] public int TrackIndex;

        }
}

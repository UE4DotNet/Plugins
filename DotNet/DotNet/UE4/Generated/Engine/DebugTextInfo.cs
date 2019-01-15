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
        ///<summary>* Single entry of a debug text item to render.</summary>
        ///<remarks>
        ///*
        ///* @see AHud
        ///* @see AddDebugText(), RemoveDebugText() and DrawDebugTextList()
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct DebugTextInfo {
            [FieldOffset(0)] 
            private IntPtr  SrcActor_field;
            ///<summary>AActor related to text item</summary>
            public Actor SrcActor {
                get {return SrcActor_field;}
                set {SrcActor_field = value;}
            }

            ///<summary>Offset from SrcActor.Location to apply</summary>
            [FieldOffset(8)] Vector SrcActorOffset;

            ///<summary>Desired offset to interpolate to</summary>
            [FieldOffset(20)] Vector SrcActorDesiredOffset;

            [FieldOffset(32)] byte DebugText; //TODO: string FString DebugText

            [FieldOffset(48)] public float TimeRemaining;

            [FieldOffset(52)] public float Duration;

            ///<summary>Text color</summary>
            [FieldOffset(56)] Color TextColor;

            [FieldOffset(60)] public bool bAbsoluteLocation;

            [FieldOffset(60)] public bool bKeepAttachedToActor;

            [FieldOffset(60)] public bool bDrawShadow;

            ///<summary>When we first spawn store off the original actor location for use with bKeepAttachedToActor</summary>
            [FieldOffset(64)] Vector OrigActorLocation;

            [FieldOffset(80)] 
            private IntPtr  Font_field;
            ///<summary>The Font which to display this as.  Will Default to GetSmallFont()*</summary>
            public Font Font {
                get {return Font_field;}
                set {Font_field = value;}
            }

            [FieldOffset(88)] public float FontScale;

        }
}

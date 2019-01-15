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
        ///<summary>Timeline</summary>
        [StructLayout( LayoutKind.Explicit, Size=168 )]
        public unsafe struct Timeline {
            [FieldOffset(0)] public byte LengthMode;

            [FieldOffset(1)] public bool bLooping;

            [FieldOffset(1)] public bool bReversePlayback;

            [FieldOffset(1)] public bool bPlaying;

            [FieldOffset(4)] public float Length;

            [FieldOffset(8)] public float PlayRate;

            [FieldOffset(12)] public float Position;

            [FieldOffset(16)] byte Events; //TODO: array TArray Events

            [FieldOffset(32)] byte InterpVectors; //TODO: array TArray InterpVectors

            [FieldOffset(48)] byte InterpFloats; //TODO: array TArray InterpFloats

            [FieldOffset(64)] byte InterpLinearColors; //TODO: array TArray InterpLinearColors

            [FieldOffset(80)] byte TimelinePostUpdateFunc; //TODO: delegate FOnTimelineEvent TimelinePostUpdateFunc

            [FieldOffset(100)] byte TimelineFinishedFunc; //TODO: delegate FOnTimelineEvent TimelineFinishedFunc

            [FieldOffset(120)] byte PropertySetObject; //TODO: weak object TWeakObjectPtr<UObject> PropertySetObject

            [FieldOffset(128)] public Name DirectionPropertyName;

            [FieldOffset(160)] 
            private IntPtr  DirectionProperty_field;
            ///<summary>Cached property pointer for setting timeline direction</summary>
            public Property DirectionProperty {
                get {return DirectionProperty_field;}
                set {DirectionProperty_field = value;}
            }

        }
}

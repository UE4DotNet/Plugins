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
        ///<summary>Used to describe an element that can be linked to a segment in a montage or sequence.</summary>
        ///<remarks>
        ///Usage:
        ///           Inherit from FAnimLinkableElement and make sure to call LinkMontage or LinkSequence
        ///           both on creation and on loading the element. From there SetTime and GetTime should be
        ///           used to control where this element is in the montage or sequence.
        ///
        ///           For more advanced usage, see this implementation used in FAnimNotifyEvent where
        ///           we have a secondary link to handle a duration
        ///           @see FAnimNotifyEvent
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct AnimLinkableElement {
            [FieldOffset(8)] 
            private IntPtr  LinkedMontage_field;
            ///<summary>The montage that this element is currently linked to</summary>
            public AnimMontage LinkedMontage {
                get {return LinkedMontage_field;}
                set {LinkedMontage_field = value;}
            }

            [FieldOffset(16)] public int SlotIndex;

            [FieldOffset(20)] public int SegmentIndex;

            [FieldOffset(24)] public byte LinkMethod;

            [FieldOffset(25)] public byte CachedLinkMethod;

            [FieldOffset(28)] public float SegmentBeginTime;

            [FieldOffset(32)] public float SegmentLength;

            [FieldOffset(36)] public float LinkValue;

            [FieldOffset(40)] 
            private IntPtr  LinkedSequence_field;
            ///<summary>The Animation Sequence that this montage element will link to, when the sequence changes</summary>
            ///<remarks>in either length or rate; the element will correctly place itself in relation to the sequence</remarks>
            public AnimSequenceBase LinkedSequence {
                get {return LinkedSequence_field;}
                set {LinkedSequence_field = value;}
            }

        }
}

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


namespace UE4.SourceControl{
        ///<summary>
        ///Snapshot of source control state of for a file
        ///@
        ///</summary>
        ///<remarks>see        USourceControlHelpers::QueryFileState()</remarks>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct SourceControlState {
            [FieldOffset(0)] byte Filename; //TODO: string FString Filename

            [FieldOffset(16)] public bool bIsValid;

            [FieldOffset(17)] public bool bIsUnknown;

            [FieldOffset(18)] public bool bCanCheckIn;

            [FieldOffset(19)] public bool bCanCheckOut;

            [FieldOffset(20)] public bool bIsCheckedOut;

            [FieldOffset(21)] public bool bIsCurrent;

            [FieldOffset(22)] public bool bIsSourceControlled;

            [FieldOffset(23)] public bool bIsAdded;

            [FieldOffset(24)] public bool bIsDeleted;

            [FieldOffset(25)] public bool bIsIgnored;

            [FieldOffset(26)] public bool bCanEdit;

            [FieldOffset(27)] public bool bCanDelete;

            [FieldOffset(28)] public bool bIsModified;

            [FieldOffset(29)] public bool bCanAdd;

            [FieldOffset(30)] public bool bIsConflicted;

            [FieldOffset(31)] public bool bCanRevert;

            [FieldOffset(32)] public bool bIsCheckedOutOther;

            [FieldOffset(40)] byte CheckedOutOther; //TODO: string FString CheckedOutOther

        }
}

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
        ///<summary>Helper struct for tracking on screen messages.</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct ScreenMessageString {
            [FieldOffset(0)] byte Key; //TODO: numeric uint64 Key

            [FieldOffset(8)] byte ScreenMessage; //TODO: string FString ScreenMessage

            ///<summary>The color to display the message in.</summary>
            [FieldOffset(24)] Color DisplayColor;

            [FieldOffset(28)] public float TimeToDisplay;

            [FieldOffset(32)] public float CurrentTimeDisplayed;

            ///<summary>Scale of text</summary>
            [FieldOffset(36)] Vector2D TextScale;

        }
}

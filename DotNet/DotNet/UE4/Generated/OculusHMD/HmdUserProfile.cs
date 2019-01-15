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


namespace UE4.OculusHMD{
        ///<summary>Hmd User Profile</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct HmdUserProfile {
            [FieldOffset(0)] byte Name; //TODO: string FString Name

            [FieldOffset(16)] byte Gender; //TODO: string FString Gender

            [FieldOffset(32)] public float PlayerHeight;

            [FieldOffset(36)] public float EyeHeight;

            [FieldOffset(40)] public float IPD;

            ///<summary>Neck-to-eye distance, in meters. X - horizontal, Y - vertical.</summary>
            [FieldOffset(44)] Vector2D NeckToEyeDistance;

            [FieldOffset(56)] byte ExtraFields; //TODO: array TArray ExtraFields

        }
}

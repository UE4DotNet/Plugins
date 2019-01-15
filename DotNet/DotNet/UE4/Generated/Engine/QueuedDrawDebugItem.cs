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
        ///<summary>Queued Draw Debug Item</summary>
        [StructLayout( LayoutKind.Explicit, Size=104 )]
        public unsafe struct QueuedDrawDebugItem {
            [FieldOffset(0)] public byte ItemType;

            ///<summary>Start Loc</summary>
            [FieldOffset(4)] Vector StartLoc;

            ///<summary>End Loc</summary>
            [FieldOffset(16)] Vector EndLoc;

            ///<summary>Center</summary>
            [FieldOffset(28)] Vector Center;

            ///<summary>Rotation</summary>
            [FieldOffset(40)] Rotator Rotation;

            [FieldOffset(52)] public float Radius;

            [FieldOffset(56)] public float Size;

            [FieldOffset(60)] public int Segments;

            ///<summary>Color</summary>
            [FieldOffset(64)] Color Color;

            [FieldOffset(68)] public bool bPersistentLines;

            [FieldOffset(72)] public float LifeTime;

            [FieldOffset(76)] public float Thickness;

            [FieldOffset(80)] byte Message; //TODO: string FString Message

            ///<summary>Text Scale</summary>
            [FieldOffset(96)] Vector2D TextScale;

        }
}

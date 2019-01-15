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


namespace UE4.MagicLeap{
        ///<summary>Represents the featuers of a found object.</summary>
        [StructLayout( LayoutKind.Explicit, Size=104 )]
        public unsafe struct FoundObjectResult {
            [FieldOffset(0)] byte ObjectUID; //TODO: string FString ObjectUID

            [FieldOffset(16)] byte ObjectType; //TODO: enum EFoundObjectType ObjectType

            ///<summary>Position of the center of the found object in world coordinates.</summary>
            [FieldOffset(20)] Vector ObjectPosition;

            ///<summary>Orientation of the found object.</summary>
            [FieldOffset(32)] Rotator ObjectOrientation;

            ///<summary>Dimensions of the found object (in Unreal units).</summary>
            [FieldOffset(44)] Vector ObjectDimensions;

            [FieldOffset(56)] byte ObjectLabels; //TODO: array TArray ObjectLabels

            [FieldOffset(72)] byte ObjectProperties; //TODO: array TArray ObjectProperties

            [FieldOffset(88)] byte RelatedObjectID; //TODO: string FString RelatedObjectID

        }
}

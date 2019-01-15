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


namespace UE4.SlateCore{
        ///<summary>Represents the position, size, and absolute position of a Widget in Slate.</summary>
        ///<remarks>
        ///The absolute location of a geometry is usually screen space or
        ///window space depending on where the geometry originated.
        ///Geometries are usually paired with a SWidget pointer in order
        ///to provide information about a specific widget (see FArrangedWidget).
        ///A Geometry's parent is generally thought to be the Geometry of the
        ///the corresponding parent widget.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct Geometry {
        }
}

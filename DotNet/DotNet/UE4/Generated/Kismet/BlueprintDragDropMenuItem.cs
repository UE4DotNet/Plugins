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


namespace UE4.Kismet{
        ///<summary>
        ///At certain times we want a single menu entry that represents a set of
        ///UBlueprintNodeSpawners (generally when all those UBlueprintNodeSpawners wrap
        ///the same UField).
        ///</summary>
        ///<remarks>
        ///We do this to keep the menu less jumbled, and instead
        ///use the drag/drop action to present a sub-menu to the user (so they can pick
        ///the the node type that they want). We do this with both delegates and
        ///variable nodes (where the user can pick a getter vs. a setter, etc.).
        ///
        ///This class represents those "consolidated" actions, and essentially serves
        ///as a FDragDropOperation spawner. It wraps a single UBlueprintNodeSpawner (any
        ///one of the set that it is supposed to represent), that it uses to determine
        ///the proper FDragDropOperation.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=336 )]
        public unsafe struct BlueprintDragDropMenuItem {
        }
}

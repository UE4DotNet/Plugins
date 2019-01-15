using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UE4.Engine;

namespace UE4.Core {
    [StructLayout( LayoutKind.Explicit, Size = 12 )]
    public struct Name : IEquatable<string> {
        
        public static Name Make( string nameText ) =>
            Main.GetNameFunction(nameText);

        public bool Equals( Name other ) =>
            ComparisonIndex == other.ComparisonIndex;

        public override int GetHashCode() =>
            ComparisonIndex;

        public override string ToString() =>
            KismetStringLibrary.Conv_NameToString( this );

        public bool Equals( string other ) =>
            ToString() == other;

        public static implicit operator Name(string name) =>
            Make(name);

        //TODO: IEquatable<string>

        [FieldOffset(0)]
        private readonly int ComparisonIndex;
        [FieldOffset(4)]
        private readonly int DisplayIndex;
        [FieldOffset(8)]
        private readonly int Number;
    }
}

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UE4.Engine;
using UE4.Native;

namespace UE4.DotNet {
    internal delegate void UnusedDelegate();

    public partial class DotNetGameModeBase : GameModeBase {

        private unsafe struct Local {
            public static GameModeBaseInterface* NativeFunctions;

            public static UnusedDelegate Unused;

            static Local() {
                NativeFunctions = (GameModeBaseInterface*) Interfaces.Get( Core.Name.Make( "GameModeBase" ) ).ToPointer();
                Debug.Assert( NativeFunctions != null );
                NativeFunctions->Validate();
                Unused = Marshal.GetDelegateForFunctionPointer<UnusedDelegate>( NativeFunctions->Unused );
            }
        }
    }

    [StructLayout( LayoutKind.Sequential, Pack = 0 )]
    internal struct GameModeBaseInterface {
        uint StartGuardian;
        uint SizeOfShared;
        int FNameID;

        internal IntPtr Unused;

        uint EndGuardian;

        public void Validate() {
            var size = Marshal.SizeOf<GameModeBaseInterface>();
            Debug.Assert( StartGuardian == 0x12345678 &&
                EndGuardian == 0x87654321 &&
                SizeOfShared == size
                );
        }
    }


}

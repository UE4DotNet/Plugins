using System;
using UE4.DotNet;

namespace Game
{
    public class MyGameInstance : DotNetGameInstance
    {
        /// <summary>
        /// Preallocated shared UE4 pointers used to manage garbage collection.  
        /// </summary>
        public override int MaxSharedPointerCount => base.MaxSharedPointerCount;

        /// <summary>
        /// Game Mode used for this game.
        /// </summary>
        public override Type GameModeBaseType => typeof( MyGameMode );
    }
}

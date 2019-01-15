using System;

using UE4.CoreUObject;
using UE4.Engine;

namespace UE4.DotNet {
    public partial class DotNetGameInstance : GameInstance {
        /// <summary>
        /// Subclass of GameModeBase to use for Game Mode.
        /// </summary>
        public virtual Type GameModeBaseType => typeof( GameModeBase );

        /// <summary>
        /// The maximum number of pointers expected to be shared between DotNet and UE4.  
        /// This will be used to reserve space for the ObjectsSharedWithDotNet array
        /// so there will be no re-allocation during game play.
        /// </summary>
        public virtual int MaxSharedPointerCount => 1000;

        /// <summary>
        /// GameMode is the rules keeper for this game.
        /// </summary>
        public virtual GameModeBase GameMode { get; protected set; }

        public override void Construct() {
            base.Construct();

            this.SetGameModeBase += SetGameModeForURL;
        }


        /// <summary>
        /// Called after Game DLL is loaded, but before anything else
        /// </summary>
        /// <param name="arguments">Argument set in editor configuration</param>
        public virtual void Start( string argument ) {
        }


        /// <summary>
        /// Event handler called when new GameMode is created.
        /// </summary>
        /// <remarks>
        /// This is called when a GameModeBase is created for this instance.  It allows the
        /// Game to create a C# GameModeBase subclass.
        /// </remarks>
        /// <param name="gameModeBase">The UE4 GameModeBase Object</param>
        /// <param name="inMapURL">The URL for the map being loaded</param>
        protected virtual void SetGameModeForURL( GameModeBase gameModeBase, string inMapURL ) {
            if (GameModeBaseType != null)
                GameMode = (GameModeBase) UObject.CastTo( (UObject) gameModeBase, GameModeBaseType );
        }
    }
}

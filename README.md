<img width="400px" src=https://raw.githubusercontent.com/mackieks/brc-lodmod/refs/heads/main/lodmod_banner.jpg>

LOD mod for Bomb Rush Cyberfunk on PC, to vastly increase NPC and clutter draw distance

## Background
The mod consists of two DLLs:
- A BepInEx 5.4.21.0 plugin to force lodBias to 15,000 (so textures are always max quality, and clutter like tables/chairs/fences are never culled based on distance from the player)
- A modified Assembly-CSharp.dll that
    - sets StreetLifeCluster.deactivateDistance to 1000000000 (stock is 63!) so NPCs render infinitely far from the player
    - sets distanceOptimize to false
    - forces stage chunks to stay loaded, which ensures maximum crowd and clutter density in big levels
 
The FPS hit is minor since the game is so low poly and CPU-light to begin with. 

<img width="1280px" src=https://raw.githubusercontent.com/mackieks/brc-lodmod/refs/heads/main/lodmod.jpg>

## Installation

1. Install [BepInEx 5.4.21.0](https://thunderstore.io/c/bomb-rush-cyberfunk/p/BepInEx/BepInExPack/)
2. Extract BombRushCyberfunk.zip from [Releases](https://github.com/mackieks/brc-lodmod/releases) into your install folder and replace files when asked (note: the mod ships with a backup of the original Assembly-CSharp.dll)
4. **Important:** don't edit the video settings from the in-game menu! Doing so will reset lodBias and deactivate the mod. I might fix this eventually.

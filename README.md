<img width="400px" src=https://raw.githubusercontent.com/mackieks/brc-lodmod/refs/heads/main/lodmod_banner.jpg>

LOD mod for Bomb Rush Cyberfunk on PC, to vastly increase NPC and clutter draw distance

## Background
The mod consists of:
- A modified Assembly-CSharp.dll that
    - force lodBias to 15,000 (so textures are always max quality, and clutter like tables/chairs/fences are never culled based on distance from the player)
    - sets StreetLifeCluster.deactivateDistance to 300 (stock is 63) so NPCs render 4.75x as far from the player
    - adjusts Reptile.StageChunk.PointInOBB bounds to 1.5x instead of 0.5x, so chunks render in a 3x wider radius from the player
        - this has compounding benefits since lots of stage geometry is culled using chunk loading (See the Brink Terminal comparison pic)
 
The FPS hit varies depending on level. In areas with lots of NPCs that are usually culled, like Brink Terminal, FPS is halved on my rig. 

<img width="1280px" src=https://raw.githubusercontent.com/mackieks/brc-lodmod/refs/heads/main/lodmod-2.jpg>

<img width="1280px" src=https://raw.githubusercontent.com/mackieks/brc-lodmod/refs/heads/main/lodmod.jpg>

## Installation

1. Install [BepInEx 5.4.21.0](https://thunderstore.io/c/bomb-rush-cyberfunk/p/BepInEx/BepInExPack/)
2. Extract BombRushCyberfunk.zip from [Releases](https://github.com/mackieks/brc-lodmod/releases) into your install folder and replace files when asked (note: the mod ships with a backup of the original Assembly-CSharp.dll)
4. **Important:** don't edit the video settings from the in-game menu! Doing so will reset lodBias and deactivate the mod. I might fix this eventually.

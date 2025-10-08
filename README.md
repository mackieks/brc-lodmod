<img width="400px" src=https://raw.githubusercontent.com/mackieks/brc-lodmod/refs/heads/main/lodmod_banner.jpg>

LOD mod for Bomb Rush Cyberfunk on PC, to vastly increase NPC and clutter draw distance

## Background
The mod consists of:
- A modified Assembly-CSharp.dll that
    - forces `QualitySettings.lodBias = 15000f` so textures are always max quality, and clutter like tables/chairs/fences are never culled based on distance from the player
    - forces `QualitySettings.shadowDistance = 2000f` so faraway NPCs and objects cast dynamic shadows (default is `500`) 
    - sets `StreetLifeCluster.deactivateDistance = 300f` (stock is `63f`) so NPCs render 4.75x as far from the player
    - adjusts `Reptile.StageChunk.PointInOBB` bounds to 1.5x instead of 0.5x, so chunks render in a 3x wider radius from the player
        - this eliminates virtually all pop-in during normal gameplay
        - Brink Terminal (Stage.tower) has some unique chunk loading behavior and is kept at the stock 0.5x value to avoid graphical glitches
    - forces NPCs to stay visible at all times, even during police chases
        - `Reptile.StreetLifeCluster.hideFromWantedStar = -1;`
 
The FPS hit varies depending on level. In areas with lots of NPCs that are usually culled, like Brink Terminal, FPS is halved on my rig from 480 to ~200.

<img width="1280px" src=https://raw.githubusercontent.com/mackieks/brc-lodmod/refs/heads/main/lodmod.jpg>

## Installation

1. Extract BombRushCyberfunk.zip from [Releases](https://github.com/mackieks/brc-lodmod/releases) into your install folder and replace files when asked (note: the mod ships with a backup of the original Assembly-CSharp.dll)

You can edit the video settings from the in-game menu freely. Doing so won't affect the LOD settings whatsoever, since they're hardcoded in the DLL.

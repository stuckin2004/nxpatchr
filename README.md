# NXPatchr
> Finally, a friendly tool for modding NX games!

This is the main repo for **NXPatchr**, a C# project that makes modifying your Nintendo Switch games easy, and friendly.

The main and eternal goal of this app is to unify and simplify the process of modifying your games without the headaches of modifying your games. I personally have found that modifying NX games to be extremely tedious and quite unstable. NXPatchr fixes this by providing a patch-file. Simply speaking: a patch file is a small file that describes only the differences between the original game and the modded version. Not the game data itself. Instead of distributing entire modified game files (which would be both illegal and extremely inconvenient), mod authors distribute a tiny `.nxpatch` patch file that NXPatchr applies to your own purchased games.

**NXPatchr** exists because modding games shouldn't be hard for the end-user.

## Requirements & Installing

Before you install and use this program, you'll want the following things:
 - A modified Nintendo Switch (I recommend the [Atmosphère](https://github.com/Atmosphere-NX/Atmosphere) CFW)
 - A dump of the game you want to mod
     - This requires CFW and a legal copy of the game
 - A copy of the `prod.keys` file dumped from your Nintendo Switch
     - This also requires CFW, **do not trust random files online!**

> [!IMPORTANT]
> NXPatchr and its maintainers and owners do not condone, encourage, or approve of piracy of video games or "cracked" games. NXPatchr will only work with legally dumped games.

### For Windows Users

For users on Windows, head to the [Releases page](../../releases) and download the latest released version for your system. The file name should look like `NXPatchr-X.X.X-Windows.zip`

Once downloaded, you can extract it (right click the folder, click "extract" or "extract to") and run it!

### Linux and MacOS Users

> [!NOTE]
> I plan on making this cross-platform, I primarily work on Windows and will be targeting this first, apologies!

HiResRecorder-for-unity
=======================

HiResRecorder is a unity3D plugin for capturing high resolution in-game video.
Its mechanism is quite simple - capture each frame as image sequences at a desired frame rate, if necessary, it'll slow down the game in order to maintain the desired framerate.

### Scenario
HiResRecorder is useful when:<br />
1. You want super high resolution at which your game is origirnal running.<br />
2. You want to showcase your game via online video service, like YouTube or Vimeo.<br />
3. You want to demonstrate your cutscene or animation.<br />

### Tips

Usually this plugin will try to slow down your game to get a smooth image squence. Consequently, the actual game play will be jeopardized, if you rely much on timing. Therefore it's not recommended to use this tool at the above situation. And also, this tool simply creat image sequence, instead of a exported video. Therefore you need to import the generated image sequence into a video editing software, like AfterEffects, to render your own video. The reason for doing so is for making it flexible to configure its video settings. Things like codec, ect., is best done in a professional video programme other than in a unity plugin.

### Usage:
1. Drag the HiResRecorder prefab into the hierarchy of the master scene. The prefab will be persistent through scenes.<br />
2. click on the HiResRecorder prefab, and set the toggle key to record, and the desired framerate for you video. Default are key "C" and fps at 30.<br />
3. When in game, toggle the key to recording image sequences. Image sequences are created under the Application.datapath, where a folder named HiResRecorder should contain every sequences. Each time you enable recording, it will generate a sub folder inside this HiResRecorder folder.<br />
4. Note that it's better to build the unity project, then record img sequences in a built application. Recording in editor though works but quite laggy.<br />

A showcase work where I used to export FYSH's in game video at 720P.<br />
https://vimeo.com/69785071 <br />

Any feedback is greatly welcome.<br />
Feel free to drop an email at paraself[at]gmail.com.


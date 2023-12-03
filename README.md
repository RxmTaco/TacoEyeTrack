# TacoEyeTrack

VR eye tracking application for VRChat using OSC inspired by [RedHawk989](https://github.com/RedHawk989/EyeTrackVR)

![eyetrack](https://user-images.githubusercontent.com/117571946/204283521-a67e8b5c-3bf1-4fd2-b751-bb9a62c91ae8.gif)

![lid_test](https://user-images.githubusercontent.com/117571946/210032743-9c747257-0bb5-4b33-85b4-12d4a98af4f7.gif)


# Install
Download [latest version](https://github.com/RxmTaco/TacoTrack/releases), extract, launch "TacoEyeTrack.exe"

# Settings
- Link cameras to left and right eyes (Link example: `http://192.168.1.101`) and save.
- Go to "Cropping" tab and click and drag an area to be tracked.
- Go to "Tracking" tab to start tracking.
- In the "Tracking" tab, adjust the vertical Rotation sliders until the eyes are parallel, adjust Threshold slider so that the iris is visible and adjust the blob sliders to filter out potential unwanted blobs. Click on "Center" button to center the eyes.

Optional settings:
- Option to enable hull tracking which will detect the circumference of the iris, if disabled the program will average all detected values
(keeping disabled may be better if there is a lot of noise in the camera feed, enabled will be more accurate)
- Smoothing iterations, higher means more smoothing but more delay, 0 = off
- Eyelid detection (in development)

Parameters sent over OSC:
- LeftEyeX      (float)
- LeftEyeY      (float)
- RightEyeX     (float)
- RightEyeY     (float)
- LeftEyeLid    (int / bool)
- RightEyeLid   (int / bool)

(All OSC parameters can be changed from within the app as needed)

Default address for avatar parameters is /avatar/parameters/"**parameter_name**"

Float values range from -1 to 1 (this will be adjustable in a future update)

Blink values can be either sent as an integer (1 or 0) or boolean (true or false) depending how your avatar is set up.

***Still a work-in-progress***

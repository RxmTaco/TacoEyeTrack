# TacoEyeTrack

VR eye tracking application for VRChat using OSC inspired by [RedHawk989](https://github.com/RedHawk989/EyeTrackVR)

![eyetrack](https://user-images.githubusercontent.com/117571946/204283521-a67e8b5c-3bf1-4fd2-b751-bb9a62c91ae8.gif)


# Install
Download [latest version](https://github.com/RxmTaco/TacoTrack/releases), extract, launch "TacoEyeTrack.exe"

# Settings
- Link cameras to left and right eyes (Link example: `http://192.168.1.101`) and save.
- Go to "Cropping" tab and click and drag an area to be tracked.
- Go to "Tracking" tab to start tracking.
- In the "Tracking" tab, adjust the vertical Rotation sliders until the eyes are parallel, adjust Threshold slider so that the iris is visible and adjust the blob sliders to filter out potential unwanted blobs. Click on "Center" button to center the eyes.

Parameters sent over OSC:
- LeftEyeX      (float)
- LeftEyeY      (float)
- RightEyeX     (float)
- RightEyeY     (float)
- LeftEyeLid    (int / bool)
- RightEyeLid   (int / bool)

(All OSC parameters can be changed from within the app as needed)

*Still a work-in-progress, new features constantly rolling out.*

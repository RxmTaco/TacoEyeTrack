# TacoTrack

Eye tracking application for VRChat using OSC inspired by [RedHawk989](https://github.com/RedHawk989/EyeTrackVR)

![Screenshot 2022-11-26 174435](https://user-images.githubusercontent.com/117571946/204097154-2f51e4bb-f6f0-47ef-ad1a-6a8bdc99b1d5.jpg)

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
- LeftEyeLid    (int)
- RightEyeLid   (int)

For float values range is -1.0 to 1.0, for int values 1 when blink detected and 0 when eye is open. As of now blinking is only detected as either open or closed.

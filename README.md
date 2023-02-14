# DecoAR

DecoAR is an App for exdended the decoration at home, office or any place. It is aimed to track different images from home and provide overlayed content on top of that, when we see them thru the smart glasses.  

Aim of this project is to easily configure the images from the environemnt you want to extend, and see in the smart glasses like ThinkReality A3 or similar. It usage Qualcomm Snapdragon SDK's image tracking feature.   

Here are steps user need to do. 

- Import this project in Unity and import Spaces SDK  
- Take some pictures from the environent your want to extend. 
- Define actions for those pictures, following actions are available
  -  3D model - a 3D model will pop out of the image. 
  -  Video - a video will play on top of the tracked image
  -  Animation - a gif animation will play on top of the tracked image
  -  Audio - an audio will play on top of the tracked image
  -  Text - a formatted text will be shown on the tracked image.
- Once data is setup, build the project and run in the smart glass. 

## Project Setup

### Download the Snapdragon Spaces SDK

- Open https://spaces.qualcomm.com/download-sdk/
- Login to your account or create a account if you don't have.
- Click on "Download SDK" button for unity
- Unzip the Downloaded file

### Setting up the project

- Clone the repo
- Open it with Unity editor
- Open Package Manager from ```Window > Package Manager```
- Click on the plus icon and choose "import from tarball option"
- Navigate the file that we unzipped and choose the ```SnapdragonSpaces_Package_0_9_0.tgz``` from the folder to import it
- After importing click on the Snapdragon Spaces in Package Manager
- There you will find samples. Click on Samples and import them. It will be added to the Assets folder.

## Setup Data

- Get the images that you want to track.
- Drag and drop the images in the Unity project under Assets/Texture folder. Create the folder if it is missing.
- lets change the images settings to make it a Spite.
  - Choose texture type "Sprite (2D and UI)"
  - Choose Sprite mode "Single"
  - Check the checkbox for "Alpha is transparency" and "Read/Write" both
  - Choose the Wrap mode as "Clamp"
  - Click on Apply to apply all the changes we made.
  - Apply same settings for all the images you want to track.

## Build and Run
TODO

## Demo 

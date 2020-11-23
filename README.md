# Intralism Tool Collection
Collection of tools for Intralism.

# Features
- [Intralism Score Checker](#intralism-score-checker)
- [Map Converters](#map-converting)
  - [Intralism -> Mania]()
  - [Mania -> Intralism]()
- [Intralism Speed Changer](#intralism-speed-changer)
- [Any music file to .ogg Converter](#.ogg-converter)

# Installation
Go to [Releases](https://github.com/Ludeo/intralism-tool-collection/releases/latest) and downloaded the latest version. You can decide between the two .rar files c# needed and no c# needed. If you have .net 5.0 installed you can just downloaded the c# needed .rar file. If you don't have .net 5.0 you can either download the no c# needed .rar file or you can download .net 5.0 from [here](https://dotnet.microsoft.com/download/dotnet/5.0).

# Usage
First of all, you should go into the settings and set the mania song folder path and the intralism editor folder path to make the map conversion easier.

## Intralism Score Checker
With the Score Checker you can get information about intralism players like an overview of their ranked scores and basic informations like total points or accuracy.

You will have different options to check a player:

### Check with the profile link
Enter the profile link of the player into the textbox and click the check button 
(profile link format: https://intralism.khb-soft.ru/?player=PlayerID)

### Search for a player
Enter the name of the player into the textbox and click the check button (Note: It will take the first result) 

### Check with the global rank
Enter the global rank of the player into the textbox and select the checkbox titled "Check By Rank". Then click the check button

## Map Converting
You can decide between converting from intralism to mania or converting from mania to intralism.

### Intralism -> Mania
Select the config.txt file of the intralism map you want to convert (Note: Encrypted maps won't work). Then select the osu songs folder and click the convert button. The converted map will be inside a new folder in the osu song directory called "intralismconverts"

### Mania -> Intralism
Select the .osu file of the difficulty you want to convert (Note: only 4 keys is supported). Then select the editor folder from intralism and click the convert button. The converted map will be inside a new folder called by the artist and the title of the map.

## Intralism Speed Changer
The speed changer has two different modes, change every speed to one speed or change each speed by a specific value.

### Changing every speed to one speed
Select the config.txt file of the map where you want to change the speed (Note: Encrypted maps won't work) and make sure the checkbox ***is not checked***. Then enter the speed inside the textbox and click the change speed button (Note: This will change **every** speed event to the given speed value)

### Changing each speed by a specific amount
Select the config.txt file of the map where you want to change speeds (Note: Encrypted maps won't work) and make sure the checkbox ***is checked***. Then enter the value by how much the speed should change (for example: "1" would set every speed 1 higher, so 25 will be 26 and 20 will be 21 | "-1" would set every speed 1 lower, so 25 will be 24 and 20 will be 19) and click the change speed button.

## .ogg Converter
Select the music file you want to convert and select the output path, where the converted music file should be located at (Note: The name of the music file will be music.ogg). Then click the convert button.

# Bug reporting
If you find any bugs, please go to the [issues](https://github.com/Ludeo/intralism-tool-collection/issues) page and create a new issue there. We will try to answer as fast as possible.

# Help/Questions
If you need help or if you have any questions, feel free to write me on Discord Ludeo#8554 or ping me on the [official intralism discord server](https://discord.gg/intralism)

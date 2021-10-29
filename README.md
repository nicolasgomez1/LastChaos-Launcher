# LastChaos Launcher <img align="left" src="https://user-images.githubusercontent.com/5092697/138568453-9cbbedb8-7889-4a9d-ac72-5d2dae9bae9f.png" width="100px">

LastChaos launcher programmed in Lua.<br/>
Developed with <a href="https://www.indigorose.com/autoplay-media-studio/">Autoplay Media Studio 8.5.3.0</a>

# Information
* Define ```-dev``` as launch parameter to be able to use the developer window.
* Define ```-resetsettings``` as launch parameter to reset the configuration.
* Structure of the Folders/Files on the Server should be like this
  * lc_updater (The name of this folder must be in the url of the launcher)
    * style1.html
    * style2.html
    * style3.html
    * stylecustom.html
    * __patches(This folder must be called 'patches' compulsorily!)__
      * version.txt
      * 1.zip
      * 2.zip ETC
---
* Style 1 and 2 Web page sizes 297x339.
* Style 3 Web page size 725x425.
* Custom Style Web page size 647x398.
---
* __lccnct.dta__ Structure: ```Value1,Value2,Value3,Value4,Value5```
  * Value 1: Launcher URL. Example: http://127.0.0.1/lc_updater/
  * Value 2: Nksp launch parameter. (EP1: 6574 / EP2: 4022 / EP3: fkzktlfgod!)
  * Value 3: Enable/Disable multi Client. (true/false)
  * Value 4: Server name. Example: MyServerGonnaBeHackedByReza
  * Value 5: Launcher Style. (Style1 / Style2 / Style3)

# Features
* 4 Skins and 1 Custom page for dev purposes.
* Ability to allow or not multi-clients.
* ip.txt File is not required anymore.
* After downloading all the updates it will check the existence of LC.exe.new and LC.cdd.new if these 2 files exist, a batch file will be created that replaces the old files with the new ones.

# Notes

The '__StyleCustom__' is for testing/development purposes, but in case you want to use it, you have to know that the html related to it must be called '__stylecustom.html__' and its measurements are 647x398.

# Pics
![DevScreen](https://user-images.githubusercontent.com/5092697/139489251-488bb2c8-21be-4112-b217-8602386cfb46.jpg)
![Style1](https://user-images.githubusercontent.com/5092697/139489253-07000c9f-967f-4839-8c53-55890a560521.jpg)
![Style2](https://user-images.githubusercontent.com/5092697/139489254-8f72a21a-6648-4ae2-9b34-62c9c7ea5611.png)
![Style3](https://user-images.githubusercontent.com/5092697/139489259-50cf3e21-dcda-42af-9af7-23341e1e9a76.jpg)
![StyleCustom](https://user-images.githubusercontent.com/5092697/139489261-9d43bb46-4064-4fbb-82ef-3724be8de00b.png)

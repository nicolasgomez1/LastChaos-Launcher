# LastChaos Launcher <img align="left" src="https://user-images.githubusercontent.com/5092697/138568453-9cbbedb8-7889-4a9d-ac72-5d2dae9bae9f.png" width="100px">

LastChaos launcher programmed in Lua.<br/>
Developed with <a href="https://www.indigorose.com/autoplay-media-studio/">Autoplay Media Studio 8.5.3.0</a>

# Information
* Define ```-dev``` as launch parameter to be able to use the developer window.
* Define ```-resetsettings``` as launch parameter to reset the configuration.
* Structure of the Folders/Files on the Server should be like this
  * lc_updater (The name of this folder must be in the url of the launcher)
    * Style1.html
    * Style2.html
    * Style3.html
    * patches(The folder must be called 'patches' compulsorily)
      * version.txt
      * 1.zip
      * 2.zip ETC
---
* Style 1 and 2 web page sizes 297x339.
* Style 3 web page size 725x425.
---
* __lccnct.dta__ Structure: ```Value1,Value2,Value3,Value4,Value5```
  * Value 1: Launcher URL. Example: http://127.0.0.1/lc_updater/
  * Value 2: Nksp launch parameter. (EP1: 6574 / EP2: 4022 / EP3: fkzktlfgod!)
  * Value 3: Enable/Disable multi Client. (true/false)
  * Value 4: Server name. Example: MyServerGonnaBeHackedByReza
  * Value 5: Launcher Style. (Style1 / Style2 / Style3)

# Features
* 3 Skins and 1 Custom page for dev purposes.
* Ability to allow or not multi-clients.
* ip.txt File is not required anymore.
* After downloading all the updates it will check the existence of LC.exe.new and LC.cdd.new if these 2 files exist, a batch file will be created that replaces the old files with the new ones.

# Notes

The '__StyleCustom__' is for testing/development purposes, but in case you want to use it, you have to know that the html related to it must be called '__stylecustom.html__' and its measurements are 619x341.

# Pics
![DevScreen](https://user-images.githubusercontent.com/5092697/137717846-18aa6f83-fd6b-494e-9c79-98c1fdf39ef1.png)
![Style1](https://user-images.githubusercontent.com/5092697/137717859-16dd0a67-36f3-45c5-ba30-e774fcde3374.png)
![Style2](https://user-images.githubusercontent.com/5092697/137717862-100bef2e-8a4b-4382-8db5-f6f9c37860df.png)
![Style3](https://user-images.githubusercontent.com/5092697/138597158-10ce356c-d4cf-4802-ae06-17f3c62be6f8.jpg)


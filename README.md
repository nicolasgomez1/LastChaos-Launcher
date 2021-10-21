# LastChaos Launcher <img align="left" src="https://user-images.githubusercontent.com/5092697/137706275-5a285a31-a814-4e40-bb2a-b75601ec6fed.png" width="100px">

LastChaos launcher programmed in Lua.<br/>
Design with <a href="https://www.indigorose.com/autoplay-media-studio/">Autoplay Media Studio 8.5.3.0</a>

# Information
* Define ```-dev``` as launch parameter to be able to use the developer window.
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

# Pics
![DevScreen](https://user-images.githubusercontent.com/5092697/137717846-18aa6f83-fd6b-494e-9c79-98c1fdf39ef1.png)
![Style1](https://user-images.githubusercontent.com/5092697/137717859-16dd0a67-36f3-45c5-ba30-e774fcde3374.png)
![Style2](https://user-images.githubusercontent.com/5092697/137717862-100bef2e-8a4b-4382-8db5-f6f9c37860df.png)
![Style3](https://user-images.githubusercontent.com/5092697/137717870-dfa81aa5-65c0-4b61-8366-391df42d4d40.png)

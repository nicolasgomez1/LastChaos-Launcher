# LastChaos Launcher <img align="left" src="https://user-images.githubusercontent.com/5092697/137706275-5a285a31-a814-4e40-bb2a-b75601ec6fed.png" width="100px">

LastChaos launcher programmed in Lua.<br/>

# Information
* Define ```-dev``` as launch parameter to be able to use the developer window.
* Structure of the Folders/Files on the Server should be like this
```
youupdatefolder
  Style1.html
  Style2.html
  Style3.html
  patches(The folder must be called patches compulsorily)
    version.txt
    1.zip
    2.zip ETC
```
* Style 1 and 2 web page sizes 297x339.
* Style 3 web page size 725x425.
* lccnct.dta Structure
*     Value 1: launcher url. Example: http://127.0.0.1/lc_updater/
*     Value 2: Nksp launch argument. (EP1: 6574 / EP2: 4022 / EP3: fkzktlfgod!)
*     Value 3: Enable/Disable multi Client. (true/false)
*     Value 4: Server name. Example: I'm Idiot 123
*     Value 5: Launcher Style. (Style1 / Style2 / Style3)

# Features
* 3 Skins and 1 Custom page por Devs.
* Ability to allow or not multi-clients.
* ip.txt File is not required.
* After downloading all the updates it will check the existence of LC.exe.new and LC.cdd.new if these 2 files exist, a batch file will be created that replaces the old files with the new ones.

# Pics

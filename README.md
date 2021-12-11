# LastChaos Launcher <img align="left" src="https://user-images.githubusercontent.com/5092697/138568453-9cbbedb8-7889-4a9d-ac72-5d2dae9bae9f.png" width="100px">

Custom LastChaos launcher programmed in Lua.<br/>
Developed with <a href="https://www.indigorose.com/autoplay-media-studio/">Autoplay Media Studio 8.5.3.0</a>

# Usage guide
* __To create the file checklist.txt__ you must run the launcher in developer mode. Then you must press the Create Verification File List button, Select the game client folder, and start the process, then simply pose the file checklist.txt resulting in your server folder.(Example: www\lc_updater\client) (the folder must be called client and must be in the same folder where your patch folder is located)
# Features
1) 4 Skins. (3 Originals & Custom one)
2) Allow or Not Multi Client.
3) Pause & Resume Update Downloads.
4) Repair Game Files Function.
5) Window dedicated for Developers.
6) <a href="https://github.com/weolar/miniblink49/releases">MiniBlink(WKE)</a> for Web browser.
7) Little Settings Menu with 2 Functions: Run game after applying updates & start Launcher at Windows startup.
8) Dedicated 'button' to install dependencies (VCRedist C++ 2010 & DirectX 9.0c).
9) Command system using the url.

# Available Launch Commands/Arguments
* ```-dev``` (Desc: Open Launcher on Developer mode)
* ```-resetsettings``` (Desc: Reset "Run On Startup" and "StartGameAfterUpdate")
* ```-installdependencies``` (Desc: Force installation of "VCRedist C++ 2010" and "DirectX 9.0c")
* ```-createlist="<path>"``` (Desc: Create File Check List Without Window) (Example:`-createlist="C:\MyClientFolder"`)

# Available Web Commands.
* `#discord_join=` (Desc: Open a invite for Discord) (Example:`<a href="#discord_join=EnVFnY7PVb">Join Discord</a>`)
* `#open=` (Desc: Open url on default web browser) (Example:`<a href="#open=www.html5test.com">My Link</a>`)

# Folder Structure on Server
	Host
	└──Updater Folder (Example: lc_updater)
	   ├───patches Folder (It is mandatory that the folder should be called patcher)
	   │   ├───version.txt File
	   │   └───Patches files here
	   ├───client Folder (It is mandatory that the folder should be called client)
	   │   ├───checklist.txt File
	   │   └───Entire Client here
	   ├───style1.html
	   ├───style2.html
	   ├───style3.html
	   └───style4.html

# Information / Notes
1) Style 1, 2 & 3 Web Browser Size: 297 Width 339 Height.
2) Style 3 Web Browser Size: 725 Width 425 Height.
3) Style 4 Web Browser Size: 647 Width 398 Height.
4) Nksp Launch Parameter: EP1: 6574 / EP2: 4022 / EP3 & Up: fkzktlfgod!
5) To update the Launcher, it is as simple as taking the new EXE and CDD and renaming them as LC.exe.new and LC.cdd.new and adding them to the updates, after downloading the updates, the existence of these files will be checked in the folder of the game client, if it exists, a .bat process will be created and the old files will be replaced by the new ones.
6) Unfortunately I am using a function that is included with the IDE itself to obtain the Checksum (CRC32) so I don't have much control, I don't know which tables are used. What I can comment on is that it does not seem to fail. It is capable of distinguishing bytes in lowercase or uppercase. In case the file is empty, it returns 0 as checksum.
7) The Save button of Game Version and that of the Launcher Settings section serve to refresh the list of patches.
8) Game files verification Process takes 52 seconds (47781 Files) (Sys: FX 6300, HDD 7200rpm, Windows 10).
9) the content of the file __lccnct.dta__ differs slightly from the content of the previous versions, so this launcher is not compatible with the file of the old version (Now called __legacy__).
10) Remember to remove the Files you don't want to check from the file list. (checklist.txt)
11) This version does not show the weight of each pending update individually, it actually shows the total weight of all the remaining updates.

# Pics
<p align="center">
 DevScreen
 <br/><img src="https://user-images.githubusercontent.com/5092697/142677740-f0e575f6-21ea-4911-bf6b-5f494cd4f4ae.jpg"><br/>
 Style1
 <br/><img src="https://user-images.githubusercontent.com/5092697/145689170-6eceb392-80ce-4b51-97dd-58c8c78b6a37.jpg"><br/>
 Style2
 <br/><img src="https://user-images.githubusercontent.com/5092697/145689267-cc893c32-f9cc-4906-8240-0ef11aae212d.png"><br/>
 Style3
 <br/><img src="https://user-images.githubusercontent.com/5092697/142678571-a169887b-0d9a-4acf-8dd8-5136a085a983.jpg"><br/>
 StyleCustom
 <br/><img src="https://user-images.githubusercontent.com/5092697/139492719-44fda316-4a81-4c5a-b983-1b8e964a8c28.png"><br/>
</p>

### Finally thanks to [Joker](https://lckb.dev/forum/index.php?/profile/21747-joker/), [Desarija](https://lckb.dev/forum/index.php?/profile/18894-desarija/), [dethunter12](https://lckb.dev/forum/index.php?/profile/2167-dethunter12/)  & [Scura](https://lckb.dev/forum/index.php?/profile/21802-scura/) For helping to Fix / Improve and Complete this application^^.

### Special thanks to [Pabloko ](https://amsspecialist.com/memberlist.php?mode=viewprofile&u=54)for the MiniBlink fork.

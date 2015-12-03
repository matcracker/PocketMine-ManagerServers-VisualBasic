#PocketMine-ManagerServers

[![Join the chat at https://gitter.im/matcracker/PocketMine-ManagerServers](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/matcracker/PocketMine-ManagerServers?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
PocketMine-ManagerServers is a useful software that allow you to install and manage servers for PocketMine-MP! You can install servers MC:PE from 0.10.x to 0.13.x, you can open directly from the software, you can change the performance and properties for each server, you can choose how many times you want to restart the server; in conclusion you can do everything for administrate a server!

##Minimum System Requirements
- Operative System (OS): Windows XP/7/8/8.1/10 32-64 bit
- CPU Frequency: 1 GHz
- Hard Disk space (HDD): 50 MByte  
- RAM: 500 MB
- Require administrator privileges.

## How to install PocketMine-ManagerServers
There are 2 type of versions for PocketMine-ManagerServers:
- **Stable versions**: It's a build with minor bugs and with setup file.
- **Beta versions (Builds)**: It's the last build with new fuctions added in future version.

### Stable version
If you [download](https://github.com/matcracker/PocketMine-ManagerServers/releases) a stable version from v1.1 to v1.2 when you run the setup and finished the installation, you must go to the directory folder (**C:\Program Files\PocketMine-ManagerServers**) and move the DLL file (**Ionic.Zip.dll**) from the folder "Libraries" into the main folder. When you do this, you can run the software. Instead if you install the v1.3 you can do without moving the DLL's file.
### Beta versions (Builds)
If you [download](https://github.com/matcracker/PocketMine-ManagerServers/releases) a beta version, first install the last stable version, then replace the new build **PocketMine-ManagerServers.exe** with the current executable. Eventually for a correct working, delete the **Languages** folder and run the software.

## How it works PocketMine-ManagerServers?
It's use is very simple! It will begin with a call screen in the main menu which lists the functions of the program.

The current functions of the program are:
- Installation PocketMine-MP
- Management servers
- Program options

![pm_ms_menu](https://cloud.githubusercontent.com/assets/10587406/11320549/71d986f6-909c-11e5-9c94-c7c58cc21e11.PNG)

###Installation PocketMine-MP
The function itself says it does, install the system creating servers for Minecraft PE (Pocket Edition)
After selecting the item appear other two items: a download and installation.
First you will need to download the beating heart of PocketMine, then select the version you want to download, and the download will start automatically! Once you download the indicated link to the folder where you saved it and go to the installation phase! It too will have procedures similar but different tasks. The difference lies in having to specify the connection folder in which you want to install the server, that's all!

###Management servers
This function provides for the management of one or more servers (maximum 10). It includes other three functions: one to open the servers, second the other to change the performance, third for do backup or restore for yuor server and last for restart in a periodic time your servers.

![pm_ms_manager](https://cloud.githubusercontent.com/assets/10587406/11320552/89d61d82-909c-11e5-8ea5-d1a879c711b9.PNG)

######Opener
The first function is simple to use, though in the past they had already indicated the connections will not be referred to a second time while on the contrary, if they had not shown connections now you will have to do and then go on.

######Editor
The second function is also divided into two functions: one that changes the properties of the servers (server.properties) and one which changes the performance (High, medium, low).

The first is simple to use, you just need to specify the properties to be attributed to the servers and create the file and place it will show where

The second asks you to choose which you want to assign to the performance servers, always pointing to the links folder (as 
noted previously)

######Backup & Restore
This function implemented with version 1.1 allows you to create backup files whenever you like , for your server and wanting can also restore them !

######Server Restarter
You can choose an interval of time to decide when to restart the server and you can kill the BackgroudTask if is turned on.

###Options
This fuction allows you to change the language of the program.

###Dev Menu
You can enable the menu for developer writing three times "devon" in the main menu, to disable write 3 times "devoff". The devmenu contains some fuctions:
- Memory usage
- Force opening BackgroundTask
- Commands mode
- Restarting software
- Resetting program data (in option menu)

![pm_ms_menudev](https://cloud.githubusercontent.com/assets/10587406/11320550/7d18b7a8-909c-11e5-8c23-bc6d2629cc1e.PNG)

####Memory usage
This fuction allow you to control memory usage that the program uses.

####Force opening BackgroundTask
This fuction allow you to restart the server without the "BackgroundTask" disappear and open it if the "task" is turn off

####Commands mode
This fuction allow you to use program fuctions with the commands, like a real console! Digit **/help** or only **help** for show the all avaible commands.

![pm_ms_commander](https://cloud.githubusercontent.com/assets/10587406/11320551/83607006-909c-11e5-9681-d283204d97d7.PNG)

####Restarting software
This fuction allow you simplify restart the software.

####Resetting program data
When you enable the devmode in the option menu you can see a new option **"Reset program"** that you can reset some data.

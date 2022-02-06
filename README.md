# CSGO-RPC
- Show to discord what you are doing in CS:GO

# Requirement
- This app required [.NET 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48) to be installed on your computer to be able to run
- 
# Usage
- Run the application (MainProgram.exe)
- Leave the application running or minimize it down for the presence to work

# Installation
- For the app to work with csgo, the gamestate config file must first be copy to CSGO's cfg folder before running CS:GO, you can do it's in 2 way
  ### Automatic 
  1. Open the application
  2. Press Install
  ### Manual
  1. Locate your csgo cfg folder
  2. Copy gamestate config file included with releases or under here and copy it to the cfg folder

  [gamestate_integration_jrpc.cfg](https://github.com/Johnnymc2001/CSGO-RPC/blob/master/gamestate_integration_jrpc.cfg)
       
       "CSGSI" 
        { 
        "uri" "http://localhost:4123" 
        "timeout" "5.0" 
        "data" 
            { 
                "provider" "1" 
                "map" "1" 
                "round" "1" 
                "player_id" "1" 
                "player_weapons" "1" 
                "player_match_stats" "1" 
                "player_state" "1" 
            } 
        }

# Placeholders
- Match :
	- {TScore}/{CTScore}  - Team's Score 
	- {TName}/{CTName} - Team's Name

	- {Phase} - Game Phase
	- {Round} - Current Round
	- {Mode} - Current Mode
	- {Map} - Current Map

	- {Kill}/{Death}/{Assist}/{Score}/{MVP} - Player's KDA

- Player:
	- {FriendCode} - Your CSGO FriendCode
	- {Name} - Player's Name
	- {ID} - Player's ID
	- {Team} - Player's Team
	- {Version} - Game's Version
	- {ProgramVersion} - Program's Version

// Idle Setting Only Have {FriendCode, Username and ID}


# Implementation

![Lobby](https://i.imgur.com/1xgCMOD.png)
![Ingame](https://i.imgur.com/D2DyXHc.png)

![First Tab](https://i.imgur.com/L4Sfolf.png)

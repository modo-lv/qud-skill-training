cd %~dp0
taskkill /f /im CoQ.exe
robocopy . "c:\users\martin\AppData\LocalLow\Freehold Games\CavesOfQud\Mods\LootYeet" *.cs *.xml /s /purge /xd bin
start "" "c:\games\steam\steamapps\common\Caves of Qud\CoQ.exe"
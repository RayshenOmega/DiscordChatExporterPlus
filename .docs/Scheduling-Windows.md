# Scheduling exports on Windows

We'll be using [DiscordChatExporter CLI](https://github.com/nulldg/DiscordChatExporterPlus/releases/latest), PowerShell, and Task Scheduler.

1. Open a text editor such as Notepad and paste:

```powershell
# Info: https://github.com/nulldg/DiscordChatExporterPlus/blob/master/.docs

$TOKEN = "tokenhere"
$CHANNEL = "channelhere"
$EXEPATH = "exefolderhere"
$FILENAME = "filenamehere"
$EXPORTDIRECTORY = "dirhere"
$EXPORTFORMAT = "formathere"
# Available export formats: PlainText, HtmlDark, HtmlLight, Json, Csv

cd $EXEPATH

.\DiscordChatExporter.Cli.exe export -t $TOKEN -c $CHANNEL -f $EXPORTFORMAT -o "$FILENAME.tmp"

$Date = Get-Date -Format "yyyy-MM-dd-HH-mm"

If($EXPORTFORMAT -match "PlainText"){mv "$FILENAME.tmp" -Destination "$EXPORTDIRECTORY\$FILENAME-$Date.txt"}
ElseIf($EXPORTFORMAT -match "HtmlDark"){mv "$FILENAME.tmp" -Destination "$EXPORTDIRECTORY\$FILENAME-$Date.html"}
ElseIf($EXPORTFORMAT -match "HtmlLight"){mv "$FILENAME.tmp" -Destination "$EXPORTDIRECTORY\$FILENAME-$Date.html"}
ElseIf($EXPORTFORMAT -match "Json"){mv "$FILENAME.tmp" -Destination "$EXPORTDIRECTORY\$FILENAME-$Date.json"}
ElseIf($EXPORTFORMAT -match "Csv"){mv "$FILENAME.tmp" -Destination "$EXPORTDIRECTORY\$FILENAME-$Date.csv"}
exit
```

2. Replace:

- `tokenhere` with your [Token](https://github.com/nulldg/DiscordChatExporterPlus/blob/master/.docs/Token-and-IDs.md)
- `channelhere` with a [Channel ID](https://github.com/nulldg/DiscordChatExporterPlus/blob/master/.docs/Token-and-IDs.md)
- `exefolderhere` with the .exe **directory's path** (e.g. C:\Users\User\Desktop\DiscordChatExporter)
- `filenamehere` with a filename without spaces
- `dirhere` with the export directory (e.g. C:\Users\User\Documents\Exports)
- `formathere` with one of the available export formats

Make sure not to delete the quotes (")

3. Save the file as `filename.ps1` not `.txt`

## Export at Startup

1. Press Windows + R, type `shell:startup` and press ENTER
2. Paste `filename.ps1` or a shortcut into this folder

## Scheduling with Task Scheduler

Please notice your computer must be turned on so the exportation can occur.

1. Press Windows + R, type `taskschd.msc` and press ENTER
2. Select `Task Scheduler Library`, create a Basic Task, and follow the instructions on-screen

<img src="https://i.imgur.com/MHRVGDi.png" height="500"/>

[ ![](https://i.imgur.com/m2DKhA8.png) ](https://i.imgur.com/3gHkF0t.png)

3. At 'Start a Program', write `powershell -file -ExecutionPolicy ByPass -WindowStyle Hidden "C:\path\to\filename.ps1"` in the Program/script text box

![](https://i.imgur.com/FGtWRod.png)

4. Click 'Yes'

![](https://i.imgur.com/DuaRBt3.png)

5. Click 'Finish'

![](https://i.imgur.com/LHgXp9Q.png)

---

Special thanks to [@Yudi](https://github.com/Yudi)
# Connected Players

🔌 **Connected Players** is a plugin for [IW4MAdmin](https://github.com/RaidMax/IW4M-Admin) that adds a `{{CONNECTED}}` message token for use in automated messages. This plugin was originally created for **HGMServers**, but is open-source and available for anyone to use or modify. It allows you to display the current number of online players in your server's broadcast messages.

---

## ✨ Features

- Adds a `{{CONNECTED}}` **message token** for automated messages
- Displays the current number of **online players**
- Integrates with the IW4MAdmin **automated message system**
- Lightweight and easy to install

---

## 🧱 Requirements

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [IW4MAdmin](https://github.com/RaidMax/IW4M-Admin)
- [SharedLibraryCore NuGet package](https://www.nuget.org/packages/RaidMax.IW4MAdmin.SharedLibraryCore)

---

## 🛠️ Build Instructions

```bash
# Clone the repo
git clone https://github.com/NotHGM/ConnectedPlayersPlugin.git
cd ConnectedPlayersPlugin

# Restore dependencies & build
dotnet restore
dotnet build -c Release
```

After building, the compiled plugin will be located at:

```
bin/Release/net8.0/ConnectedPlayers.dll
```

Copy ``ConnectedPlayers.dll`` into your IW4MAdmin/Plugins/ directory and restart IW4MAdmin.

---

## ⚙️ How to Use

To use the plugin, simply add ``{{CONNECTED}}`` to any of your broadcast messages.

In your ``IW4MAdminSettings.json`` file, you would add it to the Messages array like this:

Example in ``IW4MAdminSettings.json``:

```json
"AutoMessages": [
  "There are currently {{CONNECTED}} players online on HGMServers!"
],
```

Example In-Game Output:
```
There are currently 6 players online on HGMServers!
```

## 🧪 Example Output on Startup

```
[ConnectedPlayers] by HGM loaded. Version: 2025-04-10
```

## 🙌 Credits

Special thanks to:

- [RaidMax](https://github.com/RaidMax) for creating IW4MAdmin 🛠️
- [Amos](https://github.com/ayymoss) for being amos 💡

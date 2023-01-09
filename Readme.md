# DiscordChatExporterPlus

> 🟢 **Project status**: active<sup>[[?]](.github/docs/project-status.md)</sup>

**DiscordChatExporterPlus** can be used to export message history from a [Discord](https://discord.com) channel to a file.
It works with direct messages, group messages, and server channels, and supports Discord's dialect of markdown as well as all other rich media features.

This application comes in two flavors: graphical user interface (**GUI**) and command line interface (**CLI**).
Supported operating systems are Windows 7 or higher, macOS 10.13 (High Sierra) or higher, and Linux.


> **Warning**:
> To run **DiscordChatExporter** on macOS and Linux, you need to make sure that **.NET 7.0 Runtime** is installed.
> You can download it here:
>
> - [.NET 7.0 Runtime for **macOS x64**](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-7.0.101-macos-x64-installer)
> - [.NET 7.0 Runtime for **macOS Arm64**](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-7.0.101-macos-arm64-installer)
> - [.NET 7.0 Runtime for **Linux**](https://docs.microsoft.com/en-us/dotnet/core/install/linux) (find the correct download for your distro)
>
> This should not be necessary if you install **DiscordChatExporter** using a package manager, as it should take care of the dependencies for you.
> This is also not necessary if you are running **DiscordChatExporter** via Docker, because the image already contains the runtime.

## Features

- Graphical user interface (Windows)
- Command line interface (Windows, Linux, macOS)
- Authentication via both user and bot tokens
- Multiple output formats: HTML (dark/light), TXT, CSV, JSON
- Support for markdown, attachments, embeds, emoji, and other rich media features
- File partitioning, date ranges, message filtering, and other export options
- Self-contained exports that don't require internet

## Screenshots

![channel list](.assets/list.png)
![rendered output](.assets/output.png)

## Related projects

- [**Chat Analytics**](https://github.com/mlomb/chat-analytics) — solution for analyzing chat patterns of Discord users, using exports produced by **DiscordChatExporter**.
- [**DiscordChatExporter-frontend**](https://github.com/slatinsky/DiscordChatExporter-frontend) — convenient viewer for exports produced by **DiscordChatExporter**.

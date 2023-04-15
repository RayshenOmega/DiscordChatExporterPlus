# DiscordChatExporterPlus

This is a fork of **DiscordChatExporter** with the political cancer, popups, "sanctions", discrimination against Russian people, etc removed.

This fork acts as a drop-in replacement for DiscordChatExporter, and is set to update from this fork instead of upstream. Upstream is treated with minimal trust, therefore commits from upstream and the dependencies owned by Tyrrrz are reviewed to avoid supply-chain attacks and insertion of political bloat.

----

**DiscordChatExporter** is an application that can be used to export message history from any [Discord](https://discord.com) channel to a file.
It works with direct messages, group messages, and server channels, and supports Discord's dialect of markdown as well as most other rich media features.

> ❔ If you have questions or issues, **please refer to the [docs](.docs)**.

This application comes in two flavors: graphical user interface (**GUI**) and command-line interface (**CLI**).
Supported operating systems are Windows 7 or higher, macOS 10.13 (High Sierra) or higher, and Linux.


## Installation

To install this fork, download the [latest release](https://github.com/nulldg/DiscordChatExporterPlus/releases/latest) and extract the zip into an empty directory.

If you already have a copy of DiscordChatExporter and wish to switch to this fork, you can simply overwrite the existing files. Your settings will be preserved.

> **Warning**:
> To run **DiscordChatExporterPlus** on macOS and Linux, you need to make sure that **.NET 7.0 Runtime** is installed.
> You can download it here:
>
> - [.NET 7.0 Runtime for **macOS x64**](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-7.0.101-macos-x64-installer)
> - [.NET 7.0 Runtime for **macOS Arm64**](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-7.0.101-macos-arm64-installer)
> - [.NET 7.0 Runtime for **Linux**](https://docs.microsoft.com/en-us/dotnet/core/install/linux) (find the correct download for your distro)

## Features

- Graphical user interface (Windows)
- Command-line interface (Windows, Linux, macOS)
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
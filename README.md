# 🎮 Discord Rich Presence Controller

This is a Discord Rich Presence Controller! A C# application designed to make your Discord presence totally custom for you show of whatever you like.

## 🚀 Project Overview

This app is a **Windows Forms** application built with **C#** and the **DiscordRPC** library, using **Guna** library for enhancing visulas.  It enables users to customize their Discord Rich Presence details, including:

- **Details & State:** Show off your current status or mood.
- **Images & Tooltips:** Set large and small images, complete with hover text.
- **Timestamps:** Display start times (or even end times, if you're feeling dramatic).
- **Interactive Buttons:** Add up to two buttons with custom text and URLs.

## 💻 How It Works

This app's magic happens through the *DiscordRpcController* class. It handles the initialization and updates of your rich presence. The GUI, built using Windows Forms, allows you to adjust presence settings with a few clicks.

Here’s how the main components fit together:

### 1. **DiscordRpcController.cs**
   - Manages the connection with Discord's API.
   - Updates presence based on user inputs.
   - Provides handy getters to retrieve current presence details.

### 2. **MainWindow.cs**
   - The main GUI window.
   - Lets users update presence details like state, images, buttons, and timestamps.

### 3. **Program.cs**
   - The entry point of the application.
   - Initializes the *DiscordRpcController* and starts the main application loop.

## 🛠️ Setting Up

Wanna run it yourself? No problem! Here's how to get started:

1. **Clone this repo:**  
   ```bash
   git clone https://github.com/yourusername/discord-rpc-controller.git
   ```
2. Open the project in visual studio and run it!

   Will make an executable release soon! stay tuned

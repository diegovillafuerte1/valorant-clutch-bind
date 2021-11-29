# Valorant Clutch Bind

You're in a clutch situation when all of a sudden your teammates decide to backseat game. [They start telling you how bad you are in one hundred imaginative ways.](https://youtu.be/KwTS0-Vtsrw?t=239)

This was simple to create with binds in CS:GO's console, and even then Valve devs decided to add it to the menus. Hopefully Riot will follow their example, until then, we present the [much](https://www.reddit.com/r/VALORANT/comments/paswv1/clutchfocusdeafen_keybind_for_valorant/) [requested](https://www.reddit.com/r/VALORANT/comments/hjm14u/valorant_needs_a_clutch_mute_toggle_key_bind/) **Valorant Clutch Bind**!

How to Use Your Project
Provide instructions and examples so users/contributors can use the project. This will make it easy for them in case they encounter a problem – they will always have a place of reference.

# FAQ
If you have any pertinent questions, feel free to contact me at <almond.granola@hugevalorantyoutuber.com>

## What does this do?
To put it simply, this application will listen for a keypress of your choice that will toggle your voice chat audio.

## How does this work?
There are two separate audio streams created by the Valorant application -- Valorant and RiotClientServices. The former is where the game sounds are sent and the latter is where the chat goes. All this code does is listen for a keypress and mute/unmute the RiotClientServices audio stream.

## Is this a keylogger?
Technically, we're reading every key while it's open, but it's completely open source and plain to see that there's no storage or networking of any kind that would be doing anything nefarious with your keypresses.

## Will this get me banned?
We're essentially just adjusting the Volume Mixer for you, so we don't think so!

How to Install Your Project
If your project is software or an app that needs installation, you should include the steps required to install your project. Provide a step-by-step description of how to get the development environment running.


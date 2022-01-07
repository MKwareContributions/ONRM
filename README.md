# ONRM
Oversimplified Number Randomizing Machine.

*Despite it's name, it's really simple*

[![Project Status: Active – The project has reached a stable, usable state and is being actively developed.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)

The name says it all - randomizer with configurable range.

It's my first project that was made with C# and Silverlight

---

ONRM requires Silverlight plugin in your browser in order to work.

Modern web browsers won't work with Silverlight. Install Silverlight plugin first and then use IE to open ONRM.

---

Public instance: https://mkware.eu.org/onrm/

### Getting source code

1. Download `source` directory
2. Open `ONRM.sln` in VS (2013 at least)

### Compiling

1. In "Solution Explorer" select `ONRMv2.Web`
2. Click "Build" in menu bar
3. Click "Publish ONRMv2.Web"
4. Create new publishing profile with the settings you need. I'd recommend to publish on local machine. To do this, click "Custom" > Name your profile whatever you want > "Publish method = File System" > In "Target location" select directory where you want to place compiled program (i.e. Desktop)
5. Click "Publish"
6. Done

There is also pre-compiled ONRM in `front-end` directory. To use it, open `ONRMv2.aspx` in IE.

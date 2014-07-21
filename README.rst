====================================
README for the Starter Pack Launcher
====================================

The Starter Pack Launcher is an open-source third party launcher for the game Dwarf Fortress.  It provides a GUI to easily change game settings, run other third party utilities, install graphics packs, and more.

-----------
Development
-----------
The Launcher was originally developed by Lucas Paquette/LucasUP in 2010, who later released it under the GPL3 in February 2013.  

Building the project from source requires Microsoft Visual Basic 2010 Express or higher (open "LazyNewbPackGUI.vbproj").  The folder ``./bin/debug/`` is used when you export/test the program, it includes the LNP folder structure - which is explained below.  The project has had a number of homes, but development is currently at https://github.com/PeridexisErrant/Starter-Pack-Launcher

*Dwarf Fortress* is not included, and nor are any other files and utilities; they can be added individually or you can download a pre-configured package such as the `Dwarf Fortress Starter Pack`_.  See also the `Bay12 Forums thread for development`_ of this launcher.

.. _`Dwarf Fortress Starter Pack`: http://www.bay12forums.com/smf/index.php?topic=126076
.. _`Bay12 Forums thread for development`: http://www.bay12forums.com/smf/index.php?topic=123384

Contributions are most welcome, in response to open issues or as unsolicited improvements.  Please submit pull requests to the development branch, or contact me if you want to contribute in some other way.  

Contributors:  
-------------

- Lucas Paquette/LucasUP (Original creator and coder, retired Feb 2013)
- TolyK/aTolyK (Graphical concept and early coding)
- Mason11987 (Provided source of DFConfig)
- xndrad (Provided source of DFInit)
- daveralph1234 (current lead coder)
- PeridexisErrant (documentation, maintains Starter Pack)
- Splinterz (DFHack tab and maintenance)

==================================

-------------------------
Starter Pack Launcher.exe
-------------------------
As used in the `Dwarf Fortress Starter Pack`_

The launcher has five main tabs, drop down menus at the top, and buttons to launch DF / edit init files / reset settings to defaults.  

The "Options" and "Settings" tabs are mostly a GUI for editing ``init.txt`` and ``d_init.txt``, plus a few minor extras such as changing keybindings and toggling the generation of aquifers in new worlds.  

The "Graphics" tab facilitates switching between graphics packs, drawing on the graphics folder.  The "Utilities" tab lets you launch programs from the utilities folder, and allows you to add programs to launch with the 'Play Dwarf Fortress!' button.  The DFHack tab allows you to select commands to run with dfhack when a world is loaded; the details are explained with "/LNP/LNPWin.txt" below.  

The "Folders" and "Links" menus are defined through LNPWin.txt, and provide a set of shortcuts and favourite links respectively.  

==================================

----------------
Folder Structure
----------------
Besides the GUI itself the launcher comes with a folder structure, each part of which has a purpose.  The folder structure is vital for the launcher to work, equally important to the launcher itself.  

At the top level, there is the GUI, the "Dwarf Fortress" folder, and the "LNP" folder.  An explanation of each component follows.  Some packs have an optional top-level folder to store user generated content, to make switching packs easier.  

Dwarf Fortress Folder
---------------------
Extract a copy of Dwarf Fortress, and place the folder next to ``"./Starter Pack Launcher.exe"``
The Dwarf Fortress folder can be named anything starting with ``"Dwarf Fortress"`` (ie ``"./Dwarf Fortress 9001/"`` would work).

This is compatible with mods, but be careful as mods may conflict with the way graphics packs are installed. 


Under ``./LNP/``
----------------

``./LNP/About/``
----------------
Contains documentation about the launcher and the package as a whole.  In the template, merely points to this readme at the top of the source folder.  

``./LNP/Defaults/``
-------------------
A copy of d_init.txt and init.txt can be placed here, and will be what your settings revert to when you click the "Defaults" button.

``./LNP/Extras/``
-----------------
Any files in "LNP\Extras" are copied into the Dwarf Fortress folder the first time "Lazy Newb Pack.exe" is run.
A text file is made named "LNPx.x.txt" in the DF directory, where "x.x" is the version of the GUI. If you delete this file, the Extras folder will be installed again the next time Lazy Newb Pack is run.

``./LNP/Keybinds/``
-------------------
Contains renamed and edited versions of DF's "data\init\interface.txt".  
The launcher can substitute the contents to provide control schemes which are better suited to a laptop (Classic LNP) or also to mouse control (PeridexisErrant).  The default keys are provided to switch back.  

``./LNP/Graphics/``
-------------------
Extract any graphics packs you want to be able to use into a subfolder of "LNP\Graphics"

LOOKS LIKE: 	``"Graphics\Mayday\[files]"``

NOT LIKE:   	``"Graphics\Mayday\Mayday\[files]"``

Once placed you can press the "Simplify Graphic Folders" button in the Lazy Newb Pack program to delete all the extra files the pack may contain - effectively extracting the graphics from a full install of Dwarf Fortress.

This is useful to save space or to re-pack to a friend.  If adding graphics packs, simplifying a pre-installed package in this way avoids the common problem of missing files in 'upgrade packs'.  

``./LNP/Useful/``
-----------------
A folder provided as a default place to put useful things, such as saved copies of tutorials or minor utilities.  Intended for creators of packages, as a (optional) top-level User Content folder is more appropriate for end-user usage.

``./LNP/Utilities/``
--------------------
Put ANY utilities you want to use through the launcher into the "LNP\Utilities" folder. It automatically recognizes and lists .exe, .bat, and .jar files.  

You can hide files from the utilities pane of the launcher by adding their filenames to "LNP\exclude.txt".  The configuration for Soundsense is provided as an example.  

``./LNP/LNPWin.txt``
---------------------
Defines the entries in the drop down menus 'links' and 'folders'.  Modifiable to add or remove entries; sensible defaults are provided.   

It also defines the entries in the DFHack tab, to allow flexibility in the compilation of a package.  These are then written to "LNP_dfhack_onLoad.init" when Dwarf Fortress is started or the launcher is closed.  The command in the provided dfhack.init will then execute the contents of that file when a world is loaded::

	:lua dfhack.onStateChange.onloadscript = function(state) if state == SC_WORLD_LOADED then print((dfhack.run_command('script LNP_dfhack_onLoad.init'))) end end

Advanced uses such as multiple commands in a single line or recurring commands are possible through the dfhack functions "multicmd" and "repeat" - documented in the dfhack readme - and are demonstrated in the example config.  

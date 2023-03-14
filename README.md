# RAD-Controller-VIbration
A small controller vibration plugin for Unity's old input system

---------------------------------------------------------------------------
Table of Contents:
	1) Copyright Info
	2) About this Project
	3) Tutorial
	4) Troubleshooting

---------------------------------------------------------------------------
Copyright Info:

	Portions Copyright © 2002-2008 Charlie Poole

	
---------------------------------------------------------------------------
About This Project:

	Thanks for downloading!!!

	Check the Troubleshooting section for Playstation Compatibilty

	The actual controller vibration code is from SharpDX and XInput.
	I simply packaged it into an asset and created some functions to make it easier to use.
	I made this asset because I hate the new Unity input system and I was never able to make standard XInput work
	well enough to use my projects. This solution may be a little janky, but it works well enough.
	If you have questions, suggestions, or you just want to make fun of my code, send me an email --> (fishybearstudiogames@gmail.com) or leave a review.
	Either way, thanks for checking out the Asset. <3
		 -Fishybear/Aaron


---------------------------------------------------------------------------
Tutorial:

	Supports up to 4 (four) controllers.

	The Demo files included show recommended uses for the controller vibration functions.
	That should be all you need to get it working.

	However,

	If you wish to bypass the functions I made, and use SharpDX directly, you'll want to view the "AdvancedExample" script located in your project at "Rad_Controller_Vibration\Demo\2D_Demo\AdvancedExample"


	Also: These are some good examples here as well --> https://csharp.hotexamples.com/examples/SharpDX.XInput/Vibration/-/php-vibration-class-examples.html (These are not built for Unity however)

	Also also: Here is a list of all the other functions included in XInput if you plan to use any of those --> http://sharpdx.org/wiki/class-library-api/xinput/

---------------------------------------------------------------------------
Troubleshooting:

	Disclaimer:
		In order for this asset to work with Playstation controllers, the user will need to download DS4Windows from here --> https://ds4-windows.com/
		This will remap the Playstation controller to XInput.
		I haven't been able to test this yet as I don't own a Playstation controller.
		Hopefully in the future I can get my hands on one and figure out how to implement vibration directly with the RawInput API.
		Anyone smarter than me with access to a controller is certainly welcome to build off of this project though
		


	If for some odd reason Unity tells you that it doesn't know what SharpDX.XInput is:
	1) Close Unity
	2) delete your project's library folder
	3) Reopen Unity, and it should have rebuilt your library folder with the dll's/Assembly files included


	As always feel free to reach out with any problems --> fishybearstudiogames@gmail.com






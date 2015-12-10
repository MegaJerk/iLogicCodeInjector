# iLogicCodeInjector - UPDATE! (12/10/2015)

I have taken some time to fix a few problems that existed in previous versions of the Code Injector. 
This should now create iLogic Event Triggers correctly across new and old Inventor documents. 

Because the Autodesk - Being Inventive blog no longer seems to be updated, this repository will serve 
as the (new?) home to this project. 

Though I do plan on completely remaking / re-imagining the Code Injector in the future, this will be the 
**last update** that this particular iteration receives. 

As always, I have included all of the code files / Visual Studios solution for everyone who wants to 
learn the deeper mysteries of how iLogic Event Triggers are being created, or who just wants to 
laugh at my terrible 'Fisher Price - My First Software' code.

## *If you're just interested in the updated executable (.exe) [go here](../master/Code%20Injector%20Project/Code%20Injector/obj/x86/Release/Code%20Injector.exe), and then click on the 'View Raw' link in the center of the page. It should start the download.*


## List of Changes 

**1.** Fixed an error that would occur when the iProperty Set that contains Event Trigger information was formatted differently
using the original (old) format, subsequently hiding itself from Inventor.

**2.** Fixed the anchors on the applications main dialog box to prevent buttons from drifting into the text editing area. 

**3.** Corrected the value for iProperties controlling the On Drawing View event triggers. 


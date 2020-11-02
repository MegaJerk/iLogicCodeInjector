# Clarification Update! (11/2/2020)
This project has long been mothballed by myself and serves only as a guide to anyone who is in search of some specific answers. That said, there are a few things that have changed in Inventor / Community knowledge that warrent me to update some of the information here.

My previous table of the iProperty names and ID ranges is now out of date. Thanks to the work of Autodesk Community member WCrihfield (who created a new list of Property Names and ID Ranges alongside many other fixes and informative posts regarding Event Triggers), I am updating this Readme with their new values, which are as follows:

|Name (Name Shown in Dialog)|Property Name (& DisplayName)|PropId Range|Doc Types Available In|
|--- |--- |--- |--- |
|After Open Document|AfterDocOpen|400 to 499|Assembly, Part, Drawing|
|Close Document|DocClose|500 to 599|Assembly, Part, Drawing|
|Before Save Document|BeforeDocSave|700 to 799|Assembly, Part, Drawing|
|After Save Document|AfterDocSave|800 to 899|Assembly, Part, Drawing|
|After Model Parameter Change|AfterAnyParamChange|1000 to 1099|Assembly, Part|
|Part Geometry Change|PartBodyChanged|1200 to 1299|Part|
|Material Change|AfterMaterialChange|1400 to 1499|Part|
|iProperty Change|AfterAnyiPropertyChange|1600 to 1699|Assembly, Part, Drawing|
|Drawing View Change|AfterDrawingViewsUpdate|1800 to 1899|Drawing|
|Feature Suppression Change|AfterFeatureSuppressionChange|2000 to 2099|Part|
|Component Suppression Change|AfterComponentSuppressionChange|2200 to 2299|Assembly|
|iPart or iAssembly Change Component|AfterComponentReplace|2400 to 2499|Assembly|
|New Document|AfterDocNew|2600 to 2699|Assembly, Part, Drawing|

**Please remember that**

1. None of the comments in the code contained within this progam has been updated to reflect this new table of information!
2. Older versions of Inventor may actually use the old table of ID ranges!

So. That's it! This is likely the last update unless Inventor updates something else and I have to make another update like this one!

Until next time!

(**PS**: Check out WCrihfield's awesome Autodesk Community Articles [here](https://knowledge.autodesk.com/profile/LTSUSR7HXMSAE/articles))


---

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

### Special Thanks 

Special thanks to Bob Van der Donck and the crew (defunct or not) over at beinginventive.typepad.com. He made some wonderful contributions to this project after its initial debut, and was the person responsible for sparking the initial idea in the first place. 

Props! 

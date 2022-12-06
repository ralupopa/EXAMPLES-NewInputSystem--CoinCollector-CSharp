# CoinCollector - CSharp tests

This project contains C# AltTester tests for a project using the New Input System.
The tested actions are: tap object, key down/ key up, press key, click object, scroll, begin/end touch and tap simulated with swipe.

## Before running the tests
To run the tests, you must include the AltTester Unity SDK in the project. To do that, you can choose between the following ways:
1. Add the AltTester Unity SDK submodule to the project
    - in the <i> New Input System proj/Assets </i> folder add the submodule using the <i><b> git submodule add https://github.com/alttester/AltTester-Unity-SDK.git </b></i> command;
    - make sure that the submodule added is on the master branch (you can use the following command <i><b> cd AltTester-Unity-SDK && git checkout master</b></i>).

    <br> 
2. Download AltTester Unity SDK and import it into Unity 
    - download the AltTester Unity SDK from the Altom website (https://altom.com/testing-tools/alttester/) or using this link https://altom.com/app/uploads/AltTester/sdks/AltTester.unitypackage;
    - open the project in Unity and from the menu, go to <i> Assets -> Import Packages -> Custom Package... </i> and select the AltTester Unity Package downloaded before;
    - a pop-up will appear, select All and click on Import.

## Run the tests

You can open the project in the Unity Editor and run the tests from the AltTester Editor window.

The tests can be found in Editor -> Tests folder in the AltTester_NIS_Tests class.
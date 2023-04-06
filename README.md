This project does not contain a build. In order to run tests need to:
- instrument app (load AltTester Unity SDK as package in Unity Editor)
- build application with desired target platform (e.g.: Standalone Windows)

## Pre-requisites
1. Install the required [.NET Framework Developer Pack](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks#supported-versions-framework), version 4.7.1 [installer link](https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net471-developer-pack-offline-installer)
2. Install Unity Hub
3. Install **Unity Editor version 2021.3.12f1**
4. Import AltTester Unity SDK in Unity Editor
  * Assets > Import Package > Custom Package > use the SDK version suggested below in *Before running the tests*

## Before running the tests
To run the tests, you must include the AltTester Unity SDK in the project. To do that, you can choose between the following ways:
1. Add the AltTester Unity SDK submodule to the project
    - use ``git submodule update --init`` command to pull the git submodule;
    - make sure that the submodule added is on the master branch (you can use the following command ``git checkout master`` in the <i>Assets/AltTester-Unity-SDK</i> folder);
    - also, if you already have the project, you should make a ``git pull`` on the master branch, in order to ensure that you are using the latest version of AltTester.

    <br> 
2. Download AltTester Unity SDK and import it into Unity 
    - download the AltTester Unity SDK from the [Altom website: Alttester](https://altom.com/testing-tools/alttester/) or using this [link for unitypackage](https://altom.com/app/uploads/AltTester/sdks/AltTester.unitypackage);
    - import the package into the project (drag-n-drop the package in the Assets folder);
    - a pop-up will appear, select All and click on Import.

## Run tests: using Unity Editor > AltTester Editor

1. Open the project in Unity Editor (see pre-requisites for which version proved to work).
2. Platform > Standalone > Build Target: StandaloneWindows
  * Build Only
3. Open AltTester Editor from Unity Editor menu (displayed only after imported package as mentioned above) and see tests under `Assembly-CSharp-Editor.dll`
4. If build completed successfully, should see in folder `New Input System proj` *build* folder.
5. Launch Game from executable inside *build* folder
6. In Unity Editor: select tests under **AltTester_NIS_Tests**
  * Run Selected Tests

The tests can be found in *New Input System proj > Assets > Editor > Tests* folder in the **AltTester_NIS_Tests.cs** class.

## Run tests: using [dotnet CLI](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-test)

In order to be able to execute tests using dotnet, need to have an NUnit Test project. Compared with parent repository generated following steps to be able to execute tests from terminal with dotnet CLI.

1. Create a folder `CoinCollector.Tests` inside `New Input System proj`
2. From `CoinCollector.Tests` create a test project that uses NUnit as the test library:

```
dotnet new nunit
```

3. Rename `UnitTest1.cs` to smth convenient ( eg: `AltTester_NIS_Tests.cs`)

4. Add necessary nuget packages:
 - AltTester-Driver (v 1.8.0)

 ```
 dotnet add package AltTester-Driver --version 1.8.0
 ```

- UnityEngine

```
dotnet add package UnityEngine --version 1.0.0
```

5. Execute tests

```
dotnet test
```

# CoinCollector - CSharp tests

This project contains C# AltTester tests for a project using the [New Input System](https://alttester.com/docs/sdk/pages/commands.html#input-actions).

The tested actions are: 
- BeginTouch, EndTouch
- Click
- PressKey
- Scroll
- Swipe
- Tap
- KeyDown, KeyUp
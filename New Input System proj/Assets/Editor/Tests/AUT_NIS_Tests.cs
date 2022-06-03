using NUnit.Framework;
using Altom.AltUnityDriver;
using System.Threading;
using UnityEngine; 

public class AUT_NIS_Tests
{
    public AltUnityDriver altUnityDriver;
    //Before any test it connects with the socket
    [OneTimeSetUp]
    public void SetUp()
    {
        altUnityDriver =new AltUnityDriver();
    }

    //At the end of the test closes the connection with the socket
    [OneTimeTearDown]
    public void TearDown()
    {
        altUnityDriver.Stop();
    }

    //scroll
    [Test]
    public void TestPlayerJumpsOnScroll()
    {
        altUnityDriver.LoadScene("GameScene");
        Thread.Sleep(1000);
        altUnityDriver.Scroll(2000, 0.1f, true);
        var coinValue = altUnityDriver.FindObject(By.PATH,"//GameController/GameView/Coin/CoinValueText");
        Thread.Sleep(500);
        Assert.AreEqual("1", coinValue.GetText());
    }

    //click object
    [Test]
    public void TestPlayerJumpsOnClick()
    {
        altUnityDriver.LoadScene("GameScene");
        
        Thread.Sleep(1000);
        var player = altUnityDriver.FindObject(By.NAME, "Player");
        player.Click();
        var coinValue = altUnityDriver.FindObject(By.PATH,"//GameController/GameView/Coin/CoinValueText");
        Thread.Sleep(500);
        Assert.AreEqual("1", coinValue.GetText());
    }
    
    //tap object
    [Test]
    public void TestPlayerJumpsOnTap()
    {
        altUnityDriver.LoadScene("GameScene");
        
        Thread.Sleep(1000);
        var player = altUnityDriver.FindObject(By.NAME, "Player");
        player.Tap();
        var coinValue = altUnityDriver.FindObject(By.PATH,"//GameController/GameView/Coin/CoinValueText");
        Thread.Sleep(500);
        Assert.AreEqual("1", coinValue.GetText());
    }

    //swipe object
    [Test]
    public void TestPlayerJumpsOnSwipe()
    {
        altUnityDriver.LoadScene("GameScene");
        Thread.Sleep(1000);
        var playerPos = altUnityDriver.FindObject(By.NAME,"Player");
        altUnityDriver.Swipe(new AltUnityVector2(playerPos.x + 1, playerPos.y + 1), new AltUnityVector2(playerPos.x + 1, playerPos.y + 1), 0.1f); //simulating a tap
        var coinValue = altUnityDriver.FindObject(By.PATH,"//GameController/GameView/Coin/CoinValueText");
        Thread.Sleep(500);
        Assert.AreEqual("1", coinValue.GetText());
    }

    //key down + key up
    [Test]
    public void TestPlayerMovesOnKeyDownKeyUp()
    {
        altUnityDriver.LoadScene("GameScene");        
        Thread.Sleep(1000);

        var player = altUnityDriver.FindObject(By.NAME, "Player");

        altUnityDriver.KeyDown(AltUnityKeyCode.LeftArrow);
        Thread.Sleep(700);
        altUnityDriver.KeyUp(AltUnityKeyCode.LeftArrow);
        altUnityDriver.KeyDown(AltUnityKeyCode.Mouse0);
        Thread.Sleep(100);
        altUnityDriver.KeyUp(AltUnityKeyCode.Mouse0);
        var coinValue = altUnityDriver.FindObject(By.PATH,"//GameController/GameView/Coin/CoinValueText");
        Assert.AreEqual("1", coinValue.GetText());
        
    }

    //key down + key up + press key
    [Test]
    public void TestPlayerJumpsOnPressKey()
    {
        altUnityDriver.LoadScene("GameScene");        
        Thread.Sleep(1000);
        altUnityDriver.KeyDown(AltUnityKeyCode.DownArrow);
        Thread.Sleep(600);
        altUnityDriver.KeyUp(AltUnityKeyCode.DownArrow);
        altUnityDriver.PressKey(AltUnityKeyCode.Mouse0);
        Thread.Sleep(200);
        var coinValue = altUnityDriver.FindObject(By.PATH,"//GameController/GameView/Coin/CoinValueText");
        Assert.AreEqual("1", coinValue.GetText());
    }


    [Test]
    public void TestPlayerJumpsOnBeginEndTouch()
    {
        altUnityDriver.LoadScene("GameScene");
        Thread.Sleep(1000);
        var player = altUnityDriver.FindObject(By.NAME,"Player");
        var playerPos = player.getScreenPosition();
        var fingerId = altUnityDriver.BeginTouch(playerPos);
        altUnityDriver.EndTouch(fingerId);
        var coinValue = altUnityDriver.FindObject(By.PATH,"//GameController/GameView/Coin/CoinValueText");
        Thread.Sleep(500);
        Assert.AreEqual("1", coinValue.GetText());
        
    }

}
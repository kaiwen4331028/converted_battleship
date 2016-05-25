using System;
using NUnit.Framework;
using SwinGameSDK;

namespace BattleShips
{
	[TestFixture]
	public class Test_Battleship
	{
		
		[Test]
		public void Testing_Mute()
		{
			// this test is assume that the user click the mute music button, it will mute the music 

			// set the music is on
			MenuController.Set_Flag_Mute = true;
			// confirm that music is on
			Assert.AreEqual (true, MenuController.Get_Flag_Mute);

			// after user clicked the mute button
			MenuController.PerformMainMenuAction (3);
			// confirm the music will go off
			Assert.AreEqual (false, MenuController.Get_Flag_Mute);

		}

	}
}


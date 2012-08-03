/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 31/07/2012
 * Time: 08:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GameTimer
{
	/// <summary>
	/// Identification and timer information for a player.
	/// </summary>
	public class Player
	{
		public string name;
		public int hoursLeft;
		public int minsLeft;
		public int secsLeft;
		public int tenthsLeft;
		public Boolean knockedOut = false;
		
		public Player(int hoursLeft, int minsLeft, int secsLeft)
		{
			this.hoursLeft = hoursLeft;
			this.minsLeft = minsLeft;
			this.secsLeft = secsLeft;
			if(hoursLeft>0 || minsLeft>0 || secsLeft>0){
				this.tenthsLeft = 9;
			}
		}
	}
}
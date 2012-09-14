/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 31/07/2012
 * Time: 08:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace GameTimer
{
	/// <summary>
	/// Identification and timer information for a player.
	/// </summary>
	public class Player
	{
		public string name;
		public Boolean active = true;
		
		// timeLeftLabel is reference to labelPxTimeLeft of MainForm
		public Label timeLeftLabel;
		
		public TimeSpan timeRemaining;
		
		public Player(int hoursLeft, int minsLeft, int secsLeft)
		{
			this.timeRemaining = new TimeSpan(hoursLeft, minsLeft, secsLeft);
			}
		}
	}
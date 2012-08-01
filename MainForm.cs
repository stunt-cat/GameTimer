/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 31/07/2012
 * Time: 08:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GameTimer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			// Make new event handler for timer Tick event
			timer.Tick += new EventHandler(timer_Tick);
			
		}
		
		Boolean pause = false; // Used to determine whether 'pause' button has been activated or not
		int numberOfPlayers;
		
		// List is populated in ButtonStartClick(), from user parameters
		public List<Player> players;
		Player activePlayer;
		
		// N.B. Only player 1 text box and label is visible to begin with
		// Make more/less player text boxes clear colour and editable as number is increased/decreased
		// Increase/decrease NumericUpDownStartPlayer max value as number is increased/decreased
		void NumericUpDownPlayersValueChanged(object sender, EventArgs e)
		{
			switch ((int)numericUpDownPlayers.Value){
				case 1 : if (numericUpDownPlayers.Value == 1){
						labelP2Name.Visible = false;
						labelP3Name.Visible = false;
						labelP4Name.Visible = false;
						textBoxP2.Visible = false;
						textBoxP3.Visible = false;
						textBoxP4.Visible = false;
						numericUpDownStartPlayer.Maximum = 1;
					} break;
				case 2: if (numericUpDownPlayers.Value == 2){
						labelP2Name.Visible = true;
						labelP3Name.Visible = false;
						labelP4Name.Visible = false;
						textBoxP2.Visible = true;
						textBoxP3.Visible = false;
						textBoxP4.Visible = false;
						numericUpDownStartPlayer.Maximum = 2;
					} break;
				case 3: if (numericUpDownPlayers.Value == 3){
						labelP3Name.Visible = true;
						labelP4Name.Visible = false;
						textBoxP3.Visible = true;
						textBoxP4.Visible = false;
						numericUpDownStartPlayer.Maximum = 3;
					} break;
				case 4: if (numericUpDownPlayers.Value == 4){
						labelP4Name.Visible = true;
						textBoxP4.Visible = true;
						numericUpDownStartPlayer.Maximum = 4;
					} break;
			}
		}
		
		// Gets user input values and starts initial player clock
		void ButtonStartClick(object sender, System.EventArgs e)
		{
			// Hide setup panel
			groupBoxSetup.Visible = false;
			groupBoxActive.Visible = true;
			
			// Create List<Player> to correct size defined by user.
			numberOfPlayers = (int)numericUpDownPlayers.Value;
			players = new List<Player> (numberOfPlayers);
			
			// Set max value of NumericUpDownStartValue and reveal correct number of Player Name entry areas
			numericUpDownStartPlayer.Maximum = (decimal)numberOfPlayers;
			
			// Populate List<Player> according to user specified number of players, using user specified initial time
			for (int i=0; i<numberOfPlayers; i++){
				players.Add(new Player((int)numericUpDownH.Value, (int)numericUpDownM.Value, (int)numericUpDownS.Value));
			}
			
			// Setup active panel to display player names (or assign standard names if none are entered) and remaining time
			switch (numberOfPlayers){
					case 1 : if(textBoxP1.Text == "") players[0].name = "Player 1";
						else players[0].name = textBoxP1.Text;
						labelP1TimeLeft.Text = DisplayTimeLeft(players[0]);
						labelP1Timer.Text = players[0].name;
						break;
				case 2 : if(textBoxP2.Text == "") players[1].name = "Player 2";
						else players[1].name = textBoxP2.Text;
						labelP2TimeLeft.Text = DisplayTimeLeft(players[1]);
						labelP2Timer.Text = players[1].name;
						goto case 1;
				case 3 : if(textBoxP3.Text == "") players[2].name = "Player 3";
						else players[2].name = textBoxP3.Text;
						labelP3TimeLeft.Text = DisplayTimeLeft(players[2]);
						labelP3Timer.Text = players[2].name;
						goto case 2;
				case 4 : if(textBoxP4.Text == "") players[3].name = "Player 4";
						else players[3].name = textBoxP4.Text;
						labelP4TimeLeft.Text = DisplayTimeLeft(players[3]);
						labelP4Timer.Text = players[3].name;
						goto case 3;
			}
			
			// Make non-existant player data invisible in active panel
			switch (numberOfPlayers){
				case 1:	labelP2Timer.Visible = false;
						labelP3Timer.Visible = false;
						labelP4Timer.Visible = false;
						labelP2TimeLeft.Visible = false;
						labelP3TimeLeft.Visible = false;
						labelP4TimeLeft.Visible = false;
						break;
				case 2: labelP3Timer.Visible = false;
						labelP4Timer.Visible = false;
						labelP3TimeLeft.Visible = false;
						labelP4TimeLeft.Visible = false;
						break;
				case 3: labelP4Timer.Visible = false;
						labelP4TimeLeft.Visible = false;
						break;
				case 4: break;
			}
			
			// Set active player
			activePlayer = players[(int)numericUpDownStartPlayer.Value - 1];
			
			// Highlight active player
			switch((int)numericUpDownStartPlayer.Value){
				case 1:	labelP1TimeLeft.BackColor = SystemColors.ControlLightLight;
						labelP2TimeLeft.BackColor = SystemColors.Control;
						labelP3TimeLeft.BackColor = SystemColors.Control;
						labelP4TimeLeft.BackColor = SystemColors.Control;
						break;
				case 2:	labelP1TimeLeft.BackColor = SystemColors.Control;
						labelP2TimeLeft.BackColor = SystemColors.ControlLightLight;
						labelP3TimeLeft.BackColor = SystemColors.Control;
						labelP4TimeLeft.BackColor = SystemColors.Control;
						break;
				case 3:	labelP1TimeLeft.BackColor = SystemColors.Control;
						labelP2TimeLeft.BackColor = SystemColors.Control;
						labelP3TimeLeft.BackColor = SystemColors.ControlLightLight;
						labelP4TimeLeft.BackColor = SystemColors.Control;
						break;
				case 4:	labelP1TimeLeft.BackColor = SystemColors.Control;
						labelP2TimeLeft.BackColor = SystemColors.Control;
						labelP3TimeLeft.BackColor = SystemColors.Control;
						labelP4TimeLeft.BackColor = SystemColors.ControlLightLight;
						break;
			}
			
			// Begin timer
			timer.Start();
		}
		
		string DisplayTimeLeft(Player player){
			return string.Format("{0}:{1}:{2}",player.hoursLeft.ToString("00"), player.minsLeft.ToString("00"), player.secsLeft.ToString("00"));
		}
		
		void timer_Tick(Object myObject, EventArgs myEventArgs){
			DecrementTimer(activePlayer);
		}
		
		void DecrementTimer(Player player){
			if(player.hoursLeft == 0 && player.minsLeft == 0 && player.secsLeft == 1 && player.tenthsLeft == 1){
				timer.Stop();
				buttonTimerUp.Text = string.Format("{0} is out of time!",activePlayer.name);
				buttonTimerUp.Visible = true;
				buttonExit.Visible = false;
			} else {
				if(player.tenthsLeft>0){
				   	player.tenthsLeft--;
				   }
				else if(player.secsLeft>0) {
					player.secsLeft--;
					player.tenthsLeft = 9;
				}
				else if(player.minsLeft > 0){
					player.minsLeft--;
					player.secsLeft = 59;
					player.tenthsLeft = 9;
				}
				else if(player.hoursLeft > 0){
					player.hoursLeft--;
					player.minsLeft = 59;
					player.secsLeft = 59;
					player.tenthsLeft = 9;
				}
			}
			
			if (player == players[0]) labelP1TimeLeft.Text = DisplayTimeLeft(players[0]);
			else if(player == players[1]) labelP2TimeLeft.Text = DisplayTimeLeft(players[1]);
			else if(player == players[2]) labelP3TimeLeft.Text = DisplayTimeLeft(players[2]);
			else if(player == players[3]) labelP4TimeLeft.Text = DisplayTimeLeft(players[3]);
			return;
		}

		
		void ButtonSwitchPlayerClick(object sender, EventArgs e)
		{
			switch(numberOfPlayers){
				case 1: break;
	
				case 2:	if (activePlayer == players[1]){
							activePlayer = players[0];
							labelP1TimeLeft.BackColor = SystemColors.ControlLightLight;
							labelP2TimeLeft.BackColor = SystemColors.Control;
						} else {
							activePlayer = players[1];
							labelP1TimeLeft.BackColor = SystemColors.Control;
							labelP2TimeLeft.BackColor = SystemColors.ControlLightLight;
						}
						break;
						
				case 3:	if (activePlayer == players[0]){
							activePlayer = players[1];
							labelP1TimeLeft.BackColor = SystemColors.Control;
							labelP2TimeLeft.BackColor = SystemColors.ControlLightLight;
							labelP3TimeLeft.BackColor = SystemColors.Control;
						} else if(activePlayer == players[1]){
							activePlayer = players[2];
							labelP1TimeLeft.BackColor = SystemColors.Control;
							labelP2TimeLeft.BackColor = SystemColors.Control;
							labelP3TimeLeft.BackColor = SystemColors.ControlLightLight;
						} else {
							activePlayer = players[0];
							labelP1TimeLeft.BackColor = SystemColors.ControlLightLight;
							labelP2TimeLeft.BackColor = SystemColors.Control;
							labelP3TimeLeft.BackColor = SystemColors.Control;
						}
						break;
						
				case 4:	if (activePlayer == players[0]){
							activePlayer = players[1];
							labelP1TimeLeft.BackColor = SystemColors.Control;
							labelP2TimeLeft.BackColor = SystemColors.ControlLightLight;
							labelP3TimeLeft.BackColor = SystemColors.Control;
							labelP4TimeLeft.BackColor = SystemColors.Control;
						} else if(activePlayer == players[1]){
							activePlayer = players[2];
							labelP1TimeLeft.BackColor = SystemColors.Control;
							labelP2TimeLeft.BackColor = SystemColors.Control;
							labelP3TimeLeft.BackColor = SystemColors.ControlLightLight;
							labelP4TimeLeft.BackColor = SystemColors.Control;
						} else if(activePlayer == players[2]){
							activePlayer = players[3];
							labelP1TimeLeft.BackColor = SystemColors.Control;
							labelP2TimeLeft.BackColor = SystemColors.Control;
							labelP3TimeLeft.BackColor = SystemColors.Control;
							labelP4TimeLeft.BackColor = SystemColors.ControlLightLight;
						} else {
							activePlayer = players[0];
							labelP1TimeLeft.BackColor = SystemColors.ControlLightLight;
							labelP2TimeLeft.BackColor = SystemColors.Control;
							labelP3TimeLeft.BackColor = SystemColors.Control;
							labelP4TimeLeft.BackColor = SystemColors.Control;
						}
						break;
			}
		}
			
		void ButtonTimerUpClick(object sender, EventArgs e)
		{
			buttonTimerUp.Visible = false;
			groupBoxActive.Visible = false;
			buttonExit.Visible = true;
			groupBoxSetup.Visible = true;
		}
		
		void ButtonPauseClick(object sender, EventArgs e)
		{
			if (!pause){
				pause = true;
				timer.Stop();
				buttonSwitchPlayer.Enabled = false;
				buttonPause.BackColor = SystemColors.ControlDark;
			} else {
				pause = false;
				timer.Start();
				buttonSwitchPlayer.Enabled = true;
				buttonPause.BackColor = SystemColors.Control;
			}
		}
		
		void ButtonExitClick(object sender, EventArgs e)
		{
			// Make all contents of groupBoxActive visible again ready for next selection and back to normal colour
			labelP2Timer.Visible = true;
			labelP3Timer.Visible = true;
			labelP4Timer.Visible = true;
			labelP2TimeLeft.Visible = true;
			labelP3TimeLeft.Visible = true;
			labelP4TimeLeft.Visible = true;
			labelP1TimeLeft.BackColor = SystemColors.Control;
			labelP2TimeLeft.BackColor = SystemColors.Control;
			labelP3TimeLeft.BackColor = SystemColors.Control;
			labelP4TimeLeft.BackColor = SystemColors.Control;
			
			groupBoxActive.Visible = false;
			groupBoxSetup.Visible = true;
		}
	
	}
}
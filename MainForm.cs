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
		
		// playersRemaining is populated in ButtonStartClick(), from user parameters.
		public List<Player> players = new List<Player>();
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
			if(numericUpDownH.Value == 0 && numericUpDownM.Value == 0 && numericUpDownS.Value == 0){
				buttonZeroInitialTime.Visible = true;
			} else {
			
				// Hide setup panel
			groupBoxSetup.Visible = false;
			groupBoxActive.Visible = true;
			
			// Set max value of NumericUpDownStartPlayer and reveal correct number of Player Name entry areas
			numberOfPlayers = (int)numericUpDownPlayers.Value;
			numericUpDownStartPlayer.Maximum = (decimal)numberOfPlayers;
			
			// Populate List<Player> according to user specified number of players, using user specified initial time
			for (int i=0; i<numberOfPlayers; i++){
				players.Add(new Player((int)numericUpDownH.Value, (int)numericUpDownM.Value, (int)numericUpDownS.Value));
			}
			
			// Setup active panel to display player names (or assign standard names if none are entered) and remaining time.
			// Also give each player a reference to their labelPxTimeLeft
			switch (numberOfPlayers){
				case 1 : if(textBoxP1.Text == "") players[0].name = "Player 1";
						else players[0].name = textBoxP1.Text;
						labelP1Timer.Text = players[0].name;
						players[0].timeLeftLabel = labelP1TimeLeft;
						goto default;
				case 2 : if(textBoxP2.Text == "") players[1].name = "Player 2";
						else players[1].name = textBoxP2.Text;
						labelP2Timer.Text = players[1].name;
						players[1].timeLeftLabel = labelP2TimeLeft;
						goto case 1;
				case 3 : if(textBoxP3.Text == "") players[2].name = "Player 3";
						else players[2].name = textBoxP3.Text;
						labelP3Timer.Text = players[2].name;
						players[2].timeLeftLabel = labelP3TimeLeft;
						goto case 2;
				case 4 : if(textBoxP4.Text == "") players[3].name = "Player 4";
						else players[3].name = textBoxP4.Text;
						labelP4Timer.Text = players[3].name;
						players[3].timeLeftLabel = labelP4TimeLeft;
						goto case 3;
				default:
						for(int i=0; i<numberOfPlayers; i++){
							players[i].timeLeftLabel.Text = DisplayTimeLeft(players[i]);
						}
						break;
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
			
			// Set active player and assign correct colours to labelPxTimeLeft
			activePlayer = players[(int)numericUpDownStartPlayer.Value - 1];
			ColourIn();
			
			// Begin timer
			timer.Start();
			}
		}
		
		void ButtonZeroInitialTimeClick(object sender, EventArgs e)
		{
			buttonZeroInitialTime.Visible = false;
		}
		
		string DisplayTimeLeft(Player player){
			return player.timeRemaining.ToString();
		}
		
		void timer_Tick(Object myObject, EventArgs myEventArgs){
			DecrementTimer(activePlayer);
		}
		
		void DecrementTimer(Player player){
			// When a players' time runs out, show message, highlight player time red, switch to next player.
			// Otherwise decrement player time remaining.
			TimeSpan decrement = new TimeSpan(1000000);
			if(player.timeRemaining.Ticks == 0){
				player.active = false;
				PlayerTimeUpStatus(player);
			} else {
				player.timeRemaining = player.timeRemaining.Subtract(decrement);
			}
		
			for(int i=0; i<numberOfPlayers; i++){
				players[i].timeLeftLabel.Text = DisplayTimeLeft(players[i]);
			}
			return;
		}
		
		void PlayerTimeUpStatus(Player knockedOut){
			// If everyone is out of time end timer.
			Boolean someoneLeft = false;
			foreach(Player checkMe in players){
				if(checkMe.active){
					someoneLeft = true;
				}
			}
			if(someoneLeft){
				buttonTimerUp.Text = string.Format("{0} is out of time!",knockedOut.name);
				SwitchPlayer();
				buttonTimerUp.Visible = true;
			} else {
				buttonTimerUp.Visible = false;
				buttonAllTimersUp.Visible = true;
			}
		}

		// Selects next player in play order who is still active
		void SwitchPlayer(){
			List<Player> playOrder = new List<Player>();
			
			// Populate playOrder with all players in the order they will play (regardless of if they are active or not)
			// Add all players after activePlayer
			for(int i=players.IndexOf(activePlayer)+1; i<players.Count; i++){
				playOrder.Add(players[i]);
			}
			// Append all players before and including activePlayer
			for(int i=0; i<players.IndexOf(activePlayer); i++){
				playOrder.Add(players[i]);
			}
			
			// Choose next Player in playOrder who is active to be activePlayer
			foreach(Player checkMe in playOrder){
				if(checkMe.active){
					activePlayer = checkMe;
					break;
				}
			}
			
			ColourIn();
		}
		
		void ColourIn(){
			// Sets background colours for all
			// Colour of activeplayer to ControlLightLight
			// Colour of other active players to Control
			// Colour of other non-active players to Control.Dark
		
			foreach(Player player in players){
				if(!player.active){
					player.timeLeftLabel.BackColor = SystemColors.ControlDark;
				} else player.timeLeftLabel.BackColor = SystemColors.Control;
				
				// Set background colour of active player
				if(player == activePlayer){
					player.timeLeftLabel.BackColor = SystemColors.ControlLightLight;
				}
			}
		}
		
		void ButtonSwitchPlayerClick(object sender, EventArgs e)
		{
			SwitchPlayer();
		}
			
		void ButtonTimerUpClick(object sender, EventArgs e)
		{
			buttonTimerUp.Visible = false;
		}
		
		// 
		void ButtonAllTimersUpClick(object sender, EventArgs e)
		{
			buttonTimerUp.Visible = false;
			buttonAllTimersUp.Visible = false;
			Reset();
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
			Reset();
		}
		
		void Reset(){
			timer.Stop();
			players.Clear();
			groupBoxActive.Visible = false;
			groupBoxSetup.Visible = true;
			
			// Make all contents of groupBoxActive visible again ready for next selection and back to normal colour
			labelP2Timer.Visible = true;
			labelP3Timer.Visible = true;
			labelP4Timer.Visible = true;
			labelP2TimeLeft.Visible = true;
			labelP3TimeLeft.Visible = true;
			labelP4TimeLeft.Visible = true;
		}
	}
}
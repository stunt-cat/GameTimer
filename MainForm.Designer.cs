/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 31/07/2012
 * Time: 08:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GameTimer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.labelStartPlayer = new System.Windows.Forms.Label();
			this.buttonStart = new System.Windows.Forms.Button();
			this.numericUpDownS = new System.Windows.Forms.NumericUpDown();
			this.labelSec = new System.Windows.Forms.Label();
			this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
			this.labelMin = new System.Windows.Forms.Label();
			this.numericUpDownH = new System.Windows.Forms.NumericUpDown();
			this.labelHour = new System.Windows.Forms.Label();
			this.labelTime = new System.Windows.Forms.Label();
			this.groupBoxSetup = new System.Windows.Forms.GroupBox();
			this.textBoxP4 = new System.Windows.Forms.TextBox();
			this.numericUpDownStartPlayer = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownPlayers = new System.Windows.Forms.NumericUpDown();
			this.labelP4Name = new System.Windows.Forms.Label();
			this.labelPlayerNumber = new System.Windows.Forms.Label();
			this.textBoxP3 = new System.Windows.Forms.TextBox();
			this.textBoxP1 = new System.Windows.Forms.TextBox();
			this.labelP3Name = new System.Windows.Forms.Label();
			this.labelP1Name = new System.Windows.Forms.Label();
			this.textBoxP2 = new System.Windows.Forms.TextBox();
			this.labelP2Name = new System.Windows.Forms.Label();
			this.groupBoxActive = new System.Windows.Forms.GroupBox();
			this.buttonTimerUp = new System.Windows.Forms.Button();
			this.labelP4TimeLeft = new System.Windows.Forms.Label();
			this.labelP4Timer = new System.Windows.Forms.Label();
			this.labelP3TimeLeft = new System.Windows.Forms.Label();
			this.labelP3Timer = new System.Windows.Forms.Label();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonPause = new System.Windows.Forms.Button();
			this.buttonSwitchPlayer = new System.Windows.Forms.Button();
			this.labelP2TimeLeft = new System.Windows.Forms.Label();
			this.labelP1TimeLeft = new System.Windows.Forms.Label();
			this.labelP2Timer = new System.Windows.Forms.Label();
			this.labelP1Timer = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).BeginInit();
			this.groupBoxSetup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPlayer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayers)).BeginInit();
			this.groupBoxActive.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelStartPlayer
			// 
			this.labelStartPlayer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStartPlayer.Location = new System.Drawing.Point(80, 198);
			this.labelStartPlayer.Name = "labelStartPlayer";
			this.labelStartPlayer.Size = new System.Drawing.Size(100, 23);
			this.labelStartPlayer.TabIndex = 4;
			this.labelStartPlayer.Text = "Start Player";
			// 
			// buttonStart
			// 
			this.buttonStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonStart.Location = new System.Drawing.Point(80, 326);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(170, 40);
			this.buttonStart.TabIndex = 15;
			this.buttonStart.Text = "START";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
			// 
			// numericUpDownS
			// 
			this.numericUpDownS.Location = new System.Drawing.Point(211, 287);
			this.numericUpDownS.Maximum = new decimal(new int[] {
									59,
									0,
									0,
									0});
			this.numericUpDownS.Name = "numericUpDownS";
			this.numericUpDownS.Size = new System.Drawing.Size(39, 20);
			this.numericUpDownS.TabIndex = 9;
			// 
			// labelSec
			// 
			this.labelSec.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSec.Location = new System.Drawing.Point(170, 286);
			this.labelSec.Name = "labelSec";
			this.labelSec.Size = new System.Drawing.Size(35, 21);
			this.labelSec.TabIndex = 13;
			this.labelSec.Text = "SS";
			// 
			// numericUpDownM
			// 
			this.numericUpDownM.Location = new System.Drawing.Point(211, 266);
			this.numericUpDownM.Maximum = new decimal(new int[] {
									59,
									0,
									0,
									0});
			this.numericUpDownM.Name = "numericUpDownM";
			this.numericUpDownM.Size = new System.Drawing.Size(39, 20);
			this.numericUpDownM.TabIndex = 8;
			// 
			// labelMin
			// 
			this.labelMin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMin.Location = new System.Drawing.Point(170, 265);
			this.labelMin.Name = "labelMin";
			this.labelMin.Size = new System.Drawing.Size(35, 21);
			this.labelMin.TabIndex = 11;
			this.labelMin.Text = "MM";
			// 
			// numericUpDownH
			// 
			this.numericUpDownH.Location = new System.Drawing.Point(211, 245);
			this.numericUpDownH.Maximum = new decimal(new int[] {
									5,
									0,
									0,
									0});
			this.numericUpDownH.Name = "numericUpDownH";
			this.numericUpDownH.Size = new System.Drawing.Size(39, 20);
			this.numericUpDownH.TabIndex = 7;
			// 
			// labelHour
			// 
			this.labelHour.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHour.Location = new System.Drawing.Point(170, 244);
			this.labelHour.Name = "labelHour";
			this.labelHour.Size = new System.Drawing.Size(35, 21);
			this.labelHour.TabIndex = 9;
			this.labelHour.Text = "HH";
			// 
			// labelTime
			// 
			this.labelTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTime.Location = new System.Drawing.Point(62, 262);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(95, 24);
			this.labelTime.TabIndex = 8;
			this.labelTime.Text = "Time Each";
			// 
			// groupBoxSetup
			// 
			this.groupBoxSetup.Controls.Add(this.textBoxP4);
			this.groupBoxSetup.Controls.Add(this.numericUpDownStartPlayer);
			this.groupBoxSetup.Controls.Add(this.numericUpDownPlayers);
			this.groupBoxSetup.Controls.Add(this.labelP4Name);
			this.groupBoxSetup.Controls.Add(this.labelPlayerNumber);
			this.groupBoxSetup.Controls.Add(this.buttonStart);
			this.groupBoxSetup.Controls.Add(this.textBoxP3);
			this.groupBoxSetup.Controls.Add(this.textBoxP1);
			this.groupBoxSetup.Controls.Add(this.numericUpDownS);
			this.groupBoxSetup.Controls.Add(this.labelP3Name);
			this.groupBoxSetup.Controls.Add(this.labelSec);
			this.groupBoxSetup.Controls.Add(this.labelP1Name);
			this.groupBoxSetup.Controls.Add(this.numericUpDownM);
			this.groupBoxSetup.Controls.Add(this.textBoxP2);
			this.groupBoxSetup.Controls.Add(this.labelMin);
			this.groupBoxSetup.Controls.Add(this.labelP2Name);
			this.groupBoxSetup.Controls.Add(this.numericUpDownH);
			this.groupBoxSetup.Controls.Add(this.labelHour);
			this.groupBoxSetup.Controls.Add(this.labelTime);
			this.groupBoxSetup.Controls.Add(this.labelStartPlayer);
			this.groupBoxSetup.Location = new System.Drawing.Point(2, 12);
			this.groupBoxSetup.Name = "groupBoxSetup";
			this.groupBoxSetup.Size = new System.Drawing.Size(307, 379);
			this.groupBoxSetup.TabIndex = 0;
			this.groupBoxSetup.TabStop = false;
			this.groupBoxSetup.Text = "Setup";
			// 
			// textBoxP4
			// 
			this.textBoxP4.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxP4.Location = new System.Drawing.Point(170, 155);
			this.textBoxP4.MaxLength = 10;
			this.textBoxP4.Name = "textBoxP4";
			this.textBoxP4.Size = new System.Drawing.Size(86, 20);
			this.textBoxP4.TabIndex = 5;
			this.textBoxP4.Visible = false;
			// 
			// numericUpDownStartPlayer
			// 
			this.numericUpDownStartPlayer.Location = new System.Drawing.Point(193, 198);
			this.numericUpDownStartPlayer.Maximum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDownStartPlayer.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDownStartPlayer.Name = "numericUpDownStartPlayer";
			this.numericUpDownStartPlayer.Size = new System.Drawing.Size(52, 20);
			this.numericUpDownStartPlayer.TabIndex = 6;
			this.numericUpDownStartPlayer.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// numericUpDownPlayers
			// 
			this.numericUpDownPlayers.Location = new System.Drawing.Point(211, 30);
			this.numericUpDownPlayers.Maximum = new decimal(new int[] {
									4,
									0,
									0,
									0});
			this.numericUpDownPlayers.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDownPlayers.Name = "numericUpDownPlayers";
			this.numericUpDownPlayers.Size = new System.Drawing.Size(52, 20);
			this.numericUpDownPlayers.TabIndex = 1;
			this.numericUpDownPlayers.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDownPlayers.ValueChanged += new System.EventHandler(this.NumericUpDownPlayersValueChanged);
			// 
			// labelP4Name
			// 
			this.labelP4Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelP4Name.Location = new System.Drawing.Point(89, 155);
			this.labelP4Name.Name = "labelP4Name";
			this.labelP4Name.Size = new System.Drawing.Size(75, 23);
			this.labelP4Name.TabIndex = 18;
			this.labelP4Name.Text = "Player 4";
			this.labelP4Name.Visible = false;
			// 
			// labelPlayerNumber
			// 
			this.labelPlayerNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPlayerNumber.Location = new System.Drawing.Point(49, 30);
			this.labelPlayerNumber.Name = "labelPlayerNumber";
			this.labelPlayerNumber.Size = new System.Drawing.Size(156, 21);
			this.labelPlayerNumber.TabIndex = 20;
			this.labelPlayerNumber.Text = "Number of Players";
			// 
			// textBoxP3
			// 
			this.textBoxP3.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxP3.Location = new System.Drawing.Point(170, 129);
			this.textBoxP3.MaxLength = 10;
			this.textBoxP3.Name = "textBoxP3";
			this.textBoxP3.Size = new System.Drawing.Size(86, 20);
			this.textBoxP3.TabIndex = 4;
			this.textBoxP3.Visible = false;
			// 
			// textBoxP1
			// 
			this.textBoxP1.Location = new System.Drawing.Point(170, 77);
			this.textBoxP1.MaxLength = 10;
			this.textBoxP1.Name = "textBoxP1";
			this.textBoxP1.Size = new System.Drawing.Size(86, 20);
			this.textBoxP1.TabIndex = 2;
			// 
			// labelP3Name
			// 
			this.labelP3Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelP3Name.Location = new System.Drawing.Point(89, 129);
			this.labelP3Name.Name = "labelP3Name";
			this.labelP3Name.Size = new System.Drawing.Size(75, 23);
			this.labelP3Name.TabIndex = 16;
			this.labelP3Name.Text = "Player 3";
			this.labelP3Name.Visible = false;
			// 
			// labelP1Name
			// 
			this.labelP1Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelP1Name.Location = new System.Drawing.Point(89, 77);
			this.labelP1Name.Name = "labelP1Name";
			this.labelP1Name.Size = new System.Drawing.Size(75, 23);
			this.labelP1Name.TabIndex = 0;
			this.labelP1Name.Text = "Player 1";
			// 
			// textBoxP2
			// 
			this.textBoxP2.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxP2.Location = new System.Drawing.Point(170, 103);
			this.textBoxP2.MaxLength = 10;
			this.textBoxP2.Name = "textBoxP2";
			this.textBoxP2.Size = new System.Drawing.Size(86, 20);
			this.textBoxP2.TabIndex = 3;
			this.textBoxP2.Visible = false;
			// 
			// labelP2Name
			// 
			this.labelP2Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelP2Name.Location = new System.Drawing.Point(89, 103);
			this.labelP2Name.Name = "labelP2Name";
			this.labelP2Name.Size = new System.Drawing.Size(75, 23);
			this.labelP2Name.TabIndex = 1;
			this.labelP2Name.Text = "Player 2";
			this.labelP2Name.Visible = false;
			// 
			// groupBoxActive
			// 
			this.groupBoxActive.Controls.Add(this.buttonTimerUp);
			this.groupBoxActive.Controls.Add(this.labelP4TimeLeft);
			this.groupBoxActive.Controls.Add(this.labelP4Timer);
			this.groupBoxActive.Controls.Add(this.labelP3TimeLeft);
			this.groupBoxActive.Controls.Add(this.labelP3Timer);
			this.groupBoxActive.Controls.Add(this.buttonExit);
			this.groupBoxActive.Controls.Add(this.buttonPause);
			this.groupBoxActive.Controls.Add(this.buttonSwitchPlayer);
			this.groupBoxActive.Controls.Add(this.labelP2TimeLeft);
			this.groupBoxActive.Controls.Add(this.labelP1TimeLeft);
			this.groupBoxActive.Controls.Add(this.labelP2Timer);
			this.groupBoxActive.Controls.Add(this.labelP1Timer);
			this.groupBoxActive.Location = new System.Drawing.Point(334, 12);
			this.groupBoxActive.Name = "groupBoxActive";
			this.groupBoxActive.Size = new System.Drawing.Size(308, 379);
			this.groupBoxActive.TabIndex = 1;
			this.groupBoxActive.TabStop = false;
			this.groupBoxActive.Text = "Active";
			this.groupBoxActive.Visible = false;
			// 
			// buttonTimerUp
			// 
			this.buttonTimerUp.Location = new System.Drawing.Point(6, 198);
			this.buttonTimerUp.Name = "buttonTimerUp";
			this.buttonTimerUp.Size = new System.Drawing.Size(295, 181);
			this.buttonTimerUp.TabIndex = 22;
			this.buttonTimerUp.Text = "END";
			this.buttonTimerUp.UseVisualStyleBackColor = true;
			this.buttonTimerUp.Visible = false;
			this.buttonTimerUp.Click += new System.EventHandler(this.ButtonTimerUpClick);
			// 
			// labelP4TimeLeft
			// 
			this.labelP4TimeLeft.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelP4TimeLeft.Location = new System.Drawing.Point(110, 153);
			this.labelP4TimeLeft.Name = "labelP4TimeLeft";
			this.labelP4TimeLeft.Size = new System.Drawing.Size(173, 48);
			this.labelP4TimeLeft.TabIndex = 27;
			this.labelP4TimeLeft.Text = "00:00:00";
			// 
			// labelP4Timer
			// 
			this.labelP4Timer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelP4Timer.Location = new System.Drawing.Point(16, 161);
			this.labelP4Timer.Name = "labelP4Timer";
			this.labelP4Timer.Size = new System.Drawing.Size(88, 23);
			this.labelP4Timer.TabIndex = 26;
			this.labelP4Timer.Text = "Player 4";
			// 
			// labelP3TimeLeft
			// 
			this.labelP3TimeLeft.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelP3TimeLeft.Location = new System.Drawing.Point(110, 110);
			this.labelP3TimeLeft.Name = "labelP3TimeLeft";
			this.labelP3TimeLeft.Size = new System.Drawing.Size(173, 48);
			this.labelP3TimeLeft.TabIndex = 25;
			this.labelP3TimeLeft.Text = "00:00:00";
			// 
			// labelP3Timer
			// 
			this.labelP3Timer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelP3Timer.Location = new System.Drawing.Point(16, 118);
			this.labelP3Timer.Name = "labelP3Timer";
			this.labelP3Timer.Size = new System.Drawing.Size(88, 23);
			this.labelP3Timer.TabIndex = 24;
			this.labelP3Timer.Text = "Player 3";
			// 
			// buttonExit
			// 
			this.buttonExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonExit.Location = new System.Drawing.Point(181, 300);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(102, 57);
			this.buttonExit.TabIndex = 23;
			this.buttonExit.Text = "EXIT";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
			// 
			// buttonPause
			// 
			this.buttonPause.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPause.Location = new System.Drawing.Point(16, 300);
			this.buttonPause.Name = "buttonPause";
			this.buttonPause.Size = new System.Drawing.Size(102, 57);
			this.buttonPause.TabIndex = 21;
			this.buttonPause.Text = "PAUSE";
			this.buttonPause.UseVisualStyleBackColor = true;
			this.buttonPause.Click += new System.EventHandler(this.ButtonPauseClick);
			// 
			// buttonSwitchPlayer
			// 
			this.buttonSwitchPlayer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSwitchPlayer.Location = new System.Drawing.Point(32, 202);
			this.buttonSwitchPlayer.Name = "buttonSwitchPlayer";
			this.buttonSwitchPlayer.Size = new System.Drawing.Size(231, 75);
			this.buttonSwitchPlayer.TabIndex = 20;
			this.buttonSwitchPlayer.Text = "SWITCH";
			this.buttonSwitchPlayer.UseVisualStyleBackColor = true;
			this.buttonSwitchPlayer.Click += new System.EventHandler(this.ButtonSwitchPlayerClick);
			// 
			// labelP2TimeLeft
			// 
			this.labelP2TimeLeft.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelP2TimeLeft.Location = new System.Drawing.Point(110, 66);
			this.labelP2TimeLeft.Name = "labelP2TimeLeft";
			this.labelP2TimeLeft.Size = new System.Drawing.Size(173, 48);
			this.labelP2TimeLeft.TabIndex = 19;
			this.labelP2TimeLeft.Text = "00:00:00";
			// 
			// labelP1TimeLeft
			// 
			this.labelP1TimeLeft.BackColor = System.Drawing.SystemColors.Control;
			this.labelP1TimeLeft.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelP1TimeLeft.Location = new System.Drawing.Point(110, 21);
			this.labelP1TimeLeft.Name = "labelP1TimeLeft";
			this.labelP1TimeLeft.Size = new System.Drawing.Size(173, 45);
			this.labelP1TimeLeft.TabIndex = 18;
			this.labelP1TimeLeft.Text = "00:00:00";
			// 
			// labelP2Timer
			// 
			this.labelP2Timer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelP2Timer.Location = new System.Drawing.Point(16, 74);
			this.labelP2Timer.Name = "labelP2Timer";
			this.labelP2Timer.Size = new System.Drawing.Size(88, 23);
			this.labelP2Timer.TabIndex = 17;
			this.labelP2Timer.Text = "Player 2";
			// 
			// labelP1Timer
			// 
			this.labelP1Timer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelP1Timer.Location = new System.Drawing.Point(16, 29);
			this.labelP1Timer.Name = "labelP1Timer";
			this.labelP1Timer.Size = new System.Drawing.Size(88, 23);
			this.labelP1Timer.TabIndex = 16;
			this.labelP1Timer.Text = "Player 1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 395);
			this.Controls.Add(this.groupBoxActive);
			this.Controls.Add(this.groupBoxSetup);
			this.Name = "MainForm";
			this.Text = "GameTimer";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).EndInit();
			this.groupBoxSetup.ResumeLayout(false);
			this.groupBoxSetup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPlayer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayers)).EndInit();
			this.groupBoxActive.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labelP3Timer;
		private System.Windows.Forms.Label labelP3TimeLeft;
		private System.Windows.Forms.Label labelP4Timer;
		private System.Windows.Forms.Label labelP4TimeLeft;
		private System.Windows.Forms.NumericUpDown numericUpDownPlayers;
		private System.Windows.Forms.NumericUpDown numericUpDownStartPlayer;
		private System.Windows.Forms.Label labelP3Name;
		private System.Windows.Forms.TextBox textBoxP3;
		private System.Windows.Forms.Label labelP4Name;
		private System.Windows.Forms.TextBox textBoxP4;
		private System.Windows.Forms.Label labelPlayerNumber;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonTimerUp;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label labelP1Timer;
		private System.Windows.Forms.Label labelP2Timer;
		private System.Windows.Forms.Label labelP1TimeLeft;
		private System.Windows.Forms.Label labelP2TimeLeft;
		private System.Windows.Forms.Button buttonSwitchPlayer;
		private System.Windows.Forms.Button buttonPause;
		private System.Windows.Forms.GroupBox groupBoxActive;
		private System.Windows.Forms.Label labelP1Name;
		private System.Windows.Forms.Label labelHour;
		private System.Windows.Forms.NumericUpDown numericUpDownH;
		private System.Windows.Forms.Label labelMin;
		private System.Windows.Forms.NumericUpDown numericUpDownM;
		private System.Windows.Forms.Label labelSec;
		private System.Windows.Forms.NumericUpDown numericUpDownS;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Label labelP2Name;
		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.GroupBox groupBoxSetup;
		private System.Windows.Forms.Label labelStartPlayer;
		private System.Windows.Forms.TextBox textBoxP2;
		private System.Windows.Forms.TextBox textBoxP1;
		
	}
}

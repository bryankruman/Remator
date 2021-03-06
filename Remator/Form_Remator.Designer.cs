﻿namespace Remator
{
	partial class Form_Remator
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.applicationGroupBox = new System.Windows.Forms.GroupBox();
			this.cpuUsageLabelInfo = new System.Windows.Forms.Label();
			this.statusLabelInfo = new System.Windows.Forms.Label();
			this.cpuUsageLabel = new System.Windows.Forms.Label();
			this.statusLabel = new System.Windows.Forms.Label();
			this.loggingButton = new System.Windows.Forms.Button();
			this.audioButton = new System.Windows.Forms.Button();
			this.accuracyLabel = new System.Windows.Forms.Label();
			this.accuracyTrackBar = new System.Windows.Forms.TrackBar();
			this.promptLabel = new System.Windows.Forms.Label();
			this.promptComboBox = new System.Windows.Forms.ComboBox();
			this.startButton = new System.Windows.Forms.Button();
			this.commandsButton = new System.Windows.Forms.Button();
			this.hideFromTaskbarCheckBox = new System.Windows.Forms.CheckBox();
			this.startupCheckBox = new System.Windows.Forms.CheckBox();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.websiteLinkLabel = new System.Windows.Forms.LinkLabel();
			this.cpuUpdateTimer = new System.Windows.Forms.Timer(this.components);
			this.applicationGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.accuracyTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// applicationGroupBox
			// 
			this.applicationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.applicationGroupBox.Controls.Add(this.cpuUsageLabelInfo);
			this.applicationGroupBox.Controls.Add(this.statusLabelInfo);
			this.applicationGroupBox.Controls.Add(this.cpuUsageLabel);
			this.applicationGroupBox.Controls.Add(this.statusLabel);
			this.applicationGroupBox.Controls.Add(this.loggingButton);
			this.applicationGroupBox.Controls.Add(this.audioButton);
			this.applicationGroupBox.Controls.Add(this.accuracyLabel);
			this.applicationGroupBox.Controls.Add(this.accuracyTrackBar);
			this.applicationGroupBox.Controls.Add(this.promptLabel);
			this.applicationGroupBox.Controls.Add(this.promptComboBox);
			this.applicationGroupBox.Controls.Add(this.startButton);
			this.applicationGroupBox.Controls.Add(this.commandsButton);
			this.applicationGroupBox.Controls.Add(this.hideFromTaskbarCheckBox);
			this.applicationGroupBox.Controls.Add(this.startupCheckBox);
			this.applicationGroupBox.Location = new System.Drawing.Point(12, 12);
			this.applicationGroupBox.Name = "applicationGroupBox";
			this.applicationGroupBox.Size = new System.Drawing.Size(334, 269);
			this.applicationGroupBox.TabIndex = 0;
			this.applicationGroupBox.TabStop = false;
			this.applicationGroupBox.Text = "Application";
			// 
			// cpuUsageLabelInfo
			// 
			this.cpuUsageLabelInfo.Location = new System.Drawing.Point(97, 81);
			this.cpuUsageLabelInfo.Name = "cpuUsageLabelInfo";
			this.cpuUsageLabelInfo.Size = new System.Drawing.Size(87, 13);
			this.cpuUsageLabelInfo.TabIndex = 15;
			this.cpuUsageLabelInfo.Text = "0%";
			this.cpuUsageLabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// statusLabelInfo
			// 
			this.statusLabelInfo.Location = new System.Drawing.Point(64, 63);
			this.statusLabelInfo.Name = "statusLabelInfo";
			this.statusLabelInfo.Size = new System.Drawing.Size(120, 13);
			this.statusLabelInfo.TabIndex = 13;
			this.statusLabelInfo.Text = "Paused";
			this.statusLabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cpuUsageLabel
			// 
			this.cpuUsageLabel.AutoSize = true;
			this.cpuUsageLabel.Location = new System.Drawing.Point(25, 81);
			this.cpuUsageLabel.Name = "cpuUsageLabel";
			this.cpuUsageLabel.Size = new System.Drawing.Size(66, 13);
			this.cpuUsageLabel.TabIndex = 12;
			this.cpuUsageLabel.Text = "CPU Usage:";
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Location = new System.Drawing.Point(25, 62);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(40, 13);
			this.statusLabel.TabIndex = 11;
			this.statusLabel.Text = "Status:";
			// 
			// loggingButton
			// 
			this.loggingButton.Enabled = false;
			this.loggingButton.Location = new System.Drawing.Point(205, 83);
			this.loggingButton.Name = "loggingButton";
			this.loggingButton.Size = new System.Drawing.Size(104, 23);
			this.loggingButton.TabIndex = 9;
			this.loggingButton.Text = "Logging";
			this.loggingButton.UseVisualStyleBackColor = true;
			// 
			// audioButton
			// 
			this.audioButton.Location = new System.Drawing.Point(205, 54);
			this.audioButton.Name = "audioButton";
			this.audioButton.Size = new System.Drawing.Size(104, 23);
			this.audioButton.TabIndex = 8;
			this.audioButton.Text = "Audio";
			this.audioButton.UseVisualStyleBackColor = true;
			this.audioButton.Click += new System.EventHandler(this.audioButton_Click);
			// 
			// accuracyLabel
			// 
			this.accuracyLabel.AutoSize = true;
			this.accuracyLabel.Location = new System.Drawing.Point(6, 218);
			this.accuracyLabel.Name = "accuracyLabel";
			this.accuracyLabel.Size = new System.Drawing.Size(101, 13);
			this.accuracyLabel.TabIndex = 7;
			this.accuracyLabel.Text = "Accuracy threshold:";
			// 
			// accuracyTrackBar
			// 
			this.accuracyTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accuracyTrackBar.Location = new System.Drawing.Point(157, 212);
			this.accuracyTrackBar.Name = "accuracyTrackBar";
			this.accuracyTrackBar.Size = new System.Drawing.Size(171, 45);
			this.accuracyTrackBar.TabIndex = 6;
			// 
			// promptLabel
			// 
			this.promptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.promptLabel.AutoSize = true;
			this.promptLabel.Location = new System.Drawing.Point(6, 188);
			this.promptLabel.Name = "promptLabel";
			this.promptLabel.Size = new System.Drawing.Size(107, 13);
			this.promptLabel.TabIndex = 6;
			this.promptLabel.Text = "Voice prompt phrase:";
			// 
			// promptComboBox
			// 
			this.promptComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.promptComboBox.FormattingEnabled = true;
			this.promptComboBox.Items.AddRange(new object[] {
            "None",
            "Mator",
            "Jarvis",
            "Computer"});
			this.promptComboBox.Location = new System.Drawing.Point(157, 185);
			this.promptComboBox.Name = "promptComboBox";
			this.promptComboBox.Size = new System.Drawing.Size(171, 21);
			this.promptComboBox.TabIndex = 5;
			// 
			// startButton
			// 
			this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.startButton.Location = new System.Drawing.Point(45, 25);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(120, 23);
			this.startButton.TabIndex = 4;
			this.startButton.Text = "Start Listening";
			this.startButton.UseVisualStyleBackColor = true;
			// 
			// commandsButton
			// 
			this.commandsButton.Location = new System.Drawing.Point(205, 25);
			this.commandsButton.Name = "commandsButton";
			this.commandsButton.Size = new System.Drawing.Size(104, 23);
			this.commandsButton.TabIndex = 0;
			this.commandsButton.Text = "Commands";
			this.commandsButton.UseVisualStyleBackColor = true;
			this.commandsButton.Click += new System.EventHandler(this.commandsButton_Click);
			// 
			// hideFromTaskbarCheckBox
			// 
			this.hideFromTaskbarCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hideFromTaskbarCheckBox.AutoSize = true;
			this.hideFromTaskbarCheckBox.Location = new System.Drawing.Point(9, 144);
			this.hideFromTaskbarCheckBox.Name = "hideFromTaskbarCheckBox";
			this.hideFromTaskbarCheckBox.Size = new System.Drawing.Size(109, 17);
			this.hideFromTaskbarCheckBox.TabIndex = 1;
			this.hideFromTaskbarCheckBox.Text = "Hide from taskbar";
			this.hideFromTaskbarCheckBox.UseVisualStyleBackColor = true;
			this.hideFromTaskbarCheckBox.CheckedChanged += new System.EventHandler(this.hideFromTaskbarCheckBox_CheckedChanged);
			// 
			// startupCheckBox
			// 
			this.startupCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.startupCheckBox.AutoSize = true;
			this.startupCheckBox.Location = new System.Drawing.Point(9, 121);
			this.startupCheckBox.Name = "startupCheckBox";
			this.startupCheckBox.Size = new System.Drawing.Size(147, 17);
			this.startupCheckBox.TabIndex = 0;
			this.startupCheckBox.Text = "Launch on system startup";
			this.startupCheckBox.UseVisualStyleBackColor = true;
			this.startupCheckBox.CheckedChanged += new System.EventHandler(this.startupCheckBox_CheckedChanged);
			// 
			// notifyIcon
			// 
			this.notifyIcon.Text = "notifyIcon1";
			this.notifyIcon.Visible = true;
			// 
			// websiteLinkLabel
			// 
			this.websiteLinkLabel.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
			this.websiteLinkLabel.LinkColor = System.Drawing.Color.Navy;
			this.websiteLinkLabel.Location = new System.Drawing.Point(12, 284);
			this.websiteLinkLabel.Name = "websiteLinkLabel";
			this.websiteLinkLabel.Size = new System.Drawing.Size(334, 30);
			this.websiteLinkLabel.TabIndex = 3;
			this.websiteLinkLabel.TabStop = true;
			this.websiteLinkLabel.Text = "Created by Bryan Kruman";
			this.websiteLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cpuUpdateTimer
			// 
			this.cpuUpdateTimer.Enabled = true;
			this.cpuUpdateTimer.Interval = 1000;
			this.cpuUpdateTimer.Tick += new System.EventHandler(this.cpuUpdateTimer_Tick);
			// 
			// Form_Remator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 323);
			this.Controls.Add(this.websiteLinkLabel);
			this.Controls.Add(this.applicationGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form_Remator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Remator";
			this.Load += new System.EventHandler(this.Remator_Load);
			this.applicationGroupBox.ResumeLayout(false);
			this.applicationGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.accuracyTrackBar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox applicationGroupBox;
		private System.Windows.Forms.CheckBox hideFromTaskbarCheckBox;
		private System.Windows.Forms.CheckBox startupCheckBox;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.Label promptLabel;
		private System.Windows.Forms.ComboBox promptComboBox;
		private System.Windows.Forms.Button commandsButton;
		private System.Windows.Forms.Label accuracyLabel;
		private System.Windows.Forms.TrackBar accuracyTrackBar;
		private System.Windows.Forms.Button loggingButton;
		private System.Windows.Forms.Button audioButton;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.LinkLabel websiteLinkLabel;
		private System.Windows.Forms.Label cpuUsageLabelInfo;
		private System.Windows.Forms.Label statusLabelInfo;
		private System.Windows.Forms.Label cpuUsageLabel;
		private System.Windows.Forms.Timer cpuUpdateTimer;
	}
}


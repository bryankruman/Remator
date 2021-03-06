﻿namespace Remator
{
	partial class Form_Audio
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.trackOutputSpeed = new System.Windows.Forms.TrackBar();
			this.label6 = new System.Windows.Forms.Label();
			this.comboOutputVoice = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboOutputDevice = new System.Windows.Forms.ComboBox();
			this.trackOutputVolume = new System.Windows.Forms.TrackBar();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.inputMeter = new System.Windows.Forms.ProgressBar();
			this.trackInputGain = new System.Windows.Forms.TrackBar();
			this.comboInputDevice = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonConfirm = new System.Windows.Forms.Button();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackOutputSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackOutputVolume)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackInputGain)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.trackOutputSpeed);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.comboOutputVoice);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.comboOutputDevice);
			this.groupBox3.Location = new System.Drawing.Point(12, 149);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(342, 181);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Output";
			// 
			// trackOutputSpeed
			// 
			this.trackOutputSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.trackOutputSpeed.Location = new System.Drawing.Point(100, 73);
			this.trackOutputSpeed.Name = "trackOutputSpeed";
			this.trackOutputSpeed.Size = new System.Drawing.Size(236, 45);
			this.trackOutputSpeed.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Speed:";
			// 
			// comboOutputVoice
			// 
			this.comboOutputVoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboOutputVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboOutputVoice.FormattingEnabled = true;
			this.comboOutputVoice.Location = new System.Drawing.Point(100, 46);
			this.comboOutputVoice.Name = "comboOutputVoice";
			this.comboOutputVoice.Size = new System.Drawing.Size(236, 21);
			this.comboOutputVoice.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Voice:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Device:";
			// 
			// comboOutputDevice
			// 
			this.comboOutputDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboOutputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboOutputDevice.Enabled = false;
			this.comboOutputDevice.FormattingEnabled = true;
			this.comboOutputDevice.Location = new System.Drawing.Point(100, 19);
			this.comboOutputDevice.Name = "comboOutputDevice";
			this.comboOutputDevice.Size = new System.Drawing.Size(236, 21);
			this.comboOutputDevice.TabIndex = 6;
			// 
			// trackOutputVolume
			// 
			this.trackOutputVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.trackOutputVolume.Location = new System.Drawing.Point(112, 273);
			this.trackOutputVolume.Name = "trackOutputVolume";
			this.trackOutputVolume.Size = new System.Drawing.Size(236, 45);
			this.trackOutputVolume.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(18, 273);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Volume:";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.inputMeter);
			this.groupBox2.Controls.Add(this.trackInputGain);
			this.groupBox2.Controls.Add(this.comboInputDevice);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(342, 131);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Input";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Gain:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Meter:";
			// 
			// inputMeter
			// 
			this.inputMeter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inputMeter.Location = new System.Drawing.Point(100, 44);
			this.inputMeter.Name = "inputMeter";
			this.inputMeter.Size = new System.Drawing.Size(236, 23);
			this.inputMeter.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.inputMeter.TabIndex = 3;
			// 
			// trackInputGain
			// 
			this.trackInputGain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.trackInputGain.Location = new System.Drawing.Point(100, 80);
			this.trackInputGain.Name = "trackInputGain";
			this.trackInputGain.Size = new System.Drawing.Size(236, 45);
			this.trackInputGain.TabIndex = 2;
			// 
			// comboInputDevice
			// 
			this.comboInputDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboInputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboInputDevice.Enabled = false;
			this.comboInputDevice.FormattingEnabled = true;
			this.comboInputDevice.Location = new System.Drawing.Point(100, 17);
			this.comboInputDevice.Name = "comboInputDevice";
			this.comboInputDevice.Size = new System.Drawing.Size(236, 21);
			this.comboInputDevice.TabIndex = 1;
			this.comboInputDevice.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboInputDevice_Format);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Device:";
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(279, 336);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonConfirm
			// 
			this.buttonConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonConfirm.Location = new System.Drawing.Point(198, 336);
			this.buttonConfirm.Name = "buttonConfirm";
			this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
			this.buttonConfirm.TabIndex = 9;
			this.buttonConfirm.Text = "Confirm";
			this.buttonConfirm.UseVisualStyleBackColor = true;
			// 
			// Form_Audio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 371);
			this.Controls.Add(this.buttonConfirm);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.trackOutputVolume);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_Audio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Remator Audio Settings";
			this.Load += new System.EventHandler(this.Audio_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackOutputSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackOutputVolume)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackInputGain)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TrackBar trackOutputVolume;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboOutputVoice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboOutputDevice;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ProgressBar inputMeter;
		private System.Windows.Forms.TrackBar trackInputGain;
		private System.Windows.Forms.ComboBox comboInputDevice;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonConfirm;
		private System.Windows.Forms.TrackBar trackOutputSpeed;
		private System.Windows.Forms.Label label6;
	}
}
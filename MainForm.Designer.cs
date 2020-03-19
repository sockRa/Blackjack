namespace Blackjack
{
	partial class MainForm
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
			this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.Player1SplitContainer = new System.Windows.Forms.SplitContainer();
			this.Player1HitButton = new System.Windows.Forms.Button();
			this.Player1StayButton = new System.Windows.Forms.Button();
			this.Player2SplitContainer = new System.Windows.Forms.SplitContainer();
			this.Player2HitButton = new System.Windows.Forms.Button();
			this.Player2StayButton = new System.Windows.Forms.Button();
			this.Player1Panel = new System.Windows.Forms.Panel();
			this.Player2Panel = new System.Windows.Forms.Panel();
			this.Player1ScorePanel = new System.Windows.Forms.Panel();
			this.Player2ScorePanel = new System.Windows.Forms.Panel();
			this.Player1ScoreLabel = new System.Windows.Forms.Label();
			this.Player2ScoreLabel = new System.Windows.Forms.Label();
			this.Player1Label = new System.Windows.Forms.Label();
			this.Player2Label = new System.Windows.Forms.Label();
			this.Player1CardPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.Player2CardPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.Player1ScoreText = new System.Windows.Forms.Label();
			this.Player2ScoreText = new System.Windows.Forms.Label();
			this.MainTableLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Player1SplitContainer)).BeginInit();
			this.Player1SplitContainer.Panel1.SuspendLayout();
			this.Player1SplitContainer.Panel2.SuspendLayout();
			this.Player1SplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Player2SplitContainer)).BeginInit();
			this.Player2SplitContainer.Panel1.SuspendLayout();
			this.Player2SplitContainer.Panel2.SuspendLayout();
			this.Player2SplitContainer.SuspendLayout();
			this.Player1Panel.SuspendLayout();
			this.Player2Panel.SuspendLayout();
			this.Player1ScorePanel.SuspendLayout();
			this.Player2ScorePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainTableLayout
			// 
			this.MainTableLayout.ColumnCount = 3;
			this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.MainTableLayout.Controls.Add(this.Player1SplitContainer, 2, 0);
			this.MainTableLayout.Controls.Add(this.Player2SplitContainer, 2, 1);
			this.MainTableLayout.Controls.Add(this.Player1Panel, 0, 0);
			this.MainTableLayout.Controls.Add(this.Player2Panel, 0, 1);
			this.MainTableLayout.Controls.Add(this.Player1ScorePanel, 1, 0);
			this.MainTableLayout.Controls.Add(this.Player2ScorePanel, 1, 1);
			this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
			this.MainTableLayout.Name = "MainTableLayout";
			this.MainTableLayout.RowCount = 2;
			this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.MainTableLayout.Size = new System.Drawing.Size(707, 375);
			this.MainTableLayout.TabIndex = 0;
			// 
			// Player1SplitContainer
			// 
			this.Player1SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Player1SplitContainer.Location = new System.Drawing.Point(610, 3);
			this.Player1SplitContainer.Name = "Player1SplitContainer";
			this.Player1SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// Player1SplitContainer.Panel1
			// 
			this.Player1SplitContainer.Panel1.Controls.Add(this.Player1HitButton);
			// 
			// Player1SplitContainer.Panel2
			// 
			this.Player1SplitContainer.Panel2.Controls.Add(this.Player1StayButton);
			this.Player1SplitContainer.Size = new System.Drawing.Size(94, 181);
			this.Player1SplitContainer.SplitterDistance = 84;
			this.Player1SplitContainer.TabIndex = 0;
			// 
			// Player1HitButton
			// 
			this.Player1HitButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Player1HitButton.Location = new System.Drawing.Point(0, 0);
			this.Player1HitButton.Name = "Player1HitButton";
			this.Player1HitButton.Size = new System.Drawing.Size(94, 84);
			this.Player1HitButton.TabIndex = 0;
			this.Player1HitButton.Text = "Hit";
			this.Player1HitButton.UseVisualStyleBackColor = true;
			// 
			// Player1StayButton
			// 
			this.Player1StayButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Player1StayButton.Location = new System.Drawing.Point(0, 0);
			this.Player1StayButton.Name = "Player1StayButton";
			this.Player1StayButton.Size = new System.Drawing.Size(94, 93);
			this.Player1StayButton.TabIndex = 0;
			this.Player1StayButton.Text = "Stay";
			this.Player1StayButton.UseVisualStyleBackColor = true;
			// 
			// Player2SplitContainer
			// 
			this.Player2SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Player2SplitContainer.Location = new System.Drawing.Point(610, 190);
			this.Player2SplitContainer.Name = "Player2SplitContainer";
			this.Player2SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// Player2SplitContainer.Panel1
			// 
			this.Player2SplitContainer.Panel1.Controls.Add(this.Player2HitButton);
			// 
			// Player2SplitContainer.Panel2
			// 
			this.Player2SplitContainer.Panel2.Controls.Add(this.Player2StayButton);
			this.Player2SplitContainer.Size = new System.Drawing.Size(94, 182);
			this.Player2SplitContainer.SplitterDistance = 84;
			this.Player2SplitContainer.TabIndex = 1;
			// 
			// Player2HitButton
			// 
			this.Player2HitButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Player2HitButton.Location = new System.Drawing.Point(0, 0);
			this.Player2HitButton.Name = "Player2HitButton";
			this.Player2HitButton.Size = new System.Drawing.Size(94, 84);
			this.Player2HitButton.TabIndex = 0;
			this.Player2HitButton.Text = "Hit";
			this.Player2HitButton.UseVisualStyleBackColor = true;
			// 
			// Player2StayButton
			// 
			this.Player2StayButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Player2StayButton.Location = new System.Drawing.Point(0, 0);
			this.Player2StayButton.Name = "Player2StayButton";
			this.Player2StayButton.Size = new System.Drawing.Size(94, 94);
			this.Player2StayButton.TabIndex = 0;
			this.Player2StayButton.Text = "Stay";
			this.Player2StayButton.UseVisualStyleBackColor = true;
			// 
			// Player1Panel
			// 
			this.Player1Panel.Controls.Add(this.Player1CardPanel);
			this.Player1Panel.Controls.Add(this.Player1Label);
			this.Player1Panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Player1Panel.Location = new System.Drawing.Point(3, 3);
			this.Player1Panel.Name = "Player1Panel";
			this.Player1Panel.Size = new System.Drawing.Size(501, 181);
			this.Player1Panel.TabIndex = 2;
			// 
			// Player2Panel
			// 
			this.Player2Panel.Controls.Add(this.Player2CardPanel);
			this.Player2Panel.Controls.Add(this.Player2Label);
			this.Player2Panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Player2Panel.Location = new System.Drawing.Point(3, 190);
			this.Player2Panel.Name = "Player2Panel";
			this.Player2Panel.Size = new System.Drawing.Size(501, 182);
			this.Player2Panel.TabIndex = 3;
			// 
			// Player1ScorePanel
			// 
			this.Player1ScorePanel.Controls.Add(this.Player1ScoreText);
			this.Player1ScorePanel.Controls.Add(this.Player1ScoreLabel);
			this.Player1ScorePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Player1ScorePanel.Location = new System.Drawing.Point(510, 3);
			this.Player1ScorePanel.Name = "Player1ScorePanel";
			this.Player1ScorePanel.Size = new System.Drawing.Size(94, 181);
			this.Player1ScorePanel.TabIndex = 4;
			// 
			// Player2ScorePanel
			// 
			this.Player2ScorePanel.Controls.Add(this.Player2ScoreText);
			this.Player2ScorePanel.Controls.Add(this.Player2ScoreLabel);
			this.Player2ScorePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Player2ScorePanel.Location = new System.Drawing.Point(510, 190);
			this.Player2ScorePanel.Name = "Player2ScorePanel";
			this.Player2ScorePanel.Size = new System.Drawing.Size(94, 182);
			this.Player2ScorePanel.TabIndex = 5;
			// 
			// Player1ScoreLabel
			// 
			this.Player1ScoreLabel.AutoSize = true;
			this.Player1ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Player1ScoreLabel.Location = new System.Drawing.Point(0, 0);
			this.Player1ScoreLabel.Name = "Player1ScoreLabel";
			this.Player1ScoreLabel.Size = new System.Drawing.Size(75, 26);
			this.Player1ScoreLabel.TabIndex = 0;
			this.Player1ScoreLabel.Text = "Score:";
			// 
			// Player2ScoreLabel
			// 
			this.Player2ScoreLabel.AutoSize = true;
			this.Player2ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Player2ScoreLabel.Location = new System.Drawing.Point(0, 0);
			this.Player2ScoreLabel.Name = "Player2ScoreLabel";
			this.Player2ScoreLabel.Size = new System.Drawing.Size(75, 26);
			this.Player2ScoreLabel.TabIndex = 1;
			this.Player2ScoreLabel.Text = "Score:";
			// 
			// Player1Label
			// 
			this.Player1Label.AutoSize = true;
			this.Player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Player1Label.Location = new System.Drawing.Point(3, 6);
			this.Player1Label.Name = "Player1Label";
			this.Player1Label.Size = new System.Drawing.Size(86, 26);
			this.Player1Label.TabIndex = 1;
			this.Player1Label.Text = "Player1";
			// 
			// Player2Label
			// 
			this.Player2Label.AutoSize = true;
			this.Player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Player2Label.Location = new System.Drawing.Point(3, 0);
			this.Player2Label.Name = "Player2Label";
			this.Player2Label.Size = new System.Drawing.Size(86, 26);
			this.Player2Label.TabIndex = 1;
			this.Player2Label.Text = "Player2";
			// 
			// Player1CardPanel
			// 
			this.Player1CardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Player1CardPanel.Location = new System.Drawing.Point(0, 35);
			this.Player1CardPanel.Name = "Player1CardPanel";
			this.Player1CardPanel.Size = new System.Drawing.Size(501, 149);
			this.Player1CardPanel.TabIndex = 2;
			// 
			// Player2CardPanel
			// 
			this.Player2CardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Player2CardPanel.Location = new System.Drawing.Point(3, 29);
			this.Player2CardPanel.Name = "Player2CardPanel";
			this.Player2CardPanel.Size = new System.Drawing.Size(498, 150);
			this.Player2CardPanel.TabIndex = 3;
			// 
			// Player1ScoreText
			// 
			this.Player1ScoreText.AutoSize = true;
			this.Player1ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Player1ScoreText.Location = new System.Drawing.Point(5, 35);
			this.Player1ScoreText.Name = "Player1ScoreText";
			this.Player1ScoreText.Size = new System.Drawing.Size(30, 31);
			this.Player1ScoreText.TabIndex = 1;
			this.Player1ScoreText.Text = "0";
			// 
			// Player2ScoreText
			// 
			this.Player2ScoreText.AutoSize = true;
			this.Player2ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Player2ScoreText.Location = new System.Drawing.Point(5, 29);
			this.Player2ScoreText.Name = "Player2ScoreText";
			this.Player2ScoreText.Size = new System.Drawing.Size(30, 31);
			this.Player2ScoreText.TabIndex = 2;
			this.Player2ScoreText.Text = "0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 375);
			this.Controls.Add(this.MainTableLayout);
			this.MinimumSize = new System.Drawing.Size(390, 187);
			this.Name = "MainForm";
			this.Text = "Black Jack";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MainTableLayout.ResumeLayout(false);
			this.Player1SplitContainer.Panel1.ResumeLayout(false);
			this.Player1SplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Player1SplitContainer)).EndInit();
			this.Player1SplitContainer.ResumeLayout(false);
			this.Player2SplitContainer.Panel1.ResumeLayout(false);
			this.Player2SplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Player2SplitContainer)).EndInit();
			this.Player2SplitContainer.ResumeLayout(false);
			this.Player1Panel.ResumeLayout(false);
			this.Player1Panel.PerformLayout();
			this.Player2Panel.ResumeLayout(false);
			this.Player2Panel.PerformLayout();
			this.Player1ScorePanel.ResumeLayout(false);
			this.Player1ScorePanel.PerformLayout();
			this.Player2ScorePanel.ResumeLayout(false);
			this.Player2ScorePanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel MainTableLayout;
		private System.Windows.Forms.SplitContainer Player1SplitContainer;
		private System.Windows.Forms.Button Player1HitButton;
		private System.Windows.Forms.Button Player1StayButton;
		private System.Windows.Forms.SplitContainer Player2SplitContainer;
		private System.Windows.Forms.Button Player2HitButton;
		private System.Windows.Forms.Button Player2StayButton;
		private System.Windows.Forms.Panel Player1Panel;
		private System.Windows.Forms.Label Player1Label;
		private System.Windows.Forms.Panel Player2Panel;
		private System.Windows.Forms.Label Player2Label;
		private System.Windows.Forms.Panel Player1ScorePanel;
		private System.Windows.Forms.Label Player1ScoreLabel;
		private System.Windows.Forms.Panel Player2ScorePanel;
		private System.Windows.Forms.Label Player2ScoreLabel;
		private System.Windows.Forms.FlowLayoutPanel Player1CardPanel;
		private System.Windows.Forms.FlowLayoutPanel Player2CardPanel;
		private System.Windows.Forms.Label Player1ScoreText;
		private System.Windows.Forms.Label Player2ScoreText;
	}
}


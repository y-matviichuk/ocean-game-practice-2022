namespace WinFormsOcean
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelGame = new System.Windows.Forms.Label();
            this.labelStatistic = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textObstacles = new System.Windows.Forms.TextBox();
            this.textPredators = new System.Windows.Forms.TextBox();
            this.textPreys = new System.Windows.Forms.TextBox();
            this.textOperations = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGame
            // 
            this.labelGame.AutoSize = true;
            this.labelGame.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGame.Location = new System.Drawing.Point(30, 48);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(0, 19);
            this.labelGame.TabIndex = 0;
            // 
            // labelStatistic
            // 
            this.labelStatistic.AutoSize = true;
            this.labelStatistic.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatistic.Location = new System.Drawing.Point(819, 470);
            this.labelStatistic.Name = "labelStatistic";
            this.labelStatistic.Size = new System.Drawing.Size(0, 18);
            this.labelStatistic.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(834, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Obstacles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(833, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Predators";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(833, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preys";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(833, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Operations";
            // 
            // textObstacles
            // 
            this.textObstacles.Location = new System.Drawing.Point(828, 69);
            this.textObstacles.Name = "textObstacles";
            this.textObstacles.Size = new System.Drawing.Size(120, 23);
            this.textObstacles.TabIndex = 6;
            // 
            // textPredators
            // 
            this.textPredators.Location = new System.Drawing.Point(828, 124);
            this.textPredators.Name = "textPredators";
            this.textPredators.Size = new System.Drawing.Size(120, 23);
            this.textPredators.TabIndex = 7;
            // 
            // textPreys
            // 
            this.textPreys.Location = new System.Drawing.Point(828, 177);
            this.textPreys.Name = "textPreys";
            this.textPreys.Size = new System.Drawing.Size(120, 23);
            this.textPreys.TabIndex = 8;
            // 
            // textOperations
            // 
            this.textOperations.Location = new System.Drawing.Point(828, 230);
            this.textOperations.Name = "textOperations";
            this.textOperations.Size = new System.Drawing.Size(120, 23);
            this.textOperations.TabIndex = 9;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playButton.Location = new System.Drawing.Point(828, 278);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(120, 41);
            this.playButton.TabIndex = 10;
            this.playButton.Text = "Play Game";
            this.playButton.UseVisualStyleBackColor = false;
            // 
            // endButton
            // 
            this.endButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endButton.Location = new System.Drawing.Point(828, 371);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(120, 39);
            this.endButton.TabIndex = 11;
            this.endButton.Text = "End Game";
            this.endButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settingsButton.Location = new System.Drawing.Point(828, 325);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(120, 40);
            this.settingsButton.TabIndex = 12;
            this.settingsButton.Text = "Set Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pauseButton.Location = new System.Drawing.Point(828, 416);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(120, 38);
            this.pauseButton.TabIndex = 13;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 673);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.textOperations);
            this.Controls.Add(this.textPreys);
            this.Controls.Add(this.textPredators);
            this.Controls.Add(this.textObstacles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelStatistic);
            this.Controls.Add(this.labelGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelGame;
        private Label labelStatistic;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textObstacles;
        private TextBox textPredators;
        private TextBox textPreys;
        private TextBox textOperations;
        private Button playButton;
        private Button endButton;
        private Button settingsButton;
        private Button pauseButton;
    }
}
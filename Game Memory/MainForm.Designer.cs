namespace Game_Memory
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelFinalTime = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerStopwatch = new System.Windows.Forms.Timer(this.components);
            this.userName = new System.Windows.Forms.TextBox();
            this.labelFinalName = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelEnterTheName = new System.Windows.Forms.Label();
            this.labelFinalScore = new System.Windows.Forms.Label();
            this.labelDefeat = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFinalTime
            // 
            this.labelFinalTime.AutoSize = true;
            this.labelFinalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalTime.ForeColor = System.Drawing.Color.White;
            this.labelFinalTime.Location = new System.Drawing.Point(1250, 750);
            this.labelFinalTime.Name = "labelFinalTime";
            this.labelFinalTime.Size = new System.Drawing.Size(122, 44);
            this.labelFinalTime.TabIndex = 1;
            this.labelFinalTime.Text = "Time:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(154, 750);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(42, 44);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "0";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(1389, 750);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(42, 44);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "0";
            // 
            // timerStopwatch
            // 
            this.timerStopwatch.Tick += new System.EventHandler(this.timer_Stopwatch);
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(98, 28);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(128, 22);
            this.userName.TabIndex = 4;
            // 
            // labelFinalName
            // 
            this.labelFinalName.AutoSize = true;
            this.labelFinalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalName.Location = new System.Drawing.Point(43, 31);
            this.labelFinalName.Name = "labelFinalName";
            this.labelFinalName.Size = new System.Drawing.Size(54, 17);
            this.labelFinalName.TabIndex = 5;
            this.labelFinalName.Text = "Name:";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(243, 27);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.button_Start);
            // 
            // labelEnterTheName
            // 
            this.labelEnterTheName.AutoSize = true;
            this.labelEnterTheName.Location = new System.Drawing.Point(109, 9);
            this.labelEnterTheName.Name = "labelEnterTheName";
            this.labelEnterTheName.Size = new System.Drawing.Size(0, 17);
            this.labelEnterTheName.TabIndex = 7;
            // 
            // labelFinalScore
            // 
            this.labelFinalScore.AutoSize = true;
            this.labelFinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalScore.Location = new System.Drawing.Point(12, 750);
            this.labelFinalScore.Name = "labelFinalScore";
            this.labelFinalScore.Size = new System.Drawing.Size(136, 44);
            this.labelFinalScore.TabIndex = 8;
            this.labelFinalScore.Text = "Score:";
            // 
            // labelDefeat
            // 
            this.labelDefeat.AutoSize = true;
            this.labelDefeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefeat.ForeColor = System.Drawing.Color.DarkSalmon;
            this.labelDefeat.Location = new System.Drawing.Point(620, 171);
            this.labelDefeat.Name = "labelDefeat";
            this.labelDefeat.Size = new System.Drawing.Size(89, 135);
            this.labelDefeat.TabIndex = 9;
            this.labelDefeat.Text = "|";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.Location = new System.Drawing.Point(734, 9);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(89, 32);
            this.labelLevel.TabIndex = 10;
            this.labelLevel.Text = "Level";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1581, 803);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelDefeat);
            this.Controls.Add(this.labelFinalScore);
            this.Controls.Add(this.labelEnterTheName);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelFinalName);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelFinalTime);
            this.ForeColor = System.Drawing.Color.GhostWhite;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flag memory game";
            this.Click += new System.EventHandler(this.imagem_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFinalTime;
        private System.Windows.Forms.Label labelScore;
        public System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerStopwatch;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label labelFinalName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelEnterTheName;
        private System.Windows.Forms.Label labelFinalScore;
        private System.Windows.Forms.Label labelDefeat;
        private System.Windows.Forms.Label labelLevel;
    }
}


namespace Unplanetary_Wars
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCharName = new System.Windows.Forms.Label();
            this.lblCharHP = new System.Windows.Forms.Label();
            this.lblCharMP = new System.Windows.Forms.Label();
            this.lblCharXP = new System.Windows.Forms.Label();
            this.lblCharLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCharMoney = new System.Windows.Forms.Label();
            this.lblCurrentLocal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Health Points:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mana Points:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Experience:";
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.Location = new System.Drawing.Point(105, 9);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(13, 13);
            this.lblCharName.TabIndex = 4;
            this.lblCharName.Text = "--";
            // 
            // lblCharHP
            // 
            this.lblCharHP.AutoSize = true;
            this.lblCharHP.Location = new System.Drawing.Point(105, 23);
            this.lblCharHP.Name = "lblCharHP";
            this.lblCharHP.Size = new System.Drawing.Size(48, 13);
            this.lblCharHP.TabIndex = 5;
            this.lblCharHP.Text = "000/000";
            // 
            // lblCharMP
            // 
            this.lblCharMP.AutoSize = true;
            this.lblCharMP.Location = new System.Drawing.Point(105, 37);
            this.lblCharMP.Name = "lblCharMP";
            this.lblCharMP.Size = new System.Drawing.Size(48, 13);
            this.lblCharMP.TabIndex = 6;
            this.lblCharMP.Text = "000/000";
            // 
            // lblCharXP
            // 
            this.lblCharXP.AutoSize = true;
            this.lblCharXP.Location = new System.Drawing.Point(105, 51);
            this.lblCharXP.Name = "lblCharXP";
            this.lblCharXP.Size = new System.Drawing.Size(48, 13);
            this.lblCharXP.TabIndex = 7;
            this.lblCharXP.Text = "000/000";
            // 
            // lblCharLevel
            // 
            this.lblCharLevel.AutoSize = true;
            this.lblCharLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharLevel.Location = new System.Drawing.Point(187, 32);
            this.lblCharLevel.Name = "lblCharLevel";
            this.lblCharLevel.Size = new System.Drawing.Size(36, 25);
            this.lblCharLevel.TabIndex = 8;
            this.lblCharLevel.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(177, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(249, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Money";
            // 
            // lblCharMoney
            // 
            this.lblCharMoney.AutoSize = true;
            this.lblCharMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCharMoney.Location = new System.Drawing.Point(255, 36);
            this.lblCharMoney.Name = "lblCharMoney";
            this.lblCharMoney.Size = new System.Drawing.Size(54, 17);
            this.lblCharMoney.TabIndex = 11;
            this.lblCharMoney.Text = "0 | 0 | 0";
            // 
            // lblCurrentLocal
            // 
            this.lblCurrentLocal.AutoSize = true;
            this.lblCurrentLocal.Location = new System.Drawing.Point(12, 103);
            this.lblCurrentLocal.Name = "lblCurrentLocal";
            this.lblCurrentLocal.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentLocal.TabIndex = 12;
            this.lblCurrentLocal.Text = "--";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "+20 hex";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 125);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCurrentLocal);
            this.Controls.Add(this.lblCharMoney);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCharLevel);
            this.Controls.Add(this.lblCharXP);
            this.Controls.Add(this.lblCharMP);
            this.Controls.Add(this.lblCharHP);
            this.Controls.Add(this.lblCharName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.Label lblCharHP;
        private System.Windows.Forms.Label lblCharMP;
        private System.Windows.Forms.Label lblCharXP;
        private System.Windows.Forms.Label lblCharLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCharMoney;
        private System.Windows.Forms.Label lblCurrentLocal;
        private System.Windows.Forms.Button button1;
    }
}


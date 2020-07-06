namespace WF_Appli4
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.bAjoute = new System.Windows.Forms.Button();
            this.bRemplirCb2 = new System.Windows.Forms.Button();
            this.bActive = new System.Windows.Forms.Button();
            this.bDesactive = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.bVitesse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rome - Italie",
            "Bruxelless - Belgique",
            "Paris - France",
            "Berlin - Allemagne",
            "Londres - Angleterre"});
            this.comboBox1.Location = new System.Drawing.Point(61, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(501, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(217, 28);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(423, 203);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(423, 117);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 26);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 203);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(298, 26);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(61, 117);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(298, 26);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(279, 296);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(230, 26);
            this.textBox5.TabIndex = 6;
            // 
            // bAjoute
            // 
            this.bAjoute.Location = new System.Drawing.Point(587, 349);
            this.bAjoute.Name = "bAjoute";
            this.bAjoute.Size = new System.Drawing.Size(122, 42);
            this.bAjoute.TabIndex = 7;
            this.bAjoute.Text = "bAjoute";
            this.bAjoute.UseVisualStyleBackColor = true;
            this.bAjoute.Click += new System.EventHandler(this.bAjoute_Click);
            // 
            // bRemplirCb2
            // 
            this.bRemplirCb2.Location = new System.Drawing.Point(61, 349);
            this.bRemplirCb2.Name = "bRemplirCb2";
            this.bRemplirCb2.Size = new System.Drawing.Size(112, 42);
            this.bRemplirCb2.TabIndex = 8;
            this.bRemplirCb2.Text = "bRemplirCb2";
            this.bRemplirCb2.UseVisualStyleBackColor = true;
            this.bRemplirCb2.Click += new System.EventHandler(this.bRemplirCb2_Click);
            // 
            // bActive
            // 
            this.bActive.Location = new System.Drawing.Point(587, 281);
            this.bActive.Name = "bActive";
            this.bActive.Size = new System.Drawing.Size(122, 41);
            this.bActive.TabIndex = 9;
            this.bActive.Text = "bActive";
            this.bActive.UseVisualStyleBackColor = true;
            this.bActive.Click += new System.EventHandler(this.bActive_Click);
            // 
            // bDesactive
            // 
            this.bDesactive.Location = new System.Drawing.Point(61, 281);
            this.bDesactive.Name = "bDesactive";
            this.bDesactive.Size = new System.Drawing.Size(112, 41);
            this.bDesactive.TabIndex = 10;
            this.bDesactive.Text = "bDesactive";
            this.bDesactive.UseVisualStyleBackColor = true;
            this.bDesactive.Click += new System.EventHandler(this.bDesactive_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(239, 162);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(295, 26);
            this.textBox6.TabIndex = 11;
            // 
            // bVitesse
            // 
            this.bVitesse.Location = new System.Drawing.Point(332, 349);
            this.bVitesse.Name = "bVitesse";
            this.bVitesse.Size = new System.Drawing.Size(112, 42);
            this.bVitesse.TabIndex = 12;
            this.bVitesse.Text = "bVitesse";
            this.bVitesse.UseVisualStyleBackColor = true;
            this.bVitesse.Click += new System.EventHandler(this.bVitesse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bVitesse);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.bDesactive);
            this.Controls.Add(this.bActive);
            this.Controls.Add(this.bRemplirCb2);
            this.Controls.Add(this.bAjoute);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button bAjoute;
        private System.Windows.Forms.Button bRemplirCb2;
        private System.Windows.Forms.Button bActive;
        private System.Windows.Forms.Button bDesactive;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button bVitesse;
    }
}


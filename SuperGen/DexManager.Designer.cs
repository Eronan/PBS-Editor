namespace SuperGen
{
    partial class DexManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DexManager));
            this.pokedexBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_AddDex = new System.Windows.Forms.Button();
            this.button_RemoveDex = new System.Windows.Forms.Button();
            this.button_RemoveEntry = new System.Windows.Forms.Button();
            this.button_AddEntry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.entriesBox = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pokedexBox
            // 
            this.pokedexBox.FormattingEnabled = true;
            this.pokedexBox.Location = new System.Drawing.Point(4, 20);
            this.pokedexBox.Name = "pokedexBox";
            this.pokedexBox.Size = new System.Drawing.Size(120, 238);
            this.pokedexBox.TabIndex = 0;
            this.pokedexBox.SelectedIndexChanged += new System.EventHandler(this.pokedexBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pokedexes";
            // 
            // button_AddDex
            // 
            this.button_AddDex.Location = new System.Drawing.Point(4, 258);
            this.button_AddDex.Name = "button_AddDex";
            this.button_AddDex.Size = new System.Drawing.Size(121, 23);
            this.button_AddDex.TabIndex = 2;
            this.button_AddDex.Text = "Add Pokédex";
            this.button_AddDex.UseVisualStyleBackColor = true;
            this.button_AddDex.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_RemoveDex
            // 
            this.button_RemoveDex.Location = new System.Drawing.Point(4, 280);
            this.button_RemoveDex.Name = "button_RemoveDex";
            this.button_RemoveDex.Size = new System.Drawing.Size(121, 23);
            this.button_RemoveDex.TabIndex = 3;
            this.button_RemoveDex.Text = "Remove Pokédex";
            this.button_RemoveDex.UseVisualStyleBackColor = true;
            this.button_RemoveDex.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_RemoveEntry
            // 
            this.button_RemoveEntry.Location = new System.Drawing.Point(127, 255);
            this.button_RemoveEntry.Name = "button_RemoveEntry";
            this.button_RemoveEntry.Size = new System.Drawing.Size(122, 23);
            this.button_RemoveEntry.TabIndex = 7;
            this.button_RemoveEntry.Text = "Remove Entry";
            this.button_RemoveEntry.UseVisualStyleBackColor = true;
            this.button_RemoveEntry.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_AddEntry
            // 
            this.button_AddEntry.Location = new System.Drawing.Point(127, 233);
            this.button_AddEntry.Name = "button_AddEntry";
            this.button_AddEntry.Size = new System.Drawing.Size(122, 23);
            this.button_AddEntry.TabIndex = 6;
            this.button_AddEntry.Text = "Add Entry";
            this.button_AddEntry.UseVisualStyleBackColor = true;
            this.button_AddEntry.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pokedex Entries";
            // 
            // entriesBox
            // 
            this.entriesBox.FormattingEnabled = true;
            this.entriesBox.Location = new System.Drawing.Point(128, 20);
            this.entriesBox.Name = "entriesBox";
            this.entriesBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.entriesBox.Size = new System.Drawing.Size(120, 212);
            this.entriesBox.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 296);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Species:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pokédex Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Index:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(183, 321);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DexManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 346);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_RemoveEntry);
            this.Controls.Add(this.button_AddEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entriesBox);
            this.Controls.Add(this.button_RemoveDex);
            this.Controls.Add(this.button_AddDex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pokedexBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(268, 385);
            this.MinimumSize = new System.Drawing.Size(268, 385);
            this.Name = "DexManager";
            this.ShowIcon = false;
            this.Text = "Pokédex Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DexManager_FormClosing);
            this.Load += new System.EventHandler(this.DexManagerV2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox pokedexBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AddDex;
        private System.Windows.Forms.Button button_RemoveDex;
        private System.Windows.Forms.Button button_RemoveEntry;
        private System.Windows.Forms.Button button_AddEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox entriesBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
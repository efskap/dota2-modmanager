namespace Dota2ModManager
{
    partial class Main
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
            this.applyButton = new System.Windows.Forms.Button();
            this.modList = new System.Windows.Forms.CheckedListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dotadirbox = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.conflictsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.AutoSize = true;
            this.applyButton.BackColor = System.Drawing.SystemColors.Control;
            this.applyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(189, 308);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(369, 36);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply Changes";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // modList
            // 
            this.modList.CheckOnClick = true;
            this.modList.FormattingEnabled = true;
            this.modList.Location = new System.Drawing.Point(12, 12);
            this.modList.Name = "modList";
            this.modList.Size = new System.Drawing.Size(171, 229);
            this.modList.TabIndex = 2;
            this.modList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.modList_ItemCheck);
            this.modList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.modsList_MouseClick);
            this.modList.SelectedIndexChanged += new System.EventHandler(this.modsList_SelectedIndexChanged);
            this.modList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modList_KeyPress);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.richTextBox1.Location = new System.Drawing.Point(189, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(369, 262);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // dotadirbox
            // 
            this.dotadirbox.Location = new System.Drawing.Point(189, 352);
            this.dotadirbox.Name = "dotadirbox";
            this.dotadirbox.Size = new System.Drawing.Size(369, 20);
            this.dotadirbox.TabIndex = 4;
            this.dotadirbox.Text = "%DOTADIR%";
            this.dotadirbox.TextChanged += new System.EventHandler(this.dotadirbox_TextChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(84, 247);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(99, 27);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refresh);
            // 
            // upButton
            // 
            this.upButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.Location = new System.Drawing.Point(12, 247);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(30, 27);
            this.upButton.TabIndex = 6;
            this.upButton.Text = "↑";
            this.upButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // downButton
            // 
            this.downButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.Location = new System.Drawing.Point(48, 247);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(30, 27);
            this.downButton.TabIndex = 8;
            this.downButton.Text = "↓";
            this.downButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(13, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Open Mods Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // conflictsButton
            // 
            this.conflictsButton.AutoSize = true;
            this.conflictsButton.BackColor = System.Drawing.Color.MistyRose;
            this.conflictsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conflictsButton.Location = new System.Drawing.Point(189, 279);
            this.conflictsButton.Name = "conflictsButton";
            this.conflictsButton.Size = new System.Drawing.Size(369, 28);
            this.conflictsButton.TabIndex = 10;
            this.conflictsButton.Text = "No Conflicts Detected";
            this.conflictsButton.UseVisualStyleBackColor = false;
            this.conflictsButton.Click += new System.EventHandler(this.conflictsButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button2.Location = new System.Drawing.Point(12, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Open Dota Directory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 37);
            this.button3.TabIndex = 12;
            this.button3.Text = "Start Dota 2";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 384);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.conflictsButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dotadirbox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.modList);
            this.Controls.Add(this.applyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Dota 2 Mod Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.CheckedListBox modList;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox dotadirbox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button conflictsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

    }
}


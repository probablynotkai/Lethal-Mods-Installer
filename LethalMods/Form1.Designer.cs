using System.Windows.Forms;

namespace LethalMods
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.installModsButton = new System.Windows.Forms.Button();
            this.removeModsButton = new System.Windows.Forms.Button();
            this.uiHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // installModsButton
            // 
            this.installModsButton.Location = new System.Drawing.Point(257, 318);
            this.installModsButton.Name = "installModsButton";
            this.installModsButton.Size = new System.Drawing.Size(125, 37);
            this.installModsButton.TabIndex = 0;
            this.installModsButton.Text = "Install Mods";
            this.installModsButton.UseVisualStyleBackColor = true;
            this.installModsButton.Click += new System.EventHandler(this.installModsButton_Click);
            // 
            // removeModsButton
            // 
            this.removeModsButton.Location = new System.Drawing.Point(408, 318);
            this.removeModsButton.Name = "removeModsButton";
            this.removeModsButton.Size = new System.Drawing.Size(125, 37);
            this.removeModsButton.TabIndex = 1;
            this.removeModsButton.Text = "Remove Mods";
            this.removeModsButton.UseVisualStyleBackColor = true;
            this.removeModsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // uiHeader
            // 
            this.uiHeader.AutoSize = true;
            this.uiHeader.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiHeader.Location = new System.Drawing.Point(298, 63);
            this.uiHeader.Name = "uiHeader";
            this.uiHeader.Size = new System.Drawing.Size(189, 43);
            this.uiHeader.TabIndex = 2;
            this.uiHeader.Text = "Lethal Mods";
            this.uiHeader.Click += new System.EventHandler(this.uiHeader_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Credits";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(702, 128);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(657, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Our goal is to make modding your Lethal Company game as straightforward \r\nas poss" +
    "ible. Elevate your gaming experience now with the Lethal Mods – where simplicity" +
    " meets customization!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiHeader);
            this.Controls.Add(this.removeModsButton);
            this.Controls.Add(this.installModsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lethal Mods";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button installModsButton;
        private System.Windows.Forms.Button removeModsButton;
        private System.Windows.Forms.Label uiHeader;
        private System.Windows.Forms.Label label1;
        private Label label2;
        private Label label3;
    }
}


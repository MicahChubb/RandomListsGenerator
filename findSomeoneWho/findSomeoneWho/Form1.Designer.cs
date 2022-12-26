namespace findSomeoneWho
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblNumPlayers = new System.Windows.Forms.Label();
            this.txtNumPlayers = new System.Windows.Forms.TextBox();
            this.lblNumWords = new System.Windows.Forms.Label();
            this.txtNumWords = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(25, 113);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(127, 29);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate List";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblNumPlayers
            // 
            this.lblNumPlayers.AutoSize = true;
            this.lblNumPlayers.Location = new System.Drawing.Point(21, 15);
            this.lblNumPlayers.Name = "lblNumPlayers";
            this.lblNumPlayers.Size = new System.Drawing.Size(131, 20);
            this.lblNumPlayers.TabIndex = 1;
            this.lblNumPlayers.Text = "Number of Players";
            // 
            // txtNumPlayers
            // 
            this.txtNumPlayers.Location = new System.Drawing.Point(158, 12);
            this.txtNumPlayers.Name = "txtNumPlayers";
            this.txtNumPlayers.Size = new System.Drawing.Size(56, 27);
            this.txtNumPlayers.TabIndex = 2;
            this.txtNumPlayers.Enter += new System.EventHandler(this.validation_Enter);
            // 
            // lblNumWords
            // 
            this.lblNumWords.AutoSize = true;
            this.lblNumWords.Location = new System.Drawing.Point(251, 12);
            this.lblNumWords.Name = "lblNumWords";
            this.lblNumWords.Size = new System.Drawing.Size(127, 20);
            this.lblNumWords.TabIndex = 3;
            this.lblNumWords.Text = "Number of Words";
            // 
            // txtNumWords
            // 
            this.txtNumWords.Location = new System.Drawing.Point(384, 12);
            this.txtNumWords.Name = "txtNumWords";
            this.txtNumWords.Size = new System.Drawing.Size(56, 27);
            this.txtNumWords.TabIndex = 4;
            this.txtNumWords.Enter += new System.EventHandler(this.validation_Enter);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(23, 59);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(92, 20);
            this.lblSource.TabIndex = 6;
            this.lblSource.Text = "List Location";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(114, 55);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(228, 27);
            this.txtSource.TabIndex = 7;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(348, 55);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 29);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(25, 145);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 256);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtNumWords);
            this.Controls.Add(this.lblNumWords);
            this.Controls.Add(this.txtNumPlayers);
            this.Controls.Add(this.lblNumPlayers);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Generate Lists";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGenerate;
        private Label lblNumPlayers;
        private TextBox txtNumPlayers;
        private Label lblNumWords;
        private TextBox txtNumWords;
        private Label lblSource;
        private TextBox txtSource;
        private Button btnBrowse;
        private OpenFileDialog openFileDialog1;
        private Label lblError;
    }
}
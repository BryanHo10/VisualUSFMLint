using System;

namespace DemoUSFMLinter
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
            this.fileDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Msg_Linter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnAddFiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // fileDataGrid
            // 
            this.fileDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileDataGrid.Location = new System.Drawing.Point(23, 60);
            this.fileDataGrid.Name = "fileDataGrid";
            this.fileDataGrid.Size = new System.Drawing.Size(293, 374);
            this.fileDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(58, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Files";
            // 
            // Msg_Linter
            // 
            this.Msg_Linter.BackColor = System.Drawing.Color.White;
            this.Msg_Linter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msg_Linter.Location = new System.Drawing.Point(450, 60);
            this.Msg_Linter.Multiline = true;
            this.Msg_Linter.Name = "Msg_Linter";
            this.Msg_Linter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Msg_Linter.Size = new System.Drawing.Size(282, 373);
            this.Msg_Linter.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 31);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output";
            // 
            // BtnCheck
            // 
            this.BtnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheck.Location = new System.Drawing.Point(340, 183);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(90, 38);
            this.BtnCheck.TabIndex = 4;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnAddFiles
            // 
            this.BtnAddFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddFiles.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddFiles.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.BtnAddFiles.FlatAppearance.BorderSize = 0;
            this.BtnAddFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddFiles.Location = new System.Drawing.Point(340, 12);
            this.BtnAddFiles.Name = "BtnAddFiles";
            this.BtnAddFiles.Size = new System.Drawing.Size(90, 45);
            this.BtnAddFiles.TabIndex = 5;
            this.BtnAddFiles.Text = "Add Files";
            this.BtnAddFiles.UseVisualStyleBackColor = false;
            this.BtnAddFiles.Click += new System.EventHandler(this.BtnAddFiles_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAddFiles);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Msg_Linter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileDataGrid);
            this.Name = "Main";
            this.Text = "Demo USFM Linter";
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView fileDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Msg_Linter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnAddFiles;
    }
}


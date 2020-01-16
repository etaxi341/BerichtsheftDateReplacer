namespace BerichtsheftDateReplacer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectedFileLabel = new System.Windows.Forms.Label();
            this.btn_selectFile = new System.Windows.Forms.Button();
            this.dateTime_EndOfAusbildung = new System.Windows.Forms.DateTimePicker();
            this.btn_generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime_StartOfAusbildung = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_Wochenrhythmus = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Wochenrhythmus)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectedFileLabel
            // 
            this.selectedFileLabel.Location = new System.Drawing.Point(12, 9);
            this.selectedFileLabel.Name = "selectedFileLabel";
            this.selectedFileLabel.Size = new System.Drawing.Size(206, 17);
            this.selectedFileLabel.TabIndex = 0;
            this.selectedFileLabel.Text = "No file selected";
            this.selectedFileLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_selectFile
            // 
            this.btn_selectFile.Location = new System.Drawing.Point(224, 5);
            this.btn_selectFile.Name = "btn_selectFile";
            this.btn_selectFile.Size = new System.Drawing.Size(75, 23);
            this.btn_selectFile.TabIndex = 1;
            this.btn_selectFile.Text = "Select File";
            this.btn_selectFile.UseVisualStyleBackColor = true;
            this.btn_selectFile.Click += new System.EventHandler(this.btn_selectFile_Click);
            // 
            // dateTime_EndOfAusbildung
            // 
            this.dateTime_EndOfAusbildung.Location = new System.Drawing.Point(15, 93);
            this.dateTime_EndOfAusbildung.Name = "dateTime_EndOfAusbildung";
            this.dateTime_EndOfAusbildung.Size = new System.Drawing.Size(200, 20);
            this.dateTime_EndOfAusbildung.TabIndex = 2;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(15, 148);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 3;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ausbildungsende";
            // 
            // dateTime_StartOfAusbildung
            // 
            this.dateTime_StartOfAusbildung.Location = new System.Drawing.Point(15, 44);
            this.dateTime_StartOfAusbildung.Name = "dateTime_StartOfAusbildung";
            this.dateTime_StartOfAusbildung.Size = new System.Drawing.Size(203, 20);
            this.dateTime_StartOfAusbildung.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ausbildungsbeginn";
            // 
            // numeric_Wochenrhythmus
            // 
            this.numeric_Wochenrhythmus.Location = new System.Drawing.Point(96, 121);
            this.numeric_Wochenrhythmus.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numeric_Wochenrhythmus.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Wochenrhythmus.Name = "numeric_Wochenrhythmus";
            this.numeric_Wochenrhythmus.Size = new System.Drawing.Size(47, 20);
            this.numeric_Wochenrhythmus.TabIndex = 7;
            this.numeric_Wochenrhythmus.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Berichtsheft alle                    Wochen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 182);
            this.Controls.Add(this.numeric_Wochenrhythmus);
            this.Controls.Add(this.dateTime_StartOfAusbildung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTime_EndOfAusbildung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.btn_selectFile);
            this.Controls.Add(this.selectedFileLabel);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Berichtsheft Dategenerator";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Wochenrhythmus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label selectedFileLabel;
        private System.Windows.Forms.Button btn_selectFile;
        private System.Windows.Forms.DateTimePicker dateTime_EndOfAusbildung;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTime_StartOfAusbildung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeric_Wochenrhythmus;
        private System.Windows.Forms.Label label3;
    }
}


namespace ELF_FW_Patcher {
    partial class ElfFwPatcher {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElfFwPatcher));
            this.radioFile = new System.Windows.Forms.RadioButton();
            this.radioFolder = new System.Windows.Forms.RadioButton();
            this.buttonPatch = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelFWLookup = new System.Windows.Forms.Label();
            this.textFWLookup = new System.Windows.Forms.TextBox();
            this.textFWPatch = new System.Windows.Forms.TextBox();
            this.labelFWPatch = new System.Windows.Forms.Label();
            this.selectFile = new System.Windows.Forms.OpenFileDialog();
            this.selectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelDude = new System.Windows.Forms.Label();
            this.labelMe = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioFile
            // 
            this.radioFile.AutoSize = true;
            this.radioFile.Location = new System.Drawing.Point(12, 12);
            this.radioFile.Name = "radioFile";
            this.radioFile.Size = new System.Drawing.Size(41, 17);
            this.radioFile.TabIndex = 0;
            this.radioFile.TabStop = true;
            this.radioFile.Text = "File";
            this.radioFile.UseVisualStyleBackColor = true;
            // 
            // radioFolder
            // 
            this.radioFolder.AutoSize = true;
            this.radioFolder.Location = new System.Drawing.Point(59, 12);
            this.radioFolder.Name = "radioFolder";
            this.radioFolder.Size = new System.Drawing.Size(54, 17);
            this.radioFolder.TabIndex = 1;
            this.radioFolder.TabStop = true;
            this.radioFolder.Text = "Folder";
            this.radioFolder.UseVisualStyleBackColor = true;
            // 
            // buttonPatch
            // 
            this.buttonPatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatch.Location = new System.Drawing.Point(12, 115);
            this.buttonPatch.Name = "buttonPatch";
            this.buttonPatch.Size = new System.Drawing.Size(302, 32);
            this.buttonPatch.TabIndex = 2;
            this.buttonPatch.Text = "Patch FW";
            this.buttonPatch.UseVisualStyleBackColor = true;
            this.buttonPatch.Click += new System.EventHandler(this.ButtonPatch_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(241, 84);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxInput.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxInput.Location = new System.Drawing.Point(12, 86);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(223, 20);
            this.textBoxInput.TabIndex = 4;
            // 
            // labelFWLookup
            // 
            this.labelFWLookup.AutoSize = true;
            this.labelFWLookup.Location = new System.Drawing.Point(115, 35);
            this.labelFWLookup.Name = "labelFWLookup";
            this.labelFWLookup.Size = new System.Drawing.Size(75, 13);
            this.labelFWLookup.TabIndex = 5;
            this.labelFWLookup.Text = "FW to Lookup";
            // 
            // textFWLookup
            // 
            this.textFWLookup.BackColor = System.Drawing.SystemColors.WindowText;
            this.textFWLookup.ForeColor = System.Drawing.Color.Yellow;
            this.textFWLookup.Location = new System.Drawing.Point(12, 32);
            this.textFWLookup.MaxLength = 8;
            this.textFWLookup.Name = "textFWLookup";
            this.textFWLookup.Size = new System.Drawing.Size(100, 20);
            this.textFWLookup.TabIndex = 6;
            // 
            // textFWPatch
            // 
            this.textFWPatch.BackColor = System.Drawing.SystemColors.WindowText;
            this.textFWPatch.ForeColor = System.Drawing.Color.Yellow;
            this.textFWPatch.Location = new System.Drawing.Point(12, 58);
            this.textFWPatch.MaxLength = 8;
            this.textFWPatch.Name = "textFWPatch";
            this.textFWPatch.Size = new System.Drawing.Size(100, 20);
            this.textFWPatch.TabIndex = 7;
            // 
            // labelFWPatch
            // 
            this.labelFWPatch.AutoSize = true;
            this.labelFWPatch.Location = new System.Drawing.Point(114, 61);
            this.labelFWPatch.Name = "labelFWPatch";
            this.labelFWPatch.Size = new System.Drawing.Size(67, 13);
            this.labelFWPatch.TabIndex = 8;
            this.labelFWPatch.Text = "FW to Patch";
            // 
            // selectFile
            // 
            this.selectFile.FileName = "Choose ELF...";
            this.selectFile.Filter = "EXE Files (*.elf, *.bin)|*.elf; *.bin";
            this.selectFile.Multiselect = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 171);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(326, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(100, 17);
            this.status.Text = "Waiting for user...";
            // 
            // labelDude
            // 
            this.labelDude.AutoSize = true;
            this.labelDude.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelDude.Location = new System.Drawing.Point(12, 153);
            this.labelDude.Name = "labelDude";
            this.labelDude.Size = new System.Drawing.Size(94, 13);
            this.labelDude.TabIndex = 10;
            this.labelDude.Text = "Method @Barthen";
            // 
            // labelMe
            // 
            this.labelMe.AutoSize = true;
            this.labelMe.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelMe.Location = new System.Drawing.Point(228, 153);
            this.labelMe.Name = "labelMe";
            this.labelMe.Size = new System.Drawing.Size(81, 13);
            this.labelMe.TabIndex = 11;
            this.labelMe.Text = "GUI @cfwprpht";
            // 
            // ElfFwPatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 193);
            this.Controls.Add(this.labelMe);
            this.Controls.Add(this.labelDude);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelFWPatch);
            this.Controls.Add(this.textFWPatch);
            this.Controls.Add(this.textFWLookup);
            this.Controls.Add(this.labelFWLookup);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonPatch);
            this.Controls.Add(this.radioFolder);
            this.Controls.Add(this.radioFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ElfFwPatcher";
            this.Text = "ELF FW Patcher";
            this.Load += new System.EventHandler(this.ElfFwPatcher_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioFile;
        private System.Windows.Forms.RadioButton radioFolder;
        private System.Windows.Forms.Button buttonPatch;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelFWLookup;
        private System.Windows.Forms.TextBox textFWLookup;
        private System.Windows.Forms.TextBox textFWPatch;
        private System.Windows.Forms.Label labelFWPatch;
        private System.Windows.Forms.OpenFileDialog selectFile;
        private System.Windows.Forms.FolderBrowserDialog selectFolder;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Label labelDude;
        private System.Windows.Forms.Label labelMe;
    }
}


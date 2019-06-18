namespace FeatureExtractor
{
    partial class featureExtractor
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
            this.components = new System.ComponentModel.Container();
            this.languageGrammarLabel = new System.Windows.Forms.Label();
            this.onlyLUV = new System.Windows.Forms.CheckBox();
            this.targetLanguageGrammarPath = new System.Windows.Forms.FolderBrowserDialog();
            this.targetProjectPath = new System.Windows.Forms.FolderBrowserDialog();
            this.languageGrammar = new System.Windows.Forms.TextBox();
            this.targetProjectLabel = new System.Windows.Forms.Label();
            this.targetProject = new System.Windows.Forms.TextBox();
            this.browseLanguageGrammar = new System.Windows.Forms.Button();
            this.browseProject = new System.Windows.Forms.Button();
            this.levelOfContextLabel = new System.Windows.Forms.Label();
            this.levelOfContext = new System.Windows.Forms.NumericUpDown();
            this.submitRequest = new System.Windows.Forms.Button();
            this.applicationLog = new System.Windows.Forms.RichTextBox();
            this.formError = new System.Windows.Forms.ErrorProvider(this.components);
            this.clearRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.levelOfContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formError)).BeginInit();
            this.SuspendLayout();
            // 
            // languageGrammarLabel
            // 
            this.languageGrammarLabel.AutoSize = true;
            this.languageGrammarLabel.Location = new System.Drawing.Point(47, 27);
            this.languageGrammarLabel.Name = "languageGrammarLabel";
            this.languageGrammarLabel.Size = new System.Drawing.Size(247, 25);
            this.languageGrammarLabel.TabIndex = 0;
            this.languageGrammarLabel.Text = "TXL Language Grammar";
            // 
            // onlyLUV
            // 
            this.onlyLUV.AutoSize = true;
            this.onlyLUV.Location = new System.Drawing.Point(52, 216);
            this.onlyLUV.Name = "onlyLUV";
            this.onlyLUV.Size = new System.Drawing.Size(137, 29);
            this.onlyLUV.TabIndex = 1;
            this.onlyLUV.Text = "onlyLUV?";
            this.onlyLUV.UseVisualStyleBackColor = true;
            this.onlyLUV.CheckedChanged += new System.EventHandler(this.OnlyLUV_CheckedChanged);
            // 
            // targetLanguageGrammarPath
            // 
            this.targetLanguageGrammarPath.Description = "Select TXL language grammar folder";
            // 
            // targetProjectPath
            // 
            this.targetProjectPath.Description = "Select target project folder";
            // 
            // languageGrammar
            // 
            this.languageGrammar.Location = new System.Drawing.Point(52, 55);
            this.languageGrammar.Name = "languageGrammar";
            this.languageGrammar.ReadOnly = true;
            this.languageGrammar.Size = new System.Drawing.Size(903, 31);
            this.languageGrammar.TabIndex = 2;
            // 
            // targetProjectLabel
            // 
            this.targetProjectLabel.AutoSize = true;
            this.targetProjectLabel.Location = new System.Drawing.Point(47, 117);
            this.targetProjectLabel.Name = "targetProjectLabel";
            this.targetProjectLabel.Size = new System.Drawing.Size(147, 25);
            this.targetProjectLabel.TabIndex = 3;
            this.targetProjectLabel.Text = "Target Project";
            // 
            // targetProject
            // 
            this.targetProject.Location = new System.Drawing.Point(52, 146);
            this.targetProject.Name = "targetProject";
            this.targetProject.ReadOnly = true;
            this.targetProject.Size = new System.Drawing.Size(903, 31);
            this.targetProject.TabIndex = 4;
            // 
            // browseLanguageGrammar
            // 
            this.browseLanguageGrammar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.browseLanguageGrammar.Location = new System.Drawing.Point(1004, 51);
            this.browseLanguageGrammar.Name = "browseLanguageGrammar";
            this.browseLanguageGrammar.Size = new System.Drawing.Size(300, 45);
            this.browseLanguageGrammar.TabIndex = 5;
            this.browseLanguageGrammar.Text = "Browse Language Grammar";
            this.browseLanguageGrammar.UseVisualStyleBackColor = false;
            this.browseLanguageGrammar.Click += new System.EventHandler(this.BrowseLanguageGrammar_Click);
            // 
            // browseProject
            // 
            this.browseProject.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.browseProject.Location = new System.Drawing.Point(1004, 140);
            this.browseProject.Name = "browseProject";
            this.browseProject.Size = new System.Drawing.Size(300, 45);
            this.browseProject.TabIndex = 6;
            this.browseProject.Text = "Browse Project";
            this.browseProject.UseVisualStyleBackColor = false;
            this.browseProject.Click += new System.EventHandler(this.BrowseProject_Click);
            // 
            // levelOfContextLabel
            // 
            this.levelOfContextLabel.AutoSize = true;
            this.levelOfContextLabel.Location = new System.Drawing.Point(81, 252);
            this.levelOfContextLabel.Name = "levelOfContextLabel";
            this.levelOfContextLabel.Size = new System.Drawing.Size(219, 25);
            this.levelOfContextLabel.TabIndex = 7;
            this.levelOfContextLabel.Text = "Level of Context Dept";
            // 
            // levelOfContext
            // 
            this.levelOfContext.Location = new System.Drawing.Point(306, 246);
            this.levelOfContext.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.levelOfContext.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.levelOfContext.Name = "levelOfContext";
            this.levelOfContext.ReadOnly = true;
            this.levelOfContext.Size = new System.Drawing.Size(120, 31);
            this.levelOfContext.TabIndex = 8;
            this.levelOfContext.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // submitRequest
            // 
            this.submitRequest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitRequest.Location = new System.Drawing.Point(394, 305);
            this.submitRequest.Name = "submitRequest";
            this.submitRequest.Size = new System.Drawing.Size(196, 55);
            this.submitRequest.TabIndex = 9;
            this.submitRequest.Text = "Submit Request";
            this.submitRequest.UseVisualStyleBackColor = false;
            this.submitRequest.Click += new System.EventHandler(this.SubmitRequest_Click);
            // 
            // applicationLog
            // 
            this.applicationLog.Enabled = false;
            this.applicationLog.Location = new System.Drawing.Point(52, 388);
            this.applicationLog.Name = "applicationLog";
            this.applicationLog.Size = new System.Drawing.Size(1268, 365);
            this.applicationLog.TabIndex = 10;
            this.applicationLog.Text = "Feature Extractor Log\n-------------------------------------------------------\n";
            // 
            // formError
            // 
            this.formError.ContainerControl = this;
            // 
            // clearRequest
            // 
            this.clearRequest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearRequest.Enabled = false;
            this.clearRequest.Location = new System.Drawing.Point(650, 305);
            this.clearRequest.Name = "clearRequest";
            this.clearRequest.Size = new System.Drawing.Size(196, 54);
            this.clearRequest.TabIndex = 11;
            this.clearRequest.Text = "Clear Request";
            this.clearRequest.UseVisualStyleBackColor = false;
            this.clearRequest.Click += new System.EventHandler(this.ClearRequest_Click);
            // 
            // featureExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1352, 819);
            this.Controls.Add(this.clearRequest);
            this.Controls.Add(this.applicationLog);
            this.Controls.Add(this.submitRequest);
            this.Controls.Add(this.levelOfContext);
            this.Controls.Add(this.levelOfContextLabel);
            this.Controls.Add(this.browseProject);
            this.Controls.Add(this.browseLanguageGrammar);
            this.Controls.Add(this.targetProject);
            this.Controls.Add(this.targetProjectLabel);
            this.Controls.Add(this.languageGrammar);
            this.Controls.Add(this.onlyLUV);
            this.Controls.Add(this.languageGrammarLabel);
            this.Name = "featureExtractor";
            this.Text = "Language Use Vector Extractor";
            ((System.ComponentModel.ISupportInitialize)(this.levelOfContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label languageGrammarLabel;
        private System.Windows.Forms.CheckBox onlyLUV;
        private System.Windows.Forms.FolderBrowserDialog targetLanguageGrammarPath;
        private System.Windows.Forms.FolderBrowserDialog targetProjectPath;
        private System.Windows.Forms.TextBox languageGrammar;
        private System.Windows.Forms.Label targetProjectLabel;
        private System.Windows.Forms.TextBox targetProject;
        private System.Windows.Forms.Button browseLanguageGrammar;
        private System.Windows.Forms.Button browseProject;
        private System.Windows.Forms.Label levelOfContextLabel;
        private System.Windows.Forms.NumericUpDown levelOfContext;
        private System.Windows.Forms.Button submitRequest;
        private System.Windows.Forms.RichTextBox applicationLog;
        private System.Windows.Forms.ErrorProvider formError;
        private System.Windows.Forms.Button clearRequest;
    }
}


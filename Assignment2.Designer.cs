namespace Assignment2
{
    partial class Assignment2
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
            label1 = new Label();
            lstMakeModel = new ListBox();
            lblYear = new Label();
            txtYear = new TextBox();
            grpColors = new GroupBox();
            rbtnWhite = new RadioButton();
            rbtnBlack = new RadioButton();
            rbtnBlue = new RadioButton();
            rbtnRed = new RadioButton();
            grpOptions = new GroupBox();
            chkLaneAssistance = new CheckBox();
            chkSiriusRadio = new CheckBox();
            chkAirConditioning = new CheckBox();
            chkPowerWindows = new CheckBox();
            btnPurchase = new Button();
            lblPurchaseSummary = new Label();
            grpColors.SuspendLayout();
            grpOptions.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 21);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "&Make and Model";
            // 
            // lstMakeModel
            // 
            lstMakeModel.FormattingEnabled = true;
            lstMakeModel.Items.AddRange(new object[] { "Chevrolet Silverado", "Ford F-150", "Toyota Yaris", "Honda Civic" });
            lstMakeModel.Location = new Point(55, 52);
            lstMakeModel.Name = "lstMakeModel";
            lstMakeModel.Size = new Size(150, 104);
            lstMakeModel.TabIndex = 1;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(253, 21);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(37, 20);
            lblYear.TabIndex = 2;
            lblYear.Text = "&Year";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(253, 52);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(85, 27);
            txtYear.TabIndex = 3;
            // 
            // grpColors
            // 
            grpColors.Controls.Add(rbtnWhite);
            grpColors.Controls.Add(rbtnBlack);
            grpColors.Controls.Add(rbtnBlue);
            grpColors.Controls.Add(rbtnRed);
            grpColors.Location = new Point(366, 21);
            grpColors.Name = "grpColors";
            grpColors.RightToLeft = RightToLeft.No;
            grpColors.Size = new Size(152, 153);
            grpColors.TabIndex = 5;
            grpColors.TabStop = false;
            grpColors.Text = "&Colors";
            // 
            // rbtnWhite
            // 
            rbtnWhite.AutoSize = true;
            rbtnWhite.Location = new Point(17, 111);
            rbtnWhite.Name = "rbtnWhite";
            rbtnWhite.Size = new Size(69, 24);
            rbtnWhite.TabIndex = 3;
            rbtnWhite.TabStop = true;
            rbtnWhite.Text = "White";
            rbtnWhite.UseVisualStyleBackColor = true;
            // 
            // rbtnBlack
            // 
            rbtnBlack.AutoSize = true;
            rbtnBlack.Location = new Point(17, 81);
            rbtnBlack.Name = "rbtnBlack";
            rbtnBlack.Size = new Size(65, 24);
            rbtnBlack.TabIndex = 2;
            rbtnBlack.TabStop = true;
            rbtnBlack.Text = "Black";
            rbtnBlack.UseVisualStyleBackColor = true;
            // 
            // rbtnBlue
            // 
            rbtnBlue.AutoSize = true;
            rbtnBlue.Location = new Point(17, 51);
            rbtnBlue.Name = "rbtnBlue";
            rbtnBlue.Size = new Size(59, 24);
            rbtnBlue.TabIndex = 1;
            rbtnBlue.TabStop = true;
            rbtnBlue.Text = "Blue";
            rbtnBlue.UseVisualStyleBackColor = true;
            // 
            // rbtnRed
            // 
            rbtnRed.AutoSize = true;
            rbtnRed.Location = new Point(17, 26);
            rbtnRed.Name = "rbtnRed";
            rbtnRed.Size = new Size(56, 24);
            rbtnRed.TabIndex = 0;
            rbtnRed.TabStop = true;
            rbtnRed.Text = "Red";
            rbtnRed.UseVisualStyleBackColor = true;
            // 
            // grpOptions
            // 
            grpOptions.Controls.Add(chkLaneAssistance);
            grpOptions.Controls.Add(chkSiriusRadio);
            grpOptions.Controls.Add(chkAirConditioning);
            grpOptions.Controls.Add(chkPowerWindows);
            grpOptions.Location = new Point(539, 21);
            grpOptions.Name = "grpOptions";
            grpOptions.Size = new Size(169, 153);
            grpOptions.TabIndex = 6;
            grpOptions.TabStop = false;
            grpOptions.Text = "&Options";
            // 
            // chkLaneAssistance
            // 
            chkLaneAssistance.AutoSize = true;
            chkLaneAssistance.Location = new Point(21, 121);
            chkLaneAssistance.Name = "chkLaneAssistance";
            chkLaneAssistance.Size = new Size(134, 24);
            chkLaneAssistance.TabIndex = 3;
            chkLaneAssistance.Text = "Lane Assistance";
            chkLaneAssistance.UseVisualStyleBackColor = true;
            // 
            // chkSiriusRadio
            // 
            chkSiriusRadio.AutoSize = true;
            chkSiriusRadio.Location = new Point(20, 91);
            chkSiriusRadio.Name = "chkSiriusRadio";
            chkSiriusRadio.Size = new Size(109, 24);
            chkSiriusRadio.TabIndex = 2;
            chkSiriusRadio.Text = "Sirius Radio";
            chkSiriusRadio.UseVisualStyleBackColor = true;
            // 
            // chkAirConditioning
            // 
            chkAirConditioning.AutoSize = true;
            chkAirConditioning.Location = new Point(20, 61);
            chkAirConditioning.Name = "chkAirConditioning";
            chkAirConditioning.Size = new Size(140, 24);
            chkAirConditioning.TabIndex = 1;
            chkAirConditioning.Text = "Air Conditioning";
            chkAirConditioning.UseVisualStyleBackColor = true;
            // 
            // chkPowerWindows
            // 
            chkPowerWindows.AutoSize = true;
            chkPowerWindows.Location = new Point(20, 31);
            chkPowerWindows.Name = "chkPowerWindows";
            chkPowerWindows.Size = new Size(136, 24);
            chkPowerWindows.TabIndex = 0;
            chkPowerWindows.Text = "Power Windows";
            chkPowerWindows.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            btnPurchase.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPurchase.Location = new Point(225, 202);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(271, 97);
            btnPurchase.TabIndex = 7;
            btnPurchase.Text = "&Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // lblPurchaseSummary
            // 
            lblPurchaseSummary.BorderStyle = BorderStyle.Fixed3D;
            lblPurchaseSummary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPurchaseSummary.Location = new Point(85, 327);
            lblPurchaseSummary.Name = "lblPurchaseSummary";
            lblPurchaseSummary.Size = new Size(651, 93);
            lblPurchaseSummary.TabIndex = 8;
            // 
            // Assignment2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPurchaseSummary);
            Controls.Add(btnPurchase);
            Controls.Add(grpOptions);
            Controls.Add(grpColors);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(lstMakeModel);
            Controls.Add(label1);
            Name = "Assignment2";
            Text = "Assignment 2";
            Load += Assignment2_Load;
            grpColors.ResumeLayout(false);
            grpColors.PerformLayout();
            grpOptions.ResumeLayout(false);
            grpOptions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstMakeModel;
        private Label lblYear;
        private TextBox txtYear;
        private GroupBox grpColors;
        private GroupBox grpOptions;
        private RadioButton rbtnWhite;
        private RadioButton rbtnBlack;
        private RadioButton rbtnBlue;
        private RadioButton rbtnRed;
        private CheckBox chkLaneAssistance;
        private CheckBox chkSiriusRadio;
        private CheckBox chkAirConditioning;
        private CheckBox chkPowerWindows;
        private Button btnPurchase;
        private Label lblPurchaseSummary;
    }
}

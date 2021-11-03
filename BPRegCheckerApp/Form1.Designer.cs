
namespace BPRegCheckerApp
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
            this.lblEnterReg = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.txtInputtedReg = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblVehicleColour = new System.Windows.Forms.Label();
            this.lblTaxStatus = new System.Windows.Forms.Label();
            this.lblMOTExpiry = new System.Windows.Forms.Label();
            this.lblResultMake = new System.Windows.Forms.Label();
            this.lblResultColour = new System.Windows.Forms.Label();
            this.lblResultTaxStatus = new System.Windows.Forms.Label();
            this.lblMOTExpiryDate = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblEngineSize = new System.Windows.Forms.Label();
            this.lblResultEngineSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterReg
            // 
            this.lblEnterReg.AutoSize = true;
            this.lblEnterReg.Location = new System.Drawing.Point(21, 22);
            this.lblEnterReg.Name = "lblEnterReg";
            this.lblEnterReg.Size = new System.Drawing.Size(89, 13);
            this.lblEnterReg.TabIndex = 0;
            this.lblEnterReg.Text = "Enter registration:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(66, 53);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(75, 13);
            this.lblMake.TabIndex = 1;
            this.lblMake.Text = "Vehicle Make:";
            // 
            // txtInputtedReg
            // 
            this.txtInputtedReg.Location = new System.Drawing.Point(107, 19);
            this.txtInputtedReg.Name = "txtInputtedReg";
            this.txtInputtedReg.Size = new System.Drawing.Size(100, 20);
            this.txtInputtedReg.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(213, 19);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblVehicleColour
            // 
            this.lblVehicleColour.AutoSize = true;
            this.lblVehicleColour.Location = new System.Drawing.Point(63, 70);
            this.lblVehicleColour.Name = "lblVehicleColour";
            this.lblVehicleColour.Size = new System.Drawing.Size(78, 13);
            this.lblVehicleColour.TabIndex = 3;
            this.lblVehicleColour.Text = "Vehicle Colour:";
            // 
            // lblTaxStatus
            // 
            this.lblTaxStatus.AutoSize = true;
            this.lblTaxStatus.Location = new System.Drawing.Point(42, 86);
            this.lblTaxStatus.Name = "lblTaxStatus";
            this.lblTaxStatus.Size = new System.Drawing.Size(99, 13);
            this.lblTaxStatus.TabIndex = 4;
            this.lblTaxStatus.Text = "Vehicle Tax Status:";
            // 
            // lblMOTExpiry
            // 
            this.lblMOTExpiry.AutoSize = true;
            this.lblMOTExpiry.Location = new System.Drawing.Point(12, 101);
            this.lblMOTExpiry.Name = "lblMOTExpiry";
            this.lblMOTExpiry.Size = new System.Drawing.Size(129, 13);
            this.lblMOTExpiry.TabIndex = 5;
            this.lblMOTExpiry.Text = "Vehicle MOT Expiry Date:";
            // 
            // lblResultMake
            // 
            this.lblResultMake.AutoSize = true;
            this.lblResultMake.Location = new System.Drawing.Point(147, 53);
            this.lblResultMake.Name = "lblResultMake";
            this.lblResultMake.Size = new System.Drawing.Size(16, 13);
            this.lblResultMake.TabIndex = 6;
            this.lblResultMake.Text = "---";
            // 
            // lblResultColour
            // 
            this.lblResultColour.AutoSize = true;
            this.lblResultColour.Location = new System.Drawing.Point(147, 70);
            this.lblResultColour.Name = "lblResultColour";
            this.lblResultColour.Size = new System.Drawing.Size(16, 13);
            this.lblResultColour.TabIndex = 7;
            this.lblResultColour.Text = "---";
            // 
            // lblResultTaxStatus
            // 
            this.lblResultTaxStatus.AutoSize = true;
            this.lblResultTaxStatus.Location = new System.Drawing.Point(147, 86);
            this.lblResultTaxStatus.Name = "lblResultTaxStatus";
            this.lblResultTaxStatus.Size = new System.Drawing.Size(16, 13);
            this.lblResultTaxStatus.TabIndex = 8;
            this.lblResultTaxStatus.Text = "---";
            // 
            // lblMOTExpiryDate
            // 
            this.lblMOTExpiryDate.AutoSize = true;
            this.lblMOTExpiryDate.Location = new System.Drawing.Point(147, 101);
            this.lblMOTExpiryDate.Name = "lblMOTExpiryDate";
            this.lblMOTExpiryDate.Size = new System.Drawing.Size(16, 13);
            this.lblMOTExpiryDate.TabIndex = 9;
            this.lblMOTExpiryDate.Text = "---";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(295, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblEngineSize
            // 
            this.lblEngineSize.AutoSize = true;
            this.lblEngineSize.Location = new System.Drawing.Point(31, 114);
            this.lblEngineSize.Name = "lblEngineSize";
            this.lblEngineSize.Size = new System.Drawing.Size(110, 13);
            this.lblEngineSize.TabIndex = 11;
            this.lblEngineSize.Text = "Engine Capacity (CC):";
            // 
            // lblResultEngineSize
            // 
            this.lblResultEngineSize.AutoSize = true;
            this.lblResultEngineSize.Location = new System.Drawing.Point(147, 114);
            this.lblResultEngineSize.Name = "lblResultEngineSize";
            this.lblResultEngineSize.Size = new System.Drawing.Size(16, 13);
            this.lblResultEngineSize.TabIndex = 12;
            this.lblResultEngineSize.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 152);
            this.Controls.Add(this.lblResultEngineSize);
            this.Controls.Add(this.lblEngineSize);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMOTExpiryDate);
            this.Controls.Add(this.lblResultTaxStatus);
            this.Controls.Add(this.lblResultColour);
            this.Controls.Add(this.lblResultMake);
            this.Controls.Add(this.lblMOTExpiry);
            this.Controls.Add(this.lblTaxStatus);
            this.Controls.Add(this.lblVehicleColour);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtInputtedReg);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblEnterReg);
            this.Name = "Form1";
            this.Text = "BP Reg Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterReg;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtInputtedReg;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblVehicleColour;
        private System.Windows.Forms.Label lblTaxStatus;
        private System.Windows.Forms.Label lblMOTExpiry;
        private System.Windows.Forms.Label lblResultMake;
        private System.Windows.Forms.Label lblResultColour;
        private System.Windows.Forms.Label lblResultTaxStatus;
        private System.Windows.Forms.Label lblMOTExpiryDate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblEngineSize;
        private System.Windows.Forms.Label lblResultEngineSize;
    }
}


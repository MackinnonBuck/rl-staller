namespace RLStaller
{
    partial class MainWindow
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
            this.controllerComboBox = new System.Windows.Forms.ComboBox();
            this.controllerLabel = new System.Windows.Forms.Label();
            this.stallLabel = new System.Windows.Forms.Label();
            this.stallComboBox = new System.Windows.Forms.ComboBox();
            this.notFoundLabel = new System.Windows.Forms.Label();
            this.airSteerLabel = new System.Windows.Forms.Label();
            this.airRollLabel = new System.Windows.Forms.Label();
            this.jumpLabel = new System.Windows.Forms.Label();
            this.airSteerButton = new System.Windows.Forms.Button();
            this.airRollButton = new System.Windows.Forms.Button();
            this.jumpButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controllerComboBox
            // 
            this.controllerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controllerComboBox.DisplayMember = "UserIndex";
            this.controllerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controllerComboBox.FormattingEnabled = true;
            this.controllerComboBox.Location = new System.Drawing.Point(12, 33);
            this.controllerComboBox.Name = "controllerComboBox";
            this.controllerComboBox.Size = new System.Drawing.Size(136, 21);
            this.controllerComboBox.TabIndex = 0;
            this.controllerComboBox.SelectedIndexChanged += new System.EventHandler(this.ControllerSelectedIndexChanged);
            // 
            // controllerLabel
            // 
            this.controllerLabel.AutoSize = true;
            this.controllerLabel.Location = new System.Drawing.Point(13, 13);
            this.controllerLabel.Name = "controllerLabel";
            this.controllerLabel.Size = new System.Drawing.Size(65, 13);
            this.controllerLabel.TabIndex = 1;
            this.controllerLabel.Text = "Controller ID";
            // 
            // stallLabel
            // 
            this.stallLabel.AutoSize = true;
            this.stallLabel.Location = new System.Drawing.Point(12, 57);
            this.stallLabel.Name = "stallLabel";
            this.stallLabel.Size = new System.Drawing.Size(61, 13);
            this.stallLabel.TabIndex = 4;
            this.stallLabel.Text = "Stall Button";
            // 
            // stallComboBox
            // 
            this.stallComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stallComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stallComboBox.FormattingEnabled = true;
            this.stallComboBox.Location = new System.Drawing.Point(12, 73);
            this.stallComboBox.Name = "stallComboBox";
            this.stallComboBox.Size = new System.Drawing.Size(206, 21);
            this.stallComboBox.TabIndex = 5;
            this.stallComboBox.SelectedIndexChanged += new System.EventHandler(this.StallSelectedIndexChanged);
            // 
            // notFoundLabel
            // 
            this.notFoundLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notFoundLabel.AutoSize = true;
            this.notFoundLabel.ForeColor = System.Drawing.Color.Red;
            this.notFoundLabel.Location = new System.Drawing.Point(119, 13);
            this.notFoundLabel.Name = "notFoundLabel";
            this.notFoundLabel.Size = new System.Drawing.Size(99, 13);
            this.notFoundLabel.TabIndex = 3;
            this.notFoundLabel.Text = "Controller not found";
            // 
            // airSteerLabel
            // 
            this.airSteerLabel.AutoSize = true;
            this.airSteerLabel.Location = new System.Drawing.Point(9, 97);
            this.airSteerLabel.Name = "airSteerLabel";
            this.airSteerLabel.Size = new System.Drawing.Size(68, 13);
            this.airSteerLabel.TabIndex = 6;
            this.airSteerLabel.Text = "Air Steer Left";
            // 
            // airRollLabel
            // 
            this.airRollLabel.AutoSize = true;
            this.airRollLabel.Location = new System.Drawing.Point(9, 139);
            this.airRollLabel.Name = "airRollLabel";
            this.airRollLabel.Size = new System.Drawing.Size(68, 13);
            this.airRollLabel.TabIndex = 7;
            this.airRollLabel.Text = "Air Roll Right";
            // 
            // jumpLabel
            // 
            this.jumpLabel.AutoSize = true;
            this.jumpLabel.Location = new System.Drawing.Point(9, 181);
            this.jumpLabel.Name = "jumpLabel";
            this.jumpLabel.Size = new System.Drawing.Size(32, 13);
            this.jumpLabel.TabIndex = 8;
            this.jumpLabel.Text = "Jump";
            // 
            // airSteerButton
            // 
            this.airSteerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.airSteerButton.Location = new System.Drawing.Point(12, 113);
            this.airSteerButton.Name = "airSteerButton";
            this.airSteerButton.Size = new System.Drawing.Size(206, 23);
            this.airSteerButton.TabIndex = 9;
            this.airSteerButton.Tag = 0;
            this.airSteerButton.Text = "None";
            this.airSteerButton.UseVisualStyleBackColor = true;
            this.airSteerButton.Click += new System.EventHandler(this.BindButtonClick);
            this.airSteerButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BindButtonKeyDown);
            this.airSteerButton.Leave += new System.EventHandler(this.BindButtonLeave);
            // 
            // airRollButton
            // 
            this.airRollButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.airRollButton.Location = new System.Drawing.Point(12, 155);
            this.airRollButton.Name = "airRollButton";
            this.airRollButton.Size = new System.Drawing.Size(206, 23);
            this.airRollButton.TabIndex = 10;
            this.airRollButton.Tag = 1;
            this.airRollButton.Text = "None";
            this.airRollButton.UseVisualStyleBackColor = true;
            this.airRollButton.Click += new System.EventHandler(this.BindButtonClick);
            this.airRollButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BindButtonKeyDown);
            this.airRollButton.Leave += new System.EventHandler(this.BindButtonLeave);
            // 
            // jumpButton
            // 
            this.jumpButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jumpButton.Location = new System.Drawing.Point(12, 197);
            this.jumpButton.Name = "jumpButton";
            this.jumpButton.Size = new System.Drawing.Size(206, 23);
            this.jumpButton.TabIndex = 11;
            this.jumpButton.Tag = 2;
            this.jumpButton.Text = "None";
            this.jumpButton.UseVisualStyleBackColor = true;
            this.jumpButton.Click += new System.EventHandler(this.BindButtonClick);
            this.jumpButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BindButtonKeyDown);
            this.jumpButton.Leave += new System.EventHandler(this.BindButtonLeave);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(154, 32);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(64, 23);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 231);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.jumpButton);
            this.Controls.Add(this.airRollButton);
            this.Controls.Add(this.airSteerButton);
            this.Controls.Add(this.jumpLabel);
            this.Controls.Add(this.airRollLabel);
            this.Controls.Add(this.airSteerLabel);
            this.Controls.Add(this.stallComboBox);
            this.Controls.Add(this.stallLabel);
            this.Controls.Add(this.notFoundLabel);
            this.Controls.Add(this.controllerLabel);
            this.Controls.Add(this.controllerComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "RLStaller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseWindow);
            this.Load += new System.EventHandler(this.LoadWindow);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox controllerComboBox;
        private System.Windows.Forms.Label controllerLabel;
        private System.Windows.Forms.Label stallLabel;
        private System.Windows.Forms.ComboBox stallComboBox;
        private System.Windows.Forms.Label notFoundLabel;
        private System.Windows.Forms.Label airSteerLabel;
        private System.Windows.Forms.Label airRollLabel;
        private System.Windows.Forms.Label jumpLabel;
        private System.Windows.Forms.Button airSteerButton;
        private System.Windows.Forms.Button airRollButton;
        private System.Windows.Forms.Button jumpButton;
        private System.Windows.Forms.Button refreshButton;
    }
}


namespace UnitsConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            unitsCB = new ComboBox();
            leftUnitCB = new ComboBox();
            rightUnitCB = new ComboBox();
            titleLbl = new Label();
            leftTB = new TextBox();
            rightTB = new TextBox();
            SuspendLayout();
            // 
            // unitsCB
            // 
            unitsCB.BackColor = Color.White;
            unitsCB.DropDownStyle = ComboBoxStyle.DropDownList;
            unitsCB.ForeColor = Color.Black;
            unitsCB.FormattingEnabled = true;
            unitsCB.Items.AddRange(new object[] { "Mass", "Length", "Temperature" });
            unitsCB.Location = new Point(106, 79);
            unitsCB.Name = "unitsCB";
            unitsCB.Size = new Size(341, 23);
            unitsCB.TabIndex = 0;
            unitsCB.SelectedIndexChanged += unitsCB_SelectedIndexChanged;
            // 
            // leftUnitCB
            // 
            leftUnitCB.BackColor = Color.White;
            leftUnitCB.DropDownStyle = ComboBoxStyle.DropDownList;
            leftUnitCB.ForeColor = Color.Black;
            leftUnitCB.FormattingEnabled = true;
            leftUnitCB.Location = new Point(106, 159);
            leftUnitCB.Name = "leftUnitCB";
            leftUnitCB.Size = new Size(121, 23);
            leftUnitCB.TabIndex = 1;
            leftUnitCB.SelectedValueChanged += leftUnitCB_SelectedValueChanged;
            // 
            // rightUnitCB
            // 
            rightUnitCB.BackColor = Color.White;
            rightUnitCB.DropDownStyle = ComboBoxStyle.DropDownList;
            rightUnitCB.ForeColor = Color.Black;
            rightUnitCB.FormattingEnabled = true;
            rightUnitCB.Location = new Point(326, 159);
            rightUnitCB.Name = "rightUnitCB";
            rightUnitCB.Size = new Size(121, 23);
            rightUnitCB.TabIndex = 2;
            rightUnitCB.SelectedValueChanged += rightUnitCB_SelectedValueChanged;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.BackColor = Color.Transparent;
            titleLbl.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(186, 9);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(186, 32);
            titleLbl.TabIndex = 3;
            titleLbl.Text = "Units Converter";
            // 
            // leftTB
            // 
            leftTB.Location = new Point(106, 139);
            leftTB.Name = "leftTB";
            leftTB.Size = new Size(121, 23);
            leftTB.TabIndex = 4;
            leftTB.TextAlign = HorizontalAlignment.Right;
            leftTB.TextChanged += leftTB_TextChanged;
            leftTB.KeyPress += leftTB_KeyPress;
            // 
            // rightTB
            // 
            rightTB.Enabled = false;
            rightTB.Location = new Point(326, 139);
            rightTB.Name = "rightTB";
            rightTB.Size = new Size(121, 23);
            rightTB.TabIndex = 5;
            rightTB.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(555, 250);
            Controls.Add(rightTB);
            Controls.Add(leftTB);
            Controls.Add(titleLbl);
            Controls.Add(rightUnitCB);
            Controls.Add(leftUnitCB);
            Controls.Add(unitsCB);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox unitsCB;
        private ComboBox leftUnitCB;
        private ComboBox rightUnitCB;
        private Label titleLbl;
        private TextBox leftTB;
        private TextBox rightTB;
    }
}

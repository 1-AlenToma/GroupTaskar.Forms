namespace GroupTaskar
{
    partial class frmIcons
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
            lstIcon = new ListView();
            btnSelect = new Button();
            SuspendLayout();
            // 
            // lstIcon
            // 
            lstIcon.Dock = DockStyle.Fill;
            lstIcon.Location = new Point(0, 0);
            lstIcon.Margin = new Padding(4);
            lstIcon.Name = "lstIcon";
            lstIcon.Size = new Size(685, 503);
            lstIcon.TabIndex = 0;
            lstIcon.UseCompatibleStateImageBehavior = false;
            lstIcon.SelectedIndexChanged += lstIcon_SelectedIndexChanged;
            // 
            // btnSelect
            // 
            btnSelect.Dock = DockStyle.Bottom;
            btnSelect.Location = new Point(0, 449);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(685, 54);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // frmIcons
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 503);
            Controls.Add(btnSelect);
            Controls.Add(lstIcon);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            Margin = new Padding(4);
            Name = "frmIcons";
            Text = "Choose Icon";
            Load += frmIcons_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lstIcon;
        private Button btnSelect;
    }
}
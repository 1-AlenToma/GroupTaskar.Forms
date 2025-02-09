namespace GroupTaskar
{
    partial class NewTask
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
            btnSave = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            tFontSize = new TrackBar();
            label4 = new Label();
            listView1 = new ListView();
            pSelectedIcon = new PictureBox();
            btnIconSelection = new Button();
            label3 = new Label();
            cmType = new ComboBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tFontSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pSelectedIcon).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(288, 480);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(412, 539);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(tFontSize);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(pSelectedIcon);
            tabPage1.Controls.Add(btnIconSelection);
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cmType);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(404, 511);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(8, 336);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 17;
            label5.Text = "Font Size:";
            // 
            // tFontSize
            // 
            tFontSize.Location = new Point(97, 326);
            tFontSize.Maximum = 15;
            tFontSize.Name = "tFontSize";
            tFontSize.Size = new Size(298, 45);
            tFontSize.TabIndex = 16;
            tFontSize.TickStyle = TickStyle.Both;
            tFontSize.Value = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(8, 175);
            label4.Name = "label4";
            label4.Size = new Size(237, 21);
            label4.TabIndex = 15;
            label4.Text = "Drag and drop your apps here";
            // 
            // listView1
            // 
            listView1.Location = new Point(8, 209);
            listView1.Name = "listView1";
            listView1.Size = new Size(387, 97);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pSelectedIcon
            // 
            pSelectedIcon.Location = new Point(353, 105);
            pSelectedIcon.Name = "pSelectedIcon";
            pSelectedIcon.Size = new Size(42, 38);
            pSelectedIcon.TabIndex = 13;
            pSelectedIcon.TabStop = false;
            // 
            // btnIconSelection
            // 
            btnIconSelection.Location = new Point(74, 105);
            btnIconSelection.Name = "btnIconSelection";
            btnIconSelection.Size = new Size(273, 38);
            btnIconSelection.TabIndex = 12;
            btnIconSelection.Text = "Select Icon";
            btnIconSelection.UseVisualStyleBackColor = true;
            btnIconSelection.Click += btnIconSelection_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(8, 112);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 11;
            label3.Text = "Icon:";
            // 
            // cmType
            // 
            cmType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmType.FormattingEnabled = true;
            cmType.Location = new Point(74, 62);
            cmType.Name = "cmType";
            cmType.Size = new Size(321, 23);
            cmType.TabIndex = 10;
            cmType.SelectedIndexChanged += cChange;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(8, 63);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 9;
            label2.Text = "Type:";
            // 
            // txtName
            // 
            txtName.Location = new Point(74, 14);
            txtName.Name = "txtName";
            txtName.Size = new Size(321, 23);
            txtName.TabIndex = 8;
            txtName.TextChanged += cChange;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 7;
            label1.Text = "Name:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(404, 511);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // NewTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 539);
            Controls.Add(tabControl1);
            Name = "NewTask";
            Text = "Form1";
            Load += NewTask_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tFontSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pSelectedIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSave;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnIconSelection;
        private ComboBox cmType;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private TabPage tabPage2;
        private PictureBox pSelectedIcon;
        private Label label4;
        private ListView listView1;
        private Label label3;
        private Label label5;
        private TrackBar tFontSize;
    }
}

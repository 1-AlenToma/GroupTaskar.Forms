using System.Data;
using FontAwesome.Sharp;
using GroupTaskar.Core;
using GroupTaskar.Modols;



namespace GroupTaskar
{
    public partial class NewTask : Form
    {
        TasksItem item = new TasksItem();
        public NewTask()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);

        }

        private void overlay(bool transparent = true)
        {
            var color = transparent ? Color.LimeGreen : Color.White;
            if (color == this.BackColor)
                return;
            this.BackColor = tabPage1.BackColor = color;
            //this.TransparencyKey = color;
            foreach (dynamic c in tabPage1.Controls)
            {

                if (c.GetType().GetProperty("BackColor") != null)
                    c.BackColor = color;

            }

        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }


        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 0) return;
            MessageBox.Show(files[0]);
           
            //foreach (string file in files) Console.WriteLine(file);
        }

        private void cChange(object sender, EventArgs e)
        {
            item.Name = txtName.Text;
            if (cmType.SelectedText != "")
                item.Type = (Enums.TaskType)Enum.Parse(typeof(Enums.TaskType), cmType.SelectedText);
        }

        private void Selected()
        {
            if (item.Icon != null && item.Icon.Length > 0)
                pSelectedIcon.Image = IconExtractor.Extract("shell32.dll", int.Parse(item.Icon), true).ToBitmap();
            cmType.SelectedIndex = (int)item.Type;
            txtName.Text = item.Name;

        }

        private void NewTask_Load(object sender, EventArgs e)
        {
            cmType.Items.AddRange(Enum.GetNames(typeof(Enums.TaskType)));
            Selected();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnIconSelection_Click_1(object sender, EventArgs e)
        {
            using (frmIcons frm = new frmIcons())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.item.Icon = frm.Value;
                    Selected();
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroupTaskar.Modols;

namespace GroupTaskar
{
    public partial class frmIcons : Form
    {
        public string Value
        {
            get; set;
        }
        public frmIcons()
        {
            InitializeComponent();
        }

        private void frmIcons_Load(object sender, EventArgs e)
        {
            var count = IconExtractor.Count();
            var phiconLarge = new IntPtr[count];
            var phiconSmall = new IntPtr[count];
            var result = IconExtractor.ExtractIconEx("shell32.dll",0, phiconLarge, null, count);
            ImageList imagelist1 = new ImageList();
            imagelist1.ImageSize = SystemInformation.IconSize;
            imagelist1.Images.AddRange(phiconLarge.Select(x => System.Drawing.Icon.FromHandle(x).ToBitmap()).ToArray());

            lstIcon.LargeImageList = imagelist1;
            // lstIcons.Dock = DockStyle.Fill;
            lstIcon.View = View.LargeIcon;
            lstIcon.Items.AddRange(Enumerable.Range(0, count).Select(x => new ListViewItem(x.ToString(), x)).ToArray());
            lstIcon.Items[0].Selected = true;
            Value = lstIcon.Items[0].Text;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lstIcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIcon.SelectedItems.Count>0)
            {
                Value = lstIcon.SelectedItems[0].Text;
            }
            
           
        }
    }
}

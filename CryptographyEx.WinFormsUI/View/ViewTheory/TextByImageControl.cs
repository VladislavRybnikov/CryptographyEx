using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptographyEx.Theory.Entity;

namespace CryptographyEx.WinFormsUI.View.ViewTheory
{
    public partial class TextByImageControl : UserControl
    {
        private readonly TheoryTextByImageEntity _theoryTextByImageEntity;
        public TextByImageControl
            (TheoryTextByImageEntity theoryTextByImageEntity)
        {
            InitializeComponent();
            _theoryTextByImageEntity = theoryTextByImageEntity;
        }

        private void Init()
        {
            if(_theoryTextByImageEntity.TheoryTextEntity!=null)
            {
                Label label = new Label();
                var thick = _theoryTextByImageEntity.TheoryTextEntity.Thickness;
                label.Image = Image.FromFile(_theoryTextByImageEntity.TheoryImageEntity.Path);

                if(_theoryTextByImageEntity.TheoryImageEntity
                    .HorisontalAligment==Theory.Enum.HorisontalAligment.Center)
                {
                    label.ImageAlign = ContentAlignment.TopCenter;
                }
               
                label.Margin = new Padding(thick.Left, thick.Top, thick.Right, thick.Bottom);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringToBinary
{
    public partial class Form1 : Form
    {
        private ConversionTypeEnum _conversionTypeEnum = ConversionTypeEnum.StringToBinary;
        private BinaryToStringConverter _converter;

        public Form1()
        {
            InitializeComponent();
            _converter = BinaryToStringConverter.GetInstance();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void binaryToStringSet_CheckedChanged(object sender, EventArgs e)
        {
            //StringToBinarySet.Checked = false;
            _conversionTypeEnum = ConversionTypeEnum.BinaryToString;
        }

        private void StringToBinarySet_CheckedChanged(object sender, EventArgs e)
        {
            //binaryToStringSet.Checked = false;
            _conversionTypeEnum = ConversionTypeEnum.StringToBinary;
        }

        private void ConvertButtonClick_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_conversionTypeEnum)
                {
                    case ConversionTypeEnum.BinaryToString:
                        OutputTextBox.Text = _converter.BinaryToString(InputTextBox.Text);
                        break;
                    case ConversionTypeEnum.StringToBinary:
                        OutputTextBox.Text = _converter.StringToBinary(InputTextBox.Text);
                        break;
                }

                ErrorDisplayLabel.Text = "Conversion successful.";
            }
            catch (ArgumentException ex)
            {
                ErrorDisplayLabel.Text = ex.Message;
            }
        }
    }
}

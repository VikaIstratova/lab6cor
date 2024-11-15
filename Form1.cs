using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;


namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // �������� �������� � ��������� ����
                double a = Convert.ToDouble(txtCubeSide.Text);
                double c = Convert.ToDouble(txtRectLength.Text);
                double d = Convert.ToDouble(txtRectWidth.Text);
                double h = Convert.ToDouble(txtRectHeight.Text);

                // �������� ��'���� ��� ���� �� ������������ �������������
                Solid cube = new Cube(a);
                Solid rectSolid = new RectSolid(c, d, h);

                // ��������� ��'���
                double cubeVolume = cube.GetVolume();
                double rectVolume = rectSolid.GetVolume();

                // ������� ����������
                txtCubeVolume.Text = cubeVolume.ToString();
                txtRectVolume.Text = rectVolume.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }
    }
}

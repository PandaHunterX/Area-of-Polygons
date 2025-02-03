using PolygonLibrary;
using System.Diagnostics;

namespace Area_of_Polygons
{
    public partial class MainHome : Form
    {
        public MainHome()
        {
            InitializeComponent();
        }

        private void btn_TriangleArea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TriangleBase.Text) || string.IsNullOrWhiteSpace(txt_TriangleHeight.Text))
            {
                MessageBox.Show("Please enter both the base and height values.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                double Base = Convert.ToDouble(txt_TriangleBase.Text);
                double Height = Convert.ToDouble(txt_TriangleHeight.Text);

                if (Base <= 0 || Height <= 0)
                {
                    MessageBox.Show("Base and Height must be positive numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Polygon Triangle = new Triangle(Base, Height);
                double Area = Triangle.getArea();

                txt_TriangleArea.Text = Area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for the base and height.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_RectangleArea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_RectangleWidth.Text) || string.IsNullOrWhiteSpace(txt_RectangleLength.Text))
            {
                MessageBox.Show("Please enter both the width and length values.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                double Width = Convert.ToDouble(txt_RectangleWidth.Text);
                double Length = Convert.ToDouble(txt_RectangleLength.Text);

                if (Width <= 0 || Length <= 0)
                {
                    MessageBox.Show("Width and Length must be positive numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Polygon Rectangle = new PolygonLibrary.Rectangle(Width, Length);
                double Area = Rectangle.getArea();

                txt_RectangleArea.Text = Area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for the width and length.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SquareArea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_SquareSide.Text))
            {
                MessageBox.Show("Please enter the side value.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                double Side = Convert.ToDouble(txt_SquareSide.Text);

                if (Side <= 0)
                {
                    MessageBox.Show("Side must be a positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Polygon Square = new Square(Side);
                double Area = Square.getArea();

                txt_SquareArea.Text = Area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value for the side.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btm_ParallelogramArea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ParallelogramBase.Text) || string.IsNullOrWhiteSpace(txt_ParallelogramHeight.Text))
            {
                MessageBox.Show("Please enter both the base and height values.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                double Base = Convert.ToDouble(txt_ParallelogramBase.Text);
                double Height = Convert.ToDouble(txt_ParallelogramHeight.Text);

                if (Base <= 0 || Height <= 0) { 
                    MessageBox.Show("Base must be a positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    return; 
                }

                Polygon Parallelogram = new Parallelogram(Base, Height);
                double Area = Parallelogram.getArea();

                txt_ParallelogramArea.Text = Area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for the base and height.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_RhombusArea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_RhombusDiagonal1.Text) || string.IsNullOrWhiteSpace(txt_RhombusDiagonal2.Text))
            {
                MessageBox.Show("Please enter both the diagonal values.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                double Diagonal1 = Convert.ToDouble(txt_RhombusDiagonal1.Text);
                double Diagonal2 = Convert.ToDouble(txt_RhombusDiagonal2.Text);

                if (Diagonal1 <= 0 || Diagonal2 <= 0)
                {
                    MessageBox.Show("Diagonals must be positive numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Polygon Rhombus = new Rhombus(Diagonal1, Diagonal2);
                double Area = Rhombus.getArea();

                txt_RhombusArea.Text = Area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for the diagonals.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TrapezoidArea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TrapezoidShortBase.Text) || string.IsNullOrWhiteSpace(txt_TrapezoidLongBase.Text) || string.IsNullOrWhiteSpace(txt_TrapezoidHeight.Text))
            {
                MessageBox.Show("Please enter all the base and height values.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                double ShortBase = Convert.ToDouble(txt_TrapezoidShortBase.Text);
                double LongBase = Convert.ToDouble(txt_TrapezoidLongBase.Text);
                double Height = Convert.ToDouble(txt_TrapezoidHeight.Text);

                if (ShortBase <= 0 || LongBase <= 0 || Height <= 0)
                {
                    MessageBox.Show("Bases and Height must be positive numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Polygon Trapezoid = new Trapezoid(ShortBase, LongBase, Height);
                double Area = Trapezoid.getArea();

                txt_TrapezoidArea.Text = Area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for the bases and height.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_KiteArea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_KiteBase.Text) || string.IsNullOrWhiteSpace(txt_KiteHeight.Text))
            {
                MessageBox.Show("Please enter both the base and height values.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                double Base = Convert.ToDouble(txt_KiteBase.Text);
                double Height = Convert.ToDouble(txt_KiteHeight.Text);

                if (Base <= 0 || Height <= 0)
                {
                    MessageBox.Show("Base and Height must be positive numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Polygon Kite = new Kite(Base, Height);
                double Area = Kite.getArea();

                txt_KiteArea.Text = Area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for the base and height.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_PentagonArea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_PentagonPerimeter.Text) || string.IsNullOrWhiteSpace(txt_PentagonApothem.Text))
            {
                MessageBox.Show("Please enter both the perimeter and apothem values.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                double Perimeter = Convert.ToDouble(txt_PentagonPerimeter.Text);
                double Apothem = Convert.ToDouble(txt_PentagonApothem.Text);

                if (Perimeter <= 0 || Apothem <= 0)
                {
                    MessageBox.Show("Perimeter and Apothem must be positive numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Polygon Pentagon = new Pentagon(Perimeter, Apothem);
                double Area = Pentagon.getArea();

                txt_PentagonArea.Text = Area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for the perimeter and apothem.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenLink("https://github.com/PandaHunterX");
        }

        private void label34_Click(object sender, EventArgs e)
        {
            OpenLink("https://github.com/PandaHunterX");
        }
    }
}
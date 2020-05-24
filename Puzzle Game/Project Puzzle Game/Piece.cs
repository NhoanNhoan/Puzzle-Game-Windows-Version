using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Project_Puzzle_Game
{
    class Piece : PictureBox
    {
        // To check right location
        static bool[][] MatrixRightLocation = null;

        // Root Image
        static Image RootImage;

        // Size of Root Image
        static Size SizeRootImage = new Size();

        // Generate random location
        static Random rd = new Random();

        // Save right location
        int ID;

        // Save previous location
        Point PreviousLocation = new Point();

        // For mouse click event
        bool IsDown = false;

        // On/Off Highlight
        bool IsHighlighted = false;

        // Init root image
        public static void SetRootImage(Image _Img)
        {
            RootImage = _Img;
            SizeRootImage = _Img.Size;
        }

        public static void InitMatrixRightLocation(int _Rows, int _Cols)
        {
            MatrixRightLocation = new bool[_Rows][];

            for (int i = 0; i < _Rows; ++i)
            {
                MatrixRightLocation[i] = new bool[_Cols];
            }
        }

        private void RandomLocation()
        {
            Left = rd.Next((Form1.Columns - 1) * Width);
            Top = rd.Next((Form1.Rows - 1) * Height);
        }

        public Piece(int _Rows, int _Columns)
        {
            ID = _Rows * Form1.Columns + _Columns;

            Width = SizeRootImage.Width / Form1.Columns;
            Height = SizeRootImage.Height / Form1.Rows;

            Bitmap bitmap = new Bitmap(Width, Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.DrawImage(RootImage,
                                                new RectangleF(0, 0, Width, Height),
                                                new Rectangle(_Columns * Width, _Rows * Height, Width, Height),
                                                GraphicsUnit.Pixel);
            Image = bitmap;
            RandomLocation();
        }

        public static Image GetRootImage()
        {
            return RootImage;
        }

        public int GetID()
        {
            return ID;
        }

        public void TurnOnHighLight()
        {
            IsHighlighted = true;
            Graphics graphics = CreateGraphics();
            PaintEventArgs e = new PaintEventArgs(graphics, new Rectangle());
            OnPaint(e);
        }

        public void TurnOffHighLight()
        {
            IsHighlighted = false;
            Graphics graphics = CreateGraphics();
            PaintEventArgs e = new PaintEventArgs(graphics, new Rectangle());
            OnPaint(e);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (IsHighlighted)
            {
                var rect = ClientRectangle;
                var borderColor = Color.ForestGreen;
                var borderStyle = ButtonBorderStyle.Solid;
                var borderWidth = 5;

                ControlPaint.DrawBorder(
                                    pe.Graphics,
                                    rect,
                                    borderColor,
                                    borderWidth,
                                    borderStyle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle);
            }
        }

        // Check whether to win
        private bool IsComplete()
        {
            for (int i = 0; i < MatrixRightLocation.Length; ++i)
            {
                for (int j = 0; j < MatrixRightLocation[i].Length; ++j)
                    if (!MatrixRightLocation[i][j])
                        return false;
            }

            return true;
        }

        private void CheckLocationMatch(int _Rows, int _Columns)
        {
            int RightRows = ID / Form1.Columns;
            int RightColumns = ID % Form1.Columns;

            if (_Rows == RightRows && _Columns == RightColumns)
            {
                MatrixRightLocation[RightRows][RightColumns] = true;
            }
            else
            {
                MatrixRightLocation[RightRows][RightColumns] = false;
            }

            if (IsComplete())
            {
                Congratulations form = new Congratulations();
                form.ShowDialog();
                Form1.IsVictory = true;

                if (Form1.Remote != null)
                {
                    Form1.Remote.Close();
                }

                if (Form1.TurtorialForm != null)
                {
                    Form1.TurtorialForm.Close();
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs mouse)
        {
            base.OnMouseMove(mouse);
            if (IsDown)
            {
                Left += (mouse.X - PreviousLocation.X);
                Top += (mouse.Y - PreviousLocation.Y);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            BringToFront();
            base.OnMouseDown(e);
            IsDown = true;
            IsHighlighted = true;
            PreviousLocation.X = e.X;
            PreviousLocation.Y = e.Y;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            IsDown = false;
            IsHighlighted = false;
            Invalidate();

            int curCols = (Location.X * Form1.Columns / SizeRootImage.Width);
            int curRows = (Location.Y * Form1.Rows / SizeRootImage.Height);

            if ((1.0 * Location.X * Form1.Columns / SizeRootImage.Width) - curCols >= 0.5)
            {
                ++curCols; 
            }

            if ((1.0 * Location.Y * Form1.Rows / SizeRootImage.Height) - curRows >= 0.5)
            {
                ++curRows;
            }

            if (curCols < 0)
            {
                curCols = 0;
            }
            else
            {
                if (curCols >= Form1.Columns)
                {
                    curCols = Form1.Columns - 1;
                }
            }

            if (curRows < 0)
            {
                curRows = 0;
            }
            else
            {
                if (curRows >= Form1.Rows)
                {
                    curRows = Form1.Rows - 1;
                }
            }

            Left = curCols * Width;
            Top = curRows * Height;

            PreviousLocation = new Point(e.X, e.Y);

            CheckLocationMatch(curRows, curCols);
        }

        // Method for Remote
        public void MoveUp()
        {
            BringToFront();
            TurnOnHighLight();

            int CurrentRows = Location.Y / Height;
            int CurrentColumns = Location.X / Width;

            if (CurrentRows > 0)
            {
                --CurrentRows;
            }

            Top = CurrentRows * Height;

            CheckLocationMatch(CurrentRows, CurrentColumns);
        }

        public void MoveDown()
        {
            BringToFront();
            TurnOnHighLight();

            int CurrentRows = Location.Y / Height;
            int CurrentColumns = Location.X / Width;

            if (CurrentRows < Form1.Rows - 1)
            {
                ++CurrentRows;
            }

            Top = CurrentRows * Height;

            CheckLocationMatch(CurrentRows, CurrentColumns);
        }

        public void MoveLeft()
        {
            BringToFront();
            TurnOnHighLight();

            int CurrentRows = Location.Y / Height;
            int CurrentColumns = Location.X / Width;

            if (CurrentColumns > 0)
            {
                --CurrentColumns;
            }

            Left = CurrentColumns * Width;

            CheckLocationMatch(CurrentRows, CurrentColumns);
        }

        public void MoveRight()
        {
            BringToFront();
            TurnOnHighLight();

            int CurrentRows = Location.Y / Height;
            int CurrentColumns = Location.X / Width;

            if (CurrentColumns < Form1.Columns - 1)
            {
                ++CurrentColumns;
            }

            Left = CurrentColumns * Width;

            CheckLocationMatch(CurrentRows, CurrentColumns);
        }
    }
}

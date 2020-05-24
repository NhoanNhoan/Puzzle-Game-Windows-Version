using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Puzzle_Game
{
    public partial class Form1 : Form
    {
        // To mark pieces
        internal static Piece[][] Pieces= null;

        // Determine vitory or not
        internal static bool IsVictory;

        // Number of Rows
        internal static int Rows;

        // Number of Columns
        internal static int Columns;

        // Tutorial form
        internal static Form TurtorialForm = null;

        // Remote form
        internal static RemoteForm Remote = null;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ckTutorial.Enabled = false;
            ckRemote.Enabled = false;
        }

        //
        // Helper area
        //

        private void InitPiecesMatrix()
        {
            Pieces = new Piece[Rows][];

            for (int i = 0; i < Rows; ++i)
            {
                Pieces[i] = new Piece[Columns];
            }
        }

        private bool SelectPicture()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG |*.jpg";
            ofd.Multiselect = false;
            ofd.ShowDialog();

            string imgPath = ofd.FileName;

            if (imgPath == String.Empty)
            {
                MessageBox.Show("No picture is selected! This game is not continue.", "Error No Picture");
                return false;
            }

            Image image = new Bitmap(imgPath);
            Bitmap bitmap = new Bitmap(panelPlay.Width, panelPlay.Height);

            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(image,
                new RectangleF(0, 0, panelPlay.Width, panelPlay.Height),
                new RectangleF(0, 0, image.Width, image.Height),
                GraphicsUnit.Pixel);

            Piece.SetRootImage(bitmap);

            return true;
        }

        private void GeneratePieces()
        {
            InitPiecesMatrix();

            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    Piece piece = new Piece(i, j);
                    panelPlay.Controls.Add(piece);
                    Pieces[i][j] = piece;
                }
            }
        }

        internal static Piece FindPiece(int ID)
        {
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    if (Pieces[i][j].GetID() == ID)
                    {
                        return Pieces[i][j];
                    }
                }
            }

            return null;
        }

        //
        // Event
        //

        private void bntNewGame_Click(object sender, EventArgs e)
        {
            if (!SelectPicture())
            {
                return;
            }

            if (IsVictory)
            {
                ckTutorial.Enabled = false;
                ckRemote.Enabled = false;
            }

            panelPlay.Controls.Clear();


            // Create 2 labels
            Label lbCol = new Label();
            Label lbRow = new Label();

            lbCol.AutoSize = lbRow.AutoSize = true;
            lbCol.Text = "Enter number of columns:";
            lbRow.Text = "Enter number of rows:";

            lbCol.Location = new Point(0, 10);
            lbRow.Location = new Point(0, 50);

            lbCol.BackColor = lbRow.BackColor = Color.DodgerBlue;

            lbCol.Font = lbRow.Font = new Font("Lucida Calligraphy", 12);

            panelPlay.Controls.Add(lbCol);
            panelPlay.Controls.Add(lbRow);


            // Create 2 numeric up down
            NumericUpDown numCol = new NumericUpDown();
            NumericUpDown numRow = new NumericUpDown();

            numCol.Location = new Point(250, 10);
            numRow.Location = new Point(250, 50);

            numCol.Size = numRow.Size = new Size(50, 50);

            panelPlay.Controls.Add(numCol);
            panelPlay.Controls.Add(numRow);


            // Create start button
            Button btnStart = new Button();

            btnStart.Text = "Start";
            btnStart.Location = new Point(350, 10);
            btnStart.Size = new Size(100,65);
            btnStart.BackColor = Color.SlateGray;
            btnStart.Font = new Font("Monotype Corsiva", 19);

            numCol.ValueChanged += NumCol_ValueChanged;
            numRow.ValueChanged += NumRow_ValueChanged;
            btnStart.Click += BtnStart_Click;

            panelPlay.Controls.Add(btnStart);
        }

        private void NumRow_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown obj = sender as NumericUpDown;
            Rows = (int)obj.Value;
        }

        private void NumCol_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown obj = sender as NumericUpDown;
            Columns = (int)obj.Value;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if(Columns < 4 || Columns > 9)
            {
                MessageBox.Show("The number of columns must be at least 4 and less than 10.");
            }
            else if (Rows < 3 || Rows > 9)
            {
                MessageBox.Show("The number of rows must be at least 3. and less than 10");
            }
            else
            {
                panelPlay.Controls.Clear();
                ckRemote.Enabled = true;
                ckTutorial.Enabled = true;
                Piece.InitMatrixRightLocation(Rows, Columns);
                GeneratePieces();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckTutorial_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTutorial.Checked == true)
            {
                Form Turtorial_Form = new Form();
                PictureBox TurtorialPicture = new PictureBox();
                Image TurtorialImage = Piece.GetRootImage();

                // set form's attribute
                Turtorial_Form.Text = "Suggestion";
                Turtorial_Form.AutoSize = true;
                Turtorial_Form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                Turtorial_Form.Controls.Add(TurtorialPicture);

                // set picture's attribute
                TurtorialPicture.Width = TurtorialImage.Width / 2;
                TurtorialPicture.Height = TurtorialImage.Height / 2;
                TurtorialPicture.Dock = DockStyle.Bottom;
                TurtorialPicture.Image = new Bitmap(TurtorialImage, new Size(TurtorialImage.Width / 2, TurtorialImage.Height / 2));

                // show tutorial form
                Turtorial_Form.Show();

                // set start position
                StartPosition = FormStartPosition.CenterParent;

                // event for closing
                Turtorial_Form.FormClosing += TurtorialForm_FormClosing;

                TurtorialForm = Turtorial_Form;
            }
            else
            {
                TurtorialForm.Close();
                TurtorialForm = null;
            }
        }

        private void TurtorialForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ckTutorial.Checked == true)
            {
                ckTutorial.Checked = false;
            }
        }

        private void ckRemote_CheckedChanged(object sender, EventArgs e)
        {
            if (ckRemote.Checked == true)
            {
                RemoteForm remote = new RemoteForm();
                remote.Show();

                RemoteForm.piece = Form1.FindPiece(RemoteForm.Item_th);

                if (RemoteForm.piece != null)
                {
                    RemoteForm.piece.BringToFront();
                    RemoteForm.piece.TurnOnHighLight();
                }

                remote.FormClosing += Remote_FormClosing;

                Remote = remote;
            }
            else
            {
                Remote.Close();
                Remote = null;
            }
        }

        private void Remote_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ckRemote.Checked == true)
            {
                ckRemote.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

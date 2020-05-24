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
    public partial class RemoteForm : Form
    {
        // Determine a selected piece
        internal static int Item_th = 0;

        // References to a selected piece
        internal static Piece piece = null;
        
        public RemoteForm()
        {
            InitializeComponent();

            // Set start position
            StartPosition = FormStartPosition.CenterParent;

            // Set atributes for label which display Item_th
            lbNumItem.Text = Item_th.ToString();
            lbNumItem.AutoSize = true;
            lbNumItem.Font = new Font("Californian FB", 15);

            // Set Click events for movement keys
            btnUp.Click += BtnUp_Click;
            btnDown.Click += BtnDown_Click;
            btnLeft.Click += BtnLeft_Click;
            btnRight.Click += BtnRight_Click;

            // Form Closing Event
            FormClosing += RemoteForm_Closing;
        }

        // 
       // THE AREA OF MOVEMENT BUTTONS CLICK EVENT
       //
        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (piece != null)
            {
                piece.MoveRight();
            }
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            if (piece != null)
            {
                piece.MoveLeft();
            }
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            if (piece != null)
            {
                piece.MoveDown();
            }
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            if (piece != null)
            {
                piece.MoveUp();
            }
        }

        //
        // END THE AREA
        //

         //
        // INCREASE AND DECREASE BUTTON CLICK EVENT
        //
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (piece != null)
            {
                piece.TurnOffHighLight();
            }

            if (Item_th < Form1.Columns * Form1.Rows - 1)
            {
                ++Item_th;
                lbNumItem.Text = Item_th.ToString();
            }

            piece = Form1.FindPiece(Item_th);
            if (piece != null)
            {
                piece.BringToFront();
                piece.TurnOnHighLight();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (piece != null)
            {
                piece.TurnOffHighLight();
            }

            if (Item_th > 0)
            {
                --Item_th;
                lbNumItem.Text = Item_th.ToString();
            }

            piece = Form1.FindPiece(Item_th);
            if (piece != null)
            {
                BringToFront();
                piece.TurnOnHighLight();
            }
        }
        
        //
        // END THE AREA
        //
        
         //
        // THE AREA OF EVENT FORM
        //
        private void RemoteForm_Load(object sender, EventArgs e)
        {
        }

        private void RemoteForm_Closing(object sender, FormClosingEventArgs e)
        {
            piece.TurnOffHighLight();
        }
        
        //
        // END THE AREA
        //
    }
}

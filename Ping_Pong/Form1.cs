using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_Pong
{
    public partial class Form1 : Form
    {
      
        public int v_dr = 7;           // viteza mingii
        public int v_sus = 7;
        public int scor = 0;       //scorul jocului
        public int points1 = 0;
        public int points2 = 0;
        public int x = 300;
        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();                                //Ascunde cursorul
            this.FormBorderStyle = FormBorderStyle.None;  //Inlatura orice fel de border

            this.TopMost = true;                            // Pune Form in fata
            this.Bounds = Screen.PrimaryScreen.Bounds;      //Intra in fullscreen

            bara.Top = playground.Bottom - (playground.Bottom / 10); // seteaza posiztia barei

            stop_joc.Left = (playground.Width / 2) - (stop_joc.Width / 2);
            stop_joc.Top = (playground.Height / 2) - (stop_joc.Height / 2);
            stop_joc.Visible = false;
            ply1.Left = (playground.Width / 2);
            ply2.Left = (playground.Width / 2) ;
            ply1.Top = (playground.Height / 2) ;
            ply2.Left = (playground.Height / 2);
            ply1.Visible = false;
            ply2.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bara.Left = Cursor.Position.X - (bara.Width / 2);   // pune bara in positia cursorului

            bara2.Left = x;

            
            
            minge.Left += v_dr;         //aici se misca mingea :)
            minge.Top += v_sus;

            if(minge.Bottom >= bara.Top && minge.Bottom <= bara.Bottom  && minge.Left >= bara.Left && minge.Right <= bara.Right)  //cand se loveste minge de bara1
            {
                //v_sus += 1;
                //v_dr += 2;
                v_sus = -v_sus;  // schimba directia mingii;

                puncte_lbl.Text = Convert.ToString(points1);
                Random r = new Random();
                playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
                
            }


            if (minge.Top <= bara2.Bottom && minge.Top >= bara2.Top && minge.Left >= bara2.Left && minge.Right <= bara2.Right)  //cand se loveste minge de bara2
            {
                //v_sus += 1;
                //v_dr += 2;
                v_sus = -v_sus;  // schimba directia mingii;
                

                puncte2_lbl.Text = Convert.ToString(points2);
                Random r = new Random();
                playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));

            }

            if(minge.Left <= playground.Left)
            {
                v_dr = -v_dr;
                
            }

            if (minge.Right >= playground.Right)
            {
                v_dr = -v_dr;
            }

      
            if (minge.Bottom >= playground.Bottom)
            {
                //timer1.Enabled = false;  // Opreste Jocul
                //stop_joc.Visible = true;
                //ply2.Visible = true;
                minge.Top = 100;
                minge.Left = 100;
                v_sus = 10;
                v_dr = 10;
                points2 += 1;
                puncte2_lbl.Text = Convert.ToString(points2);
            }

            if (minge.Top <= playground.Top)
            {
                //timer1.Enabled = false;  // Opreste Jocul
                //stop_joc.Visible = true;
               // ply1.Visible = true;
                v_sus = 7;
                v_dr = 7;
                minge.Top = 100;
                minge.Left = 100;
                points1 += 1;
                puncte_lbl.Text = Convert.ToString(points1);
               
            }
        
            
            if(points1==5)
            {
                timer1.Enabled = false;  // Opreste Jocul
                stop_joc.Visible = true;
                ply1.Visible = true;
                minge.Top = 100;
                minge.Left = 100;
                v_sus = 7;
                v_dr = 7;
            }

            if (points2 == 5)
            {
                timer1.Enabled = false;  // Opreste Jocul
                stop_joc.Visible = true;
                ply2.Visible = true;
                minge.Top = 100;
                minge.Left = 100;
                v_sus = 7;
                v_dr = 7;
            }
               
         }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Application.Exit();  // apasa pe escape ca sa inchizi aplicatia
            if(e.KeyCode==Keys.F1)
            {
                minge.Top = 100;
                minge.Left = 100;
                v_sus = 10;
                v_dr = 10;
                stop_joc.Visible = false;
                timer1.Enabled = true;   
                ply1.Visible = false;
                ply2.Visible = false;
                points1 = 0;
                points2 = 0;
                puncte_lbl.Text = "0";
                puncte2_lbl.Text="0";
            }
            if (e.KeyData == Keys.D)
            {
                x += 50;
                bara2.Left = x;
            }

            if (e.KeyData == Keys.A)
            {
                x -= 50;
                bara2.Left = x;
            }
        }




    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corvette_Picker
{
    public partial class Corvette : Form
    {


        CorvetteConfiguration mycorvette = new CorvetteConfiguration();
       
        
        public Corvette()
        {
            InitializeComponent();
        }

       

        private void rbtop_CheckedChanged(object sender, EventArgs e)
        {
            mycorvette.setTop("up");
            pbcar.ImageLocation = mycorvette.changePicture();
        }

        private void rbdown_CheckedChanged(object sender, EventArgs e)
        {
            mycorvette.setTop("down");
            pbcar.ImageLocation = mycorvette.changePicture();
            //
        }

        private void rbwhite_CheckedChanged(object sender, EventArgs e)
        {
            mycorvette.setColor("w");
            pbcar.ImageLocation = mycorvette.changePicture();
            lblprice.Text = "$" + mycorvette.calcPrice().ToString();
        }

        private void rbred_CheckedChanged(object sender, EventArgs e)
        {
            mycorvette.setColor("r");
            pbcar.ImageLocation = mycorvette.changePicture();
            lblprice.Text = "$" + mycorvette.calcPrice().ToString();
        }

        private void cbFLS_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFLS.Checked == false)
            {
                mycorvette.setFLS(false);
            }
            else if (cbFLS.Checked)
            {
                mycorvette.setFLS(true);
            }
            lblprice.Text = "$" + mycorvette.calcPrice().ToString();
        }

        private void Corvette_Load(object sender, EventArgs e)
        {
            rbtrim1.Checked = true;
            rbwhite.Checked = true;
            lblprice.Text = "$" + mycorvette.getBasePrice().ToString();
            lblprice.Width = 285;
            lblprice.Height = 95;
        }

        private void rbtrim2_CheckedChanged(object sender, EventArgs e)
        {
            mycorvette.setTrim(2);
            lblprice.Text = "$" + mycorvette.calcPrice().ToString();
            if (mycorvette.getTrim() == 2)
            {
                
                cbFLS.Enabled = true;
            }
        }

        private void rbtrim1_CheckedChanged(object sender, EventArgs e)
        {
            mycorvette.setTrim(1);
           
           
            if (mycorvette.getTrim() == 1)
            {
                mycorvette.setFLS(false);
                cbFLS.Checked = false;
              
                cbFLS.Enabled = false;
            }
            lblprice.Text = "$" + mycorvette.calcPrice().ToString();
           
        }

        private void cbspoiler_CheckedChanged(object sender, EventArgs e)
        {
            if(cbspoiler.Checked == false)
            {
                mycorvette.setSpoiler(false);
                pbcar.ImageLocation = mycorvette.changePicture();
            }  else if(cbspoiler.Checked)
            {
                mycorvette.setSpoiler(true);
                pbcar.ImageLocation = mycorvette.changePicture();

            }
            lblprice.Text = "$" + mycorvette.calcPrice().ToString();
        }

        private void cblogo_CheckedChanged(object sender, EventArgs e)
        {
            if(cblogo.Checked == false)
            {
                mycorvette.setLogo(false);
                //
            } else if(cblogo.Checked)
            {
                mycorvette.setLogo(true);
                //
            }
            lblprice.Text = "$" + mycorvette.calcPrice().ToString();
        }

        private void cbfloormats_CheckedChanged(object sender, EventArgs e)
        {
            if(cbfloormats.Checked == false)
            {
                mycorvette.setfloormats(false);
            } else if(cbfloormats.Checked)
            {
                mycorvette.setfloormats(true);
            }
            lblprice.Text = "$" + mycorvette.calcPrice().ToString();
          
        }

        private void cbspoiler_CheckStateChanged(object sender, EventArgs e)
        {
            //not needed
        }

        private void lbltrimprice_Click(object sender, EventArgs e)
        {
            //
        }

        private void rbtrim1_Click(object sender, EventArgs e)
        {
            Trim1InfoForm ftrim1 = new Trim1InfoForm();
            ftrim1.Show();
        
            
            

        }

        private void rbtrim2_Click(object sender, EventArgs e)
        {
            trim2info ftrim2 = new trim2info();
            ftrim2.Show();
        }

        private void lblprice_Click(object sender, EventArgs e)
        {
           //
            
        }
    }

}

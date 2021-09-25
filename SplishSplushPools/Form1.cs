using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplishSplushPools
{
    public partial class Form1 : Form   //Driver Code Or Code under button
    {
        public Form1()
        {
            InitializeComponent();
            cmbPoolType.Items.Add("Heated Pool");  
            cmbPoolType.Items.Add("Salt water Pool");

            grpHeatingPool.Visible = false;
            grpSaltPool.Visible = false;

            txtNumOfLitres.Visible = false;
            txtBasicPoolCost.Visible = false;
            txtpooltypeResults.Visible = false;

            txtHeatedPoolCost.Visible = false;
            txtSaltCost.Visible = false;
            txtSaltWaterCost.Visible = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void cmbPoolType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPoolType.SelectedIndex == 0) //Takes the first option in a combobox
            {
                grpHeatingPool.Visible = true;
                grpSaltPool.Visible = false;
            }
            else if(cmbPoolType.SelectedIndex == 1)//Takes the second option in a combobox
            {
                
                grpSaltPool.Visible = true;
                grpHeatingPool.Visible = false;
            }
           
        }
      
        private void btnProcess_Click(object sender, EventArgs e)
        {
            double Length;
            double Width;
            double Depth;
            cmbPoolType.GetItemText(ToString());


            double NumberOfLitres = 0;
            double PoolCost = 0;

            double HeatingCost = 0;
            double SaltCost=0;
          
            Length = double.Parse(txtLength.Text);
            Width = double.Parse(txtWidth.Text);
            Depth = double.Parse(txtDepth.Text);
 
            Basic_Pool objB = new Basic_Pool(Length, Width, Depth); //--Parameterised Constructor

            //objB.propLength = Length;       //--Default Constructor
            //objB.propWidth = Width;          //--Default Constructor
            //objB.propDepth = Depth;          //--Default Constructor

            NumberOfLitres = objB.CalcNumberOfLitres();
            PoolCost = objB.CalcBasicCost();
            txtNumOfLitres.Text = NumberOfLitres.ToString("0.00")+" "+"Litres";
            txtBasicPoolCost.Text = PoolCost.ToString("C");
          

            txtNumOfLitres.Visible = true;
            txtBasicPoolCost.Visible = true;
            txtpooltypeResults.Visible = true;

           
            //Heated Pool
            if (cmbPoolType.SelectedIndex==0)
            {
                if (radSolarHeating.Checked)
                {
                    HeatingCost = 10000;
                }
                else if (radHeatPump.Checked)
                {
                    HeatingCost = 45000;
                }
                else if (radGeyser.Checked)
                {
                    HeatingCost = 15000;
                    
                }
                
                txtHeatedPoolCost.Visible = true;
                txtpooltypeResults.Text = cmbPoolType.SelectedItem.ToString(); //cmbPoolType is a comboBox name from GUI Properties



                Heated_Pool objH = new Heated_Pool(Length, Width, Depth, HeatingCost);
                PoolCost = objH.CalcBasicCost();
                txtHeatedPoolCost.Text = PoolCost.ToString("C");
            }
           
            //Salt Water Pool
            else if (cmbPoolType.SelectedIndex==1)
            {
                
                Salt_Water_Pool objS = new Salt_Water_Pool(Length, Width, Depth);  //--Default Constructor

                SaltCost = objS.CalcSaltCost();
                PoolCost = objS.CalcBasicCost();

                txtSaltCost.Visible = true;
                txtSaltWaterCost.Visible = true;
                txtpooltypeResults.Text = cmbPoolType.SelectedItem.ToString();   //cmbPoolType is a comboBox name from GUI Properties

                txtSaltCost.Text = SaltCost.ToString("C");
                txtSaltWaterCost.Text = PoolCost.ToString("C");
            }   
        }
    }
}

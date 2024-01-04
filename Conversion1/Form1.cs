using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace ChamaBasinMiner
{
    public partial class Form1 : Form
    {
        int num_of_mineral_types;
        string[] mineral_symbol;
        string[] mineral_name;
        int[] num_of_mineral_tons;
        string[] output_messages;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        
        private void makeLabel(int x, int y, String str)
        {
          
        }

        
        private void userInputInt(TextBox t)
        {
           
        }

        
        private void Next_Click(object sender, EventArgs e)
        {
            
            
        }
    
        private void makeMineralsProcess(String str)
        {
           
        }
        
        private void userInputMineralSymbol()
        {
            
        }
        
        private void userInputTempMineralName()
        {
            
        }
         
        private void userInputTempTonnage()
        {
            

        }

        
        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void MineralTypesNumBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                num_of_mineral_types = Convert.ToInt32(MineralTypesNumTxtBox.Text);
                if (num_of_mineral_types < 10 && num_of_mineral_types > 0)
                {
                    MineralTypesNumBtn.Enabled = false;
                    MineralTypesNumTxtBox.Enabled = false;
                    MineralTypesNumBtn.Visible = false;
                    MineralTypesNumTxtBox.Visible = false;
                    MineralTypesNumResponseLabel.Text = $"You selected to create {num_of_mineral_types} minerals.";
                    MineralSymbolLabel.Text = "You will now enter in the mineral symbol, it's name, and how much has been mined in tons. The market rate for $USD per ton will be randomly generated.";
                    MineralSymbolInputLabel.Text = "Please enter the three to five alphanumeric mineral symbol.";
                    MineralSymbolNextBtn.Enabled = true;
                    MineralSymbolTextBox.Enabled = true;
                    MineralSymbolLabel.Visible = true;
                    MineralTypesNumResponseLabel.Visible = true;
                    MineralSymbolInputLabel.Visible = true;
                    MineralSymbolNextBtn.Visible = true;
                    MineralSymbolTextBox.Visible = true;
                }
                else
                {
                    MessageBox.Show("The entry needs to be greater than zero and no greater than 10.\nPlease enter a new number.", "Error", MessageBoxButtons.OK);
                }

            }
            catch (System.FormatException) 
            {
                MessageBox.Show("The entry needs to be greater than zero and no greater than 10.\nPlease enter a new number.", "Error", MessageBoxButtons.OK);
            };
        }

        private void MineralSymbolNextBtn_Click(object sender, EventArgs e)
        {
            MineralSymbolTextBox.Enabled = false;
            MineralSymbolNextBtn.Enabled = false;
            MineralSymbolTextBox.Visible = false;
            MineralSymbolNextBtn.Visible = false;
            MineralNameLabel.Text = "Please enter the mineral name.";
            MineralNameLabel.Visible = true;
            MineralNameTextBox.Enabled = true;
            MineralNameNextBtn.Enabled = true;
            MineralNameTextBox.Visible = true;
            MineralNameNextBtn.Visible = true;

        }

        private void MineralNameNextBtn_Click(object sender, EventArgs e)
        {
            MineralNameTextBox.Enabled = false;
            MineralNameNextBtn.Enabled = false;
            MineralNameTextBox.Visible = false;
            MineralNameNextBtn.Visible = false;
            MineralTonsLabel.Text = "Please enter the total number of tons that were mined.";
            MineralTonsLabel.Visible = true;
            MineralTonsTextBox.Enabled = true;
            MineralTonsTextBox.Visible = true;
            MineralTonsNextBtn.Enabled = true;
            MineralTonsNextBtn.Visible = true;

        }

        private void MineralTonsNextBtn_Click(object sender, EventArgs e)
        {
            FinalOutputMessages.Visible = true;
            
            FinalOutputMessages.Text = $"[Mineral Symbol: {mineral_symbol}].[Mineral Name: {mineral_name}].[Market $USD/Ton: $].[Total Tonnage Mined: {num_of_mineral_tons}].[Estimated Market Value: $]";
        }
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /*
             * Din cauza ca sunt mai multe contexte, pentru a rula exemplele trebui rulate urmatoarele comenzi in PM Console:
             * Pentru Ex1:
             * Enable-Migrations -ContextTypeName Lab5.ModelSelfReferences -Force
             * 
             * Ex2:
             * Enable-Migrations -ContextTypeName Lab5.ProductContext -Force
             * 
             * Ex3: 
             * Enable-Migrations -ContextTypeName Lab5.PhotographContext -Force
             * 
             * Ex4:
             * Enable-Migrations -ContextTypeName Lab5.BusinessContext -Force
             *
             * Ex5:
             * Enable-Migrations -ContextTypeName Lab5.EmployeeContext -Force
             * 
             * 
             * 
             * Comenzi pentru toate exemplele:
             * add-miration
             * update-database
             * 
             * Rezultatele o sa apare in Tab-ul output dupa inchiderea Form1.
             */
            //Examples.Ex1();
            //Examples.Ex2();
            //Examples.Ex3();
            //Examples.Ex4();
            Examples.Ex5();

        }
       
    }
}

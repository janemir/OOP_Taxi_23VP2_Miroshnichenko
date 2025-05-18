using OOP_Taxi_23VP2;
using System;
using System.Windows.Forms;

namespace OOP_Taxi_23VP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {

            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Column1", "ФИО водителя");
            dataGridView1.Columns.Add("Column2", "Гос. номер автомобиля");
            dataGridView1.Columns.Add("Column3", "Номер телефона клиента");
            dataGridView1.Columns.Add("Column4", "Статус заказа");

            dataGridView1.Columns["Column1"].Width = 250;  
            dataGridView1.Columns["Column2"].Width = 100;  
            dataGridView1.Columns["Column3"].Width = 100;  
            dataGridView1.Columns["Column4"].Width = 100;  

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; 
            dataGridView1.AllowUserToResizeColumns = true; 
        }
    }
}




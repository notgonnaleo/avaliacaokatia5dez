using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud.Models;
using MySql.Data.MySqlClient;


namespace Crud
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            listagem();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcnpj_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrazao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtend_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfantasia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtins_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            try
            {
                string db = "datasource=localhost;username=root;password=1234;database=crud";
                var conn = new MySqlConnection(db);
                conn.Open();

                var cnpj = txtcnpj.Text;
                var razao = txtrazao.Text;
                var end = txtend.Text;
                var fantasia = txtfantasia.Text;
                var tel = txttel.Text;
                var inscricao = txtins.Text;

                var obj = new Fornecedor()
                {
                    cnpj = cnpj,
                    razao_social = razao,
                    endereco = end,
                    nome_fantasia = fantasia,
                    telefone = tel,
                    ins_est = inscricao
                };

                string query = $"INSERT INTO fornecedor(cnpj, razao_social, endereco, nome_fantasia, telefone, ins_est) " +
                    $"VALUES " +
                    $"('{obj.cnpj}','{obj.razao_social}','{obj.endereco}','{obj.nome_fantasia}','{obj.telefone}','{obj.ins_est}')";

                MySqlCommand exec = new MySqlCommand(query, conn);
                exec.ExecuteReader();

                listagem();

                MessageBox.Show("Deu certo");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string db = "datasource=localhost;username=root;password=1234;database=crud";
                var conn = new MySqlConnection(db);
                conn.Open();

                var id = txtbusca.Text;
                var cnpj = txtcnpj.Text;
                var razao = txtrazao.Text;
                var end = txtend.Text;
                var fantasia = txtfantasia.Text;
                var tel = txttel.Text;
                var inscricao = txtins.Text;

                var obj = new Fornecedor()
                {
                    cnpj = cnpj,
                    razao_social = razao,
                    endereco = end,
                    nome_fantasia = fantasia,
                    telefone = tel,
                    ins_est = inscricao
                };

                string query = $"UPDATE fornecedor SET cnpj = '{obj.cnpj}', razao_social = '{obj.razao_social}', endereco = '{obj.endereco}', nome_fantasia = '{obj.nome_fantasia}', telefone = '{obj.telefone}, ins_est = '{obj.ins_est}' WHERE id_fornecedor = '{id}'";

                MySqlCommand exec = new MySqlCommand(query, conn);
                exec.ExecuteReader();
                listagem();

                MessageBox.Show("Deu certo");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tablefornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public DataTable listagem()
        {
            try
            {
                DataTable tablet = new DataTable();

                string db = "datasource=localhost;username=root;password=1234;database=crud";

                var conn = new MySqlConnection(db);
                conn.Open();
                string query = "SELECT * FROM fornecedor";

                MySqlCommand exec = new MySqlCommand(query, conn);

                MySqlDataReader reader = exec.ExecuteReader();

                tablet.Load(reader);
                tablefornecedor.DataSource = tablet.DefaultView;
                // n sei pq n ta mostrando a escrita mas ta mostrando a qtde de itens q tem
                return tablet;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DataTable tablet = new DataTable();
                return tablet;
            }
        }

        private void btnprodutos_Click(object sender, EventArgs e)
        {
            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void txtbusca_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                string db = "datasource=localhost;username=root;password=1234;database=crud";
                var conn = new MySqlConnection(db);
                conn.Open();

                var id = txtbusca.Text;
                var cnpj = txtcnpj.Text;
                var razao = txtrazao.Text;
                var end = txtend.Text;
                var fantasia = txtfantasia.Text;
                var tel = txttel.Text;
                var inscricao = txtins.Text;

                var obj = new Fornecedor()
                {
                    cnpj = cnpj,
                    razao_social = razao,
                    endereco = end,
                    nome_fantasia = fantasia,
                    telefone = tel,
                    ins_est = inscricao
                };

                string query = $"DELETE FROM fornecedor WHERE id_fornecedor = '{id}'";

                MySqlCommand exec = new MySqlCommand(query, conn);
                exec.ExecuteReader();
                listagem();

                MessageBox.Show("Deu certo");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
            
 }


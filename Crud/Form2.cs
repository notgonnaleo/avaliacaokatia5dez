using Crud.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                string db = "datasource=localhost;username=root;password=1234;database=crud";
                var conn = new MySqlConnection(db);
                conn.Open();

                var id = txtbusca.Text;

                string query = $"DELETE FROM produtos WHERE id_produto = '{id}'";

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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string db = "datasource=localhost;username=root;password=1234;database=crud";
                var conn = new MySqlConnection(db);
                conn.Open();

                var cod = txtCodigo.Text;
                var desc = txtdesc.Text;
                var qtde = Convert.ToDecimal(txtqtde.Text);
                var valid = Convert.ToDateTime(dtValid.Text);
                var id = txtbusca.Text;
                var medida = txtmedida.Text;
                var tipo = txttipo.Text;
                var preco = txtpreco.Text;

                var obj = new Produtos()
                {
                    cod_prod = cod,
                    desc_produto = desc,
                    qtde = qtde,
                    dt_valid = valid,
                    preco = Convert.ToDecimal(preco)
                };

                string query = $"UPDATE produtos SET " +
                    $"cod_prod='{obj.cod_prod}'," +
                    $"'{obj.desc_produto}'," +
                    $"'{obj.qtde}'," +
                    $"'{obj.dt_valid}'," +
                    $"'{obj.preco}'," +
                    $"WHERE id_produto = {id}";


                if (tipo == "A")
                {
                    var obj2 = new Alimenticios()
                    {
                        cod_prod = cod,
                        desc_produto = desc,
                        qtde = qtde,
                        dt_valid = valid,
                        preco = Convert.ToDecimal(preco),
                        tipo = tipo,
                        medida = Convert.ToDecimal(medida)
                    };
                    string query2 = $"UPDATE produtos SET " +
                        $"cod_prod='{obj2.cod_prod}'," +
                        $"'{obj2.desc_produto}'," +
                        $"'{obj2.qtde}'," +
                        $"'{obj2.dt_valid}'," +
                        $"'{obj2.preco}'," +
                        $"'{obj2.medida}'," +
                        $"'{obj2.tipo}'" +
                        $"WHERE id_produto = {id}";


                    MySqlCommand exec = new MySqlCommand(query2, conn);
                    exec.ExecuteReader();

                    listagem();

                    MessageBox.Show("Deu certo");
                    conn.Close();
                }
                else
                {

                    MySqlCommand exec = new MySqlCommand(query, conn);
                    exec.ExecuteReader();

                    listagem();

                    MessageBox.Show("Deu certo");
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string db = "datasource=localhost;username=root;password=1234;database=crud";
                var conn = new MySqlConnection(db);
                conn.Open();

                var cod = txtCodigo.Text;
                var desc = txtdesc.Text;
                var qtde = Convert.ToDecimal(txtqtde.Text);
                var valid = Convert.ToDateTime(dtValid.Text);
                var busca = txtbusca.Text;
                var medida = txtmedida.Text;
                var tipo = txttipo.Text;
                var preco = txtpreco.Text;

                var obj = new Produtos()
                {
                    cod_prod = cod,
                    desc_produto = desc,
                    qtde = qtde,
                    dt_valid = valid,
                    preco = Convert.ToDecimal(preco)
                };

                string query = $"INSERT INTO " +
                    $"produtos(cod_prod, desc_produto, qtde, dt_valid, preco) " +
                    $"VALUES " +
                    $"('{obj.cod_prod}'," +
                    $"'{obj.desc_produto}'," +
                    $"'{obj.qtde}'," +
                    $"'{obj.dt_valid}'," +
                    $"'{obj.preco}')";

                    if (tipo == "A")
                    {
                        var obj2 = new Alimenticios()
                        {
                            cod_prod = cod,
                            desc_produto = desc,
                            qtde = qtde,
                            dt_valid = valid,
                            preco = Convert.ToDecimal(preco),
                            tipo = tipo,
                            medida = Convert.ToDecimal(medida)
                        };

                        string query2 = $"INSERT INTO " +
                            $"produtos(cod_prod, desc_produto, qtde, dt_valid, preco, medida, tipo) " +
                            $"VALUES " +
                            $"('{obj2.cod_prod}'," +
                            $"'{obj2.desc_produto}'," +
                            $"'{obj2.qtde}'," +
                            $"'{obj2.dt_valid}'," +
                            $"'{obj2.preco}'" +
                            $"'{obj2.medida}'" +
                            $"'{obj2.tipo}')";


                        MySqlCommand exec = new MySqlCommand(query2, conn);
                        exec.ExecuteReader();

                        listagem();

                        MessageBox.Show("Deu certo");
                        conn.Close();
                    }
                    else
                    {

                        MySqlCommand exec = new MySqlCommand(query, conn);
                        exec.ExecuteReader();

                        listagem();

                        MessageBox.Show("Deu certo");
                        conn.Close();
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable listagem()
        {
            try
            {
                DataTable tablet = new DataTable();

                string db = "datasource=localhost;username=root;password=1234;database=crud";

                var conn = new MySqlConnection(db);
                conn.Open();
                string query = "SELECT * FROM produtos";

                MySqlCommand exec = new MySqlCommand(query, conn);

                MySqlDataReader reader = exec.ExecuteReader();

                tablet.Load(reader);
                dataGridView1.DataSource = tablet.DefaultView;
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnfornecedor_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }
    }
}

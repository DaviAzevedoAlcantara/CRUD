using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySqlConnector;

namespace Projeto3Camadas.CODE.DAL
{
    class AcessoBancoDados
    {
        private MySqlConnection conn;
        private DataTable data;
        private MySqlDataAdapter da;
        private MySqlDataReader dr;
        private MySqlCommandBuilder cb;

        private String server = "localhost"; 
        private String user = "root";
        private String database = "db_projeto3camadas";
        private String port = "3306";
        private String password = "Dragoncity@23";

        public void Conectar()
        {
            //string connStr = "server=192.168.1.106;user=root;database=db_projeto3camadas;port=3306;password=Dragoncity@23";
            string connStr = String.Format($"server={server}; User Id={user}; database={database}; port={port}; password={password}; pooling=false");
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
                conn = new MySqlConnection(connStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a conexão!");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void ExecutarComandoSQL(string comandoSql)
        {

            try
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {

                    MySqlCommand comando = new MySqlCommand(comandoSql, conn);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Comando SQL executado com sucesso!");
                }
                else
                {
                    MessageBox.Show("conexao nao foi aberta, impossivel executar o comando sql");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao executar comando sql");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new MySqlDataAdapter(sql, conn);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);
            return data;
        }

        public MySqlDataReader RetDataReader(string sql)
        {
            MySqlCommand comando = new MySqlCommand(sql, conn);
            MySqlDataReader dr = comando.ExecuteReader();
            dr.Read();
            return dr;
        }
    }
}

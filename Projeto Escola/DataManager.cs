using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Amazon;
using System.Data.Sql;


namespace Projeto_Escola
{
    public class DataManager : SqlConnecions
    {

        public static void TestConnection(login testeconexao)
        {
            SqlConnection connection = CreateConnection();

            if (connection.State == ConnectionState.Open)
            {
                MessageBox.Show("Successfully Connection Database !");
            }
            else
            {
                MessageBox.Show("Error Connection Database !");
            }



        }

        public static void GetEscolas()
        {
            SqlConnection connection = CreateConnection();

            SqlDataReader dr = null;
            try
            {
               
                SqlCommand cmd = new SqlCommand("select * from escola", connection);
                connection.Open();
                dr = cmd.ExecuteReader();

               

                while (dr.Read())
                {
                    Console.WriteLine(dr[0]);
                    
                }
                dr.Close();

            }

            
            catch (SqlException ex)
            {
                MessageBox.Show("erro:  " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

        }

        public static void InsertEscola(String nome, Double cnpj, String endereco, Double tel)
        {
            SqlConnection connection = CreateConnection();
            
            string query = "INSERT INTO escola (cnpj, enderecoid, nome, telefone) " +
                   "VALUES (@cnpj,  @enderecoescola, @Nomeescola, @telescola) ";

            

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {

                   
                    cmd.Parameters.Add("@Nomeescola", SqlDbType.VarChar, 50).Value = nome;
                    cmd.Parameters.Add("@enderecoescola", SqlDbType.VarChar, 50).Value = 1;
                    cmd.Parameters.Add("@telescola", SqlDbType.VarChar, 50).Value = tel;
                    cmd.Parameters.Add("@cnpj", SqlDbType.VarChar, 50).Value = cnpj;
                    
                    

                    // open connection, execute INSERT, close connection
                    connection.Open();
                    SqlTransaction tran;
                   // tran = connection.BeginTransaction();
                    cmd.Connection = connection;
                  //  cmd.Transaction = tran;
                    int n = cmd.ExecuteNonQuery();
                 //   tran.Commit();
                    connection.Close();

                    MessageBox.Show("valor de nn: " + n);
                }
            }
            catch (SqlException ex)
            {
                //SqlTransaction tran = connection.BeginTransaction("MINHA TRANSAÇÃO");

               // try
               // {
               //     tran.Rollback();
               // }
               // catch (Exception exRollback)
               // {
               //     Console.WriteLine(exRollback.Message);
              //  }

              //  throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

using System.Data.SqlClient;

namespace LHPet.Models;
    class Banco
    {   
	
    private List<Clientes> lista = new List<Clientes>();
    public List<Clientes> GetLista(){
        return lista;
    }
	public Banco()
	{
	 	try
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(
                    "User ID=sa;Password=464972006;" +
                    "Server=localhost\\CYLON;" +
                    "Database=pet;" +
                    "Trusted_Connection=False;"
                    );

                    using (SqlConnection conexao = new SqlConnection(builder.ConnectionString))
                    {
                        String sql = "SELECT * FROM tblCliente";
                        using (SqlCommand comando = new SqlCommand(sql, conexao ))
                        {
                            conexao.Open();
                            using (SqlDataReader tabela = comando.ExecuteReader())
                            {

                                while(tabela.Read())
                                {
                                    lista.Add(new Clientes()
                                    {   Id = (int)tabela["id"],
                                        Nome = tabela["nome"].ToString(),
                                        Cpf = tabela["cpf"].ToString(),
                                        Email = tabela["email"].ToString(),
                                        Paciente = tabela["paciente"].ToString()
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
	}
}



    class Banco1
    {   
	
    private List<Fornecedor> lista1 = new List<Fornecedor>();
    public List<Fornecedor> GetLista1(){
        return lista1;
    }
	public Banco1()
	{
	 	try
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(
                    "User ID=sa;Password=464972006;" +
                    "Server=localhost\\CYLON;" +
                    "Database=pet;" +
                    "Trusted_Connection=False;"
                    );

                    using (SqlConnection conexao = new SqlConnection(builder.ConnectionString))
                    {
                        String sql = "SELECT * FROM tblFornecedor";
                        using (SqlCommand comando = new SqlCommand(sql, conexao ))
                        {
                            conexao.Open();
                            using (SqlDataReader tabela = comando.ExecuteReader())
                            {

                                while(tabela.Read())
                                {
                                    lista1.Add(new Fornecedor()
                                    {   Id = (int)tabela["Id"],
                                        Nome = tabela["nome"].ToString(),
                                        Cnpj = tabela["cnpj"].ToString(),
                                        Email = tabela["email"].ToString()
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
	}
}
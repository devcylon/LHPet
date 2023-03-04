namespace LHPet.Models;
public class Fornecedor{
    public int Id { get; set; }
    public String Nome { get; set; }
    public String  Cnpj { get; set; }
    public String Email { get; set; }

    public Fornecedor(int id, String nome, String cnpj, String email)
    {
        this.Id = id;
        this.Nome = nome;
        this.Cnpj = cnpj;
        this.Email = email;
    }

    public Fornecedor()
    {
    }
}
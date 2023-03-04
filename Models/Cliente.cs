namespace LHPet.Models;

public class Clientes{
    public int Id {get; set;}
    public String Nome { get; set; }
    public String Cpf { get; set; }
    public String Email { get; set; }
    public String Paciente { get; set; }

    public Clientes(int id, String nome, String cpf, String email, String paciente )
    {
        this.Id = id;
        this.Nome = nome;
        this.Cpf = cpf;
        this.Email = email;
        this.Paciente = paciente;
    }

    public Clientes()
    {
    }
}

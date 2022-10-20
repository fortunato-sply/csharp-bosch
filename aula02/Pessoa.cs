public class Pessoa
{
    public Pessoa(string nome, string senha, long cpf)
    {
        this.Nome = nome;
        this.Senha = senha;
        this.cpf = cpf;
    }

    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Senha;
    public decimal Saldo { get; set; }
    private long cpf; //campo
    public string CPF { //propriedade
        get {
            return cpf.ToString("000.000.000-00");
        }
        set {
            cpf = long.Parse(value.Replace(".", "").Replace("-", ""));
        }
    }
    
}
public class Aluno
{
    public int IdMatricula { get; set; }
    public string Name { get; set; }
    public int IdCurso { get; set; }    
    public List<float> Notas { get; set; } = new List<float>();

    public Aluno (int idMatricula, string name, int idCurso)
    {
        this.IdMatricula = idMatricula; this.Name = name; this.IdCurso = idCurso;
    }

    public void DarNotas()
    {
        int n = 1;
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Nota {n}: ");
            this.Notas.Add(float.Parse(Console.ReadLine()));
            n++;
        }
    }

    public string GetMedia()
    {
        string txt = $"Nome: {this.Name} - Média: {Notas.Sum()/Notas.Count} - Aprovado: {Notas.Sum()/Notas.Count >= 7}";
        return txt;
    }
}
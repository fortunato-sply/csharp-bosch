public class Curso
{
    public int? Id { get; set; } = null;
    public string Name { get; set; }
    public int CargaHoraria { get; set; }
    public List<Aluno> Alunos { get; set; } = new List<Aluno>();

    public Curso (int id, string name, int cargaHoraria)
    {
        this.Id = id; this.Name = name; this.CargaHoraria = cargaHoraria;
    }

    public void DarNotas()
    {
        Console.WriteLine($"Curso: {this.Name}");
        if(Alunos.Count > 0)
            foreach(Aluno aluno in Alunos)
            {
                Console.Write($"Aluno: {aluno.Name}\n");
                aluno.DarNotas();
            }
        else
            Console.WriteLine("Este curso ainda não possui alunos :(");
    }
}

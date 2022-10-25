public class Curso
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CargaHoraria { get; set; }
    public List<Aluno> Alunos { get; set; }

    public Curso (int id, string name, int cargaHoraria)
    {
        this.Id = id; this.Name = name; this.CargaHoraria = cargaHoraria;
    }

    public void DarNotas()
    {
        foreach(Aluno aluno in alunos)
        {
            aluno.DarNotas();
        }
    }
}

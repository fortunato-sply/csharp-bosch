public class Database
{
    public List<Aluno> Alunos { get; private set; } = new List<Aluno>();
    public List<Curso> Cursos { get; private set; } = new List<Curso>();

    public void AddCurso(int id, string name, int cargaHoraria)
    {
        Cursos.Add(new Curso(id, name, cargaHoraria));
    }

    public void AddAluno(int idMatricula, string name, int idCurso)
    {
        Aluno aluno = new Aluno(idMatricula, name, idCurso);
        Alunos.Add(aluno);
        
        foreach (Curso x in Cursos)
        {
            x.Id == idCurso ? x.Alunos.Add(aluno) : "";
        }
    }

    public void ListarCursos()
    {
        foreach (Curso x in Cursos)
        {
            Console.WriteLine($"ID: {x.Id} - Nome: {x.Name} - Carga Horária: {x.CargaHoraria}");
        }
    }

    public void DarNotas(int idCurso)
    {
        foreach (Curso x in Cursos)
        {
            if(x.Id == idCurso)
            {
                x.DarNotas();
            }
        }
    }

    public void GetEstatisticas(int idCurso)
    {
        foreach (Curso x in Cursos)
        {
            if(x.Id == idCurso)
            {
                foreach(Aluno a in x.Alunos)
                {
                    Console.WriteLine(a.GetMedia());
                }
            }
        }
    }
}
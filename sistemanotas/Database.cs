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
            if (x.Id == idCurso)
                x.Alunos.Add(aluno);
        }
    }

    public void ListarCursos()
    {
        if (Cursos.Count > 0)
            foreach (Curso x in Cursos)
            {
                Console.WriteLine($"ID: {x.Id} - Nome: {x.Name} - Carga Horária: {x.CargaHoraria}");
            }
        else
            Console.WriteLine("Ainda não há cursos cadastrados :(\nPressione qualquer tecla para continuar.");
            Console.ReadKey();
    }

    public void DarNotas(int idCurso)
    {
        bool have = false; 
        foreach (Curso x in Cursos)
        {
            if(x.Id == idCurso)
            {
                have = true;
                x.DarNotas();
            }
        }

        if (!have)
            Console.WriteLine("Curso não encontrado.\nPressione qualquer tecla para continuar.");
        Console.ReadKey(true);
    }

    public void GetEstatisticas(int idCurso)
    {
        Console.Clear();
        bool have = false;
        foreach (Curso x in Cursos)
        {
            if(x.Id == idCurso)
            {
                have = true;
                Console.WriteLine($"Curso: {x.Name} - N. de Alunos: {x.Alunos.Count}\n");
                foreach(Aluno a in x.Alunos)
                {
                    Console.WriteLine(a.GetMedia());
                }
            }
        }
        if (!have)
            Console.WriteLine("Curso não encontrado.\nPressione qualquer tecla para continuar.");
        Console.ReadKey(true);
    }
}
public class Menu
{
    private Database db = new Database();
    public void main()
    {
    inicio:
        string text = "--- AULAS E CURSOS ---\n1. Cadastrar novo curso\n2. Listar cursos\n3. Cadastrar alunos\n4. Dar notas\n5. Estatísticas\n\n0. Sair\n-> ";
        int choose = 0;
        while(true)
        {
            try
            {
                Console.WriteLine(text);
                choose = int.Parse(Console.ReadLine());
                break;
            } 
            catch
            {
                Console.WriteLine("Digite uma opção válida.");
            }
        }
        

        switch(choose)
        {
            case 1:
                Console.WriteLine("--- CRIAÇÃO DE NOVO CURSO ---\nID: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string name = Console.ReadLine();
                Console.WriteLine("Carga Horária: ");
                int cargaHoraria = int.Parse(Console.ReadLine());

                db.AddCurso(id, name, cargaHoraria);
                Console.WriteLine("Adicionado com sucesso!");
                goto inicio;
            
            case 2:
                db.ListarCursos();
                Console.ReadKey(true);
                goto inicio;

            case 3:
                Console.WriteLine("--- CADASTRO DE ALUNO ---\nID: ");
                int _id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string _name = Console.ReadLine();
                Console.WriteLine("ID Curso: ");
                int idCurso = int.Parse(Console.ReadLine());

                Curso.AddAluno(idCurso, new Aluno(_id, _name, idCurso));
                db.AddAluno(_id, _name, idCurso);
                Console.WriteLine($"O aluno(a) {_name} foi adicionado com sucesso! Digite qualquer tecla para continuar.");
                Console.ReadKey(true);
                goto inicio;
            
            case 4:
                Console.WriteLine("--- NOTAS POR CURSO ---\nDIGITE O ID DO CURSO: ");
                int _idCurso = int.Parse(Console.ReadLine());
                db.DarNotas(_idCurso);
                Console.WriteLine("Sucesso!");
                goto inicio;
            case 5:
                Console.WriteLine("--- ESTATISTICAS ---\nDIGITE O ID DO CURSO: ");
                int _idCurso_ = int.Parse(Console.ReadLine());
                db.GetEstatisticas(_idCurso_);
                Console.WriteLine("Sucesso!");
                goto inicio;
        }
    }
}
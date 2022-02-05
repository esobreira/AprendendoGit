namespace AprendendoGit
{
    public class Registro
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }
    }

    public enum Sexo
    {
        Masculino = 1,
        Feminino = 2
    }
}
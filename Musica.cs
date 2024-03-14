
class Musica
{
     public string nome;
     public string artista;
     public int duracao;
     public bool disponivel;

     public void ExibirFichaTecnica()
     {
        Console.WriteLine($"Nome/Artista: {nome} - {artista}");
     }
}
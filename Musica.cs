class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
     
     public Banda Artista { get; }

     public int Duracao { get; set; }

     public bool Disponivel { get; set; }

     public string? NomeCompleto { get; set; }

     public Genero? Genero { get; set; }

     public string DescricaoResumida => 
      $"A música {Nome}, pertence à banda {Artista}";

     public void ExibirFichaTecnica()
     {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Disponibilidade para o plano atual: {Disponivel}");
     }
}
class Musica
{
     public string? Nome { get; set; }
     
     public string? Artista { get; set; }

     public int Duracao { get; set; }

     public bool Disponivel { get; set; }

     public string? NomeCompleto { get; set; }

     public string DescricaoResumida => 
      $"A música {Nome}, pertence à banda {Artista}";

     public void ExibirFichaTecnica()
     {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Disponibilidade para o plano atual: {Disponivel}");
     }
}
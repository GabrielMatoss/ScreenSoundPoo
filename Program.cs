Episodio epi1 = new(1, "Técnicas de facilitação", 45);
epi1.AdicionarConvidados("Leon");
epi1.AdicionarConvidados("Luiza");

Episodio epi2 = new(3, "Técnicas de aprendizado", 50);
epi2.AdicionarConvidados("Mariana");
epi2.AdicionarConvidados("Giulia");

Episodio epi3 = new(2, "Técnicas de segurança", 25);
epi3.AdicionarConvidados("Yasmin");
epi3.AdicionarConvidados("Marcos");

Podcast podcast = new("Podcast especial", "Gabriel");
podcast.AdicionarEpisodio(epi1);
podcast.AdicionarEpisodio(epi2);
podcast.AdicionarEpisodio(epi3);

podcast.ExibirDetalhes();
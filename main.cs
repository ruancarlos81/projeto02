using System;
using System.Collections.Generic;

public class PROJETO02
{
  public enum EstadoEspiritual
  {
    Equilibrio,
    Desequilibrado,
    Ruptura
  }

  private bool pactoExuQuebrado = false;
  private bool profanouFloresta = false;
  private bool profanouRio = false;
  public void Executar()
  {
    Console.WriteLine("Mundo iniciado em equilibrio.\n");

    ProfanarFloresta();
    MentirEmPacto();
    PoluirRio();

    AtualizarEstadoEspiritual();
    VerificarManifestacoes();
  }

  void ProfanarFloresta()
  {
    Console.WriteLine("O jogador profanou a floresta.");
    profanouFloresta = true;
    dividaEspiritua += 40;
  }

  void MentirEmPacto()
  {
    Console.WriteLine("O jogador mentiu em um pacto");
    pactoExuQuebrado = true;
    dividaEspiritual += 30;
  }

  void PoluirRIo()
  {
    Console.WriteLine("O jogador poluiu um rio.");
    profanouRio = true;
    dividaEspiritual += 50;
  }

  void AtualizarEstadoEspiritual()
  {
    if (dividaEspiritual < 50)
      estadoAtual = EstadoEspiritual.Equilibrio;
    else if (dividaEspiritual < 100)
      estadoAtual = EstadoEspiritual.Desequilibrado;
    else
      estadoAtual = EstadoEspiritual.Ruptura;

    Console.WriteLine($"\nEstado espiritual do mundo: {estadoAtual}");
  }

  void VerificarManifestacoes()
  {
    Console.WriteLine("\nInimigos comuns manifestam-se:");
    Console.WriteLine("- Saci surge em redemoinhos, causando azar e doença.");

    if (profanouFloresta)
      Console.WriteLine("- Caipora observa e passa a hostilizar o jogador");
    if (pactoExuQuebrado)
      Console.WriteLine("- Exu tranca-rua fecha caminhos e consome recursos.");
    Console.WriteLine("- Boitatá ronda áreas profanadas pelo fogo.");
  }

  void ManifestarInimigosComuns()
  {
    onsole.WriteLine("\nInimigos comuns manifestam-se:");
    Console.WriteLine("- Saci surge em redemoinhos, causando azar e doença.");

    if (profanouFloresta)
      Console.WriteLine("- Caipora observa e passa a hostilizar o jogador.");
    if (pactoExuQuebrado)
      Console.WriteLine("- Exu Tranca-Rua fecha caminhos e consome recursos.");
    Console.WriteLine("- Boitatá ronda áreas profanadas pelo fogo.");
  }

  void ManifestarChefes()
  {
    Console.WriteLine("\nRUPTURA ESPIRITUAL!");
    Console.WriteLine("Chefes começam a se manifestar:");

    if (profanouFloresta)
      Console.WriteLine("- Curupira surge e desorienta o jogador até a exaustão.");
    if (profanouRio)
      Console.WriteLine("- Iara emerge e começa a afogar viajantes.");
    Console.WriteLine("- Mapinguari protege território sagrado com violência.");
    if (pactoExuQuebrado)
    {
      Console.WriteLine("- Exu Caveira manifesta-se em locais de morte.");
      Console.WriteLine("- Exu Sete Encruzilhadas impõe consequências irreversíveis.");
      Console.WriteLine("  (Não é possível vencê-lo por combate direto.)");

    }
    ManifestarEventoOrixa();

  }

  void ManifestarEventoOrixa()
  {
    Console.WriteLine("\nEvento de escala divina:");
    Console.WriteLine("- Xangô julga a corrupção estrutural.");
    Console.WriteLine("  Cidades sofrem colapso, líderes são punidos.");
    Console.WriteLine("- Yemanjá agita o mar.");
    Console.WriteLine("  Vilas costeiras são destruídas se não houver reparação.");
    Console.WriteLine("\nNenhum Orixá pode ser derrotado.");
    Console.WriteLine("A única saída é apaziguamento ritual ou abandono.");
  }
  public static void Main()
  {
    new JogoMonolitico().Executar();
  }
}
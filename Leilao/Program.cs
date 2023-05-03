
public class Program{

    public static void Main(string[] args){

        Usuario usuario1 = new Usuario("Arthur", "arthur@email.com", "123465");

        Usuario usuario2 = new Usuario();
        usuario2.setNome("Joyce");
        usuario2.setEmail("Joyce@email.com");
        usuario2.setSenha("456789");

        Usuario usuario3 = new Usuario("Ricardo", "ricardo@email.com", "123465");

        Leilao leilao = new Leilao();
        leilao.setDescricao("Leilão teste da disciplina");
        leilao.setDataLeilao(new DateOnly(2023,04,01));

        List<Lote> lotes = new List<Lote>();

        Lote lote1 = new Lote();
        lote1.setProduto("Produto 1");
        lote1.setValor(50);

        Lote lote2 = new Lote();
        lote2.setProduto("Produto 2");
        lote2.setValor(500);

        lotes.Add(lote1);
        lotes.Add(lote2);

        leilao.setLotes(lotes);

        LanceLeilao lanceUsuario1  = new LanceLeilao();
        lanceUsuario1.setLote(lote1);
        lanceUsuario1.setComprador(usuario1);
        lanceUsuario1.setValorLance(100);

        atualizarVisualizacaoLances(lote1);
        lote1.fazerLance(lanceUsuario1);

        LanceLeilao lanceUsuario2  = new LanceLeilao();
        lanceUsuario2.setLote(lote1);
        lanceUsuario2.setComprador(usuario2);
        lanceUsuario2.setValorLance(110);

        atualizarVisualizacaoLances(lote1);
        lote1.fazerLance(lanceUsuario2);

        lote1.historicoLances();

       // usuario1.historicoLances();
    }

    public static void atualizarVisualizacaoLances(Lote lote){
        Double valorLote   =  lote.checharMaiorLance();
        Console.WriteLine(valorLote == 0 ? "Nenhum lance cadastrador faça um lance maior que: " + lote.getValor() : "O maior lance é: " + valorLote);
    }
}

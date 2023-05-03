

public class Leilao{

    private string? descricao;

    private DateOnly dataLeilao;

    private List<Lote> lotes;

    public string? getDescricao()
    {
        return this.descricao;
    }

    public void setDescricao(string? descricao)
    {
        this.descricao = descricao;
    }

    public DateOnly getDataLeilao()
    {
        return this.dataLeilao;
    }

    public void setDataLeilao(DateOnly dataLeilao)
    {
        this.dataLeilao = dataLeilao;
    }

    public List<Lote> getLotes()
    {
        return this.lotes;
    }

    public void setLotes(List<Lote> lotes)
    {
        this.lotes = lotes;
    }

    public Leilao(){}

}
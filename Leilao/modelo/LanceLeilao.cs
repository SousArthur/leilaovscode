

public class LanceLeilao{

    private Usuario? comprador;

    private Double? valorLance;

    private Lote? lote;

    public Usuario? getComprador()
    {
        return (Usuario) this.comprador;
    }

    public void setComprador(Usuario? comprador)
    {
        this.comprador = comprador;
    }

    public Double? getValorLance()
    {
        return this.valorLance;
    }

    public void setValorLance(Double? valorLance)
    {
        this.valorLance = valorLance;
    }

    public Lote? getLote()
    {
        return this.lote;
    }

    public void setLote(Lote? lote)
    {
        this.lote = lote;
    }

    public LanceLeilao(){}

    public LanceLeilao(Usuario? comprador, Double? valorLance){
        this.comprador = comprador;
        this.valorLance = valorLance;
    }

}
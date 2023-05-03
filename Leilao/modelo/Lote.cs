

public class Lote{

    private string? produto;

    private double? valor;

    private List<LanceLeilao> lances = new List<LanceLeilao>();

    public string? getProduto()
    {
        return this.produto;
    }

    public void setProduto(string? produto)
    {
        this.produto = produto;
    }

    public double? getValor()
    {
        return this.valor;
    }

    public void setValor(double? valor)
    {
        this.valor = valor;
    }

    public List<LanceLeilao> getLances()
    {
        return this.lances;
    }

    public void setLances(List<LanceLeilao> lances)
    {
        this.lances = lances;
    }

    public Lote(){}


    public void fazerLance(LanceLeilao lance){
        if(lance.getValorLance() < this.valor){
            Console.WriteLine("O valor do lance precisa ser maior que o valor inicial do lote! que é: " + this.valor);
        }else{
           if(checharMaiorLance() < lance.getValorLance()){
            this.lances.Add(lance);
            lance.getComprador().getLances().Add(lance);
            Console.WriteLine("Lance efetuado com sucesso para o comprador: " + lance.getComprador().getNome());
           } else{
            Console.WriteLine("Existe um lance maior que o seu faça um lance maior que " + checharMaiorLance() + "!");
           }
        }
    }

    public Double checharMaiorLance(){
         Double maior = 0;
        if(this.lances != null && this.lances.Count() > 0){
            for(int i = 0 ; i < this.lances.Count() ; i ++){
                LanceLeilao l = this.lances[i];
                if(l.getValorLance() > maior){
                    maior = (Double) l.getValorLance();    
                }
            }
        }
        return maior;
    }

    public void historicoLances(){
        if(this.lances != null && this.lances.Count() > 0){
            foreach (LanceLeilao l in this.lances)
            {
                Console.WriteLine("O usuário: " + l.getComprador().getNome() + " fez o lance: " + l.getValorLance());
            }
        }
    }

}
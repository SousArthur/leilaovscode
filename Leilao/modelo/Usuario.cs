
public class Usuario{
    private string? nome;

    private string? email;

    private string? senha;

    private List<LanceLeilao>? lances = new List<LanceLeilao>();

    public string? getNome(){
        return this.nome;
    }

    public void setNome(string nome){
        this.nome = nome;
    }

    public string? getEmail(){
        return this.nome;
    }

    public void setEmail(string email){
        this.email = email;
    }

    public string? getSenha(){
        return this.senha;
    }

    public void setSenha(string senha){
        this.senha = senha;
    }

    public List<LanceLeilao>? getLances()
    {
        return this.lances;
    }

    public void setLances(List<LanceLeilao> lances)
    {
        this.lances = lances;
    }

    public Usuario(){}

    public Usuario(string? nome, string? email, string? senha){
        this.nome = nome;
        this.email = email;
        this.senha = senha;
    }


    public void historicoLances(){
        if(this.lances != null && this.lances.Count() > 0){
            Console.WriteLine("Sua lista de lances é :");
            foreach (LanceLeilao l in this.lances)
            {
                Console.WriteLine("Lote: " + l.getLote().getProduto() + " no valor de: " + l.getValorLance());
            }
        }
    }

}
class Funcionario {
    public string Nome { get; set; }
    public int NumeroIdentificacao { get; set; }
    public int MetaMensalVendas { get; set; }
    public int VendasFeitas { get; set; }
    public bool AtingiuMeta { get; set; }

    public Funcionario(string nome, int numeroIdentificacao, int metaMensalVendas) {
        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao;
        MetaMensalVendas = metaMensalVendas;
    }

    public override string ToString()
    {
        return $"\nNome: {Nome}\nID: {NumeroIdentificacao}\nMeta: {MetaMensalVendas}";
    }

    public void MetaAtingida() {
        if(MetaMensalVendas.Equals(VendasFeitas) || VendasFeitas > MetaMensalVendas) {
            AtingiuMeta = true;
        } else {
            AtingiuMeta = false;
        }
    }

}
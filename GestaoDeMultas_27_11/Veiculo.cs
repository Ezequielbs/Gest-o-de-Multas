public class Veiculo
{
    public int _IdVeiculo;
    private string _Niv;
    public string _placa;
    public string _NumeroMotor;
    public string _Renavam;
    public string _anoModelo;
    public string _Situacao;
    public string _Cor;
    public Cidade _Cidade;
    public Modelo Modelo;

    public void SetNiv(string niv)
    {
        try
        {
            if (niv.Length == 17)
            {
                _Niv = niv;
            }
            else
            {
                throw new Exception("O número no chassis está  inválido");
            }
        }
        catch(Exception ex) 
        {
            throw new Exception(ex.Message);
        }
    }

    public string GetNiv()
    {
        return _Niv;
    }

}
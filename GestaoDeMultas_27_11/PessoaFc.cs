using System.Text;

public class PessoaFc:Proprietario // sistyema de herança que vai buscar os dados da classi principal
{
    public int _IdPessoaFC;
    public string _Rg;
    private string _Cpf;
    public string _Sex;
    public DateOnly _DataNasc;

    public void SetCpf(string Cpf)
    {
        _Cpf = Cpf.Replace (",", ".");
        _Cpf = _Cpf.Replace("_", "");

            try
        {
            if(Cpf.Length == 17)
            {
                _Cpf = Cpf;

            }
            else
            {
                throw new Exception("CPF inválido!");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);

        }
    }

}

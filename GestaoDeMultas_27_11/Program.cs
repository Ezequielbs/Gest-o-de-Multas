int op = 0;


do
{
    Console.WriteLine("Informe uma opcão");
    op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {
        case 1:
            try
            {
                Veiculo v1 = new Veiculo();

                Console.WriteLine("Informe o id do Veiculo");
                v1._IdVeiculo = Console.ReadLine();

                Console.WriteLine("Informe a placa do Veiculo");
                string niv = Console.ReadLine();
                v1.SetNiv(niv);

                Console.WriteLine("Informe a placa do Veiculo");
                v1._placa = Console.ReadLine();

                Console.WriteLine("Informe a numeração do motor do Veiculo");
                v1._NumeroMotor = Console.ReadLine();

                Console.WriteLine("Informe o renavam do Veiculo");
                v1._Renavam = Console.ReadLine();

                Console.WriteLine("Informe o ano e modelo do Veiculo");
                v1._anoModelo = Console.ReadLine();

                Console.WriteLine("Informe a situação do Veiculo");
                v1._Situacao = Console.ReadLine();

                Console.WriteLine("Informe a cor do Veiculo");
                v1._Cor = Console.ReadLine();

                Console.WriteLine(v1.GetNiv());


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;



    }


} while (true);
namespace Televisao.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciar o objeto Box do tipo Box (classe)
            Box meo = new Box();

            if (meo == null)
            {
                System.Console.WriteLine("A box nao foi criada.");
            }
            else
            {
                System.Console.WriteLine("A box ja foi criada.");
                int op;
                do
                {
                    do
                    {
                        //System.Console.Clear();
                        System.Console.WriteLine("***** COMANDO DA BOX *****");
                        System.Console.WriteLine("1 - Ligar a Box");
                        System.Console.WriteLine("2 - Desligar a Box");
                        System.Console.WriteLine("0 - Sair");
                        System.Console.WriteLine("Escolha op: ");
                    } while (!int.TryParse(System.Console.ReadLine(), out op));
                } while (op < 0 || op > 2);

                //meo.Ligar();

                switch (op)
                {
                    case 1:

                        if (meo.Estado == false) {
                            meo.Ligar();
                            // Ir buscar a mensagem da Box
                            System.Console.WriteLine(meo.Mensagem);
                        }
                        else
                        {
                            System.Console.WriteLine("Box ja esta ligada");
                        }

                        // como a Mensagem e uma propriedade so de leitura, nao posso fazer o codigo embaixo
                        //meo.Mensagem = "Ola";
                        break;

                    case 2:
                        meo.Desligar();
                        System.Console.WriteLine(meo.Mensagem);
                        break;
                }
            }
        }
    }
}

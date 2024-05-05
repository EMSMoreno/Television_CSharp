using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisao.Console
{
    public class Box
    {
        #region Atributos

        private int _canal;

        private int _volume;

        private string _mensagem;

        private int _numeroCanais;

        private bool _estado;

        #endregion

        #region Propriedades

        public int Canal
        {
            get
            {
                return _canal;
            }

            set
            {
                if (value >= 0 && value <= _numeroCanais)
                {
                    _canal = value;
                }
            }
        }
        public int Volume
        {
            get
            {
                return _volume;
            }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    _volume = value;
                }
            }
        }

        // Propriedade so de leitura
        public string Mensagem 
        { 
            get
            {
                return _mensagem;
            }

            /*set { 
                _mensagem = value; 
            }*/
        }

        public bool Estado
        {
            get
            {
                return _estado;
            }
        }

        #endregion

        #region Metodos

        public Box()
        {
            _estado = false;
            _canal = 1;
            _volume = 50;
            _mensagem = "Box criada com sucesso";
            _numeroCanais = 10;
        }

        public Box(int numeroCanais)
        {
            _estado = false;
            _canal = 1;
            _volume = 50;
            _mensagem = "Box criada com sucesso";
            _numeroCanais = numeroCanais;
        }

        public void Ligar()
        {
            _estado = true;
            try 
            {
                LerInfo();
            } 
            catch (Exception e) 
            {
                _mensagem = e.Message;
            }
            _mensagem = "Box ligada com sucesso!";
        }

        //#endregion

        public void Desligar()
        {
            _estado = false;

            //try
           // {
                // coloco o código q quero executar
                // e q se correr mal, a culpa é externa
            //    GravarInfo();
            //}
            //catch (Exception e)
            //{
            //    _mensagem = e.Message;
            //}


            _mensagem = "Box desligada!";
        }

        private void GravarInfo()
        {
            string ficheiro = @"tvInfo.txt";

            string linha = $"{_canal};{_volume}";

            StreamWriter sw = new StreamWriter(ficheiro, false);

            if (!File.Exists(ficheiro))
            {
                sw = File.CreateText(ficheiro);
            }

            sw.WriteLine(linha);
            sw.Close();
        }

        private void LerInfo()
        {
            string ficheiro = @"tvInfo.txt";

            StreamReader sr;

            if (!File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);

                string linha = "";

                while ((linha + sr.ReadLine()) != null)
                {
                    string[] campos = new string[2];

                    campos = linha.Split(';');

                    Canal = Convert.ToInt32(campos[0]);
                    Volume = Convert.ToInt32(campos[1]);

                }// fim do while

                sr.Close();
            }
        }
           #endregion
    }
}

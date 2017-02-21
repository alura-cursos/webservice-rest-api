using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LojaAPIClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:portaDoSeuServidor/api/carrinho/1/produto/3467");
            request.Method = "DELETE";

            HttpWebResponse response = (HttpWebResponse) request.GetResponse();

            Console.Write(response.StatusCode);
            Console.Read();
        }

        static void TestaGet(string[] args)
        {
            string conteudo;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:60852/api/carrinho/1");
            request.Method = "GET";

            WebResponse response = request.GetResponse();
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                conteudo = reader.ReadToEnd();
            }

            Console.Write(conteudo);
            Console.Read();
        }
    }
}

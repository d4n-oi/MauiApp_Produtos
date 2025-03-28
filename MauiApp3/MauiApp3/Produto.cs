using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3
{
    internal class Produto
    {
        public double Preco { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }

        public ImageSource Imagem { get; set; }

        public static List<Produto> Lista
        {
            get
            {
                List<Produto> lista = new List<Produto>();
                lista.Add(new Produto() { Nome = "Buzina", Preco = 300, Categoria = "Acessórios", Descricao = "Buzina com som de trem", Estoque = 100, Imagem = ImageSource.FromFile("trem.png") });
                lista.Add(new Produto() { Nome = "Mouse", Preco = 30, Categoria = "Informática", Descricao = "Mouse com formato de rato", Estoque = 10, Imagem = ImageSource.FromFile("rato.png") });
                lista.Add(new Produto() { Nome = "Headset", Preco = 3, Categoria = "Informática", Descricao = "Headset da positivo com ratinho", Estoque = 230, Imagem = ImageSource.FromFile("headset.png") });
                lista.Add(new Produto() { Nome = "Notebook", Preco = 3000, Categoria = "Informática", Descricao = "Notebook intel I20 placa de video rtx6090", Estoque = 5 , Imagem = ImageSource.FromFile("notebook.png")});
                lista.Add(new Produto() { Nome = "Moto", Preco = 30000, Categoria = "Automóvel", Descricao = "Moto que o Max Verstappen ganhou a F12024", Estoque = 1 , Imagem = ImageSource.FromFile("carro.png") });
                lista.Add(new Produto() { Nome = "Carro", Preco = 30000, Categoria = "Automóvel", Descricao = "Carro que voa", Estoque = 40 , Imagem = ImageSource.FromFile("carrinho.png") });
                lista.Add(new Produto() { Nome = "Caminhão", Preco = 30000, Categoria = "Automóvel", Descricao = "Caminhão com fomarto de barco", Estoque = 3 , Imagem = ImageSource.FromFile("barco.png") });

                return lista;
            }
        }

    }
}

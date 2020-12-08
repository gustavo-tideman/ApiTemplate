using System;
using System.Collections.Generic;

namespace ApiTemplate.Data.Sample
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }

        public static List<Fornecedor> GerarListaDados()
        {
            var model = new List<Fornecedor>
            {
                new Fornecedor()
                {
                    Id = 1,
                    Nome = "Dell",
                    Endereco = "Avenida Paulista, 1234",
                    DataCadastro = DateTime.Now
                },

                new Fornecedor()
                {
                    Id = 2,
                    Nome = "VMWare",
                    Endereco = "Avenida Consolação, 9999",
                    DataCadastro = DateTime.Now
                },

                new Fornecedor()
                {
                    Id = 3,
                    Nome = "Microsoft",
                    Endereco = "Avenida Boa vista, 200",
                    DataCadastro = DateTime.Now
                },

                new Fornecedor()
                {
                    Id = 4,
                    Nome = "JetBrains",
                    Endereco = "Avenida Ibirapuera, 1450",
                    DataCadastro = DateTime.Now
                },

                new Fornecedor()
                {
                    Id = 5,
                    Nome = "Devart",
                    Endereco = "Avenida Rebouças, 5000",
                    DataCadastro = DateTime.Now
                }
            };
            return model;
        }

        public static Fornecedor GerarDado(int id)
        {
            var model = new Fornecedor
            {
                Id = 1,
                Nome = "Dell",
                Endereco = "Avenida Paulista, 1234",
                DataCadastro = DateTime.Now
            };

            if (id == 1)
            {
                return model;
            }
            return null;
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

public class VeterinarioController
{
    public void Listagem()
    {

        Console.WriteLine("\n --- Listagem Geral --- \n");

        var listagem = new Listagem();
			
						
			// Cadastro Listagem geral
			
			Console.Write("ID Veterinario: ");
			listagem.ID_veterinario = Console.ReadLine();

			Console.Write("Nome do Veterinario: ");
			listagem.Nome_Veterinario = Console.ReadLine();

            Console.Write("ID Cliente: ");
			listagem.ID_Cliente = Console.ReadLine();

			Console.Write("Nome do Cliente: ");
			listagem.Nome_cliente = Console.ReadLine();

			Console.Write("Endereço do cliente: ");
			listagem.Endereco_Cliente = Console.ReadLine();

            Console.Write("Telefone Cliente: ");
			listagem.Telefone_Cliente = Console.ReadLine();

            Console.Write("ID Animal: ");
			listagem.ID_animal = Console.ReadLine();	
			
			Console.Write("Data da adocao: ");
			listagem.DateTime_adocao = Console.ReadLine();

            Console.Write("Nome do animal: ");
			listagem.Nome_Animal = Console.ReadLine();

            Console.Write("Raca: ");
			listagem.Raca = Console.ReadLine();
            
            Console.Write("Peso: ");
			listagem.Peso = Console.ReadLine();

            Console.Write("Especie: ");
			listagem.Especie = Console.ReadLine();

    }
}
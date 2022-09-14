using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

public class VeterinarioController
{
    public void CadastrarVeterinario()
    {

        Console.WriteLine("\n --- Cadastrar Veterinario --- \n");

        var veterinario = new Veterinario();
			
			veterinario.IdVeterinario = Guid.NewGuid();
			
			// Cadastro Veterinario
			
			Console.Write("CRM Medico: ");
			veterinario.CRM = Console.ReadLine();
			
			Console.Write("Nome do medico: ");
			veterinario.Nome = Console.ReadLine();
			
			Console.Write("Endereço: ");
			veterinario.Endereco = Console.ReadLine();
			
			Console.Write("Data da consulta: ");
			veterinario.DateTime = Console.ReadLine();

            Console.Write("Data da cirurgia: ");
			veterinario.DateTime = Console.ReadLine();

            Console.Write("Raça do animal: ");
			veterinario.raca = Console.ReadLine();

    }
}
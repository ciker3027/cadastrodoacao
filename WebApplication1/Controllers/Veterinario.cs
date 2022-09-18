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
			
			
			// Cadastro Veterinario
			
			Console.Write("CRM Medico: ");
			veterinario.CRM = Console.ReadLine();
			
			Console.Write("Nome do medico: ");
			veterinario.Nome_Medico = Console.ReadLine();
			
			Console.Write("Endereço: ");
			veterinario.Endereco = Console.ReadLine();
			
			Console.Write("Data da consulta: ");
			veterinario.DateTime_Consulta = Console.ReadLine();

            Console.Write("Data da cirurgia: ");
			veterinario.DateTime_Cirurgia = Console.ReadLine();

            Console.Write("Raça do animal: ");
			veterinario.raca = Console.ReadLine();

    }
}
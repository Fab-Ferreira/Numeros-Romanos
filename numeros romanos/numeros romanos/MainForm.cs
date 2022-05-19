using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace numeros_romanos
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		//Variáveis
		string[] romanos1 = {"I", "X", "C", "M"}, romanos5 = {"V", "L", "D"}, romanos4 = {"IV", "XL", "CD"}, romanos9 = {"IX", "XC", "CM"};
		string numRomano;
		int i, tamanho;
		
		
		void ConvertRomanClick(object sender, EventArgs e)
		{
			try
			{
				int number = int.Parse(textDecToRom.Text);
				string sNumber = textDecToRom.Text;
			
				//Sempre esvaziar a Label após clicar no botão
				numRomano = "";
			
				//Se o número não for permitido
				if(number >= 4000 || number < 1)
				{
					MessageBox.Show("Número inválido, insira um valor entre 1 e 3999.");
				}
				
				//Se for válido
				else
				{	
					switch(sNumber.Length)
					{
						case 4: //Se o número possuir 4 algarismos
							tamanho = 3;
							break;
						
						case 3: //Se o número possuir 3 algarismos
							tamanho = 2;
							break;
						
						case 2: //Se o número possuir 2 algarismos
							tamanho = 1;
							break;
						
						case 1: //Se o número possuir 1 algarismo
							tamanho = 0;
							break;
					}
	
					for(i = 0; i < sNumber.Length; i++)
					{
						switch(sNumber[i])
						{
							case '1': //Se o algarismo de certa posição for 1
								numRomano += romanos1[tamanho - i];
								break;
							
							case '2': //Se o algarismo de certa posição for 2
								numRomano += new string(char.Parse(romanos1[tamanho - i]), 2); //Repetir determinada letra duas vezes
								break;
							
							case '3': //Se o algarismo de certa posição for 3
								numRomano += new string(char.Parse(romanos1[tamanho - i]), 3); //Repetir determinada letra três vezes
								break;
							
							case '4': //Se o algarismo de certa posição for 4
								numRomano += romanos4[tamanho - i];
								break;
							
							case '5': //Se o algarismo de certa posição for 5
								numRomano += romanos5[tamanho - i];
								break;
							
							case '6': //Se o algarismo de certa posição for 6
								numRomano += (romanos5[tamanho - i] + romanos1[tamanho - i]);
								break;
							
							case '7': //Se o algarismo de certa posição for 7
								numRomano += (romanos5[tamanho - i] + new string(char.Parse(romanos1[tamanho - i]), 2)); //Unir uma letra do vetor romanos5 com a repetição de uma letra duas vezes
								break;
							
							case '8': //Se o algarismo de certa posição for 8
								numRomano += (romanos5[tamanho - i] + new string(char.Parse(romanos1[tamanho - i]), 3)); //Unir uma letra do vetor romanos5 com a repetição de uma letra três vezes
								break;
							
							case '9': //Se o algarismo de certa posição for 9
								numRomano += romanos9[tamanho - i];
								break;
						}
					}
					labelDecToRom.Text = numRomano; //Mostrar na tela
				}
			}
			catch (Exception erro)
			{
				MessageBox.Show("Erro: " + erro.Message + " (TextBox contendo letras, caracteres especiais ou vazia)");
			}
		}
	}
}
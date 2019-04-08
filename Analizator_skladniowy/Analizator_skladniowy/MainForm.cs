/*
 * Created by SharpDevelop.
 * User: Mateusz Ratajczak
 * Date: 05.01.2018
 * Time: 22:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Analizator_skladniowy
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
			char[] cyfra1 = {'0'};											//składnia naszego języka
			char[] cyfra2 = {'1','2','3','4','5','6','7','8','9'};
			char[] cyfra3 = {'0','1','2','3','4','5','6','7','8','9'};
			char[] operacja = {'-','+','*','/','^'};
			
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		bool F_Operacja(char a, int poz)							//zwraca prawdę gdy "a" będzie znakiem
		{
			if(poz == 0)								//gdy będzie pierwsza pozycja stringa akceptujemy tylko "-"
				return (a == operacja[poz]) ? true : false; //if(a == operacja[poz]) { return true; } else { return false; }
			else										//czy znak "a" jest w tej tablicy
			{
				for(int i=0; i<operacja.Length; i++)
					if(operacja[i] == a)	
						return true;					//jeśli tak to zwróć prawdę
				
				return false;							//w przeciwnym razie zwróci fałsz
			}
		}
		bool F_Cyfra1(char a)						//zwróci prawdę gdy a jest z tablicy cyfra1 czyli de fakto kiedy a == 0
		{
			for(int i=0; i<cyfra1.Length; i++)
					if(cyfra1[i] == a)
						return true;
				return false;
		}
		bool F_Cyfra2(char a)					// zwróci prwdę jeśli a jest cyfrą z tablicy cyfra2
		{
			for(int i=0; i<cyfra2.Length; i++)
					if(cyfra2[i] == a)
						return true;
				return false;
		}
		bool F_Cyfra3(char a)					//zwróci prawdę jeśli a jest cyfra z tablicy cyfra3
		{
			for(int i=0; i<cyfra3.Length; i++)
					if(cyfra3[i] == a)
						return true;
				return false;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			bool czy_ok = true;					//zmienna określająca czy całość jest dobra 
			bool czy_operacja = false;			//poszczególne operacje - określają stan elementu występującego porzednio czyli
			bool czy_cyfra1 = false;			//jeśli przed elemenetem który teraz analizujemy był "+" to zmienna czy_operacja
			bool czy_cyfra2 = false;			//przyjmie wartość true
			bool czy_cyfra3 = false;
			//char jaka_operacja = ' ';
				
			string zawartosc = textBox1.Text;
			
			if(zawartosc == "")						
				textBox2.Text = "Wpis wyrażenie";
			else
			{	
				for(int i=0; i<zawartosc.Length; i++)	//lecimy przez całe wyrażenie
				{
					if(i == 0)							//na pierwszym miejscu może być ....
					{
						czy_operacja = F_Operacja(zawartosc[i],i); //to zwróci prawdę gdy tylko minus
						czy_cyfra2 = F_Cyfra2(zawartosc[i]);
						czy_cyfra1 = F_Cyfra1(zawartosc[i]);
						
						if(czy_operacja || czy_cyfra2 || czy_cyfra1)	// ... cyfra 0-9 lub minus
							continue;
						else											//w przeciwnym razie przerwij
						{
							czy_ok = false;
							break;
						}
					}
					else
					{
						if(czy_operacja) 						//gdy poprzednio pojawił się operator
						{
							czy_cyfra2 = F_Cyfra2(zawartosc[i]);
							czy_cyfra1 = F_Cyfra1(zawartosc[i]);
							if(czy_cyfra2 || czy_cyfra1)		//to teraz musi być cyfra
							{
								czy_operacja = false;
								continue;
							}
							else							//jak nie to wyrzuć
							{
								czy_ok = false; 
								break;
							}
						}//if(czy_operacja)
						else
						{
							if(czy_cyfra1)				//jeśli poprzednio było zero
							{
								czy_cyfra2 = F_Cyfra2(zawartosc[i]); //tego nie musimy wyznaczać ale niech będzie 
								czy_cyfra1 = F_Cyfra1(zawartosc[i]);
								czy_operacja = F_Operacja(zawartosc[i],i);
								
								if(czy_operacja)		//to teraz dopuszczamy tylko operator
								{
									continue;	
								}
								else
								{
									czy_ok = false;
									break;
								}
							
							}
							else
							{
								if(czy_cyfra2 || czy_cyfra3) //jeśli cyfra od 0 - 9
								{
									czy_cyfra3 = F_Cyfra3(zawartosc[i]);
									czy_operacja = F_Operacja(zawartosc[i],i);
									
									
									
									if(czy_cyfra3 || czy_operacja)  //jeśli jest cyfra lub operator jedź dalej
										continue;
									else							//przerwij
									{
										czy_ok = false;
										break;
									}
								}//if(czy_cyfra2 || czy_czyfra3)
							}
						}
					}//else	
				}//for
				
				if(czy_operacja)  //jeśli by została na końcu operacja na true tzn. że kończy się na operatorze to będne
					czy_ok = false;
				
				
				//uzupełnienie textboxa
				if(czy_ok)
					textBox2.Text = "Wyrażenie jest poprawne :) ";
				else
					textBox2.Text = "Wyrażenie jest błędne :(";
			
			}
		}
	}
}

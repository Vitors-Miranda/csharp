/*
 * Created by SharpDevelop.
 * User: LUANA
 * Date: 26/08/2021
 * Time: 14:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TAREFA_DIA26
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		
		//exercício1 ------
		void Btn_calc_tab1Click(object sender, EventArgs e)
		{
			int valor1;
			valor1= int.Parse(tb_tab1.Text);
			if (valor1 > 0){
				lbl_resultado_Tab1.Text= "O valor é positivo!";
			}else if(valor1 < 0){
				lbl_resultado_Tab1.Text= "O valor é negativo!";
			}else{
					lbl_resultado_Tab1.Text= "O valor é nulo!";
				}
		}
		//exercício2 ------
		
		void Btn_calc_tab2Click(object sender, EventArgs e)
		{
			int valor1;
			valor1= int.Parse(tb_tab2.Text);
			if (valor1 == 0){
				lbl_resultado_tab2.Text= "O valor é nulo!";
			}else if(valor1 % 2 != 0){
				lbl_resultado_tab2.Text= "O valor é impar!";
			}else{
				lbl_resultado_tab2.Text= "O valor é par!";
				}
		}
		//exercício3 -----
		
		
		
		void Btn_calc_tab3Click(object sender, EventArgs e)
		{
			double valor1, dobro, metade;
			
			valor1= int.Parse(tb_tab3.Text);
			dobro= valor1 * 2 ;
			metade= valor1 / 2;
			lbl_resultado_dobro.Text= dobro.ToString();
			lbl_resultado_metade.Text= metade.ToString();
		}
		//exercício4 -----
		
		
		void Btn_calc_tab4Click(object sender, EventArgs e)
		{
			int valor1, antecessor, sucessor;
		
			valor1= int.Parse(tb_tab4.Text);
			antecessor= valor1 - 1;
			sucessor= valor1 + 1;
			lbl_suc_tab4.Text= sucessor.ToString();
			lbl_ant_tab4.Text= antecessor.ToString();
		}
		//exercício5 -----
		
		
		void Btn_calc_tab5Click(object sender, EventArgs e)
		{
			double v1,v2,  media;
			string mensagem;
			v1= double.Parse(tb_v1_tab5.Text);
			v2= double.Parse(tb_v2_tab5.Text);
			media= (v1 + v2)/2;
			
			if(media >= 5){
				mensagem= ". Aprovado! :)";
				lbl_resultado_tab5.ForeColor= Color.Cyan;
			}else{
				mensagem= ". Reprovado! :(";
				lbl_resultado_tab5.ForeColor= Color.Red;
			}
			lbl_resultado_tab5.Text= "Média: "+ media.ToString()+ mensagem;
		}
		//exercício6 -----
		
		
		void Btn_calc_tab6Click(object sender, EventArgs e)
		{
			int v1,v2;
			v1= int.Parse(tb_v1_tab6.Text);
			v2= int.Parse(tb_v2_tab6.Text);
			
			if(v1 == v2){
				lbl_resultado_tab6.Text= "Valores iguais!";
			}else{
				lbl_resultado_tab6.Text= "Valores diferentes!";
			}
		}
		//exercício7 -----
		
		void Btn_calc_tab7Click(object sender, EventArgs e)
		{
			int v1,v2;
			v1= int.Parse(tb_v1_tab7.Text);
			v2= int.Parse(tb_v2_tab7.Text);
			
			if (v1 == v2){
				lbl_resultado_tab7.Text= "Valores iguais.";
			}else if (v1 > v2){
				lbl_resultado_tab7.Text= "Primeiro valor("+ v1 +") é maior.";
			}else{
				lbl_resultado_tab7.Text= "Segundo valor("+ v2 +") é maior.";
			}
		}
		//exercício final -----
		
		
		void Btn_calc_tab8Click(object sender, EventArgs e)
		{
			//RESETAR CASO JÁ TENHA USADO
			lbl_hotel.Text = "Gastos com hotel: ";
			lbl_combustivel_total.Text = "Gastos com combustível: ";
			lbl_duracao.Text =" Duração (80km/h): ";
			lbl_totais.Text = "Gastos totais: ";
			
			
			//DECLARAÇÃO DE VARIÁVEIS
			double diaria, dias, gasolina, consumo, distancia, gasolinaTotal, hotel, 
			duracao, total; 
			int orcamento= 500;
			
			//CONVERSÃO DOS VALORES
			diaria= double.Parse(tb_diaria.Text);
			dias= double.Parse(tb_dias.Text);
			gasolina= double.Parse(tb_gasolina.Text);
			consumo= double.Parse(tb_consumo.Text);
			distancia= double.Parse(tb_distancia.Text);
			
			//CÁLCULO E EXIBIÇÃO DOS GASTOS COM HOTEL 
			hotel= diaria*dias;
			lbl_hotel.Text += "R$ "+hotel.ToString();
			lbl_hotel.Visible=true;
			
			//CÁLCULO E EXIBIÇÃO DOS GASTOS COM GASOLINA
			gasolinaTotal= gasolina*consumo;
			lbl_combustivel_total.Text += "R$ " + gasolinaTotal.ToString();
			lbl_combustivel_total.Visible=true;
			
			//CÁLCULO E EXIBIÇÃO DA DURAÇÃO
			duracao= (distancia/80)*60;
			lbl_duracao.Text += duracao.ToString() + " min.";
			lbl_duracao.Visible= true;
			
			//CÁLCULO E EXIBIÇÃO DOS GASTOS TOTAIS
			total= hotel+ gasolinaTotal;
			lbl_totais.Text += "R$ "+  total.ToString();
			lbl_totais.Visible= true;
			
			//CÁLCULO E EXIBIÇÃO DO ORÇAMENTO
			lbl_orcamento.Visible= true;	
			if(total>orcamento){
				lbl_orcamento.ForeColor= Color.Red;
				lbl_orcamento.Text = "Viagem fora do orçamento!";
			} else{
				lbl_orcamento.Text= "Viagem dentro do orçamento!";
				lbl_orcamento.ForeColor= Color.Cyan;
			}
		}
		
	}
}

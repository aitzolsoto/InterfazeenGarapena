using System;

public class Esaldia
{
	private string esaldiGuztia;
	public Esaldia()
	{
	}

	public string getEsaldiaBatuta()
	{
		return esaldiGuztia;
	}

	public void setEsaldiaBatuta(string jasotakoEsaldia)
	{
		esaldiGuztia = esaldiGuztia + " " + jasotakoEsaldia;
	}

	public void EsaldiaEzabatu()
	{
		esaldiGuztia = "";
	}
}

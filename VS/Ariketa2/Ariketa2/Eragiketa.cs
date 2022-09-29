using System;

public class Eragiketa
{

	public float a { get; set; }
	public float b { get; set; }
	public float c { get; set; }
    public float d { get; set; }
    private float emaitza;

	public Eragiketa()
	{
	}

	public string eragiketaErakutsi()
	{
		emaitza = (a + (2 * b) + (3 * c) + (4 * d))/4;
		return "(" + a + " + (2 x " + b + ") + (3 x " + c + ") + (4 x " + d + ")) / 4 = " + emaitza;
	}


}

using System;

public class verificaClave
{
	public verificaClave()
	{

	}
    static void Main(string[] args)
    {
        string pass = "miPassword";
        string hash = encriptarClave.GetHash(pass);
        Console.WriteLine(hash);
        bool isValid = encriptarClave.ValidatePass("miPassword2", hash);
        Console.WriteLine(isValid ? "válida" : "no válida");
        MessageBox.show("asd");     
    }
}

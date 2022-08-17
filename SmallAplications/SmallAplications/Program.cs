Console.WriteLine(fibonacci(10, 0, 1));
Console.WriteLine(calculadoraSimples(10, 2, "dividir"));

string fibonacci(int x, int y, int z)
{
    return y < x ? (Convert.ToString(y) + "\n") + fibonacci(x, z, y + z) : "";
    //return x <= 1 ? 1 : fibonacci(x - 1) + fibonacci(x - 2);
}

string calculadoraSimples(int x, int y, string choose)
{
    return true ? (choose == "somar" ? Convert.ToString(x + y):"") + (choose == "diminuir" ? Convert.ToString(x - y): "") + (choose == "multiplicar" ? Convert.ToString(x * y): "") + (choose == "dividir" ? Convert.ToString(x / y): "") : "Saida";
}
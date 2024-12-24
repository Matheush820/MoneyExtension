namespace MoneyExtension;

public static class Money
{
    public static int ToCents(this decimal amount)
    {
        if (amount < 0)
            return 0;

        // Converte o valor decimal para string com duas casas decimais
        var text = amount.ToString("F2").Replace(",", "").Replace(".", "");

        if (string.IsNullOrEmpty(text))
            return 0;

        // Tenta converter a string para inteiro
        if (int.TryParse(text, out var result))
            return result;

        return 0; // Retorna 0 caso a conversão falhe
    }
}

using System;
using System.Collections.Generic;

public class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
}

public class Evento
{
    public string Id 
    public string Titulo { get; set; }
    public DateTime Data { get; set; }
    public DateTime Horaini { get; set; }
    public DateTime HoraFim { get; set; }
    public string Descricao { get; set; }
    public int QuantidadePessoas { get; set; }
    public string PublicoAlvo { get; set; }
    public Contato Responsavel { get; set; }

    public Evento()
    {
        
        Id = GerarId();
    }

    private string GerarId()
    {
        
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        return new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());
    }
}

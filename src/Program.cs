

public class Program
{
    public static void Main(string[] args)
    {
       
        var summary = BenchmarkRunner.Run<MyBenchmark>();
    }
  
}

[MemoryDiagnoser]
public class MyBenchmark
{
    private const string _jsonStringPascalCase = "{\"Stringa\" : \"abc\", \"Intero\" : 123, \"Lista\" : [\"abcd\", \"1234\"]}";
    private const string _jsonStringCamelCase = "{\"Stringa\" : \"abc\", \"Intero\" : 123, \"Lista\" : [\"abcd\", \"1234\"]}";

    [Benchmark]
    
    public Classe SystemText() => JsonSerializer.Deserialize<Classe>(_jsonStringPascalCase);
    
    [Benchmark]    
    public void NewtosNewtonsoft() => Newtonsoft.Json.JsonConvert.DeserializeObject<Classe>(_jsonStringCamelCase);
    

}

public class Classe
{
    public int Intero { get; set; }

    public string? Stringa { get; set; }

    public List<string>? Lista { get; set; }
}





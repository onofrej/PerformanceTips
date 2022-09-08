using BenchmarkDotNet.Running;
using PerformanceTips.Benchmarks;

//BenchmarkRunner.Run(typeof(IntroArgumentsSource));
BenchmarkRunner.Run(typeof(TaskReturnComparison));
//BenchmarkRunner.Run(typeof(GetUserInfoUseCase));
//BenchmarkRunner.Run(typeof(ListSizeComparison));

//[MemoryDiagnoser, RankColumn]
//public class GetUserInfoUseCase //: IGetUserInfoUseCase
//{
//    //[ParamsSource(nameof(ValuesForDetalhes))]
//    //public List<DetalheProdutoResponse> Detalhes => new Fixture().CreateMany<DetalheProdutoResponse>(100).ToList();

//    [ParamsSource(nameof(ValuesForDetalhes))]
//    public List<DetalheProdutoResponse> Detalhes
//    {
//        get { return new Fixture().CreateMany<DetalheProdutoResponse>(100).ToList(); }
//        set
//        {
//            Detalhes = value;
//        }
//    }

//    public List<DetalheProdutoResponse> ValuesForDetalhes
//        => new Fixture().CreateMany<DetalheProdutoResponse>(100).ToList();

//    [Benchmark]
//    public TesouroDiretoResponse BenchWithAddRange()
//    {
//        TesouroDiretoResponse entidade = new TesouroDiretoResponse()
//        {
//            ListaProdutosTesouroDireto1 = new List<DetalheProdutoResponse>()
//        };

//        entidade.ListaProdutosTesouroDireto1.AddRange(Detalhes.Select(x => new DetalheProdutoResponse()
//        {
//            Codigo = x.Codigo,
//            Nome = x.Nome,
//            Valor = x.Valor,
//            Quantidade = 1
//        }));

//        return entidade;
//    }

//    [Benchmark]
//    public TesouroDiretoResponse BenchWithSetList()
//    {
//        TesouroDiretoResponse entidade = new TesouroDiretoResponse()
//        {
//            ListaProdutosTesouroDireto1 = Detalhes.Select(x => new DetalheProdutoResponse()
//            {
//                Codigo = x.Codigo,
//                Nome = x.Nome,
//                Valor = x.Valor,
//                Quantidade = 1
//            }).ToList()
//        };

//        return entidade;
//    }

//    [Benchmark]
//    public TesouroDiretoResponse BenchWithYieldReturn()
//    {
//        TesouroDiretoResponse entidade = new TesouroDiretoResponse()
//        {
//            ListaProdutosTesouroDireto2 = RetornaLista(Detalhes)
//        };

//        return entidade;
//    }

//    public IEnumerable<DetalheProdutoResponse> RetornaLista(List<DetalheProdutoResponse> detalhes)
//    {
//        foreach (var x in Detalhes)
//        {
//            yield return new DetalheProdutoResponse()
//            {
//                Codigo = x.Codigo,
//                Nome = x.Nome,
//                Valor = x.Valor,
//                Quantidade = 1
//            };
//        }
//    }

//    //private readonly IUserData _data;

//    //public GetUserInfoUseCase() => _data = new UserData();

//    ////[Benchmark]
//    //public async Task<string> ExecuteAsync()
//    //{
//    //    return await _data.GetDataAsync();
//    //}

//    ////[Benchmark]
//    //public Task<string> ExecuteElidingAsync()
//    //{
//    //    return _data.GetDataAsync();
//    //}

//    //[Benchmark]
//    //public async Task<string> FromResultAwait()
//    //{
//    //    return await Task.FromResult("Test");
//    //}

//    //[Benchmark]
//    //public Task<string> FromResult()
//    //{
//    //    return Task.FromResult("Test");
//    //}

//    //[Benchmark]
//    //public List<string> ListWithSize()
//    //{
//    //    var a = new List<string>(10);

//    //    foreach (var i in "1234567890")
//    //    {
//    //        a.Add(i.ToString());
//    //    }

//    //    return a;
//    //}

//    //[Benchmark]
//    //public List<string> ListWithoutSize()
//    //{
//    //    var a = new List<string>();

//    //    foreach (var i in "1234567890")
//    //    {
//    //        a.Add(i.ToString());
//    //    }

//    //    return a;
//    //}
//}